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
        public InfraDbContext(DbContextOptions<InfraDbContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config.Connection);
        }
    }
}
