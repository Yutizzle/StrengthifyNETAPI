using System;

namespace StrengthifyNETAPI.Dto
{
    public class UserReadDto
    {
        public Guid Uuid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Email { get; set; }

    }
}