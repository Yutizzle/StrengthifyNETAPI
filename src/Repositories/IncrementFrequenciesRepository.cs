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
    public class IncrementFrequenciesRepository : IIncrementFrequenciesRepository
    {
        private readonly StrengthifyContext _context;
        public IncrementFrequenciesRepository(StrengthifyContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<IncrementFrequencyReadDto>> GetAllIncrFreqAsync()
        {
            List<IncrementFrequencyReadDto> result = await _context.IncrementFrequencies
                .Select(x => new IncrementFrequencyReadDto { IncrementFrequencyId = x.IncrementFrequencyId, Frequency = x.Frequency })
                .ToListAsync();

            return result.AsEnumerable();
        }
    }
}
