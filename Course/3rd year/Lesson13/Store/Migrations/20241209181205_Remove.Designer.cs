﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store.Models;

#nullable disable

namespace Store.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20241209181205_Remove")]
    partial class Remove
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Store.Models.Entity.BuyerEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("Store.Models.Entity.OrderEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("BuyerIdId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BuyerIdId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Store.Models.Entity.ProductEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Store.Models.Entity.OrderEntity", b =>
                {
                    b.HasOne("Store.Models.Entity.BuyerEntity", "BuyerId")
                        .WithMany()
                        .HasForeignKey("BuyerIdId");

                    b.Navigation("BuyerId");
                });
#pragma warning restore 612, 618
        }
    }
}