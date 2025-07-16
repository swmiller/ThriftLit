using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ThriftMedia.Data.Models;

public partial class ThriftMediaDbContext : DbContext
{
    public ThriftMediaDbContext()
    {
    }

    public ThriftMediaDbContext(DbContextOptions<ThriftMediaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MediaItem> MediaItems { get; set; }

    public virtual DbSet<StoreOwner> StoreOwners { get; set; }

    // The connection string is now injected via DI in the API project. Remove OnConfiguring override.

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MediaItem>(entity =>
        {
            entity.HasKey(e => e.MediaId);

            entity.ToTable("MediaItems", "media");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.ImageUrl).HasMaxLength(500);
            entity.Property(e => e.MediaType).HasMaxLength(50);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);

            entity.HasOne(d => d.StoreOwner).WithMany(p => p.MediaItems)
                .HasForeignKey(d => d.StoreOwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MediaItems_StoreOwner");
        });

        modelBuilder.Entity<StoreOwner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StoreOwn__3214EC07271D525F");

            entity.ToTable("StoreOwner", "media");

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.StoreName).HasMaxLength(200);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
