using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIsActiveToGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Group",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "group_id",
                keyValue: "57bf1149-8880-c27c-d603-3546214d03a8",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3701bc4e-401e-f4f3-00aa-b37659789636",
                column: "date",
                value: new DateTime(2026, 4, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "54166d2e-0d4d-7e23-3a55-ecde2614bcfa",
                column: "date",
                value: new DateTime(2026, 4, 25, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f",
                column: "date",
                value: new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "885f671e-9801-9aec-86eb-3fe1cb1db365",
                column: "date",
                value: new DateTime(2026, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a5129120-7dfa-797c-3e24-99056723ec39",
                column: "date",
                value: new DateTime(2026, 4, 23, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e823715d-0a77-1379-9289-b44b55c10267",
                column: "date",
                value: new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 7, 697, DateTimeKind.Utc).AddTicks(367), "$2b$12$2WsYyvYHjaQ8bg1nmCLU8.reGpoUM3ZJxQYiW/kV3jK4RjOxC09M6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 10, 414, DateTimeKind.Utc).AddTicks(6570), "$2b$12$bclkl/o/AK.oxBtinhSf6.I/hsNI1Qwq1aLoBonLeWrZET0QQEKI6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 13, 373, DateTimeKind.Utc).AddTicks(1606), "$2b$12$AQnUUjKXZ6gFMMDrL9yOYuO9Uj474WgXljVlcIU9pqeCbZtcDp9iq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 4, 410, DateTimeKind.Utc).AddTicks(7297), "$2b$12$6RBhDzduKAzRTyLnSDC7iuTjjNQOuQB6Ej4FJqj5VHgCLB2SKBr.K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 6, 585, DateTimeKind.Utc).AddTicks(936), "$2b$12$SEZ/oPmHCA1/x/t5JCm6LOHN13RPe8GD8Y/Xkv1syNVP65LMWnWFO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 12, 569, DateTimeKind.Utc).AddTicks(6135), "$2b$12$0JYky39YHnfIrW0ktH4zxOdfFSevCqyOj20ZoNaOqhqTU8r9DZndq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 3, 324, DateTimeKind.Utc).AddTicks(304), "$2b$12$YHZuF/gi/GCLN2.7m6qQVen1RuwlqFCVFtNv2ixvuGpI7l5Vb/vX6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 6, 313, DateTimeKind.Utc).AddTicks(1240), "$2b$12$l1QfNaZ1J/CeG3h6wZKPr.nuyi9NkOF5Vlasjt8JooiXw8gpFuI9G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 3, 594, DateTimeKind.Utc).AddTicks(8728), "$2b$12$VWW0iLYUPZE6d1Kzh6jiGeT3PvPa3LKQRTmep7brlhN09wgX0r3Py" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 3, 861, DateTimeKind.Utc).AddTicks(5521), "$2b$12$u2BM5RQ2P3o8AE7f6wrkyO/rJ0x6Fq/fglPiPBRHxGpdaDMOXtTA2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 4, 974, DateTimeKind.Utc).AddTicks(1568), "$2b$12$K1juyVktlV4wz2BjS8VRS.fL4czOOnqBpZAJC4ZOHhfJe4K1AJZw2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 7, 425, DateTimeKind.Utc).AddTicks(7154), "$2b$12$2/hs.TagzGZzrqdKhXoh8uhIZOA6CJmQJdRiCuR7CaA7FMzSnhjFe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 11, 491, DateTimeKind.Utc).AddTicks(3756), "$2b$12$FMsupPWntBzOiXnr5Q4bweGhBXLogg3Zr01naBiLoJ9VO0Ab5LxYi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 13, 103, DateTimeKind.Utc).AddTicks(8227), "$2b$12$jTtMnwDGpjxSTdQF5g2AweL30eeSkrKBa3soyM5C2reGTy5LFRLDm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 12, 301, DateTimeKind.Utc).AddTicks(7814), "$2b$12$7rzECd5JE6p6C3lPwr3NyOdyN1Et7No8niqxRFxJfMGE0TG8Tg9o6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 9, 298, DateTimeKind.Utc).AddTicks(1233), "$2b$12$TnCdYYfXFKI.oYg7gMNMy.V8iyMMJUA.dBrZzOfflzoOS.6xGLs6q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 9, 846, DateTimeKind.Utc).AddTicks(8701), "$2b$12$.zaYPuW2228.GAxdwNWsvepbJzcOyV/on6OcJaV1fLnVQzCxA1xb." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 9, 566, DateTimeKind.Utc).AddTicks(9104), "$2b$12$qCFzP0ZDjeU1yjpPfXT7OuSX55hvKUb1gSrtZFZx66xKlh5WG3u6i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 8, 495, DateTimeKind.Utc).AddTicks(3328), "$2b$12$aRg8P6Tstc0HYuT0Ovj23ugicqoxi.ZmZeBv7hghsSPuWg5resxle" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 11, 765, DateTimeKind.Utc).AddTicks(7312), "$2b$12$loJoFPz2.NzLpTUnqhwoqOVAJOPlyBifPFKaRhxdouExfhDI63e8e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 8, 768, DateTimeKind.Utc).AddTicks(9515), "$2b$12$5K44p6dVdFyilynFB54/x.flDYXFMofcMKO5GT/80jowvcz9gi9Ai" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 10, 682, DateTimeKind.Utc).AddTicks(9895), "$2b$12$zRQRG14NIejDgtEltBkDxu5moNtMeXFq70MYR8mwinddyplWkGh7e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 12, 32, DateTimeKind.Utc).AddTicks(6192), "$2b$12$RU.GYDIFBPgDAZKqlNl/3.HVBJlKhNs4g2YSRB/ZddVCHGXRjA0j6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 7, 143, DateTimeKind.Utc).AddTicks(9566), "$2b$12$GivSJIIrYXG3oQl1kSQMNeMJIYunVlwXzoN59Z3oHMxFVHgKI5xuS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 5, 242, DateTimeKind.Utc).AddTicks(3768), "$2b$12$M9gCb9jxu9tObbzZcXxd7eOlv2RfmM1ie9yJgeLLo0JwyJleGbIe." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 6, 853, DateTimeKind.Utc).AddTicks(8953), "$2b$12$IX0pmYkvFG6xLDRj4Ew.t.wxwzo.8cADsZrfrIpwUC/WL3L9xJrbS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 6, 45, DateTimeKind.Utc).AddTicks(7853), "$2b$12$wMneRan60V23BX.gJC3RP.doTVmDcabgTiUP4IW.TYHVuzrON5StC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 12, 836, DateTimeKind.Utc).AddTicks(9184), "$2b$12$dm/YcQJmpTBzxMKi.KF5Oejm5xXQbXss1KASaXGpcAqp9jsVqH0ha" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 4, 704, DateTimeKind.Utc).AddTicks(7436), "$2b$12$x3W1qy1y74x92vK3jeoSLOY6Xkcjepw6fklL081PA.5em2XfyRSJi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 7, 961, DateTimeKind.Utc).AddTicks(3093), "$2b$12$ne3cEkkDOH1gvn9K/f3KR.HoEOP4OkhsS7FMXnHTqFKlHsAzKxGrS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 9, 34, DateTimeKind.Utc).AddTicks(114), "$2b$12$zIqICjll1lo3PgSymynG3.bopE7cNcjFk6JdOB47pAQQbhyOUMMLi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 10, 954, DateTimeKind.Utc).AddTicks(9040), "$2b$12$jq77zUV.qhmXU1emX0IU6efvGlvr.gD8RgKUAczNSGI2tOqgTug/O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 11, 225, DateTimeKind.Utc).AddTicks(2502), "$2b$12$N6Y4.Anxzc5OtFrdZ8wRsek8Y92E6ZeHxbJf2wMdhE6ckO72.z/Y2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 10, 132, DateTimeKind.Utc).AddTicks(3914), "$2b$12$IWgZnYRPiCIk9vXBJj4PR.WjMA027nt7GULEAZTgFbzrm74daggJW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 8, 229, DateTimeKind.Utc).AddTicks(744), "$2b$12$mBEfpAq2qmdPPsNbi5070umFdH5MVJBgQ7pDihw2/B.M7uUcThM5C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 5, 777, DateTimeKind.Utc).AddTicks(9956), "$2b$12$h53OViLZKi2eME538wso.eMgvXy240B5.TBrrTUaFOaPy8EdbQCvS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 5, 510, DateTimeKind.Utc).AddTicks(5705), "$2b$12$FQ3GK9k2cnebz4xEi9i10e.p3XdqnJxOJOnwog87HQyLo39ew0cF2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 13, 19, 4, 4, 127, DateTimeKind.Utc).AddTicks(3177), "$2b$12$Xu7UVnPz3qTKfeTLBvKe/uadLxoyo9qBbqvsxrWhadYv2XrZlGrVm" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Group");

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
