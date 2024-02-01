﻿// <auto-generated />
using DotNet__1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotNet__1.Migrations
{
    [DbContext(typeof(TransactionDbContext))]
    [Migration("20240131162222_Initial Create")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DotNet__1.Models.Transaction", b =>
                {
                    b.Property<int>("transactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("transactionID"));

                    b.Property<string>("bankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("transactionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("transactionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("transactionID");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}