﻿// <auto-generated />
using HappyCalendarCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HappyCalendarCore.Migrations
{
    [DbContext(typeof(HappyCalendarCoreContext))]
    [Migration("20180930225539_20180930")]
    partial class _20180930
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HappyCalendarCore.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("HappyCalendarCore.Models.HomeBill", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BillDate");

                    b.Property<double>("BillValue");

                    b.Property<string>("Description");

                    b.Property<string>("Who");

                    b.HasKey("ID");

                    b.ToTable("HomeBill");
                });
#pragma warning restore 612, 618
        }
    }
}
