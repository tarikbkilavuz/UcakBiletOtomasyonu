using Microsoft.EntityFrameworkCore; 
using UcakBiletOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakBiletOtomasyonu.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=..\\..\\files\\UcakBiletOtomasyonu.db");
        }

        public DbSet<Havayolu> Havayolu { get; set; } 
        public DbSet<Lokasyon> Lokasyon { get; set; }
        public DbSet<Ucak> Ucak { get; set; }

        public DbSet<Ucus> Ucus { get; set; }
    }
}
