﻿// <auto-generated />
using System;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.5.24306.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Manila, Philippines",
                            DateOfBirth = new DateOnly(2002, 8, 12),
                            FirstName = "Nathaniel",
                            LastName = "Alvarez",
                            ProfilePicture = ""
                        },
                        new
                        {
                            Id = 2,
                            Address = "Quezon City, Philippines",
                            DateOfBirth = new DateOnly(2002, 8, 12),
                            FirstName = "Alyssa",
                            LastName = "Gonzales",
                            ProfilePicture = ""
                        },
                        new
                        {
                            Id = 3,
                            Address = "Cebu City, Philippines",
                            DateOfBirth = new DateOnly(2002, 8, 12),
                            FirstName = "Joshua",
                            LastName = "Reyes",
                            ProfilePicture = ""
                        },
                        new
                        {
                            Id = 4,
                            Address = "Davao City, Philippines",
                            DateOfBirth = new DateOnly(2002, 8, 12),
                            FirstName = "Isabella",
                            LastName = "Santos",
                            ProfilePicture = ""
                        },
                        new
                        {
                            Id = 5,
                            Address = "Makati, Philippines",
                            DateOfBirth = new DateOnly(2002, 8, 12),
                            FirstName = "Miguel",
                            LastName = "Torres",
                            ProfilePicture = ""
                        },
                        new
                        {
                            Id = 6,
                            Address = "Pasig, Philippines",
                            DateOfBirth = new DateOnly(2002, 8, 12),
                            FirstName = "Sophia",
                            LastName = "Cruz",
                            ProfilePicture = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
