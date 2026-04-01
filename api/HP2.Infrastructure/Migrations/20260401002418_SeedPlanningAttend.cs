using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedPlanningAttend : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 6, 995, DateTimeKind.Utc).AddTicks(6868), "$2b$12$maqqakRQd9TqFxAsYUUkueQHXV.KpO4dZWJUyM98OcLKX0.ykulW6" });

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
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 7, 298, DateTimeKind.Utc).AddTicks(463), "$2b$12$E3yY22QjJTM3qgH6MQPJbuheHmae0yarlPM3WcfzMmNo9kMwdYRjy" });

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
                values: new object[] { new DateTime(2026, 4, 1, 0, 24, 9, 97, DateTimeKind.Utc).AddTicks(2963), "$2b$12$uOuNxHF8wOmYm/c5P7REBOpHbIE6rdf2BllDJ8hT.z67O34WDUbyi" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3701bc4e-401e-f4f3-00aa-b37659789636",
                column: "date",
                value: new DateTime(2026, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "54166d2e-0d4d-7e23-3a55-ecde2614bcfa",
                column: "date",
                value: new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f",
                column: "date",
                value: new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "885f671e-9801-9aec-86eb-3fe1cb1db365",
                column: "date",
                value: new DateTime(2026, 4, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a5129120-7dfa-797c-3e24-99056723ec39",
                column: "date",
                value: new DateTime(2026, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e823715d-0a77-1379-9289-b44b55c10267",
                column: "date",
                value: new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Utc));

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
    }
}
