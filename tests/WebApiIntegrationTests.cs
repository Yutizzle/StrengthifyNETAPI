using System.Linq;
using Xunit;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using StrengthifyNETAPI.Dto;
using System.Text;
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
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(JwtBearerDefaults.AuthenticationScheme, Environment.GetEnvironmentVariable("REQUEST_JWT"));
        }

        [Fact]
        public async Task UsersRoute_ReturnsAllUsers()
        {
            // Arrange
            Guid user1Uuid = new Guid("29ed5754-b19a-41fb-a902-6503717850a1");
            Guid user2Uuid = new Guid("37e9433e-3cfe-43bf-a26e-82f41cc20dbc");

            // Act
            var response = await _httpClient.GetAsync("/api/Users");
            var responseContent = await response.Content.ReadAsStreamAsync();
            List<UserReadDto> responseList = await JsonSerializer.DeserializeAsync<List<UserReadDto>>(responseContent, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

            // Assert
            Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)response.StatusCode);
            Assert.NotNull(responseContent);
            Assert.Equal(user1Uuid, responseList.Find(x => x.Uuid == user1Uuid).Uuid);
            Assert.Equal(user2Uuid, responseList.Find(x => x.Uuid == user2Uuid).Uuid);
        }

        [Fact]
        public async Task PutProgramRoute_AddNewWorkoutToExistingProgram_ReturnsNewWorkout()
        {
            // Arrange
            List<WorkoutUpdateDto> updateWorkouts = new List<WorkoutUpdateDto> {
                new WorkoutUpdateDto
                {
                    WorkoutId = 2,
                    WorkoutKey = "2",
                    WorkoutName = "Test Workout",
                    SequenceNum = 0,
                    CycleDayNum = 1
                },
                new WorkoutUpdateDto
                {
                    WorkoutId = 0,
                    WorkoutKey = "workout-0",
                    WorkoutName = "New Workout",
                    SequenceNum = 0,
                    CycleDayNum = 1
                }

            };

            List<ExerciseUpdateDto> updateExercises = new List<ExerciseUpdateDto>
            {
                new ExerciseUpdateDto
                {
                    WorkoutExerciseId = 3,
                    ExerciseKey = "3",
                    Exercise = "Test Exercise 1",
                    WorkoutKey = "0",
                    SequenceNum = 0
                },
                new ExerciseUpdateDto
                {
                    WorkoutExerciseId = 0,
                    ExerciseKey = "exercise-0",
                    Exercise = "Test Exercise 2",
                    WorkoutKey = "workout-0",
                    SequenceNum = 0
                }
            };

            List<SetUpdateDto> updateSets = new List<SetUpdateDto>
            {
                new SetUpdateDto
                {
                    WorkoutExerciseDetailId = 4,
                    WorkoutKey = "2",
                    ExerciseKey = "3",
                    Set = 1,
                    Reps = 5,
                    Weight = 100,
                    SetDuration = 0,
                    SetRestDuration = 0,
                    MaxReps = 0,
                    MaxWeight = 0,
                    MaxSetDuration  = 0,
                    RepsIncrementFrequencyId  = 0,
                    WeightIncrementFrequencyId  = 0,
                    SetDurationIncrementFrequencyId  = 0,
                    RepsIncrementAmount  = 0,
                    WeightIncrementAmount  = 0,
                    SetDurationIncrementAmount  = 0,
                },
                new SetUpdateDto
                {
                    WorkoutExerciseDetailId = 0,
                    WorkoutKey = "workout-0",
                    ExerciseKey = "exercise-0",
                    Set = 1,
                    Reps = 5,
                    Weight = 100,
                    SetDuration = 0,
                    SetRestDuration = 0,
                    MaxReps = 0,
                    MaxWeight = 0,
                    MaxSetDuration  = 0,
                    RepsIncrementFrequencyId  = 0,
                    WeightIncrementFrequencyId  = 0,
                    SetDurationIncrementFrequencyId  = 0,
                    RepsIncrementAmount  = 0,
                    WeightIncrementAmount  = 0,
                    SetDurationIncrementAmount  = 0,
                }
            };

            ProgramUpdateDto updateProgram = new ProgramUpdateDto
            {
                ProgramId = 1,
                ProgramName = "Test Program",
                UserUuid = new Guid("29ed5754-b19a-41fb-a902-6503717850a1"),
                Workouts = updateWorkouts.ToArray(),
                Exercises = updateExercises.ToArray(),
                Sets = updateSets.ToArray(),
            };

            var payload = new StringContent(JsonSerializer.Serialize(updateProgram, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }), Encoding.UTF8, "application/json");

            Console.WriteLine(await payload.ReadAsStringAsync());

            // Act
            var response = await _httpClient.PutAsync("/api/Programs", payload);
            var responseContent = await response.Content.ReadAsStreamAsync();
            ProgramReadFullDto responseList = await JsonSerializer.DeserializeAsync<ProgramReadFullDto>(responseContent, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            List<WorkoutUpdateDto> updatedWorkouts = responseList.Workouts
                .Select(x => new WorkoutUpdateDto
                {
                    WorkoutId = x.WorkoutId,
                    WorkoutKey = x.WorkoutKey,
                    WorkoutName = x.WorkoutName,
                    SequenceNum = x.SequenceNum,
                    CycleDayNum = x.CycleDayNum
                })
                .ToList();

            // Assert
            Assert.Equal(HttpStatusCode.Created, (HttpStatusCode)response.StatusCode);
            Assert.NotNull(responseContent);
            Assert.True(updatedWorkouts.FirstOrDefault(x => x.WorkoutName == "New Workout").WorkoutId > 0);

        }
    }
}