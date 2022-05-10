using System;

namespace StrengthifyNETAPI.Dto
{
    public class ProgramReadLiteDto
    {
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public int TotalCycleDays { get; set; }
        public int? CurrentProgramCycle { get; set; }
    }
}