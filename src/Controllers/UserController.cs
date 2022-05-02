using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using StrengthifyNETAPI.Models;
using StrengthifyNETAPI.Dto;
using System.Text.Json;
using StrengthifyNETAPI.Repositories;

namespace StrengthifyNETAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUsersRepository _UsersRepository;
        public UserController(IUsersRepository UsersRepository)
        {
            _UsersRepository = UsersRepository;
        }

        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserReadDto>>> GetUsers()
        {
            return Ok(await _UsersRepository.GetAllUsersAsync());
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            User user = await _UsersRepository.GetUserByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // POST: api/User
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserWriteDto>> PostUser(UserWriteDto user)
        {
            // Validate date of birth
            DateTime birthDate = DateTime.MinValue;
            try
            {
                birthDate = DateTime.SpecifyKind(DateTime.Parse(user.DateOfBirth).Date, DateTimeKind.Utc);
            }
            catch
            {
                return BadRequest("Date of Birth is invalid.");
            }

            // Sign up user to supabase
            var httpResponseMessage = await _UsersRepository.CreateSupabaseUserAsync(user.Email, user.Password);
            SupabaseSignupResponseDto signUpResponse = new SupabaseSignupResponseDto();
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();
                signUpResponse = await JsonSerializer.DeserializeAsync<SupabaseSignupResponseDto>(contentStream);
            }
            else
            {
                return BadRequest("An error occurred while registering a new user.");
            }

            // create new user
            User newUser = await _UsersRepository.CreateUserAsync(user, signUpResponse.user.id, birthDate);

            return CreatedAtAction("GetUser", new { id = newUser.UserId }, new UserWriteResultDto { refresh_token = signUpResponse.refresh_token });
        }
    }
}
