using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyTask.DataAccess.Migrations
{
    public partial class UpdateMemberV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avtar",
                table: "Member");

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Member",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Member");

            migrationBuilder.AddColumn<string>(
                name: "Avtar",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
