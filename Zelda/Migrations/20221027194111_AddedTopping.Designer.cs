﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Zelda.Migrations
{
    [DbContext(typeof(ZeldaContext))]
    [Migration("20221027194111_AddedTopping")]
    partial class AddedTopping
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Zelda.Models.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressID"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.HasKey("AddressID");

                    b.ToTable("Addreses");
                });

            modelBuilder.Entity("Zelda.Models.Costumer", b =>
                {
                    b.Property<string>("CustomerID")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<int>("AdrressID")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("CustomerID");

                    b.HasIndex("AdrressID");

                    b.ToTable("Costumers");
                });

            modelBuilder.Entity("Zelda.Models.IceCream", b =>
                {
                    b.Property<int>("IceCreamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IceCreamID"), 1L, 1);

                    b.Property<string>("ImgSrc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("IceCreamID");

                    b.ToTable("IceCreams");
                });

            modelBuilder.Entity("Zelda.Models.Order", b =>
                {
                    b.Property<Guid>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionalPhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("AlternativeAddrresID")
                        .HasColumnType("int");

                    b.Property<string>("CostumerID")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<int?>("OrderedIceCreamID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("ToopingSyropID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("ToppingID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("CostumerID");

                    b.HasIndex("OrderedIceCreamID");

                    b.HasIndex("ToopingSyropID");

                    b.HasIndex("ToppingID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Zelda.Models.Syrop", b =>
                {
                    b.Property<int>("SyropID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SyropID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("imgSrc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SyropID");

                    b.ToTable("Syrops");
                });

            modelBuilder.Entity("Zelda.Models.Topping", b =>
                {
                    b.Property<int>("ToppingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ToppingID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("imgSrc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ToppingID");

                    b.ToTable("Topping");
                });

            modelBuilder.Entity("Zelda.Models.Costumer", b =>
                {
                    b.HasOne("Zelda.Models.Address", "Adrress")
                        .WithMany()
                        .HasForeignKey("AdrressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adrress");
                });

            modelBuilder.Entity("Zelda.Models.Order", b =>
                {
                    b.HasOne("Zelda.Models.Costumer", "Costumer")
                        .WithMany()
                        .HasForeignKey("CostumerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Zelda.Models.IceCream", "OrderedIceCream")
                        .WithMany()
                        .HasForeignKey("OrderedIceCreamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Zelda.Models.Syrop", "ToopingSyrop")
                        .WithMany()
                        .HasForeignKey("ToopingSyropID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Zelda.Models.Topping", "Top")
                        .WithMany()
                        .HasForeignKey("ToppingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Costumer");

                    b.Navigation("OrderedIceCream");

                    b.Navigation("ToopingSyrop");

                    b.Navigation("Top");
                });
#pragma warning restore 612, 618
        }
    }
}
