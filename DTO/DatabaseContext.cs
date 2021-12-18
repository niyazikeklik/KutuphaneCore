using Entitites;
using Entitites.Models;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DTO
{
    public class DatabaseContext : DbContext
    {
        public string connectionString = @"Data Source=database.db;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(connectionString);

        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<Kitap> Kitaps { get; set; }
        public DbSet<KutuphaneIslem> KutuphaneIslems { get; set; }

    }


}
