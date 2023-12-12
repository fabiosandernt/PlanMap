
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlanMap.Models;

namespace PlanMap.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Plantio> Plantios { get; set; }
        public DbSet<Especie> Especies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Plantio entity
            modelBuilder.Entity<Plantio>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Plantio>()
                .Property(p => p.Long)
                .IsRequired();

            modelBuilder.Entity<Plantio>()
                .Property(p => p.Lat)
                .IsRequired();

            modelBuilder.Entity<Plantio>()
                .Property(p => p.Name)
                .IsRequired();

            modelBuilder.Entity<Plantio>()
                .Property(p => p.Description)
                .IsRequired();

            modelBuilder.Entity<Plantio>()
                .Property(p => p.DataPlantio)
                .IsRequired();

            modelBuilder.Entity<Plantio>()
                .HasOne(p => p.Especie)
                .WithMany(e => e.Plants)
                .HasForeignKey(p => p.EspecieId);

            // Configure Especie entity
            modelBuilder.Entity<Especie>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Especie>()
                .Property(e => e.Name)
                .IsRequired();

            modelBuilder.Entity<Especie>()
                .Property(e => e.Description)
                .IsRequired();

            modelBuilder.Entity<Especie>()
                .Property(e => e.CodigoEspecie)
                .IsRequired();

            // Seed data if needed
            modelBuilder.Entity<Especie>().HasData(
                new Especie { Id = 1, Name = "Species1", Description = "Description1", CodigoEspecie = 123 },
                new Especie { Id = 2, Name = "Species2", Description = "Description2", CodigoEspecie = 456 });
        }
    }
}
