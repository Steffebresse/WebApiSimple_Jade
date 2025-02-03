﻿// <auto-generated />
using System;
using DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DbContext.Migrations.SqlServerDbContext
{
    [DbContext(typeof(MainDbContext.SqlServerDbContext))]
    partial class SqlServerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DbModels.AddressDbM", b =>
                {
                    b.Property<Guid>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Seeded")
                        .HasColumnType("bit");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses", "supusr");
                });

            modelBuilder.Entity("DbModels.AttractionDbM", b =>
                {
                    b.Property<Guid>("AttractionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AddressDbMAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryDbMCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Seeded")
                        .HasColumnType("bit");

                    b.HasKey("AttractionId");

                    b.HasIndex("AddressDbMAddressId");

                    b.HasIndex("CategoryDbMCategoryId");

                    b.ToTable("Attractions", "supusr");
                });

            modelBuilder.Entity("DbModels.CategoryDbM", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Catkind")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<bool>("Seeded")
                        .HasColumnType("bit");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories", "supusr");
                });

            modelBuilder.Entity("DbModels.MusicGroupDbM", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EstablshedYear")
                        .HasColumnType("int");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("MusicGroups", "supusr");
                });

            modelBuilder.Entity("Models.DTO.GstUsrInfoDbDto", b =>
                {
                    b.Property<int>("NrAddresses")
                        .HasColumnType("int");

                    b.Property<int>("NrAttractions")
                        .HasColumnType("int");

                    b.Property<int>("NrCategories")
                        .HasColumnType("int");

                    b.ToTable((string)null);

                    b.ToView("vwInfoDb", "gstusr");
                });

            modelBuilder.Entity("DbModels.AttractionDbM", b =>
                {
                    b.HasOne("DbModels.AddressDbM", "AddressDbM")
                        .WithMany("AttractionDbM")
                        .HasForeignKey("AddressDbMAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbModels.CategoryDbM", "CategoryDbM")
                        .WithMany("AttractionsDbM")
                        .HasForeignKey("CategoryDbMCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddressDbM");

                    b.Navigation("CategoryDbM");
                });

            modelBuilder.Entity("DbModels.AddressDbM", b =>
                {
                    b.Navigation("AttractionDbM");
                });

            modelBuilder.Entity("DbModels.CategoryDbM", b =>
                {
                    b.Navigation("AttractionsDbM");
                });
#pragma warning restore 612, 618
        }
    }
}
