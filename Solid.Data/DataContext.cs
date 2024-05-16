using Microsoft.EntityFrameworkCore;
using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Girl> girls { get; set; }
        public DbSet<Guy> guys { get; set; }
        public DbSet<Matchmaker> matchmakers { get; set; }
        public DbSet<Proposal> proposal { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sample1_db");
        }

    
    }
}
