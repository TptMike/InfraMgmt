using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfraMgmt.Models;

namespace InfraMgmt.Data
{
    public class InfraDbContext : DbContext
    {
        public DbSet<Asset> Assets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(Config.Connection);
        }
    }
}
