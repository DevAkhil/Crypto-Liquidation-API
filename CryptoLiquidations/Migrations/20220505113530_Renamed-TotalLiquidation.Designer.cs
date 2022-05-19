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
    [Migration("20220505113530_Renamed-TotalLiquidation")]
    partial class RenamedTotalLiquidation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CryptoLiquidations.Models.LiquidationData", b =>
                {
                    b.Property<int>("LD_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LD_ID"), 1L, 1);

                    b.Property<string>("LD_12HrLiquidation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LD_1HrLiquidation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LD_24HrLiquidation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LD_4HrLiquidation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LD_LargestSingleLiquidation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LD_Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("LD_TotalLiquidations")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LD_ID");

                    b.ToTable("Liquidations");
                });

            modelBuilder.Entity("CryptoLiquidations.Models.LiquidationGraph", b =>
                {
                    b.Property<int>("LG_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LG_ID"), 1L, 1);

                    b.Property<string>("LG_12HourGraph")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LG_1HourGraph")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LG_24HourGraph")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LG_4HourGraph")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LG_Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LG_ID");

                    b.ToTable("LiquidationGraphs");
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
