using System;
using System.ComponentModel.DataAnnotations;

namespace StrengthifyNETAPI.Dto
{
    public class UserWriteDto
    {
        [Required]
        public string Password {get; set;}
        [Required]
        public string FirstName {get; set;}
        [Required]
        public string LastName {get; set;}
        [Required]
        public string DateOfBirth {get; set;}
        [Required]
        public string Email {get; set;}

    }
}