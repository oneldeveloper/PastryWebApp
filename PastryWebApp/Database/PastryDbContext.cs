using Microsoft.EntityFrameworkCore;
using PastryWebApp.Database.Entities;

namespace PastryWebApp.Database
{
    public class PastryDbContext : DbContext
    {
        public DbSet<Pastry> Pastries { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }


        public PastryDbContext(DbContextOptions<PastryDbContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pastry>(
                eb =>
                {
                    eb.ToTable("Pastries");
                    eb.HasKey(p => p.Id);
                    eb.HasMany(p => p.Ingredients)
                    .WithOne(p=>p.Pastry);
                    eb.Property(p => p.Id)
                    .ValueGeneratedOnAdd();
                    eb.Property(p => p.Name)
                    .IsRequired();
                });

            modelBuilder.Entity<Ingredient>(
                eb =>
                {
                    eb.ToTable("Ingredients");
                    eb.HasKey(p => p.Id);
                    eb.Property(p=>p.Id)
                    .ValueGeneratedOnAdd();
                    eb.Property(p => p.Name)
                    .IsRequired();
                    eb.Property(p => p.MeasureUnit)
                    .IsRequired();
                });
        }
    }
}