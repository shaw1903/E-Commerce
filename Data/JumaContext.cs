using Microsoft.EntityFrameworkCore;
using E_Commerce;
using E_Commerce.Models;
using E_Commerce.Controllers;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace E_Commerce.Data
{
    public partial class JumaContext : DbContext
    {
        public JumaContext()
        {
        }

        public JumaContext(DbContextOptions<JumaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Orders> Orders { get; set; } = null!;
        public virtual DbSet<Images> Images { get; set; } = null!;
        public virtual DbSet<Customers> Customers { get; set; } = null!;
        

        //public DbSet<Orders> Order => Set<Orders>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Juma.db");
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Filename={path}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Images>()
            .Property(images => images.ItemPrice)
            .HasConversion<double>();
            
/*
            modelBuilder.Entity<Customers>()
            .Property(c => c.CustomerName)
            .IsRequired()//NOT NULL
            .HasMaxLength(20);
            
            modelBuilder.Entity<Orders>()
            .HasOne(p => p.CustomerName)
            .WithMany(p=> p.ItemNumber)
            .HasForeignKey(p=> p.Order);
                        
            OnModelCreatingPartial(modelBuilder);
            */
           }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
