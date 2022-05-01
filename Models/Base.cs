using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Strengthify.Models
{
    public abstract class BaseEntity
    {
        public int? CreatedById { get; set; }
        [ForeignKey("CreatedById")]
        public User CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? UpdatedById { get; set; }
        [ForeignKey("UpdatedById")]
        public User UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}