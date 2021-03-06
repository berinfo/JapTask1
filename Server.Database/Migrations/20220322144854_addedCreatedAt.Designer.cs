// <auto-generated />
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
    [Migration("20220322144854_addedCreatedAt")]
    partial class addedCreatedAt
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
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Oil",
                            PurchasePrice = 3f,
                            PurchaseQuantity = 1,
                            PurchaseUnit = 4
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Flour",
                            PurchasePrice = 30f,
                            PurchaseQuantity = 25,
                            PurchaseUnit = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sugar",
                            PurchasePrice = 3f,
                            PurchaseQuantity = 1,
                            PurchaseUnit = 2
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Salt",
                            PurchasePrice = 2f,
                            PurchaseQuantity = 1,
                            PurchaseUnit = 2
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Olive Oil",
                            PurchasePrice = 20f,
                            PurchaseQuantity = 1,
                            PurchaseUnit = 4
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Egg",
                            PurchasePrice = 9f,
                            PurchaseQuantity = 30,
                            PurchaseUnit = 0
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
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
                            PasswordHash = new byte[] { 163, 24, 88, 247, 182, 193, 202, 14, 7, 193, 79, 91, 122, 198, 28, 73, 253, 79, 114, 17, 47, 114, 49, 182, 31, 119, 129, 132, 7, 171, 186, 7, 37, 166, 54, 255, 118, 137, 45, 150, 210, 22, 213, 129, 202, 1, 206, 76, 112, 36, 235, 250, 169, 126, 227, 90, 64, 102, 169, 77, 219, 99, 172, 185 },
                            PasswordSalt = new byte[] { 192, 39, 154, 37, 189, 25, 0, 243, 250, 234, 71, 44, 94, 92, 219, 222, 73, 35, 180, 85, 28, 140, 250, 88, 36, 26, 39, 27, 3, 65, 44, 195, 247, 19, 199, 112, 142, 221, 142, 131, 55, 189, 191, 143, 126, 201, 108, 217, 215, 12, 94, 185, 243, 55, 12, 33, 71, 169, 102, 230, 162, 163, 249, 137, 142, 241, 233, 29, 157, 107, 159, 115, 173, 219, 194, 151, 65, 53, 237, 17, 111, 242, 107, 187, 75, 249, 134, 233, 234, 174, 133, 98, 235, 91, 2, 60, 6, 52, 151, 106, 114, 182, 183, 184, 17, 177, 55, 255, 195, 15, 148, 56, 47, 79, 54, 65, 71, 114, 109, 143, 18, 200, 79, 187, 118, 46, 20, 161 },
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
