﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sales.Data;

#nullable disable

namespace sales.Migrations
{
    [DbContext(typeof(RequisitioDbContext))]
    [Migration("20221216053321_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("sales.Models.Requisition", b =>
                {
                    b.Property<Guid>("RequisitionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientCountryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complexity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CurrencyID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DeadlineDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DepartmentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("EstimatedBudget")
                        .HasColumnType("float");

                    b.Property<DateTime>("ExpectedStartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LastUpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LastUpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("PotentialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProjectManagerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProjectType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequisitionCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequisitionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RequisitionStatus")
                        .HasColumnType("int");

                    b.Property<Guid>("SalesPersionUserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RequisitionID");

                    b.ToTable("Requisitions");
                });
#pragma warning restore 612, 618
        }
    }
}
