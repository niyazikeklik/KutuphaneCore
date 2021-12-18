﻿// <auto-generated />
using System;
using DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DTO.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20211113152308_sada")]
    partial class sada
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("Entitites.Kitap", b =>
                {
                    b.Property<int>("BarkodNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BasimTarihi")
                        .HasColumnType("TEXT");

                    b.Property<string>("KitapAd")
                        .HasColumnType("TEXT");

                    b.Property<int>("KitapTuru")
                        .HasColumnType("INTEGER");

                    b.Property<string>("KitapYazar")
                        .HasColumnType("TEXT");

                    b.Property<int>("SayfaSayısı")
                        .HasColumnType("INTEGER");

                    b.HasKey("BarkodNo");

                    b.ToTable("Kitaps");
                });

            modelBuilder.Entity("Entitites.Models.KutuphaneIslem", b =>
                {
                    b.Property<int>("IslemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AlimTarihi")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("IadeTarihi")
                        .HasColumnType("TEXT");

                    b.Property<int>("Islem")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KitapBarkodNo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OgrenciNo")
                        .HasColumnType("INTEGER");

                    b.HasKey("IslemId");

                    b.HasIndex("KitapBarkodNo");

                    b.HasIndex("OgrenciNo");

                    b.ToTable("KutuphaneIslems");
                });

            modelBuilder.Entity("Entitites.Models.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("TEXT");

                    b.Property<string>("IsimSoyisim")
                        .HasColumnType("TEXT");

                    b.Property<int>("TCno")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TelefonNo")
                        .HasColumnType("TEXT");

                    b.HasKey("OgrenciNo");

                    b.ToTable("Ogrencis");
                });

            modelBuilder.Entity("Entitites.Models.KutuphaneIslem", b =>
                {
                    b.HasOne("Entitites.Kitap", "Kitap")
                        .WithMany()
                        .HasForeignKey("KitapBarkodNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entitites.Models.Ogrenci", "Ogrenci")
                        .WithMany("kutuphaneIslems")
                        .HasForeignKey("OgrenciNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("Entitites.Models.Ogrenci", b =>
                {
                    b.Navigation("kutuphaneIslems");
                });
#pragma warning restore 612, 618
        }
    }
}
