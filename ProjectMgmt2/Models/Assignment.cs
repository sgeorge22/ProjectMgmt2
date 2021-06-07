using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMgmt2.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public virtual Developer Developer { get; set; }
        [Required]
        public int DeveloperId { get; set; }
        public virtual Project Project { get; set; }
        [Required]
        public int PublicId { get; set; }

        public Assignment() { }
    }
}
