﻿// <auto-generated />
using AspNetCore_CRUD_With_EFCORE_Empty.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNetCoreCRUDWithEFCOREEmpty.Migrations
{
    [DbContext(typeof(iakademi45Context))]
    [Migration("20221228164520_iakademi45Create")]
    partial class iakademi45Create
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AspNetCore_CRUD_With_EFCORE_Empty.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StudentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}