using Xunit;
using Moq;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Net;
using System.Collections.Generic;
using StrengthifyNETAPI.Controllers;
using StrengthifyNETAPI.Repositories;
using StrengthifyNETAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace StrengthifyNETAPI.UnitTests;

public class UserController_UnitTests
{
    [Fact]
    public async Task UserController_GetUsersTest()
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
        var controller = new UserController(userRepositoryMock.Object);
        userRepositoryMock
            .Setup(_ => _.GetAllUsersAsync())
            .ReturnsAsync(allUsers.AsEnumerable())
            .Verifiable();

        // Act   
        ActionResult<IEnumerable<UserReadDto>> actionResult = await controller.GetUsers();
        OkObjectResult resultObj = actionResult.Result as OkObjectResult;
        List<UserReadDto> resultValue = resultObj.Value as List<UserReadDto>;
        // var resultValue = resultObj.Value;

        // Assert
        Assert.IsType<OkObjectResult>(actionResult.Result);
        Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)resultObj.StatusCode);
        Assert.NotNull(resultValue);
        Assert.Contains(user1, resultValue);
        Assert.Contains(user2, resultValue);
    }
}