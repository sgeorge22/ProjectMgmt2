using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectMgmt2.Models;

namespace ProjectMgmt2.Data
{
    public class ProjectMgmt2Context : DbContext
    {
        public ProjectMgmt2Context (DbContextOptions<ProjectMgmt2Context> options)
            : base(options)
        {
        }

        public DbSet<ProjectMgmt2.Models.Developer> Developer { get; set; }

        public DbSet<ProjectMgmt2.Models.Assignment> Assignment { get; set; }

        public DbSet<ProjectMgmt2.Models.Project> Project { get; set; }
    }
}
