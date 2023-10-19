﻿// <auto-generated />
using System;
using Employee.Infrastructure.Presistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Employee.Infrastructure.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Employee.Model.Countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Courencies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryName");

                    b.ToTable("Country", "Emp");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryName = "BanglaDesh",
                            Courencies = "Taka",
                            Created = new DateTimeOffset(new DateTime(2023, 10, 18, 12, 23, 7, 55, DateTimeKind.Unspecified).AddTicks(2076), new TimeSpan(0, 6, 0, 0, 0)),
                            CreatedBy = "1",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CountryName = "India",
                            Courencies = "Rupi",
                            Created = new DateTimeOffset(new DateTime(2023, 10, 18, 12, 23, 7, 55, DateTimeKind.Unspecified).AddTicks(2108), new TimeSpan(0, 6, 0, 0, 0)),
                            CreatedBy = "1",
                            Status = 1
                        });
                });

            modelBuilder.Entity("Employee.Model.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset?>("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("FirstName");

                    b.HasIndex("StateId");

                    b.ToTable("Employee", "Emp");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Dhaka",
                            Age = 26,
                            CountryId = 1,
                            Created = new DateTimeOffset(new DateTime(2023, 10, 18, 12, 23, 7, 56, DateTimeKind.Unspecified).AddTicks(8559), new TimeSpan(0, 6, 0, 0, 0)),
                            CreatedBy = "1",
                            FirstName = "M.A. Monaem",
                            LastName = "Khan",
                            PhoneNumber = "01303271849",
                            StateId = 1,
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            Address = "Dhaka",
                            Age = 26,
                            CountryId = 2,
                            Created = new DateTimeOffset(new DateTime(2023, 10, 18, 12, 23, 7, 56, DateTimeKind.Unspecified).AddTicks(8589), new TimeSpan(0, 6, 0, 0, 0)),
                            CreatedBy = "1",
                            FirstName = "M.A.",
                            LastName = "Khan",
                            PhoneNumber = "013",
                            StateId = 3,
                            Status = 1
                        });
                });

            modelBuilder.Entity("Employee.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BarCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountriesId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RatingPrice")
                        .HasColumnType("int");

                    b.Property<int>("SellPrice")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountriesId");

                    b.HasIndex("ProductName");

                    b.ToTable("Product", "Emp");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BarCode = "1234",
                            CountryId = 1,
                            Created = new DateTimeOffset(new DateTime(2023, 10, 18, 12, 23, 7, 57, DateTimeKind.Unspecified).AddTicks(2740), new TimeSpan(0, 6, 0, 0, 0)),
                            Description = "Taka",
                            ProductName = "Computer",
                            RatingPrice = 400,
                            SellPrice = 1,
                            Status = 1
                        });
                });

            modelBuilder.Entity("Employee.Model.States", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("StateName");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Created = new DateTimeOffset(new DateTime(2023, 10, 18, 12, 23, 7, 58, DateTimeKind.Unspecified).AddTicks(232), new TimeSpan(0, 6, 0, 0, 0)),
                            CreatedBy = "1",
                            StateName = "Dhaka",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Created = new DateTimeOffset(new DateTime(2023, 10, 18, 12, 23, 7, 58, DateTimeKind.Unspecified).AddTicks(254), new TimeSpan(0, 6, 0, 0, 0)),
                            CreatedBy = "1",
                            StateName = "Rajshahi",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 2,
                            Created = new DateTimeOffset(new DateTime(2023, 10, 18, 12, 23, 7, 58, DateTimeKind.Unspecified).AddTicks(256), new TimeSpan(0, 6, 0, 0, 0)),
                            CreatedBy = "1",
                            StateName = "Mumbai",
                            Status = 1
                        });
                });

            modelBuilder.Entity("Employee.Model.Employees", b =>
                {
                    b.HasOne("Employee.Model.Countries", "Countries")
                        .WithMany("Employees")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Employee.Model.States", "States")
                        .WithMany("Employees")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Countries");

                    b.Navigation("States");
                });

            modelBuilder.Entity("Employee.Model.Product", b =>
                {
                    b.HasOne("Employee.Model.Countries", "Countries")
                        .WithMany("Products")
                        .HasForeignKey("CountriesId");

                    b.Navigation("Countries");
                });

            modelBuilder.Entity("Employee.Model.States", b =>
                {
                    b.HasOne("Employee.Model.Countries", "Countries")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Countries");
                });

            modelBuilder.Entity("Employee.Model.Countries", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Products");

                    b.Navigation("States");
                });

            modelBuilder.Entity("Employee.Model.States", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
