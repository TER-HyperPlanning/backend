using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedPlanningSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "session_id", "course_id", "date", "Description", "end_time", "mode", "room_id", "session_status_id", "session_type_id", "start_time" },
                values: new object[,]
                {
                    { "3701bc4e-401e-f4f3-00aa-b37659789636", "93b97065-831b-a4dc-8179-be986f0772b8", new DateTime(2026, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, new TimeSpan(0, 16, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 0, 0, 0) },
                    { "54166d2e-0d4d-7e23-3a55-ecde2614bcfa", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc), null, new TimeSpan(0, 16, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 0, 0, 0) },
                    { "885f671e-9801-9aec-86eb-3fe1cb1db365", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 4, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, new TimeSpan(0, 12, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 0, 0, 0) },
                    { "a5129120-7dfa-797c-3e24-99056723ec39", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 0, 0, 0) },
                    { "e823715d-0a77-1379-9289-b44b55c10267", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Utc), null, new TimeSpan(0, 12, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 0, 0, 0) }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 27, 271, DateTimeKind.Utc).AddTicks(1406), "$2b$12$XM1aqkI753a4EVdMl4aaPuONcYMYyKaq9uQ/gvKAF1D3QZrUHRnD." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 30, 395, DateTimeKind.Utc).AddTicks(7835), "$2b$12$eftIR/DK8UvRPeOWv7LJZ.fPak3CKKZuuGRFBbYpFdMETVZEEQt/C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 33, 799, DateTimeKind.Utc).AddTicks(3834), "$2b$12$bOeUKRa5Q.mFtFSE9wmS4ubKgTP7iEZTrtxL2RaJqIBKRLMmGGlh." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 23, 575, DateTimeKind.Utc).AddTicks(3499), "$2b$12$hlM4iB0F5HQQ.9tJ0yZUxueXyGAnbftOEYBQUgpn4V/./xsQDzH4K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 26, 35, DateTimeKind.Utc).AddTicks(1038), "$2b$12$A.zjQi/SftvKkZRyoJWHtOgN2qA7iW4vllgseNnqZ85hLnef9fEGW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 32, 853, DateTimeKind.Utc).AddTicks(9958), "$2b$12$NlN/54Y1SICuprbafn9jt.j.jHEX2Abj/cIHpOidIXriruElzgmDS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 22, 279, DateTimeKind.Utc).AddTicks(5786), "$2b$12$XCQL2wishrcBsLfQhZpvzuuXHfae.U4Qid5yeIb9TyLtVo3wEm5Ee" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 25, 727, DateTimeKind.Utc).AddTicks(9478), "$2b$12$9Mg3r.R2MqyORMACIQUzAe9JM6iywUvom4uAe1REbsVXz1d/VDTSC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 22, 609, DateTimeKind.Utc).AddTicks(9243), "$2b$12$azGWhNvVELzq2AOJlglktO3c4VWSVhxiPrUhOHlYNI1LmasUFaYXC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 22, 934, DateTimeKind.Utc).AddTicks(5621), "$2b$12$hrwXepyw0lO4IO9IcytelOAytIjdI8jPlKvpnpMdPA4ox2EyjMNdi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 24, 182, DateTimeKind.Utc).AddTicks(2439), "$2b$12$1TbANmYB3.y.DqSfy95rvuhTffFSQTG7V9nhzhidfobphLwcyuxNe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 26, 966, DateTimeKind.Utc).AddTicks(2899), "$2b$12$3aIQOnXP6quXyIZZ9Sb0HuNcJY.mp7WrhLmfr8l2WgPbmOWY6wdlq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 31, 637, DateTimeKind.Utc).AddTicks(8433), "$2b$12$cdHI3r1TqN8PzZqZ.0iw9eLpcunLC8yJLGhRRYN26hn7zvRn5ZJJu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 33, 493, DateTimeKind.Utc).AddTicks(1617), "$2b$12$FFTJ89BGpEJabwFbx2AwNuhkJ0rz/BbyuAm/fX/XXPRV3NMcHqvH2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 32, 548, DateTimeKind.Utc).AddTicks(2307), "$2b$12$QTNcILyAAmSoUMIUBLTLU.ip.bsAABiSvceKL05CT/zKZuXfzZdpC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 29, 131, DateTimeKind.Utc).AddTicks(4869), "$2b$12$KITW8DPFAkGdejYTCW3oyOAx48FVwchFveQeRtRDAT93MAJI1bPde" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 29, 741, DateTimeKind.Utc).AddTicks(3363), "$2b$12$YpofuZYhemeuTq9XUMIEDuDETgo3brYYDVcWBp/2xMkoo..CXC2JS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 29, 436, DateTimeKind.Utc).AddTicks(5133), "$2b$12$NwXVyrgGai46tqss4pkXduAoPikO6WZl4bjTmluui4FAKOWOnPp.O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 28, 191, DateTimeKind.Utc).AddTicks(2989), "$2b$12$iOIZeE7W3US/w1530yN69.C4XcGYFkDZTE1pReuQ788G2TqF43sku" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 31, 938, DateTimeKind.Utc).AddTicks(2580), "$2b$12$hH8b9bA1ScrkhBiK0FU2Qey7T6tE3U34rvYMBaIM2YG/8FX1/6nVW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 28, 523, DateTimeKind.Utc).AddTicks(5982), "$2b$12$zIZPrehdeENjkfrpUH0Gt.DxMALgQZ1kL.iYOBq6yI1/GdEd6i9iy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 30, 703, DateTimeKind.Utc).AddTicks(1063), "$2b$12$63v8fW4DTYl7x/5OV/Bf8Or05G8pCF3Uq.oYHL0X7zV.gykSEMX5W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 32, 245, DateTimeKind.Utc).AddTicks(6089), "$2b$12$DwblZ3.eW//N90cy0VBX/.IBorNPWveSDbN0msfBO9nKb9NLZ/rIW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 26, 660, DateTimeKind.Utc).AddTicks(7218), "$2b$12$0bs5ow/yazyK2mZEEsyMvOzHB.Pt4mQXQ4zKCznbq9P91AIKF6WBO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 24, 503, DateTimeKind.Utc).AddTicks(6150), "$2b$12$AFJrA4ZKnAw6oxIhTRrlwepOkjmO6H5yWJ2MAgxJ57mU0fm8KTFRS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 26, 357, DateTimeKind.Utc).AddTicks(7073), "$2b$12$ekqRnC33D4l8.ewF40q43udQ.JmR4W2qsUUn4YVHNp4xyVc/T.Y6u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 25, 426, DateTimeKind.Utc).AddTicks(1065), "$2b$12$6rZwErVntLFi.fDJUpfbhOtKE5hRJUjQQyuTf8EcwIPO0YhWI6tYe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 33, 159, DateTimeKind.Utc).AddTicks(8286), "$2b$12$j.3HHqZwYaNcxTFSdSy4f.6Bc0geWl9c5y9tuTj5H5DjOPN9T4Tqm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 23, 879, DateTimeKind.Utc).AddTicks(2863), "$2b$12$fmwh262dfTgqQY/mUM3Dju12lhA7SyY2rALRJLucEKMN/07IgDZK." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 27, 576, DateTimeKind.Utc).AddTicks(4760), "$2b$12$3dfROGYBPBvTPSV29wDDWO4cTpEEfclSZ5Wft5crvQNBsM3fwA9RW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 28, 826, DateTimeKind.Utc).AddTicks(6513), "$2b$12$APduH7BgAkGyY5zoBhGu/.gqEd2MxdXkVEX2IlKyustB4G.LA/HzK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 31, 39, DateTimeKind.Utc).AddTicks(8812), "$2b$12$77wWZLINJgI3c6b0xQQ.qunurDOrYo.UEi673zq64MkFohR21XMQi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 31, 341, DateTimeKind.Utc).AddTicks(1934), "$2b$12$1IlHsR.UT/iJkZOa5vHbieA3PgSgbdtumZu3YYNC1v29fUHU7gSDm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 30, 75, DateTimeKind.Utc).AddTicks(6410), "$2b$12$ke3BHAVuqBIzA8phMHzXdOc6W6SAEkAKAZeteYJkZlYGksrIy0SOq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 27, 885, DateTimeKind.Utc).AddTicks(7431), "$2b$12$Azigr2Ft0g6/JQJtL1QM7.RTVHT/Cxz7Y8j.BqXa2OIpUO5mosiE6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 25, 111, DateTimeKind.Utc).AddTicks(9100), "$2b$12$NcgWvwTHaGnPKPGKzNrlbuqn/LQctqwfKdP758XmO/EHdiGCxYqfu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 24, 806, DateTimeKind.Utc).AddTicks(5542), "$2b$12$wbVjM0AtTRamMS7HQnltyOAZ3Cf31Cpa.8l16kcNvO6EeFZJpXvz2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 33, 23, 256, DateTimeKind.Utc).AddTicks(6823), "$2b$12$Ucex2ZCKrR1R3EGJJ/Jfkef8/5MEXz2mf6XnWb34LxX2Nb9SklILe" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: "885f671e-9801-9aec-86eb-3fe1cb1db365");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a5129120-7dfa-797c-3e24-99056723ec39");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e823715d-0a77-1379-9289-b44b55c10267");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 17, 216, DateTimeKind.Utc).AddTicks(9614), "$2b$12$wiU.z.oypUKkARKUAopZxOPwr5DWm3urBJ962Y1AXtnjn2CtvEGaa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 20, 263, DateTimeKind.Utc).AddTicks(5644), "$2b$12$JxBvr1e5xoUzl9etc97OVu/2nXmgq5QTVkExvDB9bSbPsOmqAgHRS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 23, 672, DateTimeKind.Utc).AddTicks(1181), "$2b$12$KsLFbEIgiJ8hMhTVBQiCUOQHFEHnoRCgmlDXojt4bwq1KU4wJQdjW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 13, 508, DateTimeKind.Utc).AddTicks(589), "$2b$12$xu1uphKL1emXzRqHGMEb6eXT.hPZGpIsT.PCVRhPxZyti2PnMHJbC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 15, 988, DateTimeKind.Utc).AddTicks(9532), "$2b$12$YKsspBsgl./NBD9B6kKnR./DixECbBTiSlWBDdEP4WOtPKf7Nu2uO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 22, 763, DateTimeKind.Utc).AddTicks(3791), "$2b$12$1VOe2kmNa8TYVkJ6rWDKX.zoBHYJwrqF9BMiY1S65jX5zHYsEuyjK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 12, 238, DateTimeKind.Utc).AddTicks(163), "$2b$12$B3voQFZJZOTHCUX8LJ7Ww.W.0NJ1SA8nUNHbcxncWBM/z4w1zNJbm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 15, 680, DateTimeKind.Utc).AddTicks(9547), "$2b$12$CsbqLAvGj1ZPHxgCCEmoxuetnoskARblr/7dj47bDc08Z5zfOSh2y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 12, 567, DateTimeKind.Utc).AddTicks(2760), "$2b$12$CXHRfcXy68hL0FYs09lZy.Ms6bD0zz1kpcj/vMiVY3sPqhI9VA1zq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 12, 889, DateTimeKind.Utc).AddTicks(5408), "$2b$12$e0s.mcNRGesUfymK0g2kf.Pm5trcoJ/X3if5FUUEuqsCJUGG2Wa2G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 14, 123, DateTimeKind.Utc).AddTicks(3996), "$2b$12$hVGwxEG6k/qMMD4vGCTzrehBtIhs63Nsbx/ByngvTN/LTu9dshtO2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 16, 905, DateTimeKind.Utc).AddTicks(5511), "$2b$12$OaH61znkePpgy9D3Eh3CmOhWWE7MUc23DoAw3.syZCtI9hEf65ymu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 21, 527, DateTimeKind.Utc).AddTicks(1989), "$2b$12$Y0JzsvnQbWlD41MyTckZ3O04f9aILLVk6eAKzzSPOeaeyr2Be9knm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 23, 368, DateTimeKind.Utc).AddTicks(4269), "$2b$12$YiHYzEdplQksnGCUw454kODWlBUJ.WSdgMCGmqHYbIQnSn/PTr6ze" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 22, 456, DateTimeKind.Utc).AddTicks(6622), "$2b$12$vkLxql69N76zzHQg7aVpdO7DdxFBqFdL8wJo9S7KwG67h/t9uDD1." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 19, 54, DateTimeKind.Utc).AddTicks(5210), "$2b$12$XwgOInFZKCdBiFHDDFJ0Ium2Bfs6nagepE7sljY9O07pwWYm/Cb.O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 19, 658, DateTimeKind.Utc).AddTicks(3133), "$2b$12$Pig6cM8jNryhvVcltqCAbeB6dzX91uPvWqjQA.aD/3HmK37z5air2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 19, 356, DateTimeKind.Utc).AddTicks(2927), "$2b$12$f.Szd/9kboZiy945b7tveOJyAgalLa/2XHcYSRZW1YFxWig.EQXLm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 18, 141, DateTimeKind.Utc).AddTicks(4973), "$2b$12$PI0QoJWYYJXNfp/JqNdv8uevOke.RyX8rIuPzJYHbkcViAUhB4Wjm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 21, 845, DateTimeKind.Utc).AddTicks(751), "$2b$12$VrDJyaQcCQJjJhSBYerVUuLwYzCATFN3fIuUXIH9gAqf9SKbr9yam" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 18, 447, DateTimeKind.Utc).AddTicks(3121), "$2b$12$XA8tIP.HKA6ifpDnP/6hMO2q18zmkNhpJ63atwFCj97v.yymhGTde" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 20, 567, DateTimeKind.Utc).AddTicks(6118), "$2b$12$RS4TIEXFTMv.U5BQC.ris.jvtvTPbirUg2/KAT7Xie6WhH2wF71ky" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 22, 150, DateTimeKind.Utc).AddTicks(3386), "$2b$12$zPFLGtNrn9ljvJxQc0MMceyZGI4fllWlUx/k/l8telhbLU7Qi5yHC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 16, 605, DateTimeKind.Utc).AddTicks(3163), "$2b$12$88ZzPB6STqrqTeu5qMSniO7BZbh8eEgBSj/V2erUIMcOLO7Gh8NhO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 14, 457, DateTimeKind.Utc).AddTicks(2514), "$2b$12$uHeMsxGxLOnxbgKA7JchX.XX3d4lcWkHDHccS7wn/DvnyNSWusrwu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 16, 302, DateTimeKind.Utc).AddTicks(6532), "$2b$12$gaX5wDpMRu1v8DsHwMf/XOAa1n/6qbX3LOY.Jyl65uNKtTCJQ2zuO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 15, 376, DateTimeKind.Utc).AddTicks(8454), "$2b$12$fK/bwY88dT8g/aw8RVEWtOvq/wy7Owu5wJ/xWlpcz3eKgJrXV8Odq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 23, 66, DateTimeKind.Utc).AddTicks(3741), "$2b$12$E136fv9L18yZ6P7UcH.kO.qcnTi7i6Jv7hYE7rKlW7rKfxWoPWcK2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 13, 813, DateTimeKind.Utc).AddTicks(3754), "$2b$12$a6p5WEkoFDEPcHJITGQ4COH9gd91CyvnBitq1Scda4lZ1z1vwQedW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 17, 526, DateTimeKind.Utc).AddTicks(2025), "$2b$12$VmVcGtE0KXxgDYEOvWoMYe9ByDEqVRRrk9GALbCy811mRhgYBdX12" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 18, 746, DateTimeKind.Utc).AddTicks(6261), "$2b$12$8GeRobtuo7e3Qk9jePfHY.GpX0E/3E89H.AkIH1Gcz7G7gpw76Tn6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 20, 873, DateTimeKind.Utc).AddTicks(7558), "$2b$12$ntbmE7D7rjTrJnXoDyctj.KGPayQKr6JFu421TIvG2.5UhPVo2ioS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 21, 182, DateTimeKind.Utc).AddTicks(3800), "$2b$12$gisf6eB0c2yUId7T7K796uNXCRZKE3B2U6CTzuoDrKMXkoVpjvJ7G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 19, 955, DateTimeKind.Utc).AddTicks(955), "$2b$12$yiA70a5eZSlyqOWumR0Vse8bQdy4k/vuwy9LEWlpidWkeLpQN1nI." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 17, 837, DateTimeKind.Utc).AddTicks(9324), "$2b$12$4dSwzSsUoaPrvgW9y71x4u6awbVxfE9Wi15G0G.4tpCnPyHGrnL46" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 15, 66, DateTimeKind.Utc).AddTicks(3834), "$2b$12$yeGzhnXvgacjpD88t0./Tej7p4OhdDLbULEON6.Ku0OXZP.mg5A3K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 14, 763, DateTimeKind.Utc).AddTicks(8157), "$2b$12$53yLTRijXgmpu4GljOt68.JxOUH1gPMay6.3VZxXuDVLFhCHH7u4m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 13, 194, DateTimeKind.Utc).AddTicks(6677), "$2b$12$hOT7I2RDRq4H4qtX28oVg.9YR.cDtig2QzLivjDy41/OkfekWYI2a" });
        }
    }
}
