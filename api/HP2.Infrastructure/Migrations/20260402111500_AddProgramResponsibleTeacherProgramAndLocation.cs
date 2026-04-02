using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    public partial class AddProgramResponsibleTeacherProgramAndLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "responsible_teacher_id",
                table: "Program",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "location",
                table: "Program",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "program",
                table: "Program",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Program_responsible_teacher_id",
                table: "Program",
                column: "responsible_teacher_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Program_Teacher",
                table: "Program",
                column: "responsible_teacher_id",
                principalTable: "Teacher",
                principalColumn: "user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Program_Teacher",
                table: "Program");

            migrationBuilder.DropIndex(
                name: "IX_Program_responsible_teacher_id",
                table: "Program");

            migrationBuilder.DropColumn(
                name: "responsible_teacher_id",
                table: "Program");

            migrationBuilder.DropColumn(
                name: "location",
                table: "Program");

            migrationBuilder.DropColumn(
                name: "program",
                table: "Program");
        }
    }
}
