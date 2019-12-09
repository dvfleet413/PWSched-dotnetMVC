﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PWSched_dotnet_mvc.Data;

namespace PWSched_dotnet_mvc.Migrations
{
    [DbContext(typeof(PWSchedContext))]
    partial class PWSchedContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("PWSched_dotnet_mvc.Models.Shift", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ShiftDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Volunteer")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Shift");
                });
#pragma warning restore 612, 618
        }
    }
}
