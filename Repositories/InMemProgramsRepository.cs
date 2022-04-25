using System;
using System.Collections.Generic;
using System.Linq;
using Strengthify.Models;

namespace Programs.Repositories
{
    public class InMemProgramsRepository
    {
        private static Guid Id = Guid.NewGuid();
        private readonly List<Program> programs = new ()
        {
            new Program { Id = 1, ProgramName = "Simple 3x5", TotalCycleDays = 4, CreatedBy = Id, CreatedAt = DateTimeOffset.UtcNow, UpdatedBy = Id, UpdatedAt = DateTimeOffset.UtcNow},
            new Program { Id = 2, ProgramName = "Test Program 123", TotalCycleDays = 2, CreatedBy = Id, CreatedAt = DateTimeOffset.UtcNow, UpdatedBy = Id, UpdatedAt = DateTimeOffset.UtcNow},
            new Program { Id = 3, ProgramName = "Strongman", TotalCycleDays = 3, CreatedBy = Id, CreatedAt = DateTimeOffset.UtcNow, UpdatedBy = Id, UpdatedAt = DateTimeOffset.UtcNow}

        };

        public IEnumerable<Program> GetPrograms() 
        {
            return programs;
        }

        public Program GetProgram(int Id)
        {
            return programs.Where(program => program.Id == Id).SingleOrDefault();
        }

    }
}