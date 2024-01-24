﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProvaPub.Repository;

#nullable disable

namespace ProvaPub.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20240122194406_Test3")]
    partial class Test3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProvaPub.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Wilbert Christiansen"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Krystal Botsford"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rosalie Rath"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Irma Schneider"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Micheal Schaefer"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Roxanne Green"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Elvira Hilll"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Edwin Huel"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Damon Champlin"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Nancy Hudson"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Ross Bruen"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Melanie Daniel"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Eula Buckridge"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Randall Feil"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Velma O'Hara"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Deanna Bergstrom"
                        },
                        new
                        {
                            Id = 17,
                            Name = "John Lebsack"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Ruth Hintz"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Erik Feil"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Kari Leannon"
                        });
                });

            modelBuilder.Entity("ProvaPub.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ProvaPub.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Handmade Cotton Chair"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Practical Frozen Chair"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Licensed Granite Chair"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Licensed Soft Table"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Ergonomic Concrete Chicken"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Fantastic Rubber Fish"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Handmade Soft Ball"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Fantastic Wooden Table"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Sleek Granite Chicken"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Unbranded Granite Chair"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Awesome Concrete Ball"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Handcrafted Concrete Shoes"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Incredible Cotton Sausages"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Generic Frozen Table"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Sleek Frozen Sausages"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Intelligent Fresh Towels"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Practical Granite Ball"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Intelligent Steel Chips"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Tasty Plastic Salad"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Refined Frozen Gloves"
                        });
                });

            modelBuilder.Entity("ProvaPub.Models.Order", b =>
                {
                    b.HasOne("ProvaPub.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ProvaPub.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
