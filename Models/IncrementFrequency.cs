using System;
using Microsoft.EntityFrameworkCore;

namespace Strengthify.Models
{
    [Index(nameof(Frequency), IsUnique = true)]
    public record IncrementFrequency {
         public int IncrementFrequencyId {get; init;}
         public string Frequency {get; init;}
         public Guid CreatedBy {get; init;}
         public DateTimeOffset CreatedAt {get; init;}
         public Guid UpdatedBy {get; init;}
         public DateTimeOffset UpdatedAt{get; init;}
    }
}