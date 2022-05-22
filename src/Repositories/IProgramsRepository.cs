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
        Task<IEnumerable<ProgramReadLiteDto>> GetAllProgramsAsync();
        Task<ProgramReadLiteDto> GetProgramByIdAsync(int id);
        Task<Program> GetProgramEntityByIdAsync(int id);
        Task<Program> GetProgramByNameAsync(string name);
        Task<ProgramReadFullDto> GetFullProgramByIdAsync(int id);
        Task<int> PutProgramAsync(ProgramUpdateDto newProgram, User user);
        Task<int> CreateProgramAsync(ProgramWriteDto newProgram, User user);
        Task<int> DeleteProgramAsync(int id);
        bool ProgramExists(int id);
    }
}
