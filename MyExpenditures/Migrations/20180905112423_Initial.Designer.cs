﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyExpenditures.DbModels;

namespace MyExpenditures.Migrations
{
    [DbContext(typeof(ExpenditureDbContext))]
    [Migration("20180905112423_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyExpenditures.DbModels.Expenditure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<string>("MonthOfPurchase");

                    b.Property<decimal>("Price");

                    b.Property<string>("PurchasedItem");

                    b.Property<int>("YearOfPurchase");

                    b.HasKey("Id");

                    b.ToTable("Expenditures");

                    b.HasData(
                        new { Id = 1, Category = "Electronic devices", MonthOfPurchase = "June", Price = 1550.0m, PurchasedItem = "Samsung S7 Edge", YearOfPurchase = 2018 },
                        new { Id = 2, Category = "Electronic devices", MonthOfPurchase = "June", Price = 168.0m, PurchasedItem = "Xiaomi MI Band 3", YearOfPurchase = 2018 },
                        new { Id = 3, Category = "Hobby", MonthOfPurchase = "August", Price = 65.0m, PurchasedItem = "Bicycle chain", YearOfPurchase = 2018 },
                        new { Id = 4, Category = "Food", MonthOfPurchase = "August", Price = 32.5m, PurchasedItem = "Pizza", YearOfPurchase = 2018 },
                        new { Id = 5, Category = "Clothes", MonthOfPurchase = "August", Price = 49.0m, PurchasedItem = "T-shirt", YearOfPurchase = 2018 },
                        new { Id = 6, Category = "Car", MonthOfPurchase = "August", Price = 179.8m, PurchasedItem = "Petrol", YearOfPurchase = 2018 }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
