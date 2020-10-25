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
                .UseMySql("server=localhost;database:dolphin;user=root;password=;sslmode=none;")
                .UseLoggerFactory(LoggerFactory.Create(b => b
                .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
    }
}
