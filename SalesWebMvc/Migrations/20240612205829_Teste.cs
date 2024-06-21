using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class Teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "SalesRecord");

            migrationBuilder.RenameColumn(
                name: "BasySalary",
                table: "Seller",
                newName: "BaseSalary");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BaseSalary",
                table: "Seller",
                newName: "BasySalary");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SalesRecord",
                nullable: true);
        }
    }
}
