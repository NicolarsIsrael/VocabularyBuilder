using Microsoft.EntityFrameworkCore.Migrations;

namespace VocaBuilder.Data.Migrations
{
    public partial class lesson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Lesson",
                table: "Word",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CorrectAnswers",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalTrials",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lesson",
                table: "Word");

            migrationBuilder.DropColumn(
                name: "CorrectAnswers",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TotalTrials",
                table: "AspNetUsers");
        }
    }
}
