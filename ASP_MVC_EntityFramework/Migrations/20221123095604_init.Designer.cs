﻿// <auto-generated />
using ASP_MVC_EntityFramework.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP_MVC_EntityFramework.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221123095604_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASP_MVC_EntityFramework.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CountryId = 1,
                            Name = "Paris"
                        },
                        new
                        {
                            CityId = 2,
                            CountryId = 1,
                            Name = "Nantes"
                        },
                        new
                        {
                            CityId = 3,
                            CountryId = 2,
                            Name = "Ljusdal"
                        },
                        new
                        {
                            CityId = 4,
                            CountryId = 2,
                            Name = "Boden"
                        },
                        new
                        {
                            CityId = 5,
                            CountryId = 3,
                            Name = "Skagen"
                        },
                        new
                        {
                            CityId = 6,
                            CountryId = 3,
                            Name = "Odense"
                        });
                });

            modelBuilder.Entity("ASP_MVC_EntityFramework.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            Name = "France"
                        },
                        new
                        {
                            CountryId = 2,
                            Name = "Sweden"
                        },
                        new
                        {
                            CountryId = 3,
                            Name = "Denmark"
                        });
                });

            modelBuilder.Entity("ASP_MVC_EntityFramework.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Name = "Kalle Person",
                            PhoneNumber = "555-5555"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 2,
                            Name = "Jennie Antonsson",
                            PhoneNumber = "444-4444"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 3,
                            Name = "Wendely Blom",
                            PhoneNumber = "222-2222"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 4,
                            Name = "Belly Button",
                            PhoneNumber = "000-4444"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 5,
                            Name = "Alma Starstruck",
                            PhoneNumber = "888-4444"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 6,
                            Name = "Hugo Magnusson",
                            PhoneNumber = "999-9999"
                        });
                });

            modelBuilder.Entity("ASP_MVC_EntityFramework.Models.City", b =>
                {
                    b.HasOne("ASP_MVC_EntityFramework.Models.Country", null)
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP_MVC_EntityFramework.Models.Person", b =>
                {
                    b.HasOne("ASP_MVC_EntityFramework.Models.City", "City")
                        .WithMany("Persons")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("ASP_MVC_EntityFramework.Models.City", b =>
                {
                    b.Navigation("Persons");
                });

            modelBuilder.Entity("ASP_MVC_EntityFramework.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
