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
    public interface IIncrementFrequenciesRepository
    {
        Task<IEnumerable<IncrementFrequencyReadDto>> GetAllIncrFreqAsync();
    }
}
