using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StrengthifyNETAPI.Models
{
    [Index(nameof(ProgramName), IsUnique = true)]
    public class Program : BaseEntity
    {
        public int ProgramId { get; init; }
        public string ProgramName { get; init; }
        public int TotalCycleDays { get; init; }

        public ICollection<ProgramDetail> ProgramDetails { get; init; }
    }
}