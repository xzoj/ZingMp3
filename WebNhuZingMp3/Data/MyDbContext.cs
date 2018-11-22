using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNhuZingMp3.Models;

namespace WebNhuZingMp3.Data
{
    public class MyDbContext: DbContext
    {
        public DbSet<Song> Song { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SongCategory> SongCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WebNhuZingMp3Context;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SongCategory>()
                .HasKey(sc => new { sc.SongId, sc.CategoryId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
