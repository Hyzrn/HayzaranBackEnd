﻿// <auto-generated />
using Hayzaran.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hayzaran.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201121150906_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Hayzaran.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Kalemler"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Defterler"
                        });
                });

            modelBuilder.Entity("Hayzaran.Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("InnerBarcode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            IsDeleted = false,
                            Name = "Pilot Kalem",
                            Price = 12.50m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            IsDeleted = false,
                            Name = "Kurşun Kalem",
                            Price = 40.00m,
                            Stock = 200
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            IsDeleted = false,
                            Name = "Tükenmez Kalem",
                            Price = 500.00m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            IsDeleted = false,
                            Name = "Küçük Boy Defter",
                            Price = 12.50m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            IsDeleted = false,
                            Name = "Orta Boy Defter",
                            Price = 12.50m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            IsDeleted = false,
                            Name = "Büyük Boy Defter",
                            Price = 12.50m,
                            Stock = 100
                        });
                });

            modelBuilder.Entity("Hayzaran.Core.Entities.Product", b =>
                {
                    b.HasOne("Hayzaran.Core.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Hayzaran.Core.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}