using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSoftDeleteToGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Group",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Group",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "group_id",
                keyValue: "57bf1149-8880-c27c-d603-3546214d03a8",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "group_id",
                keyValue: "64b93cdc-56f3-906f-6e4c-2adfe2184501",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "group_id",
                keyValue: "e61277a9-9d07-5b53-e623-528bf88a6962",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Group");
        }
    }
}
