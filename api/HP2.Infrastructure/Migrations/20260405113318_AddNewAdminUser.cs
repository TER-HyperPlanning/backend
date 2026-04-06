using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNewAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 11, 801, DateTimeKind.Utc).AddTicks(9548), "$2b$12$3yUR9HAMyeFIL33dIhp.K.cuJK3hdk.8fVRYQ337E20lya1MYbw6S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 14, 882, DateTimeKind.Utc).AddTicks(3445), "$2b$12$L1mpndTvsLNPsaDaPQJDxuYkZfOvZVnuCWfSCoZ0Ih4Iuy1ocRTWK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 18, 270, DateTimeKind.Utc).AddTicks(2968), "$2b$12$MjrCzgrXsXvzdxOw4YtdWeuuN1H.9sHS28mPfynZFiaOSZ82DyZ0." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 8, 50, DateTimeKind.Utc).AddTicks(5774), "$2b$12$dbqU2.UkpGi2gyN3BUF7NOvEKA6waHM0WsTPVD3RZ/gJpn8nY5tB." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 10, 547, DateTimeKind.Utc).AddTicks(3344), "$2b$12$fErG0K9NMJH3htOOvzY0Q.JOhTwxDhwvUFl9JVQcYDHQbU0vaPfAa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 17, 277, DateTimeKind.Utc).AddTicks(8787), "$2b$12$MWdJZcMYd5Vzcjq5lUeaLOZRxD0JIwvIkxmfvgo6C5wZpiz0uEu.u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 5, 515, DateTimeKind.Utc).AddTicks(8938), "$2b$12$BPriICWc4A8CB8hsDkN23udBZTqdGmm8hP5SpdIl0teVOfYCLX0GK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 10, 239, DateTimeKind.Utc).AddTicks(1803), "$2b$12$yeWQ0LrxHPfCDWo.Mtf4n.WWLSb4o0kWSK4K4SNDM7XNKHjilhmei" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 7, 109, DateTimeKind.Utc).AddTicks(4879), "$2b$12$ra993J1/kelYnbmV30b7SeN71Db2Mjk1Di16x1rQdxFNGcnEbMpi2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 7, 413, DateTimeKind.Utc).AddTicks(9312), "$2b$12$SLyUBQXsvFPQMNZ5Lko6DOyoyOHphFsDG/c0uofy9682xRct72pWe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 8, 698, DateTimeKind.Utc).AddTicks(4060), "$2b$12$ew.Y9nUY4zM/fWoUwwOp6uKvNDTd5RyZA3etEZ9UMUF3hHh25..nu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 11, 503, DateTimeKind.Utc).AddTicks(2430), "$2b$12$PhGbm5WVADRsn0nAXL.PyeTjncltUE1USh1/CiWxdy3IkWSL8sH8G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 16, 80, DateTimeKind.Utc).AddTicks(8092), "$2b$12$ZlO4W9i3kENttn/5qv0W.OWo1Ki6rA6bMX0Py9McWn3L5pcu.vbLW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 17, 952, DateTimeKind.Utc).AddTicks(3191), "$2b$12$Z6aR/zZ/pktjsxP0PZjmueERbbyFLpMHQxZmgaDkliqQ/GmqT0yH6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 16, 982, DateTimeKind.Utc).AddTicks(3234), "$2b$12$aX/K5L3pgKA.u4YrVrftL.KWajesiNa.ApDj2vt09TMboq79UBnLm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 13, 629, DateTimeKind.Utc).AddTicks(5748), "$2b$12$G2PAUfhpsKk6WgXH8PDYEOTAvAnBauJCTwz7puXkdeyGvBe6eq8T." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 14, 238, DateTimeKind.Utc).AddTicks(8209), "$2b$12$5tuwiRav2quiPg/f7CnkpOx2LsN/YYIAwHdahgvW9ht1fdRf.G8B2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 13, 932, DateTimeKind.Utc).AddTicks(3390), "$2b$12$6LuE/DMcESbqtfHBtfwFkuKgfeseoOXdowkaAL1uN1CdlhB2Pkqk6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 12, 719, DateTimeKind.Utc).AddTicks(5526), "$2b$12$HcXcNNvPh.BRtC/LojruJeOwbeTQxgBTq2iUHblHtyPs/TfRkbXUK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 16, 378, DateTimeKind.Utc).AddTicks(2495), "$2b$12$fWz5Uge7RA0VWERDX06gjuxMPiDb8pxABHfn.0AEVPxCdXcXUqff2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 13, 25, DateTimeKind.Utc).AddTicks(8432), "$2b$12$To6SWWS8dmf8OnhAzgx/r.kIAdZNOwd0jC1974Go52sc4Yp3H8qTq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 15, 192, DateTimeKind.Utc).AddTicks(6311), "$2b$12$XusTTp9ojwiMH0CGyYiIIefyzuKpoyJGmuhABM9xuCROfX/FxMjYu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 16, 687, DateTimeKind.Utc).AddTicks(675), "$2b$12$o/0w2tUJq.yhRqspvzH33.sFUN8U1hnZzDlf35PqDTAawMxmJJu1K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 11, 165, DateTimeKind.Utc).AddTicks(4223), "$2b$12$2Ng.BWbM3InOHqb/kV.PruVC5Kxlyv5MAmUmcEVHcCa4QDG1wMOb6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 9, 12, DateTimeKind.Utc).AddTicks(5457), "$2b$12$ITNm5hx90J2eJqYOhD4ytOyGITZ8BtXFX3D8GpwH6g63lBvvnkTna" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 10, 861, DateTimeKind.Utc).AddTicks(3066), "$2b$12$exmYkn4Lu09Z2c5oscdbpes2LbhWC7BBt0E8U0SS4fRLtmi.h5nlW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 9, 936, DateTimeKind.Utc).AddTicks(6953), "$2b$12$D6dMYy1/y25PiiuS5om.AOWvaHEn22nJ4ucBvD1GXx9EqX/CwslQK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 17, 627, DateTimeKind.Utc).AddTicks(1856), "$2b$12$IIjgpA9gz0NlAes0ddyYf.7uWmOvyQlKVSVy2uC2Ty86wGVtlmXHS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 8, 352, DateTimeKind.Utc).AddTicks(6278), "$2b$12$cdkpqzyXktVBnspzcUjsxejggYFCQ11oSYzGP3UKQ3Xkkn0C4LDEK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 12, 103, DateTimeKind.Utc).AddTicks(8716), "$2b$12$F1HN1Mh2ogFkY4uBkvs2POGDcGh0I/mYiEnNpKKuo5/avI3VX6f1G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 13, 323, DateTimeKind.Utc).AddTicks(4445), "$2b$12$S19p0GASwMyqQ6ZOnS4u9eIiOPW2XZUbdd0zkXXAxlyoIuuqh9GCq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 15, 489, DateTimeKind.Utc).AddTicks(719), "$2b$12$1igH2lJ3YlM8eOBEyohtOu.XhkCOcUM2GUmEBmakGsON0K.W1u8Di" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 15, 785, DateTimeKind.Utc).AddTicks(5261), "$2b$12$9MTP78hHcIMVhfcSjU9WKeDoB/dcB97q0yc5hEj6GbWeHcsXOFS1q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 14, 550, DateTimeKind.Utc).AddTicks(9529), "$2b$12$a2BXtrLs6sFnlLuFHs/03ejz9BUxIrOvz4Iip986KZen2/LddGgF6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 12, 405, DateTimeKind.Utc).AddTicks(216), "$2b$12$TbJp.qYuQc2RrOfcup8BReUpHHvrB1yaVRvQWUsItKwyNDBk5WJT2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 9, 627, DateTimeKind.Utc).AddTicks(2069), "$2b$12$TlUUhYPafL5U6qTlM1XI5.tnSEijyHo1J7jH4wzyaoA5v3tfIDIcK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 9, 320, DateTimeKind.Utc).AddTicks(8502), "$2b$12$IL699Z6Op0NVE5YSpKL2u.mKYAb6xjAxy1XsDhFncmmfD0UVQ/VeC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 7, 732, DateTimeKind.Utc).AddTicks(9314), "$2b$12$swkBVgc9frCNffcz9mq4ZOt0ztEPQWflKPPhOy/l7IiIWzi0u3OSm" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "user_id", "created_at", "deleted_at", "email", "first_name", "last_name", "password", "phone_number", "UpdatedAt", "user_role_id" },
                values: new object[,]
                {
                    { "0b2b1684-7b29-7ac4-d601-be906e631ebb", new DateTime(2026, 4, 5, 11, 33, 6, 506, DateTimeKind.Utc).AddTicks(9698), null, "fatima.zahra@univ.fr", "Fatima", "Zahra", "$2b$12$13BKNGc2XJ1w6zPJ0JR.ZOXlE3Qv93LZ41/dTdsEiOFoW2SfH/hR2", "0102030403", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0a5d76e1-f1e4-946f-9f3c-d757a576d60e" },
                    { "4ab584a9-078d-55db-c5b4-e647a99a1187", new DateTime(2026, 4, 5, 11, 33, 6, 806, DateTimeKind.Utc).AddTicks(5225), null, "pierre.louis@univ.fr", "Pierre", "Louis", "$2b$12$eUjyBKO4RvmPsg3BoVb7jepgk9eQEzwJoMxEFRd3wdoHGaMWhRobK", "0102030404", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0a5d76e1-f1e4-946f-9f3c-d757a576d60e" },
                    { "b23b2edd-8498-994b-f92d-1033b02c5cee", new DateTime(2026, 4, 5, 11, 33, 5, 880, DateTimeKind.Utc).AddTicks(2961), null, "claire.bernard@univ.fr", "Claire", "Bernard", "$2b$12$CfBJx2vx1NhiZeh4vcRt8eY55UiBjXmc9NAau4FBo3R2OrvIdru8C", "0102030401", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0a5d76e1-f1e4-946f-9f3c-d757a576d60e" },
                    { "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3", new DateTime(2026, 4, 5, 11, 33, 6, 204, DateTimeKind.Utc).AddTicks(7197), null, "julien.moreau@univ.fr", "Julien", "Moreau", "$2b$12$oqKhwD7.IaGYYTEUPkPJH.Ed3pAcFcPtwcKhk0Roh.7sHUGoC0NRe", "0102030402", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0a5d76e1-f1e4-946f-9f3c-d757a576d60e" }
                });

            migrationBuilder.InsertData(
                table: "Admin",
                column: "user_id",
                values: new object[]
                {
                    "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                    "4ab584a9-078d-55db-c5b4-e647a99a1187",
                    "b23b2edd-8498-994b-f92d-1033b02c5cee",
                    "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3"
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb");

            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187");

            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee");

            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 37, 603, DateTimeKind.Utc).AddTicks(9419), "$2b$12$w7zm9akzss3y.mZg0iylweFrCoo4IKJDuso3c/aJyghH8e79e3C2S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 40, 581, DateTimeKind.Utc).AddTicks(8693), "$2b$12$EdUXunn4eZKoA9Sq5/pzoudKWvUCVnEmjY8OGsqiqxx891rL4DLUm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 43, 850, DateTimeKind.Utc).AddTicks(108), "$2b$12$lcm49vlkedNNPJFmIjei5uSYQPx1HxU.kh24yi/UGEkKMmnCpL/Ru" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 33, 931, DateTimeKind.Utc).AddTicks(8571), "$2b$12$YEgoprooW2CT7IzS2uO2HOPOTS/J4qOyPqcsAUs3RhaLE5mSIe3E." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 36, 412, DateTimeKind.Utc).AddTicks(8517), "$2b$12$sv9IFV7t95lAHk6uERAMoOULbQIlciEy5GZ3OH2UUm6Idve6JsO1O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 42, 964, DateTimeKind.Utc).AddTicks(202), "$2b$12$cNEMuQUEP9E9s/R.xXSVe.2HO4SAa4d2XGFywxkqolfk/P0VqSk0C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 32, 637, DateTimeKind.Utc).AddTicks(9685), "$2b$12$Fax2rjUgggIKuEW3RsF6xuK/gj/yfDE9FVxGfU/4Qt4NeDaQaE/FS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 36, 109, DateTimeKind.Utc).AddTicks(6112), "$2b$12$TYSd89QVNwNDchTpbiwA/uZisHcTrw4pOF7mfEgO6gYqoNpVlEXzS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 32, 983, DateTimeKind.Utc).AddTicks(3637), "$2b$12$/HdNOe4aldp5WmvQVPWOSub7A0/n2NAXdx4rHfAqQ2k1mIderA.L2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 33, 312, DateTimeKind.Utc).AddTicks(9159), "$2b$12$sITpASa9/SEbkqttyTP2e.LE5ORy7IrtrsVZtC6d97N/QyjFxFvpy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 34, 542, DateTimeKind.Utc).AddTicks(4947), "$2b$12$s5SlG1cOtHuxo9flV4RBXOBS4lM9tSOYE4tCiKgWxBaz0RovlXRfe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 37, 307, DateTimeKind.Utc).AddTicks(5828), "$2b$12$VB6b.mm1dj95XfiVo0QPM.Zrtuy2F0UQ17rv45QBCVV2dr8xsQ4Bi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 41, 772, DateTimeKind.Utc).AddTicks(9109), "$2b$12$rsfbaLnofQDwQzz029d4cOJ3ogiSaKSEj7B7YsMj6Hf39XC.prZim" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 43, 554, DateTimeKind.Utc).AddTicks(1782), "$2b$12$ckDn6hItM4Pq4gpwGCWXvuzQAFmGXlKEQ06WxrlA.uqwLhjVnRuku" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 42, 668, DateTimeKind.Utc).AddTicks(8780), "$2b$12$6cOHq51svhikpQzF9GnIg.rvzw9WlHOafbvJMlQGZYBqzlcSaZbNS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 39, 398, DateTimeKind.Utc).AddTicks(3955), "$2b$12$U4Bj759H4cZGSgnZ2USj9./aTEb14qSNM.uY9rAeUyCWQOGuFjBw." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 39, 990, DateTimeKind.Utc).AddTicks(7686), "$2b$12$ACbu9Qwzm4aEz0OjLdB72.ZcWTtopSU8c0yMWeEovEum5FxLA3XfW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 39, 694, DateTimeKind.Utc).AddTicks(9481), "$2b$12$mjbdpQe1vRyS.6VwsnwTjevVDN4OqP/W3XmBZlxmUj76VpmKveuai" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 38, 502, DateTimeKind.Utc).AddTicks(9040), "$2b$12$499V5.yz.7jt2rdzxV4yNOdk83hR0CQ9n8Y0EuAkYVdxyfK8gvDqK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 42, 76, DateTimeKind.Utc).AddTicks(9787), "$2b$12$gXputWw9fNLwBinfWIyXTeNWNllACy2lrMYU.kbGCKjd5sGl0E936" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 38, 803, DateTimeKind.Utc).AddTicks(5327), "$2b$12$13mY0cxwJi/HnXtNqXm2JuuhVK1KK5lmCOqkwPaKZ5/T8NhptMq5G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 40, 877, DateTimeKind.Utc).AddTicks(8479), "$2b$12$2UpEK6rTce0lzZSOvve90OEhTYvNb1qDgPGDHQEwBqtG2PlYC15HC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 42, 374, DateTimeKind.Utc).AddTicks(736), "$2b$12$6IeaDla.AvODAWj115DzoujkJYUZrp3wVequUls3IfhdybPLQnCEm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 37, 11, DateTimeKind.Utc).AddTicks(725), "$2b$12$yywEc2k9f4kFisgrF7M.ie5XWrc7DsfuV1umrEm0P3Wz8ZQHZbvvC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 34, 845, DateTimeKind.Utc).AddTicks(7282), "$2b$12$ZWppWXotYdvTBIWGmqzUEOfQyL0Q9hZfA7uQ1zEG8HVNO/qaywlXW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 36, 709, DateTimeKind.Utc).AddTicks(4919), "$2b$12$DVyYBkHa47g.Z0h/XWji2OfY2vDcHuD96fpBORTvTvEb7Qwxg/Tt." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 35, 801, DateTimeKind.Utc).AddTicks(9140), "$2b$12$/.hbdANLA76ZpCF3IHmjuucCGT.D/JHTRZuKkgsh.e03Uz6W6e7Ym" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 43, 259, DateTimeKind.Utc).AddTicks(7937), "$2b$12$fQnll/lghWz4ZfyeI/4...IdvQGVJXEZy5MIg.hjDnJjrSGoUMFAi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 34, 236, DateTimeKind.Utc).AddTicks(9354), "$2b$12$TGLfWg14oTliIO4i/VabHeP4A/2U5BrRvryoUmbdhGiAOcVI3z5u2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 37, 904, DateTimeKind.Utc).AddTicks(7054), "$2b$12$gettteKQZ9QZIeruHlJFCuvTYlIgFnS025SAFvDTb9hiuxCFPMfIa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 39, 101, DateTimeKind.Utc).AddTicks(8076), "$2b$12$/hHJhQCVoEfA.e1/.OL25uXcYW/i7vdoP3rmOp.jBSVHOe/N4x99i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 41, 181, DateTimeKind.Utc).AddTicks(1790), "$2b$12$S3M4GAu4XSEYxwEqdyeysedG9Hr/bWol9fv4FPlCpyUF9VHjkUFz." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 41, 476, DateTimeKind.Utc).AddTicks(6637), "$2b$12$CW43qFBjD2g082cnHbvtQ.8Aj3Zz3UI4q77QLBP/p.wJ7msJRjloG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 40, 286, DateTimeKind.Utc).AddTicks(4899), "$2b$12$rJoCb2uunwfxwxSj2.C/xeA4ImQSb5CO5CpPTU5Mso3AlO9scnqjC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 38, 202, DateTimeKind.Utc).AddTicks(3310), "$2b$12$nbF7D43SCNEBhblR0D4Vlu5HekacvZ.C6iSqT5LBUgj56tljifRse" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 35, 464, DateTimeKind.Utc).AddTicks(5706), "$2b$12$MpYfdCKqBqe9iOluchZBOu4Zgeq1CIPxxd.DgQUm2siRHO3Kc2jvy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 35, 150, DateTimeKind.Utc).AddTicks(8304), "$2b$12$hYXYTnKSrxaEMR.0V4q4de2Bi8YuUSfAVZT7GRo3Tx5.fTUnWiD0u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 33, 621, DateTimeKind.Utc).AddTicks(1336), "$2b$12$2d4k85iXxnmjjyH7aSUrqObuFP3jnx.jxnRMCs4519Ok1nHHxDWCG" });
        }
    }
}
