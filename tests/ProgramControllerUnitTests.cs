using Xunit;
using Moq;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Net;
using System.Collections.Generic;
using StrengthifyNETAPI.Controllers;
using StrengthifyNETAPI.Models;
using StrengthifyNETAPI.Repositories;
using StrengthifyNETAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace StrengthifyNETAPI.Tests;

public class ProgramController_UnitTests
{
    [Fact]
    public async Task GetPrograms_TwoPrograms_ReturnsBothPrograms()
    {
        // Arrange
        ProgramReadDto program1 = new ProgramReadDto
        {
            ProgramId = 1,
            ProgramName = "Program1",
            TotalCycleDays = 2,
        };
        ProgramReadDto program2 = new ProgramReadDto
        {
            ProgramId = 2,
            ProgramName = "Program2",
            TotalCycleDays = 3,
        };
        List<ProgramReadDto> allPrograms = new List<ProgramReadDto> { program1, program2 };
        var programsRepositoryMock = new Mock<IProgramsRepository>();
        var userRepositoryMock = new Mock<IUsersRepository>();
        var controller = new ProgramsController(programsRepositoryMock.Object, userRepositoryMock.Object);
        programsRepositoryMock
            .Setup(_ => _.GetAllProgramsAsync())
            .ReturnsAsync(allPrograms.AsEnumerable())
            .Verifiable();

        // Act   
        ActionResult<IEnumerable<ProgramReadDto>> actionResult = await controller.GetPrograms();
        OkObjectResult resultObj = actionResult.Result as OkObjectResult;
        List<ProgramReadDto> resultValue = resultObj.Value as List<ProgramReadDto>;

        // Assert
        Assert.IsType<OkObjectResult>(actionResult.Result);
        Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)resultObj.StatusCode);
        Assert.NotNull(resultValue);
        Assert.Contains(program1, resultValue);
        Assert.Contains(program2, resultValue);
    }

    [Fact]
    public async Task GetProgram_SingleId_ReturnsSingleProgramWithId()
    {
        // Arrange
        ProgramReadDto program = new ProgramReadDto
        {
            ProgramId = 1,
            ProgramName = "Program1",
            TotalCycleDays = 2,
        };
        var programsRepositoryMock = new Mock<IProgramsRepository>();
        var userRepositoryMock = new Mock<IUsersRepository>();
        var programController = new ProgramsController(programsRepositoryMock.Object, userRepositoryMock.Object);
        programsRepositoryMock
            .Setup(_ => _.GetProgramByIdAsync(1))
            .ReturnsAsync(program)
            .Verifiable();

        // Act
        ActionResult<ProgramReadDto> actionResult = await programController.GetProgram(1);
        OkObjectResult resultObj = actionResult.Result as OkObjectResult;
        ProgramReadDto resultValue = resultObj.Value as ProgramReadDto;

        // Assert
        Assert.IsType<OkObjectResult>(actionResult.Result);
        Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)resultObj.StatusCode);
        Assert.NotNull(resultValue);
        Assert.Equal(program.ProgramId, resultValue.ProgramId);

    }

    [Fact]
    public async Task PostProgram_SingleProgram_ReturnsSameProgram()
    {
        // Arrange
        Guid uuid = Guid.NewGuid();
        Program nullProgram = null;
        Program newProgram = new Program
        {
            ProgramId = 1,
            ProgramName = "Program1",
            TotalCycleDays = 2,
        };
        ProgramWriteDto newProgramParams = new ProgramWriteDto
        {
            ProgramName = "test program 2",
            Workouts = new WorkoutDto[]
                {
                    new WorkoutDto
                    {
                        WorkoutName = "test workout 2",
                        SequenceNum = 0,
                        CycleDayNum = 1
                    }
                },
            Exercises = new ExerciseDto[] {
                new ExerciseDto {
                    Exercise= "test exercise 1",
                    WorkoutKey = "test workout 2",
                    SequenceNum = 0
                }
            },
            Sets = new SetsDto[] {
                new SetsDto {
                    ExerciseKey = "test exercise 1",
                    Set = 1,
                    Reps = 8,
                    Weight = 100,
                    SetDuration = 0,
                    SetRestDuration = 90,
                    MaxReps = 15,
                    MaxWeight = 0,
                    MaxSetDuration = 0,
                    RepsIncrementFrequencyId = 0,
                    WeightIncrementFrequencyId = 0,
                    SetDurationIncrementFrequencyId = 0,
                    RepsIncrementAmount = 1,
                    WeightIncrementAmount = 5,
                    SetDurationIncrementAmount = 0
                }
            },
            UserUuid = uuid
        };
        User user = new User
        {
            UserId = 1,
            Uuid = uuid,
            Email = "email1@email.com",
            FirstName = "FirstNameTest1",
            LastName = "LastNameTest1",
            DateOfBirth = DateTime.UtcNow
        };
        var programsRepositoryMock = new Mock<IProgramsRepository>();
        var userRepositoryMock = new Mock<IUsersRepository>();
        userRepositoryMock
            .Setup(_ => _.GetUserByUuidAsync(uuid))
            .ReturnsAsync(user)
            .Verifiable();
        programsRepositoryMock
            .Setup(_ => _.GetProgramByNameAsync(It.IsAny<string>()))
            .ReturnsAsync(nullProgram)
            .Verifiable();
        programsRepositoryMock
            .Setup(_ => _.CreateProgramAsync(newProgramParams, user))
            .ReturnsAsync(1)
            .Verifiable();
        var programController = new ProgramsController(programsRepositoryMock.Object, userRepositoryMock.Object);

        // Act
        ActionResult<ProgramWriteDto> actionResult = await programController.PostProgram(newProgramParams);
        CreatedAtActionResult resultObj = actionResult.Result as CreatedAtActionResult;
        ProgramWriteDto resultValue = resultObj.Value as ProgramWriteDto;

        // Assert
        Assert.IsType<CreatedAtActionResult>(actionResult.Result);
        Assert.Equal(HttpStatusCode.Created, (HttpStatusCode)resultObj.StatusCode);
        Assert.NotNull(resultValue);
        Assert.Equal(newProgramParams, resultValue);

    }
}