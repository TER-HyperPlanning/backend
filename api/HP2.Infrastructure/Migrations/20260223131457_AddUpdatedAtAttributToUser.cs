using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUpdatedAtAttributToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f",
                column: "date",
                value: new DateTime(2026, 3, 2, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 23, 13, 14, 57, 76, DateTimeKind.Utc).AddTicks(6986), "$2b$12$RnmWIN1BGxHRaUGOy1nE3eFDeIcxygIgm.eQwy2Fwq54HKtSeK0zS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 23, 13, 14, 57, 374, DateTimeKind.Utc).AddTicks(4987), "$2b$12$CQ4XOgBc7EolHGCDXBUsEeKoWcIrIYy8Ha1nw9KEZgUZGoSnre17m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 23, 13, 14, 57, 669, DateTimeKind.Utc).AddTicks(6272), "$2b$12$q4xHD3m9.kzlCSkueUnpeuzsODntgdhlteX5NxJ4ZZl9hzjchL/yC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "User");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f",
                column: "date",
                value: new DateTime(2026, 2, 19, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 2, 12, 12, 2, 42, 711, DateTimeKind.Utc).AddTicks(9625), "$2b$12$MwhPrea2aOC/E1wcu.XCruprJ0W57R8B07q09URIwHJceR6eaZsO2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 2, 12, 12, 2, 42, 981, DateTimeKind.Utc).AddTicks(4374), "$2b$12$GAeajJap/COJCUnBkTb//Oc4JCSo7bsxQwdhNLza45Bk0nBNSqLsS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 2, 12, 12, 2, 43, 251, DateTimeKind.Utc).AddTicks(8153), "$2b$12$8n3zSaJbAb.Lqc2KwVeq8eQNkXI0r./KaBpadhWebSxl9mh9u6eii" });
        }
    }
}
