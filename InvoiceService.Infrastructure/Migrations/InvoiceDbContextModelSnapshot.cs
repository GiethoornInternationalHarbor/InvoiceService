﻿// <auto-generated />
using InvoiceService.Core.Models;
using InvoiceService.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace InvoiceService.Infrastructure.Migrations
{
    [DbContext(typeof(InvoiceDbContext))]
    partial class InvoiceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InvoiceService.Core.Models.Customer", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("PostalCode")
                        .IsRequired();

                    b.Property<string>("Residence")
                        .IsRequired();

                    b.HasKey("Email");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("InvoiceService.Core.Models.Invoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerEmail")
                        .IsRequired();

                    b.Property<double>("Price");

                    b.Property<Guid>("ShipId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerEmail");

                    b.HasIndex("ShipId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("InvoiceService.Core.Models.InvoiceLine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("InvoiceId");

                    b.Property<int>("InvoiceType");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.ToTable("InvoiceLines");
                });

            modelBuilder.Entity("InvoiceService.Core.Models.Ship", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Ships");
                });

            modelBuilder.Entity("InvoiceService.Core.Models.ShipService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Price");

                    b.Property<Guid?>("ShipId");

                    b.HasKey("Id");

                    b.HasIndex("ShipId");

                    b.ToTable("ShipServices");
                });

            modelBuilder.Entity("InvoiceService.Core.Models.Invoice", b =>
                {
                    b.HasOne("InvoiceService.Core.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerEmail")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InvoiceService.Core.Models.Ship", "Ship")
                        .WithMany()
                        .HasForeignKey("ShipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InvoiceService.Core.Models.InvoiceLine", b =>
                {
                    b.HasOne("InvoiceService.Core.Models.Invoice")
                        .WithMany("Lines")
                        .HasForeignKey("InvoiceId");
                });

            modelBuilder.Entity("InvoiceService.Core.Models.ShipService", b =>
                {
                    b.HasOne("InvoiceService.Core.Models.Ship")
                        .WithMany("ShipServices")
                        .HasForeignKey("ShipId");
                });
#pragma warning restore 612, 618
        }
    }
}