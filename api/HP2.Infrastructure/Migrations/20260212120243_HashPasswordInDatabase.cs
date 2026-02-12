using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class HashPasswordInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 2, 12, 11, 7, 39, 385, DateTimeKind.Utc).AddTicks(1560), "$2b$12$Qjkq4kUTT7kabT3EtKzU7OCvGftvB9W2TuNa7oHYpM/YEsf0KAzWm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 2, 12, 11, 7, 39, 637, DateTimeKind.Utc).AddTicks(1978), "$2b$12$EaGtd6/OvqNJVMHacl2eGOskOIAcx2wkwt3PQkXQ.PHHjbnXVbpRq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 2, 12, 11, 7, 39, 637, DateTimeKind.Utc).AddTicks(2455), "pass_jean" });
        }
    }
}
