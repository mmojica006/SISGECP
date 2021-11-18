using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using CargoMap = Infraestructure.Data.EntityMapper.CargoMap;

namespace Infraestructure.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Cargo> Cargos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CargoMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
