using Entitites;
using Entitites.Models;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DTO
{
    //DatabaseContext nesnesni bir veritabanı örneğidir.
    public class DatabaseContext : DbContext
    {
        public string connectionString = @"Data Source=database.db;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite(connectionString);
            optionsBuilder.EnableSensitiveDataLogging();
        }
        //İlgili modelleri DbSet<T> class'ı üzerinden veritabanı tablosu olarak simgeler. 
        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<Kitap> Kitaps { get; set; }
        public DbSet<KutuphaneIslem> KutuphaneIslems { get; set; }

    }


}
