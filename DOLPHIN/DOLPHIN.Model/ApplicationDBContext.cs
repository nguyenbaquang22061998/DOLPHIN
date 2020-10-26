using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOLPHIN.Model
{
    public class ApplicationDBContext : DbContext
    {
        public virtual DbSet<Products> Dolphin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySql("server=localhost;database=dolphin;user=root;password=;sslmode=none;")
                .UseLoggerFactory(LoggerFactory.Create(b => b
                .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleUser>()
                .HasKey(c => new { c.RoleId, c.UserId });
            modelBuilder.Entity<RolePermission>()
                .HasKey(c => new { c.RoleId, c.PermissionId });
            modelBuilder.Entity<Comments>()
                .HasKey(c => new { c.UserId, c.ProductId });
            modelBuilder.Entity<Users>().HasIndex(c => c.Email).IsUnique();
            modelBuilder.Entity<Users>().HasIndex(c => c.UserName).IsUnique();
        }
    }
}
