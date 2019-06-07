using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

//Connection string: "Scaffold-DbContext "Server=MSI\SQLEXPRESS;Database=Meals;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities" in Tools > Nuget packet manager console

namespace ExamPreparation.Entities
{
    public partial class MealsContext : DbContext
    {
        public MealsContext()
        {
        }

        public MealsContext(DbContextOptions<MealsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Meals> Meals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=Meals;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meals>(entity =>
            {
                entity.ToTable("meals");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Book).HasColumnName("book");

                entity.Property(e => e.Calories).HasColumnName("calories");

                entity.Property(e => e.Cook)
                    .HasColumnName("cook")
                    .HasMaxLength(15);

                entity.Property(e => e.Img)
                    .HasColumnName("img")
                    .HasMaxLength(45);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Servings).HasColumnName("servings");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(45);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(6);
            });
        }
    }
}
