using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedUnavailableDay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f",
                column: "date",
                value: new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.InsertData(
                table: "UnavailableDayType",
                columns: new[] { "unavailable_day_type_id", "name" },
                values: new object[,]
                {
                    { "TYPE1", "Congé" },
                    { "TYPE2", "Maladie" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 13, 46, 2, 825, DateTimeKind.Utc).AddTicks(9545), "$2b$12$Bg0v3NwD3c55YnRxziRlUe7OJAyD1yebgjh3mrKiPZOFHP86L6Xee" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 13, 46, 3, 327, DateTimeKind.Utc).AddTicks(4958), "$2b$12$JBsrDeV6j.8.tISfmvKoWOYQ/gIljoQA9IpPOZGfyWIHnGyLXUkp." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 13, 46, 3, 789, DateTimeKind.Utc).AddTicks(7342), "$2b$12$CRdLVe8S2Bws3t//ZkoNluiF2UyZuUaMCoMugQHO0j/8OyR.QGBiq" });

            migrationBuilder.InsertData(
                table: "UnavailableDay",
                columns: new[] { "unavailable_day_id", "end_date", "end_time", "start_date", "start_time", "unavailable_day_type_id" },
                values: new object[,]
                {
                    { "UD1", new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0), new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0), "TYPE1" },
                    { "UD2", new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0), new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0), "TYPE2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UnavailableDay",
                keyColumn: "unavailable_day_id",
                keyValue: "UD1");

            migrationBuilder.DeleteData(
                table: "UnavailableDay",
                keyColumn: "unavailable_day_id",
                keyValue: "UD2");

            migrationBuilder.DeleteData(
                table: "UnavailableDayType",
                keyColumn: "unavailable_day_type_id",
                keyValue: "TYPE1");

            migrationBuilder.DeleteData(
                table: "UnavailableDayType",
                keyColumn: "unavailable_day_type_id",
                keyValue: "TYPE2");

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
