﻿// <auto-generated />
using Day02;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Day02.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240201000431_CreateBookTable")]
    partial class CreateBookTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Day02.Models2.Book", b =>
                {
                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BookKey")
                        .HasColumnType("int");

                    b.HasKey("Author", "BookName");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
