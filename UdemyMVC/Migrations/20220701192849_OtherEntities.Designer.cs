﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UdemyMVC.Data;

namespace UdemyMVC.Migrations
{
    [DbContext(typeof(UdemyMVCContext))]
    [Migration("20220701192849_OtherEntities")]
    partial class OtherEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UdemyMVC.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("UdemyMVC.Models.SalesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amonth");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("SallerId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("SallerId");

                    b.ToTable("SalesRecords");
                });

            modelBuilder.Entity("UdemyMVC.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDadte");

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Saller");
                });

            modelBuilder.Entity("UdemyMVC.Models.SalesRecord", b =>
                {
                    b.HasOne("UdemyMVC.Models.Seller", "Saller")
                        .WithMany("Sales")
                        .HasForeignKey("SallerId");
                });

            modelBuilder.Entity("UdemyMVC.Models.Seller", b =>
                {
                    b.HasOne("UdemyMVC.Models.Department")
                        .WithMany("Sallers")
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
