using Xunit;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Net;
using System.Net.Http;
using StrengthifyNETAPI.Dto;
using System.Text.Json;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace StrengthifyNETAPI.Tests
{
    public class WebApiIntegrationTests
    {
        private HttpClient _httpClient;
        public WebApiIntegrationTests()
        {
            var _webAppFactory = new CustomWebApplicationFactory<Startup>();
            _httpClient = _webAppFactory.CreateClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(JwtBearerDefaults.AuthenticationScheme, Environment.GetEnvironmentVariable("REQUEST_JWT"));
        }
        [Fact]
        public async Task UsersRoute_ReturnsAllUsers()
        {
            // Arrange
            Guid user1Uuid = new Guid("29ed5754-b19a-41fb-a902-6503717850a1");
            Guid user2Uuid = new Guid("29ed5754-b19a-41fb-a902-6503717850a2");
            Guid user3Uuid = new Guid("29ed5754-b19a-41fb-a902-6503717850a3");

            // Act
            var response = await _httpClient.GetAsync("/api/Users");
            var responseContent = await response.Content.ReadAsStreamAsync();
            List<UserReadDto> responseList = await JsonSerializer.DeserializeAsync<List<UserReadDto>>(responseContent, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

            // Assert
            Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)response.StatusCode);
            Assert.NotNull(responseContent);
            Assert.Equal(user1Uuid, responseList.Find(x => x.Uuid == user1Uuid).Uuid);
            Assert.Equal(user2Uuid, responseList.Find(x => x.Uuid == user2Uuid).Uuid);
            Assert.Equal(user3Uuid, responseList.Find(x => x.Uuid == user3Uuid).Uuid);
        }
    }
}