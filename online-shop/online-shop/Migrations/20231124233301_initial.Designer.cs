﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using online_shop.DataAccess.Data;

#nullable disable

namespace onlineshop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231124233301_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("online_shop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Action"
                        });
                });

            modelBuilder.Entity("online_shop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<double>("unitPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Billy spark",
                            Description = "About time travel",
                            ISBN = "SWD99",
                            Title = "Fortune of time",
                            price = 90.25,
                            unitPrice = 99.75
                        },
                        new
                        {
                            Id = 2,
                            Author = "Murakami",
                            Description = "Japan based novel",
                            ISBN = "SWD89",
                            Title = "Kafka on the shore",
                            price = 20.25,
                            unitPrice = 29.75
                        },
                        new
                        {
                            Id = 3,
                            Author = "Khaleed Hussain",
                            Description = "Afghanisthan during Taliban rule",
                            ISBN = "SWD79",
                            Title = "A thousand splended suns",
                            price = 10.25,
                            unitPrice = 29.75
                        },
                        new
                        {
                            Id = 4,
                            Author = "James clear",
                            Description = "Self help book",
                            ISBN = "SWD69",
                            Title = "Atomic habits",
                            price = 15.25,
                            unitPrice = 22.989999999999998
                        },
                        new
                        {
                            Id = 5,
                            Author = "Joe Dispenza",
                            Description = "Build a new you",
                            ISBN = "SWD59",
                            Title = "Breaking the habit of being yourself",
                            price = 4.25,
                            unitPrice = 9.75
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
