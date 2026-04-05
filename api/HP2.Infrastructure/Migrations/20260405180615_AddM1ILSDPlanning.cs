using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddM1ILSDPlanning : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "3701bc4e-401e-f4f3-00aa-b37659789636" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "54166d2e-0d4d-7e23-3a55-ecde2614bcfa" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "885f671e-9801-9aec-86eb-3fe1cb1db365" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "a5129120-7dfa-797c-3e24-99056723ec39" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e823715d-0a77-1379-9289-b44b55c10267" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3701bc4e-401e-f4f3-00aa-b37659789636", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "54166d2e-0d4d-7e23-3a55-ecde2614bcfa", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "885f671e-9801-9aec-86eb-3fe1cb1db365", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a5129120-7dfa-797c-3e24-99056723ec39", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e823715d-0a77-1379-9289-b44b55c10267", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3701bc4e-401e-f4f3-00aa-b37659789636");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "54166d2e-0d4d-7e23-3a55-ecde2614bcfa");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "885f671e-9801-9aec-86eb-3fe1cb1db365");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a5129120-7dfa-797c-3e24-99056723ec39");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e823715d-0a77-1379-9289-b44b55c10267");

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "course_id", "code", "name" },
                values: new object[] { "083b85af-c2e8-d7eb-0cca-13cbad93f7df", "UNIV_PRESENCE", "PRESENCE UNIVERSITAIRE" });

            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "session_id", "course_id", "date", "Description", "end_time", "mode", "room_id", "session_status_id", "session_type_id", "start_time" },
                values: new object[,]
                {
                    { "0056b48e-646b-1783-e719-29ef81ea762a", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2025, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "0091cba3-5f4c-8290-7f29-69bbf9ac6c75", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2026, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "00c13648-2c99-5428-44db-05a0c0279cf0", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2025, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "015e0664-9e05-7ec5-026a-02358ea2fdcd", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "0186b8c5-7384-82e7-630a-125e669795fa", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "01b7f46e-e743-7e80-acd8-a17d880f56d0", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "021ebba2-249f-412c-5eb1-3e0c4948ccea", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "0240e089-b8a7-a02f-258a-a8b6c8d126fa", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "0281ab1f-a5e4-530f-05d8-634d4674961c", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "033c0d0e-6ebc-eac7-402d-0a65b07b5d05", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "03672eca-e781-12f4-2d9b-a8a0ef7371ea", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "03dd7c2d-0e63-63b4-fce6-4cef1114723f", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2026, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "0451df21-9439-2fdb-b358-3a18b53abeb0", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "04c21ebe-dd6c-b7a5-ccc0-34b07be385e1", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "04e7c487-4657-0550-418c-6ae0d96b0528", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "0514db36-1e6b-9f75-e491-6d62278fe3d7", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "05ac8d14-9ecc-b065-64c4-5df33f73ff93", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2026, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "05f45355-dcb4-bfc1-eca2-89610fcef0d9", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "06324105-c510-7ccb-8f94-e4870ce2e627", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "06b02a80-c9d1-d88f-01d0-4b332bf3aec8", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2025, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "0849ab21-5c47-8cf8-670d-35a386c99293", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "0a08ff61-3964-d9ce-66f6-95b9fed4b85c", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "0a1e6c34-263b-19da-8f16-af1a8c36f35f", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "0aa26dd6-fa27-a71e-c93f-521ffc61e5cc", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "0ae9f823-f08b-d78f-4df6-cc81679f3637", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "0b4864d5-d4da-199e-5176-98bbfc05e7de", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "0b4c6aff-e816-b058-5365-42db3f1e5d8c", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "0b8454a7-0a16-cf00-e450-67acb872b63f", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "0bf8e9e5-9b13-98d5-464c-f806a63e32c0", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "0ca0abe1-8f3e-0b41-55c1-ef443bb6ea4b", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "0cd8d9f3-0c28-666d-7b5b-fddb4b07baac", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2026, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "0eac91c7-8342-c0e4-8486-23bc65f11a5c", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "0f759511-6d88-16ab-f5c3-5393413b7374", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "1058d1f9-1cc3-2808-aac4-059b31118f9d", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "11ad3e3e-3e22-3940-c40f-12d0aa828da7", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "11b3e597-791a-0186-c8a9-b9ebcf03c46c", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 0, 0, 0), "SOUTENANCE", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "0fc6aed4-11a4-4bca-c1f3-c7060734aa3c", new TimeSpan(0, 14, 0, 0, 0) },
                    { "12b42ac9-b980-4a40-07fb-1ac7850b48f6", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2025, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "12f0485e-7175-e7c7-5f34-9a5d287363f0", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2026, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "133278cc-7933-0286-e390-0fc4a7c1b142", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "1602657d-7ad0-127e-ede9-53f5a9462a02", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2026, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "1627b02a-1985-4026-7d79-48231e25e736", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "1734038d-4527-75b4-b567-6e3cb8c2e754", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "185d79a9-7e4e-9529-350a-3da955eab609", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "192a3e79-1737-a728-a963-36f925baffcf", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "19e792a4-0483-3555-0a1c-a0ed0a1576e7", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "1b168d80-ed4d-134e-39e9-71249e4c0507", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "1b7bfd56-148f-400b-b749-42d9a7795b40", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2026, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "1b7c5fa9-a3ac-def6-7c3d-dae37cafb16e", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "1bbd08c7-9fdf-8b99-83f0-194d30ecf035", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2026, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "1d62de39-a195-1f19-531c-586e0b001796", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "1d91292c-0920-91d0-bed7-087e0898e6af", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "1dc1cb0f-8b56-5156-3c9b-7bd80fd6d19a", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 0, 0, 0), "EXAMEN", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 8, 30, 0, 0) },
                    { "1e482bc0-cb16-87ea-b49f-ecd316a2c08a", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "1edb9a35-2dd8-fd90-c524-ef01391f97e7", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "1efc29fc-be39-f8af-e74b-60bc554c6e07", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2025, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "1f25b7fb-08b8-61ca-e752-399c77c7ef18", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "1fa7e581-d14d-f584-b7b7-3157b90f044b", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "20fd11f1-9d76-af81-a983-e277b5065596", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "2113fb7b-0c39-c75f-80cb-24ac87012268", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "22d299bb-59f1-1abb-bec3-812a9dd3b5e3", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "2300fc1f-af6d-738a-1ea2-84f7a0e8f992", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "24890c6c-e90d-38be-651f-3943a6f6ea0d", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "24b867d5-8da5-1e4c-cda6-1c1d3c7bca96", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "24bdb534-9db2-56c1-541a-98c6628ffac1", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "250a707d-9a6a-fb4b-293a-0b493f02d48e", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2026, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "251f287b-bbd1-1cf0-1088-dd9fc8d6a950", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "253f5749-818b-1a88-32e9-5dc0104fc2aa", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "257769b4-8b4d-7462-3b1a-e97b8b18d1bd", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2026, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "258ce124-a53c-53ce-891c-1ea6db4607ea", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "2652da8c-eb61-912d-6466-fa10b62e3520", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2026, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "282ef117-7b5e-4151-2e5a-b04fbec08021", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "28bdcd73-2251-4ca3-10c7-95e04d2dc193", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "28fa2e04-d2a3-c9c2-2765-58ceff54c266", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "29713359-c512-2642-bd35-8fdc7b713a86", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "29e9000b-929f-6ed2-4da4-08a48438c572", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "29f81d4f-f254-3c81-0800-484fff4f95db", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "2addb7b3-2b07-8a74-2cc4-54477360f8cf", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2026, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "2b9a99ca-97e3-ab45-6adc-18c0401e2271", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2026, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 17, 0, 0, 0), "EXAMEN", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 14, 0, 0, 0) },
                    { "2c254944-38d1-2bed-b104-4a98c3c374f9", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2025, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "2c25f4cc-1a17-b424-e587-50429d74e7ee", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 30, 0, 0), "EXAMEN", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 13, 30, 0, 0) },
                    { "2c2a7076-d2a1-aab8-c0cc-c2e4987052e7", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "2cbd2815-0d3b-af8c-cee2-c3fe4475aa8b", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "2d258078-d362-5598-81b6-d303b58aa17c", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2026, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "2ebe1d68-df32-c1ba-0f2b-518e7fa0cdc6", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "2f27bf5f-9f51-0f83-2802-e450bcfe54d8", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2026, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "30aab798-8663-49b3-924d-2228a5d800fa", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "30c224f9-a838-d4a4-510e-c5c9bc0629e8", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "31070994-cc4e-a988-3590-882ca0efb529", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "32f442d5-d876-73a9-8df5-64e07a5d3f2d", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "334bea02-aa9c-4cd0-cf37-b1cea75708b3", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "33e58c5f-41bb-41c0-7ec9-0b6268a5e750", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "34fa4ca6-fd2b-01bc-14d2-1fe35a8cfda5", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "35e6a580-20ea-f11f-d809-147bf282fdb2", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "364f949f-4f8d-abfe-a012-8dde7f6274a9", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2026, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "3651bd6e-248c-618f-a526-7fb73d1baf2f", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "37193eae-9c03-29b6-840b-0c9ab3caf2ed", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "377cb800-1c31-487e-f813-a69cf52eee2d", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "37f609e0-2c09-aad4-b8a2-d2a600514b39", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2026, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "381194f6-13d1-0784-ef42-2252bb8c2de6", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "38c44239-042b-9f47-b126-8bac5a935de4", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "3a75ece9-d6bd-8369-eb49-e0dd587b83c8", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "3b276f2e-e4dd-6f2e-f7c2-dafc41842740", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "3ba81963-cccd-65f9-73df-02219e2c2e7e", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2026, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "3d349848-9686-f1c8-de8a-688906a214cc", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "3e9a3d32-6316-244b-56e7-1b6bcec630bf", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "3f9efddf-d4ac-b783-4fd2-ef586805836c", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 15, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 30, 0, 0) },
                    { "4058b0fa-48be-4e17-2576-c4135c300b34", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "408a61ae-4b6b-0076-67ce-a465b6fa9dca", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "41a5c5f3-39a7-fd50-55f1-15a5ffdab6af", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 0, 0, 0), "EXAMEN", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 8, 30, 0, 0) },
                    { "42468a5a-4a16-eb8e-de47-265fc96a4ca9", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2025, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "437a2f46-83e6-12b5-d427-e9cfefbec976", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "43835ede-7675-be2c-7c3b-1b062538fa9f", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "441a291d-b318-85bb-ad24-07c5c11f5062", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "4455a522-1f44-6544-eed9-9335814735f6", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "4465707f-e953-9211-c9e5-fa31eccb30bc", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "446d9588-beb3-632b-0e25-e1b5b4f33776", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2026, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "447fd5eb-36b6-2ad8-db74-b20bddf788a5", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "44f6ff10-d9ea-89f1-6e59-8804e41a182b", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "45380ea6-04b6-5c4f-748f-26a430eb604b", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "46c17505-618a-4ab0-6173-304a63b6b627", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "47702301-4262-c698-1569-cce48dec8d1a", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "481e422a-50e8-4125-184a-14a073fb947a", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "49282f5e-88a1-e68a-cf2b-b70e99cc24d6", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2026, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "49df7fc7-082a-69a1-0440-377f6e1fde69", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "4a4c2da0-0133-601d-1522-921ce26123d3", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2025, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "4acb04ae-4f32-0992-3ffd-50b16241ba97", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "4ae299ae-0f82-b71d-0262-22bb2a532176", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2026, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 30, 0, 0), "EXAMEN", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 13, 30, 0, 0) },
                    { "4b7c860f-0fc0-abf5-476f-3a45fa180ca8", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "4c877cbd-bfb5-2f1b-f281-36f0c8137a99", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "4ce01da5-4f9f-5257-b982-7c7a6e70e1d4", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "4d6b8d40-5855-e522-368d-ad628b0372ea", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "4e9d38e8-b380-471f-bc75-979ad0cdd4e8", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "4eef927f-1d7e-5446-0f24-488523a20b01", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "4f11ef9b-0cf2-26dd-fe1b-1d4d63075c9f", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2026, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "4f215f44-2da6-46e2-e33c-59f53c74c0ff", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "5015b809-1fa9-1fa5-650a-2a405fd64085", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "50d9044e-0086-d1f3-254f-77152cd854e8", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "5175db0f-8378-8d13-46b3-8edb798ee7df", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "51ca6d70-ecb7-c756-e98f-11e9e46eb1bd", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 15, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 30, 0, 0) },
                    { "51e907e9-b001-29c7-1d2f-82526931ca1b", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "52310af2-ece3-cd10-f89c-46732e228f89", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "5294bdc8-57c8-442a-5a7e-5b06f82ac5e8", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "52a673d4-2604-d117-fa31-59e6b1583b05", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "52d5138e-d17c-a425-ef8f-47d0d46c0a79", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "545669bc-406f-75a2-c5e8-1eb4a6a7bffb", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "546331da-fcbb-455f-1cfe-ecbd95845602", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "54daaa31-3130-ffc0-c011-b8d202aa19d6", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "555c4f01-12f9-5870-2fc2-954b990f9ea9", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2026, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "5561b254-a62b-e8eb-bc3e-43d0d935ab76", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "557a5d2d-2c5b-63cd-ed1d-69a53390882b", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2026, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "55a67536-efb2-9b26-ab0a-968135ce47c4", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "562094e8-3ad2-2a03-0579-fc1418b5f659", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2025, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "563098bf-4f57-55cd-5db5-817ecd76d316", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2026, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "56ff463d-10f6-6e00-3a7d-c4aea77e299b", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "5702f7da-be71-c268-696f-98d52e88ea53", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2026, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "582a1dd6-8a44-76b0-8c01-7261083f0172", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "586c1df1-b67d-a268-6dd0-09b96b2c644f", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "58858d76-14c3-cbe5-adc4-8791825c778e", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "597e10ad-aa92-7822-1987-a88d6cf5852f", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 17, 30, 0, 0), "EXAMEN", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 13, 30, 0, 0) },
                    { "59922d63-7e84-a47d-e7e2-ca0253d54ace", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "59c8349a-3b56-1684-bcfc-15b8ba173f15", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "5d1d4bd0-53eb-e05b-237f-6514f5b79081", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "5d96512f-a43c-9fdc-5c4e-f83ca7b76102", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "5e65d782-df6f-14a7-c210-3213fc284e29", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "5e86ab2d-34b7-1cb2-ef43-ec920c0a70e6", "f8c83971-d090-c665-8911-cd645e1a3c87", new DateTime(2026, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 18, 0, 0, 0), "EVENEMENT", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7d12ed93-7363-9686-49c3-77ad3ccb2da0", new TimeSpan(0, 8, 30, 0, 0) },
                    { "5fb45997-dbe8-5a6d-46db-ea5654a68a27", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "602d6044-d51b-bbd6-a54c-1a345e89937d", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "60544a1d-7058-eae3-3dde-a79b6b8ef9c3", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "60d3c38c-09a5-dce6-6101-41ecbce1bf03", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "613bcf8b-9d1e-e78d-17d2-53422ab92602", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "61f6ef7f-4330-e352-da28-4895756a5251", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "61ff370e-6c73-3674-a907-9007cd4b33a9", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "622a60bd-1788-2e1b-a6a0-c8f4e1d1e219", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "62512fb2-d619-81c7-3311-1b118818d52b", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "6255702d-a7b2-bb95-f10a-49b274da6d53", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2026, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "62ac54af-88e9-dfa2-813c-7794254d1335", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "638a4120-4be1-950a-fec5-94663410af82", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "63e4081b-ce44-4976-db5f-bb0600bcf7af", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "64e321fd-02c0-e40f-12b4-d66aea725403", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "652b1fdb-8e05-5f20-7458-639066ce3139", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "65472971-26a2-f130-16b1-1c92bbd22ed0", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "66d7cc94-016c-2ade-9bd5-b80af34bf830", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2026, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "66e64f1a-bcdb-e90d-4b74-760046e2450b", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "67bce44d-530c-659e-c998-e149a26d5125", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "67c0607e-1a86-5adc-1cbb-1b67ebd4f5c7", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "68b1f719-fd66-8ebb-ac71-4ff3607a297d", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "6961bdc3-425e-2f60-be51-9f75ba501dcd", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "6979eeb6-1623-28d8-2c4b-aa9c9ca3dd61", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "69d170b3-caea-dcc2-2098-39eba8d87e7d", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "6a0168cc-dc00-e5b9-3d51-e63ac454ab2d", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "6a693347-e820-3da0-51aa-7f83809be309", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "6a8902b7-62fa-3c0b-741d-c65a94b9bc40", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "6a9c2aba-178c-4935-0602-b587d85cce25", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "6b79c9c7-2703-0c83-47a0-7b93b92595f5", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "6cb8f5f6-9138-6744-da11-698ada9c7cd9", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "6d0a9a86-a0c2-ab66-6cf4-0b82f34cbcaa", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2026, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 13, 0, 0, 0), "EXAMEN", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 9, 0, 0, 0) },
                    { "6da289df-b92c-187f-6dd9-988eca909576", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "6dea7d94-a09f-56f2-f31e-0cd3aac5ab06", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "6e86371a-fdc1-a36b-ebb9-ccdbc764ed53", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "6ede21c7-5e01-847d-90d3-85a92e3b87bd", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "6efe6515-de20-2195-a929-b8f79fb59e3e", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "6f3e4dee-356c-1e4f-91ea-c4aacd751af4", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "6f877b46-e63b-1f94-279a-86e19b4c5761", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "6fe7c898-a901-a39c-6bb0-d06bd0d6e5fb", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2026, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "71703b6c-1f4e-53ec-e9e6-2e0174689404", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "72a3c917-dfaf-9ddd-88fb-94f9ca743271", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "74f4e56c-46d0-b7b4-aa59-11386a4ea5fd", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "7527c779-5120-f31d-474d-61aff31bc8c2", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "7636a876-a0ef-b958-5ccb-fa1744245061", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "76570e22-cf14-6006-bcb5-b33b40821d16", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "769cb487-c2b4-dfe2-c6b9-0fba223fefd2", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "76a47667-00d8-1aed-4659-1935af3c9c95", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "76a72df6-2cda-3c30-6f4c-66d8d7517f4e", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "76b957f7-e3c2-291b-7522-effc736f5b46", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "7710775c-5b25-a750-18d6-63956d2fccf7", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2025, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "77245690-2f64-8b48-384f-600788950792", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "780954cc-cb71-98e4-921a-36493c1213ab", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "782ae39e-a5d2-9cc4-3fc7-5d64bc387293", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "78750878-ef0d-057e-c510-51e22b56ee0e", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "78a0fa33-dc9f-e211-b484-baafb65a9751", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "7952bd2c-9bf5-fc7a-018f-c55e5ea6a639", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "799fd89b-42c7-3ef3-6c3c-ffcedbff6861", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2026, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "79e45e6d-96cb-5c40-a6c3-e18a6d44b454", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "7bfcaba8-0d96-44e7-df91-80bd72afaa1f", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2026, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "7c62f011-6077-ed38-5ea4-4bb85363ccb5", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2025, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "7c84033b-5176-ff52-bf0c-2d96a280808f", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2026, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "7cfc755e-5b32-8d59-789c-bc4dd2100d61", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "7d62fd98-d42d-cfa9-2959-3cb49a0b2ffc", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "7edc844d-8fdd-7aff-15d9-a2a0bbc13b82", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "7f2243f4-ac3d-acde-849b-c8a89c2180af", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "7f3bd210-62cd-bc91-18e1-e0eb300567f2", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "80517491-33d5-45f6-4b9f-2a73dabbfac0", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "81c2420f-339f-14dc-75dd-01c9688542bd", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "820cc779-f49f-5bdc-d9b1-8e1b5faa0477", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "82714fa8-f934-7af7-a9f2-8296dcd9a0c2", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "83b0393a-1b75-fa6f-7f72-02d12d0fe1f7", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2025, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "83d8c26f-491d-fe4e-5fbb-6befa442c4b6", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "84791388-7f45-2463-c3cb-b60e2beecb42", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "84b4ae16-7e63-9425-edc3-2828257f19b9", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "853fd355-afab-e34e-3932-5edd59a14471", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2026, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "879a6a99-bb2c-37a9-766e-a310fe50294f", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "879c6462-be54-6a55-3f7a-c71691eff10a", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "883954fa-8710-fa17-ac5e-9019be27c7b3", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2025, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "887f71d1-a887-b99e-f276-dff6af9c5d76", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "8896c2af-a850-2d70-92b7-e36a6630c282", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "88a9d605-45a4-7dba-3085-4963782e8da1", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "88bc1f89-0749-56c2-c09d-df1d426ffc30", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2026, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 15, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 30, 0, 0) },
                    { "88bf75c3-eafe-f500-22e1-80e974eaf9a9", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "890fff94-7866-0993-b421-ee7b72322af7", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2026, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "898a34e4-9b61-d1d5-b386-750cddb45093", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "89a8a3a0-f0b5-f882-cbed-62c800a42b67", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "8b24abf0-7d82-945d-9f59-df957b49026b", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "8bfd4e11-7816-f525-8723-b142709b59a3", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "8cfb7ff3-442d-26df-1431-da48ab37532e", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "8dcf77d5-4bb8-4a37-c156-8378722486e6", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2025, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "8f4a50b6-d908-a23e-8f91-11ecfaf85f8d", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "8f5034bb-2a44-e79e-6077-937b9e2eb778", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "8ff39507-c5d8-26cc-69a3-7e0737654adf", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "900080d8-70d4-55f9-da68-9b515a38d066", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "9084f470-325c-483b-f43a-ba4c72ee85e5", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "916d390a-b5f8-a47e-c047-99ce0772f358", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "926050e2-d137-dd61-ef03-70f839196de2", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "9282ce07-8b76-3331-139a-3bd67c69f78d", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "93236a10-6062-4627-9669-e68c7a9a512a", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "932db80b-bbbe-0554-eb22-b1ce43d19e43", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "93a8edeb-fa34-5caa-0a30-bc9fa1256165", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "93b325a2-1a3a-ccd4-2dd4-1760da9e566b", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "94f13bbd-c7c5-6bd2-b7e9-52dc0966f576", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "960a4d6c-57ca-5d75-ec41-814efa474455", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "968f01c1-f329-f7b2-ab09-e3101785e985", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "96a355c4-e5cb-088f-316e-114cd303e69f", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "97ba9829-84cf-fe71-ae74-3c7b060094dc", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "9890bc17-31b9-f162-f970-60b0775a6d12", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "98ad42af-7b62-d045-c029-acc7f8391178", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2026, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "98c79796-6474-5451-a8fd-fbdfeaab98d1", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "99485134-637f-7f92-aa87-ef09cc97060f", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "99970ce2-4a02-f1e9-0c8a-b2036566990b", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2025, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "99b56292-1db6-2eaa-1288-6ffe8ab9f867", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "9a513f41-293e-f359-228b-0ae8a899031f", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 17, 30, 0, 0), "EXAMEN", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 13, 30, 0, 0) },
                    { "9b120356-d713-52aa-6d15-0ab20a6dafa3", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "9b129a34-ff85-acf3-f293-10326813c2a6", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2025, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "9b97f7cb-2fd2-1b2b-7fb4-48549c9bce71", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "9c805c50-f759-7741-630c-deb8cb68ba8d", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "9ddfae2a-a9d0-ee5e-363c-9d1d546f35f9", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "9df27dd2-5b2b-c22b-8bf9-2ffc7ae6beac", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "9e16991a-6b3d-afa5-9b5f-4fa492f6968a", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "9e8406ec-c5cf-c049-573a-e095a69d467d", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "9f0735a9-35a8-4ab3-1ce6-30127c7ddf10", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "9f61d871-99d9-56bb-6c0b-ac3e63961c62", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "a058e8a5-6167-8fb2-40e8-7a78db40cb18", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "a13ad1a5-bc2c-d63f-e354-a07fad74183a", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "a16acd15-b2a1-6c4b-5863-94bbd012c634", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "a1843163-d8ba-b59f-684a-014886bd3d61", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "a25df2d0-0b45-9ba0-6124-d90473770072", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "a2da7e4d-71fe-bc21-a388-bf057c332e9b", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "a30142d9-69c8-572f-6e00-36337174568a", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "a321cf46-28c1-494e-363b-768a8c0ea651", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "a3ef0364-5887-0b4a-0e3f-a21f7831dab4", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2026, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "a5903bd3-3b04-7e69-11b7-732fa860c788", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "a63701af-c71f-0544-02bc-d0280dee25ed", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "a84e00b6-e85b-0b23-352b-9aa3ffe7314e", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "a98ab2f3-b600-aa92-df9d-36a8b29618ce", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "abd180fb-51b2-f036-0801-160bf90d7ff5", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "ac33006a-f6a7-b30d-924b-b9599a119708", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "ac3d6140-0409-55a7-b2ef-a8a48c6a005c", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2026, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "ad0352cb-af71-03e2-f7df-fcfd332d43f6", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "ad045d93-a868-e459-2cac-86d7eaee8cbc", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "ad9b3882-b23f-7ecb-96cd-d373c961086c", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "b035fcae-1e8a-9fa0-49c5-fc0683abb1da", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "b068d9ed-052d-db39-42d5-f761fb91389d", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "b0b518c2-a0f2-014f-aa51-bb87f5303bb2", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "b2b61f8d-4efd-b3a1-11fa-c03b6cbe4c80", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "b4a63901-0da1-eb7b-337c-6faec61f874e", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "b4c4e99d-fb21-e705-082d-9fc412367c4c", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 15, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 0, 0, 0) },
                    { "b4e13ede-e71c-c186-bc27-870c75e7fa67", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "b60cb0e1-40c9-a5e7-1e80-652fc7e60428", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "b65ea77f-0e71-5a29-e989-834ddd46ad27", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "b7c1bf18-8580-7593-aef3-07ac58070309", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "b963ef01-1013-65af-0dae-792235151046", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "b979e399-3c5c-bc24-51fc-cbe7015b3815", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "bac650fc-e433-b6c8-ea8c-5897aaca3ec4", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "baca9ff5-9366-45e4-601e-9abe5fc1a116", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "bacd5124-36c2-d836-b1d9-1c102fb463e2", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2026, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "bcbecc4c-c68d-698e-a66d-3dee53146775", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "bcda868b-6398-0edf-ee1a-4e6e1f3c7ad9", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "bd0003a7-71ef-64fa-f405-2a8bc1f818ac", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2026, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "bd9d3143-409a-0f66-ed4b-777fb22d9eb9", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 30, 0, 0), "EXAMEN", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 8, 30, 0, 0) },
                    { "bdb036bd-e677-8f22-3e58-ea3960108397", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "be69de91-98fb-dc9b-1101-1a7fc424aed6", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "bebf7f2d-d0c4-8f83-295d-815d8b032f00", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "bfe31176-d336-318e-e3ed-ba48e2bc3165", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "c04c2819-327c-b89b-c9e0-3873bad8caa5", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "c16f9c29-49a4-27ea-0dde-3cb64d935374", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 30, 0, 0), "EXAMEN", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 8, 30, 0, 0) },
                    { "c2f5b7d2-8f15-ffc8-53c2-db0ce86adc84", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "c37e09bd-181b-3d96-2267-136727f2138b", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "c3baf7b7-0b10-9349-ce60-5e337c5f52b7", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "c4ddd6d9-e547-8150-7cbb-a70c8a4ea647", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2026, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "c4fda568-4149-5765-76ca-f7ab1369f72c", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "c537988b-784d-2ea2-3809-35137ba3ebcc", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2026, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "c57fc538-62be-d295-4d6c-9a96583b2e82", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "c61b143a-76b8-b0ec-0e2a-08728ca06f99", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "c7230259-ea86-ac19-75bb-b2dad1a7ed0d", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "c993a9c2-00c0-6c35-a8a0-acbb8dbf8753", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2025, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "ca196df1-2e76-e3c5-5b7f-909737937fd1", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2026, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "ca332a52-83dc-966b-2342-2cfa7834704a", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "cabd52b6-a9ac-25e0-f006-07b9930bd0c3", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2026, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 15, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 30, 0, 0) },
                    { "cbf0a3b0-23aa-ebe1-ecb0-2f49a219687e", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2025, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "cc1386d9-f61b-4f16-b7f2-95c233d40325", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "cc801d7a-0b5d-c9ac-4abc-7f710fafc579", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "ccb84504-009b-9e1f-6ce9-0be79bb9d7d6", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2026, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "cda690cc-9d90-b01f-a225-e231fbaf2d75", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "cf2227f8-70aa-e895-7365-f15ee87416bb", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "cf9e4513-7a68-0fdc-c515-738bc7c05bcf", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "cfa498cf-480e-686c-2f55-1e85a2647581", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "cfead747-9003-9e9b-52bc-0b41c8573a39", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "d023c16b-07bb-4858-64d8-83d703d81765", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "d0be853e-e5c9-c00a-3210-24826d54c8c9", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2026, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 12, 30, 0, 0), "EXAMEN", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 8, 30, 0, 0) },
                    { "d0c70ae1-f86f-a9bb-5fca-6dedd3a1f20e", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "d10298e1-5278-47aa-0f71-0797c103d6bf", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "d12b6441-c021-e685-c2a0-ccb6d18c6e2d", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2026, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 17, 0, 0, 0), "EXAMEN", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 14, 0, 0, 0) },
                    { "d13345ea-8622-2baa-5ca1-e65ec6f6d3cc", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "d1e482c5-5f57-881a-bc65-4b0554787a06", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2025, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "d272319c-c4bc-7e55-a5fc-c1d865ce2883", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "d313aa93-bceb-8611-cca6-98587fedb027", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "d3d5330e-9305-c5d7-f15a-ad3e9222c64a", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "d3e94f59-6971-3fd2-3883-5f737558e970", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "d4a2b82e-ac81-a489-3fdc-7ec091f63120", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "d5c40a0d-5c86-c041-1c69-6d7124c1e5bb", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "d61166a8-3d8e-05da-a441-d02f25fc1b17", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "d6e39a4e-8f99-c2c5-1822-c304edb960f3", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "d70feb19-c076-1b92-3271-7948a4d2ec6d", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "d7170eca-6fea-c607-d3ea-a156d892282c", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 12, 0, 0, 0), "EXAMEN", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 9, 0, 0, 0) },
                    { "d754a532-6439-c81c-1483-071ac7753f6e", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "d848e964-36fd-7e2c-6bac-bd62ea17d076", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "da05cec6-33ff-2f51-78eb-672bdce9eedc", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2026, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "db66eb60-ccdb-191c-0c31-b065ed6d0c07", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "db989267-e3f8-d20e-50ce-1a86a2cb57de", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "dc7bb52c-c8ea-4b9e-12e9-bcd0082fbbe7", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "dcb53a8b-1ca9-8890-1554-fb1f69795899", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "dd29a66e-0244-8e91-bb9e-5eb5b60dcc21", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2026, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "dd6279a3-ed2e-e099-78b8-e975ad79687f", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "de4b747f-2f87-b06d-520e-007961ddec2e", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2025, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "df6c40a6-74f6-3ac5-3ee4-300429a61e92", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "dfa69c92-c9b4-adf9-0115-99847777c0fb", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "e0234452-8d42-ea87-6893-c8dad80a84fe", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2026, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 15, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 0, 0, 0) },
                    { "e032d36e-64fb-e93b-27b9-37683c91d300", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "e1eb12cb-0d6e-2027-4210-915e431f4ee1", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "e204a5c3-39d1-cf4d-201a-17b13ca7a645", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "e242a289-dfca-efbd-da76-61b5c7801269", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "e299482e-7b44-d8ed-01cf-ae87285d8dc3", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "e2c94de3-afd5-3f70-dc53-3a85d0ccf301", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "e31bb2d7-2b9a-a6ab-f504-5733579b55ee", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "e32ef38f-8b36-731f-a2cb-144fdf2caa9e", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "e3943ee6-d742-976e-27d7-c25fd96be488", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2026, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "e3991f32-1ba2-8da6-8bee-13eba7e85116", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "e39b9f48-8efc-4076-6041-db0363d180d2", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "e3d506b8-4836-4dd0-f312-e6111b78375e", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "e4155591-818f-ccbc-dec2-1f13a4ceabcf", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2025, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "e54f716f-5bec-79e2-3621-5d67e987b557", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 15, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 0, 0, 0) },
                    { "e5768617-c1aa-9f58-6294-50c88eb76415", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2026, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "e6784a9e-fd61-5183-b498-c10d934e8e00", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "e7350ca5-30bb-8485-c1bb-068f4f9a3111", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "e74c971d-569c-0886-9869-07377c0ca1fa", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "e77dec89-6970-70ac-95b8-3cdc5e790b3e", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2026, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "e8a6ddaa-c287-1fe4-b545-bdc2fd737e27", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2026, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "e8c252de-2177-6e6b-6a96-97b24e5d5b7c", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "e8c891d5-d3ea-f1f0-af84-4fc0ee0ed391", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "e90f9ec7-abac-39a0-75db-8e26d17e1d23", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "e99b900e-d9fa-606a-a428-aecaa24585f0", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "ea2644a3-6940-66dd-8ade-abe2c55365e5", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "eadd632c-d2c1-e747-3094-e99e549421fd", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "eaf9ef0a-dee7-c3a3-cded-0b69ccd9aa15", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "eb4782fc-4751-f80c-b548-f550874f4182", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "eb74d386-f79e-d317-141b-26eb9f3fd90b", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "eb805281-c659-1c4c-ee27-bf6c913df877", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "ebe2026d-144c-a338-087f-de57a76fa97a", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "ecd70e45-0560-ea42-6c72-a4e6f64c7caf", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "ed2ba61e-d0e4-5997-83cc-4f6ccef9664c", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2026, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "ed5e554a-a46e-ff18-f963-08d2d533dbca", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "ef0a6048-6175-f72e-7151-6650c8532708", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "f1920d05-d079-d363-8deb-07fb5734a4e0", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2026, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "f35c38af-d54c-f9c2-c3b9-033da24e2e2c", "02e0e667-183a-1225-d0ed-19fe4c25f963", new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "f38bae86-3131-c1a3-e7b0-39abb9d9412f", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "f48f8cdd-2f78-d1f4-8546-55e53fa147a2", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "f4d5e080-3fed-8109-2129-d774ede4123d", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "f5a17134-8d98-8c79-5e8e-df528cbecd83", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "f6772830-b34b-1d5b-6633-820dd62c5c02", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "f6f47760-6361-ee41-6255-b291ea4600b4", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "f8ad4631-fdd2-506b-e471-e2041401daba", "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", new DateTime(2026, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "f8be17a0-408e-e2dd-3c1b-6ffddb4185ff", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "f8dbee0d-2cd0-4fd8-529b-debe83c64f4a", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2026, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "f91c1c31-b7c4-3561-0d35-1774f56dd285", "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "fbd60b76-c388-94cc-b92c-1e1ce2ea0913", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2025, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "fc47173b-f1b2-614e-82f0-eb2f0f4fe92a", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "fc4a1a33-9953-a9f3-00ab-afd1b89dc2e8", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2025, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "fe2ba999-5615-2c19-c9c9-60153195bce5", "3448ddd0-694c-35d0-f117-7d5834e6ca81", new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 15, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 0, 0, 0) },
                    { "ff082da8-0206-1639-740d-2f2fd480909b", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "ff3ba2eb-2da3-6a8f-b57a-bd4ffdc5b987", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "ff70c7a4-a0a4-25f7-828d-0f73d22d50c7", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 4, 479, DateTimeKind.Utc).AddTicks(7934), "$2b$12$2tqgNN4GkiZnQ31roef7Def9MIIrQwgi3Dw5HkTOISqyQ6SF.Dji." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 8, 603, DateTimeKind.Utc).AddTicks(8072), "$2b$12$YK8T4Zp.FVNwBBwOGtoA6ORVZ7eXHCeQsFuEREVKh4opqzkQr787C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 0, 307, DateTimeKind.Utc).AddTicks(6957), "$2b$12$ul3rb.M0F.dGxn6yHjSX..r5EH/wDBOcUK8e8F8qRflipJxWd8TtW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 11, 578, DateTimeKind.Utc).AddTicks(4189), "$2b$12$tv4csSn7.5gP1WSNbGsZkObC15CZhRyC0Kb6i9KN246bgvciHMwu2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 14, 835, DateTimeKind.Utc).AddTicks(5915), "$2b$12$pEvGRQOROG2Atyzy2SS2tu3q7NQwXQjqQ4V5zB4.ka0m..J5hNW/6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 1, 816, DateTimeKind.Utc).AddTicks(6457), "$2b$12$BgxR//YE6FD5tFaUBy6fUuC0LzrhLS9JPPJoSEdLlNlvtrw1ZDNru" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 7, 410, DateTimeKind.Utc).AddTicks(9135), "$2b$12$OcCua9Efi85AdUZ5QR6XWOmEfhalrUn4XX4.FHEcVVO864ENcYfKK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 2, 699, DateTimeKind.Utc).AddTicks(6058), "$2b$12$wKd6I8DQIuVaBVmT5JP0sex5Ajpk8TuN01HQYqp.ZSe6LzTMfma/K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 3, 292, DateTimeKind.Utc).AddTicks(4091), "$2b$12$OuJJ8LdjUMJWGeVLZ/ex6.7P1PAKUCjOpv2ARJsgLHFxEN9R4L./C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 13, 953, DateTimeKind.Utc).AddTicks(7037), "$2b$12$LrPmgLe9PxOT6/gsx2Tr6ektV5ZxuzpRzF8oV342l47DkWe.ZV9Fe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 5, 59, 404, DateTimeKind.Utc).AddTicks(8881), "$2b$12$5o28QZ.Ii1nW1a2LEnSU7eb7ZZsqFFXPOYqNe2DwiZl26Ou.GdV7S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 7, 118, DateTimeKind.Utc).AddTicks(4318), "$2b$12$sQlcHpX5zDKlswLuIHY3CeFsvjva0BADMX3tBY/yR64aRskhAN5M2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 0, 913, DateTimeKind.Utc).AddTicks(6616), "$2b$12$UNU00U/5FHdULDfxScVMaeNXCYzzxUomBq/cvJB1wxNQUU5stgEkW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 0, 606, DateTimeKind.Utc).AddTicks(331), "$2b$12$RHndgaJyNY191muNu/fAC.13HSwH2u1w7fNDiqXtSBzE9MXEMEH5O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 3, 890, DateTimeKind.Utc).AddTicks(6084), "$2b$12$la9gqf/B1JzrH8KZ7qnTAOoCAFy02tCj/G1qPyXaayOlR0S0w4H3K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 1, 221, DateTimeKind.Utc).AddTicks(2106), "$2b$12$Js099kAmxjryZjCHkY02vusxALpQuuXG2I8l40tHS9kg4rjFlxmay" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 5, 360, DateTimeKind.Utc).AddTicks(9338), "$2b$12$LVPMBW66fXLUJ/TWsgePP.xH/bOHQZU9FcgJjrao1gL/tBX05JPuO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 2, 406, DateTimeKind.Utc).AddTicks(800), "$2b$12$nqAfIomcY7p8XhriEvtJj.r8PBAZ5147kq7B7YrW5z/qkPCtgxxiG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 8, 287, DateTimeKind.Utc).AddTicks(6878), "$2b$12$g/t7ej.0obIPfkrS42S9NOXK0klXQ8qIjm8gW8e9Uldm/ULibkTCG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 12, 766, DateTimeKind.Utc).AddTicks(9623), "$2b$12$zC/MG3GlpFY1pPIQYLn1GuMz.s3pU1BZoL97ZCQX30eMzRLohjfPG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 14, 541, DateTimeKind.Utc).AddTicks(3972), "$2b$12$4byjXDp2aqFndKXLEdIub.OZE8c0J8ieTYI.xBKeuHlrwWRZwBR/K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 5, 654, DateTimeKind.Utc).AddTicks(2066), "$2b$12$oC0JvTmXRWlgpwYYO1GJGOyQmxv80OBh.Ws56gvsHLiAUlPica2zC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 13, 658, DateTimeKind.Utc).AddTicks(5880), "$2b$12$X.yyDH6YiXGZQtraL1dx3uYNZel3cMMFtLYoK8e3poALdrCvY4M/u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 10, 371, DateTimeKind.Utc).AddTicks(3663), "$2b$12$VKs5P9GWR.HTFRgEWNGszOV8UV1RoWaI.vKimjuc6JtcirKVCm322" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 10, 973, DateTimeKind.Utc).AddTicks(5757), "$2b$12$NDMj9wTyR2B/1xuasxw6SexCKW87gxD0F8Yq0gjXHGu5KQec8rmEG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 10, 664, DateTimeKind.Utc).AddTicks(4343), "$2b$12$bkTdIlEUcQdgNeYsJXma3eLAInjP/SmVTQp.yRAn7AyVaFyq2S59W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 9, 488, DateTimeKind.Utc).AddTicks(4463), "$2b$12$9iTfijh13HZPxvi808cGsuQjQp4yRkyGMRUp3aQXNkV3NyNpZYpiC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 13, 62, DateTimeKind.Utc).AddTicks(742), "$2b$12$utjtZP2yvE2sPGC65AkdQehWcMvIyf8HAa7E/GL548MqxGSmaSeV2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 9, 782, DateTimeKind.Utc).AddTicks(6915), "$2b$12$hTgAmWd8svCq3MQVwoB4DOw3qwnIOzNgowKFTPNhFWigqp00T2SBy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 11, 882, DateTimeKind.Utc).AddTicks(6454), "$2b$12$aAIXgeSwRxeGW3RnmAfENOei0MWWSt9P1JzQUciNUJuNxE8Pux0O." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 13, 356, DateTimeKind.Utc).AddTicks(4292), "$2b$12$qd/q7kYEX0y2CYsub3V8seBl45XLlfc.2OW2NRZTGbR8Syf6gi7gi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 7, 996, DateTimeKind.Utc).AddTicks(6910), "$2b$12$HiseForhqJAli88JAvR9GuKWzoYzDp50vhzhj8Sswnsf4k6oSX.CK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 5, 59, 706, DateTimeKind.Utc).AddTicks(3814), "$2b$12$FfG.tb35RGk4TB54nXdPl.Bem.9quwLMYWWG5nhEFJU5p2u3p5SwK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 5, 948, DateTimeKind.Utc).AddTicks(2859), "$2b$12$XkG4GNs55b/wp5SZq7Wbi.qg6cNLWnShGW0wH7.xUlN3rxvWK46Qu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 2, 997, DateTimeKind.Utc).AddTicks(423), "$2b$12$EhOB7UuVEUAvCo1FPocjt.DLJZpu/VRrKuu.JuoCYZ11dQcawOTRm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 7, 702, DateTimeKind.Utc).AddTicks(6040), "$2b$12$jP94iZ0vtv96qF8GaaQ.xe.T34BAJD9EZoQ/LFp16Ed6EyjPzlSnC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 6, 827, DateTimeKind.Utc).AddTicks(2622), "$2b$12$44KXkHJQ/k2Modtg5nKhiOWEMfXYjmn80irhFrnz7SfRU0AtYv1Va" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 14, 247, DateTimeKind.Utc).AddTicks(3528), "$2b$12$7gwoCXcbFRuqEOVeJjoSfuBxqYFR/WHqds8afcvWqNZD6hx43jbQC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 3, 593, DateTimeKind.Utc).AddTicks(5237), "$2b$12$oNVfOuPRLvenG1yTHD8FteQknGIx27atlshbACcDXTok/kUFEc.IO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 2, 111, DateTimeKind.Utc).AddTicks(7416), "$2b$12$DQDDMPUd2l9EVTn6xBHzf.gVM5btZcyfYOKI.2l7fPxiInu3VVY2K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 8, 900, DateTimeKind.Utc).AddTicks(197), "$2b$12$cPd3P4SACndITY7KwPWi8.tf6MgcaYq/WdbTaAT/OxVBtP6NezIE." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 0, 8, DateTimeKind.Utc).AddTicks(264), "$2b$12$NVOD6yqTojs2XglwXXZCu.dTtN1RmE9JKmAwoFBuRfEGEouVTUj2u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 10, 77, DateTimeKind.Utc).AddTicks(4568), "$2b$12$KDSGYDV6YWtG2ajHj64R/.P7h57IqAa77n1Mf.ddAyrCM37IM9osO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 4, 185, DateTimeKind.Utc).AddTicks(1917), "$2b$12$3.DFBmbkKabNB0whXsDUeeYp3ngw6i3Sjkq060fHy/W7DGTySk6BW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 12, 178, DateTimeKind.Utc).AddTicks(1990), "$2b$12$sSekxlFuIjsOazwFXHMR3OT1d8xH5tDZdyM.lQ7lcuxtpPLZd7vri" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 12, 472, DateTimeKind.Utc).AddTicks(4057), "$2b$12$WEBFZiLMAFLV1va6rghLnuUpTUwQYhJA8.3ggXfya7QDQOpA4qF3K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 11, 280, DateTimeKind.Utc).AddTicks(4980), "$2b$12$MxHgXAS34pH8IqKen9SWduXZshM8X9aFBGKHXHx40eAhK1NbDEhMO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 9, 194, DateTimeKind.Utc).AddTicks(3290), "$2b$12$tBWXqUj.d4YYgvZll43YnOhqArMrYe8FONWQ06rxxmHSL2wyBW75K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 6, 534, DateTimeKind.Utc).AddTicks(8531), "$2b$12$d23VwNHATzZbgqH7CIdqy.yJ2IoryLgK6hNtHNkeDfqS2NtFxaPAa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 5, 66, DateTimeKind.Utc).AddTicks(8418), "$2b$12$CP0dydhKzaMmGSO0sQMYuO9atnD0f8jJtuXrVIDu659sQml51N2qe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 4, 774, DateTimeKind.Utc).AddTicks(7187), "$2b$12$YadaBvL45cm7Rv9b3POxbeAz2Ft2wcopayd0TGtyuCdrEl16.DfRG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 6, 242, DateTimeKind.Utc).AddTicks(4305), "$2b$12$cvd7cL.8iOWY0pl6M/NSnO70e5uhZ2bHSuzXDxnbVw7MtEki0Byey" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 1, 519, DateTimeKind.Utc).AddTicks(8029), "$2b$12$3jxHjExEX/CI0jEuIMwrFuINBRJb5b60Fyg97dToJvWxOGo1CX9lG" });

            migrationBuilder.InsertData(
                table: "Attend",
                columns: new[] { "group_id", "session_id" },
                values: new object[,]
                {
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0056b48e-646b-1783-e719-29ef81ea762a" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0091cba3-5f4c-8290-7f29-69bbf9ac6c75" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "00c13648-2c99-5428-44db-05a0c0279cf0" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "015e0664-9e05-7ec5-026a-02358ea2fdcd" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0186b8c5-7384-82e7-630a-125e669795fa" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "01b7f46e-e743-7e80-acd8-a17d880f56d0" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "021ebba2-249f-412c-5eb1-3e0c4948ccea" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0240e089-b8a7-a02f-258a-a8b6c8d126fa" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0281ab1f-a5e4-530f-05d8-634d4674961c" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "033c0d0e-6ebc-eac7-402d-0a65b07b5d05" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "03672eca-e781-12f4-2d9b-a8a0ef7371ea" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "03dd7c2d-0e63-63b4-fce6-4cef1114723f" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0451df21-9439-2fdb-b358-3a18b53abeb0" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "04c21ebe-dd6c-b7a5-ccc0-34b07be385e1" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "04e7c487-4657-0550-418c-6ae0d96b0528" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0514db36-1e6b-9f75-e491-6d62278fe3d7" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "05ac8d14-9ecc-b065-64c4-5df33f73ff93" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "05f45355-dcb4-bfc1-eca2-89610fcef0d9" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "06324105-c510-7ccb-8f94-e4870ce2e627" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "06b02a80-c9d1-d88f-01d0-4b332bf3aec8" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0849ab21-5c47-8cf8-670d-35a386c99293" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0a08ff61-3964-d9ce-66f6-95b9fed4b85c" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0a1e6c34-263b-19da-8f16-af1a8c36f35f" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0aa26dd6-fa27-a71e-c93f-521ffc61e5cc" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0ae9f823-f08b-d78f-4df6-cc81679f3637" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0b4864d5-d4da-199e-5176-98bbfc05e7de" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0b4c6aff-e816-b058-5365-42db3f1e5d8c" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0b8454a7-0a16-cf00-e450-67acb872b63f" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0bf8e9e5-9b13-98d5-464c-f806a63e32c0" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0ca0abe1-8f3e-0b41-55c1-ef443bb6ea4b" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0cd8d9f3-0c28-666d-7b5b-fddb4b07baac" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0eac91c7-8342-c0e4-8486-23bc65f11a5c" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "0f759511-6d88-16ab-f5c3-5393413b7374" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "1058d1f9-1cc3-2808-aac4-059b31118f9d" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "11ad3e3e-3e22-3940-c40f-12d0aa828da7" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "11b3e597-791a-0186-c8a9-b9ebcf03c46c" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "12b42ac9-b980-4a40-07fb-1ac7850b48f6" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "12f0485e-7175-e7c7-5f34-9a5d287363f0" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "133278cc-7933-0286-e390-0fc4a7c1b142" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "1602657d-7ad0-127e-ede9-53f5a9462a02" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "1627b02a-1985-4026-7d79-48231e25e736" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "1734038d-4527-75b4-b567-6e3cb8c2e754" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "185d79a9-7e4e-9529-350a-3da955eab609" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "192a3e79-1737-a728-a963-36f925baffcf" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "19e792a4-0483-3555-0a1c-a0ed0a1576e7" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "1b168d80-ed4d-134e-39e9-71249e4c0507" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "1b7bfd56-148f-400b-b749-42d9a7795b40" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "1b7c5fa9-a3ac-def6-7c3d-dae37cafb16e" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "1bbd08c7-9fdf-8b99-83f0-194d30ecf035" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "1d62de39-a195-1f19-531c-586e0b001796" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "1d91292c-0920-91d0-bed7-087e0898e6af" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "1dc1cb0f-8b56-5156-3c9b-7bd80fd6d19a" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "1e482bc0-cb16-87ea-b49f-ecd316a2c08a" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "1edb9a35-2dd8-fd90-c524-ef01391f97e7" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "1efc29fc-be39-f8af-e74b-60bc554c6e07" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "1f25b7fb-08b8-61ca-e752-399c77c7ef18" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "1fa7e581-d14d-f584-b7b7-3157b90f044b" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "20fd11f1-9d76-af81-a983-e277b5065596" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "2113fb7b-0c39-c75f-80cb-24ac87012268" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "22d299bb-59f1-1abb-bec3-812a9dd3b5e3" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "2300fc1f-af6d-738a-1ea2-84f7a0e8f992" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "24890c6c-e90d-38be-651f-3943a6f6ea0d" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "24b867d5-8da5-1e4c-cda6-1c1d3c7bca96" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "24bdb534-9db2-56c1-541a-98c6628ffac1" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "250a707d-9a6a-fb4b-293a-0b493f02d48e" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "251f287b-bbd1-1cf0-1088-dd9fc8d6a950" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "253f5749-818b-1a88-32e9-5dc0104fc2aa" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "257769b4-8b4d-7462-3b1a-e97b8b18d1bd" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "258ce124-a53c-53ce-891c-1ea6db4607ea" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "2652da8c-eb61-912d-6466-fa10b62e3520" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "282ef117-7b5e-4151-2e5a-b04fbec08021" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "28bdcd73-2251-4ca3-10c7-95e04d2dc193" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "28fa2e04-d2a3-c9c2-2765-58ceff54c266" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "29713359-c512-2642-bd35-8fdc7b713a86" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "29e9000b-929f-6ed2-4da4-08a48438c572" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "29f81d4f-f254-3c81-0800-484fff4f95db" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "2addb7b3-2b07-8a74-2cc4-54477360f8cf" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "2b9a99ca-97e3-ab45-6adc-18c0401e2271" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "2c254944-38d1-2bed-b104-4a98c3c374f9" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "2c25f4cc-1a17-b424-e587-50429d74e7ee" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "2c2a7076-d2a1-aab8-c0cc-c2e4987052e7" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "2cbd2815-0d3b-af8c-cee2-c3fe4475aa8b" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "2d258078-d362-5598-81b6-d303b58aa17c" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "2ebe1d68-df32-c1ba-0f2b-518e7fa0cdc6" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "2f27bf5f-9f51-0f83-2802-e450bcfe54d8" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "30aab798-8663-49b3-924d-2228a5d800fa" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "30c224f9-a838-d4a4-510e-c5c9bc0629e8" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "31070994-cc4e-a988-3590-882ca0efb529" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "32f442d5-d876-73a9-8df5-64e07a5d3f2d" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "334bea02-aa9c-4cd0-cf37-b1cea75708b3" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "33e58c5f-41bb-41c0-7ec9-0b6268a5e750" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "34fa4ca6-fd2b-01bc-14d2-1fe35a8cfda5" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "35e6a580-20ea-f11f-d809-147bf282fdb2" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "364f949f-4f8d-abfe-a012-8dde7f6274a9" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "3651bd6e-248c-618f-a526-7fb73d1baf2f" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "37193eae-9c03-29b6-840b-0c9ab3caf2ed" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "377cb800-1c31-487e-f813-a69cf52eee2d" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "37f609e0-2c09-aad4-b8a2-d2a600514b39" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "381194f6-13d1-0784-ef42-2252bb8c2de6" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "38c44239-042b-9f47-b126-8bac5a935de4" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "3a75ece9-d6bd-8369-eb49-e0dd587b83c8" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "3b276f2e-e4dd-6f2e-f7c2-dafc41842740" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "3ba81963-cccd-65f9-73df-02219e2c2e7e" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "3d349848-9686-f1c8-de8a-688906a214cc" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "3e9a3d32-6316-244b-56e7-1b6bcec630bf" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "3f9efddf-d4ac-b783-4fd2-ef586805836c" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "4058b0fa-48be-4e17-2576-c4135c300b34" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "408a61ae-4b6b-0076-67ce-a465b6fa9dca" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "41a5c5f3-39a7-fd50-55f1-15a5ffdab6af" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "42468a5a-4a16-eb8e-de47-265fc96a4ca9" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "437a2f46-83e6-12b5-d427-e9cfefbec976" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "43835ede-7675-be2c-7c3b-1b062538fa9f" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "441a291d-b318-85bb-ad24-07c5c11f5062" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "4455a522-1f44-6544-eed9-9335814735f6" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "4465707f-e953-9211-c9e5-fa31eccb30bc" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "446d9588-beb3-632b-0e25-e1b5b4f33776" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "447fd5eb-36b6-2ad8-db74-b20bddf788a5" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "44f6ff10-d9ea-89f1-6e59-8804e41a182b" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "45380ea6-04b6-5c4f-748f-26a430eb604b" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "46c17505-618a-4ab0-6173-304a63b6b627" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "47702301-4262-c698-1569-cce48dec8d1a" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "481e422a-50e8-4125-184a-14a073fb947a" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "49282f5e-88a1-e68a-cf2b-b70e99cc24d6" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "49df7fc7-082a-69a1-0440-377f6e1fde69" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "4a4c2da0-0133-601d-1522-921ce26123d3" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "4acb04ae-4f32-0992-3ffd-50b16241ba97" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "4ae299ae-0f82-b71d-0262-22bb2a532176" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "4b7c860f-0fc0-abf5-476f-3a45fa180ca8" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "4c877cbd-bfb5-2f1b-f281-36f0c8137a99" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "4ce01da5-4f9f-5257-b982-7c7a6e70e1d4" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "4d6b8d40-5855-e522-368d-ad628b0372ea" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "4e9d38e8-b380-471f-bc75-979ad0cdd4e8" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "4eef927f-1d7e-5446-0f24-488523a20b01" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "4f11ef9b-0cf2-26dd-fe1b-1d4d63075c9f" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "4f215f44-2da6-46e2-e33c-59f53c74c0ff" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "5015b809-1fa9-1fa5-650a-2a405fd64085" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "50d9044e-0086-d1f3-254f-77152cd854e8" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "5175db0f-8378-8d13-46b3-8edb798ee7df" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "51ca6d70-ecb7-c756-e98f-11e9e46eb1bd" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "51e907e9-b001-29c7-1d2f-82526931ca1b" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "52310af2-ece3-cd10-f89c-46732e228f89" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "5294bdc8-57c8-442a-5a7e-5b06f82ac5e8" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "52a673d4-2604-d117-fa31-59e6b1583b05" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "52d5138e-d17c-a425-ef8f-47d0d46c0a79" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "545669bc-406f-75a2-c5e8-1eb4a6a7bffb" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "546331da-fcbb-455f-1cfe-ecbd95845602" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "54daaa31-3130-ffc0-c011-b8d202aa19d6" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "555c4f01-12f9-5870-2fc2-954b990f9ea9" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "5561b254-a62b-e8eb-bc3e-43d0d935ab76" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "557a5d2d-2c5b-63cd-ed1d-69a53390882b" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "55a67536-efb2-9b26-ab0a-968135ce47c4" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "562094e8-3ad2-2a03-0579-fc1418b5f659" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "563098bf-4f57-55cd-5db5-817ecd76d316" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "56ff463d-10f6-6e00-3a7d-c4aea77e299b" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "5702f7da-be71-c268-696f-98d52e88ea53" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "582a1dd6-8a44-76b0-8c01-7261083f0172" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "586c1df1-b67d-a268-6dd0-09b96b2c644f" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "58858d76-14c3-cbe5-adc4-8791825c778e" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "597e10ad-aa92-7822-1987-a88d6cf5852f" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "59922d63-7e84-a47d-e7e2-ca0253d54ace" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "59c8349a-3b56-1684-bcfc-15b8ba173f15" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "5d1d4bd0-53eb-e05b-237f-6514f5b79081" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "5d96512f-a43c-9fdc-5c4e-f83ca7b76102" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "5e65d782-df6f-14a7-c210-3213fc284e29" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "5e86ab2d-34b7-1cb2-ef43-ec920c0a70e6" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "5fb45997-dbe8-5a6d-46db-ea5654a68a27" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "602d6044-d51b-bbd6-a54c-1a345e89937d" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "60544a1d-7058-eae3-3dde-a79b6b8ef9c3" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "60d3c38c-09a5-dce6-6101-41ecbce1bf03" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "613bcf8b-9d1e-e78d-17d2-53422ab92602" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "61f6ef7f-4330-e352-da28-4895756a5251" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "61ff370e-6c73-3674-a907-9007cd4b33a9" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "622a60bd-1788-2e1b-a6a0-c8f4e1d1e219" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "62512fb2-d619-81c7-3311-1b118818d52b" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6255702d-a7b2-bb95-f10a-49b274da6d53" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "62ac54af-88e9-dfa2-813c-7794254d1335" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "638a4120-4be1-950a-fec5-94663410af82" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "63e4081b-ce44-4976-db5f-bb0600bcf7af" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "64e321fd-02c0-e40f-12b4-d66aea725403" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "652b1fdb-8e05-5f20-7458-639066ce3139" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "65472971-26a2-f130-16b1-1c92bbd22ed0" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "66d7cc94-016c-2ade-9bd5-b80af34bf830" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "66e64f1a-bcdb-e90d-4b74-760046e2450b" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "67bce44d-530c-659e-c998-e149a26d5125" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "67c0607e-1a86-5adc-1cbb-1b67ebd4f5c7" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "68b1f719-fd66-8ebb-ac71-4ff3607a297d" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6961bdc3-425e-2f60-be51-9f75ba501dcd" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6979eeb6-1623-28d8-2c4b-aa9c9ca3dd61" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "69d170b3-caea-dcc2-2098-39eba8d87e7d" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6a0168cc-dc00-e5b9-3d51-e63ac454ab2d" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6a693347-e820-3da0-51aa-7f83809be309" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6a8902b7-62fa-3c0b-741d-c65a94b9bc40" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6a9c2aba-178c-4935-0602-b587d85cce25" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6b79c9c7-2703-0c83-47a0-7b93b92595f5" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6cb8f5f6-9138-6744-da11-698ada9c7cd9" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6d0a9a86-a0c2-ab66-6cf4-0b82f34cbcaa" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6da289df-b92c-187f-6dd9-988eca909576" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6dea7d94-a09f-56f2-f31e-0cd3aac5ab06" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6e86371a-fdc1-a36b-ebb9-ccdbc764ed53" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6ede21c7-5e01-847d-90d3-85a92e3b87bd" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6efe6515-de20-2195-a929-b8f79fb59e3e" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6f3e4dee-356c-1e4f-91ea-c4aacd751af4" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6f877b46-e63b-1f94-279a-86e19b4c5761" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6fe7c898-a901-a39c-6bb0-d06bd0d6e5fb" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "71703b6c-1f4e-53ec-e9e6-2e0174689404" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "72a3c917-dfaf-9ddd-88fb-94f9ca743271" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "74f4e56c-46d0-b7b4-aa59-11386a4ea5fd" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "7527c779-5120-f31d-474d-61aff31bc8c2" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "7636a876-a0ef-b958-5ccb-fa1744245061" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "76570e22-cf14-6006-bcb5-b33b40821d16" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "769cb487-c2b4-dfe2-c6b9-0fba223fefd2" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "76a47667-00d8-1aed-4659-1935af3c9c95" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "76a72df6-2cda-3c30-6f4c-66d8d7517f4e" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "76b957f7-e3c2-291b-7522-effc736f5b46" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "7710775c-5b25-a750-18d6-63956d2fccf7" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "77245690-2f64-8b48-384f-600788950792" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "780954cc-cb71-98e4-921a-36493c1213ab" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "782ae39e-a5d2-9cc4-3fc7-5d64bc387293" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "78750878-ef0d-057e-c510-51e22b56ee0e" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "78a0fa33-dc9f-e211-b484-baafb65a9751" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "7952bd2c-9bf5-fc7a-018f-c55e5ea6a639" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "799fd89b-42c7-3ef3-6c3c-ffcedbff6861" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "79e45e6d-96cb-5c40-a6c3-e18a6d44b454" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "7bfcaba8-0d96-44e7-df91-80bd72afaa1f" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "7c62f011-6077-ed38-5ea4-4bb85363ccb5" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "7c84033b-5176-ff52-bf0c-2d96a280808f" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "7cfc755e-5b32-8d59-789c-bc4dd2100d61" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "7d62fd98-d42d-cfa9-2959-3cb49a0b2ffc" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "7edc844d-8fdd-7aff-15d9-a2a0bbc13b82" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "7f2243f4-ac3d-acde-849b-c8a89c2180af" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "7f3bd210-62cd-bc91-18e1-e0eb300567f2" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "80517491-33d5-45f6-4b9f-2a73dabbfac0" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "81c2420f-339f-14dc-75dd-01c9688542bd" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "820cc779-f49f-5bdc-d9b1-8e1b5faa0477" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "82714fa8-f934-7af7-a9f2-8296dcd9a0c2" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "83b0393a-1b75-fa6f-7f72-02d12d0fe1f7" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "83d8c26f-491d-fe4e-5fbb-6befa442c4b6" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "84791388-7f45-2463-c3cb-b60e2beecb42" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "84b4ae16-7e63-9425-edc3-2828257f19b9" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "853fd355-afab-e34e-3932-5edd59a14471" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "879a6a99-bb2c-37a9-766e-a310fe50294f" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "879c6462-be54-6a55-3f7a-c71691eff10a" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "883954fa-8710-fa17-ac5e-9019be27c7b3" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "887f71d1-a887-b99e-f276-dff6af9c5d76" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "8896c2af-a850-2d70-92b7-e36a6630c282" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "88a9d605-45a4-7dba-3085-4963782e8da1" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "88bc1f89-0749-56c2-c09d-df1d426ffc30" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "88bf75c3-eafe-f500-22e1-80e974eaf9a9" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "890fff94-7866-0993-b421-ee7b72322af7" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "898a34e4-9b61-d1d5-b386-750cddb45093" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "89a8a3a0-f0b5-f882-cbed-62c800a42b67" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "8b24abf0-7d82-945d-9f59-df957b49026b" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "8bfd4e11-7816-f525-8723-b142709b59a3" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "8cfb7ff3-442d-26df-1431-da48ab37532e" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "8dcf77d5-4bb8-4a37-c156-8378722486e6" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "8f4a50b6-d908-a23e-8f91-11ecfaf85f8d" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "8f5034bb-2a44-e79e-6077-937b9e2eb778" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "8ff39507-c5d8-26cc-69a3-7e0737654adf" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "900080d8-70d4-55f9-da68-9b515a38d066" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "9084f470-325c-483b-f43a-ba4c72ee85e5" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "916d390a-b5f8-a47e-c047-99ce0772f358" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "926050e2-d137-dd61-ef03-70f839196de2" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "9282ce07-8b76-3331-139a-3bd67c69f78d" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "93236a10-6062-4627-9669-e68c7a9a512a" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "932db80b-bbbe-0554-eb22-b1ce43d19e43" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "93a8edeb-fa34-5caa-0a30-bc9fa1256165" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "93b325a2-1a3a-ccd4-2dd4-1760da9e566b" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "94f13bbd-c7c5-6bd2-b7e9-52dc0966f576" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "960a4d6c-57ca-5d75-ec41-814efa474455" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "968f01c1-f329-f7b2-ab09-e3101785e985" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "96a355c4-e5cb-088f-316e-114cd303e69f" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "97ba9829-84cf-fe71-ae74-3c7b060094dc" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "9890bc17-31b9-f162-f970-60b0775a6d12" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "98ad42af-7b62-d045-c029-acc7f8391178" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "98c79796-6474-5451-a8fd-fbdfeaab98d1" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "99485134-637f-7f92-aa87-ef09cc97060f" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "99970ce2-4a02-f1e9-0c8a-b2036566990b" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "99b56292-1db6-2eaa-1288-6ffe8ab9f867" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "9a513f41-293e-f359-228b-0ae8a899031f" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "9b120356-d713-52aa-6d15-0ab20a6dafa3" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "9b129a34-ff85-acf3-f293-10326813c2a6" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "9b97f7cb-2fd2-1b2b-7fb4-48549c9bce71" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "9c805c50-f759-7741-630c-deb8cb68ba8d" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "9ddfae2a-a9d0-ee5e-363c-9d1d546f35f9" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "9df27dd2-5b2b-c22b-8bf9-2ffc7ae6beac" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "9e16991a-6b3d-afa5-9b5f-4fa492f6968a" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "9e8406ec-c5cf-c049-573a-e095a69d467d" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "9f0735a9-35a8-4ab3-1ce6-30127c7ddf10" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "9f61d871-99d9-56bb-6c0b-ac3e63961c62" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "a058e8a5-6167-8fb2-40e8-7a78db40cb18" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "a13ad1a5-bc2c-d63f-e354-a07fad74183a" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "a16acd15-b2a1-6c4b-5863-94bbd012c634" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "a1843163-d8ba-b59f-684a-014886bd3d61" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "a25df2d0-0b45-9ba0-6124-d90473770072" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "a2da7e4d-71fe-bc21-a388-bf057c332e9b" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "a30142d9-69c8-572f-6e00-36337174568a" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "a321cf46-28c1-494e-363b-768a8c0ea651" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "a3ef0364-5887-0b4a-0e3f-a21f7831dab4" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "a5903bd3-3b04-7e69-11b7-732fa860c788" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "a63701af-c71f-0544-02bc-d0280dee25ed" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "a84e00b6-e85b-0b23-352b-9aa3ffe7314e" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "a98ab2f3-b600-aa92-df9d-36a8b29618ce" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "abd180fb-51b2-f036-0801-160bf90d7ff5" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "ac33006a-f6a7-b30d-924b-b9599a119708" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "ac3d6140-0409-55a7-b2ef-a8a48c6a005c" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "ad0352cb-af71-03e2-f7df-fcfd332d43f6" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "ad045d93-a868-e459-2cac-86d7eaee8cbc" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "ad9b3882-b23f-7ecb-96cd-d373c961086c" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "b035fcae-1e8a-9fa0-49c5-fc0683abb1da" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "b068d9ed-052d-db39-42d5-f761fb91389d" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "b0b518c2-a0f2-014f-aa51-bb87f5303bb2" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "b2b61f8d-4efd-b3a1-11fa-c03b6cbe4c80" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "b4a63901-0da1-eb7b-337c-6faec61f874e" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "b4c4e99d-fb21-e705-082d-9fc412367c4c" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "b4e13ede-e71c-c186-bc27-870c75e7fa67" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "b60cb0e1-40c9-a5e7-1e80-652fc7e60428" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "b65ea77f-0e71-5a29-e989-834ddd46ad27" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "b7c1bf18-8580-7593-aef3-07ac58070309" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "b963ef01-1013-65af-0dae-792235151046" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "b979e399-3c5c-bc24-51fc-cbe7015b3815" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "bac650fc-e433-b6c8-ea8c-5897aaca3ec4" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "baca9ff5-9366-45e4-601e-9abe5fc1a116" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "bacd5124-36c2-d836-b1d9-1c102fb463e2" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "bcbecc4c-c68d-698e-a66d-3dee53146775" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "bcda868b-6398-0edf-ee1a-4e6e1f3c7ad9" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "bd0003a7-71ef-64fa-f405-2a8bc1f818ac" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "bd9d3143-409a-0f66-ed4b-777fb22d9eb9" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "bdb036bd-e677-8f22-3e58-ea3960108397" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "be69de91-98fb-dc9b-1101-1a7fc424aed6" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "bebf7f2d-d0c4-8f83-295d-815d8b032f00" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "bfe31176-d336-318e-e3ed-ba48e2bc3165" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "c04c2819-327c-b89b-c9e0-3873bad8caa5" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "c16f9c29-49a4-27ea-0dde-3cb64d935374" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "c2f5b7d2-8f15-ffc8-53c2-db0ce86adc84" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "c37e09bd-181b-3d96-2267-136727f2138b" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "c3baf7b7-0b10-9349-ce60-5e337c5f52b7" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "c4ddd6d9-e547-8150-7cbb-a70c8a4ea647" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "c4fda568-4149-5765-76ca-f7ab1369f72c" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "c537988b-784d-2ea2-3809-35137ba3ebcc" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "c57fc538-62be-d295-4d6c-9a96583b2e82" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "c61b143a-76b8-b0ec-0e2a-08728ca06f99" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "c7230259-ea86-ac19-75bb-b2dad1a7ed0d" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "c993a9c2-00c0-6c35-a8a0-acbb8dbf8753" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "ca196df1-2e76-e3c5-5b7f-909737937fd1" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "ca332a52-83dc-966b-2342-2cfa7834704a" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "cabd52b6-a9ac-25e0-f006-07b9930bd0c3" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "cbf0a3b0-23aa-ebe1-ecb0-2f49a219687e" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "cc1386d9-f61b-4f16-b7f2-95c233d40325" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "cc801d7a-0b5d-c9ac-4abc-7f710fafc579" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "ccb84504-009b-9e1f-6ce9-0be79bb9d7d6" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "cda690cc-9d90-b01f-a225-e231fbaf2d75" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "cf2227f8-70aa-e895-7365-f15ee87416bb" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "cf9e4513-7a68-0fdc-c515-738bc7c05bcf" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "cfa498cf-480e-686c-2f55-1e85a2647581" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "cfead747-9003-9e9b-52bc-0b41c8573a39" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d023c16b-07bb-4858-64d8-83d703d81765" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d0be853e-e5c9-c00a-3210-24826d54c8c9" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d0c70ae1-f86f-a9bb-5fca-6dedd3a1f20e" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d10298e1-5278-47aa-0f71-0797c103d6bf" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d12b6441-c021-e685-c2a0-ccb6d18c6e2d" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d13345ea-8622-2baa-5ca1-e65ec6f6d3cc" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d1e482c5-5f57-881a-bc65-4b0554787a06" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d272319c-c4bc-7e55-a5fc-c1d865ce2883" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d313aa93-bceb-8611-cca6-98587fedb027" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d3d5330e-9305-c5d7-f15a-ad3e9222c64a" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d3e94f59-6971-3fd2-3883-5f737558e970" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d4a2b82e-ac81-a489-3fdc-7ec091f63120" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d5c40a0d-5c86-c041-1c69-6d7124c1e5bb" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d61166a8-3d8e-05da-a441-d02f25fc1b17" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d6e39a4e-8f99-c2c5-1822-c304edb960f3" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d70feb19-c076-1b92-3271-7948a4d2ec6d" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d7170eca-6fea-c607-d3ea-a156d892282c" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d754a532-6439-c81c-1483-071ac7753f6e" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "d848e964-36fd-7e2c-6bac-bd62ea17d076" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "da05cec6-33ff-2f51-78eb-672bdce9eedc" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "db66eb60-ccdb-191c-0c31-b065ed6d0c07" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "db989267-e3f8-d20e-50ce-1a86a2cb57de" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "dc7bb52c-c8ea-4b9e-12e9-bcd0082fbbe7" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "dcb53a8b-1ca9-8890-1554-fb1f69795899" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "dd29a66e-0244-8e91-bb9e-5eb5b60dcc21" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "dd6279a3-ed2e-e099-78b8-e975ad79687f" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "de4b747f-2f87-b06d-520e-007961ddec2e" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "df6c40a6-74f6-3ac5-3ee4-300429a61e92" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "dfa69c92-c9b4-adf9-0115-99847777c0fb" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e0234452-8d42-ea87-6893-c8dad80a84fe" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e032d36e-64fb-e93b-27b9-37683c91d300" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e1eb12cb-0d6e-2027-4210-915e431f4ee1" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e204a5c3-39d1-cf4d-201a-17b13ca7a645" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e242a289-dfca-efbd-da76-61b5c7801269" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e299482e-7b44-d8ed-01cf-ae87285d8dc3" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e2c94de3-afd5-3f70-dc53-3a85d0ccf301" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e31bb2d7-2b9a-a6ab-f504-5733579b55ee" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e32ef38f-8b36-731f-a2cb-144fdf2caa9e" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e3943ee6-d742-976e-27d7-c25fd96be488" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e3991f32-1ba2-8da6-8bee-13eba7e85116" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e39b9f48-8efc-4076-6041-db0363d180d2" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e3d506b8-4836-4dd0-f312-e6111b78375e" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e4155591-818f-ccbc-dec2-1f13a4ceabcf" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e54f716f-5bec-79e2-3621-5d67e987b557" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e5768617-c1aa-9f58-6294-50c88eb76415" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e6784a9e-fd61-5183-b498-c10d934e8e00" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e7350ca5-30bb-8485-c1bb-068f4f9a3111" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e74c971d-569c-0886-9869-07377c0ca1fa" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e77dec89-6970-70ac-95b8-3cdc5e790b3e" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e8a6ddaa-c287-1fe4-b545-bdc2fd737e27" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e8c252de-2177-6e6b-6a96-97b24e5d5b7c" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e8c891d5-d3ea-f1f0-af84-4fc0ee0ed391" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e90f9ec7-abac-39a0-75db-8e26d17e1d23" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e99b900e-d9fa-606a-a428-aecaa24585f0" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "ea2644a3-6940-66dd-8ade-abe2c55365e5" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "eadd632c-d2c1-e747-3094-e99e549421fd" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "eaf9ef0a-dee7-c3a3-cded-0b69ccd9aa15" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "eb4782fc-4751-f80c-b548-f550874f4182" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "eb74d386-f79e-d317-141b-26eb9f3fd90b" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "eb805281-c659-1c4c-ee27-bf6c913df877" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "ebe2026d-144c-a338-087f-de57a76fa97a" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "ecd70e45-0560-ea42-6c72-a4e6f64c7caf" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "ed2ba61e-d0e4-5997-83cc-4f6ccef9664c" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "ed5e554a-a46e-ff18-f963-08d2d533dbca" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "ef0a6048-6175-f72e-7151-6650c8532708" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "f1920d05-d079-d363-8deb-07fb5734a4e0" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "f35c38af-d54c-f9c2-c3b9-033da24e2e2c" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "f38bae86-3131-c1a3-e7b0-39abb9d9412f" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "f48f8cdd-2f78-d1f4-8546-55e53fa147a2" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "f4d5e080-3fed-8109-2129-d774ede4123d" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "f5a17134-8d98-8c79-5e8e-df528cbecd83" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "f6772830-b34b-1d5b-6633-820dd62c5c02" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "f6f47760-6361-ee41-6255-b291ea4600b4" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "f8ad4631-fdd2-506b-e471-e2041401daba" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "f8be17a0-408e-e2dd-3c1b-6ffddb4185ff" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "f8dbee0d-2cd0-4fd8-529b-debe83c64f4a" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "f91c1c31-b7c4-3561-0d35-1774f56dd285" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "fbd60b76-c388-94cc-b92c-1e1ce2ea0913" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "fc47173b-f1b2-614e-82f0-eb2f0f4fe92a" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "fc4a1a33-9953-a9f3-00ab-afd1b89dc2e8" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "fe2ba999-5615-2c19-c9c9-60153195bce5" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "ff082da8-0206-1639-740d-2f2fd480909b" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "ff3ba2eb-2da3-6a8f-b57a-bd4ffdc5b987" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "ff70c7a4-a0a4-25f7-828d-0f73d22d50c7" }
                });

            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "session_id", "course_id", "date", "Description", "end_time", "mode", "room_id", "session_status_id", "session_type_id", "start_time" },
                values: new object[] { "68d03176-7999-d56b-1502-f5cbb0c3611e", "083b85af-c2e8-d7eb-0cca-13cbad93f7df", new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 15, 0, 0, 0), "EVENEMENT", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7d12ed93-7363-9686-49c3-77ad3ccb2da0", new TimeSpan(0, 8, 30, 0, 0) });

            migrationBuilder.InsertData(
                table: "Teach",
                columns: new[] { "session_id", "teacher_id" },
                values: new object[,]
                {
                    { "0056b48e-646b-1783-e719-29ef81ea762a", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "0091cba3-5f4c-8290-7f29-69bbf9ac6c75", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "00c13648-2c99-5428-44db-05a0c0279cf0", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "015e0664-9e05-7ec5-026a-02358ea2fdcd", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "0186b8c5-7384-82e7-630a-125e669795fa", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "01b7f46e-e743-7e80-acd8-a17d880f56d0", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "021ebba2-249f-412c-5eb1-3e0c4948ccea", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "0240e089-b8a7-a02f-258a-a8b6c8d126fa", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "0281ab1f-a5e4-530f-05d8-634d4674961c", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "033c0d0e-6ebc-eac7-402d-0a65b07b5d05", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "03672eca-e781-12f4-2d9b-a8a0ef7371ea", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "03dd7c2d-0e63-63b4-fce6-4cef1114723f", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "0451df21-9439-2fdb-b358-3a18b53abeb0", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "04c21ebe-dd6c-b7a5-ccc0-34b07be385e1", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "04e7c487-4657-0550-418c-6ae0d96b0528", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "0514db36-1e6b-9f75-e491-6d62278fe3d7", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "05ac8d14-9ecc-b065-64c4-5df33f73ff93", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "05f45355-dcb4-bfc1-eca2-89610fcef0d9", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "06324105-c510-7ccb-8f94-e4870ce2e627", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "06b02a80-c9d1-d88f-01d0-4b332bf3aec8", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "0849ab21-5c47-8cf8-670d-35a386c99293", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "0a08ff61-3964-d9ce-66f6-95b9fed4b85c", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "0a1e6c34-263b-19da-8f16-af1a8c36f35f", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "0aa26dd6-fa27-a71e-c93f-521ffc61e5cc", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "0ae9f823-f08b-d78f-4df6-cc81679f3637", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "0b4864d5-d4da-199e-5176-98bbfc05e7de", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "0b4c6aff-e816-b058-5365-42db3f1e5d8c", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "0b8454a7-0a16-cf00-e450-67acb872b63f", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "0bf8e9e5-9b13-98d5-464c-f806a63e32c0", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "0ca0abe1-8f3e-0b41-55c1-ef443bb6ea4b", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "0cd8d9f3-0c28-666d-7b5b-fddb4b07baac", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "0eac91c7-8342-c0e4-8486-23bc65f11a5c", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "0f759511-6d88-16ab-f5c3-5393413b7374", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "1058d1f9-1cc3-2808-aac4-059b31118f9d", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "11ad3e3e-3e22-3940-c40f-12d0aa828da7", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "11b3e597-791a-0186-c8a9-b9ebcf03c46c", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "12b42ac9-b980-4a40-07fb-1ac7850b48f6", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "12f0485e-7175-e7c7-5f34-9a5d287363f0", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "133278cc-7933-0286-e390-0fc4a7c1b142", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "1602657d-7ad0-127e-ede9-53f5a9462a02", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "1627b02a-1985-4026-7d79-48231e25e736", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "1734038d-4527-75b4-b567-6e3cb8c2e754", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "185d79a9-7e4e-9529-350a-3da955eab609", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "192a3e79-1737-a728-a963-36f925baffcf", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "19e792a4-0483-3555-0a1c-a0ed0a1576e7", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "1b168d80-ed4d-134e-39e9-71249e4c0507", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "1b7bfd56-148f-400b-b749-42d9a7795b40", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "1b7c5fa9-a3ac-def6-7c3d-dae37cafb16e", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "1bbd08c7-9fdf-8b99-83f0-194d30ecf035", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "1d62de39-a195-1f19-531c-586e0b001796", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "1d91292c-0920-91d0-bed7-087e0898e6af", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "1dc1cb0f-8b56-5156-3c9b-7bd80fd6d19a", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "1e482bc0-cb16-87ea-b49f-ecd316a2c08a", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "1edb9a35-2dd8-fd90-c524-ef01391f97e7", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "1efc29fc-be39-f8af-e74b-60bc554c6e07", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "1f25b7fb-08b8-61ca-e752-399c77c7ef18", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "1fa7e581-d14d-f584-b7b7-3157b90f044b", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "20fd11f1-9d76-af81-a983-e277b5065596", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "2113fb7b-0c39-c75f-80cb-24ac87012268", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "22d299bb-59f1-1abb-bec3-812a9dd3b5e3", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "2300fc1f-af6d-738a-1ea2-84f7a0e8f992", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "24890c6c-e90d-38be-651f-3943a6f6ea0d", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "24b867d5-8da5-1e4c-cda6-1c1d3c7bca96", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "24bdb534-9db2-56c1-541a-98c6628ffac1", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "250a707d-9a6a-fb4b-293a-0b493f02d48e", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "251f287b-bbd1-1cf0-1088-dd9fc8d6a950", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "253f5749-818b-1a88-32e9-5dc0104fc2aa", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "257769b4-8b4d-7462-3b1a-e97b8b18d1bd", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "258ce124-a53c-53ce-891c-1ea6db4607ea", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "2652da8c-eb61-912d-6466-fa10b62e3520", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "282ef117-7b5e-4151-2e5a-b04fbec08021", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "28bdcd73-2251-4ca3-10c7-95e04d2dc193", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "28fa2e04-d2a3-c9c2-2765-58ceff54c266", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "29713359-c512-2642-bd35-8fdc7b713a86", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "29e9000b-929f-6ed2-4da4-08a48438c572", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "29f81d4f-f254-3c81-0800-484fff4f95db", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "2addb7b3-2b07-8a74-2cc4-54477360f8cf", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "2b9a99ca-97e3-ab45-6adc-18c0401e2271", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "2c254944-38d1-2bed-b104-4a98c3c374f9", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "2c25f4cc-1a17-b424-e587-50429d74e7ee", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "2c2a7076-d2a1-aab8-c0cc-c2e4987052e7", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "2cbd2815-0d3b-af8c-cee2-c3fe4475aa8b", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "2d258078-d362-5598-81b6-d303b58aa17c", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "2ebe1d68-df32-c1ba-0f2b-518e7fa0cdc6", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "2f27bf5f-9f51-0f83-2802-e450bcfe54d8", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "30aab798-8663-49b3-924d-2228a5d800fa", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "30c224f9-a838-d4a4-510e-c5c9bc0629e8", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "31070994-cc4e-a988-3590-882ca0efb529", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "32f442d5-d876-73a9-8df5-64e07a5d3f2d", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "334bea02-aa9c-4cd0-cf37-b1cea75708b3", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "33e58c5f-41bb-41c0-7ec9-0b6268a5e750", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "34fa4ca6-fd2b-01bc-14d2-1fe35a8cfda5", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "35e6a580-20ea-f11f-d809-147bf282fdb2", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "364f949f-4f8d-abfe-a012-8dde7f6274a9", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "3651bd6e-248c-618f-a526-7fb73d1baf2f", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "37193eae-9c03-29b6-840b-0c9ab3caf2ed", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "377cb800-1c31-487e-f813-a69cf52eee2d", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "37f609e0-2c09-aad4-b8a2-d2a600514b39", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "381194f6-13d1-0784-ef42-2252bb8c2de6", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "38c44239-042b-9f47-b126-8bac5a935de4", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "3a75ece9-d6bd-8369-eb49-e0dd587b83c8", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "3b276f2e-e4dd-6f2e-f7c2-dafc41842740", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "3ba81963-cccd-65f9-73df-02219e2c2e7e", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "3d349848-9686-f1c8-de8a-688906a214cc", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "3e9a3d32-6316-244b-56e7-1b6bcec630bf", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "3f9efddf-d4ac-b783-4fd2-ef586805836c", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "4058b0fa-48be-4e17-2576-c4135c300b34", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "408a61ae-4b6b-0076-67ce-a465b6fa9dca", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "41a5c5f3-39a7-fd50-55f1-15a5ffdab6af", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "42468a5a-4a16-eb8e-de47-265fc96a4ca9", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "437a2f46-83e6-12b5-d427-e9cfefbec976", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "43835ede-7675-be2c-7c3b-1b062538fa9f", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "441a291d-b318-85bb-ad24-07c5c11f5062", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "4455a522-1f44-6544-eed9-9335814735f6", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "4465707f-e953-9211-c9e5-fa31eccb30bc", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "446d9588-beb3-632b-0e25-e1b5b4f33776", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "447fd5eb-36b6-2ad8-db74-b20bddf788a5", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "44f6ff10-d9ea-89f1-6e59-8804e41a182b", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "45380ea6-04b6-5c4f-748f-26a430eb604b", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "46c17505-618a-4ab0-6173-304a63b6b627", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "47702301-4262-c698-1569-cce48dec8d1a", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "481e422a-50e8-4125-184a-14a073fb947a", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "49282f5e-88a1-e68a-cf2b-b70e99cc24d6", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "49df7fc7-082a-69a1-0440-377f6e1fde69", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "4a4c2da0-0133-601d-1522-921ce26123d3", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "4acb04ae-4f32-0992-3ffd-50b16241ba97", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "4ae299ae-0f82-b71d-0262-22bb2a532176", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "4b7c860f-0fc0-abf5-476f-3a45fa180ca8", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "4c877cbd-bfb5-2f1b-f281-36f0c8137a99", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "4ce01da5-4f9f-5257-b982-7c7a6e70e1d4", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "4d6b8d40-5855-e522-368d-ad628b0372ea", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "4e9d38e8-b380-471f-bc75-979ad0cdd4e8", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "4eef927f-1d7e-5446-0f24-488523a20b01", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "4f11ef9b-0cf2-26dd-fe1b-1d4d63075c9f", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "4f215f44-2da6-46e2-e33c-59f53c74c0ff", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "5015b809-1fa9-1fa5-650a-2a405fd64085", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "50d9044e-0086-d1f3-254f-77152cd854e8", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "5175db0f-8378-8d13-46b3-8edb798ee7df", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "51ca6d70-ecb7-c756-e98f-11e9e46eb1bd", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "51e907e9-b001-29c7-1d2f-82526931ca1b", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "52310af2-ece3-cd10-f89c-46732e228f89", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "5294bdc8-57c8-442a-5a7e-5b06f82ac5e8", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "52a673d4-2604-d117-fa31-59e6b1583b05", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "52d5138e-d17c-a425-ef8f-47d0d46c0a79", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "545669bc-406f-75a2-c5e8-1eb4a6a7bffb", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "546331da-fcbb-455f-1cfe-ecbd95845602", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "54daaa31-3130-ffc0-c011-b8d202aa19d6", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "555c4f01-12f9-5870-2fc2-954b990f9ea9", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "5561b254-a62b-e8eb-bc3e-43d0d935ab76", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "557a5d2d-2c5b-63cd-ed1d-69a53390882b", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "55a67536-efb2-9b26-ab0a-968135ce47c4", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "562094e8-3ad2-2a03-0579-fc1418b5f659", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "563098bf-4f57-55cd-5db5-817ecd76d316", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "56ff463d-10f6-6e00-3a7d-c4aea77e299b", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "5702f7da-be71-c268-696f-98d52e88ea53", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "582a1dd6-8a44-76b0-8c01-7261083f0172", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "586c1df1-b67d-a268-6dd0-09b96b2c644f", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "58858d76-14c3-cbe5-adc4-8791825c778e", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "597e10ad-aa92-7822-1987-a88d6cf5852f", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "59922d63-7e84-a47d-e7e2-ca0253d54ace", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "59c8349a-3b56-1684-bcfc-15b8ba173f15", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "5d1d4bd0-53eb-e05b-237f-6514f5b79081", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "5d96512f-a43c-9fdc-5c4e-f83ca7b76102", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "5e65d782-df6f-14a7-c210-3213fc284e29", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "5e86ab2d-34b7-1cb2-ef43-ec920c0a70e6", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "5fb45997-dbe8-5a6d-46db-ea5654a68a27", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "602d6044-d51b-bbd6-a54c-1a345e89937d", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "60544a1d-7058-eae3-3dde-a79b6b8ef9c3", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "60d3c38c-09a5-dce6-6101-41ecbce1bf03", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "613bcf8b-9d1e-e78d-17d2-53422ab92602", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "61f6ef7f-4330-e352-da28-4895756a5251", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "61ff370e-6c73-3674-a907-9007cd4b33a9", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "622a60bd-1788-2e1b-a6a0-c8f4e1d1e219", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "62512fb2-d619-81c7-3311-1b118818d52b", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "6255702d-a7b2-bb95-f10a-49b274da6d53", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "62ac54af-88e9-dfa2-813c-7794254d1335", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "638a4120-4be1-950a-fec5-94663410af82", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "63e4081b-ce44-4976-db5f-bb0600bcf7af", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "64e321fd-02c0-e40f-12b4-d66aea725403", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "652b1fdb-8e05-5f20-7458-639066ce3139", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "65472971-26a2-f130-16b1-1c92bbd22ed0", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "66d7cc94-016c-2ade-9bd5-b80af34bf830", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "66e64f1a-bcdb-e90d-4b74-760046e2450b", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "67bce44d-530c-659e-c998-e149a26d5125", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "67c0607e-1a86-5adc-1cbb-1b67ebd4f5c7", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "68b1f719-fd66-8ebb-ac71-4ff3607a297d", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "6961bdc3-425e-2f60-be51-9f75ba501dcd", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "6979eeb6-1623-28d8-2c4b-aa9c9ca3dd61", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "69d170b3-caea-dcc2-2098-39eba8d87e7d", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "6a0168cc-dc00-e5b9-3d51-e63ac454ab2d", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "6a693347-e820-3da0-51aa-7f83809be309", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "6a8902b7-62fa-3c0b-741d-c65a94b9bc40", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "6a9c2aba-178c-4935-0602-b587d85cce25", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "6b79c9c7-2703-0c83-47a0-7b93b92595f5", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "6cb8f5f6-9138-6744-da11-698ada9c7cd9", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "6d0a9a86-a0c2-ab66-6cf4-0b82f34cbcaa", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "6da289df-b92c-187f-6dd9-988eca909576", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "6dea7d94-a09f-56f2-f31e-0cd3aac5ab06", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "6e86371a-fdc1-a36b-ebb9-ccdbc764ed53", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "6ede21c7-5e01-847d-90d3-85a92e3b87bd", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "6efe6515-de20-2195-a929-b8f79fb59e3e", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "6f3e4dee-356c-1e4f-91ea-c4aacd751af4", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "6f877b46-e63b-1f94-279a-86e19b4c5761", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "6fe7c898-a901-a39c-6bb0-d06bd0d6e5fb", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "71703b6c-1f4e-53ec-e9e6-2e0174689404", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "72a3c917-dfaf-9ddd-88fb-94f9ca743271", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "74f4e56c-46d0-b7b4-aa59-11386a4ea5fd", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "7527c779-5120-f31d-474d-61aff31bc8c2", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "7636a876-a0ef-b958-5ccb-fa1744245061", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "76570e22-cf14-6006-bcb5-b33b40821d16", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "769cb487-c2b4-dfe2-c6b9-0fba223fefd2", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "76a47667-00d8-1aed-4659-1935af3c9c95", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "76a72df6-2cda-3c30-6f4c-66d8d7517f4e", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "76b957f7-e3c2-291b-7522-effc736f5b46", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "7710775c-5b25-a750-18d6-63956d2fccf7", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "77245690-2f64-8b48-384f-600788950792", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "780954cc-cb71-98e4-921a-36493c1213ab", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "782ae39e-a5d2-9cc4-3fc7-5d64bc387293", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "78750878-ef0d-057e-c510-51e22b56ee0e", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "78a0fa33-dc9f-e211-b484-baafb65a9751", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "7952bd2c-9bf5-fc7a-018f-c55e5ea6a639", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "799fd89b-42c7-3ef3-6c3c-ffcedbff6861", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "79e45e6d-96cb-5c40-a6c3-e18a6d44b454", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "7bfcaba8-0d96-44e7-df91-80bd72afaa1f", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "7c62f011-6077-ed38-5ea4-4bb85363ccb5", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "7c84033b-5176-ff52-bf0c-2d96a280808f", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "7cfc755e-5b32-8d59-789c-bc4dd2100d61", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "7d62fd98-d42d-cfa9-2959-3cb49a0b2ffc", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "7edc844d-8fdd-7aff-15d9-a2a0bbc13b82", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "7f2243f4-ac3d-acde-849b-c8a89c2180af", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "7f3bd210-62cd-bc91-18e1-e0eb300567f2", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "80517491-33d5-45f6-4b9f-2a73dabbfac0", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "81c2420f-339f-14dc-75dd-01c9688542bd", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "820cc779-f49f-5bdc-d9b1-8e1b5faa0477", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "82714fa8-f934-7af7-a9f2-8296dcd9a0c2", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "83b0393a-1b75-fa6f-7f72-02d12d0fe1f7", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "83d8c26f-491d-fe4e-5fbb-6befa442c4b6", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "84791388-7f45-2463-c3cb-b60e2beecb42", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "84b4ae16-7e63-9425-edc3-2828257f19b9", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "853fd355-afab-e34e-3932-5edd59a14471", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "879a6a99-bb2c-37a9-766e-a310fe50294f", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "879c6462-be54-6a55-3f7a-c71691eff10a", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "883954fa-8710-fa17-ac5e-9019be27c7b3", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "887f71d1-a887-b99e-f276-dff6af9c5d76", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "8896c2af-a850-2d70-92b7-e36a6630c282", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "88a9d605-45a4-7dba-3085-4963782e8da1", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "88bc1f89-0749-56c2-c09d-df1d426ffc30", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "88bf75c3-eafe-f500-22e1-80e974eaf9a9", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "890fff94-7866-0993-b421-ee7b72322af7", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "898a34e4-9b61-d1d5-b386-750cddb45093", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "89a8a3a0-f0b5-f882-cbed-62c800a42b67", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "8b24abf0-7d82-945d-9f59-df957b49026b", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "8bfd4e11-7816-f525-8723-b142709b59a3", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "8cfb7ff3-442d-26df-1431-da48ab37532e", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "8dcf77d5-4bb8-4a37-c156-8378722486e6", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "8f4a50b6-d908-a23e-8f91-11ecfaf85f8d", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "8f5034bb-2a44-e79e-6077-937b9e2eb778", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "8ff39507-c5d8-26cc-69a3-7e0737654adf", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "900080d8-70d4-55f9-da68-9b515a38d066", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "9084f470-325c-483b-f43a-ba4c72ee85e5", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "916d390a-b5f8-a47e-c047-99ce0772f358", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "926050e2-d137-dd61-ef03-70f839196de2", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "9282ce07-8b76-3331-139a-3bd67c69f78d", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "93236a10-6062-4627-9669-e68c7a9a512a", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "932db80b-bbbe-0554-eb22-b1ce43d19e43", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "93a8edeb-fa34-5caa-0a30-bc9fa1256165", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "93b325a2-1a3a-ccd4-2dd4-1760da9e566b", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "94f13bbd-c7c5-6bd2-b7e9-52dc0966f576", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "960a4d6c-57ca-5d75-ec41-814efa474455", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "968f01c1-f329-f7b2-ab09-e3101785e985", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "96a355c4-e5cb-088f-316e-114cd303e69f", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "97ba9829-84cf-fe71-ae74-3c7b060094dc", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "9890bc17-31b9-f162-f970-60b0775a6d12", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "98ad42af-7b62-d045-c029-acc7f8391178", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "98c79796-6474-5451-a8fd-fbdfeaab98d1", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "99485134-637f-7f92-aa87-ef09cc97060f", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "99970ce2-4a02-f1e9-0c8a-b2036566990b", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "99b56292-1db6-2eaa-1288-6ffe8ab9f867", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "9a513f41-293e-f359-228b-0ae8a899031f", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "9b120356-d713-52aa-6d15-0ab20a6dafa3", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "9b129a34-ff85-acf3-f293-10326813c2a6", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "9b97f7cb-2fd2-1b2b-7fb4-48549c9bce71", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "9c805c50-f759-7741-630c-deb8cb68ba8d", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "9ddfae2a-a9d0-ee5e-363c-9d1d546f35f9", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "9df27dd2-5b2b-c22b-8bf9-2ffc7ae6beac", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "9e16991a-6b3d-afa5-9b5f-4fa492f6968a", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "9e8406ec-c5cf-c049-573a-e095a69d467d", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "9f0735a9-35a8-4ab3-1ce6-30127c7ddf10", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "9f61d871-99d9-56bb-6c0b-ac3e63961c62", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "a058e8a5-6167-8fb2-40e8-7a78db40cb18", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "a13ad1a5-bc2c-d63f-e354-a07fad74183a", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "a16acd15-b2a1-6c4b-5863-94bbd012c634", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "a1843163-d8ba-b59f-684a-014886bd3d61", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "a25df2d0-0b45-9ba0-6124-d90473770072", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "a2da7e4d-71fe-bc21-a388-bf057c332e9b", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "a30142d9-69c8-572f-6e00-36337174568a", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "a321cf46-28c1-494e-363b-768a8c0ea651", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "a3ef0364-5887-0b4a-0e3f-a21f7831dab4", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "a5903bd3-3b04-7e69-11b7-732fa860c788", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "a63701af-c71f-0544-02bc-d0280dee25ed", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "a84e00b6-e85b-0b23-352b-9aa3ffe7314e", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "a98ab2f3-b600-aa92-df9d-36a8b29618ce", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "abd180fb-51b2-f036-0801-160bf90d7ff5", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "ac33006a-f6a7-b30d-924b-b9599a119708", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "ac3d6140-0409-55a7-b2ef-a8a48c6a005c", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "ad0352cb-af71-03e2-f7df-fcfd332d43f6", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "ad045d93-a868-e459-2cac-86d7eaee8cbc", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "ad9b3882-b23f-7ecb-96cd-d373c961086c", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "b035fcae-1e8a-9fa0-49c5-fc0683abb1da", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "b068d9ed-052d-db39-42d5-f761fb91389d", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "b0b518c2-a0f2-014f-aa51-bb87f5303bb2", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "b2b61f8d-4efd-b3a1-11fa-c03b6cbe4c80", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "b4a63901-0da1-eb7b-337c-6faec61f874e", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "b4c4e99d-fb21-e705-082d-9fc412367c4c", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "b4e13ede-e71c-c186-bc27-870c75e7fa67", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "b60cb0e1-40c9-a5e7-1e80-652fc7e60428", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "b65ea77f-0e71-5a29-e989-834ddd46ad27", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "b7c1bf18-8580-7593-aef3-07ac58070309", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "b963ef01-1013-65af-0dae-792235151046", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "b979e399-3c5c-bc24-51fc-cbe7015b3815", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "bac650fc-e433-b6c8-ea8c-5897aaca3ec4", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "baca9ff5-9366-45e4-601e-9abe5fc1a116", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "bacd5124-36c2-d836-b1d9-1c102fb463e2", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "bcbecc4c-c68d-698e-a66d-3dee53146775", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "bcda868b-6398-0edf-ee1a-4e6e1f3c7ad9", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "bd0003a7-71ef-64fa-f405-2a8bc1f818ac", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "bd9d3143-409a-0f66-ed4b-777fb22d9eb9", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "bdb036bd-e677-8f22-3e58-ea3960108397", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "be69de91-98fb-dc9b-1101-1a7fc424aed6", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "bebf7f2d-d0c4-8f83-295d-815d8b032f00", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "bfe31176-d336-318e-e3ed-ba48e2bc3165", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "c04c2819-327c-b89b-c9e0-3873bad8caa5", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "c16f9c29-49a4-27ea-0dde-3cb64d935374", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "c2f5b7d2-8f15-ffc8-53c2-db0ce86adc84", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "c37e09bd-181b-3d96-2267-136727f2138b", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "c3baf7b7-0b10-9349-ce60-5e337c5f52b7", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "c4ddd6d9-e547-8150-7cbb-a70c8a4ea647", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "c4fda568-4149-5765-76ca-f7ab1369f72c", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "c537988b-784d-2ea2-3809-35137ba3ebcc", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "c57fc538-62be-d295-4d6c-9a96583b2e82", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "c61b143a-76b8-b0ec-0e2a-08728ca06f99", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "c7230259-ea86-ac19-75bb-b2dad1a7ed0d", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "c993a9c2-00c0-6c35-a8a0-acbb8dbf8753", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "ca196df1-2e76-e3c5-5b7f-909737937fd1", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "ca332a52-83dc-966b-2342-2cfa7834704a", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "cabd52b6-a9ac-25e0-f006-07b9930bd0c3", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "cbf0a3b0-23aa-ebe1-ecb0-2f49a219687e", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "cc1386d9-f61b-4f16-b7f2-95c233d40325", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "cc801d7a-0b5d-c9ac-4abc-7f710fafc579", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "ccb84504-009b-9e1f-6ce9-0be79bb9d7d6", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "cda690cc-9d90-b01f-a225-e231fbaf2d75", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "cf2227f8-70aa-e895-7365-f15ee87416bb", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "cf9e4513-7a68-0fdc-c515-738bc7c05bcf", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "cfa498cf-480e-686c-2f55-1e85a2647581", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "cfead747-9003-9e9b-52bc-0b41c8573a39", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "d023c16b-07bb-4858-64d8-83d703d81765", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "d0be853e-e5c9-c00a-3210-24826d54c8c9", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "d0c70ae1-f86f-a9bb-5fca-6dedd3a1f20e", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "d10298e1-5278-47aa-0f71-0797c103d6bf", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "d12b6441-c021-e685-c2a0-ccb6d18c6e2d", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "d13345ea-8622-2baa-5ca1-e65ec6f6d3cc", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "d1e482c5-5f57-881a-bc65-4b0554787a06", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "d272319c-c4bc-7e55-a5fc-c1d865ce2883", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "d313aa93-bceb-8611-cca6-98587fedb027", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "d3d5330e-9305-c5d7-f15a-ad3e9222c64a", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "d3e94f59-6971-3fd2-3883-5f737558e970", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "d4a2b82e-ac81-a489-3fdc-7ec091f63120", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "d5c40a0d-5c86-c041-1c69-6d7124c1e5bb", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "d61166a8-3d8e-05da-a441-d02f25fc1b17", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "d6e39a4e-8f99-c2c5-1822-c304edb960f3", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "d70feb19-c076-1b92-3271-7948a4d2ec6d", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "d7170eca-6fea-c607-d3ea-a156d892282c", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "d754a532-6439-c81c-1483-071ac7753f6e", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "d848e964-36fd-7e2c-6bac-bd62ea17d076", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "da05cec6-33ff-2f51-78eb-672bdce9eedc", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "db66eb60-ccdb-191c-0c31-b065ed6d0c07", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "db989267-e3f8-d20e-50ce-1a86a2cb57de", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "dc7bb52c-c8ea-4b9e-12e9-bcd0082fbbe7", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "dcb53a8b-1ca9-8890-1554-fb1f69795899", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "dd29a66e-0244-8e91-bb9e-5eb5b60dcc21", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "dd6279a3-ed2e-e099-78b8-e975ad79687f", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "de4b747f-2f87-b06d-520e-007961ddec2e", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "df6c40a6-74f6-3ac5-3ee4-300429a61e92", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "dfa69c92-c9b4-adf9-0115-99847777c0fb", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "e0234452-8d42-ea87-6893-c8dad80a84fe", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "e032d36e-64fb-e93b-27b9-37683c91d300", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "e1eb12cb-0d6e-2027-4210-915e431f4ee1", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "e204a5c3-39d1-cf4d-201a-17b13ca7a645", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "e242a289-dfca-efbd-da76-61b5c7801269", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "e299482e-7b44-d8ed-01cf-ae87285d8dc3", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "e2c94de3-afd5-3f70-dc53-3a85d0ccf301", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "e31bb2d7-2b9a-a6ab-f504-5733579b55ee", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "e32ef38f-8b36-731f-a2cb-144fdf2caa9e", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "e3943ee6-d742-976e-27d7-c25fd96be488", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "e3991f32-1ba2-8da6-8bee-13eba7e85116", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "e39b9f48-8efc-4076-6041-db0363d180d2", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "e3d506b8-4836-4dd0-f312-e6111b78375e", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "e4155591-818f-ccbc-dec2-1f13a4ceabcf", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "e54f716f-5bec-79e2-3621-5d67e987b557", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "e5768617-c1aa-9f58-6294-50c88eb76415", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "e6784a9e-fd61-5183-b498-c10d934e8e00", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "e7350ca5-30bb-8485-c1bb-068f4f9a3111", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "e74c971d-569c-0886-9869-07377c0ca1fa", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "e77dec89-6970-70ac-95b8-3cdc5e790b3e", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "e8a6ddaa-c287-1fe4-b545-bdc2fd737e27", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "e8c252de-2177-6e6b-6a96-97b24e5d5b7c", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "e8c891d5-d3ea-f1f0-af84-4fc0ee0ed391", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "e90f9ec7-abac-39a0-75db-8e26d17e1d23", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "e99b900e-d9fa-606a-a428-aecaa24585f0", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "ea2644a3-6940-66dd-8ade-abe2c55365e5", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "eadd632c-d2c1-e747-3094-e99e549421fd", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "eaf9ef0a-dee7-c3a3-cded-0b69ccd9aa15", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "eb4782fc-4751-f80c-b548-f550874f4182", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "eb74d386-f79e-d317-141b-26eb9f3fd90b", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "eb805281-c659-1c4c-ee27-bf6c913df877", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "ebe2026d-144c-a338-087f-de57a76fa97a", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "ecd70e45-0560-ea42-6c72-a4e6f64c7caf", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "ed2ba61e-d0e4-5997-83cc-4f6ccef9664c", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "ed5e554a-a46e-ff18-f963-08d2d533dbca", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "ef0a6048-6175-f72e-7151-6650c8532708", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "f1920d05-d079-d363-8deb-07fb5734a4e0", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "f35c38af-d54c-f9c2-c3b9-033da24e2e2c", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "f38bae86-3131-c1a3-e7b0-39abb9d9412f", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "f48f8cdd-2f78-d1f4-8546-55e53fa147a2", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "f4d5e080-3fed-8109-2129-d774ede4123d", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "f5a17134-8d98-8c79-5e8e-df528cbecd83", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "f6772830-b34b-1d5b-6633-820dd62c5c02", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "f6f47760-6361-ee41-6255-b291ea4600b4", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "f8ad4631-fdd2-506b-e471-e2041401daba", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "f8be17a0-408e-e2dd-3c1b-6ffddb4185ff", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "f8dbee0d-2cd0-4fd8-529b-debe83c64f4a", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "f91c1c31-b7c4-3561-0d35-1774f56dd285", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "fbd60b76-c388-94cc-b92c-1e1ce2ea0913", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "fc47173b-f1b2-614e-82f0-eb2f0f4fe92a", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "fc4a1a33-9953-a9f3-00ab-afd1b89dc2e8", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "fe2ba999-5615-2c19-c9c9-60153195bce5", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "ff082da8-0206-1639-740d-2f2fd480909b", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "ff3ba2eb-2da3-6a8f-b57a-bd4ffdc5b987", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "ff70c7a4-a0a4-25f7-828d-0f73d22d50c7", "455c6918-8f55-8171-e3b6-573e17977cfc" }
                });

            migrationBuilder.InsertData(
                table: "Attend",
                columns: new[] { "group_id", "session_id" },
                values: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "68d03176-7999-d56b-1502-f5cbb0c3611e" });

            migrationBuilder.InsertData(
                table: "Teach",
                columns: new[] { "session_id", "teacher_id" },
                values: new object[] { "68d03176-7999-d56b-1502-f5cbb0c3611e", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0056b48e-646b-1783-e719-29ef81ea762a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0091cba3-5f4c-8290-7f29-69bbf9ac6c75" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "00c13648-2c99-5428-44db-05a0c0279cf0" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "015e0664-9e05-7ec5-026a-02358ea2fdcd" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0186b8c5-7384-82e7-630a-125e669795fa" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "01b7f46e-e743-7e80-acd8-a17d880f56d0" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "021ebba2-249f-412c-5eb1-3e0c4948ccea" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0240e089-b8a7-a02f-258a-a8b6c8d126fa" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0281ab1f-a5e4-530f-05d8-634d4674961c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "033c0d0e-6ebc-eac7-402d-0a65b07b5d05" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "03672eca-e781-12f4-2d9b-a8a0ef7371ea" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "03dd7c2d-0e63-63b4-fce6-4cef1114723f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0451df21-9439-2fdb-b358-3a18b53abeb0" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "04c21ebe-dd6c-b7a5-ccc0-34b07be385e1" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "04e7c487-4657-0550-418c-6ae0d96b0528" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0514db36-1e6b-9f75-e491-6d62278fe3d7" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "05ac8d14-9ecc-b065-64c4-5df33f73ff93" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "05f45355-dcb4-bfc1-eca2-89610fcef0d9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "06324105-c510-7ccb-8f94-e4870ce2e627" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "06b02a80-c9d1-d88f-01d0-4b332bf3aec8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0849ab21-5c47-8cf8-670d-35a386c99293" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0a08ff61-3964-d9ce-66f6-95b9fed4b85c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0a1e6c34-263b-19da-8f16-af1a8c36f35f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0aa26dd6-fa27-a71e-c93f-521ffc61e5cc" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0ae9f823-f08b-d78f-4df6-cc81679f3637" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0b4864d5-d4da-199e-5176-98bbfc05e7de" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0b4c6aff-e816-b058-5365-42db3f1e5d8c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0b8454a7-0a16-cf00-e450-67acb872b63f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0bf8e9e5-9b13-98d5-464c-f806a63e32c0" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0ca0abe1-8f3e-0b41-55c1-ef443bb6ea4b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0cd8d9f3-0c28-666d-7b5b-fddb4b07baac" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0eac91c7-8342-c0e4-8486-23bc65f11a5c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "0f759511-6d88-16ab-f5c3-5393413b7374" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "1058d1f9-1cc3-2808-aac4-059b31118f9d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "11ad3e3e-3e22-3940-c40f-12d0aa828da7" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "11b3e597-791a-0186-c8a9-b9ebcf03c46c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "12b42ac9-b980-4a40-07fb-1ac7850b48f6" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "12f0485e-7175-e7c7-5f34-9a5d287363f0" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "133278cc-7933-0286-e390-0fc4a7c1b142" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "1602657d-7ad0-127e-ede9-53f5a9462a02" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "1627b02a-1985-4026-7d79-48231e25e736" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "1734038d-4527-75b4-b567-6e3cb8c2e754" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "185d79a9-7e4e-9529-350a-3da955eab609" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "192a3e79-1737-a728-a963-36f925baffcf" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "19e792a4-0483-3555-0a1c-a0ed0a1576e7" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "1b168d80-ed4d-134e-39e9-71249e4c0507" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "1b7bfd56-148f-400b-b749-42d9a7795b40" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "1b7c5fa9-a3ac-def6-7c3d-dae37cafb16e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "1bbd08c7-9fdf-8b99-83f0-194d30ecf035" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "1d62de39-a195-1f19-531c-586e0b001796" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "1d91292c-0920-91d0-bed7-087e0898e6af" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "1dc1cb0f-8b56-5156-3c9b-7bd80fd6d19a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "1e482bc0-cb16-87ea-b49f-ecd316a2c08a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "1edb9a35-2dd8-fd90-c524-ef01391f97e7" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "1efc29fc-be39-f8af-e74b-60bc554c6e07" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "1f25b7fb-08b8-61ca-e752-399c77c7ef18" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "1fa7e581-d14d-f584-b7b7-3157b90f044b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "20fd11f1-9d76-af81-a983-e277b5065596" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "2113fb7b-0c39-c75f-80cb-24ac87012268" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "22d299bb-59f1-1abb-bec3-812a9dd3b5e3" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "2300fc1f-af6d-738a-1ea2-84f7a0e8f992" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "24890c6c-e90d-38be-651f-3943a6f6ea0d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "24b867d5-8da5-1e4c-cda6-1c1d3c7bca96" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "24bdb534-9db2-56c1-541a-98c6628ffac1" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "250a707d-9a6a-fb4b-293a-0b493f02d48e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "251f287b-bbd1-1cf0-1088-dd9fc8d6a950" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "253f5749-818b-1a88-32e9-5dc0104fc2aa" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "257769b4-8b4d-7462-3b1a-e97b8b18d1bd" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "258ce124-a53c-53ce-891c-1ea6db4607ea" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "2652da8c-eb61-912d-6466-fa10b62e3520" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "282ef117-7b5e-4151-2e5a-b04fbec08021" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "28bdcd73-2251-4ca3-10c7-95e04d2dc193" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "28fa2e04-d2a3-c9c2-2765-58ceff54c266" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "29713359-c512-2642-bd35-8fdc7b713a86" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "29e9000b-929f-6ed2-4da4-08a48438c572" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "29f81d4f-f254-3c81-0800-484fff4f95db" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "2addb7b3-2b07-8a74-2cc4-54477360f8cf" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "2b9a99ca-97e3-ab45-6adc-18c0401e2271" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "2c254944-38d1-2bed-b104-4a98c3c374f9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "2c25f4cc-1a17-b424-e587-50429d74e7ee" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "2c2a7076-d2a1-aab8-c0cc-c2e4987052e7" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "2cbd2815-0d3b-af8c-cee2-c3fe4475aa8b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "2d258078-d362-5598-81b6-d303b58aa17c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "2ebe1d68-df32-c1ba-0f2b-518e7fa0cdc6" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "2f27bf5f-9f51-0f83-2802-e450bcfe54d8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "30aab798-8663-49b3-924d-2228a5d800fa" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "30c224f9-a838-d4a4-510e-c5c9bc0629e8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "31070994-cc4e-a988-3590-882ca0efb529" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "32f442d5-d876-73a9-8df5-64e07a5d3f2d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "334bea02-aa9c-4cd0-cf37-b1cea75708b3" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "33e58c5f-41bb-41c0-7ec9-0b6268a5e750" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "34fa4ca6-fd2b-01bc-14d2-1fe35a8cfda5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "35e6a580-20ea-f11f-d809-147bf282fdb2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "364f949f-4f8d-abfe-a012-8dde7f6274a9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "3651bd6e-248c-618f-a526-7fb73d1baf2f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "37193eae-9c03-29b6-840b-0c9ab3caf2ed" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "377cb800-1c31-487e-f813-a69cf52eee2d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "37f609e0-2c09-aad4-b8a2-d2a600514b39" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "381194f6-13d1-0784-ef42-2252bb8c2de6" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "38c44239-042b-9f47-b126-8bac5a935de4" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "3a75ece9-d6bd-8369-eb49-e0dd587b83c8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "3b276f2e-e4dd-6f2e-f7c2-dafc41842740" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "3ba81963-cccd-65f9-73df-02219e2c2e7e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "3d349848-9686-f1c8-de8a-688906a214cc" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "3e9a3d32-6316-244b-56e7-1b6bcec630bf" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "3f9efddf-d4ac-b783-4fd2-ef586805836c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "4058b0fa-48be-4e17-2576-c4135c300b34" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "408a61ae-4b6b-0076-67ce-a465b6fa9dca" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "41a5c5f3-39a7-fd50-55f1-15a5ffdab6af" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "42468a5a-4a16-eb8e-de47-265fc96a4ca9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "437a2f46-83e6-12b5-d427-e9cfefbec976" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "43835ede-7675-be2c-7c3b-1b062538fa9f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "441a291d-b318-85bb-ad24-07c5c11f5062" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "4455a522-1f44-6544-eed9-9335814735f6" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "4465707f-e953-9211-c9e5-fa31eccb30bc" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "446d9588-beb3-632b-0e25-e1b5b4f33776" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "447fd5eb-36b6-2ad8-db74-b20bddf788a5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "44f6ff10-d9ea-89f1-6e59-8804e41a182b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "45380ea6-04b6-5c4f-748f-26a430eb604b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "46c17505-618a-4ab0-6173-304a63b6b627" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "47702301-4262-c698-1569-cce48dec8d1a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "481e422a-50e8-4125-184a-14a073fb947a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "49282f5e-88a1-e68a-cf2b-b70e99cc24d6" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "49df7fc7-082a-69a1-0440-377f6e1fde69" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "4a4c2da0-0133-601d-1522-921ce26123d3" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "4acb04ae-4f32-0992-3ffd-50b16241ba97" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "4ae299ae-0f82-b71d-0262-22bb2a532176" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "4b7c860f-0fc0-abf5-476f-3a45fa180ca8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "4c877cbd-bfb5-2f1b-f281-36f0c8137a99" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "4ce01da5-4f9f-5257-b982-7c7a6e70e1d4" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "4d6b8d40-5855-e522-368d-ad628b0372ea" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "4e9d38e8-b380-471f-bc75-979ad0cdd4e8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "4eef927f-1d7e-5446-0f24-488523a20b01" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "4f11ef9b-0cf2-26dd-fe1b-1d4d63075c9f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "4f215f44-2da6-46e2-e33c-59f53c74c0ff" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "5015b809-1fa9-1fa5-650a-2a405fd64085" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "50d9044e-0086-d1f3-254f-77152cd854e8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "5175db0f-8378-8d13-46b3-8edb798ee7df" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "51ca6d70-ecb7-c756-e98f-11e9e46eb1bd" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "51e907e9-b001-29c7-1d2f-82526931ca1b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "52310af2-ece3-cd10-f89c-46732e228f89" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "5294bdc8-57c8-442a-5a7e-5b06f82ac5e8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "52a673d4-2604-d117-fa31-59e6b1583b05" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "52d5138e-d17c-a425-ef8f-47d0d46c0a79" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "545669bc-406f-75a2-c5e8-1eb4a6a7bffb" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "546331da-fcbb-455f-1cfe-ecbd95845602" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "54daaa31-3130-ffc0-c011-b8d202aa19d6" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "555c4f01-12f9-5870-2fc2-954b990f9ea9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "5561b254-a62b-e8eb-bc3e-43d0d935ab76" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "557a5d2d-2c5b-63cd-ed1d-69a53390882b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "55a67536-efb2-9b26-ab0a-968135ce47c4" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "562094e8-3ad2-2a03-0579-fc1418b5f659" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "563098bf-4f57-55cd-5db5-817ecd76d316" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "56ff463d-10f6-6e00-3a7d-c4aea77e299b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "5702f7da-be71-c268-696f-98d52e88ea53" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "582a1dd6-8a44-76b0-8c01-7261083f0172" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "586c1df1-b67d-a268-6dd0-09b96b2c644f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "58858d76-14c3-cbe5-adc4-8791825c778e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "597e10ad-aa92-7822-1987-a88d6cf5852f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "59922d63-7e84-a47d-e7e2-ca0253d54ace" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "59c8349a-3b56-1684-bcfc-15b8ba173f15" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "5d1d4bd0-53eb-e05b-237f-6514f5b79081" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "5d96512f-a43c-9fdc-5c4e-f83ca7b76102" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "5e65d782-df6f-14a7-c210-3213fc284e29" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "5e86ab2d-34b7-1cb2-ef43-ec920c0a70e6" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "5fb45997-dbe8-5a6d-46db-ea5654a68a27" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "602d6044-d51b-bbd6-a54c-1a345e89937d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "60544a1d-7058-eae3-3dde-a79b6b8ef9c3" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "60d3c38c-09a5-dce6-6101-41ecbce1bf03" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "613bcf8b-9d1e-e78d-17d2-53422ab92602" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "61f6ef7f-4330-e352-da28-4895756a5251" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "61ff370e-6c73-3674-a907-9007cd4b33a9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "622a60bd-1788-2e1b-a6a0-c8f4e1d1e219" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "62512fb2-d619-81c7-3311-1b118818d52b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6255702d-a7b2-bb95-f10a-49b274da6d53" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "62ac54af-88e9-dfa2-813c-7794254d1335" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "638a4120-4be1-950a-fec5-94663410af82" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "63e4081b-ce44-4976-db5f-bb0600bcf7af" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "64e321fd-02c0-e40f-12b4-d66aea725403" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "652b1fdb-8e05-5f20-7458-639066ce3139" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "65472971-26a2-f130-16b1-1c92bbd22ed0" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "66d7cc94-016c-2ade-9bd5-b80af34bf830" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "66e64f1a-bcdb-e90d-4b74-760046e2450b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "67bce44d-530c-659e-c998-e149a26d5125" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "67c0607e-1a86-5adc-1cbb-1b67ebd4f5c7" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "68b1f719-fd66-8ebb-ac71-4ff3607a297d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "68d03176-7999-d56b-1502-f5cbb0c3611e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6961bdc3-425e-2f60-be51-9f75ba501dcd" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6979eeb6-1623-28d8-2c4b-aa9c9ca3dd61" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "69d170b3-caea-dcc2-2098-39eba8d87e7d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6a0168cc-dc00-e5b9-3d51-e63ac454ab2d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6a693347-e820-3da0-51aa-7f83809be309" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6a8902b7-62fa-3c0b-741d-c65a94b9bc40" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6a9c2aba-178c-4935-0602-b587d85cce25" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6b79c9c7-2703-0c83-47a0-7b93b92595f5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6cb8f5f6-9138-6744-da11-698ada9c7cd9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6d0a9a86-a0c2-ab66-6cf4-0b82f34cbcaa" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6da289df-b92c-187f-6dd9-988eca909576" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6dea7d94-a09f-56f2-f31e-0cd3aac5ab06" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6e86371a-fdc1-a36b-ebb9-ccdbc764ed53" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6ede21c7-5e01-847d-90d3-85a92e3b87bd" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6efe6515-de20-2195-a929-b8f79fb59e3e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6f3e4dee-356c-1e4f-91ea-c4aacd751af4" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6f877b46-e63b-1f94-279a-86e19b4c5761" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6fe7c898-a901-a39c-6bb0-d06bd0d6e5fb" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "71703b6c-1f4e-53ec-e9e6-2e0174689404" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "72a3c917-dfaf-9ddd-88fb-94f9ca743271" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "74f4e56c-46d0-b7b4-aa59-11386a4ea5fd" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "7527c779-5120-f31d-474d-61aff31bc8c2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "7636a876-a0ef-b958-5ccb-fa1744245061" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "76570e22-cf14-6006-bcb5-b33b40821d16" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "769cb487-c2b4-dfe2-c6b9-0fba223fefd2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "76a47667-00d8-1aed-4659-1935af3c9c95" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "76a72df6-2cda-3c30-6f4c-66d8d7517f4e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "76b957f7-e3c2-291b-7522-effc736f5b46" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "7710775c-5b25-a750-18d6-63956d2fccf7" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "77245690-2f64-8b48-384f-600788950792" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "780954cc-cb71-98e4-921a-36493c1213ab" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "782ae39e-a5d2-9cc4-3fc7-5d64bc387293" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "78750878-ef0d-057e-c510-51e22b56ee0e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "78a0fa33-dc9f-e211-b484-baafb65a9751" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "7952bd2c-9bf5-fc7a-018f-c55e5ea6a639" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "799fd89b-42c7-3ef3-6c3c-ffcedbff6861" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "79e45e6d-96cb-5c40-a6c3-e18a6d44b454" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "7bfcaba8-0d96-44e7-df91-80bd72afaa1f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "7c62f011-6077-ed38-5ea4-4bb85363ccb5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "7c84033b-5176-ff52-bf0c-2d96a280808f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "7cfc755e-5b32-8d59-789c-bc4dd2100d61" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "7d62fd98-d42d-cfa9-2959-3cb49a0b2ffc" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "7edc844d-8fdd-7aff-15d9-a2a0bbc13b82" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "7f2243f4-ac3d-acde-849b-c8a89c2180af" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "7f3bd210-62cd-bc91-18e1-e0eb300567f2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "80517491-33d5-45f6-4b9f-2a73dabbfac0" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "81c2420f-339f-14dc-75dd-01c9688542bd" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "820cc779-f49f-5bdc-d9b1-8e1b5faa0477" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "82714fa8-f934-7af7-a9f2-8296dcd9a0c2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "83b0393a-1b75-fa6f-7f72-02d12d0fe1f7" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "83d8c26f-491d-fe4e-5fbb-6befa442c4b6" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "84791388-7f45-2463-c3cb-b60e2beecb42" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "84b4ae16-7e63-9425-edc3-2828257f19b9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "853fd355-afab-e34e-3932-5edd59a14471" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "879a6a99-bb2c-37a9-766e-a310fe50294f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "879c6462-be54-6a55-3f7a-c71691eff10a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "883954fa-8710-fa17-ac5e-9019be27c7b3" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "887f71d1-a887-b99e-f276-dff6af9c5d76" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "8896c2af-a850-2d70-92b7-e36a6630c282" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "88a9d605-45a4-7dba-3085-4963782e8da1" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "88bc1f89-0749-56c2-c09d-df1d426ffc30" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "88bf75c3-eafe-f500-22e1-80e974eaf9a9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "890fff94-7866-0993-b421-ee7b72322af7" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "898a34e4-9b61-d1d5-b386-750cddb45093" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "89a8a3a0-f0b5-f882-cbed-62c800a42b67" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "8b24abf0-7d82-945d-9f59-df957b49026b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "8bfd4e11-7816-f525-8723-b142709b59a3" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "8cfb7ff3-442d-26df-1431-da48ab37532e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "8dcf77d5-4bb8-4a37-c156-8378722486e6" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "8f4a50b6-d908-a23e-8f91-11ecfaf85f8d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "8f5034bb-2a44-e79e-6077-937b9e2eb778" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "8ff39507-c5d8-26cc-69a3-7e0737654adf" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "900080d8-70d4-55f9-da68-9b515a38d066" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "9084f470-325c-483b-f43a-ba4c72ee85e5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "916d390a-b5f8-a47e-c047-99ce0772f358" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "926050e2-d137-dd61-ef03-70f839196de2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "9282ce07-8b76-3331-139a-3bd67c69f78d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "93236a10-6062-4627-9669-e68c7a9a512a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "932db80b-bbbe-0554-eb22-b1ce43d19e43" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "93a8edeb-fa34-5caa-0a30-bc9fa1256165" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "93b325a2-1a3a-ccd4-2dd4-1760da9e566b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "94f13bbd-c7c5-6bd2-b7e9-52dc0966f576" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "960a4d6c-57ca-5d75-ec41-814efa474455" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "968f01c1-f329-f7b2-ab09-e3101785e985" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "96a355c4-e5cb-088f-316e-114cd303e69f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "97ba9829-84cf-fe71-ae74-3c7b060094dc" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "9890bc17-31b9-f162-f970-60b0775a6d12" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "98ad42af-7b62-d045-c029-acc7f8391178" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "98c79796-6474-5451-a8fd-fbdfeaab98d1" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "99485134-637f-7f92-aa87-ef09cc97060f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "99970ce2-4a02-f1e9-0c8a-b2036566990b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "99b56292-1db6-2eaa-1288-6ffe8ab9f867" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "9a513f41-293e-f359-228b-0ae8a899031f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "9b120356-d713-52aa-6d15-0ab20a6dafa3" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "9b129a34-ff85-acf3-f293-10326813c2a6" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "9b97f7cb-2fd2-1b2b-7fb4-48549c9bce71" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "9c805c50-f759-7741-630c-deb8cb68ba8d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "9ddfae2a-a9d0-ee5e-363c-9d1d546f35f9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "9df27dd2-5b2b-c22b-8bf9-2ffc7ae6beac" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "9e16991a-6b3d-afa5-9b5f-4fa492f6968a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "9e8406ec-c5cf-c049-573a-e095a69d467d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "9f0735a9-35a8-4ab3-1ce6-30127c7ddf10" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "9f61d871-99d9-56bb-6c0b-ac3e63961c62" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "a058e8a5-6167-8fb2-40e8-7a78db40cb18" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "a13ad1a5-bc2c-d63f-e354-a07fad74183a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "a16acd15-b2a1-6c4b-5863-94bbd012c634" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "a1843163-d8ba-b59f-684a-014886bd3d61" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "a25df2d0-0b45-9ba0-6124-d90473770072" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "a2da7e4d-71fe-bc21-a388-bf057c332e9b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "a30142d9-69c8-572f-6e00-36337174568a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "a321cf46-28c1-494e-363b-768a8c0ea651" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "a3ef0364-5887-0b4a-0e3f-a21f7831dab4" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "a5903bd3-3b04-7e69-11b7-732fa860c788" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "a63701af-c71f-0544-02bc-d0280dee25ed" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "a84e00b6-e85b-0b23-352b-9aa3ffe7314e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "a98ab2f3-b600-aa92-df9d-36a8b29618ce" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "abd180fb-51b2-f036-0801-160bf90d7ff5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "ac33006a-f6a7-b30d-924b-b9599a119708" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "ac3d6140-0409-55a7-b2ef-a8a48c6a005c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "ad0352cb-af71-03e2-f7df-fcfd332d43f6" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "ad045d93-a868-e459-2cac-86d7eaee8cbc" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "ad9b3882-b23f-7ecb-96cd-d373c961086c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "b035fcae-1e8a-9fa0-49c5-fc0683abb1da" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "b068d9ed-052d-db39-42d5-f761fb91389d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "b0b518c2-a0f2-014f-aa51-bb87f5303bb2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "b2b61f8d-4efd-b3a1-11fa-c03b6cbe4c80" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "b4a63901-0da1-eb7b-337c-6faec61f874e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "b4c4e99d-fb21-e705-082d-9fc412367c4c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "b4e13ede-e71c-c186-bc27-870c75e7fa67" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "b60cb0e1-40c9-a5e7-1e80-652fc7e60428" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "b65ea77f-0e71-5a29-e989-834ddd46ad27" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "b7c1bf18-8580-7593-aef3-07ac58070309" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "b963ef01-1013-65af-0dae-792235151046" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "b979e399-3c5c-bc24-51fc-cbe7015b3815" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "bac650fc-e433-b6c8-ea8c-5897aaca3ec4" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "baca9ff5-9366-45e4-601e-9abe5fc1a116" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "bacd5124-36c2-d836-b1d9-1c102fb463e2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "bcbecc4c-c68d-698e-a66d-3dee53146775" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "bcda868b-6398-0edf-ee1a-4e6e1f3c7ad9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "bd0003a7-71ef-64fa-f405-2a8bc1f818ac" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "bd9d3143-409a-0f66-ed4b-777fb22d9eb9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "bdb036bd-e677-8f22-3e58-ea3960108397" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "be69de91-98fb-dc9b-1101-1a7fc424aed6" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "bebf7f2d-d0c4-8f83-295d-815d8b032f00" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "bfe31176-d336-318e-e3ed-ba48e2bc3165" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "c04c2819-327c-b89b-c9e0-3873bad8caa5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "c16f9c29-49a4-27ea-0dde-3cb64d935374" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "c2f5b7d2-8f15-ffc8-53c2-db0ce86adc84" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "c37e09bd-181b-3d96-2267-136727f2138b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "c3baf7b7-0b10-9349-ce60-5e337c5f52b7" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "c4ddd6d9-e547-8150-7cbb-a70c8a4ea647" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "c4fda568-4149-5765-76ca-f7ab1369f72c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "c537988b-784d-2ea2-3809-35137ba3ebcc" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "c57fc538-62be-d295-4d6c-9a96583b2e82" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "c61b143a-76b8-b0ec-0e2a-08728ca06f99" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "c7230259-ea86-ac19-75bb-b2dad1a7ed0d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "c993a9c2-00c0-6c35-a8a0-acbb8dbf8753" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "ca196df1-2e76-e3c5-5b7f-909737937fd1" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "ca332a52-83dc-966b-2342-2cfa7834704a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "cabd52b6-a9ac-25e0-f006-07b9930bd0c3" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "cbf0a3b0-23aa-ebe1-ecb0-2f49a219687e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "cc1386d9-f61b-4f16-b7f2-95c233d40325" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "cc801d7a-0b5d-c9ac-4abc-7f710fafc579" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "ccb84504-009b-9e1f-6ce9-0be79bb9d7d6" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "cda690cc-9d90-b01f-a225-e231fbaf2d75" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "cf2227f8-70aa-e895-7365-f15ee87416bb" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "cf9e4513-7a68-0fdc-c515-738bc7c05bcf" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "cfa498cf-480e-686c-2f55-1e85a2647581" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "cfead747-9003-9e9b-52bc-0b41c8573a39" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d023c16b-07bb-4858-64d8-83d703d81765" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d0be853e-e5c9-c00a-3210-24826d54c8c9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d0c70ae1-f86f-a9bb-5fca-6dedd3a1f20e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d10298e1-5278-47aa-0f71-0797c103d6bf" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d12b6441-c021-e685-c2a0-ccb6d18c6e2d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d13345ea-8622-2baa-5ca1-e65ec6f6d3cc" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d1e482c5-5f57-881a-bc65-4b0554787a06" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d272319c-c4bc-7e55-a5fc-c1d865ce2883" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d313aa93-bceb-8611-cca6-98587fedb027" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d3d5330e-9305-c5d7-f15a-ad3e9222c64a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d3e94f59-6971-3fd2-3883-5f737558e970" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d4a2b82e-ac81-a489-3fdc-7ec091f63120" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d5c40a0d-5c86-c041-1c69-6d7124c1e5bb" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d61166a8-3d8e-05da-a441-d02f25fc1b17" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d6e39a4e-8f99-c2c5-1822-c304edb960f3" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d70feb19-c076-1b92-3271-7948a4d2ec6d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d7170eca-6fea-c607-d3ea-a156d892282c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d754a532-6439-c81c-1483-071ac7753f6e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "d848e964-36fd-7e2c-6bac-bd62ea17d076" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "da05cec6-33ff-2f51-78eb-672bdce9eedc" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "db66eb60-ccdb-191c-0c31-b065ed6d0c07" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "db989267-e3f8-d20e-50ce-1a86a2cb57de" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "dc7bb52c-c8ea-4b9e-12e9-bcd0082fbbe7" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "dcb53a8b-1ca9-8890-1554-fb1f69795899" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "dd29a66e-0244-8e91-bb9e-5eb5b60dcc21" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "dd6279a3-ed2e-e099-78b8-e975ad79687f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "de4b747f-2f87-b06d-520e-007961ddec2e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "df6c40a6-74f6-3ac5-3ee4-300429a61e92" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "dfa69c92-c9b4-adf9-0115-99847777c0fb" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e0234452-8d42-ea87-6893-c8dad80a84fe" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e032d36e-64fb-e93b-27b9-37683c91d300" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e1eb12cb-0d6e-2027-4210-915e431f4ee1" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e204a5c3-39d1-cf4d-201a-17b13ca7a645" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e242a289-dfca-efbd-da76-61b5c7801269" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e299482e-7b44-d8ed-01cf-ae87285d8dc3" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e2c94de3-afd5-3f70-dc53-3a85d0ccf301" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e31bb2d7-2b9a-a6ab-f504-5733579b55ee" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e32ef38f-8b36-731f-a2cb-144fdf2caa9e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e3943ee6-d742-976e-27d7-c25fd96be488" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e3991f32-1ba2-8da6-8bee-13eba7e85116" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e39b9f48-8efc-4076-6041-db0363d180d2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e3d506b8-4836-4dd0-f312-e6111b78375e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e4155591-818f-ccbc-dec2-1f13a4ceabcf" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e54f716f-5bec-79e2-3621-5d67e987b557" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e5768617-c1aa-9f58-6294-50c88eb76415" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e6784a9e-fd61-5183-b498-c10d934e8e00" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e7350ca5-30bb-8485-c1bb-068f4f9a3111" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e74c971d-569c-0886-9869-07377c0ca1fa" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e77dec89-6970-70ac-95b8-3cdc5e790b3e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e8a6ddaa-c287-1fe4-b545-bdc2fd737e27" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e8c252de-2177-6e6b-6a96-97b24e5d5b7c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e8c891d5-d3ea-f1f0-af84-4fc0ee0ed391" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e90f9ec7-abac-39a0-75db-8e26d17e1d23" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "e99b900e-d9fa-606a-a428-aecaa24585f0" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "ea2644a3-6940-66dd-8ade-abe2c55365e5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "eadd632c-d2c1-e747-3094-e99e549421fd" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "eaf9ef0a-dee7-c3a3-cded-0b69ccd9aa15" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "eb4782fc-4751-f80c-b548-f550874f4182" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "eb74d386-f79e-d317-141b-26eb9f3fd90b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "eb805281-c659-1c4c-ee27-bf6c913df877" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "ebe2026d-144c-a338-087f-de57a76fa97a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "ecd70e45-0560-ea42-6c72-a4e6f64c7caf" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "ed2ba61e-d0e4-5997-83cc-4f6ccef9664c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "ed5e554a-a46e-ff18-f963-08d2d533dbca" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "ef0a6048-6175-f72e-7151-6650c8532708" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "f1920d05-d079-d363-8deb-07fb5734a4e0" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "f35c38af-d54c-f9c2-c3b9-033da24e2e2c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "f38bae86-3131-c1a3-e7b0-39abb9d9412f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "f48f8cdd-2f78-d1f4-8546-55e53fa147a2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "f4d5e080-3fed-8109-2129-d774ede4123d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "f5a17134-8d98-8c79-5e8e-df528cbecd83" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "f6772830-b34b-1d5b-6633-820dd62c5c02" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "f6f47760-6361-ee41-6255-b291ea4600b4" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "f8ad4631-fdd2-506b-e471-e2041401daba" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "f8be17a0-408e-e2dd-3c1b-6ffddb4185ff" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "f8dbee0d-2cd0-4fd8-529b-debe83c64f4a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "f91c1c31-b7c4-3561-0d35-1774f56dd285" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "fbd60b76-c388-94cc-b92c-1e1ce2ea0913" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "fc47173b-f1b2-614e-82f0-eb2f0f4fe92a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "fc4a1a33-9953-a9f3-00ab-afd1b89dc2e8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "fe2ba999-5615-2c19-c9c9-60153195bce5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "ff082da8-0206-1639-740d-2f2fd480909b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "ff3ba2eb-2da3-6a8f-b57a-bd4ffdc5b987" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "ff70c7a4-a0a4-25f7-828d-0f73d22d50c7" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0056b48e-646b-1783-e719-29ef81ea762a", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0091cba3-5f4c-8290-7f29-69bbf9ac6c75", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "00c13648-2c99-5428-44db-05a0c0279cf0", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "015e0664-9e05-7ec5-026a-02358ea2fdcd", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0186b8c5-7384-82e7-630a-125e669795fa", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "01b7f46e-e743-7e80-acd8-a17d880f56d0", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "021ebba2-249f-412c-5eb1-3e0c4948ccea", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0240e089-b8a7-a02f-258a-a8b6c8d126fa", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0281ab1f-a5e4-530f-05d8-634d4674961c", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "033c0d0e-6ebc-eac7-402d-0a65b07b5d05", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "03672eca-e781-12f4-2d9b-a8a0ef7371ea", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "03dd7c2d-0e63-63b4-fce6-4cef1114723f", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0451df21-9439-2fdb-b358-3a18b53abeb0", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "04c21ebe-dd6c-b7a5-ccc0-34b07be385e1", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "04e7c487-4657-0550-418c-6ae0d96b0528", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0514db36-1e6b-9f75-e491-6d62278fe3d7", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "05ac8d14-9ecc-b065-64c4-5df33f73ff93", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "05f45355-dcb4-bfc1-eca2-89610fcef0d9", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "06324105-c510-7ccb-8f94-e4870ce2e627", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "06b02a80-c9d1-d88f-01d0-4b332bf3aec8", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0849ab21-5c47-8cf8-670d-35a386c99293", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0a08ff61-3964-d9ce-66f6-95b9fed4b85c", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0a1e6c34-263b-19da-8f16-af1a8c36f35f", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0aa26dd6-fa27-a71e-c93f-521ffc61e5cc", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0ae9f823-f08b-d78f-4df6-cc81679f3637", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0b4864d5-d4da-199e-5176-98bbfc05e7de", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0b4c6aff-e816-b058-5365-42db3f1e5d8c", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0b8454a7-0a16-cf00-e450-67acb872b63f", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0bf8e9e5-9b13-98d5-464c-f806a63e32c0", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0ca0abe1-8f3e-0b41-55c1-ef443bb6ea4b", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0cd8d9f3-0c28-666d-7b5b-fddb4b07baac", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0eac91c7-8342-c0e4-8486-23bc65f11a5c", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0f759511-6d88-16ab-f5c3-5393413b7374", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1058d1f9-1cc3-2808-aac4-059b31118f9d", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "11ad3e3e-3e22-3940-c40f-12d0aa828da7", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "11b3e597-791a-0186-c8a9-b9ebcf03c46c", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "12b42ac9-b980-4a40-07fb-1ac7850b48f6", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "12f0485e-7175-e7c7-5f34-9a5d287363f0", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "133278cc-7933-0286-e390-0fc4a7c1b142", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1602657d-7ad0-127e-ede9-53f5a9462a02", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1627b02a-1985-4026-7d79-48231e25e736", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1734038d-4527-75b4-b567-6e3cb8c2e754", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "185d79a9-7e4e-9529-350a-3da955eab609", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "192a3e79-1737-a728-a963-36f925baffcf", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "19e792a4-0483-3555-0a1c-a0ed0a1576e7", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1b168d80-ed4d-134e-39e9-71249e4c0507", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1b7bfd56-148f-400b-b749-42d9a7795b40", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1b7c5fa9-a3ac-def6-7c3d-dae37cafb16e", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1bbd08c7-9fdf-8b99-83f0-194d30ecf035", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1d62de39-a195-1f19-531c-586e0b001796", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1d91292c-0920-91d0-bed7-087e0898e6af", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1dc1cb0f-8b56-5156-3c9b-7bd80fd6d19a", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1e482bc0-cb16-87ea-b49f-ecd316a2c08a", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1edb9a35-2dd8-fd90-c524-ef01391f97e7", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1efc29fc-be39-f8af-e74b-60bc554c6e07", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1f25b7fb-08b8-61ca-e752-399c77c7ef18", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1fa7e581-d14d-f584-b7b7-3157b90f044b", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "20fd11f1-9d76-af81-a983-e277b5065596", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2113fb7b-0c39-c75f-80cb-24ac87012268", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "22d299bb-59f1-1abb-bec3-812a9dd3b5e3", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2300fc1f-af6d-738a-1ea2-84f7a0e8f992", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "24890c6c-e90d-38be-651f-3943a6f6ea0d", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "24b867d5-8da5-1e4c-cda6-1c1d3c7bca96", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "24bdb534-9db2-56c1-541a-98c6628ffac1", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "250a707d-9a6a-fb4b-293a-0b493f02d48e", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "251f287b-bbd1-1cf0-1088-dd9fc8d6a950", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "253f5749-818b-1a88-32e9-5dc0104fc2aa", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "257769b4-8b4d-7462-3b1a-e97b8b18d1bd", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "258ce124-a53c-53ce-891c-1ea6db4607ea", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2652da8c-eb61-912d-6466-fa10b62e3520", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "282ef117-7b5e-4151-2e5a-b04fbec08021", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "28bdcd73-2251-4ca3-10c7-95e04d2dc193", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "28fa2e04-d2a3-c9c2-2765-58ceff54c266", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "29713359-c512-2642-bd35-8fdc7b713a86", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "29e9000b-929f-6ed2-4da4-08a48438c572", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "29f81d4f-f254-3c81-0800-484fff4f95db", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2addb7b3-2b07-8a74-2cc4-54477360f8cf", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2b9a99ca-97e3-ab45-6adc-18c0401e2271", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2c254944-38d1-2bed-b104-4a98c3c374f9", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2c25f4cc-1a17-b424-e587-50429d74e7ee", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2c2a7076-d2a1-aab8-c0cc-c2e4987052e7", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2cbd2815-0d3b-af8c-cee2-c3fe4475aa8b", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2d258078-d362-5598-81b6-d303b58aa17c", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2ebe1d68-df32-c1ba-0f2b-518e7fa0cdc6", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2f27bf5f-9f51-0f83-2802-e450bcfe54d8", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "30aab798-8663-49b3-924d-2228a5d800fa", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "30c224f9-a838-d4a4-510e-c5c9bc0629e8", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "31070994-cc4e-a988-3590-882ca0efb529", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "32f442d5-d876-73a9-8df5-64e07a5d3f2d", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "334bea02-aa9c-4cd0-cf37-b1cea75708b3", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "33e58c5f-41bb-41c0-7ec9-0b6268a5e750", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "34fa4ca6-fd2b-01bc-14d2-1fe35a8cfda5", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "35e6a580-20ea-f11f-d809-147bf282fdb2", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "364f949f-4f8d-abfe-a012-8dde7f6274a9", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3651bd6e-248c-618f-a526-7fb73d1baf2f", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "37193eae-9c03-29b6-840b-0c9ab3caf2ed", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "377cb800-1c31-487e-f813-a69cf52eee2d", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "37f609e0-2c09-aad4-b8a2-d2a600514b39", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "381194f6-13d1-0784-ef42-2252bb8c2de6", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "38c44239-042b-9f47-b126-8bac5a935de4", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3a75ece9-d6bd-8369-eb49-e0dd587b83c8", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3b276f2e-e4dd-6f2e-f7c2-dafc41842740", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3ba81963-cccd-65f9-73df-02219e2c2e7e", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3d349848-9686-f1c8-de8a-688906a214cc", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3e9a3d32-6316-244b-56e7-1b6bcec630bf", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3f9efddf-d4ac-b783-4fd2-ef586805836c", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4058b0fa-48be-4e17-2576-c4135c300b34", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "408a61ae-4b6b-0076-67ce-a465b6fa9dca", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "41a5c5f3-39a7-fd50-55f1-15a5ffdab6af", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "42468a5a-4a16-eb8e-de47-265fc96a4ca9", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "437a2f46-83e6-12b5-d427-e9cfefbec976", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "43835ede-7675-be2c-7c3b-1b062538fa9f", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "441a291d-b318-85bb-ad24-07c5c11f5062", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4455a522-1f44-6544-eed9-9335814735f6", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4465707f-e953-9211-c9e5-fa31eccb30bc", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "446d9588-beb3-632b-0e25-e1b5b4f33776", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "447fd5eb-36b6-2ad8-db74-b20bddf788a5", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "44f6ff10-d9ea-89f1-6e59-8804e41a182b", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "45380ea6-04b6-5c4f-748f-26a430eb604b", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "46c17505-618a-4ab0-6173-304a63b6b627", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "47702301-4262-c698-1569-cce48dec8d1a", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "481e422a-50e8-4125-184a-14a073fb947a", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "49282f5e-88a1-e68a-cf2b-b70e99cc24d6", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "49df7fc7-082a-69a1-0440-377f6e1fde69", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4a4c2da0-0133-601d-1522-921ce26123d3", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4acb04ae-4f32-0992-3ffd-50b16241ba97", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4ae299ae-0f82-b71d-0262-22bb2a532176", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4b7c860f-0fc0-abf5-476f-3a45fa180ca8", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4c877cbd-bfb5-2f1b-f281-36f0c8137a99", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4ce01da5-4f9f-5257-b982-7c7a6e70e1d4", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4d6b8d40-5855-e522-368d-ad628b0372ea", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4e9d38e8-b380-471f-bc75-979ad0cdd4e8", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4eef927f-1d7e-5446-0f24-488523a20b01", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4f11ef9b-0cf2-26dd-fe1b-1d4d63075c9f", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4f215f44-2da6-46e2-e33c-59f53c74c0ff", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5015b809-1fa9-1fa5-650a-2a405fd64085", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "50d9044e-0086-d1f3-254f-77152cd854e8", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5175db0f-8378-8d13-46b3-8edb798ee7df", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "51ca6d70-ecb7-c756-e98f-11e9e46eb1bd", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "51e907e9-b001-29c7-1d2f-82526931ca1b", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "52310af2-ece3-cd10-f89c-46732e228f89", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5294bdc8-57c8-442a-5a7e-5b06f82ac5e8", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "52a673d4-2604-d117-fa31-59e6b1583b05", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "52d5138e-d17c-a425-ef8f-47d0d46c0a79", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "545669bc-406f-75a2-c5e8-1eb4a6a7bffb", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "546331da-fcbb-455f-1cfe-ecbd95845602", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "54daaa31-3130-ffc0-c011-b8d202aa19d6", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "555c4f01-12f9-5870-2fc2-954b990f9ea9", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5561b254-a62b-e8eb-bc3e-43d0d935ab76", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "557a5d2d-2c5b-63cd-ed1d-69a53390882b", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "55a67536-efb2-9b26-ab0a-968135ce47c4", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "562094e8-3ad2-2a03-0579-fc1418b5f659", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "563098bf-4f57-55cd-5db5-817ecd76d316", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "56ff463d-10f6-6e00-3a7d-c4aea77e299b", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5702f7da-be71-c268-696f-98d52e88ea53", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "582a1dd6-8a44-76b0-8c01-7261083f0172", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "586c1df1-b67d-a268-6dd0-09b96b2c644f", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "58858d76-14c3-cbe5-adc4-8791825c778e", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "597e10ad-aa92-7822-1987-a88d6cf5852f", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "59922d63-7e84-a47d-e7e2-ca0253d54ace", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "59c8349a-3b56-1684-bcfc-15b8ba173f15", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5d1d4bd0-53eb-e05b-237f-6514f5b79081", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5d96512f-a43c-9fdc-5c4e-f83ca7b76102", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5e65d782-df6f-14a7-c210-3213fc284e29", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5e86ab2d-34b7-1cb2-ef43-ec920c0a70e6", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5fb45997-dbe8-5a6d-46db-ea5654a68a27", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "602d6044-d51b-bbd6-a54c-1a345e89937d", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "60544a1d-7058-eae3-3dde-a79b6b8ef9c3", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "60d3c38c-09a5-dce6-6101-41ecbce1bf03", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "613bcf8b-9d1e-e78d-17d2-53422ab92602", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "61f6ef7f-4330-e352-da28-4895756a5251", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "61ff370e-6c73-3674-a907-9007cd4b33a9", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "622a60bd-1788-2e1b-a6a0-c8f4e1d1e219", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "62512fb2-d619-81c7-3311-1b118818d52b", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6255702d-a7b2-bb95-f10a-49b274da6d53", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "62ac54af-88e9-dfa2-813c-7794254d1335", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "638a4120-4be1-950a-fec5-94663410af82", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "63e4081b-ce44-4976-db5f-bb0600bcf7af", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "64e321fd-02c0-e40f-12b4-d66aea725403", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "652b1fdb-8e05-5f20-7458-639066ce3139", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "65472971-26a2-f130-16b1-1c92bbd22ed0", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "66d7cc94-016c-2ade-9bd5-b80af34bf830", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "66e64f1a-bcdb-e90d-4b74-760046e2450b", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "67bce44d-530c-659e-c998-e149a26d5125", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "67c0607e-1a86-5adc-1cbb-1b67ebd4f5c7", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "68b1f719-fd66-8ebb-ac71-4ff3607a297d", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "68d03176-7999-d56b-1502-f5cbb0c3611e", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6961bdc3-425e-2f60-be51-9f75ba501dcd", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6979eeb6-1623-28d8-2c4b-aa9c9ca3dd61", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "69d170b3-caea-dcc2-2098-39eba8d87e7d", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6a0168cc-dc00-e5b9-3d51-e63ac454ab2d", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6a693347-e820-3da0-51aa-7f83809be309", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6a8902b7-62fa-3c0b-741d-c65a94b9bc40", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6a9c2aba-178c-4935-0602-b587d85cce25", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6b79c9c7-2703-0c83-47a0-7b93b92595f5", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6cb8f5f6-9138-6744-da11-698ada9c7cd9", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6d0a9a86-a0c2-ab66-6cf4-0b82f34cbcaa", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6da289df-b92c-187f-6dd9-988eca909576", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6dea7d94-a09f-56f2-f31e-0cd3aac5ab06", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6e86371a-fdc1-a36b-ebb9-ccdbc764ed53", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6ede21c7-5e01-847d-90d3-85a92e3b87bd", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6efe6515-de20-2195-a929-b8f79fb59e3e", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6f3e4dee-356c-1e4f-91ea-c4aacd751af4", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6f877b46-e63b-1f94-279a-86e19b4c5761", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6fe7c898-a901-a39c-6bb0-d06bd0d6e5fb", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "71703b6c-1f4e-53ec-e9e6-2e0174689404", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "72a3c917-dfaf-9ddd-88fb-94f9ca743271", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "74f4e56c-46d0-b7b4-aa59-11386a4ea5fd", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7527c779-5120-f31d-474d-61aff31bc8c2", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7636a876-a0ef-b958-5ccb-fa1744245061", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "76570e22-cf14-6006-bcb5-b33b40821d16", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "769cb487-c2b4-dfe2-c6b9-0fba223fefd2", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "76a47667-00d8-1aed-4659-1935af3c9c95", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "76a72df6-2cda-3c30-6f4c-66d8d7517f4e", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "76b957f7-e3c2-291b-7522-effc736f5b46", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7710775c-5b25-a750-18d6-63956d2fccf7", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "77245690-2f64-8b48-384f-600788950792", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "780954cc-cb71-98e4-921a-36493c1213ab", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "782ae39e-a5d2-9cc4-3fc7-5d64bc387293", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "78750878-ef0d-057e-c510-51e22b56ee0e", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "78a0fa33-dc9f-e211-b484-baafb65a9751", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7952bd2c-9bf5-fc7a-018f-c55e5ea6a639", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "799fd89b-42c7-3ef3-6c3c-ffcedbff6861", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "79e45e6d-96cb-5c40-a6c3-e18a6d44b454", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7bfcaba8-0d96-44e7-df91-80bd72afaa1f", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7c62f011-6077-ed38-5ea4-4bb85363ccb5", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7c84033b-5176-ff52-bf0c-2d96a280808f", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7cfc755e-5b32-8d59-789c-bc4dd2100d61", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7d62fd98-d42d-cfa9-2959-3cb49a0b2ffc", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7edc844d-8fdd-7aff-15d9-a2a0bbc13b82", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7f2243f4-ac3d-acde-849b-c8a89c2180af", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7f3bd210-62cd-bc91-18e1-e0eb300567f2", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "80517491-33d5-45f6-4b9f-2a73dabbfac0", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "81c2420f-339f-14dc-75dd-01c9688542bd", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "820cc779-f49f-5bdc-d9b1-8e1b5faa0477", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "82714fa8-f934-7af7-a9f2-8296dcd9a0c2", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "83b0393a-1b75-fa6f-7f72-02d12d0fe1f7", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "83d8c26f-491d-fe4e-5fbb-6befa442c4b6", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "84791388-7f45-2463-c3cb-b60e2beecb42", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "84b4ae16-7e63-9425-edc3-2828257f19b9", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "853fd355-afab-e34e-3932-5edd59a14471", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "879a6a99-bb2c-37a9-766e-a310fe50294f", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "879c6462-be54-6a55-3f7a-c71691eff10a", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "883954fa-8710-fa17-ac5e-9019be27c7b3", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "887f71d1-a887-b99e-f276-dff6af9c5d76", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8896c2af-a850-2d70-92b7-e36a6630c282", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "88a9d605-45a4-7dba-3085-4963782e8da1", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "88bc1f89-0749-56c2-c09d-df1d426ffc30", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "88bf75c3-eafe-f500-22e1-80e974eaf9a9", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "890fff94-7866-0993-b421-ee7b72322af7", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "898a34e4-9b61-d1d5-b386-750cddb45093", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "89a8a3a0-f0b5-f882-cbed-62c800a42b67", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8b24abf0-7d82-945d-9f59-df957b49026b", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8bfd4e11-7816-f525-8723-b142709b59a3", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8cfb7ff3-442d-26df-1431-da48ab37532e", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8dcf77d5-4bb8-4a37-c156-8378722486e6", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8f4a50b6-d908-a23e-8f91-11ecfaf85f8d", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8f5034bb-2a44-e79e-6077-937b9e2eb778", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8ff39507-c5d8-26cc-69a3-7e0737654adf", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "900080d8-70d4-55f9-da68-9b515a38d066", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9084f470-325c-483b-f43a-ba4c72ee85e5", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "916d390a-b5f8-a47e-c047-99ce0772f358", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "926050e2-d137-dd61-ef03-70f839196de2", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9282ce07-8b76-3331-139a-3bd67c69f78d", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "93236a10-6062-4627-9669-e68c7a9a512a", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "932db80b-bbbe-0554-eb22-b1ce43d19e43", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "93a8edeb-fa34-5caa-0a30-bc9fa1256165", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "93b325a2-1a3a-ccd4-2dd4-1760da9e566b", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "94f13bbd-c7c5-6bd2-b7e9-52dc0966f576", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "960a4d6c-57ca-5d75-ec41-814efa474455", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "968f01c1-f329-f7b2-ab09-e3101785e985", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "96a355c4-e5cb-088f-316e-114cd303e69f", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "97ba9829-84cf-fe71-ae74-3c7b060094dc", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9890bc17-31b9-f162-f970-60b0775a6d12", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "98ad42af-7b62-d045-c029-acc7f8391178", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "98c79796-6474-5451-a8fd-fbdfeaab98d1", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "99485134-637f-7f92-aa87-ef09cc97060f", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "99970ce2-4a02-f1e9-0c8a-b2036566990b", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "99b56292-1db6-2eaa-1288-6ffe8ab9f867", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9a513f41-293e-f359-228b-0ae8a899031f", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9b120356-d713-52aa-6d15-0ab20a6dafa3", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9b129a34-ff85-acf3-f293-10326813c2a6", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9b97f7cb-2fd2-1b2b-7fb4-48549c9bce71", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9c805c50-f759-7741-630c-deb8cb68ba8d", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9ddfae2a-a9d0-ee5e-363c-9d1d546f35f9", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9df27dd2-5b2b-c22b-8bf9-2ffc7ae6beac", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9e16991a-6b3d-afa5-9b5f-4fa492f6968a", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9e8406ec-c5cf-c049-573a-e095a69d467d", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9f0735a9-35a8-4ab3-1ce6-30127c7ddf10", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9f61d871-99d9-56bb-6c0b-ac3e63961c62", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a058e8a5-6167-8fb2-40e8-7a78db40cb18", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a13ad1a5-bc2c-d63f-e354-a07fad74183a", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a16acd15-b2a1-6c4b-5863-94bbd012c634", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a1843163-d8ba-b59f-684a-014886bd3d61", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a25df2d0-0b45-9ba0-6124-d90473770072", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a2da7e4d-71fe-bc21-a388-bf057c332e9b", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a30142d9-69c8-572f-6e00-36337174568a", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a321cf46-28c1-494e-363b-768a8c0ea651", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a3ef0364-5887-0b4a-0e3f-a21f7831dab4", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a5903bd3-3b04-7e69-11b7-732fa860c788", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a63701af-c71f-0544-02bc-d0280dee25ed", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a84e00b6-e85b-0b23-352b-9aa3ffe7314e", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a98ab2f3-b600-aa92-df9d-36a8b29618ce", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "abd180fb-51b2-f036-0801-160bf90d7ff5", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ac33006a-f6a7-b30d-924b-b9599a119708", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ac3d6140-0409-55a7-b2ef-a8a48c6a005c", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ad0352cb-af71-03e2-f7df-fcfd332d43f6", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ad045d93-a868-e459-2cac-86d7eaee8cbc", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ad9b3882-b23f-7ecb-96cd-d373c961086c", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b035fcae-1e8a-9fa0-49c5-fc0683abb1da", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b068d9ed-052d-db39-42d5-f761fb91389d", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b0b518c2-a0f2-014f-aa51-bb87f5303bb2", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b2b61f8d-4efd-b3a1-11fa-c03b6cbe4c80", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b4a63901-0da1-eb7b-337c-6faec61f874e", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b4c4e99d-fb21-e705-082d-9fc412367c4c", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b4e13ede-e71c-c186-bc27-870c75e7fa67", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b60cb0e1-40c9-a5e7-1e80-652fc7e60428", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b65ea77f-0e71-5a29-e989-834ddd46ad27", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b7c1bf18-8580-7593-aef3-07ac58070309", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b963ef01-1013-65af-0dae-792235151046", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b979e399-3c5c-bc24-51fc-cbe7015b3815", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bac650fc-e433-b6c8-ea8c-5897aaca3ec4", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "baca9ff5-9366-45e4-601e-9abe5fc1a116", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bacd5124-36c2-d836-b1d9-1c102fb463e2", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bcbecc4c-c68d-698e-a66d-3dee53146775", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bcda868b-6398-0edf-ee1a-4e6e1f3c7ad9", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bd0003a7-71ef-64fa-f405-2a8bc1f818ac", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bd9d3143-409a-0f66-ed4b-777fb22d9eb9", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bdb036bd-e677-8f22-3e58-ea3960108397", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "be69de91-98fb-dc9b-1101-1a7fc424aed6", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bebf7f2d-d0c4-8f83-295d-815d8b032f00", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bfe31176-d336-318e-e3ed-ba48e2bc3165", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c04c2819-327c-b89b-c9e0-3873bad8caa5", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c16f9c29-49a4-27ea-0dde-3cb64d935374", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c2f5b7d2-8f15-ffc8-53c2-db0ce86adc84", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c37e09bd-181b-3d96-2267-136727f2138b", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c3baf7b7-0b10-9349-ce60-5e337c5f52b7", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c4ddd6d9-e547-8150-7cbb-a70c8a4ea647", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c4fda568-4149-5765-76ca-f7ab1369f72c", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c537988b-784d-2ea2-3809-35137ba3ebcc", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c57fc538-62be-d295-4d6c-9a96583b2e82", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c61b143a-76b8-b0ec-0e2a-08728ca06f99", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c7230259-ea86-ac19-75bb-b2dad1a7ed0d", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c993a9c2-00c0-6c35-a8a0-acbb8dbf8753", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ca196df1-2e76-e3c5-5b7f-909737937fd1", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ca332a52-83dc-966b-2342-2cfa7834704a", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cabd52b6-a9ac-25e0-f006-07b9930bd0c3", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cbf0a3b0-23aa-ebe1-ecb0-2f49a219687e", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cc1386d9-f61b-4f16-b7f2-95c233d40325", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cc801d7a-0b5d-c9ac-4abc-7f710fafc579", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ccb84504-009b-9e1f-6ce9-0be79bb9d7d6", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cda690cc-9d90-b01f-a225-e231fbaf2d75", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cf2227f8-70aa-e895-7365-f15ee87416bb", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cf9e4513-7a68-0fdc-c515-738bc7c05bcf", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cfa498cf-480e-686c-2f55-1e85a2647581", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cfead747-9003-9e9b-52bc-0b41c8573a39", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d023c16b-07bb-4858-64d8-83d703d81765", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d0be853e-e5c9-c00a-3210-24826d54c8c9", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d0c70ae1-f86f-a9bb-5fca-6dedd3a1f20e", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d10298e1-5278-47aa-0f71-0797c103d6bf", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d12b6441-c021-e685-c2a0-ccb6d18c6e2d", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d13345ea-8622-2baa-5ca1-e65ec6f6d3cc", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d1e482c5-5f57-881a-bc65-4b0554787a06", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d272319c-c4bc-7e55-a5fc-c1d865ce2883", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d313aa93-bceb-8611-cca6-98587fedb027", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d3d5330e-9305-c5d7-f15a-ad3e9222c64a", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d3e94f59-6971-3fd2-3883-5f737558e970", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d4a2b82e-ac81-a489-3fdc-7ec091f63120", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d5c40a0d-5c86-c041-1c69-6d7124c1e5bb", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d61166a8-3d8e-05da-a441-d02f25fc1b17", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d6e39a4e-8f99-c2c5-1822-c304edb960f3", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d70feb19-c076-1b92-3271-7948a4d2ec6d", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d7170eca-6fea-c607-d3ea-a156d892282c", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d754a532-6439-c81c-1483-071ac7753f6e", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d848e964-36fd-7e2c-6bac-bd62ea17d076", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "da05cec6-33ff-2f51-78eb-672bdce9eedc", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "db66eb60-ccdb-191c-0c31-b065ed6d0c07", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "db989267-e3f8-d20e-50ce-1a86a2cb57de", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "dc7bb52c-c8ea-4b9e-12e9-bcd0082fbbe7", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "dcb53a8b-1ca9-8890-1554-fb1f69795899", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "dd29a66e-0244-8e91-bb9e-5eb5b60dcc21", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "dd6279a3-ed2e-e099-78b8-e975ad79687f", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "de4b747f-2f87-b06d-520e-007961ddec2e", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "df6c40a6-74f6-3ac5-3ee4-300429a61e92", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "dfa69c92-c9b4-adf9-0115-99847777c0fb", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e0234452-8d42-ea87-6893-c8dad80a84fe", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e032d36e-64fb-e93b-27b9-37683c91d300", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e1eb12cb-0d6e-2027-4210-915e431f4ee1", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e204a5c3-39d1-cf4d-201a-17b13ca7a645", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e242a289-dfca-efbd-da76-61b5c7801269", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e299482e-7b44-d8ed-01cf-ae87285d8dc3", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e2c94de3-afd5-3f70-dc53-3a85d0ccf301", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e31bb2d7-2b9a-a6ab-f504-5733579b55ee", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e32ef38f-8b36-731f-a2cb-144fdf2caa9e", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e3943ee6-d742-976e-27d7-c25fd96be488", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e3991f32-1ba2-8da6-8bee-13eba7e85116", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e39b9f48-8efc-4076-6041-db0363d180d2", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e3d506b8-4836-4dd0-f312-e6111b78375e", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e4155591-818f-ccbc-dec2-1f13a4ceabcf", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e54f716f-5bec-79e2-3621-5d67e987b557", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e5768617-c1aa-9f58-6294-50c88eb76415", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e6784a9e-fd61-5183-b498-c10d934e8e00", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e7350ca5-30bb-8485-c1bb-068f4f9a3111", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e74c971d-569c-0886-9869-07377c0ca1fa", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e77dec89-6970-70ac-95b8-3cdc5e790b3e", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e8a6ddaa-c287-1fe4-b545-bdc2fd737e27", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e8c252de-2177-6e6b-6a96-97b24e5d5b7c", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e8c891d5-d3ea-f1f0-af84-4fc0ee0ed391", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e90f9ec7-abac-39a0-75db-8e26d17e1d23", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e99b900e-d9fa-606a-a428-aecaa24585f0", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ea2644a3-6940-66dd-8ade-abe2c55365e5", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "eadd632c-d2c1-e747-3094-e99e549421fd", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "eaf9ef0a-dee7-c3a3-cded-0b69ccd9aa15", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "eb4782fc-4751-f80c-b548-f550874f4182", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "eb74d386-f79e-d317-141b-26eb9f3fd90b", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "eb805281-c659-1c4c-ee27-bf6c913df877", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ebe2026d-144c-a338-087f-de57a76fa97a", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ecd70e45-0560-ea42-6c72-a4e6f64c7caf", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ed2ba61e-d0e4-5997-83cc-4f6ccef9664c", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ed5e554a-a46e-ff18-f963-08d2d533dbca", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ef0a6048-6175-f72e-7151-6650c8532708", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f1920d05-d079-d363-8deb-07fb5734a4e0", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f35c38af-d54c-f9c2-c3b9-033da24e2e2c", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f38bae86-3131-c1a3-e7b0-39abb9d9412f", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f48f8cdd-2f78-d1f4-8546-55e53fa147a2", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f4d5e080-3fed-8109-2129-d774ede4123d", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f5a17134-8d98-8c79-5e8e-df528cbecd83", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f6772830-b34b-1d5b-6633-820dd62c5c02", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f6f47760-6361-ee41-6255-b291ea4600b4", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f8ad4631-fdd2-506b-e471-e2041401daba", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f8be17a0-408e-e2dd-3c1b-6ffddb4185ff", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f8dbee0d-2cd0-4fd8-529b-debe83c64f4a", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f91c1c31-b7c4-3561-0d35-1774f56dd285", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fbd60b76-c388-94cc-b92c-1e1ce2ea0913", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fc47173b-f1b2-614e-82f0-eb2f0f4fe92a", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fc4a1a33-9953-a9f3-00ab-afd1b89dc2e8", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fe2ba999-5615-2c19-c9c9-60153195bce5", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ff082da8-0206-1639-740d-2f2fd480909b", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ff3ba2eb-2da3-6a8f-b57a-bd4ffdc5b987", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ff70c7a4-a0a4-25f7-828d-0f73d22d50c7", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0056b48e-646b-1783-e719-29ef81ea762a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0091cba3-5f4c-8290-7f29-69bbf9ac6c75");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "00c13648-2c99-5428-44db-05a0c0279cf0");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "015e0664-9e05-7ec5-026a-02358ea2fdcd");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0186b8c5-7384-82e7-630a-125e669795fa");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "01b7f46e-e743-7e80-acd8-a17d880f56d0");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "021ebba2-249f-412c-5eb1-3e0c4948ccea");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0240e089-b8a7-a02f-258a-a8b6c8d126fa");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0281ab1f-a5e4-530f-05d8-634d4674961c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "033c0d0e-6ebc-eac7-402d-0a65b07b5d05");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "03672eca-e781-12f4-2d9b-a8a0ef7371ea");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "03dd7c2d-0e63-63b4-fce6-4cef1114723f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0451df21-9439-2fdb-b358-3a18b53abeb0");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "04c21ebe-dd6c-b7a5-ccc0-34b07be385e1");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "04e7c487-4657-0550-418c-6ae0d96b0528");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0514db36-1e6b-9f75-e491-6d62278fe3d7");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "05ac8d14-9ecc-b065-64c4-5df33f73ff93");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "05f45355-dcb4-bfc1-eca2-89610fcef0d9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "06324105-c510-7ccb-8f94-e4870ce2e627");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "06b02a80-c9d1-d88f-01d0-4b332bf3aec8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0849ab21-5c47-8cf8-670d-35a386c99293");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0a08ff61-3964-d9ce-66f6-95b9fed4b85c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0a1e6c34-263b-19da-8f16-af1a8c36f35f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0aa26dd6-fa27-a71e-c93f-521ffc61e5cc");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0ae9f823-f08b-d78f-4df6-cc81679f3637");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0b4864d5-d4da-199e-5176-98bbfc05e7de");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0b4c6aff-e816-b058-5365-42db3f1e5d8c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0b8454a7-0a16-cf00-e450-67acb872b63f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0bf8e9e5-9b13-98d5-464c-f806a63e32c0");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0ca0abe1-8f3e-0b41-55c1-ef443bb6ea4b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0cd8d9f3-0c28-666d-7b5b-fddb4b07baac");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0eac91c7-8342-c0e4-8486-23bc65f11a5c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0f759511-6d88-16ab-f5c3-5393413b7374");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1058d1f9-1cc3-2808-aac4-059b31118f9d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "11ad3e3e-3e22-3940-c40f-12d0aa828da7");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "11b3e597-791a-0186-c8a9-b9ebcf03c46c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "12b42ac9-b980-4a40-07fb-1ac7850b48f6");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "12f0485e-7175-e7c7-5f34-9a5d287363f0");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "133278cc-7933-0286-e390-0fc4a7c1b142");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1602657d-7ad0-127e-ede9-53f5a9462a02");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1627b02a-1985-4026-7d79-48231e25e736");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1734038d-4527-75b4-b567-6e3cb8c2e754");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "185d79a9-7e4e-9529-350a-3da955eab609");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "192a3e79-1737-a728-a963-36f925baffcf");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "19e792a4-0483-3555-0a1c-a0ed0a1576e7");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b168d80-ed4d-134e-39e9-71249e4c0507");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b7bfd56-148f-400b-b749-42d9a7795b40");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b7c5fa9-a3ac-def6-7c3d-dae37cafb16e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1bbd08c7-9fdf-8b99-83f0-194d30ecf035");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1d62de39-a195-1f19-531c-586e0b001796");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1d91292c-0920-91d0-bed7-087e0898e6af");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1dc1cb0f-8b56-5156-3c9b-7bd80fd6d19a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1e482bc0-cb16-87ea-b49f-ecd316a2c08a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1edb9a35-2dd8-fd90-c524-ef01391f97e7");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1efc29fc-be39-f8af-e74b-60bc554c6e07");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1f25b7fb-08b8-61ca-e752-399c77c7ef18");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1fa7e581-d14d-f584-b7b7-3157b90f044b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "20fd11f1-9d76-af81-a983-e277b5065596");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2113fb7b-0c39-c75f-80cb-24ac87012268");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "22d299bb-59f1-1abb-bec3-812a9dd3b5e3");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2300fc1f-af6d-738a-1ea2-84f7a0e8f992");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "24890c6c-e90d-38be-651f-3943a6f6ea0d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "24b867d5-8da5-1e4c-cda6-1c1d3c7bca96");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "24bdb534-9db2-56c1-541a-98c6628ffac1");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "250a707d-9a6a-fb4b-293a-0b493f02d48e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "251f287b-bbd1-1cf0-1088-dd9fc8d6a950");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "253f5749-818b-1a88-32e9-5dc0104fc2aa");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "257769b4-8b4d-7462-3b1a-e97b8b18d1bd");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "258ce124-a53c-53ce-891c-1ea6db4607ea");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2652da8c-eb61-912d-6466-fa10b62e3520");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "282ef117-7b5e-4151-2e5a-b04fbec08021");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "28bdcd73-2251-4ca3-10c7-95e04d2dc193");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "28fa2e04-d2a3-c9c2-2765-58ceff54c266");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "29713359-c512-2642-bd35-8fdc7b713a86");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "29e9000b-929f-6ed2-4da4-08a48438c572");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "29f81d4f-f254-3c81-0800-484fff4f95db");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2addb7b3-2b07-8a74-2cc4-54477360f8cf");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2b9a99ca-97e3-ab45-6adc-18c0401e2271");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2c254944-38d1-2bed-b104-4a98c3c374f9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2c25f4cc-1a17-b424-e587-50429d74e7ee");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2c2a7076-d2a1-aab8-c0cc-c2e4987052e7");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2cbd2815-0d3b-af8c-cee2-c3fe4475aa8b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2d258078-d362-5598-81b6-d303b58aa17c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2ebe1d68-df32-c1ba-0f2b-518e7fa0cdc6");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2f27bf5f-9f51-0f83-2802-e450bcfe54d8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "30aab798-8663-49b3-924d-2228a5d800fa");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "30c224f9-a838-d4a4-510e-c5c9bc0629e8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "31070994-cc4e-a988-3590-882ca0efb529");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "32f442d5-d876-73a9-8df5-64e07a5d3f2d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "334bea02-aa9c-4cd0-cf37-b1cea75708b3");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "33e58c5f-41bb-41c0-7ec9-0b6268a5e750");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "34fa4ca6-fd2b-01bc-14d2-1fe35a8cfda5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "35e6a580-20ea-f11f-d809-147bf282fdb2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "364f949f-4f8d-abfe-a012-8dde7f6274a9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3651bd6e-248c-618f-a526-7fb73d1baf2f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "37193eae-9c03-29b6-840b-0c9ab3caf2ed");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "377cb800-1c31-487e-f813-a69cf52eee2d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "37f609e0-2c09-aad4-b8a2-d2a600514b39");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "381194f6-13d1-0784-ef42-2252bb8c2de6");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "38c44239-042b-9f47-b126-8bac5a935de4");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3a75ece9-d6bd-8369-eb49-e0dd587b83c8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3b276f2e-e4dd-6f2e-f7c2-dafc41842740");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3ba81963-cccd-65f9-73df-02219e2c2e7e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3d349848-9686-f1c8-de8a-688906a214cc");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3e9a3d32-6316-244b-56e7-1b6bcec630bf");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3f9efddf-d4ac-b783-4fd2-ef586805836c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4058b0fa-48be-4e17-2576-c4135c300b34");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "408a61ae-4b6b-0076-67ce-a465b6fa9dca");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "41a5c5f3-39a7-fd50-55f1-15a5ffdab6af");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "42468a5a-4a16-eb8e-de47-265fc96a4ca9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "437a2f46-83e6-12b5-d427-e9cfefbec976");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "43835ede-7675-be2c-7c3b-1b062538fa9f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "441a291d-b318-85bb-ad24-07c5c11f5062");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4455a522-1f44-6544-eed9-9335814735f6");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4465707f-e953-9211-c9e5-fa31eccb30bc");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "446d9588-beb3-632b-0e25-e1b5b4f33776");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "447fd5eb-36b6-2ad8-db74-b20bddf788a5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "44f6ff10-d9ea-89f1-6e59-8804e41a182b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "45380ea6-04b6-5c4f-748f-26a430eb604b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "46c17505-618a-4ab0-6173-304a63b6b627");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "47702301-4262-c698-1569-cce48dec8d1a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "481e422a-50e8-4125-184a-14a073fb947a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "49282f5e-88a1-e68a-cf2b-b70e99cc24d6");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "49df7fc7-082a-69a1-0440-377f6e1fde69");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4a4c2da0-0133-601d-1522-921ce26123d3");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4acb04ae-4f32-0992-3ffd-50b16241ba97");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4ae299ae-0f82-b71d-0262-22bb2a532176");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4b7c860f-0fc0-abf5-476f-3a45fa180ca8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4c877cbd-bfb5-2f1b-f281-36f0c8137a99");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4ce01da5-4f9f-5257-b982-7c7a6e70e1d4");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4d6b8d40-5855-e522-368d-ad628b0372ea");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4e9d38e8-b380-471f-bc75-979ad0cdd4e8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4eef927f-1d7e-5446-0f24-488523a20b01");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4f11ef9b-0cf2-26dd-fe1b-1d4d63075c9f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4f215f44-2da6-46e2-e33c-59f53c74c0ff");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5015b809-1fa9-1fa5-650a-2a405fd64085");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "50d9044e-0086-d1f3-254f-77152cd854e8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5175db0f-8378-8d13-46b3-8edb798ee7df");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "51ca6d70-ecb7-c756-e98f-11e9e46eb1bd");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "51e907e9-b001-29c7-1d2f-82526931ca1b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "52310af2-ece3-cd10-f89c-46732e228f89");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5294bdc8-57c8-442a-5a7e-5b06f82ac5e8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "52a673d4-2604-d117-fa31-59e6b1583b05");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "52d5138e-d17c-a425-ef8f-47d0d46c0a79");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "545669bc-406f-75a2-c5e8-1eb4a6a7bffb");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "546331da-fcbb-455f-1cfe-ecbd95845602");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "54daaa31-3130-ffc0-c011-b8d202aa19d6");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "555c4f01-12f9-5870-2fc2-954b990f9ea9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5561b254-a62b-e8eb-bc3e-43d0d935ab76");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "557a5d2d-2c5b-63cd-ed1d-69a53390882b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "55a67536-efb2-9b26-ab0a-968135ce47c4");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "562094e8-3ad2-2a03-0579-fc1418b5f659");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "563098bf-4f57-55cd-5db5-817ecd76d316");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "56ff463d-10f6-6e00-3a7d-c4aea77e299b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5702f7da-be71-c268-696f-98d52e88ea53");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "582a1dd6-8a44-76b0-8c01-7261083f0172");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "586c1df1-b67d-a268-6dd0-09b96b2c644f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "58858d76-14c3-cbe5-adc4-8791825c778e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "597e10ad-aa92-7822-1987-a88d6cf5852f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "59922d63-7e84-a47d-e7e2-ca0253d54ace");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "59c8349a-3b56-1684-bcfc-15b8ba173f15");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5d1d4bd0-53eb-e05b-237f-6514f5b79081");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5d96512f-a43c-9fdc-5c4e-f83ca7b76102");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5e65d782-df6f-14a7-c210-3213fc284e29");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5e86ab2d-34b7-1cb2-ef43-ec920c0a70e6");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5fb45997-dbe8-5a6d-46db-ea5654a68a27");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "602d6044-d51b-bbd6-a54c-1a345e89937d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "60544a1d-7058-eae3-3dde-a79b6b8ef9c3");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "60d3c38c-09a5-dce6-6101-41ecbce1bf03");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "613bcf8b-9d1e-e78d-17d2-53422ab92602");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "61f6ef7f-4330-e352-da28-4895756a5251");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "61ff370e-6c73-3674-a907-9007cd4b33a9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "622a60bd-1788-2e1b-a6a0-c8f4e1d1e219");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "62512fb2-d619-81c7-3311-1b118818d52b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6255702d-a7b2-bb95-f10a-49b274da6d53");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "62ac54af-88e9-dfa2-813c-7794254d1335");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "638a4120-4be1-950a-fec5-94663410af82");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "63e4081b-ce44-4976-db5f-bb0600bcf7af");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "64e321fd-02c0-e40f-12b4-d66aea725403");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "652b1fdb-8e05-5f20-7458-639066ce3139");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "65472971-26a2-f130-16b1-1c92bbd22ed0");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "66d7cc94-016c-2ade-9bd5-b80af34bf830");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "66e64f1a-bcdb-e90d-4b74-760046e2450b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "67bce44d-530c-659e-c998-e149a26d5125");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "67c0607e-1a86-5adc-1cbb-1b67ebd4f5c7");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "68b1f719-fd66-8ebb-ac71-4ff3607a297d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "68d03176-7999-d56b-1502-f5cbb0c3611e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6961bdc3-425e-2f60-be51-9f75ba501dcd");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6979eeb6-1623-28d8-2c4b-aa9c9ca3dd61");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "69d170b3-caea-dcc2-2098-39eba8d87e7d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6a0168cc-dc00-e5b9-3d51-e63ac454ab2d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6a693347-e820-3da0-51aa-7f83809be309");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6a8902b7-62fa-3c0b-741d-c65a94b9bc40");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6a9c2aba-178c-4935-0602-b587d85cce25");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6b79c9c7-2703-0c83-47a0-7b93b92595f5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6cb8f5f6-9138-6744-da11-698ada9c7cd9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6d0a9a86-a0c2-ab66-6cf4-0b82f34cbcaa");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6da289df-b92c-187f-6dd9-988eca909576");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6dea7d94-a09f-56f2-f31e-0cd3aac5ab06");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6e86371a-fdc1-a36b-ebb9-ccdbc764ed53");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6ede21c7-5e01-847d-90d3-85a92e3b87bd");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6efe6515-de20-2195-a929-b8f79fb59e3e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6f3e4dee-356c-1e4f-91ea-c4aacd751af4");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6f877b46-e63b-1f94-279a-86e19b4c5761");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6fe7c898-a901-a39c-6bb0-d06bd0d6e5fb");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "71703b6c-1f4e-53ec-e9e6-2e0174689404");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "72a3c917-dfaf-9ddd-88fb-94f9ca743271");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "74f4e56c-46d0-b7b4-aa59-11386a4ea5fd");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7527c779-5120-f31d-474d-61aff31bc8c2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7636a876-a0ef-b958-5ccb-fa1744245061");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "76570e22-cf14-6006-bcb5-b33b40821d16");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "769cb487-c2b4-dfe2-c6b9-0fba223fefd2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "76a47667-00d8-1aed-4659-1935af3c9c95");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "76a72df6-2cda-3c30-6f4c-66d8d7517f4e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "76b957f7-e3c2-291b-7522-effc736f5b46");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7710775c-5b25-a750-18d6-63956d2fccf7");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "77245690-2f64-8b48-384f-600788950792");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "780954cc-cb71-98e4-921a-36493c1213ab");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "782ae39e-a5d2-9cc4-3fc7-5d64bc387293");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "78750878-ef0d-057e-c510-51e22b56ee0e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "78a0fa33-dc9f-e211-b484-baafb65a9751");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7952bd2c-9bf5-fc7a-018f-c55e5ea6a639");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "799fd89b-42c7-3ef3-6c3c-ffcedbff6861");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "79e45e6d-96cb-5c40-a6c3-e18a6d44b454");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7bfcaba8-0d96-44e7-df91-80bd72afaa1f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7c62f011-6077-ed38-5ea4-4bb85363ccb5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7c84033b-5176-ff52-bf0c-2d96a280808f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7cfc755e-5b32-8d59-789c-bc4dd2100d61");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7d62fd98-d42d-cfa9-2959-3cb49a0b2ffc");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7edc844d-8fdd-7aff-15d9-a2a0bbc13b82");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7f2243f4-ac3d-acde-849b-c8a89c2180af");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7f3bd210-62cd-bc91-18e1-e0eb300567f2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "80517491-33d5-45f6-4b9f-2a73dabbfac0");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "81c2420f-339f-14dc-75dd-01c9688542bd");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "820cc779-f49f-5bdc-d9b1-8e1b5faa0477");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "82714fa8-f934-7af7-a9f2-8296dcd9a0c2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "83b0393a-1b75-fa6f-7f72-02d12d0fe1f7");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "83d8c26f-491d-fe4e-5fbb-6befa442c4b6");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "84791388-7f45-2463-c3cb-b60e2beecb42");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "84b4ae16-7e63-9425-edc3-2828257f19b9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "853fd355-afab-e34e-3932-5edd59a14471");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "879a6a99-bb2c-37a9-766e-a310fe50294f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "879c6462-be54-6a55-3f7a-c71691eff10a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "883954fa-8710-fa17-ac5e-9019be27c7b3");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "887f71d1-a887-b99e-f276-dff6af9c5d76");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8896c2af-a850-2d70-92b7-e36a6630c282");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "88a9d605-45a4-7dba-3085-4963782e8da1");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "88bc1f89-0749-56c2-c09d-df1d426ffc30");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "88bf75c3-eafe-f500-22e1-80e974eaf9a9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "890fff94-7866-0993-b421-ee7b72322af7");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "898a34e4-9b61-d1d5-b386-750cddb45093");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "89a8a3a0-f0b5-f882-cbed-62c800a42b67");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8b24abf0-7d82-945d-9f59-df957b49026b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8bfd4e11-7816-f525-8723-b142709b59a3");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8cfb7ff3-442d-26df-1431-da48ab37532e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8dcf77d5-4bb8-4a37-c156-8378722486e6");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8f4a50b6-d908-a23e-8f91-11ecfaf85f8d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8f5034bb-2a44-e79e-6077-937b9e2eb778");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8ff39507-c5d8-26cc-69a3-7e0737654adf");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "900080d8-70d4-55f9-da68-9b515a38d066");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9084f470-325c-483b-f43a-ba4c72ee85e5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "916d390a-b5f8-a47e-c047-99ce0772f358");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "926050e2-d137-dd61-ef03-70f839196de2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9282ce07-8b76-3331-139a-3bd67c69f78d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "93236a10-6062-4627-9669-e68c7a9a512a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "932db80b-bbbe-0554-eb22-b1ce43d19e43");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "93a8edeb-fa34-5caa-0a30-bc9fa1256165");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "93b325a2-1a3a-ccd4-2dd4-1760da9e566b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "94f13bbd-c7c5-6bd2-b7e9-52dc0966f576");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "960a4d6c-57ca-5d75-ec41-814efa474455");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "968f01c1-f329-f7b2-ab09-e3101785e985");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "96a355c4-e5cb-088f-316e-114cd303e69f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "97ba9829-84cf-fe71-ae74-3c7b060094dc");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9890bc17-31b9-f162-f970-60b0775a6d12");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "98ad42af-7b62-d045-c029-acc7f8391178");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "98c79796-6474-5451-a8fd-fbdfeaab98d1");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "99485134-637f-7f92-aa87-ef09cc97060f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "99970ce2-4a02-f1e9-0c8a-b2036566990b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "99b56292-1db6-2eaa-1288-6ffe8ab9f867");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9a513f41-293e-f359-228b-0ae8a899031f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9b120356-d713-52aa-6d15-0ab20a6dafa3");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9b129a34-ff85-acf3-f293-10326813c2a6");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9b97f7cb-2fd2-1b2b-7fb4-48549c9bce71");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9c805c50-f759-7741-630c-deb8cb68ba8d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9ddfae2a-a9d0-ee5e-363c-9d1d546f35f9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9df27dd2-5b2b-c22b-8bf9-2ffc7ae6beac");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9e16991a-6b3d-afa5-9b5f-4fa492f6968a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9e8406ec-c5cf-c049-573a-e095a69d467d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9f0735a9-35a8-4ab3-1ce6-30127c7ddf10");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9f61d871-99d9-56bb-6c0b-ac3e63961c62");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a058e8a5-6167-8fb2-40e8-7a78db40cb18");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a13ad1a5-bc2c-d63f-e354-a07fad74183a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a16acd15-b2a1-6c4b-5863-94bbd012c634");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a1843163-d8ba-b59f-684a-014886bd3d61");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a25df2d0-0b45-9ba0-6124-d90473770072");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a2da7e4d-71fe-bc21-a388-bf057c332e9b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a30142d9-69c8-572f-6e00-36337174568a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a321cf46-28c1-494e-363b-768a8c0ea651");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a3ef0364-5887-0b4a-0e3f-a21f7831dab4");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a5903bd3-3b04-7e69-11b7-732fa860c788");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a63701af-c71f-0544-02bc-d0280dee25ed");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a84e00b6-e85b-0b23-352b-9aa3ffe7314e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a98ab2f3-b600-aa92-df9d-36a8b29618ce");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "abd180fb-51b2-f036-0801-160bf90d7ff5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ac33006a-f6a7-b30d-924b-b9599a119708");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ac3d6140-0409-55a7-b2ef-a8a48c6a005c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ad0352cb-af71-03e2-f7df-fcfd332d43f6");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ad045d93-a868-e459-2cac-86d7eaee8cbc");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ad9b3882-b23f-7ecb-96cd-d373c961086c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b035fcae-1e8a-9fa0-49c5-fc0683abb1da");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b068d9ed-052d-db39-42d5-f761fb91389d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b0b518c2-a0f2-014f-aa51-bb87f5303bb2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b2b61f8d-4efd-b3a1-11fa-c03b6cbe4c80");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b4a63901-0da1-eb7b-337c-6faec61f874e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b4c4e99d-fb21-e705-082d-9fc412367c4c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b4e13ede-e71c-c186-bc27-870c75e7fa67");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b60cb0e1-40c9-a5e7-1e80-652fc7e60428");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b65ea77f-0e71-5a29-e989-834ddd46ad27");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b7c1bf18-8580-7593-aef3-07ac58070309");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b963ef01-1013-65af-0dae-792235151046");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b979e399-3c5c-bc24-51fc-cbe7015b3815");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bac650fc-e433-b6c8-ea8c-5897aaca3ec4");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "baca9ff5-9366-45e4-601e-9abe5fc1a116");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bacd5124-36c2-d836-b1d9-1c102fb463e2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bcbecc4c-c68d-698e-a66d-3dee53146775");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bcda868b-6398-0edf-ee1a-4e6e1f3c7ad9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd0003a7-71ef-64fa-f405-2a8bc1f818ac");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd9d3143-409a-0f66-ed4b-777fb22d9eb9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bdb036bd-e677-8f22-3e58-ea3960108397");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "be69de91-98fb-dc9b-1101-1a7fc424aed6");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bebf7f2d-d0c4-8f83-295d-815d8b032f00");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bfe31176-d336-318e-e3ed-ba48e2bc3165");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c04c2819-327c-b89b-c9e0-3873bad8caa5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c16f9c29-49a4-27ea-0dde-3cb64d935374");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c2f5b7d2-8f15-ffc8-53c2-db0ce86adc84");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c37e09bd-181b-3d96-2267-136727f2138b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c3baf7b7-0b10-9349-ce60-5e337c5f52b7");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c4ddd6d9-e547-8150-7cbb-a70c8a4ea647");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c4fda568-4149-5765-76ca-f7ab1369f72c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c537988b-784d-2ea2-3809-35137ba3ebcc");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c57fc538-62be-d295-4d6c-9a96583b2e82");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c61b143a-76b8-b0ec-0e2a-08728ca06f99");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c7230259-ea86-ac19-75bb-b2dad1a7ed0d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c993a9c2-00c0-6c35-a8a0-acbb8dbf8753");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ca196df1-2e76-e3c5-5b7f-909737937fd1");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ca332a52-83dc-966b-2342-2cfa7834704a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cabd52b6-a9ac-25e0-f006-07b9930bd0c3");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cbf0a3b0-23aa-ebe1-ecb0-2f49a219687e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cc1386d9-f61b-4f16-b7f2-95c233d40325");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cc801d7a-0b5d-c9ac-4abc-7f710fafc579");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ccb84504-009b-9e1f-6ce9-0be79bb9d7d6");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cda690cc-9d90-b01f-a225-e231fbaf2d75");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cf2227f8-70aa-e895-7365-f15ee87416bb");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cf9e4513-7a68-0fdc-c515-738bc7c05bcf");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cfa498cf-480e-686c-2f55-1e85a2647581");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cfead747-9003-9e9b-52bc-0b41c8573a39");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d023c16b-07bb-4858-64d8-83d703d81765");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d0be853e-e5c9-c00a-3210-24826d54c8c9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d0c70ae1-f86f-a9bb-5fca-6dedd3a1f20e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d10298e1-5278-47aa-0f71-0797c103d6bf");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d12b6441-c021-e685-c2a0-ccb6d18c6e2d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d13345ea-8622-2baa-5ca1-e65ec6f6d3cc");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d1e482c5-5f57-881a-bc65-4b0554787a06");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d272319c-c4bc-7e55-a5fc-c1d865ce2883");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d313aa93-bceb-8611-cca6-98587fedb027");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d3d5330e-9305-c5d7-f15a-ad3e9222c64a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d3e94f59-6971-3fd2-3883-5f737558e970");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d4a2b82e-ac81-a489-3fdc-7ec091f63120");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d5c40a0d-5c86-c041-1c69-6d7124c1e5bb");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d61166a8-3d8e-05da-a441-d02f25fc1b17");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d6e39a4e-8f99-c2c5-1822-c304edb960f3");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d70feb19-c076-1b92-3271-7948a4d2ec6d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d7170eca-6fea-c607-d3ea-a156d892282c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d754a532-6439-c81c-1483-071ac7753f6e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d848e964-36fd-7e2c-6bac-bd62ea17d076");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "da05cec6-33ff-2f51-78eb-672bdce9eedc");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "db66eb60-ccdb-191c-0c31-b065ed6d0c07");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "db989267-e3f8-d20e-50ce-1a86a2cb57de");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dc7bb52c-c8ea-4b9e-12e9-bcd0082fbbe7");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dcb53a8b-1ca9-8890-1554-fb1f69795899");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dd29a66e-0244-8e91-bb9e-5eb5b60dcc21");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dd6279a3-ed2e-e099-78b8-e975ad79687f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "de4b747f-2f87-b06d-520e-007961ddec2e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "df6c40a6-74f6-3ac5-3ee4-300429a61e92");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dfa69c92-c9b4-adf9-0115-99847777c0fb");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e0234452-8d42-ea87-6893-c8dad80a84fe");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e032d36e-64fb-e93b-27b9-37683c91d300");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e1eb12cb-0d6e-2027-4210-915e431f4ee1");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e204a5c3-39d1-cf4d-201a-17b13ca7a645");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e242a289-dfca-efbd-da76-61b5c7801269");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e299482e-7b44-d8ed-01cf-ae87285d8dc3");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e2c94de3-afd5-3f70-dc53-3a85d0ccf301");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e31bb2d7-2b9a-a6ab-f504-5733579b55ee");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e32ef38f-8b36-731f-a2cb-144fdf2caa9e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e3943ee6-d742-976e-27d7-c25fd96be488");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e3991f32-1ba2-8da6-8bee-13eba7e85116");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e39b9f48-8efc-4076-6041-db0363d180d2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e3d506b8-4836-4dd0-f312-e6111b78375e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e4155591-818f-ccbc-dec2-1f13a4ceabcf");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e54f716f-5bec-79e2-3621-5d67e987b557");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e5768617-c1aa-9f58-6294-50c88eb76415");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e6784a9e-fd61-5183-b498-c10d934e8e00");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e7350ca5-30bb-8485-c1bb-068f4f9a3111");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e74c971d-569c-0886-9869-07377c0ca1fa");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e77dec89-6970-70ac-95b8-3cdc5e790b3e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e8a6ddaa-c287-1fe4-b545-bdc2fd737e27");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e8c252de-2177-6e6b-6a96-97b24e5d5b7c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e8c891d5-d3ea-f1f0-af84-4fc0ee0ed391");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e90f9ec7-abac-39a0-75db-8e26d17e1d23");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e99b900e-d9fa-606a-a428-aecaa24585f0");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ea2644a3-6940-66dd-8ade-abe2c55365e5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eadd632c-d2c1-e747-3094-e99e549421fd");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eaf9ef0a-dee7-c3a3-cded-0b69ccd9aa15");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eb4782fc-4751-f80c-b548-f550874f4182");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eb74d386-f79e-d317-141b-26eb9f3fd90b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eb805281-c659-1c4c-ee27-bf6c913df877");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ebe2026d-144c-a338-087f-de57a76fa97a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ecd70e45-0560-ea42-6c72-a4e6f64c7caf");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ed2ba61e-d0e4-5997-83cc-4f6ccef9664c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ed5e554a-a46e-ff18-f963-08d2d533dbca");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ef0a6048-6175-f72e-7151-6650c8532708");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f1920d05-d079-d363-8deb-07fb5734a4e0");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f35c38af-d54c-f9c2-c3b9-033da24e2e2c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f38bae86-3131-c1a3-e7b0-39abb9d9412f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f48f8cdd-2f78-d1f4-8546-55e53fa147a2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f4d5e080-3fed-8109-2129-d774ede4123d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f5a17134-8d98-8c79-5e8e-df528cbecd83");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f6772830-b34b-1d5b-6633-820dd62c5c02");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f6f47760-6361-ee41-6255-b291ea4600b4");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f8ad4631-fdd2-506b-e471-e2041401daba");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f8be17a0-408e-e2dd-3c1b-6ffddb4185ff");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f8dbee0d-2cd0-4fd8-529b-debe83c64f4a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f91c1c31-b7c4-3561-0d35-1774f56dd285");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fbd60b76-c388-94cc-b92c-1e1ce2ea0913");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fc47173b-f1b2-614e-82f0-eb2f0f4fe92a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fc4a1a33-9953-a9f3-00ab-afd1b89dc2e8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fe2ba999-5615-2c19-c9c9-60153195bce5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ff082da8-0206-1639-740d-2f2fd480909b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ff3ba2eb-2da3-6a8f-b57a-bd4ffdc5b987");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ff70c7a4-a0a4-25f7-828d-0f73d22d50c7");

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "083b85af-c2e8-d7eb-0cca-13cbad93f7df");

            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "session_id", "course_id", "date", "Description", "end_time", "mode", "room_id", "session_status_id", "session_type_id", "start_time" },
                values: new object[,]
                {
                    { "3701bc4e-401e-f4f3-00aa-b37659789636", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 0, 0, 0) },
                    { "54166d2e-0d4d-7e23-3a55-ecde2614bcfa", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 0, 0, 0) },
                    { "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 0, 0, 0) },
                    { "885f671e-9801-9aec-86eb-3fe1cb1db365", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 12, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 0, 0, 0) },
                    { "a5129120-7dfa-797c-3e24-99056723ec39", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 0, 0, 0) },
                    { "e823715d-0a77-1379-9289-b44b55c10267", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 12, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 0, 0, 0) }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 44, 35, DateTimeKind.Utc).AddTicks(1168), "$2b$12$zj5E/56AA0Tv4.sx5I3y7.9v6iBcoDABpr382etNNdSH6znFc83hK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 48, 684, DateTimeKind.Utc).AddTicks(1326), "$2b$12$a4iAh.mDY/lJ/EaYfsTX6uhqubfFHOL0dZOTv7hJYpAVh0BRKx7H6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 39, 690, DateTimeKind.Utc).AddTicks(4026), "$2b$12$WhGcLIqfldLyVRTKm0.6euP5.vsqSuEjQUnUkQso0.asvaMOr.yba" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 51, 842, DateTimeKind.Utc).AddTicks(5156), "$2b$12$ujvJHhcW0g3.olfj9mH/WudnY/4teu3SIW8mThDC9F5bhb8sXggqe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 55, 187, DateTimeKind.Utc).AddTicks(7826), "$2b$12$eZNbzeh6a9BePFD/Lf1Xt.QEKTz79Xt.bVPL90RYLWHlpowgg35SO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 41, 224, DateTimeKind.Utc).AddTicks(4821), "$2b$12$326/2OHOmFKq8zEqMX2S2OKbnuQwUp11mkatopULYKd1CainsSvVG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 47, 382, DateTimeKind.Utc).AddTicks(2681), "$2b$12$1aFMzrgfLlvfVP8aVfaf6O95ebLzDmXsJqNluKS4asWOpKiqLEJd6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 42, 145, DateTimeKind.Utc).AddTicks(3429), "$2b$12$P/Xogx1VUO96dOarJMBAq.wAm27sey6bLXq385rbSL36QKrjxU40C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 42, 751, DateTimeKind.Utc).AddTicks(4527), "$2b$12$yKG4sEDk9bz1VP6WoKeHS.V3XfR9pGBtbeQLJItwuEMSlGO4rQVwW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 54, 272, DateTimeKind.Utc).AddTicks(6461), "$2b$12$E1BQrkY0P9ljkHxWflu6jOQNGX17Vs6xAuaxbUV8wh1pfSw.o9Xqy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 38, 710, DateTimeKind.Utc).AddTicks(8299), "$2b$12$GITLf9uhPHE0kJ/MTTfA1ugO7e/EJ446zHXOcInNcSghhqL7/JHXy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 47, 40, DateTimeKind.Utc).AddTicks(1478), "$2b$12$BaO5rrrL4DuG4k44L79kPOCUJot7Cn8zcAThQJ7dbIzZrm9/biXEG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 40, 302, DateTimeKind.Utc).AddTicks(2676), "$2b$12$lvV3MIEVFLatdREDaa2g4.yOyVWLeI0ws6pHXY93L.N3EM8GIVayC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 39, 996, DateTimeKind.Utc).AddTicks(2739), "$2b$12$ZPzhutqF/k528UedQw5Atel3hqrynyTXHXIx7PaAvUFcQ98SB7Q/." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 43, 358, DateTimeKind.Utc).AddTicks(8115), "$2b$12$BhfRMn6S9KwTcK9qi3uJ0eDvQZv7wXoxgFhzjUgTlrd3r5kXlWDEy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 40, 609, DateTimeKind.Utc).AddTicks(8998), "$2b$12$nfBD3jxRsl0e7wM9O.DK2.hrXkWOUTMRRFi1Sjyj.74BsaGrLApwO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 45, 25, DateTimeKind.Utc).AddTicks(5227), "$2b$12$a7peq1POQxZ32Dh1mLSir.HNhXeLPNEmZFfTpisbOUkKT2T2zTCwW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 41, 834, DateTimeKind.Utc).AddTicks(6729), "$2b$12$DnFfxtB5gm6RGY.oSCaxe.yVGvBM4AXKs/3iX7How51plw4b6qGiW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 48, 372, DateTimeKind.Utc).AddTicks(5776), "$2b$12$2EAu36TiAOZWmNpnA55j5egmXGv1e8vYDCKXfOcu6Mp3T9IPmivMS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 53, 61, DateTimeKind.Utc).AddTicks(4535), "$2b$12$UTKNaNEu9LPi2cMQpN71kOLIV1tdK1go/bILCJL6qNgjUB4pFAmcK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 54, 879, DateTimeKind.Utc).AddTicks(6264), "$2b$12$0sc4sOQ9WmFjWbhddT76GOGrYz2V9PPlwtKTRtRBGnV3d7VNieadC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 45, 332, DateTimeKind.Utc).AddTicks(65), "$2b$12$zr8siEvEjRK5GrhVIDnwR.0hPOVVj6T7TjBSTPRiCaOtB6aTE0CGi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 53, 969, DateTimeKind.Utc).AddTicks(5309), "$2b$12$MQ8OPF2cLWEH0C7q1jrVw.Dci99H01KLaHeCGR9CIj6ApZLpxCavu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 50, 609, DateTimeKind.Utc).AddTicks(5058), "$2b$12$jNSgZbv2RWMsrmxBm.z8B.anxNqrzeG2/MQRHSwSpqnm8I52JVom2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 51, 231, DateTimeKind.Utc).AddTicks(5630), "$2b$12$cPLG4n7K1BQzqU9keFt18OUpSUjUMvZ3erCBy4OnnPEt5ukDprHm2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 50, 923, DateTimeKind.Utc).AddTicks(3587), "$2b$12$7cfU3XamZWMewD2J8ock2uloc5M69StTXH7i3cfvBc0ynJa0qNKEq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 49, 686, DateTimeKind.Utc).AddTicks(2456), "$2b$12$QcRkklY2YAupzjEyMyRrfug8Y5.TTDgPEES3Aqa28.pGU4junJd/G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 53, 364, DateTimeKind.Utc).AddTicks(6811), "$2b$12$gSDJBi/Oef5TtZtpwacYlevVrvLK295zxNmDqi68rvsBo4wq.EEB2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 49, 991, DateTimeKind.Utc).AddTicks(2774), "$2b$12$Sb1OBDkntvmJ2nxrSkseGuZ3Z6ZSNpmKivi9KvArp6wolCgc6wWQ." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 52, 145, DateTimeKind.Utc).AddTicks(9848), "$2b$12$71z8.EmVPfLMSyLFIkQVDeHTysLpIDTmLvt9oTTHxr5oh/r5fb6Re" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 53, 666, DateTimeKind.Utc).AddTicks(7855), "$2b$12$Rfvj7pkf0OFHrd0FmqMbO.LvSP8mmg78Cn2sXl92WVntYCGBFVN0a" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 48, 28, DateTimeKind.Utc).AddTicks(3487), "$2b$12$MZyaTYmj8vRHtrNbdH4NL.j96M5jT5Q72k5tRPCQihOpErsR28QjG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 39, 46, DateTimeKind.Utc).AddTicks(7915), "$2b$12$oSnMGvHUVdu2nbKaX.1ODedG0oJuosTfyQu7tX8jb8pWip9UPWw0S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 45, 658, DateTimeKind.Utc).AddTicks(9928), "$2b$12$OhO0jHBKaosOIz5Xb3.17e6r9u44mXH/EBDO8uqLaRaqA8v.D5VKS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 42, 447, DateTimeKind.Utc).AddTicks(8112), "$2b$12$2E6IOIf0Y5uuiifG9WEhqO8kL53Yw1SDuY1gpcLoij1KsggOYcwY6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 47, 719, DateTimeKind.Utc).AddTicks(8257), "$2b$12$/NyE0cQ/fXfHTPD./FIF9uUHbAic/PQitZMc/mo/Mve5wt0ZwRIza" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 46, 644, DateTimeKind.Utc).AddTicks(9229), "$2b$12$o.RDueJDIo4xAh0VgVccvOF3eyNtG8bq.pLAiikbDVJ7rbJ.cj1RS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 54, 576, DateTimeKind.Utc).AddTicks(1991), "$2b$12$QX/kb/yIPJ0o0Tv63Zw/LeI31ms1VCeML18q5Jzkz.W1DepHRD7lC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 43, 55, DateTimeKind.Utc).AddTicks(7051), "$2b$12$NmLav6dhLojAI8iIDhvscuJvUblD5rtwWpw.HngxB./xg7XptCxmy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 41, 529, DateTimeKind.Utc).AddTicks(2421), "$2b$12$qN8L5hzlBJlSWi7nss2b3.4tXYyGw6NJx6pGVN2EBV4vfWp1VvIL6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 49, 34, DateTimeKind.Utc).AddTicks(905), "$2b$12$kjHZWhBWYeQuzyVsIq9K7.ShbGxf1OqSsjS/bzzkkYBiQygoeSWz." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 39, 373, DateTimeKind.Utc).AddTicks(2098), "$2b$12$Ox5iTU5XDIk/8MLBLewXgux/4PNpwbTszx9Hm7Sod5JuXod8XXhgK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 50, 297, DateTimeKind.Utc).AddTicks(7126), "$2b$12$Y5SE96shXXbdmrWCpBklaeiibBl1WiNcAxI3PpQkCdKuA8ihRghjy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 43, 691, DateTimeKind.Utc).AddTicks(8342), "$2b$12$KkSa93EX.2/d4xKc678WiO1bQIDvS6czFnztojTglXTGXvj0NVjbG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 52, 453, DateTimeKind.Utc).AddTicks(6000), "$2b$12$j9SDDcaJapwEUiZR/wzjn.oh2YiGvU4opOqbamwyZ536PtAOPFvKS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 52, 757, DateTimeKind.Utc).AddTicks(90), "$2b$12$YXeOXLtnWQOxo0xenqzjfuUlExCghVY02nXKaUrrrljpA0uSQVzPW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 51, 536, DateTimeKind.Utc).AddTicks(2377), "$2b$12$eWWb3Tw9JB0ThggvH4OH2e3M/uPtYLI8GYbe1PTnl55GAwM.4RSfK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 49, 346, DateTimeKind.Utc).AddTicks(1789), "$2b$12$4FthaX3Cg2fk9B2HEYvS/.ONt19/5h2DflPyCs7n0.52NFlEQWoAS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 46, 289, DateTimeKind.Utc).AddTicks(7912), "$2b$12$We9d.PjGxpwqwAsDfmQRtu.eT7CivyPUtrsR0XJCHKo123XeIA/N6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 44, 693, DateTimeKind.Utc).AddTicks(1302), "$2b$12$8pr4F0iUR3zQ3leN4NeZqORNc13rL4YZ7PFYVJcMJzmwJmdJzb19i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 44, 364, DateTimeKind.Utc).AddTicks(83), "$2b$12$AUpOa942Qb.FNtxuNTt0suml9vFiXU31u3tDEKkeZGSn3KgtZrsRu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 45, 976, DateTimeKind.Utc).AddTicks(3866), "$2b$12$itlepKi4O2c1lHNIYdlfMekHxvfZsrrQV5e0zHxDu.cPTFpvhl982" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 40, 918, DateTimeKind.Utc).AddTicks(5234), "$2b$12$EloWor2q.oowEZZPTZzCB.7zQSE/gbF1MEYh/n3AIGvoUWn0diVsC" });

            migrationBuilder.InsertData(
                table: "Attend",
                columns: new[] { "group_id", "session_id" },
                values: new object[,]
                {
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "3701bc4e-401e-f4f3-00aa-b37659789636" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "54166d2e-0d4d-7e23-3a55-ecde2614bcfa" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "885f671e-9801-9aec-86eb-3fe1cb1db365" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "a5129120-7dfa-797c-3e24-99056723ec39" },
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "e823715d-0a77-1379-9289-b44b55c10267" }
                });

            migrationBuilder.InsertData(
                table: "Teach",
                columns: new[] { "session_id", "teacher_id" },
                values: new object[,]
                {
                    { "3701bc4e-401e-f4f3-00aa-b37659789636", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "54166d2e-0d4d-7e23-3a55-ecde2614bcfa", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "885f671e-9801-9aec-86eb-3fe1cb1db365", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "a5129120-7dfa-797c-3e24-99056723ec39", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "e823715d-0a77-1379-9289-b44b55c10267", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" }
                });
        }
    }
}
