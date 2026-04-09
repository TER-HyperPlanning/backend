using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSoftDeleteToCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Course",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Course",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "014c457e-a48a-d25e-7781-d5e483cb3dd9",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "02e0e667-183a-1225-d0ed-19fe4c25f963",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "03241339-1186-a90f-33bd-a9850f603619",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "083b85af-c2e8-d7eb-0cca-13cbad93f7df",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "1cb2dee1-fb12-6e48-69ea-2be4c527cbf0",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "24027d5d-e151-9a00-fd19-ac11d27b8189",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "2af630c1-de0d-944f-0b87-a73f1c90644f",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "2d4557a7-a48d-9926-3e2b-bc820396b11a",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "3448ddd0-694c-35d0-f117-7d5834e6ca81",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "3aed7e82-31b6-d05a-3f46-f2ef085d313e",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "3b835d91-4f08-07ef-d4d5-575947097601",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "49ba4385-063d-7b8d-5f3f-aa1c7f573747",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "731ac32d-6ea9-f15e-7ca2-34f99e840bd3",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "93b97065-831b-a4dc-8179-be986f0772b8",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "c0452911-4948-9cb2-aed9-7b949c0b6442",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "c3cd3947-214d-3130-b938-a5d19a0e8eaa",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "cf512e7a-117b-71d0-a07f-43e743dad7eb",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "d059db13-ac91-760c-5bf7-6c442946e7bf",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "e9cbe024-5789-9dca-e8c8-418b70f033cb",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "f8c83971-d090-c665-8911-cd645e1a3c87",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "fb30b659-6817-4099-e7cb-d7c254532603",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Course");
        }
    }
}
