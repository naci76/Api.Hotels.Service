﻿// <auto-generated />
using System;
using Api.Hotels.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api.Hotels.Entity.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20230603110724_tablolarolusturuldu")]
    partial class tablolarolusturuldu
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Api.Hotels.Entity.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Lat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("Api.Hotels.Entity.HotelContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("hotelContacts");
                });

            modelBuilder.Entity("Api.Hotels.Entity.HotelContact", b =>
                {
                    b.HasOne("Api.Hotels.Entity.Hotel", "Hotel")
                        .WithMany("hotelContacts")
                        .HasForeignKey("HotelId");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Api.Hotels.Entity.Hotel", b =>
                {
                    b.Navigation("hotelContacts");
                });
#pragma warning restore 612, 618
        }
    }
}