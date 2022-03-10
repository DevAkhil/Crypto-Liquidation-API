﻿// <auto-generated />
using System;
using CryptoLiquidations.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CryptoLiquidations.Migrations
{
    [DbContext(typeof(CryptoDbContext))]
    [Migration("20220308192912_CryptoDB")]
    partial class CryptoDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CryptoLiquidations.Models.LiquadationData", b =>
                {
                    b.Property<int>("LD_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LD_ID"), 1L, 1);

                    b.Property<string>("LD_12HrLiquidation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LD_1HrLiquidation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LD_24HrLiquidation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LD_4HrLiquidation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LD_Time")
                        .HasColumnType("datetime2");

                    b.HasKey("LD_ID");

                    b.ToTable("Liquidations");
                });

            modelBuilder.Entity("CryptoLiquidations.Models.SymbolLiquidationData", b =>
                {
                    b.Property<int>("SLD_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SLD_ID"), 1L, 1);

                    b.Property<string>("SLD_LiquidationInCrypto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SLD_LiquidationInDollars")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SLD_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SLD_ID");

                    b.ToTable("SymbolLiquidations");
                });
#pragma warning restore 612, 618
        }
    }
}
