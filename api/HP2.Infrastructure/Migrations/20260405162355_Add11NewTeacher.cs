using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add11NewTeacher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "06de430f-a2f4-2726-ed59-0b529c0f9212");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "25c5927d-2e94-3504-cc8b-b152458283c5");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "41b30632-4fff-68ec-eead-cbe9e1e29c21");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "5f0e72d4-dff0-6c21-0efb-2673d678e2cd");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "84aa27d7-b4e9-19f9-ff67-3a2552c2a271");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "9025faff-feb9-c61e-d313-1a54ee26ba74");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "a50d2256-7cd0-f15b-df98-fb145013efb8");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "a729b2ea-33b2-c65b-f414-20830e2fe2a4");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "cdca56f1-aaae-3153-50bc-46f83e7a32ff");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "e75bca39-4aea-e853-add3-a481192e7567");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "fb1372c2-a5e9-32fa-26af-ceb6c3e9f791");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "06de430f-a2f4-2726-ed59-0b529c0f9212");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "25c5927d-2e94-3504-cc8b-b152458283c5");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "41b30632-4fff-68ec-eead-cbe9e1e29c21");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5f0e72d4-dff0-6c21-0efb-2673d678e2cd");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "84aa27d7-b4e9-19f9-ff67-3a2552c2a271");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9025faff-feb9-c61e-d313-1a54ee26ba74");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a50d2256-7cd0-f15b-df98-fb145013efb8");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a729b2ea-33b2-c65b-f414-20830e2fe2a4");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cdca56f1-aaae-3153-50bc-46f83e7a32ff");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e75bca39-4aea-e853-add3-a481192e7567");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fb1372c2-a5e9-32fa-26af-ceb6c3e9f791");

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
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 16, 23, 40, 609, DateTimeKind.Utc).AddTicks(8998), "$2b$12$nfBD3jxRsl0e7wM9O.DK2.hrXkWOUTMRRFi1Sjyj.74BsaGrLApwO" });

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
                table: "User",
                columns: new[] { "user_id", "created_at", "deleted_at", "email", "first_name", "last_name", "password", "phone_number", "UpdatedAt", "user_role_id" },
                values: new object[,]
                {
                    { "041d01e0-b34f-4331-85d9-9453132f67b6", new DateTime(2026, 4, 5, 16, 23, 44, 35, DateTimeKind.Utc).AddTicks(1168), null, "julie.paul@univ.fr", "Julie", "Paul", "$2b$12$zj5E/56AA0Tv4.sx5I3y7.9v6iBcoDABpr382etNNdSH6znFc83hK", "0134567801", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "1dbea3b9-23c2-3605-d494-ca1c7124c184", new DateTime(2026, 4, 5, 16, 23, 42, 145, DateTimeKind.Utc).AddTicks(3429), null, "celine.robert@univ.fr", "Celine", "Robert", "$2b$12$P/Xogx1VUO96dOarJMBAq.wAm27sey6bLXq385rbSL36QKrjxU40C", "0134567895", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "26d3840f-0826-0efe-7045-e23034efc8cd", new DateTime(2026, 4, 5, 16, 23, 42, 751, DateTimeKind.Utc).AddTicks(4527), null, "amina.cherif@univ.fr", "Amina", "Cherif", "$2b$12$yKG4sEDk9bz1VP6WoKeHS.V3XfR9pGBtbeQLJItwuEMSlGO4rQVwW", "0134567897", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "59bf4bd2-f6ce-9fa2-7070-b362983f9148", new DateTime(2026, 4, 5, 16, 23, 43, 358, DateTimeKind.Utc).AddTicks(8115), null, "elodie.guerin@univ.fr", "Elodie", "Guerin", "$2b$12$BhfRMn6S9KwTcK9qi3uJ0eDvQZv7wXoxgFhzjUgTlrd3r5kXlWDEy", "0134567899", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "606137a2-9de4-e505-00ba-117bc0f24b82", new DateTime(2026, 4, 5, 16, 23, 45, 25, DateTimeKind.Utc).AddTicks(5227), null, "antoine.mercier@univ.fr", "Antoine", "Mercier", "$2b$12$a7peq1POQxZ32Dh1mLSir.HNhXeLPNEmZFfTpisbOUkKT2T2zTCwW", "0134567804", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "7ac11e50-5cbb-c818-9b31-5e91770eece0", new DateTime(2026, 4, 5, 16, 23, 45, 332, DateTimeKind.Utc).AddTicks(65), null, "nawal.haddad@univ.fr", "Nawal", "Haddad", "$2b$12$zr8siEvEjRK5GrhVIDnwR.0hPOVVj6T7TjBSTPRiCaOtB6aTE0CGi", "0134567805", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "bde95391-58fe-5b55-3f3a-b92d9fdcc75d", new DateTime(2026, 4, 5, 16, 23, 42, 447, DateTimeKind.Utc).AddTicks(8112), null, "maxime.legrand@univ.fr", "Maxime", "Legrand", "$2b$12$2E6IOIf0Y5uuiifG9WEhqO8kL53Yw1SDuY1gpcLoij1KsggOYcwY6", "0134567896", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "d5ccafec-e254-50d8-39ec-9d9684f49b5e", new DateTime(2026, 4, 5, 16, 23, 43, 55, DateTimeKind.Utc).AddTicks(7051), null, "nicolas.fabre@univ.fr", "Nicolas", "Fabre", "$2b$12$NmLav6dhLojAI8iIDhvscuJvUblD5rtwWpw.HngxB./xg7XptCxmy", "0134567898", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "de87aa7f-ad79-cfc9-2c65-6648889c76fd", new DateTime(2026, 4, 5, 16, 23, 43, 691, DateTimeKind.Utc).AddTicks(8342), null, "mehdi.kaci@univ.fr", "Mehdi", "Kaci", "$2b$12$KkSa93EX.2/d4xKc678WiO1bQIDvS6czFnztojTglXTGXvj0NVjbG", "0134567800", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "f8360932-cad7-22ba-add7-d31883af9229", new DateTime(2026, 4, 5, 16, 23, 44, 693, DateTimeKind.Utc).AddTicks(1302), null, "samira.bensalem@univ.fr", "Samira", "Bensalem", "$2b$12$8pr4F0iUR3zQ3leN4NeZqORNc13rL4YZ7PFYVJcMJzmwJmdJzb19i", "0134567803", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "fc422d79-4d66-9bc0-c3be-19d5b2cba234", new DateTime(2026, 4, 5, 16, 23, 44, 364, DateTimeKind.Utc).AddTicks(83), null, "adrien.morin@univ.fr", "Adrien", "Morin", "$2b$12$AUpOa942Qb.FNtxuNTt0suml9vFiXU31u3tDEKkeZGSn3KgtZrsRu", "0134567802", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "user_id", "registration_number", "teacher_title_id" },
                values: new object[,]
                {
                    { "041d01e0-b34f-4331-85d9-9453132f67b6", "REG_013", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "1dbea3b9-23c2-3605-d494-ca1c7124c184", "REG_007", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "26d3840f-0826-0efe-7045-e23034efc8cd", "REG_009", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "59bf4bd2-f6ce-9fa2-7070-b362983f9148", "REG_011", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "606137a2-9de4-e505-00ba-117bc0f24b82", "REG_016", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "7ac11e50-5cbb-c818-9b31-5e91770eece0", "REG_017", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "bde95391-58fe-5b55-3f3a-b92d9fdcc75d", "REG_008", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "d5ccafec-e254-50d8-39ec-9d9684f49b5e", "REG_010", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "de87aa7f-ad79-cfc9-2c65-6648889c76fd", "REG_012", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "f8360932-cad7-22ba-add7-d31883af9229", "REG_015", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "fc422d79-4d66-9bc0-c3be-19d5b2cba234", "REG_014", "85279958-5b39-6e84-7c57-09f2a0174fa9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 11, 462, DateTimeKind.Utc).AddTicks(3437), "$2b$12$frpmgMI3oqo8E6DwrHMKw.2yqeuxESNGlGKDdKEHsEro1JX6VQvBi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 2, 927, DateTimeKind.Utc).AddTicks(4190), "$2b$12$Y0wr22NjyX.UiKXitN2wXO9eDAcCGwgZ9gx8eGqTEEJrzNm9Ny0Q." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 14, 704, DateTimeKind.Utc).AddTicks(1835), "$2b$12$Sygr13P.lzg04fILJ3KNmuk4yfyXKcVMNEJBcTiaqK4HRG/0GyZGu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 18, 289, DateTimeKind.Utc).AddTicks(679), "$2b$12$2fHcOXOW/1M4/QJ2NBi8VOlMp/rqjTeBMUDm.FOYhGUhvTnxJH7yG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 4, 422, DateTimeKind.Utc).AddTicks(344), "$2b$12$gsRMpb7/0HaEXgYniVjrROvRdgpA4M4d46MmxH6vFLdhioFi8nRRS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 10, 192, DateTimeKind.Utc).AddTicks(1493), "$2b$12$3ifdp08/gD3dxC5KskFb7O.fLNmr0W44KlytIIWbkzq5.GDMg/Dt6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 17, 346, DateTimeKind.Utc).AddTicks(9165), "$2b$12$QxbeoW11gV07nW91pLIC4uuD5INCsiEmAprukD8hivnsDAnb9HUOO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 1, 995, DateTimeKind.Utc).AddTicks(8933), "$2b$12$dWFzGTXcymb.hkGKXD7j/OqezkpODHySc.y0iumgtswj94kfmjfwu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 9, 891, DateTimeKind.Utc).AddTicks(5346), "$2b$12$.utFkWzBZaXgtzl/LObQi.OhB2C5cmTHk4HJUliaztSJEHzyhdbVS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 3, 524, DateTimeKind.Utc).AddTicks(7988), "$2b$12$h4yl6f5E9Xo/z5l2sYKmR.jGKyH8rfNG1gXCdJVdxyU8H/6ebq/im" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 3, 226, DateTimeKind.Utc).AddTicks(1219), "$2b$12$9txXvnJmieJAx3MI56BTXeFR.gMLSVzBFo4/1ERhj1oc5IzddOQj." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 3, 825, DateTimeKind.Utc).AddTicks(2853), "$2b$12$DskYjlqyMPPq0kM0manXHeZPvaOqjhiHX6Rf.qu1dx.JWEE/SZtjS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 5, 27, DateTimeKind.Utc).AddTicks(5364), "$2b$12$8pvykFZ7WlSLvAVZtdys5exT1CIAAGY4VlLOIOjDcZUiI/5WyqJiG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 11, 156, DateTimeKind.Utc).AddTicks(838), "$2b$12$uxRxd5zQKcIlr7CFCCdq8.gy4/gMVKFjWsOjXBgymZWe67cgbiCbu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 16, 64, DateTimeKind.Utc).AddTicks(2364), "$2b$12$8Qcz8Zw3P02b8wR5i5ZgPuVxOTONp6pZaWTZ84xIlEmvilvMyP56O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 17, 976, DateTimeKind.Utc).AddTicks(581), "$2b$12$IZdDdDxluAkwM.YkfMKjMuOB1zHKcXWhKhQK3bsT0rgyLXUBDm0.." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 17, 29, DateTimeKind.Utc).AddTicks(6364), "$2b$12$Wcg/vYTYe8eBb2ZyLn6nlOdn12xhRhxuViNfELK8x4pZg59Fq2SMi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 13, 462, DateTimeKind.Utc).AddTicks(749), "$2b$12$79YjoX0dx92DPVM/oYqU8.o7Yeh8PaiYwKFYstFKFBFZ.nStZ/YOe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 14, 80, DateTimeKind.Utc).AddTicks(4019), "$2b$12$VCY1p2Xr6L/4cRQ6zM2gwuJkPbnTDF4L9J62MbkANj98QlLHay4F2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 13, 775, DateTimeKind.Utc).AddTicks(8637), "$2b$12$UcFMiNCi8ii7SG/EezjNBO69DEBaUO8Q.5pNwvZFGAFye1CwmHmgW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 12, 392, DateTimeKind.Utc).AddTicks(9362), "$2b$12$RTSdZjnnh3TKYVxKcyTvDOOELq5LcGvSQmfzzLEpSiwLD1C8LviJ2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 16, 385, DateTimeKind.Utc).AddTicks(368), "$2b$12$y7eodZ35crQW0GT2wdAvY.aRfxaJV7Z8lQ/FBQwncH5MORyF./xv2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 12, 731, DateTimeKind.Utc).AddTicks(4682), "$2b$12$nuVU0i5MS46IKqvbuW30luIZcfDAME6N9jctfKJ6IMoYIp2pEqZaq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 15, 97, DateTimeKind.Utc).AddTicks(2264), "$2b$12$Yce4YsMOtewqx3qD0jeHZu2dxOjrNBKE3ri67IizSr9usjfHIDTCW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 16, 707, DateTimeKind.Utc).AddTicks(8749), "$2b$12$m4pv/zgXxZnVd2qmJt6sNOVAfJd3ryWANEg.CbFvD.EuxPC/PsAly" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 10, 844, DateTimeKind.Utc).AddTicks(6686), "$2b$12$Gnl.iZTK04MXS7MBDTn9HuAn2mzudfN4J68MLRofnI44seBUYMy1u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 2, 299, DateTimeKind.Utc).AddTicks(7284), "$2b$12$RiNgNY2f0cs2Y3p4fvD18uz4DO..2SedrwuUlCgIlxJWMoloBdc1a" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 8, 668, DateTimeKind.Utc).AddTicks(4700), "$2b$12$RVsIe/BiB0Pnd/sdHWR9ce4xmhra6ES0I/uwRZ6P2rc701d7gHYfq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 10, 508, DateTimeKind.Utc).AddTicks(6361), "$2b$12$FNzHMnZOlkx5E58aay6Lt.UTuW1wluTl1L8mvKLc15d7ztn4mmwT6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 9, 590, DateTimeKind.Utc).AddTicks(5146), "$2b$12$JhmBsJellFFjrBWQXCy.m.upIhaLyVEACnRtYRE8T5If0uO60CqOm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 17, 658, DateTimeKind.Utc).AddTicks(8937), "$2b$12$maFKJmuO/gjFyJ0bTVyUt.S2fOu6LCT39AVtBtR3x2Kpu/UyDxol2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 4, 723, DateTimeKind.Utc).AddTicks(4367), "$2b$12$RaS7voqbwgPKJwjD2St3i.y7A6np1/3kPfHgbA.W6SO7hruJCRtwi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 11, 775, DateTimeKind.Utc).AddTicks(9647), "$2b$12$eWx0fr4w.ia/rh9D25reD.ZKjLS0AsomGWg2wmyANI3Am0yV98QJG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 2, 624, DateTimeKind.Utc).AddTicks(1020), "$2b$12$wOc3/nqp4T4EiebaOFPA9esTNeySf92wEPwXIAF02gu3f/LjIzZ7." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 13, 126, DateTimeKind.Utc).AddTicks(3279), "$2b$12$gjBJ56x8GXD1yhW6DKIsNufTqd/riEortHE6CAeUw7W7eIPBLxHj2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 15, 449, DateTimeKind.Utc).AddTicks(2164), "$2b$12$EHiwHZJGpdhezMG1NXO/GO1Ln2L2YkdazijbMp1L5QQDCsxS0DUsa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 15, 753, DateTimeKind.Utc).AddTicks(1332), "$2b$12$8WypS2JpjZxYwELaLKzXaOJU/Vya2tltmh0sMf1V38rGA1881nxMO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 14, 386, DateTimeKind.Utc).AddTicks(3609), "$2b$12$75fwXonPBgMryLSA.a9f3uNLnQ9KNkezBtfiznw2B8lWRH2W2Ty72" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 12, 84, DateTimeKind.Utc).AddTicks(7102), "$2b$12$4HTd/eEs8WkB2yzTwhNwiukluDtX/B6eSY8LQYvHyauan3vTSfL6C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 9, 263, DateTimeKind.Utc).AddTicks(4568), "$2b$12$So0QZNEapoDjoh6v.OVjEuOMFbxP1P7wVSfFm3VBbQnbgtoMgu3q2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 8, 966, DateTimeKind.Utc).AddTicks(2095), "$2b$12$AHJsFEtSpx2/f0CobHiSs.qjRuFXw3Q5ESrIsO0xA/MLwDAkhOzI2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 50, 4, 123, DateTimeKind.Utc).AddTicks(8055), "$2b$12$DmMqPiGIQwVcGCchDWBtku5eZXzfkFISysxC6Ml.VyxAmmNtIfwiy" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "user_id", "created_at", "deleted_at", "email", "first_name", "last_name", "password", "phone_number", "UpdatedAt", "user_role_id" },
                values: new object[,]
                {
                    { "06de430f-a2f4-2726-ed59-0b529c0f9212", new DateTime(2026, 4, 5, 14, 50, 6, 847, DateTimeKind.Utc).AddTicks(2346), null, "nora.aitali@univ.fr", "Nora", "Aitali", "$2b$12$45ojZtgwZ5hmaQ7oZ7muOOzxh7Ly3lYhKjLN2eoYq3kaULa7Xl/RS", "0134567900", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "25c5927d-2e94-3504-cc8b-b152458283c5", new DateTime(2026, 4, 5, 14, 50, 6, 244, DateTimeKind.Utc).AddTicks(3324), null, "camille.renaud@univ.fr", "Camille", "Renaud", "$2b$12$3auS5r5QdizYKn.ia.hrQ.v.dfRhcTnwxHoVGUBgtKrTcULOzSfbC", "0134567898", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "41b30632-4fff-68ec-eead-cbe9e1e29c21", new DateTime(2026, 4, 5, 14, 50, 7, 170, DateTimeKind.Utc).AddTicks(4723), null, "hugo.lefevre@univ.fr", "Hugo", "Lefevre", "$2b$12$Zs0oyDeLM1RJgnZI9fGpteb6Q8uH1DjBO8llvVHb6af09Hh/jjej6", "0134567901", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "5f0e72d4-dff0-6c21-0efb-2673d678e2cd", new DateTime(2026, 4, 5, 14, 50, 5, 637, DateTimeKind.Utc).AddTicks(487), null, "laura.petit@univ.fr", "Laura", "Petit", "$2b$12$wGRN3WunS7F.w75agJyYSO0UsIvFRGMusMwFolWAEaI1IqrCZNks6", "0134567896", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "84aa27d7-b4e9-19f9-ff67-3a2552c2a271", new DateTime(2026, 4, 5, 14, 50, 5, 941, DateTimeKind.Utc).AddTicks(6882), null, "mehdi.khelifi@univ.fr", "Mehdi", "Khelifi", "$2b$12$YmmkOG8oZv6pqTyUekCif.MOzwr9/g8j4t9OTa5/1MymqFMBgg.SG", "0134567897", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "9025faff-feb9-c61e-d313-1a54ee26ba74", new DateTime(2026, 4, 5, 14, 50, 5, 333, DateTimeKind.Utc).AddTicks(8531), null, "amine.bensalem@univ.fr", "Amine", "Bensalem", "$2b$12$ccX4jSJid5oomWRQasPVROZY7YodVXA6xh.o2cowHbeRIF0EBgLEO", "0134567895", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "a50d2256-7cd0-f15b-df98-fb145013efb8", new DateTime(2026, 4, 5, 14, 50, 8, 70, DateTimeKind.Utc).AddTicks(6339), null, "manon.lemaire@univ.fr", "Manon", "Lemaire", "$2b$12$tiW7gruNg3TdDjiA/yUEQ.iEblz6qoLN6YNoVpvyCJS/4Ke3B0.P2", "0134567904", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "a729b2ea-33b2-c65b-f414-20830e2fe2a4", new DateTime(2026, 4, 5, 14, 50, 7, 770, DateTimeKind.Utc).AddTicks(3121), null, "elias.benyahia@univ.fr", "Elias", "Benyahia", "$2b$12$/xhqu.kQt8yUY0cv72ilJep9eIPUjX8TLY3lTAQkc8vKKtEbbs7Bm", "0134567903", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "cdca56f1-aaae-3153-50bc-46f83e7a32ff", new DateTime(2026, 4, 5, 14, 50, 8, 371, DateTimeKind.Utc).AddTicks(1733), null, "antoine.giraud@univ.fr", "Antoine", "Giraud", "$2b$12$5KZRq8ybmpO/T3pGbWHX8.WSujO5yGPS3g/zLfwhPqeEyjLJUiT26", "0134567905", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "e75bca39-4aea-e853-add3-a481192e7567", new DateTime(2026, 4, 5, 14, 50, 6, 545, DateTimeKind.Utc).AddTicks(2877), null, "yassine.haddad@univ.fr", "Yassine", "Haddad", "$2b$12$flPBCegSfqsWE8egc3s0Puu5lhRBY5DYVJPk/MHr/BfFRA0xNUjBW", "0134567899", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "fb1372c2-a5e9-32fa-26af-ceb6c3e9f791", new DateTime(2026, 4, 5, 14, 50, 7, 471, DateTimeKind.Utc).AddTicks(6120), null, "salma.mansouri@univ.fr", "Salma", "Mansouri", "$2b$12$ydhYwgz/BWKxGwikXAdDz.n5jU.W9bdNLisAvcjndJFTnnO/aqbRa", "0134567902", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "user_id", "registration_number", "teacher_title_id" },
                values: new object[,]
                {
                    { "06de430f-a2f4-2726-ed59-0b529c0f9212", "REG_012", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "25c5927d-2e94-3504-cc8b-b152458283c5", "REG_010", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "41b30632-4fff-68ec-eead-cbe9e1e29c21", "REG_013", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "5f0e72d4-dff0-6c21-0efb-2673d678e2cd", "REG_008", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "84aa27d7-b4e9-19f9-ff67-3a2552c2a271", "REG_009", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "9025faff-feb9-c61e-d313-1a54ee26ba74", "REG_007", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "a50d2256-7cd0-f15b-df98-fb145013efb8", "REG_016", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "a729b2ea-33b2-c65b-f414-20830e2fe2a4", "REG_015", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "cdca56f1-aaae-3153-50bc-46f83e7a32ff", "REG_017", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "e75bca39-4aea-e853-add3-a481192e7567", "REG_011", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "fb1372c2-a5e9-32fa-26af-ceb6c3e9f791", "REG_014", "85279958-5b39-6e84-7c57-09f2a0174fa9" }
                });
        }
    }
}
