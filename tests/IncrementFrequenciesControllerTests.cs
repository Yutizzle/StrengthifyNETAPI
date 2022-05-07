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

public class IncrementFrequenciesController_UnitTests
{
    [Fact]
    public async Task GetIncrementFrequencies_TwoFreq_ReturnsBothFreq()
    {
        // Arrange
        IncrementFrequencyReadDto freq1 = new IncrementFrequencyReadDto
        {
            IncrementFrequencyId = 1,
            Frequency = "MAX_REPS_REACHED"
        };
        IncrementFrequencyReadDto freq2 = new IncrementFrequencyReadDto
        {
            IncrementFrequencyId = 2,
            Frequency = "MAX_WEIGHT_REACHED"
        };
        List<IncrementFrequencyReadDto> allFreq = new List<IncrementFrequencyReadDto> { freq1, freq2 };
        var incrFreqRepositoryMock = new Mock<IIncrementFrequenciesRepository>();
        var controller = new IncrementFrequenciesController(incrFreqRepositoryMock.Object);
        incrFreqRepositoryMock
            .Setup(_ => _.GetAllIncrFreqAsync())
            .ReturnsAsync(allFreq.AsEnumerable())
            .Verifiable();

        // Act   
        ActionResult<IEnumerable<IncrementFrequencyReadDto>> actionResult = await controller.GetIncrementFrequencies();
        OkObjectResult resultObj = actionResult.Result as OkObjectResult;
        List<IncrementFrequencyReadDto> resultValue = resultObj.Value as List<IncrementFrequencyReadDto>;

        // Assert
        Assert.IsType<OkObjectResult>(actionResult.Result);
        Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)resultObj.StatusCode);
        Assert.NotNull(resultValue);
        Assert.Contains(freq1, resultValue);
        Assert.Contains(freq2, resultValue);
    }

}