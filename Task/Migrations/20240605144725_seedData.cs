using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ItemID", "Brand", "Color", "ItemName", "Model", "Price" },
                values: new object[,]
                {
                    { 1, "Brand1", "Red", "Item1", "Model1", 10.00m },
                    { 2, "Brand2", "Blue", "Item2", "Model2", 20.00m },
                    { 3, "Brand3", "Green", "Item3", "Model3", 30.00m },
                    { 4, "Brand4", "Yellow", "Item4", "Model4", 40.00m },
                    { 5, "Brand5", "Orange", "Item5", "Model5", 50.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ItemID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ItemID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ItemID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ItemID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ItemID",
                keyValue: 5);
        }
    }
}
