using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Strengthify;
using Strengthify.Models;
using StrengthifyNETAPI.Dto;
using System.Text.Json;
using StrengthifyNETAPI.Services;

namespace StrengthifyNETAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        public UserController(StrengthifyContext context, IHttpClientFactory httpClientFactory, UserService userService)
        {
            _userService = userService;
        }

        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserReadDto>>> GetUsers()
        {
            return Ok(await _userService.GetAllUsersAsync());
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            User user = await _userService.GetUserByIdAsync(id);

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
            var httpResponseMessage = await _userService.CreateSupabaseUserAsync(user.Email, user.Password);
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
            User newUser = await _userService.CreateUserAsync(user, signUpResponse.user.id, birthDate);

            return CreatedAtAction("GetUser", new { id = newUser.UserId }, new { refresh_token = signUpResponse.refresh_token });
        }
    }
}
