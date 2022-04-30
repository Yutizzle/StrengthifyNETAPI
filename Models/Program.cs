using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Strengthify.Models
{
    [Index(nameof(ProgramName), IsUnique = true)]
    public record Program {
         public int ProgramId {get; init;}
         public string ProgramName {get; init;}
         public int TotalCycleDays {get; init;}
         public Guid CreatedBy {get; init;}
         public DateTimeOffset CreatedAt {get; init;}
         public Guid UpdatedBy {get; init;}
         public DateTimeOffset UpdatedAt {get; init;}
         
         public ICollection<ProgramDetail> ProgramDetails {get; init;}
    }
}