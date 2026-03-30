using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSessionTypeLabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f",
                column: "date",
                value: new DateTime(2026, 3, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "SessionType",
                keyColumn: "session_type_id",
                keyValue: "7f2d1749-7a62-0b12-0f4e-3b943af03674",
                column: "label",
                value: "CM");

            migrationBuilder.InsertData(
                table: "SessionType",
                columns: new[] { "session_type_id", "label" },
                values: new object[,]
                {
                    { "a51df269-a2de-07cb-14b1-e5c0f041928c", "TP" },
                    { "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", "TD" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 15, 23, 15, 2, 853, DateTimeKind.Utc).AddTicks(8149), "$2b$12$WonlV0DB87DiYHoJi/5uGO7a8/FNeDhd1VCOkHgdFTaSAb.UM488y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 15, 23, 15, 3, 885, DateTimeKind.Utc).AddTicks(5689), "$2b$12$pQSdwxHj4CaqjcVgCKKVN.sRhihwDKBNDIZoMa2hjEgqoAONF5xHy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 15, 23, 15, 4, 829, DateTimeKind.Utc).AddTicks(7873), "$2b$12$IaeqIzJsuj.YM/SBZCur7.HbOO.vI7../xVwmjSfsl7DYZF2EyMry" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SessionType",
                keyColumn: "session_type_id",
                keyValue: "a51df269-a2de-07cb-14b1-e5c0f041928c");

            migrationBuilder.DeleteData(
                table: "SessionType",
                keyColumn: "session_type_id",
                keyValue: "bf7f6e65-68aa-07ec-c88a-06bc4b897a82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f",
                column: "date",
                value: new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "SessionType",
                keyColumn: "session_type_id",
                keyValue: "7f2d1749-7a62-0b12-0f4e-3b943af03674",
                column: "label",
                value: "Cours Magistral");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 3, 16, 55, 15, 27, DateTimeKind.Utc).AddTicks(1246), "$2b$12$3VwIfm1h7ZjLrWKxTyhPnurTZrfpBooZdAEH5Q6vcuNRXfZL6XIxy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 3, 16, 55, 15, 341, DateTimeKind.Utc).AddTicks(6324), "$2b$12$dwDJPexldvt7HAca10b7puAzjZ/o1RA42o2ab8whhEcl0AcRMgGDi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 3, 16, 55, 15, 624, DateTimeKind.Utc).AddTicks(1280), "$2b$12$EGbKWr51vHfSRzVrkpB3Eee4U6CGSgQIgB6nB5Rm/708iMocxnqLW" });
        }
    }
}
