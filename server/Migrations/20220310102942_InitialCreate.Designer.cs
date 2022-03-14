﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using server.Data;

namespace server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220310102942_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("server.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 3, 3, 5, 25, 4, 0, DateTimeKind.Unspecified),
                            Name = "Barbecue"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 4, 4, 6, 15, 14, 0, DateTimeKind.Unspecified),
                            Name = "Desert"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2020, 4, 6, 3, 17, 25, 0, DateTimeKind.Unspecified),
                            Name = "Breakfast"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2019, 5, 6, 2, 2, 2, 0, DateTimeKind.Unspecified),
                            Name = "Lunch"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2018, 5, 7, 1, 15, 15, 0, DateTimeKind.Unspecified),
                            Name = "Dinner"
                        });
                });

            modelBuilder.Entity("server.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PasswordHash = new byte[] { 84, 65, 231, 110, 154, 236, 111, 29, 71, 223, 88, 176, 63, 134, 35, 76, 146, 153, 86, 117, 160, 40, 245, 141, 28, 204, 157, 139, 134, 162, 184, 38, 190, 172, 50, 237, 248, 203, 94, 142, 16, 114, 143, 88, 150, 187, 117, 237, 213, 36, 101, 100, 113, 65, 94, 122, 117, 181, 205, 251, 80, 163, 14, 136 },
                            PasswordSalt = new byte[] { 148, 50, 124, 246, 32, 180, 50, 33, 222, 112, 208, 159, 178, 132, 39, 46, 138, 99, 204, 95, 227, 83, 229, 141, 108, 70, 110, 125, 199, 77, 69, 107, 15, 24, 238, 34, 37, 210, 155, 113, 223, 63, 167, 184, 143, 196, 237, 102, 221, 107, 198, 200, 44, 204, 139, 198, 218, 166, 48, 137, 86, 98, 117, 218, 9, 202, 202, 247, 94, 2, 49, 18, 35, 98, 123, 69, 254, 229, 20, 71, 199, 216, 13, 35, 156, 145, 183, 23, 228, 156, 168, 215, 84, 39, 24, 29, 200, 222, 106, 120, 76, 230, 85, 214, 149, 132, 202, 236, 203, 6, 247, 20, 53, 155, 192, 251, 144, 35, 27, 121, 34, 249, 96, 116, 26, 242, 162, 201 },
                            Username = "user123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
