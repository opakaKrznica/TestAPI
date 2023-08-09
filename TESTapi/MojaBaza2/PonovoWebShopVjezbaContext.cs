using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TESTapi.MojaBaza2;

public partial class PonovoWebShopVjezbaContext : DbContext
{
    public PonovoWebShopVjezbaContext()
    {
    }

    public PonovoWebShopVjezbaContext(DbContextOptions<PonovoWebShopVjezbaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ShoppingCard> ShoppingCards { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-JE9G202;Initial Catalog=ponovoWebShopVjezba;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_Product_Category");
        });

        modelBuilder.Entity<ShoppingCard>(entity =>
        {
            entity.ToTable("ShoppingCard");

            entity.HasOne(d => d.Product).WithMany(p => p.ShoppingCards)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_ShoppingCard_Product");
        });

       // OnModelCreatingPartial(modelBuilder);
    }

   // partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
