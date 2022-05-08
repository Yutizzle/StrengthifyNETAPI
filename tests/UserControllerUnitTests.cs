using Xunit;
using Moq;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using System.Text.Json;
using StrengthifyNETAPI.Controllers;
using StrengthifyNETAPI.Models;
using StrengthifyNETAPI.Repositories;
using StrengthifyNETAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace StrengthifyNETAPI.Tests;

public class UsersController_UnitTests
{
    [Fact]
    public async Task GetUsers_TwoUsers_ReturnsBothUsers()
    {
        // Arrange
        UserReadDto user1 = new UserReadDto
        {
            Uuid = Guid.NewGuid(),
            FirstName = "FirstNameTest1",
            LastName = "LastNameTest1",
            Email = "email1@email.com",
            DateOfBirth = DateTime.UtcNow
        };
        UserReadDto user2 = new UserReadDto
        {
            Uuid = Guid.NewGuid(),
            FirstName = "FirstNameTest2",
            LastName = "LastNameTest2",
            Email = "email2@email.com",
            DateOfBirth = DateTime.UtcNow
        };
        List<UserReadDto> allUsers = new List<UserReadDto> { user1, user2 };
        var userRepositoryMock = new Mock<IUsersRepository>();
        var programsRepositoryMock = new Mock<IProgramsRepository>();
        var controller = new UsersController(userRepositoryMock.Object, programsRepositoryMock.Object);
        userRepositoryMock
            .Setup(_ => _.GetAllUsersAsync())
            .ReturnsAsync(allUsers.AsEnumerable())
            .Verifiable();

        // Act   
        ActionResult<IEnumerable<UserReadDto>> actionResult = await controller.GetUsers();
        OkObjectResult resultObj = actionResult.Result as OkObjectResult;
        List<UserReadDto> resultValue = resultObj.Value as List<UserReadDto>;

        // Assert
        Assert.IsType<OkObjectResult>(actionResult.Result);
        Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)resultObj.StatusCode);
        Assert.NotNull(resultValue);
        Assert.Contains(user1, resultValue);
        Assert.Contains(user2, resultValue);
    }

    [Fact]
    public async Task GetUser_SingleId_ReturnsSingleUserWithId()
    {
        // Arrange
        User user = new User
        {
            UserId = 1,
            FirstName = "George",
            LastName = "Jungle",
            Email = "george.jungle@gmail.com",
            DateOfBirth = DateTime.UtcNow
        };
        var userRepositoryMock = new Mock<IUsersRepository>();
        var programsRepositoryMock = new Mock<IProgramsRepository>();
        var UsersController = new UsersController(userRepositoryMock.Object, programsRepositoryMock.Object);
        userRepositoryMock
            .Setup(_ => _.GetUserByIdAsync(1))
            .ReturnsAsync(user)
            .Verifiable();

        // Act
        ActionResult<User> actionResult = await UsersController.GetUser(1);
        OkObjectResult resultObj = actionResult.Result as OkObjectResult;
        User resultValue = resultObj.Value as User;

        // Assert
        Assert.IsType<OkObjectResult>(actionResult.Result);
        Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)resultObj.StatusCode);
        Assert.NotNull(resultValue);
        Assert.Equal(user.UserId, resultValue.UserId);

    }

    [Fact]
    public async Task PostUser_SingleUser_ReturnsRefreshToken()
    {
        // Arrange
        Guid uuid = new Guid("1410f70f-3a86-4183-8ef4-8e8d8532e72f");
        DateTime birthDate = DateTime.SpecifyKind(new DateTime(1993, 01, 02).Date, DateTimeKind.Utc);
        string refreshToken = "-kFVqxzJrr_3OfKC9U2kzA";
        UserWriteDto newUserParams = new UserWriteDto
        {
            Password = "secret",
            FirstName = "FirstNameTest1",
            LastName = "LastNameTest1",
            DateOfBirth = "1990-01-02",
            Email = "email1@email.com"
        };
        User newUser = new User
        {
            UserId = 1,
            Uuid = uuid,
            Email = "email1@email.com",
            FirstName = "FirstNameTest1",
            LastName = "LastNameTest1",
            DateOfBirth = birthDate
        };

        string supabaseMockResponse = JsonSerializer.Serialize(
            new
            {
                user = new
                {
                    id = uuid
                },
                refresh_token = refreshToken
            });
        var userRepositoryMock = new Mock<IUsersRepository>();
        var programsRepositoryMock = new Mock<IProgramsRepository>();
        userRepositoryMock
            .Setup(_ => _.CreateSupabaseUserAsync(newUserParams.Email, newUserParams.Password))
            .ReturnsAsync(new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(supabaseMockResponse, System.Text.Encoding.UTF8, "application/json") })
            .Verifiable();
        userRepositoryMock
            .Setup(_ => _.CreateUserAsync(newUserParams, uuid, It.IsAny<DateTime>()))
            .ReturnsAsync(newUser)
            .Verifiable();
        var UsersController = new UsersController(userRepositoryMock.Object, programsRepositoryMock.Object);

        // Act
        ActionResult<UserWriteDto> actionResult = await UsersController.PostUser(newUserParams);
        CreatedAtActionResult resultObj = actionResult.Result as CreatedAtActionResult;
        UserWriteResultDto resultValue = resultObj.Value as UserWriteResultDto;

        // Assert
        Assert.IsType<CreatedAtActionResult>(actionResult.Result);
        Assert.Equal(HttpStatusCode.Created, (HttpStatusCode)resultObj.StatusCode);
        Assert.NotNull(resultValue);
        Assert.Equal(refreshToken, resultValue.refresh_token);

    }
}