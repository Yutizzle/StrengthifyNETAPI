using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Strengthify;
using Strengthify.Models;
using StrengthifyNETAPI.Dto;
using System.Text.Json;

namespace StrengthifyNETAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly StrengthifyContext _context;
        private readonly IHttpClientFactory _httpClientFactory;
        public UserController(StrengthifyContext context, IHttpClientFactory httpClientFactory)
        {
            _context = context;
            _httpClientFactory = httpClientFactory;
        }

        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserReadDto>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            List<UserReadDto> userDto = new List<UserReadDto>();
            foreach (var user in users)
            {
                userDto.Add(new UserReadDto
                {
                    Uuid = user.Uuid,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    DateOfBirth = user.DateOfBirth
                });
            }

            return userDto;
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/User/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.UserId)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
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
            var httpClient = _httpClientFactory.CreateClient("SupabaseAuth");
            var payload = new StringContent(JsonSerializer.Serialize(new { email = user.Email, password = user.Password }), Encoding.UTF8, Application.Json);
            var httpResponseMessage = await httpClient.PostAsync("signup", payload);
            SupabaseSignupResponseDto signUpResponse = new SupabaseSignupResponseDto();
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();
                signUpResponse = await JsonSerializer.DeserializeAsync<SupabaseSignupResponseDto>(contentStream);
            }
            else
            {
                return BadRequest(new { message = "An error occurred while registering a new user.", httpResponseMessage });
            }

            // Build new User model
            var newUser = new User
            {
                Uuid = signUpResponse.user.id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                DateOfBirth = birthDate,
                Email = user.Email
            };

            // Create new user in database
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            // Update CreatedById
            newUser.CreatedById = newUser.UserId;
            _context.Users.Update(newUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = newUser.UserId }, new { refresh_token = signUpResponse.refresh_token });
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}
