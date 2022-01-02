using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace E_Commerce.AutoGen
{
    public partial class Juma : DbContext
    {
        public Juma()
        {
        }

        public Juma(DbContextOptions<Juma> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Filename=Juma.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.ItemNumber).ValueGeneratedNever();
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderNumber).ValueGeneratedNever();

                entity.HasOne(d => d.CustomerNameNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerName)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ItemNumberNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ItemNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
