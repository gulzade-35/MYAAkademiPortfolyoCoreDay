using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioCoreDay.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkAreaName",
                table: "WorkAreas",
                newName: "WorkTitle4");

            migrationBuilder.AddColumn<string>(
                name: "WorkTitle1",
                table: "WorkAreas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkTitle2",
                table: "WorkAreas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkTitle3",
                table: "WorkAreas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkTitle1",
                table: "WorkAreas");

            migrationBuilder.DropColumn(
                name: "WorkTitle2",
                table: "WorkAreas");

            migrationBuilder.DropColumn(
                name: "WorkTitle3",
                table: "WorkAreas");

            migrationBuilder.RenameColumn(
                name: "WorkTitle4",
                table: "WorkAreas",
                newName: "WorkAreaName");
        }
    }
}
