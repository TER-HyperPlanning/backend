using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCapacityFieldToGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "capacity",
                table: "Group",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "group_id",
                keyValue: "57bf1149-8880-c27c-d603-3546214d03a8",
                column: "capacity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "group_id",
                keyValue: "64b93cdc-56f3-906f-6e4c-2adfe2184501",
                column: "capacity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "group_id",
                keyValue: "e61277a9-9d07-5b53-e623-528bf88a6962",
                column: "capacity",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "capacity",
                table: "Group");
        }
    }
}
