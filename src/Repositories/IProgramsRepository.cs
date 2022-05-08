using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StrengthifyNETAPI.Models;
using StrengthifyNETAPI.Dto;

namespace StrengthifyNETAPI.Repositories
{
    public interface IProgramsRepository
    {
        Task<IEnumerable<ProgramReadDto>> GetAllProgramsAsync();
        Task<ProgramReadDto> GetProgramByIdAsync(int id);
        Task<Program> GetProgramByNameAsync(string programName);
        Task<ActionResult<int>> PutProgramAsync(int id, Program program);
        Task<int> CreateProgramAsync(ProgramWriteDto newProgram, User user);
        void DeleteProgramAsync(int id);
        bool ProgramExists(int id);
    }
}
