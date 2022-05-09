using System;
using System.ComponentModel.DataAnnotations;

namespace StrengthifyNETAPI.Dto
{
    public class UserProgramWriteDto
    {
        [Required]
        public Guid Uuid { get; set; }
        [Required]
        public int ProgramId { get; set; }

    }
}