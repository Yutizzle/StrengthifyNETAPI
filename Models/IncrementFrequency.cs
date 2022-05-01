using System;
using Microsoft.EntityFrameworkCore;

namespace Strengthify.Models
{
    [Index(nameof(Frequency), IsUnique = true)]
    public class IncrementFrequency : BaseEntity
    {
        public int IncrementFrequencyId { get; set; }
        public string Frequency { get; set; }
    }
}