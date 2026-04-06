using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddM1CNSNewGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "group_id", "academic_year", "name", "track_id" },
                values: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "2025-2026", "Groupe A - M1 CNS", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "03428ee8-3d9a-de72-c98b-dbc65724b005",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 48, 694, DateTimeKind.Utc).AddTicks(1977), "$2b$12$NxqV/ARMqLNb7yHgGRXSYOQazzxS4.wlQ5yRjsLSfKSD682LeYcJO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 31, 219, DateTimeKind.Utc).AddTicks(8595), "$2b$12$Y35b/pYGXZeMHelq5eL.R.6ivxYXxRV1aSm5GYAX9J7dgGM.ffq66" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 35, 778, DateTimeKind.Utc).AddTicks(9599), "$2b$12$MUvqtP5FxntcYwpwLRLvXOzJdl1ZVfy2u5CfUDjTW4mtqdyLUXwdG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 26, 936, DateTimeKind.Utc).AddTicks(4444), "$2b$12$zbh2Wgmc91vsJBNH1hVNIO6GwF83U8lt.JlkaHTg3WMJTDOPD28by" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 38, 898, DateTimeKind.Utc).AddTicks(8264), "$2b$12$EFrqLF4L7GuD1e1lHl.q9OfWtyZPONzi2REQEcaIVAfbPKgtQjRI6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 42, 283, DateTimeKind.Utc).AddTicks(5668), "$2b$12$tMp.igcEIiwwp04vjcd72eqjmAWNc4TVkvJKx7Gz6yuB217NApTWW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 28, 453, DateTimeKind.Utc).AddTicks(2088), "$2b$12$pkdkwV.jmX0z1hyXKdJ9auzu6nv1l4nXAq7fwunYmFoEeKYZ/WMv2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 46, 560, DateTimeKind.Utc).AddTicks(3947), "$2b$12$8186VT/S87mxeX3scpBc5eMJlGI03rJCPi1gHUbHr5OG9a3w6AOpW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 34, 475, DateTimeKind.Utc).AddTicks(5653), "$2b$12$FodbzpNQQ.VjpTyvYWHgKefY.gTBvnO.DnzLGNSHbL46Dr.ih.3ry" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "18241d26-a012-b189-957c-b5573ecb15d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 50, 848, DateTimeKind.Utc).AddTicks(2647), "$2b$12$RQrWgTrfvzg6TCXaaT2veeks8dSIcgiP7euveGMdHyY4/NV4CbXi2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 29, 368, DateTimeKind.Utc).AddTicks(7807), "$2b$12$D9gj5peLYN4HuRAXZXz8iOI8dmzpwbfTwrzf1NAGO73.zjpK2uA7K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 29, 996, DateTimeKind.Utc).AddTicks(6161), "$2b$12$pG4XsViTIUzupw50lWZl8eiSBrHgd9M7lzx.S0OKCqwT7ledrw00u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 41, 349, DateTimeKind.Utc).AddTicks(1638), "$2b$12$s/Wcj16knC2bffHpukL0TuML63AteXrA6yDWijHV12.9v6BnLISa." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3830d83f-4097-76e0-a9e0-b90ef45d1c79",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 51, 483, DateTimeKind.Utc).AddTicks(6654), "$2b$12$zEP/X1E1f3SonuzIzJcve.oSbvFYyUallmBv9mydqfKeo6hoU6V32" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 25, 994, DateTimeKind.Utc).AddTicks(1455), "$2b$12$5msbsc5GnKuf6o1C7x54MuOrweh..IxUr3dg2Xm..L1LhKTK.Zs8C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 34, 104, DateTimeKind.Utc).AddTicks(2492), "$2b$12$fG2F.8NMgS9uqYxr/hGniu6voZiwVxIMz58iBrDORq7kKY9WJLl02" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 27, 542, DateTimeKind.Utc).AddTicks(4610), "$2b$12$96EeBEDnVrdLyNuitVo.aOAD5Q8LDtThXmnKN7Pxq3wRyF4hMquYi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 27, 239, DateTimeKind.Utc).AddTicks(7610), "$2b$12$sTvfpylaDtajI7nr8VoQ9umXUfq4YTO3a1adW76JHvl47Vqmt71bq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4d41b3e5-536d-0aa0-a3e3-024218ac6267",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 45, 650, DateTimeKind.Utc).AddTicks(5101), "$2b$12$6F1K4CtHD2g9l.RE8ZlsF.bdCbkUVU7lZXDSbydie0gRnpuF9IF/2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "51432fb0-cda4-87aa-a2d2-e36c25823a2b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 46, 863, DateTimeKind.Utc).AddTicks(7433), "$2b$12$fdn4TJTPyM4IHCUVzPosfuB2oGedNTZf9E7FbvWQo0rRlJjTZSz4y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "52fb0554-7e57-01bb-5949-987520c91eb5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 44, 737, DateTimeKind.Utc).AddTicks(6273), "$2b$12$Hzcty4lOEZISQ1RiImbgx.I.GuvcHY1jqml7znVY8t/BikUH.lCbG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "557dd714-15d7-6df3-3ed1-22a2eec63c59",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 43, 504, DateTimeKind.Utc).AddTicks(4506), "$2b$12$x78Bfe6hF2iQSBwl2h1GC.gZZeOSFvlTQsbXSBeURPoim8GcCpAu2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "57f13355-ddb7-5d3c-b09a-ff2c56e22753",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 42, 587, DateTimeKind.Utc).AddTicks(7221), "$2b$12$bGKN05WeoLe5gK4QkhROB.jhP6FkkDqNH/OAYRsK62bBAObb1eLZ2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 30, 602, DateTimeKind.Utc).AddTicks(4943), "$2b$12$jjxhBMDBWUKcGF8YNrgPD.djqYesF/4tAs9vhNtVkW68aeM7ikbPW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 27, 845, DateTimeKind.Utc).AddTicks(5428), "$2b$12$uCjAF42nAIIFWa9U70LMIeLisvaL5pP3YcrYOcgPLhEgd2ksiKxri" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 32, 151, DateTimeKind.Utc).AddTicks(5276), "$2b$12$5liXtx8noaCDc8dJ8n/G7eKJhKwH0V0NL2neJgcqpcoObyxvvUdnq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "617cb820-a96f-5ce4-513e-f9de2ec06556",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 46, 257, DateTimeKind.Utc).AddTicks(2644), "$2b$12$qXsYpC7hf3Yj8.autGG2dONIDppvySYh5pai8f9wrpAvy16TnbjDW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 29, 63, DateTimeKind.Utc).AddTicks(8764), "$2b$12$G1fYTZWOge0qYTIE0p/a5Opu7cFYt.4CDc1KwwBE9L4ZEQU610lcW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "68fbd87f-0c94-976f-40de-323667ff06bf",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 49, 0, DateTimeKind.Utc).AddTicks(7636), "$2b$12$ro.Y.80Yc2bNR9Cx5luOluvMfagMLZW9HGVM9gogcQGWDRAnA0vk2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 35, 446, DateTimeKind.Utc).AddTicks(6198), "$2b$12$6CVdtLRBwHj3PqS/we1zBODDs3fRpj36/LIOlOQorN6Z4jc.o62K." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 40, 114, DateTimeKind.Utc).AddTicks(8918), "$2b$12$KFtrqyEXX7hSsWSACKYkku5pl8GvDX3Bw0HItm1Vig9JsB4H7xkYW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 44, 129, DateTimeKind.Utc).AddTicks(2731), "$2b$12$RhQMcxuFmEH0dn35aKxgveMCDu47rUlF87K2NTmq/fdXjR5t4l5NS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 41, 977, DateTimeKind.Utc).AddTicks(5521), "$2b$12$ceyzv/cr6b3P2MXL6U54JO37UJbo9jNKg4BmD0sC8B1NYKwvZ6r0." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 32, 456, DateTimeKind.Utc).AddTicks(8879), "$2b$12$bPObNRxPwywzq5I1SRTt3e0CXiVv42qUvAbP1RfR0bsfke1rVZJVO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8112e653-13fd-c47d-0fc5-7b36eda72bf0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 49, 936, DateTimeKind.Utc).AddTicks(7750), "$2b$12$UXRRgGEihSZXWnLHu3xPbuuCLQUas3AHlcdf.KEajXoNaMg04LvM." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 48, 387, DateTimeKind.Utc).AddTicks(1262), "$2b$12$jB7WFtC9h/s/GQLWsq/LA.fRX1mGcLjPfJio8AjgOLkedjZbYdqAe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 41, 27, DateTimeKind.Utc).AddTicks(8224), "$2b$12$rAqDVMHWy2JDppoz1wbLi.E.8NfFn6j79jxtOlz3CUrcgFE4bqptW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 37, 679, DateTimeKind.Utc).AddTicks(7287), "$2b$12$Ah/h.7z1N6GLfkP.IKnXA.PE195Mu9V8QimApzlQ8DxdsO6RKe.j6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e85356b-dff7-0fe0-9e0a-ac24101ff81c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 45, 40, DateTimeKind.Utc).AddTicks(7151), "$2b$12$ShmqaxrTcH9ML49w7lL.cebMfPn6sFHJVMN81.vI8XWNv6VIWoyNS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8ee02cf3-bf69-3090-c8a3-acd718cd445f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 43, 811, DateTimeKind.Utc).AddTicks(2995), "$2b$12$KKY2J/QZ5lFKhq6BU92pDeIvbhhdsVmIwCAt9DkdVI/nAzXcVaynG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "91f97c43-df32-927a-bb77-3f050c28c5d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 45, 346, DateTimeKind.Utc).AddTicks(7238), "$2b$12$HGeZ.iWjqi01rk8.3wsit.mPmUHHfP.vC/ZcFFL9ad.xZ4Apdh6H6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "954d4710-fb9b-9bc8-33d6-1a00378fef99",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 51, 154, DateTimeKind.Utc).AddTicks(3679), "$2b$12$PDsPwSXANxIcgPXL7O2i6O7uk8seXkzSIfS39k9Bn5OEMGkIdkkFm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "95755e71-293b-5fbe-2e06-ff9c6d90e96f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 47, 471, DateTimeKind.Utc).AddTicks(3971), "$2b$12$1YzrD8/LIt.7aLkLJffkcOVO9xNKKb/rqGnh3JFTCKALJh9h7pil6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "96cb69c8-c721-11de-8075-582c3bb936c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 50, 240, DateTimeKind.Utc).AddTicks(3749), "$2b$12$bPU/pmOFa.EOPWvd4rJUoOe/MoEnMwbsdPex.gAkJBQKUjkLSt3rS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 38, 287, DateTimeKind.Utc).AddTicks(7615), "$2b$12$CetHy89TIlmpOjua41u1m.CvSvnyY/N0CyM9/mqSdpfcnHCsJKn9K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 37, 984, DateTimeKind.Utc).AddTicks(3148), "$2b$12$/eaSJnvvIfxHl/ulGlUc8OqChA/NIFuIMILjSKoiJRS/fEjfldIRG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 36, 727, DateTimeKind.Utc).AddTicks(497), "$2b$12$Lh2Jc1gBVU4ozaszvyjZi.KY0WBNK9Zed3XKn7TP60iV1GX2X5tcS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 40, 417, DateTimeKind.Utc).AddTicks(7384), "$2b$12$Wj.oNgOna.z9b32h57umCuvSf8kAKcVshb23YI7kOfVeRHO5NiZbO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 47, 776, DateTimeKind.Utc).AddTicks(5592), "$2b$12$KU4T6Ay4Oa9zgubM1AsuZ.Lk6Wpc2KYkpuEF1OAEO6yRXZJ.FiKgK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 37, 46, DateTimeKind.Utc).AddTicks(6357), "$2b$12$WPwW25PQGUOQ1tsYw7PuqO/mTDHwc4EE.K2UO1UXV1kMI/I/N3/W2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 39, 202, DateTimeKind.Utc).AddTicks(6022), "$2b$12$4FB..Y9GJjPhuJmNJ4BQZ.51.45L5.22WEAW5MmGi.6Q1jI13/ho6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "aeba3eba-9c59-d115-5781-476232f36f4c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 48, 81, DateTimeKind.Utc).AddTicks(3973), "$2b$12$zosHAhLDUSH/Z3neSctZYO/SPEBn1RaV5lWMGebFxyHTmCwv1GF2e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "af142cbb-a95e-ab3e-f00a-a39f87004ec3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 42, 890, DateTimeKind.Utc).AddTicks(4583), "$2b$12$e4lXJkXsuILy/oVmIRMfQepN0nXlBX2ECCVE33na0PNDGXVWc7eSq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 40, 722, DateTimeKind.Utc).AddTicks(6295), "$2b$12$gw30i6QdISey4SRW01d3YuT4XhPKox2DpwT25F2gs6.UrxRdB1fNS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 35, 106, DateTimeKind.Utc).AddTicks(6971), "$2b$12$az.Sg4nawJyNgTTGa0kugOL5s2bmthyCczHEP5.8Z.7caOZsJA17G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 26, 321, DateTimeKind.Utc).AddTicks(3503), "$2b$12$Zc7SzLPKfNcC16Yu9DxjTO7QVj9dH/pDsD8n7h.6Mj71Io8rJ8/ni" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 32, 773, DateTimeKind.Utc).AddTicks(9428), "$2b$12$bgccH0R0Hd5EKUyd1LIw..lDPQkXG4JsGjXjDrLefzu0vuHung1pa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 49, 608, DateTimeKind.Utc).AddTicks(4942), "$2b$12$Z9jjsjwxy.vkHZBHsWxNWuuiuvh1wtXuGWOylGXYnP26Mq3xJDMt2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 29, 672, DateTimeKind.Utc).AddTicks(4111), "$2b$12$/6p6LBik0lImNTk4PiP0HOtwT2wJZjoF1ORpD0gd7VFLQjTGj7D9G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 34, 787, DateTimeKind.Utc).AddTicks(9664), "$2b$12$vDFfwjDMK3tYryIHh5fl9.RGb71nVBY8mUkXe6Ed1BuwnzLAYCT9m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 45, 953, DateTimeKind.Utc).AddTicks(7855), "$2b$12$LcJ2lQ54SWgsr4itJdeN7O3vTJ/5ic24U9I3DfNToCZGZ5wRapg56" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c2dd0d11-f58f-2546-c1ca-10b453a7bc96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 50, 544, DateTimeKind.Utc).AddTicks(4617), "$2b$12$jWJSlQ2aSGcbnxDGEFRB4OYVbg6wGHSLGzGLREHshNPDkyBV3xl76" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c668490c-dda2-f1b1-d170-72005fc34624",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 47, 167, DateTimeKind.Utc).AddTicks(89), "$2b$12$0RIX9cWbqJCaZslduVM1vORo5QmUeJXnqz7HVwOvdG/PA7N9M8Lwi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 33, 750, DateTimeKind.Utc).AddTicks(2765), "$2b$12$gEgCI/fw22xDBEx2gYETZO7o53fQVrcGjcWYcW2DkmoTrL9cqhFlG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c8936e2c-61ab-766a-1161-ed4577bda964",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 49, 305, DateTimeKind.Utc).AddTicks(5653), "$2b$12$GMr5UKAfN2S9y2Y6Dswe8.ETSJEaZ1vT2DWYY9TP361OZOrMrOk8C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 41, 664, DateTimeKind.Utc).AddTicks(5027), "$2b$12$S/jGd98nTmzIos2oPjJtcuqdmQXJgpTebspgL83akn9dNIAPT.XJC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ccd1db56-b977-3035-ca07-0d16377dbbe1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 44, 433, DateTimeKind.Utc).AddTicks(9810), "$2b$12$fEDppNCZygiFTKvczHXgU.DdV7y/z5IDw1oiIWsdyZSMVun7m7Aq2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 30, 299, DateTimeKind.Utc).AddTicks(5942), "$2b$12$dDqfsYAuPu8OQXrRGUJoEuNh8ep9IF4Gpju1oUHormRftoLqVpxiG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 28, 757, DateTimeKind.Utc).AddTicks(7803), "$2b$12$D/uOAbXyQPqHrVZEWluuB.8yb/qPIONpTszE9h4iJR1fCfXefihgS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8924a08-9bc1-e88e-8396-1a1e86e2276b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 43, 196, DateTimeKind.Utc).AddTicks(2423), "$2b$12$hTIloyh/r85bS6yVVXewOO2Zx/m/jT.TcQO6LvyF4XWQAG8k87WZy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 36, 84, DateTimeKind.Utc).AddTicks(4614), "$2b$12$4J.rFRBVH5oy8JYM8PCnBe0Tk2Ouwa4iF3kQ7iBMF3.hmAU7qO62q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 26, 632, DateTimeKind.Utc).AddTicks(8123), "$2b$12$5y2mBd0rmzdHL1qJ20W60.9/JSC8Mk56xYes50qZkZqQQwK2irAF6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 37, 353, DateTimeKind.Utc).AddTicks(7449), "$2b$12$bQmE3bPkE3BCa/WzetnZauOmSKlzW2Wz/usF8ETRoA.uet27sG2yW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 30, 905, DateTimeKind.Utc).AddTicks(7310), "$2b$12$mYL6aCzbGeG.SiTtfrTfh.mtVnJ7UMnvXM4ahC5/P94bx0wMiIXHy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 39, 506, DateTimeKind.Utc).AddTicks(6541), "$2b$12$foaO0iDn6bet5DJdOWGLD.sbNnj.5m3UQYbah/pVVleeC5H5RNitK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 39, 812, DateTimeKind.Utc).AddTicks(1243), "$2b$12$8TnoutM9T5bo74wJBXFrqebbznU.2VMBnCYqxASDfyvEayorSFUby" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 38, 594, DateTimeKind.Utc).AddTicks(1302), "$2b$12$jQBUP66BiETnfEU5NL/OOulwnqoGtydmcFran6Ort2xHFvIzq8Q8u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 36, 413, DateTimeKind.Utc).AddTicks(8798), "$2b$12$/DvL/3et4tK0xIODZhvbL.I6e1tnwOjaPGFy5MMFzoMa0i0cLU5ma" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 33, 446, DateTimeKind.Utc).AddTicks(90), "$2b$12$ZRGlT0xqjZ7hrRvDJOCJIugsESLfU5WVorKZCe1UndxfGreHKP2SK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 31, 847, DateTimeKind.Utc).AddTicks(2417), "$2b$12$DqR11hzsteLsPuc4hqnOTeD1KXzY64C5okiXBcsOuot74kWTihD2i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 31, 541, DateTimeKind.Utc).AddTicks(7847), "$2b$12$SvJ65EUJ0IKrQuEvhn.kM.TyneaZsG90Nbm4zsi9R4ZEypL9MNYNe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 33, 114, DateTimeKind.Utc).AddTicks(8177), "$2b$12$H5KtMX8GjYheJzV1.mpeyO8hRb2ytNDow1s0mYp5bxXuqvOvgl/s." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 28, 149, DateTimeKind.Utc).AddTicks(4358), "$2b$12$BDgGNcoIsbowkCl44rWuOuzvPvl4vT6wsES5MwPjum6l1Ghxzk8IO" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "user_id", "created_at", "deleted_at", "email", "first_name", "last_name", "password", "phone_number", "UpdatedAt", "user_role_id" },
                values: new object[,]
                {
                    { "011f7dd9-fd3a-3d41-6190-1f4489c299e9", new DateTime(2026, 4, 6, 11, 16, 57, 916, DateTimeKind.Utc).AddTicks(2566), null, "studentc21@etud.fr", "Bilal", "Varet", "$2b$12$QeukJPZ490ilZd4hvXSdiu8WvPTE1EAcTfsP1V1QBzugAIPyKB48S", "0630000021", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "0a3f73e7-67a8-750c-576a-49c22125bac7", new DateTime(2026, 4, 6, 11, 16, 59, 441, DateTimeKind.Utc).AddTicks(7409), null, "studentc26@etud.fr", "Sara", "Amrani", "$2b$12$rKF7yUZL0Cu/zglvLMx47u/YoNet5UFF8484zBBc6BSWGxPjlmtoK", "0630000026", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "0b48ba68-2d76-43aa-8392-7b40b1aa1e19", new DateTime(2026, 4, 6, 11, 16, 56, 93, DateTimeKind.Utc).AddTicks(3001), null, "studentc15@etud.fr", "Samy", "Perron", "$2b$12$0kNNb8DLDMAu1QUgzjci3./xWsmfhGYl5OXYVvOmWw8K1AMbBHwSe", "0630000015", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "129452cc-6c9b-3726-5c96-54b67ac3b884", new DateTime(2026, 4, 6, 11, 17, 0, 366, DateTimeKind.Utc).AddTicks(5105), null, "studentc29@etud.fr", "Ilias", "Djebar", "$2b$12$7WnF8ExCS2nvLpLoG5ojwOtkv1EsGgzGTVcwZlCAcX27hyEG6mgB6", "0630000029", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "288bdacf-8acb-a8d1-59f9-94f0cccb2086", new DateTime(2026, 4, 6, 11, 16, 54, 569, DateTimeKind.Utc).AddTicks(3181), null, "studentc10@etud.fr", "Nora", "Kassem", "$2b$12$Rb/36VPTT1vub6FTex5wOOTb.ClSnnGFsc9KsxqzbM2VqLvk5IC5G", "0630000010", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "2b5c3a92-dc35-b1bd-16c3-b0f8a21f29f6", new DateTime(2026, 4, 6, 11, 16, 52, 399, DateTimeKind.Utc).AddTicks(5007), null, "studentc03@etud.fr", "Nadir", "Daoud", "$2b$12$UWL7vCgpS0NOmFZA7PDH5.K3hghGOiwPU8uQyaQ.JsAubgkwIM19y", "0630000003", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "2fa22e35-4eb2-7351-ee0e-a523ac305c44", new DateTime(2026, 4, 6, 11, 16, 56, 700, DateTimeKind.Utc).AddTicks(8368), null, "studentc17@etud.fr", "Hicham", "Rami", "$2b$12$nEy7kBlT3auJmFziLPCMAu5zJSXSJ3tOzXEiNmcH8yFB7mdDgUuOG", "0630000017", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "373399d1-2bd2-aee5-629b-43f96da8f03e", new DateTime(2026, 4, 6, 11, 17, 0, 59, DateTimeKind.Utc).AddTicks(1228), null, "studentc28@etud.fr", "Nour", "Chami", "$2b$12$xKR2B.pSSVi1dw05T46ofOzy9LYXibNoA3d.IpAbnHighSBxvgEHG", "0630000028", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "3769412b-799f-6b72-f74f-9b9b735058c2", new DateTime(2026, 4, 6, 11, 16, 53, 313, DateTimeKind.Utc).AddTicks(5483), null, "studentc06@etud.fr", "Sofia", "Ghali", "$2b$12$G6Hbn0B30F8YkTRpfJ7lj.UNNzUENo4HSzHECQZ0VY0KM.NHKqwM.", "0630000006", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "476292a1-d3ae-cacd-a58c-2d14790da8eb", new DateTime(2026, 4, 6, 11, 16, 57, 309, DateTimeKind.Utc).AddTicks(7588), null, "studentc19@etud.fr", "Adel", "Tahar", "$2b$12$ESR3cB6MVZ3Up.j52/d1b.EI6LSY7KewQx46ksIQ/9oskBX7MNfa2", "0630000019", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "539ead07-d571-367b-79f7-68b21513886b", new DateTime(2026, 4, 6, 11, 16, 55, 789, DateTimeKind.Utc).AddTicks(2290), null, "studentc14@etud.fr", "Lina", "Ouali", "$2b$12$A0owvPDqvBhqekWkgNYPleE2nyaGAGMmXFFiDUcrfWc27m.21SWTu", "0630000014", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "62f48843-9c38-a162-72b9-af6d09b80de3", new DateTime(2026, 4, 6, 11, 16, 57, 4, DateTimeKind.Utc).AddTicks(8015), null, "studentc18@etud.fr", "Leila", "Saber", "$2b$12$nPppQLoBYGclgO9ra.nXAuhRPQk/Tb6XyqR5FEkaFYD.MJB1FSN1W", "0630000018", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "65aa7c04-2529-20cc-46f7-47c22df3e1d0", new DateTime(2026, 4, 6, 11, 16, 58, 524, DateTimeKind.Utc).AddTicks(2898), null, "studentc23@etud.fr", "Anis", "Xavier", "$2b$12$93TgQI4YdTsjnFwVmGcd7.TwVcNrKLabMZ40LaJBISXeeowyz6Fle", "0630000023", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "6dcd090f-508b-7888-b458-17aeea49123a", new DateTime(2026, 4, 6, 11, 16, 59, 751, DateTimeKind.Utc).AddTicks(3334), null, "studentc27@etud.fr", "Tarek", "Bouzidi", "$2b$12$0KzSjAzI3K3VFCCfCEvbh.p0OwGVxSzKWrRex9TlzQ4lhVKNA2YB2", "0630000027", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "6e5a0735-7928-5aca-b192-5e455fca402a", new DateTime(2026, 4, 6, 11, 16, 51, 790, DateTimeKind.Utc).AddTicks(9381), null, "studentc01@etud.fr", "Amine", "Belaid", "$2b$12$UMrjlWQ3pM.F/zYMvU1JTueY0nqRE5rNWXhXkVnWkYuUALMM7glL.", "0630000001", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "8976fc22-4f3c-f5a6-a6d7-81058525ac85", new DateTime(2026, 4, 6, 11, 17, 0, 670, DateTimeKind.Utc).AddTicks(7224), null, "studentc30@etud.fr", "Rim", "Essafi", "$2b$12$V7rkt5eEQ1NHScLgdrPjHei2qToCGk1iMpu6j24np/UKaafcIBIs2", "0630000030", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "8b8636d1-c1b0-1104-ebb5-a8e7e20d35ae", new DateTime(2026, 4, 6, 11, 16, 56, 396, DateTimeKind.Utc).AddTicks(8788), null, "studentc16@etud.fr", "Aya", "Quinet", "$2b$12$9ThIocQEA.kPacTM7Hciteyo8.O0O8ie2oHUBwYIsTii3EgTjKqpq", "0630000016", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "953715b4-1d71-3023-7048-42579385f359", new DateTime(2026, 4, 6, 11, 16, 53, 617, DateTimeKind.Utc).AddTicks(613), null, "studentc07@etud.fr", "Rayan", "Haddou", "$2b$12$fScyXFEO4aCv14YX5nyHfeghpZ3uW6wdiSPV1kEqo77faSU7aKqzW", "0630000007", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "9dd3d6be-aadd-a804-775f-b0817d3508fc", new DateTime(2026, 4, 6, 11, 16, 55, 181, DateTimeKind.Utc).AddTicks(4547), null, "studentc12@etud.fr", "Meriem", "Mabrouk", "$2b$12$SxjlV4y2T.NtndU4WiDmq.WF7WsBk4/liTqvXt5we.FO5wgCnsVDK", "0630000012", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "9f3e92f6-ee55-979e-23b7-f713245738cd", new DateTime(2026, 4, 6, 11, 16, 54, 874, DateTimeKind.Utc).AddTicks(6522), null, "studentc11@etud.fr", "Youssef", "Lahmar", "$2b$12$gA1Wx1eA6m/wsyvVyoqGmeyEb8hDvjycA1c5wBI2ryG1COteZACYO", "0630000011", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "a70a25e3-1d3d-3e25-2f6d-c728283dce2c", new DateTime(2026, 4, 6, 11, 16, 58, 218, DateTimeKind.Utc).AddTicks(6033), null, "studentc22@etud.fr", "Salma", "Wahbi", "$2b$12$lBPoCCx2/u8MbQiK6j/4/.7H0U2/T0IeUwd4FdhA4qDzi/jxaWTTe", "0630000022", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "a81af79f-d5c1-b515-0d1e-fe2dbabc780d", new DateTime(2026, 4, 6, 11, 16, 55, 485, DateTimeKind.Utc).AddTicks(5693), null, "studentc13@etud.fr", "Karim", "Naceur", "$2b$12$ajwRugkbltnjfZOvTOomg.bcc5e/PGEcLdGMkvA7a.32G540RzuVi", "0630000013", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "a894def6-b00b-6103-0ac7-92aa2bf2a079", new DateTime(2026, 4, 6, 11, 16, 53, 930, DateTimeKind.Utc).AddTicks(9458), null, "studentc08@etud.fr", "Ines", "Ibnou", "$2b$12$sBlfNfhY.5TTMDqntyErdesgfEmVFY02gF86p/bJcRppLDW6sUkOa", "0630000008", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "ada69e11-1e1e-3387-80da-a6afa8505ba2", new DateTime(2026, 4, 6, 11, 16, 52, 704, DateTimeKind.Utc).AddTicks(5846), null, "studentc04@etud.fr", "Mila", "Elmi", "$2b$12$CdLlBO27YG731Y/GpWLBn.FMG20q4ycp7VjACfV2eeAAPyzI5pa2S", "0630000004", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "afa4fe08-4af6-cc2b-778f-115de345ebba", new DateTime(2026, 4, 6, 11, 16, 58, 829, DateTimeKind.Utc).AddTicks(7101), null, "studentc24@etud.fr", "Nesrine", "Yala", "$2b$12$hhy3TYAJQjkxl981/czKsu9RAIazUdsNOQYPrdjRqiFj9HdlLpYoW", "0630000024", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "dd288475-9710-eabb-7cca-449e335c3070", new DateTime(2026, 4, 6, 11, 16, 52, 95, DateTimeKind.Utc).AddTicks(9713), null, "studentc02@etud.fr", "Yara", "Cohen", "$2b$12$ql4aMIrBi2eXlf6xt/p/3etEzWdFrmfOnfSO.XLqqHnmjOsKyf8ga", "0630000002", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "e48c4173-bb79-99df-4cdb-550c4acb9bfb", new DateTime(2026, 4, 6, 11, 16, 59, 135, DateTimeKind.Utc).AddTicks(5302), null, "studentc25@etud.fr", "Imad", "Zeroual", "$2b$12$c2DXrDG2BWbvI8OhAPG1W.YKuA319KZpOz2GsK5zzdU0oxTLmUSue", "0630000025", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "ecd9a403-0fa0-120e-0580-76ac458c1397", new DateTime(2026, 4, 6, 11, 16, 54, 242, DateTimeKind.Utc).AddTicks(8409), null, "studentc09@etud.fr", "Walid", "Jaziri", "$2b$12$tpAtraTyhq6ejhv1tSh6n.2AMBMa62BQMW.wybbuNnPI4Te3HZ8Ve", "0630000009", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "f0af01b8-a5e4-18f8-889c-4863d1166ca9", new DateTime(2026, 4, 6, 11, 16, 57, 613, DateTimeKind.Utc).AddTicks(3626), null, "studentc20@etud.fr", "Maya", "Ury", "$2b$12$233CT5JMK5NMHSzuWkPhVOzyzh/omlMlR54N3noNuXjG8uuhdUTIW", "0630000020", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "f828e1ce-18e1-0c76-9535-92a277f7875a", new DateTime(2026, 4, 6, 11, 16, 53, 8, DateTimeKind.Utc).AddTicks(4900), null, "studentc05@etud.fr", "Ilyan", "Fares", "$2b$12$/P.f1kdeEmgwJqZBMXACWOyLyUWtlUAY6kiZohjv30Mr5SD4Yp6om", "0630000005", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "user_id", "group_id" },
                values: new object[,]
                {
                    { "011f7dd9-fd3a-3d41-6190-1f4489c299e9", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "0a3f73e7-67a8-750c-576a-49c22125bac7", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "0b48ba68-2d76-43aa-8392-7b40b1aa1e19", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "129452cc-6c9b-3726-5c96-54b67ac3b884", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "288bdacf-8acb-a8d1-59f9-94f0cccb2086", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "2b5c3a92-dc35-b1bd-16c3-b0f8a21f29f6", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "2fa22e35-4eb2-7351-ee0e-a523ac305c44", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "373399d1-2bd2-aee5-629b-43f96da8f03e", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "3769412b-799f-6b72-f74f-9b9b735058c2", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "476292a1-d3ae-cacd-a58c-2d14790da8eb", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "539ead07-d571-367b-79f7-68b21513886b", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "62f48843-9c38-a162-72b9-af6d09b80de3", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "65aa7c04-2529-20cc-46f7-47c22df3e1d0", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "6dcd090f-508b-7888-b458-17aeea49123a", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "6e5a0735-7928-5aca-b192-5e455fca402a", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "8976fc22-4f3c-f5a6-a6d7-81058525ac85", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "8b8636d1-c1b0-1104-ebb5-a8e7e20d35ae", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "953715b4-1d71-3023-7048-42579385f359", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "9dd3d6be-aadd-a804-775f-b0817d3508fc", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "9f3e92f6-ee55-979e-23b7-f713245738cd", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "a70a25e3-1d3d-3e25-2f6d-c728283dce2c", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "a81af79f-d5c1-b515-0d1e-fe2dbabc780d", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "a894def6-b00b-6103-0ac7-92aa2bf2a079", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "ada69e11-1e1e-3387-80da-a6afa8505ba2", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "afa4fe08-4af6-cc2b-778f-115de345ebba", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "dd288475-9710-eabb-7cca-449e335c3070", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "e48c4173-bb79-99df-4cdb-550c4acb9bfb", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "ecd9a403-0fa0-120e-0580-76ac458c1397", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "f0af01b8-a5e4-18f8-889c-4863d1166ca9", "e61277a9-9d07-5b53-e623-528bf88a6962" },
                    { "f828e1ce-18e1-0c76-9535-92a277f7875a", "e61277a9-9d07-5b53-e623-528bf88a6962" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "011f7dd9-fd3a-3d41-6190-1f4489c299e9");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "0a3f73e7-67a8-750c-576a-49c22125bac7");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "0b48ba68-2d76-43aa-8392-7b40b1aa1e19");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "129452cc-6c9b-3726-5c96-54b67ac3b884");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "288bdacf-8acb-a8d1-59f9-94f0cccb2086");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "2b5c3a92-dc35-b1bd-16c3-b0f8a21f29f6");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "2fa22e35-4eb2-7351-ee0e-a523ac305c44");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "373399d1-2bd2-aee5-629b-43f96da8f03e");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "3769412b-799f-6b72-f74f-9b9b735058c2");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "476292a1-d3ae-cacd-a58c-2d14790da8eb");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "539ead07-d571-367b-79f7-68b21513886b");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "62f48843-9c38-a162-72b9-af6d09b80de3");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "65aa7c04-2529-20cc-46f7-47c22df3e1d0");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "6dcd090f-508b-7888-b458-17aeea49123a");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "6e5a0735-7928-5aca-b192-5e455fca402a");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "8976fc22-4f3c-f5a6-a6d7-81058525ac85");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "8b8636d1-c1b0-1104-ebb5-a8e7e20d35ae");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "953715b4-1d71-3023-7048-42579385f359");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "9dd3d6be-aadd-a804-775f-b0817d3508fc");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "9f3e92f6-ee55-979e-23b7-f713245738cd");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "a70a25e3-1d3d-3e25-2f6d-c728283dce2c");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "a81af79f-d5c1-b515-0d1e-fe2dbabc780d");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "a894def6-b00b-6103-0ac7-92aa2bf2a079");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "ada69e11-1e1e-3387-80da-a6afa8505ba2");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "afa4fe08-4af6-cc2b-778f-115de345ebba");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "dd288475-9710-eabb-7cca-449e335c3070");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "e48c4173-bb79-99df-4cdb-550c4acb9bfb");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "ecd9a403-0fa0-120e-0580-76ac458c1397");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "f0af01b8-a5e4-18f8-889c-4863d1166ca9");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "f828e1ce-18e1-0c76-9535-92a277f7875a");

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "group_id",
                keyValue: "e61277a9-9d07-5b53-e623-528bf88a6962");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "011f7dd9-fd3a-3d41-6190-1f4489c299e9");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0a3f73e7-67a8-750c-576a-49c22125bac7");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b48ba68-2d76-43aa-8392-7b40b1aa1e19");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "129452cc-6c9b-3726-5c96-54b67ac3b884");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "288bdacf-8acb-a8d1-59f9-94f0cccb2086");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2b5c3a92-dc35-b1bd-16c3-b0f8a21f29f6");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2fa22e35-4eb2-7351-ee0e-a523ac305c44");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "373399d1-2bd2-aee5-629b-43f96da8f03e");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3769412b-799f-6b72-f74f-9b9b735058c2");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "476292a1-d3ae-cacd-a58c-2d14790da8eb");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "539ead07-d571-367b-79f7-68b21513886b");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "62f48843-9c38-a162-72b9-af6d09b80de3");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "65aa7c04-2529-20cc-46f7-47c22df3e1d0");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6dcd090f-508b-7888-b458-17aeea49123a");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6e5a0735-7928-5aca-b192-5e455fca402a");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8976fc22-4f3c-f5a6-a6d7-81058525ac85");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8b8636d1-c1b0-1104-ebb5-a8e7e20d35ae");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "953715b4-1d71-3023-7048-42579385f359");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9dd3d6be-aadd-a804-775f-b0817d3508fc");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f3e92f6-ee55-979e-23b7-f713245738cd");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a70a25e3-1d3d-3e25-2f6d-c728283dce2c");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a81af79f-d5c1-b515-0d1e-fe2dbabc780d");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a894def6-b00b-6103-0ac7-92aa2bf2a079");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ada69e11-1e1e-3387-80da-a6afa8505ba2");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "afa4fe08-4af6-cc2b-778f-115de345ebba");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd288475-9710-eabb-7cca-449e335c3070");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e48c4173-bb79-99df-4cdb-550c4acb9bfb");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ecd9a403-0fa0-120e-0580-76ac458c1397");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f0af01b8-a5e4-18f8-889c-4863d1166ca9");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f828e1ce-18e1-0c76-9535-92a277f7875a");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "03428ee8-3d9a-de72-c98b-dbc65724b005",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 56, 478, DateTimeKind.Utc).AddTicks(5176), "$2b$12$YGcxL79SVEgxux89cMuCqeY.6PA0.SXPjVDq/SB.vNn9XTeMhnm06" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 39, 212, DateTimeKind.Utc).AddTicks(165), "$2b$12$zfwNZQKacrdDof9glAxhz.byvqPJQ3p3akpM32N4Y6HXqxVCtsDW2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 43, 546, DateTimeKind.Utc).AddTicks(9613), "$2b$12$JZ5La8XiZT6Y/za.q7JcJ.oW3kEDuh775K/S9u2hlu3nkZKLPP3kS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 34, 889, DateTimeKind.Utc).AddTicks(4718), "$2b$12$0q9G/J3YOdnzEWqp8t8fj.9uLfqcgpIa.SAKD9X/jE2vz7.YIaSr." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 46, 601, DateTimeKind.Utc).AddTicks(5515), "$2b$12$6m8bux7eBCuqMtd6AGfhYOGT4WcxFwascFNPURV9OzdEmjMvNgpFy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 50, 29, DateTimeKind.Utc).AddTicks(208), "$2b$12$hPyEdECKQrz72oKYCbsiQekwkgbLalZul2xqA7Kz6Mrq8gRfqpx8." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 36, 432, DateTimeKind.Utc).AddTicks(4178), "$2b$12$SP6fG5p4UesljaFetqNMAumpJjkA70KE/pnZ59NIHQLV2BF/pScqm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 54, 348, DateTimeKind.Utc).AddTicks(5395), "$2b$12$TW3AbZWSKvFMrVh6UeeV.uJRvmfJDNaQPIMSca72kYBwdxHH.CVcu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 42, 291, DateTimeKind.Utc).AddTicks(6537), "$2b$12$wFjXesdw5yePyTKUhPzcguECWHcg9kgkNCZQZ8KcHyrlrQOByP.ce" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "18241d26-a012-b189-957c-b5573ecb15d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 58, 642, DateTimeKind.Utc).AddTicks(3247), "$2b$12$8XDUdFKGBnNrb1HbsYlnGOb2Yef0zGwgMCWcCgLYB/MbFZVUW4O9q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 37, 361, DateTimeKind.Utc).AddTicks(4826), "$2b$12$fCSo91E8bExZAimV6nRtsekHocN1.4Gs1nj.Enzquom7Oopbijz/W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 37, 978, DateTimeKind.Utc).AddTicks(8143), "$2b$12$DsOD7OapvGhyfNp60IkahuRzH09pBx0oxNp7f9e/vlEGjy4uBS1G." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 49, 44, DateTimeKind.Utc).AddTicks(5057), "$2b$12$Hbj00n1u2UzLpRkD/qYKJezA1G1kKmaTtfqxA6xAas07Tpm7HsYl6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3830d83f-4097-76e0-a9e0-b90ef45d1c79",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 59, 254, DateTimeKind.Utc).AddTicks(1909), "$2b$12$qgGTsgNyVvr2PaSZVWqio.Ru4b9PI01MNztdmi39aH1vpQ2v9UPVS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 33, 929, DateTimeKind.Utc).AddTicks(4522), "$2b$12$m.xDpyp09n6deug/ORUUC.99cU0QTMCr4HNKwA5QLX/hZZeNk5RZi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 41, 977, DateTimeKind.Utc).AddTicks(373), "$2b$12$qR6XcAEuzUbsJdOhdaxh4u2b1pXKUKIxNw.Ej2nTyOYGbj8XcNkTu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 35, 491, DateTimeKind.Utc).AddTicks(5371), "$2b$12$scbOJaR8f5BSVD9fiLdi4.W7hNyRi5AexJrAynFF6okGfJbTJnIWq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 35, 191, DateTimeKind.Utc).AddTicks(5870), "$2b$12$M/JSROoK1evdwDLZ/u38OuHPj3qFbgHTSMaWIBnEEVWpZduxJm3VS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4d41b3e5-536d-0aa0-a3e3-024218ac6267",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 53, 424, DateTimeKind.Utc).AddTicks(9511), "$2b$12$MKvYOGvwfUg3mEeKEkDZKuPJ3wLFIHteR4SF94ccVnMw/oE/Ksjwm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "51432fb0-cda4-87aa-a2d2-e36c25823a2b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 54, 653, DateTimeKind.Utc).AddTicks(814), "$2b$12$RqRQV6jjXm.n9NBmeZ25d.SLqAlCkVITrdnOM406nQFbUoMXSrAqW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "52fb0554-7e57-01bb-5949-987520c91eb5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 52, 508, DateTimeKind.Utc).AddTicks(6966), "$2b$12$nu3ysv/MZsMM2optbfbKyeThCbkNCARNW3N2G16Km2b/xD4dvkb1m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "557dd714-15d7-6df3-3ed1-22a2eec63c59",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 51, 258, DateTimeKind.Utc).AddTicks(623), "$2b$12$.06FYA9wKBjGVjnXA7qPGuLLj0DP4OJlgGwDace.G6KotbpBTopv2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "57f13355-ddb7-5d3c-b09a-ff2c56e22753",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 50, 337, DateTimeKind.Utc).AddTicks(2022), "$2b$12$W5uEXdI5ryNBH/mZUsg2WeYUd8sNls2oW2gCO0S8o.kwpEeN2N9ke" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 38, 601, DateTimeKind.Utc).AddTicks(2927), "$2b$12$buRE8hgmyog9OB.hcDW9euvyifs..Vuo7xI389PQDMtdTWlfeuJlG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 35, 817, DateTimeKind.Utc).AddTicks(638), "$2b$12$yQ30cyCCkZiAo0xnUFt.luESWs.SdozmMnAiiD92dpKfYnvUyfnPi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 40, 150, DateTimeKind.Utc).AddTicks(7914), "$2b$12$vDUVOxGXXekTEWwWpJtws.nn7cSC8RdjirxKcwwxqCl1vknwaz6ay" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "617cb820-a96f-5ce4-513e-f9de2ec06556",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 54, 31, DateTimeKind.Utc).AddTicks(5892), "$2b$12$D7uNMQydRi1B.dk2Rsvw4OgyACTFxC4Bci9FQi2sEyX4oayPY.1/C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 37, 44, DateTimeKind.Utc).AddTicks(2026), "$2b$12$eEr8iV/LUHkHcV/pqKxxk.Py74rLPC9Wug8oMtvloQ3XQbAFP2cau" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "68fbd87f-0c94-976f-40de-323667ff06bf",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 56, 783, DateTimeKind.Utc).AddTicks(7839), "$2b$12$H/V7.p.wJxouW4X0S2J.4.nu77YWGDbiCJhJ/.DqFYW3TJ.NXuOEu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 43, 241, DateTimeKind.Utc).AddTicks(8290), "$2b$12$HtE9K9PAd3pOrCqw1iWGpuIyaPiFtZKr8DRilSqc17AilXg0Hb2ZG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 47, 819, DateTimeKind.Utc).AddTicks(7446), "$2b$12$1/KoiKQGdJ1ZIc.JBZZ8W.1cTN9kdkaG6b2sOWw3KzZtn.akaSM2u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 51, 878, DateTimeKind.Utc).AddTicks(665), "$2b$12$5xJ8honw3y5uQwO277QlheinhjCjSql/7syZLFT7FUPpLHTsig//q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 49, 703, DateTimeKind.Utc).AddTicks(6234), "$2b$12$QMByNQKq4Gd2CYNlrInfr.jcdqR1hdvym2Nbq9ZH/HGN5uqF9kaMi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 40, 451, DateTimeKind.Utc).AddTicks(5728), "$2b$12$tAfy5U1XUm3JI/m2Q4BLWudRr/ASFPORRQ9jy9iDDmUjSyZwq.t3O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8112e653-13fd-c47d-0fc5-7b36eda72bf0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 57, 700, DateTimeKind.Utc).AddTicks(8942), "$2b$12$A.T1Cp5thdlfiM7s75khAO75VCjEmQcJBAUK.O5c3pH7f.jrgCGge" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 56, 173, DateTimeKind.Utc).AddTicks(7845), "$2b$12$gXISabXkxYKFLyR1klQi4uyBkYx4A1n2NhgzRsqTjpmkwLR60QbPq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 48, 739, DateTimeKind.Utc).AddTicks(5004), "$2b$12$sLEPIzR8kpCWEzvKpc/liu/NtwLvMvQGOPmD2ZcyDpRLAv44fbqqS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 45, 385, DateTimeKind.Utc).AddTicks(94), "$2b$12$yYtxKPlzVFgP8h4TSIm3dO.0WH.Ln1zqQxJfkV4U4NYr2hQoqw.8G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e85356b-dff7-0fe0-9e0a-ac24101ff81c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 52, 813, DateTimeKind.Utc).AddTicks(5918), "$2b$12$fqaZJdjPgk6Vp2SYHUj.3eWeNfOHuqtu2TXEU9QjlnaYpkN9CeCui" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8ee02cf3-bf69-3090-c8a3-acd718cd445f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 51, 561, DateTimeKind.Utc).AddTicks(4751), "$2b$12$3QpdBvdCX2vAP6bcmQlxc.Pq4bQf26gWCtf8DH7PvH1lPzaR7zBwq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "91f97c43-df32-927a-bb77-3f050c28c5d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 53, 121, DateTimeKind.Utc).AddTicks(5302), "$2b$12$ZV41oE92UnS2HAUovQZ3n.r4nlyCljeEryIXMCfzmYSD9fiLRUkIy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "954d4710-fb9b-9bc8-33d6-1a00378fef99",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 58, 948, DateTimeKind.Utc).AddTicks(3417), "$2b$12$Z3tHPcgaHPytuHf2EeB5Y.ZJRGl8rB2cMlwLVaTGxqbfcIxqHoWaW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "95755e71-293b-5fbe-2e06-ff9c6d90e96f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 55, 261, DateTimeKind.Utc).AddTicks(6003), "$2b$12$sDDiOt98XTXFa4.TR6EkUuA46a7ySH.nxECUrs57ieqyjX.RiyWiG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "96cb69c8-c721-11de-8075-582c3bb936c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 58, 14, DateTimeKind.Utc).AddTicks(729), "$2b$12$L/ziy55OwtcJORRQ8/8dlOqfy8LWQYjTp0Re3hPfqUgw2jR2oQB5G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 45, 992, DateTimeKind.Utc).AddTicks(1123), "$2b$12$Mt66Y0fDq3dfMqF75Uua4ehR0FqbCEbAMiu1xBwheBMJ0s12xyFGG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 45, 688, DateTimeKind.Utc).AddTicks(7298), "$2b$12$5mmfRjNfbAT7cl03oAME8ewE2.Vn5GfX0sL4q2GB3mie0pJtjSNsK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 44, 461, DateTimeKind.Utc).AddTicks(4103), "$2b$12$sleDF6LtRdPyIw459Vf2/Oa2QiQ9Z8jVY7V9UIj.PhxenLpYlrm1i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 48, 128, DateTimeKind.Utc).AddTicks(5850), "$2b$12$r52VsBdJOCqalWT3DeCKpeWXRvxMKYo71k/4gWPY2QW0JGxakDpbe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 55, 565, DateTimeKind.Utc).AddTicks(7285), "$2b$12$JxKuQen5B4r/yUnkOFIpi.aefY0LN3yMrgn1laMB.kC3CNLmjtMly" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 44, 774, DateTimeKind.Utc).AddTicks(9091), "$2b$12$suesakG4upTDLEtICNEKou2grRuyDW4ubkCBN8rmdTy5olIG1hU/O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 46, 906, DateTimeKind.Utc).AddTicks(3266), "$2b$12$lWbVCGS.hZst3F0o9cwOZeUhQO9/1flbp1HCDK8wM99r5DUwCQFse" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "aeba3eba-9c59-d115-5781-476232f36f4c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 55, 870, DateTimeKind.Utc).AddTicks(4937), "$2b$12$XzsNnGgaupcBkGBu8TNGneKyC3VjJ4pqNqGctMVHD8Fn/xnYOmSui" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "af142cbb-a95e-ab3e-f00a-a39f87004ec3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 50, 645, DateTimeKind.Utc).AddTicks(7176), "$2b$12$A4w4WP0ggYhXDxBxKO9i0u6iaStuPUMBgmeVdNqjIllSVAaLVZ.DS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 48, 434, DateTimeKind.Utc).AddTicks(9178), "$2b$12$nhG4dXdv92qK6.qfqJYOH.HB.ptia6uWpAbatuPvurBrFsSGs5Lte" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 42, 936, DateTimeKind.Utc).AddTicks(2705), "$2b$12$eck5fM0.5qgB7H7x/BUw1utXPNYdUwlYItiTJN6K4zHYMGbrZ71Dm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 34, 262, DateTimeKind.Utc).AddTicks(5270), "$2b$12$dsdTFrvZWosBkOgP4MGzdOKjf5GQ95VpiXdCqb6CkMw5w4hLuzqgW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 40, 756, DateTimeKind.Utc).AddTicks(1576), "$2b$12$OC8ggsvxuasJRy1DMeT9yOb7TwdhY9.W9gxn3wjaqCoYRHmmHxTgy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 57, 395, DateTimeKind.Utc).AddTicks(3633), "$2b$12$XEIX7h.fNdauHLzM4wvnR.Ep5C6sPcYSltPNkmgVS9GhiW2Ea7.za" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 37, 666, DateTimeKind.Utc).AddTicks(3230), "$2b$12$FPY3dQqSBBNyHmwpD9sFZOYE64.Hn74NLDkshDuE9EUzGsva3HNzO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 42, 631, DateTimeKind.Utc).AddTicks(1725), "$2b$12$Ibt.MvugmHFOGHwU/732te2yhcWjIzTWVcFn5bnm1p/BXImGYYrNC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 53, 728, DateTimeKind.Utc).AddTicks(2022), "$2b$12$Eq35zIfVPavnv1nFKf3l7uJUXCuFKsnaAWBb1gS5nIqqKS/LrNyLi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c2dd0d11-f58f-2546-c1ca-10b453a7bc96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 58, 333, DateTimeKind.Utc).AddTicks(7343), "$2b$12$aXuA52Lj6AlbfZ8bE.AVvui3ROyPegZpvklyWAsbVXuU3EbH0aUqW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c668490c-dda2-f1b1-d170-72005fc34624",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 54, 957, DateTimeKind.Utc).AddTicks(8230), "$2b$12$FBbmxErmtzuYvrJzkjeAw./nojQ5NPmlCkfYLUFua8ZTkKhcUqRJi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 41, 669, DateTimeKind.Utc).AddTicks(4375), "$2b$12$zWNuzUIF4nN2vlB5TiC4uOLwREKazr7LHlYgRI8wuXzJwDqXfea6y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c8936e2c-61ab-766a-1161-ed4577bda964",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 57, 89, DateTimeKind.Utc).AddTicks(5617), "$2b$12$CWW3qtPSIC4WiFC.vD0QeOZy0fgBpKoMa/SPsAALlAtRovVdZc/Y." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 49, 349, DateTimeKind.Utc).AddTicks(4522), "$2b$12$TF8UMyDgIUg47xKmlWvvO.3HD6VYR2wJ9pkQ4EZUvZj0I7cEcbLlC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ccd1db56-b977-3035-ca07-0d16377dbbe1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 52, 185, DateTimeKind.Utc).AddTicks(113), "$2b$12$Zs.X6Aorq1Dza4nxF.lxZ.Gu6D7hVfQSzqd59itLJrNXewY8gMFVu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 38, 292, DateTimeKind.Utc).AddTicks(9153), "$2b$12$l9HpWznc3kuyiNED4bFuoOPWbru039gPsmcfwf8GH8Nt48Fll2vN2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 36, 740, DateTimeKind.Utc).AddTicks(3012), "$2b$12$os6Jv81GBIvoZK/VIP70yOUksIEgjF8.Pwo6/Af5RT501UZApA97u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8924a08-9bc1-e88e-8396-1a1e86e2276b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 50, 952, DateTimeKind.Utc).AddTicks(4191), "$2b$12$wcGy68zVOjqGA3s2YCc1OeyLyyqMveyO9goaOq/cC1bsPRxEOKOaS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 43, 851, DateTimeKind.Utc).AddTicks(4757), "$2b$12$cq0aiUkqUzlfdqCGX7jj7.fvfW0Hm2Kp88mj6Y68sC6BU/8p0zCxu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 34, 582, DateTimeKind.Utc).AddTicks(8206), "$2b$12$lV6Zb2DePEoFZRiR9gU9VeWOiIb0mbUP/H1YqaX6HkfwZowa5iuJu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 45, 80, DateTimeKind.Utc).AddTicks(6943), "$2b$12$XZXafM4WRjfOX22eRIY3GeuycHeBbWdElCVZIncXkavCkYTU4SPz." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 38, 909, DateTimeKind.Utc).AddTicks(6461), "$2b$12$JEexXGYwoL2rJU9x0oRShOb/HxmtSmd6jKuEA5kAuVMibny0cVb42" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 47, 211, DateTimeKind.Utc).AddTicks(480), "$2b$12$KQYmJXCvlcL51a0PN9yzUu8D1kkgbWN.GI7rBIH4YwBxouZrVd0Zm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 47, 515, DateTimeKind.Utc).AddTicks(9474), "$2b$12$eWoLK2zAK.XunUu9VF2TwORwySWYsM22MVHXOn4O4D5itm9m1n1Ne" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 46, 296, DateTimeKind.Utc).AddTicks(5592), "$2b$12$GiuzR/Lk9hHYzLO05LtpLOucQa9agCC/ec7euuCf87P6zWZBwPL3O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 44, 156, DateTimeKind.Utc).AddTicks(91), "$2b$12$EC7R1FNreEajejmYtyuTr.u.ZAmmOoRClLKM2kvxQ9neFc.HtUlZ2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 41, 365, DateTimeKind.Utc).AddTicks(8948), "$2b$12$xcH0ds2DSL6eOAfkzlu1eu70HeuVTpUFzOpd0MZDK4WnEOz7JM50q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 39, 846, DateTimeKind.Utc).AddTicks(2470), "$2b$12$mHkukUznNgkH8j3qbzlBweE8wkWVt7QrljTvyIXc5.8CQC44c3.yO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 39, 514, DateTimeKind.Utc).AddTicks(7010), "$2b$12$EbuwcdcI/PUNENnuF4whQuRK4XJt.iAM/yX3Ch/vkDRx9rmcKrJcC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 41, 62, DateTimeKind.Utc).AddTicks(2719), "$2b$12$xYWgLxJVtFoQlEVtkfXjt.LnvEoMGITRPuFKvnq.PpAW0oBCHGa7y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 39, 36, 124, DateTimeKind.Utc).AddTicks(3628), "$2b$12$sO44bC4CmHLJXV1/YBE82.m6h8rioymov6zq3.UM58y/are7BFwL." });
        }
    }
}
