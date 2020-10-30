using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyTask.DataAccess.Migrations
{
    public partial class UpdateMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avtar",
                table: "Member",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avtar",
                table: "Member");
        }
    }
}
