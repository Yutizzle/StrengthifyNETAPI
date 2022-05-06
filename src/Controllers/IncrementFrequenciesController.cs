using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StrengthifyNETAPI.Models;
using StrengthifyNETAPI.Dto;
using StrengthifyNETAPI.Repositories;

namespace StrengthifyNETAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncrementFrequenciesController : ControllerBase
    {
        private readonly IIncrementFrequenciesRepository _incrementFreqRepository;

        public IncrementFrequenciesController(IIncrementFrequenciesRepository incrementFreqRepository)
        {
            _incrementFreqRepository = incrementFreqRepository;
        }

        // GET: api/IncrementFrequencies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IncrementFrequencyReadDto>>> GetIncrementFrequencies()
        {
            return Ok(await _incrementFreqRepository.GetAllIncrFreqAsync());
        }

    }
}
