using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class M1i2526DbContext : DbContext
{
    public M1i2526DbContext()
    {
    }

    public M1i2526DbContext(DbContextOptions<M1i2526DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MatiereTest> MatiereTests { get; set; }

    public virtual DbSet<SeanceTest> Seances { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MatiereTest>(entity =>
        {
            entity.ToTable("MatiereTest");

            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Nom).HasMaxLength(250);
        });

        modelBuilder.Entity<SeanceTest>(entity =>
        {
            entity.ToTable("Seance");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Type).HasMaxLength(50);

            entity.HasOne(d => d.IdMatiereNavigation).WithMany(p => p.Seances)
                .HasForeignKey(d => d.IdMatiere)
                .HasConstraintName("FK_Seance_MatiereTest");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
