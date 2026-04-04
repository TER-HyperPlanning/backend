using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedPlanningSessionDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3701bc4e-401e-f4f3-00aa-b37659789636",
                column: "date",
                value: new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "54166d2e-0d4d-7e23-3a55-ecde2614bcfa",
                column: "date",
                value: new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f",
                column: "date",
                value: new DateTime(2026, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "885f671e-9801-9aec-86eb-3fe1cb1db365",
                column: "date",
                value: new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a5129120-7dfa-797c-3e24-99056723ec39",
                column: "date",
                value: new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e823715d-0a77-1379-9289-b44b55c10267",
                column: "date",
                value: new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 50, 607, DateTimeKind.Utc).AddTicks(9942), "$2b$12$Y36i20Egyb6BnmmKyWsA5eJAnrkbSpXFh5S/Ej8agAuzHYEB/.cV2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 53, 718, DateTimeKind.Utc).AddTicks(4191), "$2b$12$AvuB1di4KI82oZMgS4ZJI.7FPu.te2GJ5kOINcmQ8/bqCu/v8hggu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 57, 190, DateTimeKind.Utc).AddTicks(5867), "$2b$12$HMQfG/0eObiSF8qw54RJj.Hp7UAVMC1VwDKTrKZCV1Tw8ywew2X9m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 46, 624, DateTimeKind.Utc).AddTicks(6326), "$2b$12$fSRpWOYgg6d3vZ0wkvD31.1Mmh0nxQBVXbn8RYVlQKWluzYSHKA/." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 49, 343, DateTimeKind.Utc).AddTicks(1575), "$2b$12$QJB59Vn6ZlHUVZ6mwqWUcOzkIH6QstMygIKtFMSHqXdYyNRZBVoA2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 56, 274, DateTimeKind.Utc).AddTicks(2678), "$2b$12$O4vs07POVV4YqZ/RwQduyuDTC7np0qfxsCcw4ybjThOdH4JqLK8Ca" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 45, 337, DateTimeKind.Utc).AddTicks(8213), "$2b$12$xDw4bWVSa.poSzbISL7WMuTiNheLEL5IRgDXEcoj/rHjACEgl6XFC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 48, 985, DateTimeKind.Utc).AddTicks(8127), "$2b$12$ZkGpZgX7T0kPF9D.o./kEuavLEFtlYVAOUxeqsVEqms.cj1HhwyDq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 45, 681, DateTimeKind.Utc).AddTicks(3021), "$2b$12$WKInrVq2d/OvI/rENtC17u3hyM9ZVLTrR9W/qyrrllKGkxqVaRjrK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 46, 12, DateTimeKind.Utc).AddTicks(3923), "$2b$12$vZiIQrAgFS2NU4gsTEyXhuyCkGA9zWudU0eMgpZLkN/2PLYxoTiOy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 47, 342, DateTimeKind.Utc).AddTicks(9729), "$2b$12$bMyEdkYsXxe9jnbQV0M3NeLc.95uAvyUpja40Y4tOnOTRzdCNEEV." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 50, 295, DateTimeKind.Utc).AddTicks(2490), "$2b$12$hTyvgS3jf1zHgmHMdpUrX.b8uZdbHymUTjFBExpgDgalBbvCB212S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 54, 998, DateTimeKind.Utc).AddTicks(1046), "$2b$12$8zygqZPGnDs8i6uZ/8fL6O846nKDNCWhSnUqv7DnYwiWyCk1Pl7j2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 56, 884, DateTimeKind.Utc).AddTicks(3649), "$2b$12$W.JrcERsoCXiqHwdcMkx5OyQwTJq5IO8W4zMc3.Djoc9K3AM1yqU6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 55, 966, DateTimeKind.Utc).AddTicks(7342), "$2b$12$2HrfjYstmbAgEQVhHtelMOk3KFtu08qbAilMUlOCnWzNY0AA8TCoq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 52, 488, DateTimeKind.Utc).AddTicks(5357), "$2b$12$8DCSYJlawu.IbOkifk613u6DkP4tgvU5wvSjCvwzXni7X/acXDy6S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 53, 105, DateTimeKind.Utc).AddTicks(976), "$2b$12$6xpnE2GlWga7WzX13DsORuj8VfJPXZKzQZzU1NakmOk/Qi2SXgIha" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 52, 796, DateTimeKind.Utc).AddTicks(794), "$2b$12$ViPz9vs3aAqRNIHNfY1maOJ8LWBoz7bOG3wsdeyAY.48arbsJ.D9." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 51, 528, DateTimeKind.Utc).AddTicks(7209), "$2b$12$WTBEff/TYZggjHBgDRUoNOuAXhNAfX1Oa5PmZny4Aw7SvrmB95Aam" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 55, 347, DateTimeKind.Utc).AddTicks(5272), "$2b$12$s1m9Ge5moCd6p5xIbck1X.5KWslGFLZIYUnZh2lEnbkJI8YtDAIL." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 51, 845, DateTimeKind.Utc).AddTicks(4344), "$2b$12$Y.t/t/nU0i3InOv3UJOXgOxo.shzNb99eeAiB5RRjrwvPeDh59DSq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 54, 24, DateTimeKind.Utc).AddTicks(9029), "$2b$12$HRD6BPIQbJx1HPLI0MmPYurPEPW.cCFqSt2gz6BaV5cExVK94tdLC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 55, 661, DateTimeKind.Utc).AddTicks(5283), "$2b$12$1rr2OI7OpGS27GOJNGOnLOJXFofXKjI3fRQC7n6GVt2wfD.CoMA3u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 49, 977, DateTimeKind.Utc).AddTicks(3212), "$2b$12$GoEVFU5vc6.q7k89Spx6yO03u4zW6LrwgUdAwVdjOT3SbdvQMI7e6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 47, 754, DateTimeKind.Utc).AddTicks(2050), "$2b$12$dyJ3FLRNgsLH2Yy70XP.yucuM6mJj2UgwZeuFEl6VQc1JJ1BE6vTW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 49, 670, DateTimeKind.Utc).AddTicks(7192), "$2b$12$Clyhl1bfQ.DxUWwUyLd8cuFDTzSYJbVR4fATPakQ7ckPhAEbFGlZS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 48, 678, DateTimeKind.Utc).AddTicks(4391), "$2b$12$jbxrxjdwN93KLG8zlzUr0uazxmm5JP7GK1.h6B.JmMy1FMDtDH.Xu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 56, 578, DateTimeKind.Utc).AddTicks(2660), "$2b$12$C.kPEAGdaiA9xuBdupw1R.mpBsfSxpygpO88Gv4CP5vFbiHFKGbxW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 46, 936, DateTimeKind.Utc).AddTicks(2062), "$2b$12$Rv6N7w/9gfmZ0uL9m8Cdqe/2aWyfNnq4qLSEaWZ0J.jhLAjT99sAm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 50, 912, DateTimeKind.Utc).AddTicks(8500), "$2b$12$eksnRmMSHLHSS1SfIsCJxe/Cscrn0mGgyG14DomYUO3W1dRJft/jG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 52, 179, DateTimeKind.Utc).AddTicks(8462), "$2b$12$pIS9neU/LqxmwDqpZFh0Q.jjVUzhEsGYDI/KG6jeX9BlTyksq7rHi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 54, 330, DateTimeKind.Utc).AddTicks(9514), "$2b$12$V1k/mkXy5r60JOvl7bBPKuko4aYz6CWEpIW7/arQ5m7EKqrhybPEa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 54, 636, DateTimeKind.Utc).AddTicks(5190), "$2b$12$WTqgXuM5fpCRi4FOkXnLW.CIYHkyT6lUdrwmIY.8kjnDvQQ3W7Ccu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 53, 412, DateTimeKind.Utc).AddTicks(2140), "$2b$12$IzwvPog3dWGAfAHmFSZNcucUJKNsVxuWxYcA8EXuURg3Gj11Z707a" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 51, 218, DateTimeKind.Utc).AddTicks(2844), "$2b$12$Q3Mmuq6iYdQjxenDl3RSqub163TAGi5hwefVKrYKkOjbRYE60Mdgm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 48, 370, DateTimeKind.Utc).AddTicks(9857), "$2b$12$nU8HNjFp.8MrP7w5e.ULyOIIWOQ9aI/A2Qc/caJ7eDwsyTReXa1SW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 48, 62, DateTimeKind.Utc).AddTicks(3591), "$2b$12$pWJNCoUQagN5oNjcASidtOzw9WA2sd3dJxCTezs/WVd2timrY/uNm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 3, 15, 19, 46, 318, DateTimeKind.Utc).AddTicks(1072), "$2b$12$jEJ2vvW3htkSEvDQTp2vn.qTb3S7JIKXTlml1qdp5UZmOuE.cQE1K" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
