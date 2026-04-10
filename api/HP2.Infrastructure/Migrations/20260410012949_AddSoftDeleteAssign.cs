using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSoftDeleteAssign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Assign",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Assign",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "014c457e-a48a-d25e-7781-d5e483cb3dd9", "34d303a1-eecd-13ed-de46-36c8efe0f0d5" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "02e0e667-183a-1225-d0ed-19fe4c25f963", "34d303a1-eecd-13ed-de46-36c8efe0f0d5" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "03241339-1186-a90f-33bd-a9850f603619", "34d303a1-eecd-13ed-de46-36c8efe0f0d5" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "1cb2dee1-fb12-6e48-69ea-2be4c527cbf0", "34d303a1-eecd-13ed-de46-36c8efe0f0d5" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "24027d5d-e151-9a00-fd19-ac11d27b8189", "34d303a1-eecd-13ed-de46-36c8efe0f0d5" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "2d4557a7-a48d-9926-3e2b-bc820396b11a", "34d303a1-eecd-13ed-de46-36c8efe0f0d5" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", "34d303a1-eecd-13ed-de46-36c8efe0f0d5" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "3448ddd0-694c-35d0-f117-7d5834e6ca81", "34d303a1-eecd-13ed-de46-36c8efe0f0d5" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "3b835d91-4f08-07ef-d4d5-575947097601", "34d303a1-eecd-13ed-de46-36c8efe0f0d5" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "49ba4385-063d-7b8d-5f3f-aa1c7f573747", "34d303a1-eecd-13ed-de46-36c8efe0f0d5" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", "34d303a1-eecd-13ed-de46-36c8efe0f0d5" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "93b97065-831b-a4dc-8179-be986f0772b8", "34d303a1-eecd-13ed-de46-36c8efe0f0d5" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "d059db13-ac91-760c-5bf7-6c442946e7bf", "34d303a1-eecd-13ed-de46-36c8efe0f0d5" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", "34d303a1-eecd-13ed-de46-36c8efe0f0d5" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", "34d303a1-eecd-13ed-de46-36c8efe0f0d5" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", "34d303a1-eecd-13ed-de46-36c8efe0f0d5" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "014c457e-a48a-d25e-7781-d5e483cb3dd9", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "02e0e667-183a-1225-d0ed-19fe4c25f963", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "03241339-1186-a90f-33bd-a9850f603619", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "24027d5d-e151-9a00-fd19-ac11d27b8189", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "2d4557a7-a48d-9926-3e2b-bc820396b11a", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "3448ddd0-694c-35d0-f117-7d5834e6ca81", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "3b835d91-4f08-07ef-d4d5-575947097601", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "49ba4385-063d-7b8d-5f3f-aa1c7f573747", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "93b97065-831b-a4dc-8179-be986f0772b8", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "d059db13-ac91-760c-5bf7-6c442946e7bf", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "f8c83971-d090-c665-8911-cd645e1a3c87", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "014c457e-a48a-d25e-7781-d5e483cb3dd9", "900f1499-bb04-690c-9394-eeafda3848a4" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "03241339-1186-a90f-33bd-a9850f603619", "900f1499-bb04-690c-9394-eeafda3848a4" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "24027d5d-e151-9a00-fd19-ac11d27b8189", "900f1499-bb04-690c-9394-eeafda3848a4" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "2af630c1-de0d-944f-0b87-a73f1c90644f", "900f1499-bb04-690c-9394-eeafda3848a4" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "2d4557a7-a48d-9926-3e2b-bc820396b11a", "900f1499-bb04-690c-9394-eeafda3848a4" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", "900f1499-bb04-690c-9394-eeafda3848a4" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "3aed7e82-31b6-d05a-3f46-f2ef085d313e", "900f1499-bb04-690c-9394-eeafda3848a4" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "3b835d91-4f08-07ef-d4d5-575947097601", "900f1499-bb04-690c-9394-eeafda3848a4" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "49ba4385-063d-7b8d-5f3f-aa1c7f573747", "900f1499-bb04-690c-9394-eeafda3848a4" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", "900f1499-bb04-690c-9394-eeafda3848a4" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "c0452911-4948-9cb2-aed9-7b949c0b6442", "900f1499-bb04-690c-9394-eeafda3848a4" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "c3cd3947-214d-3130-b938-a5d19a0e8eaa", "900f1499-bb04-690c-9394-eeafda3848a4" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "cf512e7a-117b-71d0-a07f-43e743dad7eb", "900f1499-bb04-690c-9394-eeafda3848a4" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "d059db13-ac91-760c-5bf7-6c442946e7bf", "900f1499-bb04-690c-9394-eeafda3848a4" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", "900f1499-bb04-690c-9394-eeafda3848a4" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "e9cbe024-5789-9dca-e8c8-418b70f033cb", "900f1499-bb04-690c-9394-eeafda3848a4" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "fb30b659-6817-4099-e7cb-d7c254532603", "900f1499-bb04-690c-9394-eeafda3848a4" },
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Assign");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Assign");
        }
    }
}
