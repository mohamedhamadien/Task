using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
               name: "Color",
               table: "Product",
               type: "nvarchar(10)",
               maxLength: 10,
               nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Product",
                type: "numeric(12, 2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                 name: "Color",
                 table: "Product");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Product");
        }
    }
}
