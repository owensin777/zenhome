using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZensHomeDotNetCore.Models;

namespace ZensHomeDotNetCore
{
    public class MyDbContext : DbContext
    {
        private readonly string ConnectionString;
        public DbSet<VillageConsumption> VillageConsumption { get;set;}
        public DbSet<Village> Village { get; set; }

        public MyDbContext(string connectionString) : base()
        {
            this.ConnectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(ConnectionString);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VillageConsumption>().HasOne(x => x.Village)
                .WithMany()
                .HasForeignKey(x => x.VillageId);
        }
    }
}
