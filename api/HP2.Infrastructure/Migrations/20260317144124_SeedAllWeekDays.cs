using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedAllWeekDays : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f",
                column: "date",
                value: new DateTime(2026, 3, 24, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 17, 14, 41, 22, 790, DateTimeKind.Utc).AddTicks(1650), "$2b$12$sp9hThU4xbUCDU5RZVIpPeWOEhGGlyyLh7WHGlXXE2lqkEkm5fIi." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 17, 14, 41, 23, 288, DateTimeKind.Utc).AddTicks(2975), "$2b$12$Su0VDQMZ6dZTI6VBUdMw1OHR8AYXfOeg8TuHznyEXaV7nmqTgwLr6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 17, 14, 41, 23, 797, DateTimeKind.Utc).AddTicks(955), "$2b$12$YFbmIMr9kImvZIFT3jQP8.Lw6b.m/zJXprnQWBWjCoJwGXo20Gz6q" });

            migrationBuilder.InsertData(
                table: "WeekDay",
                columns: new[] { "weekday_id", "name", "order_index" },
                values: new object[,]
                {
                    { "41005c9e-5360-bb11-50eb-28be4d5446a8", "Mardi", (byte)2 },
                    { "8d4e36a1-7dc6-f59d-464c-ab18a938a58e", "Samedi", (byte)6 },
                    { "9cf80bf4-1ccf-677a-2b2c-988fa321d2a5", "Vendredi", (byte)5 },
                    { "cbfef8cb-fcc1-8dff-8dec-6c7d0485236e", "Mercredi", (byte)3 },
                    { "d0f05ca8-6b62-5d90-1d6a-f680ddd4b45a", "Dimanche", (byte)7 },
                    { "eeb11a2e-98d0-2688-f2bb-e3ef7a7b021b", "Jeudi", (byte)4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WeekDay",
                keyColumn: "weekday_id",
                keyValue: "41005c9e-5360-bb11-50eb-28be4d5446a8");

            migrationBuilder.DeleteData(
                table: "WeekDay",
                keyColumn: "weekday_id",
                keyValue: "8d4e36a1-7dc6-f59d-464c-ab18a938a58e");

            migrationBuilder.DeleteData(
                table: "WeekDay",
                keyColumn: "weekday_id",
                keyValue: "9cf80bf4-1ccf-677a-2b2c-988fa321d2a5");

            migrationBuilder.DeleteData(
                table: "WeekDay",
                keyColumn: "weekday_id",
                keyValue: "cbfef8cb-fcc1-8dff-8dec-6c7d0485236e");

            migrationBuilder.DeleteData(
                table: "WeekDay",
                keyColumn: "weekday_id",
                keyValue: "d0f05ca8-6b62-5d90-1d6a-f680ddd4b45a");

            migrationBuilder.DeleteData(
                table: "WeekDay",
                keyColumn: "weekday_id",
                keyValue: "eeb11a2e-98d0-2688-f2bb-e3ef7a7b021b");

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
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 2, 23, 13, 14, 57, 76, DateTimeKind.Utc).AddTicks(6986), "$2b$12$RnmWIN1BGxHRaUGOy1nE3eFDeIcxygIgm.eQwy2Fwq54HKtSeK0zS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 2, 23, 13, 14, 57, 374, DateTimeKind.Utc).AddTicks(4987), "$2b$12$CQ4XOgBc7EolHGCDXBUsEeKoWcIrIYy8Ha1nw9KEZgUZGoSnre17m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 2, 23, 13, 14, 57, 669, DateTimeKind.Utc).AddTicks(6272), "$2b$12$q4xHD3m9.kzlCSkueUnpeuzsODntgdhlteX5NxJ4ZZl9hzjchL/yC" });
        }
    }
}
