using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Strengthify.Models
{
    [Index(nameof(Frequency), IsUnique = true)]
    public record IncrementFrequency {
         public int IncrementFrequencyId {get; set;}
         public string Frequency {get; set;}
         public User CreatedBy {get; set;}
         public DateTimeOffset CreatedAt {get; set;}
         public User UpdatedBy {get; set;}
         public DateTimeOffset UpdatedAt{get; set;}
    }
}