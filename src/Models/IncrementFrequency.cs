using System;
using Microsoft.EntityFrameworkCore;

namespace StrengthifyNETAPI.Models
{
    [Index(nameof(IncrementFrequencyId), nameof(Frequency), IsUnique = true)]
    public class IncrementFrequency : BaseEntity
    {
        public int IncrementFrequencyId { get; set; }
        public string Frequency { get; set; }
    }
}