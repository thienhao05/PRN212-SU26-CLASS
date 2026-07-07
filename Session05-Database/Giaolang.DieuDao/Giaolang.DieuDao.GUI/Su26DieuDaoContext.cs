using System;
using System.Collections.Generic;
using Giaolang.DieuDao.GUI.Entities;
using Microsoft.EntityFrameworkCore;

namespace Giaolang.DieuDao.GUI;

//                  Dog      extends Pet
public partial class Su26DieuDaoContext : DbContext
{
    public Su26DieuDaoContext()
    {
    }

    public Su26DieuDaoContext(DbContextOptions<Su26DieuDaoContext> options)
        : base(options)
    {
    }

    //class quan trọng nhất khi chơi với DB
    //class này chứa các ArrayList<Entity class Fruit, Category, Student, Major>
    //Đằng sau chính là biến _backingField có 2 hàm get set
    //         List<Category> _categories = new ArrayList<>();
    //                        thằng này chính là ứng với SELECT * FROM CATEGORY

    public virtual DbSet<Category> Categories { get; set; }

    //         List<Fruit> _fruits = new ArrayList<>();
    //                        thằng này chính là ứng với SELECT * FROM FRUIT

    //CHỐT HẠ: CÓ BAO NHIÊU TABLE, CÓ BẤY NHIÊU ENTITY CLASS VÀ CÓ BẤY NHIÊU LIST<ENTITY> Ở ĐÂY
    //VẬY TA MUỐN LẤY FULL DATA CỦA 1 TABLE, TA CHỈ VIỆC GET BIẾN BACKING FIELD HOẶC DÙNG .PROPETIES TƯƠNG ỨNG VÌ CHÍNH LÀ LSIT
    //lấy hết trái cây trong table Fruit, là .Fruits, hoặc cũ: getFruit() return List
    //          category trong table Category, là .Categories, hoặc cũ .getCategories()
    //                                                                  return List
    public virtual DbSet<Fruit> Fruits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS22;uid=sa;pwd=12345;database= SU26_DieuDao;TrustServerCertificate=True");

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
