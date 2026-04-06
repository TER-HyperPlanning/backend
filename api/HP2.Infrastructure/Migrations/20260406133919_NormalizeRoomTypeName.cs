using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NormalizeRoomTypeName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Building",
                columns: new[] { "building_id", "name" },
                values: new object[] { "c3372749-b5f6-f0e6-e628-e79b82b17dc7", "IBGBI" });

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "room_type_id",
                keyValue: "2ebbc802-19e3-1c66-7809-e0126364f9f3",
                column: "name",
                value: "TD");

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "room_type_id", "name" },
                values: new object[,]
                {
                    { "086f26e1-a9c2-bc20-b3e6-3869c803f244", "AMPHITHEATRE" },
                    { "a740a15b-47ed-8bdb-c228-daf6bd05e427", "INFO" },
                    { "d1026790-e6d8-e5a5-d486-fcd720c78c6d", "COURS" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "011f7dd9-fd3a-3d41-6190-1f4489c299e9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 15, 209, DateTimeKind.Utc).AddTicks(137), "$2b$12$K9wvCrdpSeJY5z0Dm0oUEepcxfTpvvqi7/tbwtkk0VE9VMQvMNoga" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "015a9397-c5c4-4b03-eb4f-86048ec621f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 45, 160, DateTimeKind.Utc).AddTicks(9000), "$2b$12$0u0woLz8oae8YSk75HaN9.Z.y4XqtX3nUISFmokIPlytPMZldJvOq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "03428ee8-3d9a-de72-c98b-dbc65724b005",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 4, 727, DateTimeKind.Utc).AddTicks(2340), "$2b$12$A4D21iMDzT0iClwYPY664uBeOi08dpVjmcZyPdoCxoFa18fGjYMte" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 42, 985, DateTimeKind.Utc).AddTicks(9392), "$2b$12$mBpRxZMD6v6mvLCjTVx73OviVGtRLdjpfPJtmoEhbl9ATKXxY3SM6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 50, 426, DateTimeKind.Utc).AddTicks(1008), "$2b$12$Ryv8HemTV4xZ0Hspdip7fum9Drm9Ahk.ykVssCpAIV6p7hoG8j.1q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0a3f73e7-67a8-750c-576a-49c22125bac7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 16, 983, DateTimeKind.Utc).AddTicks(5341), "$2b$12$Xbxa8B80hZP4yKBJ0iAK2uzXbVqa.ia2CU8/s5dQEiIuaGTfElmPm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 37, 977, DateTimeKind.Utc).AddTicks(8597), "$2b$12$oafla47Al9U8gYLM6BCtH.wX9sfjCUocs6eYWOFjMxarZq7g5dWSG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b48ba68-2d76-43aa-8392-7b40b1aa1e19",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 13, 235, DateTimeKind.Utc).AddTicks(2590), "$2b$12$ld6V.Og/iN3.QM6Y/0w4P.4q1lHoMAOyxxFTzidekUsYJysFxabC6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 53, 779, DateTimeKind.Utc).AddTicks(4294), "$2b$12$h1hcwQ8.baw56HFXrU8BVOESsrc5X/.4cFShZrWeWbtwQCQXgWQCa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "129452cc-6c9b-3726-5c96-54b67ac3b884",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 18, 124, DateTimeKind.Utc).AddTicks(3076), "$2b$12$eE2wSoNsafAHxO3OAAZcCuLGowwsrt363XAt4890.CiKBhODtrFGS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 57, 640, DateTimeKind.Utc).AddTicks(2661), "$2b$12$Z9XFwT.i6xGiWSQs17ospeBi/0OR02dAt5t6Mm5SAygELGGdkt9DS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 39, 818, DateTimeKind.Utc).AddTicks(5804), "$2b$12$PX.AOrsIiMLUJ8S2Y2RZ.e2Auyx.trXtqV88ByZPtpbdk1z0K5iK2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 2, 348, DateTimeKind.Utc).AddTicks(6671), "$2b$12$3cqVW5gJ5hEQd00qOy0UaO/OQN0UGG8rZqJ6q.lVVYrxpKoVO1IuW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 49, 4, DateTimeKind.Utc).AddTicks(3635), "$2b$12$2XS2.CN/Yd0UBFpHtPWys.vv.OcGSrsX5IqbhgYtJAwnDKg5laxxW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "18241d26-a012-b189-957c-b5573ecb15d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 7, 245, DateTimeKind.Utc).AddTicks(8128), "$2b$12$b9ziRPr4Pybc6BKC.BOJnOfpaQFMdoZXsOas4D.SZckEgM0JOVj7G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 40, 940, DateTimeKind.Utc).AddTicks(8394), "$2b$12$y7.uKxXWF6iIbdtEvbxxzu5duBkzgI3JhVoEzh.gzOoE/92snhLMe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 41, 650, DateTimeKind.Utc).AddTicks(2370), "$2b$12$bryiHQYJqbQW2vssl1Fwwed.YF9NJuxRt18TfkZYBqV9hpYBqLulu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "288bdacf-8acb-a8d1-59f9-94f0cccb2086",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 11, 511, DateTimeKind.Utc).AddTicks(8408), "$2b$12$XtlXgnZKy8U79DCyMwmTteIoeUaS/nFQOvVLmWT4A0OpV6WaSz6XO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "296e74bd-c209-7f7c-d030-28e85a1aad75",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 45, 902, DateTimeKind.Utc).AddTicks(67), "$2b$12$g3zEwJzcVYsWWX/QazQ20uZQG/TaxCcW3gcMuD4IMcU61EBHa2qm6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2b5c3a92-dc35-b1bd-16c3-b0f8a21f29f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 9, 54, DateTimeKind.Utc).AddTicks(9778), "$2b$12$eNKa8rP3vNnx7lknYoYb5OibfwlbzivoRmqM5afZoxWURqeTBw9Pa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2fa22e35-4eb2-7351-ee0e-a523ac305c44",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 13, 887, DateTimeKind.Utc).AddTicks(8502), "$2b$12$b/V.WSBTsLTakhg0/U3ZUuQHw/ZZDHIepzOTMPV0oC6BZ6Dk0cS7W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 56, 541, DateTimeKind.Utc).AddTicks(8208), "$2b$12$ZP.vZrVWrYeOSm0LyJG.3O8lNASRJx5LpygF77vJUdXqFjofyG6fi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "373399d1-2bd2-aee5-629b-43f96da8f03e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 17, 756, DateTimeKind.Utc).AddTicks(784), "$2b$12$v85.endPno3OySdYW4dB..c5OcEP7k9AwHPlmtcOZid5C2Ervyhfa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3769412b-799f-6b72-f74f-9b9b735058c2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 10, 92, DateTimeKind.Utc).AddTicks(2980), "$2b$12$ZIUQyxsqg2tc8TY359ZBgueiZDp3s2VHY1jeR3ijCJevoYukuzO5e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3830d83f-4097-76e0-a9e0-b90ef45d1c79",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 7, 991, DateTimeKind.Utc).AddTicks(1286), "$2b$12$4.clcUHdu8EDMeFXlxOL4erkDNcZsWrswEGxTAhCCdbACb0CXksZu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 36, 764, DateTimeKind.Utc).AddTicks(6875), "$2b$12$Lxng1TOQvIWIbf2pgp4v.e.d9xAKfZsdHYqIYasWyc/GZd2u8O7Cy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 48, 644, DateTimeKind.Utc).AddTicks(6941), "$2b$12$7wzZlPDsv6sF7fcLVRu12OPiEXkFYyAZ4vyc5s0sbnutdArla1KSu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 38, 694, DateTimeKind.Utc).AddTicks(1289), "$2b$12$6kImQpC3/FQIt1EVq34Dp.fG2C6uolFwigyNOScXQ.0dVyPwxxQnO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "476292a1-d3ae-cacd-a58c-2d14790da8eb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 14, 566, DateTimeKind.Utc).AddTicks(4388), "$2b$12$W/nBvH/vCCQXufanBfqpWuA.2bC7d4.hiUVTnhHgBNvG94CuAHXu6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 38, 342, DateTimeKind.Utc).AddTicks(724), "$2b$12$gsn2Ii.zmnwO1gNEAMi9gOjPy1xWwoAK8XYQTX9IOPVN1lY5vlKr." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4d41b3e5-536d-0aa0-a3e3-024218ac6267",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 1, 233, DateTimeKind.Utc).AddTicks(3415), "$2b$12$lsJ6M7GFNUxwJtwH0eDFee.EyM358Hq9Wws442ZfKcf29DhidIrJy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "51432fb0-cda4-87aa-a2d2-e36c25823a2b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 2, 726, DateTimeKind.Utc).AddTicks(3170), "$2b$12$Jrot.2qA.jRYed20.2jRmOgnH31wRqctrIdzJn7T/wrpND/u6q8Km" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "52fb0554-7e57-01bb-5949-987520c91eb5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 0, 210, DateTimeKind.Utc).AddTicks(6048), "$2b$12$5ud1uiUK2f6B192ZSTMyFOopdjMjCeva/Feto1b6bVsnWSRdtjnD2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "539ead07-d571-367b-79f7-68b21513886b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 12, 873, DateTimeKind.Utc).AddTicks(966), "$2b$12$mMDklhnhkpiDBk/YPSIml.JbMP3CsXijJweIPsqZPPpO0k83m9sxm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "557dd714-15d7-6df3-3ed1-22a2eec63c59",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 58, 929, DateTimeKind.Utc).AddTicks(803), "$2b$12$51qPNe3kqJ3JDxBin2Ev3OObmnzxQtQ6GLy4WkSr6229ExkMrFy4K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "57f13355-ddb7-5d3c-b09a-ff2c56e22753",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 57, 969, DateTimeKind.Utc).AddTicks(6368), "$2b$12$90Yk4O9aeUfbpwO5l92PAuwxWVJiJWMyKKd7XibFnb.XLmjOTNn3S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 42, 348, DateTimeKind.Utc).AddTicks(1242), "$2b$12$B3xY2GQ25XGd32WxipBr6eabdRbMWjy31M9knbz1dOI.BvqkRVtbS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 39, 73, DateTimeKind.Utc).AddTicks(9918), "$2b$12$WGSvkvE0ZEKUd0X71J1ROeYsMDKlGArAEEJhGj/48dP8ioj6LFCDe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 44, 68, DateTimeKind.Utc).AddTicks(9660), "$2b$12$sKP.HVCOUsRnnKFLblNHLeWCMcczTTa9yUrqERKDKxnsKgpCj/E6m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "617cb820-a96f-5ce4-513e-f9de2ec06556",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 1, 965, DateTimeKind.Utc).AddTicks(8700), "$2b$12$WAZ64Go3aSteX0/7HsatheLrEBiKluJVtxV6khLYglQkyV0SPlsHK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "62f48843-9c38-a162-72b9-af6d09b80de3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 14, 212, DateTimeKind.Utc).AddTicks(656), "$2b$12$ITh5SfCzMr2370yh3ysEfeYVYAAx4WDc36EiKEHN5YPFspYGYA0ua" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 40, 570, DateTimeKind.Utc).AddTicks(5051), "$2b$12$IWdmBrbeiDm7dMkmsJHAmekNPCIS56Z70Ywbo6OGjFNZGOKpM6vWK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "65aa7c04-2529-20cc-46f7-47c22df3e1d0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 15, 938, DateTimeKind.Utc).AddTicks(7510), "$2b$12$DWWgZ43iVyvnppAidoAk2.uVL820HcjnWJEzIVs9hZsF2jhrV3NAa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "68fbd87f-0c94-976f-40de-323667ff06bf",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 5, 32, DateTimeKind.Utc).AddTicks(8789), "$2b$12$VXjOQFZCJY3oo0lHz8G9neByyuwQAzlN5b0bxvnWdCqRsArsgLYoC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 50, 81, DateTimeKind.Utc).AddTicks(625), "$2b$12$KmHLZYduWQ/davpHPfj.J.0UAsl6wlB1HtoJqGsEhxTVNXmywhuaW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 55, 151, DateTimeKind.Utc).AddTicks(7801), "$2b$12$sXN7UEU3CutZ8CzIsTpzXuYeSlZHLlhoPGTytLasPTUwkFTWd3gc2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6dcd090f-508b-7888-b458-17aeea49123a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 17, 349, DateTimeKind.Utc).AddTicks(3700), "$2b$12$8yBU7WqpBlL/ZRIAjSCdTOBfHsy.6XsPMHlEcr9kNMUIJW085vL/." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6e5a0735-7928-5aca-b192-5e455fca402a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 8, 333, DateTimeKind.Utc).AddTicks(1481), "$2b$12$HvowmTuXbTY.FlZpSalzqukElxHpMbDxI351Hv1kIDMZPFEom84ZO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 59, 567, DateTimeKind.Utc).AddTicks(4139), "$2b$12$Ms1TsjiuQbxV6HXUkVkYCurDe8o/XTyu4fq3WxUwdVNzOb55xiiQO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 57, 269, DateTimeKind.Utc).AddTicks(9520), "$2b$12$wbdY4CajK8nypmeFze.Qb.XFkzCfBQTGRn6cVW9qllTkzPQ2998jS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 44, 412, DateTimeKind.Utc).AddTicks(7945), "$2b$12$qCRm6lh.x.vAhW9rIGwMfe5jZaa8e0FonmFVY9ankiLgbx2Lw8NDO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7f2e2223-eda8-2785-2b9f-2f6cbfecc012",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 46, 262, DateTimeKind.Utc).AddTicks(2877), "$2b$12$ERMkZH71SKCFX/N3/YH2M.awVskqLDIQd4hmd2TkC6ksdwBMZklmC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8112e653-13fd-c47d-0fc5-7b36eda72bf0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 6, 116, DateTimeKind.Utc).AddTicks(4802), "$2b$12$num0Iitcv2OWAxY5IvIaO.2j/opIXnEmOCvXIpjA2lTFns5siJ9ae" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8976fc22-4f3c-f5a6-a6d7-81058525ac85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 18, 482, DateTimeKind.Utc).AddTicks(8952), "$2b$12$c2lHE9y7Qo71APdOtvXXIuDeOsd5lnCqo5leL7FrNA6ZDu88ldZg2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8b8636d1-c1b0-1104-ebb5-a8e7e20d35ae",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 13, 580, DateTimeKind.Utc).AddTicks(1489), "$2b$12$hr5HUf3gXs7focwqY0/l9OVK80sNPaXyJhKRfqYgy/ek6e9K3X43K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 4, 420, DateTimeKind.Utc).AddTicks(3194), "$2b$12$dWjJW635L8.PyLnPR8daJ.VW963oL1Jfy6HhrcshUcLAnd4dXJZfS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c62f6c8-d791-e825-bdef-5c14bf5ce951",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 45, 533, DateTimeKind.Utc).AddTicks(9294), "$2b$12$Axmuk88GG.GjA2/Sd9rHNuqva/svNd2E.rn8yyqFOBxCW9fDaHiVy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 56, 184, DateTimeKind.Utc).AddTicks(7518), "$2b$12$m6oouoBtl2xS5bOzvbW0t.Uumbq49HojfWFQa.4wiLvdJUotm2md." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 52, 393, DateTimeKind.Utc).AddTicks(8896), "$2b$12$F16muJSXoTamEDffW.UVJOXobG8eJUVVg.DolHTFvx8crCEuL5nWa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e1a2182-9af2-5229-2104-66051e4b6220",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 46, 593, DateTimeKind.Utc).AddTicks(8075), "$2b$12$6oOjSpBin8i.zq026B4g2uglxDU.vxsIrf83sQT36UGm.3225.H3K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e85356b-dff7-0fe0-9e0a-ac24101ff81c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 0, 517, DateTimeKind.Utc).AddTicks(8358), "$2b$12$WMi44tAhVo0bJQTk3jIEX.SpIbJ55nIINpWMcZH8DXCwIGo1zmh3O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8ee02cf3-bf69-3090-c8a3-acd718cd445f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 59, 259, DateTimeKind.Utc).AddTicks(3164), "$2b$12$LTCyY5V3TpgN3HDmZFDplesAdGIqW3WsxeIi7Ay7Cegzj6bCy16Pu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "91f97c43-df32-927a-bb77-3f050c28c5d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 0, 846, DateTimeKind.Utc).AddTicks(2502), "$2b$12$.fFVvReHfaqll8lqguroQ.pLjSB49IIdpbOz6/aiorL3xcJjw/VSe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "953715b4-1d71-3023-7048-42579385f359",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 10, 442, DateTimeKind.Utc).AddTicks(9698), "$2b$12$81cLA5qiIR/NROz6yO4fhOMY.JrltG27I.BkbLd.m0xxGyQMwlvy2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "954d4710-fb9b-9bc8-33d6-1a00378fef99",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 7, 639, DateTimeKind.Utc).AddTicks(6832), "$2b$12$hOsKgNu2t7jZNojpqepFweMS9EBiz6Zpp8Vgwje8M3JsS/aV1jNEe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "95755e71-293b-5fbe-2e06-ff9c6d90e96f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 3, 445, DateTimeKind.Utc).AddTicks(345), "$2b$12$xzYQ.38XntQf2D4/B5CTFOldbNqtYyir9hSc.Nzu/88lBTXORyt3y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "96cb69c8-c721-11de-8075-582c3bb936c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 6, 503, DateTimeKind.Utc).AddTicks(6521), "$2b$12$Bz6E0WjceKzoEVkyCEguWeBw5aB5.o6WtQxw5jMtuD.VncrtSZuQG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 53, 112, DateTimeKind.Utc).AddTicks(1203), "$2b$12$fLkRoWIbQ/SfgHsdEhh4.OdBGtSub/77DhWfLQ6VKKRaUdGeNUNca" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9ade6863-7e26-4864-6736-dc579f1c7a31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 46, 946, DateTimeKind.Utc).AddTicks(8997), "$2b$12$vw0Q6OpLTwdFlM6qR52pcO8iTUkw8zbuYa7xsdiLrVtT.XDi5b/OS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9dd3d6be-aadd-a804-775f-b0817d3508fc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 12, 233, DateTimeKind.Utc).AddTicks(8309), "$2b$12$HoTe5ng.XwBmLuo0f2tw4OQiGGBj1wz5Rp7Y9TWAm5aXcl3y71mzm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 52, 757, DateTimeKind.Utc).AddTicks(618), "$2b$12$u4Ig1jbzs0pO6/1A22ycTuj4w.R/eg1WR.w5oRkNTqkmNCuDRyd/2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 51, 456, DateTimeKind.Utc).AddTicks(6065), "$2b$12$4rKAEBsFfv5b0rJ1MtgnrOFTF3uSV4G.n12ddMyjm9qpE006irngm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f3e92f6-ee55-979e-23b7-f713245738cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 11, 881, DateTimeKind.Utc).AddTicks(4956), "$2b$12$2KTK/JAS3TwG9CSivpxS3eBjAOkzhZeqWs.zi2XNZgosUMeJzYvYK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 55, 534, DateTimeKind.Utc).AddTicks(5824), "$2b$12$bfbYfG5IosC4ad6Pim8I5ufpvki.nfzff/e.kig6qb9n5ZVdfyC3C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 3, 783, DateTimeKind.Utc).AddTicks(4935), "$2b$12$YRbCKpbwzznVByFKvwofX.u4pxvVmil64mstAvACKmcAlyM7Bk5be" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 51, 764, DateTimeKind.Utc).AddTicks(4093), "$2b$12$OM.wn8GRA/4M2mImSSl.U.mW0A8eZ3dqDtlw9u9es/OKI5qIRBpge" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 54, 134, DateTimeKind.Utc).AddTicks(2897), "$2b$12$vX3eMscWS9Flio9AGi5aO.uubLBfdxUCp2uHmO78YDlmHPaCkjudG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a70a25e3-1d3d-3e25-2f6d-c728283dce2c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 15, 566, DateTimeKind.Utc).AddTicks(7735), "$2b$12$CCb2ZvkGaY9ZUqUkd2dOnOQmf5E7BviUxiukvoSXn3js8cw8DfzeW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a81af79f-d5c1-b515-0d1e-fe2dbabc780d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 12, 551, DateTimeKind.Utc).AddTicks(339), "$2b$12$QYppc4mXixn8gqCunvesG.kMA0TvLmaBGtv35mCuF3QHd16tT4VFa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a894def6-b00b-6103-0ac7-92aa2bf2a079",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 10, 796, DateTimeKind.Utc).AddTicks(2908), "$2b$12$SxRk5tBssxJ4IrhE/N4RXu//6N3yQFtdUa2mNy/3wQNBmJCl./Mhy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ada69e11-1e1e-3387-80da-a6afa8505ba2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 9, 422, DateTimeKind.Utc).AddTicks(5089), "$2b$12$.luKQWUlRT30vhUt8.kwIuK/BdyvBUduRfq47qCgVXyh9I0E6dWhe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "aeba3eba-9c59-d115-5781-476232f36f4c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 4, 95, DateTimeKind.Utc).AddTicks(1787), "$2b$12$6pvxgHVPhFqQXfV0/U.MAOpkuoDyUXpkMq/Xup16Sj2vsRJignA1i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "af142cbb-a95e-ab3e-f00a-a39f87004ec3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 58, 303, DateTimeKind.Utc).AddTicks(8760), "$2b$12$P.0WV1SXtaFjmUPByMDvQ.K/61aYJrNoFkyRJqZC7xJbFBV8DlHb." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "afa4fe08-4af6-cc2b-778f-115de345ebba",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 16, 259, DateTimeKind.Utc).AddTicks(7829), "$2b$12$nPIRJnVswC5foDpdh49m5OooIPI9AIo6QmWKc9afNTpesutUQzyHy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 55, 843, DateTimeKind.Utc).AddTicks(3303), "$2b$12$xtLIX9264Epp7mx8hFjmheiB2roUQhnVyEzgRGZb0g4UiUqdx0QjG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 49, 708, DateTimeKind.Utc).AddTicks(9852), "$2b$12$RdLcr1TM.iDTiCo8DUgvCeGysUGI1LLKwmT/JujvjuJWJxs6.OSM." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 37, 163, DateTimeKind.Utc).AddTicks(9391), "$2b$12$mv8u/5TGK5AbU9u7V9gVluYRRC46wbDfa1rZf1yH4yPYYZrd96ngC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 47, 315, DateTimeKind.Utc).AddTicks(2432), "$2b$12$bQXpNEqcGj76z7wzNV.DMevh/uRBWJkAcA3wM8NVJPwZpjIKMIUzu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 5, 733, DateTimeKind.Utc).AddTicks(1355), "$2b$12$KLdoa0K1aAtox8JZMpNLgeOZh1No37OimsxCa8iETlKndZQ4yQEO." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 41, 302, DateTimeKind.Utc).AddTicks(9534), "$2b$12$b1ovxdcDvfwRxjJxqnKW8OvzViledHAusb6VCB7dIEYgi6Kj9UgQS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 49, 345, DateTimeKind.Utc).AddTicks(3208), "$2b$12$xEXu3we9TDoQ4sIzRvRA4uXGpvk4OhJULU.JsvHzDjy8VFDmNmRWS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 1, 596, DateTimeKind.Utc).AddTicks(1376), "$2b$12$QVc0jrAMurLKOcuMvjdbUOTN1TeolrHvCGYtSi0ZDloK8EUH/YYfi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c2dd0d11-f58f-2546-c1ca-10b453a7bc96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 6, 893, DateTimeKind.Utc).AddTicks(9332), "$2b$12$zDuPAIiF38SVal3XE3LM2eaOc85U3pi4XlRb5ebaiQ0c12Z4I8JxK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c668490c-dda2-f1b1-d170-72005fc34624",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 3, 109, DateTimeKind.Utc).AddTicks(6750), "$2b$12$iNPAKYnrZkOJhpXmpq.9UOS7F7fSsqSpyCIpFT4zdjRweC8lCDGYC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 48, 311, DateTimeKind.Utc).AddTicks(5127), "$2b$12$bkJ27Jz5gCMH3gLc3jGQPOnYSvylNxntVYMhvrXgeazd47xPdTiAO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c8936e2c-61ab-766a-1161-ed4577bda964",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 5, 369, DateTimeKind.Utc).AddTicks(6219), "$2b$12$qmVMaUtW7oPZe7gBiE.mH.2knw1zVryaVxVENSGlUjlXc/dFWzls6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 56, 917, DateTimeKind.Utc).AddTicks(3594), "$2b$12$/LanjQLXD0zD6..wzE8xTuQWY5BIRRpF4odplkpzIS6O7wIf93txm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ccd1db56-b977-3035-ca07-0d16377dbbe1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 59, 891, DateTimeKind.Utc).AddTicks(6059), "$2b$12$jlxMyoZkBhSCLTnTNJo6H.tkPZaK8foz/Z1eK5FfzmJB7aSM4.dee" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d3f7232a-7eb6-649e-c1fc-ad010f705d7a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 44, 795, DateTimeKind.Utc).AddTicks(3589), "$2b$12$sp.KtH79ucbk2TZ6cZM63etlJkEL6/CsoJZDfSd.X.9vnYKc6tcf6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 41, 975, DateTimeKind.Utc).AddTicks(6175), "$2b$12$NS1XAQq29ShRuEuYdNRTUupasFSesbA1.dYyIJxcm9HZHfHHSi0li" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 40, 191, DateTimeKind.Utc).AddTicks(4433), "$2b$12$40Bbs/Qn9gNY/odSuYqaJ.SSeKhZLACTeEQNcQZgG.hJt7p28rCsO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8924a08-9bc1-e88e-8396-1a1e86e2276b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 58, 617, DateTimeKind.Utc).AddTicks(5745), "$2b$12$.tiNMDMG8DXjdP45hZw2w.mwktFyasimN3imq3f2dMH41unloGItK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 50, 774, DateTimeKind.Utc).AddTicks(3580), "$2b$12$Sz2iSwZifNZn5Bqaee2g8uwoXE6DOoC63byKGtpFyC6U8TqcnXM.q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 37, 613, DateTimeKind.Utc).AddTicks(4615), "$2b$12$1npmEXJNkZXgVxWTj6h0w.VHHkBWFKYc6e2o3ESMlBRbSNW7J8Vnu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 52, 77, DateTimeKind.Utc).AddTicks(7830), "$2b$12$fxyxnJ66.rFK8GEMFlGT6evMhOhwZhfmXI1nS5oGLHGgDuLTSCQSG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd288475-9710-eabb-7cca-449e335c3070",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 8, 708, DateTimeKind.Utc).AddTicks(5364), "$2b$12$gOZA2VSjOANgwrEx9.dvCOFlqSvZgFXWhR5rmNnSXzT4yyhU1RdsK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 42, 653, DateTimeKind.Utc).AddTicks(4760), "$2b$12$kmhXRNZnG.uFHNnl9WmkyOtlXw/gu3vcsyoY8jBf6D6RzorZYekcu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 54, 445, DateTimeKind.Utc).AddTicks(5986), "$2b$12$RdOB7lngzLDgNnGIna72deaK/wBv1kq7CHI61P5XlZjow945dmSAO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 54, 782, DateTimeKind.Utc).AddTicks(590), "$2b$12$0Cm24pLhZCWdqJ4CzGkWnO9nkyDfWdsDua3UP1H22eshXlp7qs/1y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e48c4173-bb79-99df-4cdb-550c4acb9bfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 16, 611, DateTimeKind.Utc).AddTicks(6710), "$2b$12$T05iY6xu/WRpwf3Tgci.jO4OR7ByjfhVeczGG9gItfZe.2r4XN20." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 53, 471, DateTimeKind.Utc).AddTicks(7387), "$2b$12$sbLV.9tu5DLfPz6Wzpoh9eKdxkCBzy00wiC9vgd82UGiRFeBsHNNu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 51, 143, DateTimeKind.Utc).AddTicks(32), "$2b$12$b9yth3L8ooMtBN6tzkvEXe.vKpt0.GhWYKC8al2GIpxFJbQ.q6ZlC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ecd9a403-0fa0-120e-0580-76ac458c1397",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 11, 159, DateTimeKind.Utc).AddTicks(326), "$2b$12$mBQOc7HYUj9oWmrp8G.PY..2Y0l4YI76u9XnHf/jt.C1PXWysVac." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 47, 957, DateTimeKind.Utc).AddTicks(6159), "$2b$12$w/ndP1Qt0CIliSbrFWqRO.s5tnDqpGgLIP4TtB2SiMAxS64NHLNAG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f0af01b8-a5e4-18f8-889c-4863d1166ca9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 14, 904, DateTimeKind.Utc).AddTicks(3523), "$2b$12$KRtpBkZu41K7MjOsmvjvtugOt/98jfmZh/GW1AVGAaTUvgiZGil7i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f828e1ce-18e1-0c76-9535-92a277f7875a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 9, 752, DateTimeKind.Utc).AddTicks(2452), "$2b$12$MOg78XCkkDOugLMSADX4oezY5ZfoiQf0PcIboZ6oCSBpzeWddErEe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 43, 707, DateTimeKind.Utc).AddTicks(2626), "$2b$12$zmcwzfNlMgdblze0./0wp.qKHdMDX6zfdk78XcBoeuhOAL8bVJjSS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 43, 366, DateTimeKind.Utc).AddTicks(5229), "$2b$12$HeTTmrx1vWinjTlbPoQGfuTSFp281BGSfw7bCC/8J1UX.1HGrrgLG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 47, 652, DateTimeKind.Utc).AddTicks(7195), "$2b$12$36jYT4JSdqFygiuFdFa.J.1CkyKXCJmoy/n5O6mDUOqunF5h9af2S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 39, 447, DateTimeKind.Utc).AddTicks(4611), "$2b$12$U9DewoeuLNmjq9ly9jALN.vpPv477Xl5Hu9uxAJeFrl0VxqGkUJDS" });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "room_id", "building_id", "capacity", "is_available", "room_number", "room_type_id" },
                values: new object[,]
                {
                    { "105f2e79-3a04-c9be-ebe1-241b17a81848", "c3372749-b5f6-f0e6-e628-e79b82b17dc7", 50, true, "IBGBI-5", "d1026790-e6d8-e5a5-d486-fcd720c78c6d" },
                    { "222025a7-66a4-9b58-2958-eb835bd75046", "c3372749-b5f6-f0e6-e628-e79b82b17dc7", 50, true, "IBGBI-8", "d1026790-e6d8-e5a5-d486-fcd720c78c6d" },
                    { "305290d1-3c50-8f7d-1f6a-898cc87f8f5c", "c3372749-b5f6-f0e6-e628-e79b82b17dc7", 36, true, "IBGBI-4", "2ebbc802-19e3-1c66-7809-e0126364f9f3" },
                    { "5863a804-6ac2-3f05-38ed-472541726740", "c3372749-b5f6-f0e6-e628-e79b82b17dc7", 36, true, "IBGBI-1", "2ebbc802-19e3-1c66-7809-e0126364f9f3" },
                    { "61eea842-d7b8-3f75-7a50-f17d467e2f82", "c3372749-b5f6-f0e6-e628-e79b82b17dc7", 50, true, "IBGBI-6", "d1026790-e6d8-e5a5-d486-fcd720c78c6d" },
                    { "694b7a35-1915-d0fb-02e2-562a6b6b3ad0", "c3372749-b5f6-f0e6-e628-e79b82b17dc7", 36, true, "IBGBI-3", "2ebbc802-19e3-1c66-7809-e0126364f9f3" },
                    { "91263188-230c-ee00-ed2e-9eda780a61de", "c3372749-b5f6-f0e6-e628-e79b82b17dc7", 50, true, "IBGBI-9", "d1026790-e6d8-e5a5-d486-fcd720c78c6d" },
                    { "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9", "c3372749-b5f6-f0e6-e628-e79b82b17dc7", 36, true, "IBGBI-2", "2ebbc802-19e3-1c66-7809-e0126364f9f3" },
                    { "ba6e201b-edf9-7aea-a09f-4bb2fed50891", "c3372749-b5f6-f0e6-e628-e79b82b17dc7", 50, true, "IBGBI-7", "d1026790-e6d8-e5a5-d486-fcd720c78c6d" },
                    { "bc224e06-c4ec-98e8-c492-0a528471d3eb", "c3372749-b5f6-f0e6-e628-e79b82b17dc7", 36, true, "IBGBI-0", "2ebbc802-19e3-1c66-7809-e0126364f9f3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "room_id",
                keyValue: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "room_id",
                keyValue: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "room_id",
                keyValue: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "room_id",
                keyValue: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "room_id",
                keyValue: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "room_id",
                keyValue: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "room_id",
                keyValue: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "room_id",
                keyValue: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "room_id",
                keyValue: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "room_id",
                keyValue: "bc224e06-c4ec-98e8-c492-0a528471d3eb");

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "room_type_id",
                keyValue: "086f26e1-a9c2-bc20-b3e6-3869c803f244");

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "room_type_id",
                keyValue: "a740a15b-47ed-8bdb-c228-daf6bd05e427");

            migrationBuilder.DeleteData(
                table: "Building",
                keyColumn: "building_id",
                keyValue: "c3372749-b5f6-f0e6-e628-e79b82b17dc7");

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "room_type_id",
                keyValue: "d1026790-e6d8-e5a5-d486-fcd720c78c6d");

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "room_type_id",
                keyValue: "2ebbc802-19e3-1c66-7809-e0126364f9f3",
                column: "name",
                value: "Salle de TD");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "011f7dd9-fd3a-3d41-6190-1f4489c299e9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 4, 720, DateTimeKind.Utc).AddTicks(3824), "$2b$12$qwu79tnAuk1RSs2U/or2kOhnXShp7xO22BdyU2gYC0Ivxz272J6VK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "015a9397-c5c4-4b03-eb4f-86048ec621f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 37, 668, DateTimeKind.Utc).AddTicks(7568), "$2b$12$DNikWLOmiOEVNkCWkk6qleTU5mWFviXN4oeaEMh24KooSXq3HthZ." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "03428ee8-3d9a-de72-c98b-dbc65724b005",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 55, 356, DateTimeKind.Utc).AddTicks(9958), "$2b$12$ABIzx.P6fhoFBbvuKQ.cXOB5xv9PzFu/P2mnxFMBF4fKgFA8G05sG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 35, 845, DateTimeKind.Utc).AddTicks(8287), "$2b$12$IGj9Fc5lXxIVUtKi0J0b2eLdb3qlKzkh3Eh26VY5ZHTGhyUUtRQYa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 42, 263, DateTimeKind.Utc).AddTicks(2410), "$2b$12$A2CdITa7vh1uZMPrF9sybeKi034g06RrQhlrMDOS7Q/lvhFO.45Oq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0a3f73e7-67a8-750c-576a-49c22125bac7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 6, 276, DateTimeKind.Utc).AddTicks(4233), "$2b$12$3NtnLla3aC02uayAopV8NeMx99IV4je8HzOIw37v/P3oqb2lQzDAu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 31, 537, DateTimeKind.Utc).AddTicks(1678), "$2b$12$wip9XhcWkLEukzxb03Eo4e.RyqgBr8AovoE9.tOiNRBCGajWIH2gu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b48ba68-2d76-43aa-8392-7b40b1aa1e19",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 2, 897, DateTimeKind.Utc).AddTicks(7640), "$2b$12$6cEVKzSxofnZ.wP.sjVI/.6zp7JBVgRU5kpxGBFDyq1GUZ4Y9znVC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 45, 317, DateTimeKind.Utc).AddTicks(3332), "$2b$12$HZZ/FBTbDouKSR/SF29HU.s2FUzdaEqWuWGoSJ4G3bp5/GFjVrglK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "129452cc-6c9b-3726-5c96-54b67ac3b884",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 7, 188, DateTimeKind.Utc).AddTicks(9269), "$2b$12$ukWvWxIk6GWHOXJ.f/2DKeH8qLf7vX.gGgD0KWmg.Zk9g6Q2VTW/K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 48, 732, DateTimeKind.Utc).AddTicks(4663), "$2b$12$zylFq2VVc7fi5PTG5/CC0eAVRznyZurJcjMa2k1P4ST5FAeKTE4Qy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 33, 59, DateTimeKind.Utc).AddTicks(3150), "$2b$12$xsyfl0yLSeEI71UDXBlwce7qCB01HJpl2UPXVLId3dNPwyGx/PDL6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 53, 22, DateTimeKind.Utc).AddTicks(7449), "$2b$12$p2RCOVxCkt8fnwEAyNb54Oj.qfWUxVGlUJS22m7dXlsG9xmbJLuym" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 41, 44, DateTimeKind.Utc).AddTicks(1754), "$2b$12$gp5CiLcyYn3VYkTkuWrG/u/XlB8lc9veRuTa2yp.Vf8yUZBDOh.9q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "18241d26-a012-b189-957c-b5573ecb15d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 57, 609, DateTimeKind.Utc).AddTicks(2298), "$2b$12$6Wouh20MG7kmVWUlr/k4GuG2Uay9LBejCq3WVEwXjeeXAUc367xTu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 33, 981, DateTimeKind.Utc).AddTicks(6271), "$2b$12$0OwMvsyy7pW8rEwnnDa6Xu6XVxAUczlQdbjVdGTBU1EJf2WbxXq7m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 34, 594, DateTimeKind.Utc).AddTicks(2042), "$2b$12$stW1EfGqtIfkZ0hGZn1oEeuHCtBrz45cirCQHZ0KdZF4s0Gv3tWs." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "288bdacf-8acb-a8d1-59f9-94f0cccb2086",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 1, 363, DateTimeKind.Utc).AddTicks(5591), "$2b$12$lbFHGbM/6dhO8DhRCGA8UeII.Syu2M6gOXEfYdBexBwnInqsmMpBO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "296e74bd-c209-7f7c-d030-28e85a1aad75",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 38, 278, DateTimeKind.Utc).AddTicks(2797), "$2b$12$fbJ7Kbf7GFF4AnFTtc2EFeSgBgykA4rVnt1jy2rcJg6.rpY6UCaOi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2b5c3a92-dc35-b1bd-16c3-b0f8a21f29f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 59, 227, DateTimeKind.Utc).AddTicks(3094), "$2b$12$4edpQ3GoIReRrn7fj2yM4.2jpgnuefzWbNtPiDLRQ44ximAH.uvfG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2fa22e35-4eb2-7351-ee0e-a523ac305c44",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 3, 504, DateTimeKind.Utc).AddTicks(3136), "$2b$12$2Ex8HcIS1W5uU/7L1orWS.gnN.mSbL38nRLCzzzzZAEU3ax3gaUIq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 47, 795, DateTimeKind.Utc).AddTicks(7051), "$2b$12$Ac7ZkkhrCOhWamuACX.8/OYl/1Z6pHSbXTCV6A9L7dFBfoTvi3D8O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "373399d1-2bd2-aee5-629b-43f96da8f03e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 6, 884, DateTimeKind.Utc).AddTicks(95), "$2b$12$/p2LM0OQeMEcp8I2BevwoOP/Sm7U5GJRDhqKMe3sedm3AzwA8uopu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3769412b-799f-6b72-f74f-9b9b735058c2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 0, 141, DateTimeKind.Utc).AddTicks(8260), "$2b$12$s2sI9em1hQ3e0jHmidXHIOMalilEwBSy8rIGULoQDcrVqDp27Fe9." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3830d83f-4097-76e0-a9e0-b90ef45d1c79",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 58, 269, DateTimeKind.Utc).AddTicks(8546), "$2b$12$yzAWVOwI0xMTDnk.xuw9kO5ExidMPIDLKmf96Ho.JQDvx8mzTZgG6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 30, 611, DateTimeKind.Utc).AddTicks(9537), "$2b$12$4lmekffBbn1tuYcVVROz9ees7.gmv4oZWtqa5ZFFjYLzMjH228RiO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 40, 739, DateTimeKind.Utc).AddTicks(5096), "$2b$12$hQ/4qy5Y0a3Ya3ubfmxL2eWHTpXptLvJdY.3Eu08T6ZWDPuK6FM3i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 32, 145, DateTimeKind.Utc).AddTicks(5003), "$2b$12$q/3BWntVIOpP3nWcM/EZSuh5PSYfLZi3K8Aecy.VdqKTkIWJ0W3u." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "476292a1-d3ae-cacd-a58c-2d14790da8eb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 4, 112, DateTimeKind.Utc).AddTicks(1188), "$2b$12$m2wXI2H9DWl9BMbnbIQzH.nluy6Mvs/Tw3uEWibGTrtFF4lu80.7C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 31, 841, DateTimeKind.Utc).AddTicks(4648), "$2b$12$KKV3QAGgSwJ6/WeqANex1u7eqHFsXpwMdu4914Bf3NN6y6HtgDmGy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4d41b3e5-536d-0aa0-a3e3-024218ac6267",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 52, 110, DateTimeKind.Utc).AddTicks(1262), "$2b$12$Nd7cHOdIy7MDB0MiuDqRcOV6vNLgjXCg6tDGCDqe9gzG75sGbnAbi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "51432fb0-cda4-87aa-a2d2-e36c25823a2b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 53, 326, DateTimeKind.Utc).AddTicks(2742), "$2b$12$7HIeFvAbT6MSRQW.N6e3/.lfghmb7hIdLkdkGH.ZrAWXoQUW4Q.Q." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "52fb0554-7e57-01bb-5949-987520c91eb5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 51, 198, DateTimeKind.Utc).AddTicks(5495), "$2b$12$sK8sUA/ta6pqgdKCw7qope/kt.hbZrIlH/9P0Z4yumLBGw/.lU.OG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "539ead07-d571-367b-79f7-68b21513886b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 2, 591, DateTimeKind.Utc).AddTicks(7123), "$2b$12$Ae.JLgznwAV/.Ag92x2pp.Q2z4Jh6pmnfO9kZiqW9re2escoWdluy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "557dd714-15d7-6df3-3ed1-22a2eec63c59",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 49, 948, DateTimeKind.Utc).AddTicks(6842), "$2b$12$bYhjf.Ka3sX6OnzXbl2urOxstkpElnEilpakEqVO.L.GqLTXPsibO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "57f13355-ddb7-5d3c-b09a-ff2c56e22753",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 49, 35, DateTimeKind.Utc).AddTicks(8656), "$2b$12$bd6ke3o4hgVmzapSe7dLHuAiYtkvzapnRzzKQptmjlQCPQzyn.ng2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 35, 205, DateTimeKind.Utc).AddTicks(4994), "$2b$12$8gUjwew8iKE4LEPp5JscrudmrOxfupdhWHSLEbwYbKnL8JMcyuyWW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 32, 449, DateTimeKind.Utc).AddTicks(4350), "$2b$12$6c4wwpFMLnkl8TIVvaU2KetAkK83EyqAZo0K9P1ML7f.p8v.pM3uK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 36, 758, DateTimeKind.Utc).AddTicks(2903), "$2b$12$oudjG9Q8AifcYgx/4lZ3ZuYg48IOz90Eqw.xzJ0ETtlSHsfRQ4gfC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "617cb820-a96f-5ce4-513e-f9de2ec06556",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 52, 716, DateTimeKind.Utc).AddTicks(8573), "$2b$12$oI4Dnb.X20BvakDix3l0WuVg1Z52m.FSdkSy4iOJTAwa2MGplDMTC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "62f48843-9c38-a162-72b9-af6d09b80de3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 3, 808, DateTimeKind.Utc).AddTicks(3076), "$2b$12$qTbrA72mpAzmwxaV5Rttz.32KlZ3HqyzE89jbufMK8VYVK.HKWd4y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 33, 669, DateTimeKind.Utc).AddTicks(1434), "$2b$12$CtjX5JoBhNv015WsnhdcwOwkVsY1HKxs4JGI8b1ZRUo6M8.wIoUTi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "65aa7c04-2529-20cc-46f7-47c22df3e1d0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 5, 326, DateTimeKind.Utc).AddTicks(7888), "$2b$12$heZY77K1hOajm.I6jQyu7ufB1hqvT25BrkM0Utrrvas3zsN93lR6C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "68fbd87f-0c94-976f-40de-323667ff06bf",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 55, 676, DateTimeKind.Utc).AddTicks(9651), "$2b$12$qxAbUDiQX2IM7iQDYlHKG.zF0HOJWKrXUWfqV4oDSd88yMXq9iGkq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 41, 955, DateTimeKind.Utc).AddTicks(3268), "$2b$12$S5ziojmvzLAer6Qro/nz.u5u55r9N4w0fwTQ6vXH2YSxQBfapThES" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 46, 568, DateTimeKind.Utc).AddTicks(560), "$2b$12$WYFHbiWRFANiWzybQaKxHuS7faytg13h3DILGmuxk519qXbKvz3He" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6dcd090f-508b-7888-b458-17aeea49123a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 6, 580, DateTimeKind.Utc).AddTicks(4314), "$2b$12$GMDc.TULbeLcdlWSADrli.h0QcwnSkJ/pwzNFqgHpxhwL.Yk5P7TC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6e5a0735-7928-5aca-b192-5e455fca402a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 58, 619, DateTimeKind.Utc).AddTicks(6670), "$2b$12$cNH0SxJK0bUXuG32Jq6hV.wR.VJiACH6XGdqkn1oQnL4AD86zdLAW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 50, 584, DateTimeKind.Utc).AddTicks(7780), "$2b$12$TOxbmvs.0ZawMqgUYu3g4e4nfke52Zc81Rv47BPQpUnfhlXfKWKHu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 48, 410, DateTimeKind.Utc).AddTicks(5088), "$2b$12$AGfAojF4imdVsCYFBj8taOA6l00aVAlF.T0JjhnOMWe2Y5Ni75vbK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 37, 62, DateTimeKind.Utc).AddTicks(2686), "$2b$12$iWSzTL6F.TiPoUhYgj8f9e8yxONna79cR12UWqetqTRg0PjaaARWS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7f2e2223-eda8-2785-2b9f-2f6cbfecc012",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 38, 597, DateTimeKind.Utc).AddTicks(4748), "$2b$12$9z4.lSAxklq3FXw7B1BBEusv30xq4uE024HFB9krXNP2PHAA9S3f." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8112e653-13fd-c47d-0fc5-7b36eda72bf0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 56, 666, DateTimeKind.Utc).AddTicks(4206), "$2b$12$1A0yHNyahLwCvdzDSzyr7OwcodLns2rLTQ.f1HZw9mEej72HNeMNu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8976fc22-4f3c-f5a6-a6d7-81058525ac85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 7, 493, DateTimeKind.Utc).AddTicks(4105), "$2b$12$MfxcOjTW8VczlCwPXu7eFutR7VYuD6UQuUVtOpZofVCk2EHbF8YmG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8b8636d1-c1b0-1104-ebb5-a8e7e20d35ae",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 3, 201, DateTimeKind.Utc).AddTicks(3562), "$2b$12$A0f5wbTPJCWsL69YrTlYqe7vqn25SXDjdMidWxx3IR3QxHQ2simY2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 54, 999, DateTimeKind.Utc).AddTicks(548), "$2b$12$o4EniecZgtU1N/jgrvCiaOA7X5mwXCinHXON5SAhrZWdVcaPbPBz6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c62f6c8-d791-e825-bdef-5c14bf5ce951",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 37, 974, DateTimeKind.Utc).AddTicks(1752), "$2b$12$yfSvvAZSI2YSWgUICCccmOx2cNwhPgG35pAjKT8Fjmvuh34D6XyU." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 47, 490, DateTimeKind.Utc).AddTicks(888), "$2b$12$1jevL4qqbJvnTVhfhlcv6uKzBjZnCx5iEgY/aWi1E5.Olup9y.Ury" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 44, 97, DateTimeKind.Utc).AddTicks(4292), "$2b$12$KzizFbgb0yNnx3gJXheL9u701QDpEpv31.HQIX1kRlPknd3VOisJa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e1a2182-9af2-5229-2104-66051e4b6220",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 38, 902, DateTimeKind.Utc).AddTicks(6965), "$2b$12$T7c.HqzNuuPuZoyIjW9O2.Kvc9rwzR2hfMctMuxcPOymuQED4hg72" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e85356b-dff7-0fe0-9e0a-ac24101ff81c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 51, 502, DateTimeKind.Utc).AddTicks(974), "$2b$12$QAM3bSBt3YhgWcsZUcCG7eZhSb2LToCZmCyukHwdsn58.JIBO/2XC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8ee02cf3-bf69-3090-c8a3-acd718cd445f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 50, 254, DateTimeKind.Utc).AddTicks(8988), "$2b$12$iZLvX4Og37WEzKo41TMNZetc8FKJ.BEEc0xoIYGZBJus87wcFmobS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "91f97c43-df32-927a-bb77-3f050c28c5d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 51, 805, DateTimeKind.Utc).AddTicks(5003), "$2b$12$SqBIBugXt/ulJENtpb6xDeruuCKH/eWPl39xBuqWn1T.uxY3tg/EG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "953715b4-1d71-3023-7048-42579385f359",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 0, 445, DateTimeKind.Utc).AddTicks(2406), "$2b$12$Bb0pnrRGBzGrMrpM/k2DNOFen3.Z0.VgGhWfIvkslfJhrZQQ6iePW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "954d4710-fb9b-9bc8-33d6-1a00378fef99",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 57, 943, DateTimeKind.Utc).AddTicks(3778), "$2b$12$4eKRnyq32GrCumvwku/iT.CmtjtO8y95hxMZLRtTSshCZl3eaz4/m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "95755e71-293b-5fbe-2e06-ff9c6d90e96f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 53, 977, DateTimeKind.Utc).AddTicks(8094), "$2b$12$DH7aFD4a7UcZnqwD4XIfNu2BcoP1sO0AduBWrf8p0U08v6qubj91S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "96cb69c8-c721-11de-8075-582c3bb936c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 56, 982, DateTimeKind.Utc).AddTicks(2873), "$2b$12$Ei2c0KnzRF4zGj9Wee703u4WWDhVds4ArQcsGbVWeAjMwglbEIQOy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 44, 704, DateTimeKind.Utc).AddTicks(6461), "$2b$12$sWizKl/K11iP8pfGLACQVe2n43H9r54ySH.P5gTV6cUr9iy4wcl/W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9ade6863-7e26-4864-6736-dc579f1c7a31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 39, 207, DateTimeKind.Utc).AddTicks(1724), "$2b$12$1J4fVMg0ETlkD1.kRo5E..e/ZSw.SBUYNQYvwY51Eg4Y6L/e69Jiq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9dd3d6be-aadd-a804-775f-b0817d3508fc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 1, 982, DateTimeKind.Utc).AddTicks(7410), "$2b$12$Q4HUbNVpFjtrSaTB6mrP3eYOLT8bFN/0Nl5172QvKqmWfO17R59Sm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 44, 400, DateTimeKind.Utc).AddTicks(9165), "$2b$12$ihfO0a9Qz70Wj73tGqNjAephqBpaK.f8XAhIHuVWYigOhhwgp4H56" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 43, 183, DateTimeKind.Utc).AddTicks(3130), "$2b$12$T7cIC37jvnHQ8xa8S7wRjOyxk.C69dtSxceMSx9Jv9JGgq59g2Ge2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f3e92f6-ee55-979e-23b7-f713245738cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 1, 677, DateTimeKind.Utc).AddTicks(3653), "$2b$12$S6Vm.B2tGYMpq/rqQFGww.A7ReA7qyDnDr6/.kokFivd/jXWrnRva" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 46, 871, DateTimeKind.Utc).AddTicks(6367), "$2b$12$dYxota0lj/stMMk3rTVK9OWdUCESQ/4KTKrCHBvODJ7AY2xk3/lxW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 54, 307, DateTimeKind.Utc).AddTicks(5245), "$2b$12$q4mzOinKASrBpvcEINZJbOpp/6rucWDtyDKhBZA7jYghzev3m7AH." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 43, 486, DateTimeKind.Utc).AddTicks(1194), "$2b$12$T6HJzoYWxcGJT/pfc3tO7OHuUhcoxfNXVmn34FTe7klC5ITR/SSXW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 45, 625, DateTimeKind.Utc).AddTicks(7639), "$2b$12$w1s9wt4JBYl5oYiEk2vZwemNQ3xuW31iOnpgXn1olgVe8dGKl3ST2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a70a25e3-1d3d-3e25-2f6d-c728283dce2c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 5, 23, DateTimeKind.Utc).AddTicks(7024), "$2b$12$FeeyFNO68ss9xnUU6AeS4.SbxCMIEdvizdOJsZCxYOqZTlbY1.f6y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a81af79f-d5c1-b515-0d1e-fe2dbabc780d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 2, 287, DateTimeKind.Utc).AddTicks(5205), "$2b$12$ZnY3A3Ca3TZV69kgPevtlOY7Qe/AZtobUt1xhgbii.fxEfSnceOlG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a894def6-b00b-6103-0ac7-92aa2bf2a079",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 0, 754, DateTimeKind.Utc).AddTicks(2948), "$2b$12$//ZqQK4jS0S/RRuudyjjjuJOiCHQnWo2j3C1BxDUmKLg76OpbaU.q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ada69e11-1e1e-3387-80da-a6afa8505ba2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 59, 532, DateTimeKind.Utc).AddTicks(2661), "$2b$12$ZTtPruIKIdjYsb7pLA1nkuqaLE0jJXkX5F0D7r0R1.UFMmSmSEJ8W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "aeba3eba-9c59-d115-5781-476232f36f4c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 54, 642, DateTimeKind.Utc).AddTicks(6641), "$2b$12$4cRPDjgj.880wy6zSFNmseGC7xU0sDOM/0gYJXqIe842A2kY6jbla" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "af142cbb-a95e-ab3e-f00a-a39f87004ec3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 49, 339, DateTimeKind.Utc).AddTicks(8990), "$2b$12$yWNiD0z.Tu1C6nKlUV9GHOPN.p2zsP.DOIiw0TP1RM5cb8N2kx4Au" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "afa4fe08-4af6-cc2b-778f-115de345ebba",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 5, 632, DateTimeKind.Utc).AddTicks(8546), "$2b$12$R8lFhKZWlPq5TUSwDvCx6Oo3aYvVsJ4/bXOjf8vTmLjkTp8rDSMJG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 47, 175, DateTimeKind.Utc).AddTicks(9836), "$2b$12$oWTt9ri9Lm6DwBePQpEm0.2D1.N9mmuoejd7gokttOlKwZJs0m9Ky" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 41, 651, DateTimeKind.Utc).AddTicks(9464), "$2b$12$QyugGu0nWT9dcQa65LvgT.Q6E7C8yucuMF/TnZZOsHBazKTt/jphC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 30, 927, DateTimeKind.Utc).AddTicks(2676), "$2b$12$UV.AvG/B9O/Onw6f7FEaw.jUyj7mBFRqg6uC.g59Nj8zh5oSh4Fn6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 39, 515, DateTimeKind.Utc).AddTicks(6824), "$2b$12$UlobKcOPNel3DUmuPPBcXO6g55.i.kySpAUTmXtYFVZ357y2R9.0m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 56, 345, DateTimeKind.Utc).AddTicks(3354), "$2b$12$0PS/qZMWyYZUb5DpD7knEeH/l/nfQCGX2c16j3Psr3VSf5IoNukM6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 34, 287, DateTimeKind.Utc).AddTicks(7797), "$2b$12$Em0/HhjfAPVmJuOxe9EPQug9U/2wMlkX4LUmZWcXhhho.PalNHHcC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 41, 348, DateTimeKind.Utc).AddTicks(3681), "$2b$12$UUMZ1PSgT9E4Bl7LczbQyOUzW3FJhLUisoQH.oVgHu/mcEDfBOQVC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 52, 414, DateTimeKind.Utc).AddTicks(14), "$2b$12$GTugsG44N4lu0Nm2L5JiDOX0ecvKJKn5RojK.ul7IRFtO8qb6UJpG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c2dd0d11-f58f-2546-c1ca-10b453a7bc96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 57, 300, DateTimeKind.Utc).AddTicks(8796), "$2b$12$.jjPbSX1GAECeR6ripyZPuMOEbqN01pWWFjudM3Qpt7ZDddcssvM." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c668490c-dda2-f1b1-d170-72005fc34624",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 53, 631, DateTimeKind.Utc).AddTicks(4771), "$2b$12$NkoQRK42YZN9tVJxbqG9U.sHPcAp4uT0rJ6GubWCqtbk4Jdclkrzm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 40, 435, DateTimeKind.Utc).AddTicks(3503), "$2b$12$9SYgtXab5H5POgP.xF8oqu5lhMbJTouWPdZf4qtztneKrFW4C/lxm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c8936e2c-61ab-766a-1161-ed4577bda964",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 56, 27, DateTimeKind.Utc).AddTicks(6511), "$2b$12$C7kuMk5YIi71kkNhlCaNGugycrUQCcdOuhqEl44vV9VaUd6Zb4Iji" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 48, 99, DateTimeKind.Utc).AddTicks(7463), "$2b$12$YK8En1jOAEADuRnmujJ3oOyyN08nAESBN3Xxv2PKiw/AKOX153IXe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ccd1db56-b977-3035-ca07-0d16377dbbe1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 50, 891, DateTimeKind.Utc).AddTicks(4647), "$2b$12$UD0c0iXK5hZDaMi.0CeskeYsKinRM0Q66NVqi5JvkzeV687eL8jCS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d3f7232a-7eb6-649e-c1fc-ad010f705d7a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 37, 366, DateTimeKind.Utc).AddTicks(1726), "$2b$12$avYMV51bl8apL8wQ3dazEu2Ugs4hywmek6rFMA4NmtmfTiE7xfEPu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 34, 901, DateTimeKind.Utc).AddTicks(1887), "$2b$12$Jq0sAEtEKDAxCfH.90HbvuZ1LVY5c2Uzid9fENkN33sH8aQFM6kF." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 33, 363, DateTimeKind.Utc).AddTicks(6055), "$2b$12$R2p2xumCc7QJswgh1cQH6e7xLzimNgBw3ZAYNUd9.oMwQlPZR6gbm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8924a08-9bc1-e88e-8396-1a1e86e2276b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 49, 644, DateTimeKind.Utc).AddTicks(2362), "$2b$12$EYSoMBDecvCvRWHo/6YWqOzj6RqhZvGYuIduH/m/4vlcQlmE5sYYO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 42, 566, DateTimeKind.Utc).AddTicks(7017), "$2b$12$oHwxLvdiFrrv0.vmpWz6BONlepHfZA0TAfclYGfefsyP7tAWzMU8y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 31, 231, DateTimeKind.Utc).AddTicks(6855), "$2b$12$Mzb.0sUlUjnTNKp9n0lnQeIvLslfXRfuZ1UI9pVSkhRCZ/jWePNMC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 43, 789, DateTimeKind.Utc).AddTicks(1522), "$2b$12$FSHFZGtdZ7M5hN.PHSMqouu.a82UsyCjFZlFiwYEWRLzYpfa0Akpm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd288475-9710-eabb-7cca-449e335c3070",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 58, 923, DateTimeKind.Utc).AddTicks(9464), "$2b$12$uJybtBPl.640XbFagg9z4elUZWFp8qkvUYg3Vqox6PYM0NfGs1Vle" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 35, 509, DateTimeKind.Utc).AddTicks(6819), "$2b$12$YT7vurcozpJLHloxDtmUge8NS2gAy9Cs2KNFKTuknwwKrxx5gtdXO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 45, 962, DateTimeKind.Utc).AddTicks(4651), "$2b$12$tYu2HG1QbsLbPIOlLZKxUer6hsE7NeUZlyl.jyyOA4FljSRVzCnJu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 46, 265, DateTimeKind.Utc).AddTicks(7962), "$2b$12$REHDRJ6JJnZ3n6zNM2NP/.8Bxi.1jE2c0og.b1mdTL.eiWipD3ciu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e48c4173-bb79-99df-4cdb-550c4acb9bfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 5, 971, DateTimeKind.Utc).AddTicks(7171), "$2b$12$ZqhPlARJ4eBimlw9fgNy4.MhFeyf/lVleq41EJpcdYNi4pi1gKgPi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 45, 10, DateTimeKind.Utc).AddTicks(5081), "$2b$12$1MUyKPdzbOaHcj08Df7KP.6IAbMBdOdQMxdywaogtTAV9WhKa7jXe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 42, 870, DateTimeKind.Utc).AddTicks(5020), "$2b$12$z3xFL8U1vMs16eTu0YlRZu7mJ7EOhQygkKHNHXTmtaRnCFO3WkwUi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ecd9a403-0fa0-120e-0580-76ac458c1397",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 1, 59, DateTimeKind.Utc).AddTicks(666), "$2b$12$xMonLzN9B96DGQATj19MeOJI00XpUgbyfgdaPd.G8slDbb/.zDycW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 40, 129, DateTimeKind.Utc).AddTicks(5995), "$2b$12$esQFVdQ0XXAywbl1FcJ2RubAkeqIBqbwl5yIQvtcyBeBExLsPZTuW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f0af01b8-a5e4-18f8-889c-4863d1166ca9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 4, 416, DateTimeKind.Utc).AddTicks(1550), "$2b$12$mWW7zgfrNyHOq3qgvGXL7OsAXXZZFQqk06o.Ov8xeVAOOlxwGbnAi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f828e1ce-18e1-0c76-9535-92a277f7875a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 59, 836, DateTimeKind.Utc).AddTicks(7344), "$2b$12$7ehvV83hXA3eT1HLs2unAe.Ls/vfulL5umfr.gqHfoPO2BCWUW6Ka" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 36, 454, DateTimeKind.Utc).AddTicks(4034), "$2b$12$5SG0nylSagt5DpZU/L3siuUolpvD.a6N072B3oaag4LPgAC52H4zS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 36, 151, DateTimeKind.Utc).AddTicks(3966), "$2b$12$c4aFf2P3TBVOY5kBp6nThuYuK8Tywjvjxa1kGEB5jS1VlNEcLFCEm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 39, 822, DateTimeKind.Utc).AddTicks(459), "$2b$12$GMJPllS29pTfbzhzBIBl8OC959hCy94r2fuRBpUgzi04iSOqgx50O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 32, 753, DateTimeKind.Utc).AddTicks(7320), "$2b$12$EEwVDQStsSXWQUo/6/3JrOiREpifjUDd.zz5QZV2ZCPtPLIBCX6xC" });
        }
    }
}
