using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StrengthifyNETAPI.Models;
using StrengthifyNETAPI.Dto;
using System.Text.Json;

namespace StrengthifyNETAPI.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly StrengthifyContext _context;
        private readonly IHttpClientFactory _httpClientFactory;
        public UsersRepository(StrengthifyContext context, IHttpClientFactory httpClientFactory)
        {
            _context = context;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<UserReadDto>> GetAllUsersAsync()
        {
            List<User> users = await _context.Users.ToListAsync();
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

            return userDto.AsEnumerable();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }
        public async Task<User> GetUserByUuidAsync(Guid uuid)
        {
            return await _context.Users.SingleOrDefaultAsync(x => x.Uuid == uuid);
        }

        public async Task<int> PutUser(int id, User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return id;
        }

        public async Task<HttpResponseMessage> CreateSupabaseUserAsync(string email, string password)
        {
            // Sign up user to supabase
            var httpClient = _httpClientFactory.CreateClient("SupabaseAuth");
            var payload = new StringContent(JsonSerializer.Serialize(new { email = email, password = password }), Encoding.UTF8, Application.Json);
            return await httpClient.PostAsync("signup", payload);
        }

        public async Task<User> CreateUserAsync(UserWriteDto user, Guid Uuid, DateTime birthDate)
        {
            // Build new User model
            var newUser = new User
            {
                Uuid = Uuid,
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
            newUser.UpdatedById = newUser.UserId;
            _context.Users.Update(newUser);
            await _context.SaveChangesAsync();

            return newUser;
        }
    }
}
