﻿// <auto-generated />
using Angular_ASPNETCore_CustomersService.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace Angular_ASPNETCore_CustomersService.Migrations
{
    [DbContext(typeof(CustomersDbContext))]
    [Migration("20170907235845_AppV2")]
    partial class AppV2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Angular_ASPNETCore_CustomersService.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("LastName");

                    b.Property<int>("OrderCount");

                    b.Property<int>("StateId");

                    b.Property<int>("Zip");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Angular_ASPNETCore_CustomersService.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CustomerId");

                    b.Property<decimal>("Price");

                    b.Property<string>("Product");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Angular_ASPNETCore_CustomersService.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abbreviation");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("Angular_ASPNETCore_CustomersService.Models.Customer", b =>
                {
                    b.HasOne("Angular_ASPNETCore_CustomersService.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Angular_ASPNETCore_CustomersService.Models.Order", b =>
                {
                    b.HasOne("Angular_ASPNETCore_CustomersService.Models.Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");
                });
#pragma warning restore 612, 618
        }
    }
}
