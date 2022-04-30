using System;

namespace StrengthifyNETAPI.Dto
{
    public class UserWriteDto
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public DateTimeOffset DateOfBirth {get; set;}
        public string Email {get; set;}

    }
}