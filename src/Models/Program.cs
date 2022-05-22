using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StrengthifyNETAPI.Models
{
    [Index(nameof(ProgramId), nameof(ProgramName), IsUnique = true)]
    public class Program : BaseEntity
    {
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public int TotalCycleDays { get; set; }

        public ICollection<ProgramDetail> ProgramDetails { get; set; }
    }
}