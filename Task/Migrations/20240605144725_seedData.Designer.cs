﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task.Models;

#nullable disable

namespace Task.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240605144725_seedData")]
    partial class seedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Task.Models.Product", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemID"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(12,2)")
                        .HasDefaultValue(0m);

                    b.HasKey("ItemID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ItemID = 1,
                            Brand = "Brand1",
                            Color = "Red",
                            ItemName = "Item1",
                            Model = "Model1",
                            Price = 10.00m
                        },
                        new
                        {
                            ItemID = 2,
                            Brand = "Brand2",
                            Color = "Blue",
                            ItemName = "Item2",
                            Model = "Model2",
                            Price = 20.00m
                        },
                        new
                        {
                            ItemID = 3,
                            Brand = "Brand3",
                            Color = "Green",
                            ItemName = "Item3",
                            Model = "Model3",
                            Price = 30.00m
                        },
                        new
                        {
                            ItemID = 4,
                            Brand = "Brand4",
                            Color = "Yellow",
                            ItemName = "Item4",
                            Model = "Model4",
                            Price = 40.00m
                        },
                        new
                        {
                            ItemID = 5,
                            Brand = "Brand5",
                            Color = "Orange",
                            ItemName = "Item5",
                            Model = "Model5",
                            Price = 50.00m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
