using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTeacherTitleValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TeacherTitle",
                columns: new[] { "teacher_title_id", "name" },
                values: new object[,]
                {
                    { "58860466-08f2-cdc5-1f1f-bda9b990b0fb", "ASSOCIE" },
                    { "85279958-5b39-6e84-7c57-09f2a0174fa9", "PERMANENT" },
                    { "f81d6bbe-c55b-51fa-106e-6a162212cafb", "VACATAIRE" }
            });

               migrationBuilder.Sql(
                    "UPDATE [Teacher] SET [teacher_title_id] = '85279958-5b39-6e84-7c57-09f2a0174fa9' WHERE [teacher_title_id] = '025afe74-4e45-ca60-93e0-035aa84f648d'");



            migrationBuilder.DeleteData(
                table: "TeacherTitle",
                keyColumn: "teacher_title_id",
                keyValue: "025afe74-4e45-ca60-93e0-035aa84f648d");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3701bc4e-401e-f4f3-00aa-b37659789636",
                column: "date",
                value: new DateTime(2026, 4, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "54166d2e-0d4d-7e23-3a55-ecde2614bcfa",
                column: "date",
                value: new DateTime(2026, 4, 14, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f",
                column: "date",
                value: new DateTime(2026, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "885f671e-9801-9aec-86eb-3fe1cb1db365",
                column: "date",
                value: new DateTime(2026, 4, 13, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a5129120-7dfa-797c-3e24-99056723ec39",
                column: "date",
                value: new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e823715d-0a77-1379-9289-b44b55c10267",
                column: "date",
                value: new DateTime(2026, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc));


            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 20, 126, DateTimeKind.Utc).AddTicks(3720), "$2b$12$NA8/vT3yHj4zzlyS.v3pD.RNele3CWAskvzoAlx8pctnhj2AgqfG6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 23, 696, DateTimeKind.Utc).AddTicks(2740), "$2b$12$9E07C/7v4kmFjmMU71rXfOn9IEjva8aZo.jvk33Efde//l9.Kmr5." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 27, 645, DateTimeKind.Utc).AddTicks(1580), "$2b$12$rb2yPiWdOX5FPNR0n.Hl2e0G/yl5U7/oG93mfZAyVn1VFC//t2qDG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 15, 789, DateTimeKind.Utc).AddTicks(9330), "$2b$12$SxueekCMFHXwgKJwTrGxzu31RLWnIzlcilEGlDsEi0nH4pKQrRaB2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 18, 668, DateTimeKind.Utc).AddTicks(380), "$2b$12$EmPSt5Vu2BEWWGdjWOxLqeHiI1mO.PMro.MfFZDfVzc8UDuRar8uK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 26, 559, DateTimeKind.Utc).AddTicks(1380), "$2b$12$PpdVgEdVsereZR.GNJ7UOeD5px.RzdUx/MwKi.188XCRNuW9ddFm." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 14, 337, DateTimeKind.Utc).AddTicks(40), "$2b$12$B1L6B48zlk.94JYYoMlVQeWZe4jJjlxSz01P.uZYSYwyJJrJlLv6S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 18, 310, DateTimeKind.Utc).AddTicks(8950), "$2b$12$3LpmzuyGfZdliGzUed80iuh.Bnla8IObrmapN.pSOV3n7ygyiiN9K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 14, 709, DateTimeKind.Utc).AddTicks(1450), "$2b$12$mVotmBFauhhnrH.kzMgv9.HOmBBzfKV1Geqe/tkAhwWMxqQIkMXYm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 15, 74, DateTimeKind.Utc).AddTicks(9840), "$2b$12$IbufWu3/2EhyKBKmtLMC6updKjr166Wk6dcNvAI921b.5j.E9PIeS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 16, 504, DateTimeKind.Utc).AddTicks(1720), "$2b$12$xh5mjvbhg2d50pCMqI60ceouD1d9NDJNI9atQTSfmGXTkuken6cZy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 19, 769, DateTimeKind.Utc).AddTicks(6710), "$2b$12$R7PlxhpwMapfGVZ0wECJ7OMzfHmHxJnx24VTb2WtYWZXvyqjvnJyC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 25, 124, DateTimeKind.Utc).AddTicks(6950), "$2b$12$kkN2Sf6VjtpeGPnX9LteXOMxHidSIFqTKZ6VRC7EEiDGcLsy.A7pG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 27, 287, DateTimeKind.Utc).AddTicks(9050), "$2b$12$70RGmfY2BGZMHMi4wZCcyeew8qFFC.Yb2YfnnTeqxNF9DM7IZU/NK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 26, 197, DateTimeKind.Utc).AddTicks(2960), "$2b$12$LyTIskwxhyR3WhxgxecvMO9a.ydFzpyE1SU6EXrNu3ecjgRfPrGIa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 22, 269, DateTimeKind.Utc).AddTicks(1920), "$2b$12$528ZhN1cqutJzK.h0Rgy.uhzMLCiX4IJvA8GKXlz1KSEVd3jI9fIa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 22, 982, DateTimeKind.Utc).AddTicks(8060), "$2b$12$QSkd4526gzZ18YWnPkfhiOtASu191haUcSvxQJ.YD8Go10oAeIleu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 22, 625, DateTimeKind.Utc).AddTicks(8900), "$2b$12$jmP/7L7.9Gab3wE2teszmOBrmLEDe2YTumM8.PAMk8xybFzaPOIaK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 21, 197, DateTimeKind.Utc).AddTicks(8450), "$2b$12$Id5Di9P4IX3LzS1DX/hgPu.5f3CBGbjpP1RuNSA/RjLfBOAfo5bTW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 25, 481, DateTimeKind.Utc).AddTicks(3440), "$2b$12$3eZREP6vwmp/K0WjvCBkTu00tx6J1k.pfLwCeN2BjCqwvNSg1pjni" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 21, 555, DateTimeKind.Utc).AddTicks(9730), "$2b$12$/5ibZS6VHXsJ8I5hQOTji.r9/NiAs6yJZstCWuLNPFdGyZ/7oWEJ." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 24, 53, DateTimeKind.Utc).AddTicks(2320), "$2b$12$RUrzNOLUKaxwVhLl86rfz.sOqgzZdZyb6AQYmBPbFQN8izLFWpcue" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 25, 837, DateTimeKind.Utc).AddTicks(9570), "$2b$12$3Ga9YrRn2BAEIOTb.KsOP.tA1BNCImf4wWzxm4ukm/iLC9lzkrBYG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 19, 411, DateTimeKind.Utc).AddTicks(9200), "$2b$12$Y5ZmFbp93E3/CGFwBp328uOm3NtrNY5Sv93UPlINBOTimG1cAc7qC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 16, 863, DateTimeKind.Utc).AddTicks(5560), "$2b$12$QDmLy5CC9/4AYsqPqQ8yeuNXOZCwAtKnW3yJnv35eyATOH8ExbDki" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 19, 55, DateTimeKind.Utc).AddTicks(360), "$2b$12$rrg4nIphaW41GF5ywKWfde7D8inG0dhcF.AVnmorGYyvRy7F2KqYG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 17, 953, DateTimeKind.Utc).AddTicks(9550), "$2b$12$syEfZdmyxdwoe66AySDFfe3F1oAAkekrf6Ds8PyWmQxEonyy7dsvO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 26, 926, DateTimeKind.Utc).AddTicks(8440), "$2b$12$BN4VdvYwQf2hN6PnJVcoNe75AknnF93ZU50RSsoh146gRUCdJo0na" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 16, 147, DateTimeKind.Utc).AddTicks(5060), "$2b$12$44YKj0E/L5vDvuv0YiHcIeOuls6LFQCBhT3xyZ2150xcFuCreHivi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 20, 483, DateTimeKind.Utc).AddTicks(510), "$2b$12$9NIkffLXBrMWvwHeklbKmOiZkjvk88/9FH4BYuc//ck8jveB0GF8a" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 21, 912, DateTimeKind.Utc).AddTicks(3820), "$2b$12$QjwfwWiM2zm9BUxzBxu2gOAi9u/yipPLkeEEuyXFPYZsIrw3/C99q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 24, 409, DateTimeKind.Utc).AddTicks(9240), "$2b$12$bOq7LBkroj0MduzuJ/UGU.GZZwC.Z.RE0cJ8.z9jVbKx9aFCVsuWO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 24, 767, DateTimeKind.Utc).AddTicks(6220), "$2b$12$36XnCWFMFBMM.QZh19EVCeyqJ2rXdIF4MqZlOYhYgq5wlS0miUwsW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 23, 339, DateTimeKind.Utc).AddTicks(5050), "$2b$12$XH7ce.BIiWQ.akjHbntot.nsfYMaYWkl8ylSBlN7zX5PsZvoSi/Nq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 20, 840, DateTimeKind.Utc).AddTicks(3310), "$2b$12$O0W.rWTCzrCjGICVXFATJ.0N04.3wXIbxg8KqlYIeCxPXtdWW3kYu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 17, 591, DateTimeKind.Utc).AddTicks(5540), "$2b$12$lIXAv7TcRo76y0u9lP4zf.pAqeEffx0kognmuUHAsk.ciZcq0Zf0S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 17, 220, DateTimeKind.Utc).AddTicks(5750), "$2b$12$jo4zVYlkHMPwb9.fcdmyfeoAHQm2BzseP48sntd9TMr03cSQOT0y6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 2, 19, 41, 15, 432, DateTimeKind.Utc).AddTicks(8100), "$2b$12$lcmrYjcaJUo.A1XbrfE3uOly1daLSGUadeu0EZOTOmU77E6IhEihq" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeacherTitle",
                keyColumn: "teacher_title_id",
                keyValue: "58860466-08f2-cdc5-1f1f-bda9b990b0fb");

            migrationBuilder.DeleteData(
                table: "TeacherTitle",
                keyColumn: "teacher_title_id",
                keyValue: "85279958-5b39-6e84-7c57-09f2a0174fa9");

            migrationBuilder.DeleteData(
                table: "TeacherTitle",
                keyColumn: "teacher_title_id",
                keyValue: "f81d6bbe-c55b-51fa-106e-6a162212cafb");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3701bc4e-401e-f4f3-00aa-b37659789636",
                column: "date",
                value: new DateTime(2026, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "54166d2e-0d4d-7e23-3a55-ecde2614bcfa",
                column: "date",
                value: new DateTime(2026, 4, 13, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f",
                column: "date",
                value: new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "885f671e-9801-9aec-86eb-3fe1cb1db365",
                column: "date",
                value: new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a5129120-7dfa-797c-3e24-99056723ec39",
                column: "date",
                value: new DateTime(2026, 4, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e823715d-0a77-1379-9289-b44b55c10267",
                column: "date",
                value: new DateTime(2026, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.InsertData(
                table: "TeacherTitle",
                columns: new[] { "teacher_title_id", "name" },
                values: new object[] { "025afe74-4e45-ca60-93e0-035aa84f648d", "Professeur" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 11, 754, DateTimeKind.Utc).AddTicks(5227), "$2b$12$LVogedNYVz8.DCYN5Q2sLOSrkfv.MqJi1Fuh.BEWBZVs7WZzdGHKG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 14, 714, DateTimeKind.Utc).AddTicks(7901), "$2b$12$.s9HmLuPcI6J3WDuGOupEuX2hJLmo6TN5xDAQFaofG3OnY2uWzuvu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 17, 996, DateTimeKind.Utc).AddTicks(6694), "$2b$12$YcBJ409PAiMT2OtuQbuk1uZhpJQp7j0//L87Cvlf1fV0DOOKco5ki" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 8, 207, DateTimeKind.Utc).AddTicks(8322), "$2b$12$ZGx/5Y0/SWSNXDwAi/akWuupSm5M3Dk0pF8WMKXxT/d6LFkeMt/gG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 10, 576, DateTimeKind.Utc).AddTicks(6767), "$2b$12$/2LAKphSSiwwjsVc/39/LekxsHZNHk4eORxy9ScMOplBwXeK9DurG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 17, 109, DateTimeKind.Utc).AddTicks(8462), "$2b$12$vxLoru85W8Syvx0k4jq6Ie4GsKHp9.fBJpE9v4nRJ3KV0eVbmhQ3G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 17, 14, 41, 22, 790, DateTimeKind.Utc).AddTicks(1650), "$2b$12$sp9hThU4xbUCDU5RZVIpPeWOEhGGlyyLh7WHGlXXE2lqkEkm5fIi." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 10, 281, DateTimeKind.Utc).AddTicks(9116), "$2b$12$2oQf7B7MzA2lUxQ2aXdcC.xranT55hC69K7E12K.FoKWl3f.kKo12" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 17, 14, 41, 23, 288, DateTimeKind.Utc).AddTicks(2975), "$2b$12$Su0VDQMZ6dZTI6VBUdMw1OHR8AYXfOeg8TuHznyEXaV7nmqTgwLr6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 7, 602, DateTimeKind.Utc).AddTicks(6741), "$2b$12$dfRprIwX4btYEBviX/Fn9ute4qf2hfTRC5hxkA8/rHpWEmsNlUb2W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 8, 802, DateTimeKind.Utc).AddTicks(3434), "$2b$12$dMkllJIGmXj1ywBqs8KwUedj4.r32z34UGE3XtNPQlXWQFyKTQeKW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 11, 460, DateTimeKind.Utc).AddTicks(898), "$2b$12$jGE4lu4IauRVADwdnE73uuhWNylUDXOcJSq7Fl0Q6nrK.zCna1MPe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 15, 930, DateTimeKind.Utc).AddTicks(9194), "$2b$12$NcHFRIPTTp5zcM6RASET8.F4SU9Q9w2LMJ8AXawMuFXp6yN8Reuna" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 17, 701, DateTimeKind.Utc).AddTicks(1591), "$2b$12$QavDYYx3M8M0f8cvx.uuxelluB6.Q/dQ/KJwv8w3bWW0UPtNvXw36" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 16, 815, DateTimeKind.Utc).AddTicks(3532), "$2b$12$/e99.0AErEjbaScm6BRqZefV5HQju2w9GVnYoSM5B8/w7u8E.GSyS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 13, 521, DateTimeKind.Utc).AddTicks(9792), "$2b$12$hUWhhzSLMTkyLNqEzbcyzueAFo.LrRXethsWUWFTO0Le8b4AuF69W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 14, 114, DateTimeKind.Utc).AddTicks(6817), "$2b$12$WUQXHNqAJvdHs341NQVU4OmUl187MHx7yUYKMitz962MRRCyyHOEO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 13, 816, DateTimeKind.Utc).AddTicks(7307), "$2b$12$87MdRL2rr4GrbmRx5EIsQ.PBZh61nRvin88JEhoc18AO357g9z6v2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 12, 638, DateTimeKind.Utc).AddTicks(545), "$2b$12$ovdt5bql1h9jvKP7kQFX0.k/DFNY29VImLlY3ZjsKqZVJbS/7bjIe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 16, 225, DateTimeKind.Utc).AddTicks(4940), "$2b$12$7SK7Gg3kdtqWyevHHvWY3up1dbYk8vkK2ggoePlXkJ91ZFdTqxZCm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 12, 932, DateTimeKind.Utc).AddTicks(9874), "$2b$12$JbMvwaeN5.dbxskAzUWgVOY8nFYU8IhSvfQRa/4xW5opahTfMWV8K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 15, 14, DateTimeKind.Utc).AddTicks(2039), "$2b$12$laPG/86PCTB8APKHGotc.uyoTdfPABdSFuLFdKxW2vn1GyVWjBLUy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 16, 521, DateTimeKind.Utc).AddTicks(2258), "$2b$12$/ijZEQcPOYyyM1LJ2TE5nOZxMgcP3q1ExtrTRWGVh4D7d/YsOGomu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 11, 165, DateTimeKind.Utc).AddTicks(5835), "$2b$12$bZeYbjv3OqgcestJTu1IQe8ilMIDUhMoW7mtRBJtrS/Ov9qFcQW6u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 17, 14, 41, 23, 797, DateTimeKind.Utc).AddTicks(955), "$2b$12$YFbmIMr9kImvZIFT3jQP8.Lw6b.m/zJXprnQWBWjCoJwGXo20Gz6q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 10, 870, DateTimeKind.Utc).AddTicks(9774), "$2b$12$sfx.ytqirYki.QbnQvl7sOOu5pd3X40IkYy9FJLLUfSFgjmEs5L2q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 9, 987, DateTimeKind.Utc).AddTicks(9119), "$2b$12$D1SBZmfD6nZO/cH03qH15OG71KhRclsdVWqWdrjfjWleNUAalDQC6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 17, 406, DateTimeKind.Utc).AddTicks(1069), "$2b$12$f5A9jpjFDyW5Vf2zMFVx.ed1F8KqL9/99XNCCr5BEMomy/Flo6VZi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 8, 508, DateTimeKind.Utc).AddTicks(11), "$2b$12$TdRxzZkdvA6zyZXP/XmZdORMXsO7JYOPSLNp.5VpYDZFcJsoDgFGq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 12, 49, DateTimeKind.Utc).AddTicks(5868), "$2b$12$RJbtq3isA5YYfhqIm7WxjOTs2IW1ZM0dFRG17BhNAlkg7UE8UUxCm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 13, 227, DateTimeKind.Utc).AddTicks(6262), "$2b$12$V52jVr9IVZn2LHhaoU1qQupD4WAvg/WPUBL5bmy1mLySop8WKA8Xm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 15, 310, DateTimeKind.Utc).AddTicks(7354), "$2b$12$WwsT49VCxe/J8iv6pwLlT.vCGlO71GfZDvJJtZ2eQeQeRbWanpKLq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 15, 631, DateTimeKind.Utc).AddTicks(3300), "$2b$12$DPfVO5ZRCHsei/EpLpFR0e1FMK8iNMQpRJcYAU2fOfGuMmNL/PjIu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 14, 410, DateTimeKind.Utc).AddTicks(4422), "$2b$12$7jPkUegqDvqSXYT4EAPBgu2RlGuHxjK223d9N2Dfv4n30p08T3ugS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 12, 343, DateTimeKind.Utc).AddTicks(7521), "$2b$12$v/qrjybsClCeEJiq12cZFe6nMQNl4mHsE1CEi8zzXWCMQwJuD7/Ke" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 9, 692, DateTimeKind.Utc).AddTicks(4583), "$2b$12$Ht3iKANl7OlBUn5ePwlIW.K4xphZnI5CpJ01gC4WJJFsVh.j96mv2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 9, 392, DateTimeKind.Utc).AddTicks(5098), "$2b$12$sHBnAy332RAYgQv2nN2rlOOwp1n/wXl5hIembP/vOSNOhWa4krSOC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 7, 899, DateTimeKind.Utc).AddTicks(7796), "$2b$12$pYoDVv0lqYzAmFTHRmjQsOEygnxLtKyA7NnXDmCxAEpa8w3q.gj.K" });
        }
    }
}
