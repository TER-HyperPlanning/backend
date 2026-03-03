using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedAvailability : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Availability",
                columns: new[] { "availability_id", "end_date", "end_time", "start_date", "start_time", "teacher_id", "weekday_id" },
                values: new object[,]
                {
                    { "165a619b-6704-9577-6d05-311a0aed3321", new DateTime(2026, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0), new DateTime(2026, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0), "455c6918-8f55-8171-e3b6-573e17977cfc", "a1572cec-402d-a254-39ac-c88335d6d1d1" },
                    { "44f1596b-900a-6743-2e95-a4e877064b0c", new DateTime(2026, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2026, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0), "455c6918-8f55-8171-e3b6-573e17977cfc", "a1572cec-402d-a254-39ac-c88335d6d1d1" }
                });

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f",
                column: "date",
                value: new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 3, 12, 30, 49, 468, DateTimeKind.Utc).AddTicks(872), "$2b$12$bUnbFmZ3jZgFKWCuIHssfetCLDhnw.v6usZjuac4rM/14VsAwnlSO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 3, 12, 30, 49, 810, DateTimeKind.Utc).AddTicks(8047), "$2b$12$nIdI1JwPDIasoiryCE0D9.1Mu3GvGAQOwhLxVHNpGhxIlsV/i41He" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 3, 12, 30, 50, 155, DateTimeKind.Utc).AddTicks(3438), "$2b$12$igp5fVxswDuwL/.4b0mNuOKuKX2zT3/L.KtNOXgHERL22MoxpNAH6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Availability",
                keyColumn: "availability_id",
                keyValue: "165a619b-6704-9577-6d05-311a0aed3321");

            migrationBuilder.DeleteData(
                table: "Availability",
                keyColumn: "availability_id",
                keyValue: "44f1596b-900a-6743-2e95-a4e877064b0c");

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
