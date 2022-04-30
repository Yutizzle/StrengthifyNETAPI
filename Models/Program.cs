using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Strengthify.Models
{
    [Index(nameof(ProgramName), IsUnique = true)]
    public record Program {
         public int ProgramId {get; init;}
         public string ProgramName {get; init;}
         public int TotalCycleDays {get; init;}
         public User CreatedBy {get; init;}
         public DateTimeOffset CreatedAt {get; init;}
         public User UpdatedBy {get; init;}
         public DateTimeOffset UpdatedAt {get; init;}
         
         public ICollection<ProgramDetail> ProgramDetails {get; init;}
    }
}