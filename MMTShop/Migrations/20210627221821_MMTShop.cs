using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MMTShop.Migrations
{
    public partial class MMTShop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    StartRange = table.Column<int>(nullable: false),
                    EndRange = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Sku = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Sku);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "EndRange", "Name", "StartRange" },
                values: new object[,]
                {
                    { 1, 19999, "Home", 10000 },
                    { 2, 29999, "Garden", 20000 },
                    { 3, 39999, "Electronics", 30000 },
                    { 4, 49999, "Fitness", 40000 },
                    { 5, 59999, "Toys", 50000 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Sku", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 12000, "Home", "TestA", "A", 100 },
                    { 13000, "Home", "TestB", "B", 100 },
                    { 22000, "Garden", "TestC", "C", 100 },
                    { 23000, "Garden", "TestD", "D", 100 },
                    { 32000, "Electronics", "TestE", "E", 100 },
                    { 33000, "Electronics", "TestF", "F", 100 },
                    { 42000, "Fitness", "TestG", "G", 100 },
                    { 43000, "Fitness", "TestH", "H", 100 },
                    { 52000, "Toys", "TestI", "I", 100 },
                    { 53000, "Toys", "TestJ", "J", 100 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
