using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Q2.DieuDao.DAL.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Q2.DieuDao.DAL;

public partial class Su26DieuDaoContext : DbContext
{
    public Su26DieuDaoContext()
    {
    }

    public Su26DieuDaoContext(DbContextOptions<Su26DieuDaoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Fruit> Fruits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(GetConnectionString());

    private string GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();

        return config.GetConnectionString("DefaultConnectionStringDB")
            ?? throw new InvalidOperationException(
                "Connection string DefaultConnectionStringDB not found."
            );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3213E83F3D298C10");

            entity.ToTable("Category");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Fruit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fruit__3213E83FD11C7992");

            entity.ToTable("Fruit");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("price");

            entity.HasOne(d => d.Category).WithMany(p => p.Fruits)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Fruit_Category");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
