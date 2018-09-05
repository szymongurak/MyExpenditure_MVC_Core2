using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyExpenditures.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expenditures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PurchasedItem = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    MonthOfPurchase = table.Column<string>(nullable: true),
                    YearOfPurchase = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenditures", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Expenditures",
                columns: new[] { "Id", "Category", "MonthOfPurchase", "Price", "PurchasedItem", "YearOfPurchase" },
                values: new object[,]
                {
                    { 1, "Electronic devices", "June", 1550.0m, "Samsung S7 Edge", 2018 },
                    { 2, "Electronic devices", "June", 168.0m, "Xiaomi MI Band 3", 2018 },
                    { 3, "Hobby", "August", 65.0m, "Bicycle chain", 2018 },
                    { 4, "Food", "August", 32.5m, "Pizza", 2018 },
                    { 5, "Clothes", "August", 49.0m, "T-shirt", 2018 },
                    { 6, "Car", "August", 179.8m, "Petrol", 2018 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenditures");
        }
    }
}
