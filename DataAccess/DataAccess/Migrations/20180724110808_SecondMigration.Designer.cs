﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180724110808_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<DateTime>("AddedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2018, 7, 24, 14, 8, 8, 794, DateTimeKind.Local));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("DataAccess.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataAccess.Entities.Post", b =>
                {
                    b.HasOne("DataAccess.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
