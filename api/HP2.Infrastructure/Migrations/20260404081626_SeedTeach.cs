using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedTeach : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teach",
                columns: new[] { "session_id", "teacher_id" },
                values: new object[,]
                {
                    { "3701bc4e-401e-f4f3-00aa-b37659789636", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "54166d2e-0d4d-7e23-3a55-ecde2614bcfa", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "885f671e-9801-9aec-86eb-3fe1cb1db365", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "a5129120-7dfa-797c-3e24-99056723ec39", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "e823715d-0a77-1379-9289-b44b55c10267", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 20, 74, DateTimeKind.Utc).AddTicks(8622), "$2b$12$b2rP7rDZCavlDWMWT6Jx/eUTOp6MnCgJwWXkYpTIrolWQHQ9SvC7S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 23, 177, DateTimeKind.Utc).AddTicks(7939), "$2b$12$1tZHQx8mYT70gtCF.ldvC.iMFnVgPm/26CAuBDE0w6bfGvzf7EifW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 26, 570, DateTimeKind.Utc).AddTicks(164), "$2b$12$pb1Hwln.zArxKMlh8KVcCO1dKOeWEhiUADdINt68wvgD0VrBiovcq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 16, 281, DateTimeKind.Utc).AddTicks(1629), "$2b$12$Fv8J3IGY5t25vDEV/c9Ceust9oLkgtW11HbgbBtg3RoPd0XCG54xe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 18, 860, DateTimeKind.Utc).AddTicks(2056), "$2b$12$B0HTOzcvkgYau.dFk0IbmOG5N22FxbwBZyW.CPF1ap.QT6vR.Ybl6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 25, 644, DateTimeKind.Utc).AddTicks(4788), "$2b$12$H2aLNgmx61cDCbmPzKyUseZ2lq3uztFo2H9ZjyhM1G.U/EnNaNQ7i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 15, 11, DateTimeKind.Utc).AddTicks(5049), "$2b$12$lXypE.8cdgwYdmyZQF5yb.7PW6Yy08NbcCLyq.6PwY2i.WYWTcnLq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 18, 551, DateTimeKind.Utc).AddTicks(6155), "$2b$12$UmjETpRAWtQBKCz.cKvelOWdbvhQgbkmLGLtJ6sRWFis5R3RMGig2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 15, 356, DateTimeKind.Utc).AddTicks(4287), "$2b$12$Dtls9yDRTmyp8fwoUuOA0.MZhvrQ75vAjloX4Fp83aSOqILtZkp4i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 15, 660, DateTimeKind.Utc).AddTicks(4746), "$2b$12$5EDSqQUuudmuMOi/PR4GKOD/SLw584ihpXatu5IDzgMSD7scdKOva" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 16, 935, DateTimeKind.Utc).AddTicks(2894), "$2b$12$N.T11tUKkA/0jG1Gm4GVjuzjFtJ8n692LuOEQS.MQTLxZheI.Yw0u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 19, 771, DateTimeKind.Utc).AddTicks(896), "$2b$12$QX/c9EPkcSpc0aCMcpKvQ.wsG7V5zsdtKsIe7eO9NhSYnuEAJ1Duq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 24, 409, DateTimeKind.Utc).AddTicks(3082), "$2b$12$ftiZ9wCbSbf8hLxHDFdrce6MMDMFjLJYkcq5wYQrLI3v2mH9Y8Es." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 26, 264, DateTimeKind.Utc).AddTicks(1307), "$2b$12$JDgEAGWnixHGDdVsdR9wf.R7vcK0wExthsSVmOexjCuveKq4rinfS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 25, 338, DateTimeKind.Utc).AddTicks(234), "$2b$12$cn5M/kDjCQVsCDEJhyV6xeIkmqy4loTfpIRAmDS5fFSytLrmarOTy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 21, 953, DateTimeKind.Utc).AddTicks(5667), "$2b$12$./9dlu3RuIDfhPK2B4MQ8.01L9Ciq5KwlypOxSqNHQE/OnqRDLnTm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 22, 558, DateTimeKind.Utc).AddTicks(9420), "$2b$12$CWUzMd2yTsHNi1UGnXoOyu.Tn2DQD5/XWCMvxOZ.g1N47s9OTNNY2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 22, 257, DateTimeKind.Utc).AddTicks(649), "$2b$12$2Wxr20aClXofBGNLUyLLt.bHZbBQslS9sPWoLo/05IKT3jBDmQ6mS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 21, 36, DateTimeKind.Utc).AddTicks(6241), "$2b$12$xXJFDP6O7P7VTLcn8IdFzOKUbPppAYGVSwbpdzoAaRUAF2VcsB26e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 24, 719, DateTimeKind.Utc).AddTicks(7617), "$2b$12$dUIFBBfiP4zpmP1TDW6QcOWemEhXpazh1MSqGHdbCqvDLQOFWZx52" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 21, 349, DateTimeKind.Utc).AddTicks(4583), "$2b$12$xrd8jz9IisUaoG4zan0OZenxpD6NWIWbNwz6ZYh2nHfqLYn7L73NS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 23, 488, DateTimeKind.Utc).AddTicks(2506), "$2b$12$8EC0gBpVdOS9QrsGMg0vfOv8C7/79f6dcspNxsd1JLsF6Lz9QJEkK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 25, 31, DateTimeKind.Utc).AddTicks(6615), "$2b$12$vugTR10k.g/3iUC1WkIXjOTIDUqAqEYKuHDaNWKzZAimPS9RkSH8." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 19, 464, DateTimeKind.Utc).AddTicks(5760), "$2b$12$P.z2by835MFHA2TuJjwKAez56SQ1uajnStM1iCWLkxIyYQS36mSjC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 17, 294, DateTimeKind.Utc).AddTicks(5969), "$2b$12$QbfhayHecGsIUyll32yzneR1FChF8s6Y1Pvg5JNL7K//4GVv36PYC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 19, 162, DateTimeKind.Utc).AddTicks(1544), "$2b$12$VxQEwzk.9SdUq.XzBiANdepASniUNSpxNkOVicZT5//WR6P9wZMa6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 18, 209, DateTimeKind.Utc).AddTicks(681), "$2b$12$kYqhQT28amfQDtble0JgeO02FtYEJAqdmwCrOQrEuoOdGDIEf4Zl6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 25, 949, DateTimeKind.Utc).AddTicks(7901), "$2b$12$V5afxYV.JZ5JeP7bO0VQfuDtO5dFdKz.6FJQIo9nEsEnqXLcGMnXm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 16, 620, DateTimeKind.Utc).AddTicks(7739), "$2b$12$vLJTy1qA.AXJg0RnMS2AZuLgKolYWROXUPtLfR8IrYxmm522rcmVu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 20, 380, DateTimeKind.Utc).AddTicks(6952), "$2b$12$cUy30iEl8rJ.bAxPcnj/VuV.7lK01GfYqVN06RVoXG5Y7ufa5PtlO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 21, 652, DateTimeKind.Utc).AddTicks(5711), "$2b$12$S6MVUDkPonStxDRq6LozHe1rpf2jr9n5RGOf8JfwdE4.artuHJdwq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 23, 794, DateTimeKind.Utc).AddTicks(4205), "$2b$12$P4ZGCa06LDuXgi3aJa2PGey/.KiTaQbL6547cTIQT.GdmxY/0qfKC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 24, 99, DateTimeKind.Utc).AddTicks(459), "$2b$12$xOyXsbrk0BLb/2R9piDUZeTWh5Qg7di3n0SPsOYYmPQRnLSMpVHxm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 22, 861, DateTimeKind.Utc).AddTicks(4236), "$2b$12$XaU890D47o7SCIKwvk55TuGxtsEfXowIKiYXcK/wl7D8OmUw4epO." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 20, 727, DateTimeKind.Utc).AddTicks(1850), "$2b$12$n3T/6nS854BvLlksmKKCk.n6/yfvT5rp2eCK3KrQFHvIVeX7YyFh6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 17, 905, DateTimeKind.Utc).AddTicks(4363), "$2b$12$viwmpsrFh/l9Up5WrKns5.y7q0t2J4QAREWRRCgf3g0Tqul/C7CDC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 17, 599, DateTimeKind.Utc).AddTicks(9805), "$2b$12$F8kqkT1ctrTrsdbz3LrXKuHbIfHVO5/5jTVI5rGRll8J0Lc8GsH0y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 15, 967, DateTimeKind.Utc).AddTicks(304), "$2b$12$NR9yeYviD5rJBDEjqn0UB.rqq0YIKcB5rDtdx.28lFMR6r27VZwfa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValues: new object[] { "885f671e-9801-9aec-86eb-3fe1cb1db365", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a5129120-7dfa-797c-3e24-99056723ec39", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e823715d-0a77-1379-9289-b44b55c10267", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

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
    }
}
