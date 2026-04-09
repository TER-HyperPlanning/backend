using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSoftDeleteToTracks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Track",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Track",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "track_id",
                keyValue: "16e8879d-d190-3771-1b74-ca91c2f021fe",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "track_id",
                keyValue: "34d303a1-eecd-13ed-de46-36c8efe0f0d5",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "track_id",
                keyValue: "4a9d5b23-9f25-3816-a32e-0f206d9b4bb6",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "track_id",
                keyValue: "4defa7f6-3ce5-c643-a522-861cf94ee2e7",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "track_id",
                keyValue: "5942bd81-7485-6e92-c7e6-66ad363c6bee",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "track_id",
                keyValue: "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "track_id",
                keyValue: "86de5246-d552-d203-3cfb-450e00d82845",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "track_id",
                keyValue: "900f1499-bb04-690c-9394-eeafda3848a4",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "track_id",
                keyValue: "b4f9989d-1aa6-eb1c-b68d-f02b595a4e91",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "track_id",
                keyValue: "ce0e0c1e-322e-f894-4476-dc9682a4bdea",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "track_id",
                keyValue: "e06ac778-10f0-5ca0-04e6-0df679676eb3",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "track_id",
                keyValue: "ec7f0b9a-dbe5-a250-41e3-d2857ef80ccf",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Track");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Track");
        }
    }
}
