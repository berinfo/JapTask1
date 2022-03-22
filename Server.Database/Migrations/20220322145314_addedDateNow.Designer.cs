﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using server.Datas;

namespace server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220322145314_addedDateNow")]
    partial class addedDateNow
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

            modelBuilder.Entity("server.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PurchasePrice")
                        .HasColumnType("real");

                    b.Property<int>("PurchaseQuantity")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseUnit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 3, 22, 15, 53, 14, 526, DateTimeKind.Local).AddTicks(2579),
                            Name = "Oil",
                            PurchasePrice = 3f,
                            PurchaseQuantity = 1,
                            PurchaseUnit = 4
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 3, 22, 15, 53, 14, 526, DateTimeKind.Local).AddTicks(3493),
                            Name = "Flour",
                            PurchasePrice = 30f,
                            PurchaseQuantity = 25,
                            PurchaseUnit = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 3, 22, 15, 53, 14, 526, DateTimeKind.Local).AddTicks(3505),
                            Name = "Sugar",
                            PurchasePrice = 3f,
                            PurchaseQuantity = 1,
                            PurchaseUnit = 2
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 3, 22, 15, 53, 14, 526, DateTimeKind.Local).AddTicks(3508),
                            Name = "Salt",
                            PurchasePrice = 2f,
                            PurchaseQuantity = 1,
                            PurchaseUnit = 2
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 3, 22, 15, 53, 14, 526, DateTimeKind.Local).AddTicks(3511),
                            Name = "Olive Oil",
                            PurchasePrice = 20f,
                            PurchaseQuantity = 1,
                            PurchaseUnit = 4
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 3, 22, 15, 53, 14, 526, DateTimeKind.Local).AddTicks(3514),
                            Name = "Egg",
                            PurchasePrice = 9f,
                            PurchaseQuantity = 30,
                            PurchaseUnit = 0
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 3, 22, 15, 53, 14, 526, DateTimeKind.Local).AddTicks(3516),
                            Name = "Chicken meat",
                            PurchasePrice = 10f,
                            PurchaseQuantity = 1,
                            PurchaseUnit = 2
                        });
                });

            modelBuilder.Entity("server.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("server.Models.RecipeIngredients", b =>
                {
                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Unit")
                        .HasColumnType("int");

                    b.HasKey("IngredientId", "RecipeId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredients");
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
                            PasswordHash = new byte[] { 243, 230, 38, 90, 147, 64, 133, 82, 12, 12, 233, 242, 94, 145, 21, 121, 78, 106, 231, 246, 80, 237, 44, 114, 54, 246, 252, 239, 19, 66, 137, 243, 187, 102, 138, 206, 137, 251, 46, 100, 185, 29, 193, 56, 201, 126, 223, 123, 128, 76, 119, 154, 24, 23, 19, 150, 116, 98, 234, 17, 243, 136, 168, 9 },
                            PasswordSalt = new byte[] { 80, 210, 44, 36, 23, 3, 113, 55, 132, 253, 30, 174, 33, 86, 169, 246, 80, 97, 190, 30, 253, 45, 251, 220, 34, 99, 26, 47, 207, 250, 95, 30, 45, 215, 4, 110, 214, 110, 207, 209, 171, 40, 160, 152, 42, 230, 160, 7, 70, 91, 95, 167, 142, 133, 121, 248, 34, 46, 16, 100, 60, 103, 184, 195, 61, 203, 1, 51, 180, 210, 0, 73, 148, 7, 25, 133, 159, 53, 34, 10, 105, 169, 160, 78, 54, 185, 30, 51, 136, 203, 5, 149, 12, 65, 193, 18, 199, 146, 247, 122, 176, 39, 203, 143, 202, 186, 231, 143, 208, 86, 148, 23, 54, 141, 131, 54, 64, 207, 192, 204, 150, 175, 27, 201, 5, 190, 66, 252 },
                            Username = "user123"
                        });
                });

            modelBuilder.Entity("server.Models.Recipe", b =>
                {
                    b.HasOne("server.Models.Category", "Category")
                        .WithMany("Recipes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("server.Models.RecipeIngredients", b =>
                {
                    b.HasOne("server.Models.Ingredient", "Ingredient")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("server.Models.Recipe", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("server.Models.Category", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("server.Models.Ingredient", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("server.Models.Recipe", b =>
                {
                    b.Navigation("RecipeIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}