using FinalOdev2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdev
{
    internal class OdevDbContext : DbContext
    {
        public DbSet<Ogrenciler> Ogrenciler {  get; set; }
        public DbSet<tblOgrenciDers> tblOgrenciDers { get; set; }
        public DbSet<tblDersler> tblDersler { get; set; }
        public DbSet<tblSiniflar> tblSiniflars { get; set; }
        public DbSet<tblSiniflar> SecilenSinif { get;  set; }

    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source = localhost;Initial Catalog = FinalOdev2;Integrated Security = true;TrustServerCertificate=true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ogrenciler>().HasKey(o => o.OgrenciId);
            

            modelBuilder.Entity<Ogrenciler>().Property(o => o.Ad).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Ogrenciler>().Property(o => o.Soyad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogrenciler>().Property(o => o.Numara).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Ogrenciler>().Property(o => o.SinifId).HasColumnType("varchar").HasMaxLength(20).IsRequired();

           

            modelBuilder.Entity<tblOgrenciDers>().HasKey(o => o.DersId);
            modelBuilder.Entity<tblOgrenciDers>().Property(o => o.OgrenciId).HasColumnType("varchar").HasMaxLength(20).IsRequired();
          


            modelBuilder.Entity<tblDersler>().HasKey(o => o.DersId);
            modelBuilder.Entity<tblDersler>().Property(o => o.DersKod).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            modelBuilder.Entity<tblDersler>().Property(o => o.DersAd).HasColumnType("varchar").HasMaxLength(20).IsRequired();

            modelBuilder.Entity<tblSiniflar>().HasKey(o => o.SinifId);
            modelBuilder.Entity<tblSiniflar>().Property(o => o.SinifAd).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            modelBuilder.Entity<tblSiniflar>().Property(o => o.Kontenjan).HasColumnType("varchar").HasMaxLength(20).IsRequired();
        }
    
   
    }
    
    }
