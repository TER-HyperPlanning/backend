using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddM1ILSDNewGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "group_id", "academic_year", "name", "track_id" },
                values: new object[] { "64b93cdc-56f3-906f-6e4c-2adfe2184501", "2025-2026", "Groupe B - M1 ILSD", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 54, 114, DateTimeKind.Utc).AddTicks(3534), "$2b$12$B9lFEBfK0f3sGtxkJki0uuVa31laQPwOOySPj3Qjts8YuLd4i2acu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 58, 237, DateTimeKind.Utc).AddTicks(6762), "$2b$12$rJ2d1lket5.k2x/4gvv/4.n85lq8nAxw3qfvK/SgyvdVv7Kbx3WdW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 49, 959, DateTimeKind.Utc).AddTicks(4046), "$2b$12$fr0oow3Y0knVXHdmEVKJwehwGA19RbyRKSvJlkWq4oE5cOFRdb95e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 23, 1, 216, DateTimeKind.Utc).AddTicks(3285), "$2b$12$I//taJpeaMKt1R.LXMfE9e9vedYq0gOi4Vs9bYsiK.BiJUFp/qJlq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 23, 4, 464, DateTimeKind.Utc).AddTicks(4732), "$2b$12$OW4NORVmtv/dG.D0Q2ksNe.F0nwyEyzkdFVZnKr.SZ25J3bNb0aYu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 51, 439, DateTimeKind.Utc).AddTicks(4581), "$2b$12$QbdsO/wXnwq7dzmzEr6v1OvcwOrfAOcVfRXrGX8XjcqpmlSBWjEye" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 57, 60, DateTimeKind.Utc).AddTicks(3370), "$2b$12$hhcAvaeyMwTDfXDNLqDCNOHb5/ZFqg0d2FJX4tqSgFgjqdGm72OZC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 52, 346, DateTimeKind.Utc).AddTicks(3628), "$2b$12$la3p080O74d.wxcshXYdVO4hwIru5v0e/r351VuoeP1a42sCxsXkS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 52, 938, DateTimeKind.Utc).AddTicks(3416), "$2b$12$B/9Z3Z5K0m9Mv7fow1mk6OCJOQVut/KDY.rCJy2Lzb7D/QgpjQihO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 23, 3, 581, DateTimeKind.Utc).AddTicks(2037), "$2b$12$SDLTp9DFRFYoXVfanqf5U.bHywId2Xg/lUXMq2w59FGd0fxOaYlv6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 49, 47, DateTimeKind.Utc).AddTicks(7052), "$2b$12$Bsbw7KDNIZ4BLlMVunO1zOawAMuR.s9RFQNgB9yix6ezxJhXBwDcK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 56, 765, DateTimeKind.Utc).AddTicks(6692), "$2b$12$XJcqIsabfltzWfurkW.2wudOcb7Etzwjop6M2sGyZuDkgQLzdzqfe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 50, 551, DateTimeKind.Utc).AddTicks(721), "$2b$12$QYOwJV7x.QDtnBh1qRtMI.Vv5jHnCWUaqERTn1RgEoRkdPR/pZHp2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 50, 254, DateTimeKind.Utc).AddTicks(7426), "$2b$12$MI3LChjUYfk/4Ah/vJdilubiecPdIC4ejUeQICpnWBzE4EU7Lj7Yi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 53, 525, DateTimeKind.Utc).AddTicks(9196), "$2b$12$wtUVkAz4SrnWF3SZyy.rcup62OAJWe8gCnrqwlGQmko3265eNnw.2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 50, 848, DateTimeKind.Utc).AddTicks(2902), "$2b$12$JMmQ1CPzst.pVkoObkZi..WqitYYT6hTQVVzOukpQhkOdlzNz7aOm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 54, 997, DateTimeKind.Utc).AddTicks(5354), "$2b$12$SHOJbVUEALQhn.maJVkI4.sHlCHeu3.29p42gLUpSSgR5hkBFRRBu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 52, 49, DateTimeKind.Utc).AddTicks(1855), "$2b$12$HbPmFN/zYYHWXB5Y71v3CuYzzeDl4IEj7MzoR2tInO1C3GACsMRjC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 57, 943, DateTimeKind.Utc).AddTicks(2973), "$2b$12$A/LKjj3W8pFiDw0Xd0nF3eOQVgwtgwWFBGqSaISCEZ003cG8/wOTy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 23, 2, 403, DateTimeKind.Utc).AddTicks(7635), "$2b$12$n/q3L1wg1AQAud6NVYZCZu967WSm7YSxEbkwjzfZvi6JAy7Yx3WyG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 23, 4, 170, DateTimeKind.Utc).AddTicks(487), "$2b$12$/YGGfaGPdV/Vpy1KrT60mOtEwnjx8KhDzjSdVTDT4AF7LubzDg8Rq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 55, 291, DateTimeKind.Utc).AddTicks(6597), "$2b$12$Qm.UizOW5UFEDzItsLSEvuIdMMQIgU8Iaro.UDjE5wMFwfp5DQ0de" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 23, 3, 286, DateTimeKind.Utc).AddTicks(9841), "$2b$12$.a8MeSxZk.sI/6GDXeVZ0evvzR6afpGZ2ljihE2ZJyO1V9heOgylO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 23, 0, 32, DateTimeKind.Utc).AddTicks(8029), "$2b$12$1l/D2BB3NOqCs6HQyqWlleciWJJJGLss5SHYu1IMqllSF88gq2zAm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 23, 0, 623, DateTimeKind.Utc).AddTicks(7491), "$2b$12$LuISAE.ZuWqFCMXESj0EjuNPyLL8zfZFloY3pFWStlSnfe2JourPm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 23, 0, 328, DateTimeKind.Utc).AddTicks(6079), "$2b$12$9FIxMmHGjfPmFyRx/PlUMOMQ2clXiIFIPG03Obh7tMoMFV2XSA5ey" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 59, 141, DateTimeKind.Utc).AddTicks(2848), "$2b$12$z/DO9ZFClUwpLBrvGimZvu4/NbAXaRMxslu00N4.kMaK5dyuMiR7W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 23, 2, 698, DateTimeKind.Utc).AddTicks(1426), "$2b$12$yR45yTgcnMEaIsybzFI8M.ih89L.yCRuJZ1phxhEwjfjCf.JvLhwC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 59, 444, DateTimeKind.Utc).AddTicks(1897), "$2b$12$N6Mk7GMFc2OK5sxGIjpkg.YEe/0x1.fID91XfbAFS1BmKVxyl1l0m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 23, 1, 510, DateTimeKind.Utc).AddTicks(4893), "$2b$12$0BSC2XuRKoleT.BNQvkVW.Ic/1odGZd0Z2USCl3hUhlFcAW7zq86q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 23, 2, 992, DateTimeKind.Utc).AddTicks(8060), "$2b$12$BoMvkU9icOVjaxvu70x6juWKW9F3ExpCLgSVoNmlcoS464k/3KCv." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 57, 648, DateTimeKind.Utc).AddTicks(6010), "$2b$12$uHFp052G/2ZhYcxrhzCzGe5N8aB5/KHP1ig9NGoZg5tScq4msCdxK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 49, 366, DateTimeKind.Utc).AddTicks(13), "$2b$12$Se6zOOVgfSS5PdGCi6UK7.qgrE.NEVe5U8O4aj6hR4sqJazNXMEE." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 55, 586, DateTimeKind.Utc).AddTicks(3826), "$2b$12$sl3ytf.fBxcO8eRrLFvfMOq0lBwOa71ma7qDKS2QCzFJ6w3oxOojC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 52, 640, DateTimeKind.Utc).AddTicks(6774), "$2b$12$V46OPF5zPXnMiRWVIDmyiu6pqIGb1Z2g2W3EVCUFRJJ4KHAU2IZkW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 57, 354, DateTimeKind.Utc).AddTicks(2945), "$2b$12$KFozAwoMb7zAsq8rl.Si.OMGxEig2Otz8fY9fYkBHOE/GRNCoMIJG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 56, 470, DateTimeKind.Utc).AddTicks(4261), "$2b$12$xOKusL7gkWTUvm../suFwu0ZrYu6tmA8Ilt32NQKTpXddgQOgbAgG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 23, 3, 875, DateTimeKind.Utc).AddTicks(1822), "$2b$12$6zaJVJgE3bugpCWu13WcpugXhNddrZe8Ot550pX7RdOzs9OyVaA5C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 53, 231, DateTimeKind.Utc).AddTicks(9520), "$2b$12$0VO4Ej/4LZOfWh/cbeuUnuWZneNsEiff/zFepXtfI7H0JK5AsyJcu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 51, 733, DateTimeKind.Utc).AddTicks(8827), "$2b$12$pPkr8FBeBm/EsHP4cv62i.dt7Q2FwDHbBuLX1Z4ISBWLmRiZdPiBO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 58, 532, DateTimeKind.Utc).AddTicks(526), "$2b$12$/dcOEaGC4CtwLgrhEKrRAe6bwt7pLQopSxJm3EoKanh8u3F.WoMsy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 49, 664, DateTimeKind.Utc).AddTicks(6672), "$2b$12$X5HDLNB8iREsE0xfFrRrKug4czxPnrMELf3yMMTw9IuReshXCAE9u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 59, 738, DateTimeKind.Utc).AddTicks(1850), "$2b$12$z5XOJ1bTXQ507VLZWC5f9.Q4os.EbUXSE4AlqNeLWYan6sLi1d4LW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 53, 820, DateTimeKind.Utc).AddTicks(2333), "$2b$12$/Af3i0j8e/l4WSZp01PEyuQl1uk4lbTsytMdqEBQJNQ0/FyOebtRO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 23, 1, 807, DateTimeKind.Utc).AddTicks(1724), "$2b$12$mI2uLOJg89iD6fkHvPX9oeaMUqhmV5z8fLxsiDPew.GX7tTD2t5ji" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 23, 2, 109, DateTimeKind.Utc).AddTicks(4274), "$2b$12$ldfZfx/v2nO75/BCwbZCz.WuBPxaHfCrS2A76izpY.CMMqeMm0tAW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 23, 0, 920, DateTimeKind.Utc).AddTicks(4567), "$2b$12$sni088A5JBYgxdhONvsbf.AIrh.jSZXu3xjoeGOJhwSE0KOBnpKpy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 58, 826, DateTimeKind.Utc).AddTicks(6771), "$2b$12$0s45H60DOSVdF0JNOYIX6uGnMytiHewUwFa12tF6.xZ72k/y.fQHG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 56, 176, DateTimeKind.Utc).AddTicks(1096), "$2b$12$lmp7J2KPj3HbrPqApkyyYOAQ5KCfrMyHD432GD4Nl0S4A1vMqGuOS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 54, 702, DateTimeKind.Utc).AddTicks(9831), "$2b$12$qI0dlfGTKsTOoZv1/b9uPO7nQotjvU5B/IPW9Z903EGw3NdjE5KVe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 54, 408, DateTimeKind.Utc).AddTicks(7627), "$2b$12$wNWx9z6ucmtSkaM0mU04OuyrnDxjMvAywhvEAL1S9z8s5okkySPu6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 55, 881, DateTimeKind.Utc).AddTicks(7578), "$2b$12$nO7WeZijc0ndRG90uMP7pe6AGUxxGihhYRcYWSZwh5AgA24RN33TS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 21, 22, 51, 144, DateTimeKind.Utc).AddTicks(2764), "$2b$12$RwPPgEePrj.x0Ie/BdXOXeZ70vVMV5.niozY2w66hrgv5AExIyW0." });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "user_id", "created_at", "deleted_at", "email", "first_name", "last_name", "password", "phone_number", "UpdatedAt", "user_role_id" },
                values: new object[,]
                {
                    { "03428ee8-3d9a-de72-c98b-dbc65724b005", new DateTime(2026, 4, 5, 21, 23, 10, 764, DateTimeKind.Utc).AddTicks(808), null, "studentb21@etud.fr", "Omar", "Uzan", "$2b$12$GWIFOhqj48kpL6famaLexuHC2tWv6ZX2fxvxyKuCxcHNkst8y6UU2", "0620000021", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb", new DateTime(2026, 4, 5, 21, 23, 8, 614, DateTimeKind.Utc).AddTicks(6947), null, "studentb14@etud.fr", "Tarik", "Naji", "$2b$12$CVd59s4OyZZeaLgEvu3J5.lzFBisidh.TE6HyCImm2HUatLDx3/u2", "0620000014", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "18241d26-a012-b189-957c-b5573ecb15d1", new DateTime(2026, 4, 5, 21, 23, 12, 864, DateTimeKind.Utc).AddTicks(3425), null, "studentb28@etud.fr", "Hana", "Bouzid", "$2b$12$JCToqmJZ9npD/xH/2Q9hi.f3BAKqFbqDa8WIF3ehEBo4.LFTzavCi", "0620000028", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "3830d83f-4097-76e0-a9e0-b90ef45d1c79", new DateTime(2026, 4, 5, 21, 23, 13, 453, DateTimeKind.Utc).AddTicks(7642), null, "studentb30@etud.fr", "Nora", "Drissi", "$2b$12$AroIbD7F8NsJyV4evr2hrO1UkrGTGOgk4IAvY5JmjEIer8eWcE.p2", "0620000030", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "4d41b3e5-536d-0aa0-a3e3-024218ac6267", new DateTime(2026, 4, 5, 21, 23, 7, 721, DateTimeKind.Utc).AddTicks(4521), null, "studentb11@etud.fr", "Ilona", "Kadi", "$2b$12$rrkPMW6fS7vokF/YDXBlVuqBa0cazVkkgXF2.H8VyuHatwckcP2cq", "0620000011", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "51432fb0-cda4-87aa-a2d2-e36c25823a2b", new DateTime(2026, 4, 5, 21, 23, 8, 913, DateTimeKind.Utc).AddTicks(4721), null, "studentb15@etud.fr", "Imane", "Ouali", "$2b$12$NerdpK.GJLN2dBsorLIpT.g7btZ80jMCTTGGZ4GpBn.ye5DTHcUmi", "0620000015", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "52fb0554-7e57-01bb-5949-987520c91eb5", new DateTime(2026, 4, 5, 21, 23, 6, 836, DateTimeKind.Utc).AddTicks(8782), null, "studentb08@etud.fr", "Riad", "Hamidi", "$2b$12$fJd.LaWsy4Qk04o6DVXU..1AtNCPxYP3XOH1BWj.SS/dkwajmgmtO", "0620000008", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "557dd714-15d7-6df3-3ed1-22a2eec63c59", new DateTime(2026, 4, 5, 21, 23, 5, 649, DateTimeKind.Utc).AddTicks(6072), null, "studentb04@etud.fr", "Idriss", "Dahmani", "$2b$12$ikYbOGCDKKkvTcx/FpR.1enrhIvhE/yf50Ko27G.ylNM7NzPKaPXa", "0620000004", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "57f13355-ddb7-5d3c-b09a-ff2c56e22753", new DateTime(2026, 4, 5, 21, 23, 4, 759, DateTimeKind.Utc).AddTicks(1557), null, "studentb01@etud.fr", "Lina", "Ait", "$2b$12$d.tXMGd4n1e0K60KyNJi9O79pXJNKn/VACa.A4NxHoifUBvswAHzC", "0620000001", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "617cb820-a96f-5ce4-513e-f9de2ec06556", new DateTime(2026, 4, 5, 21, 23, 8, 314, DateTimeKind.Utc).AddTicks(5862), null, "studentb13@etud.fr", "Siham", "Mansouri", "$2b$12$gcJdTIwnKCDzDcjqWDn/ceOoxViRYlljT0Mli8GbtvghT0qNgYPOG", "0620000013", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "68fbd87f-0c94-976f-40de-323667ff06bf", new DateTime(2026, 4, 5, 21, 23, 11, 61, DateTimeKind.Utc).AddTicks(5781), null, "studentb22@etud.fr", "Meriem", "Vallet", "$2b$12$UYP0CIhcL55YWXFwis2Eeu6n0V9VpU.YNg0E1Fm6FZvaQs4FnITxi", "0620000022", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e", new DateTime(2026, 4, 5, 21, 23, 6, 248, DateTimeKind.Utc).AddTicks(6273), null, "studentb06@etud.fr", "Youssef", "Farah", "$2b$12$VXjoM.Zx7GVhMXEvt5XMaewU7R5wAHaKgQeagDukATNhY3p8rNieK", "0620000006", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "8112e653-13fd-c47d-0fc5-7b36eda72bf0", new DateTime(2026, 4, 5, 21, 23, 11, 972, DateTimeKind.Utc).AddTicks(1513), null, "studentb25@etud.fr", "Yanis", "Yassine", "$2b$12$YjKCW5Uyeugr/.YlG171gOnHSKs0mYW2k0aKARe9f6zFLZ.3DtYmO", "0620000025", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5", new DateTime(2026, 4, 5, 21, 23, 10, 464, DateTimeKind.Utc).AddTicks(6413), null, "studentb20@etud.fr", "Nadia", "Tazi", "$2b$12$b0pzeQOTMpAWBzNiv4py0.kMljWVVlonYRDTsJ1gUAq/Sebz/ZfWS", "0620000020", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "8e85356b-dff7-0fe0-9e0a-ac24101ff81c", new DateTime(2026, 4, 5, 21, 23, 7, 131, DateTimeKind.Utc).AddTicks(8854), null, "studentb09@etud.fr", "Sana", "Ibrahimi", "$2b$12$cJMqDufZD09eMqJaeZpbvuxKl5cRRVYH49rxh0kbYO.EkqoR.0EK.", "0620000009", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "8ee02cf3-bf69-3090-c8a3-acd718cd445f", new DateTime(2026, 4, 5, 21, 23, 5, 952, DateTimeKind.Utc).AddTicks(3646), null, "studentb05@etud.fr", "Maya", "Elouafi", "$2b$12$Y3IRypmKX0gCumes68PDH.tHkHR41pH5tsyikBEwVY6lH9rUqWUrm", "0620000005", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "91f97c43-df32-927a-bb77-3f050c28c5d1", new DateTime(2026, 4, 5, 21, 23, 7, 426, DateTimeKind.Utc).AddTicks(4133), null, "studentb10@etud.fr", "Adel", "Jabri", "$2b$12$zC/KvLAn4OoGhDM7OBPYQerv0qv74U7PuYW4UWQeFTS0pCaPSrFhy", "0620000010", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "954d4710-fb9b-9bc8-33d6-1a00378fef99", new DateTime(2026, 4, 5, 21, 23, 13, 159, DateTimeKind.Utc).AddTicks(3355), null, "studentb29@etud.fr", "Ilyes", "Cherkaoui", "$2b$12$.wypfTwAIAKgfJIwLHqNEe8e572SP3gbA4NGsezUMYgAVFJpFDCO.", "0620000029", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "95755e71-293b-5fbe-2e06-ff9c6d90e96f", new DateTime(2026, 4, 5, 21, 23, 9, 544, DateTimeKind.Utc).AddTicks(4582), null, "studentb17@etud.fr", "Leila", "Qadri", "$2b$12$HBmL26HCApOnPR6ZYWLvtuOt5XJyvM12UTFiSxrl6lFp3pEAbjJwG", "0620000017", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "96cb69c8-c721-11de-8075-582c3bb936c3", new DateTime(2026, 4, 5, 21, 23, 12, 268, DateTimeKind.Utc).AddTicks(1692), null, "studentb26@etud.fr", "Sara", "Ziani", "$2b$12$8gb0vHSUBkXOx.J2REG4nuXv4wcjGupv0C1OseXiS/wEBjFJkvtoK", "0620000026", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402", new DateTime(2026, 4, 5, 21, 23, 9, 862, DateTimeKind.Utc).AddTicks(8188), null, "studentb18@etud.fr", "Romy", "Rami", "$2b$12$BElPSM8jL4R3IWLQZVIMBOymewtUQzgL1YB90PqaCYg5GYbdqK5lm", "0620000018", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "aeba3eba-9c59-d115-5781-476232f36f4c", new DateTime(2026, 4, 5, 21, 23, 10, 166, DateTimeKind.Utc).AddTicks(7687), null, "studentb19@etud.fr", "Samy", "Safi", "$2b$12$cwWsTZwgD2M8ArOsjxMef.sYyay8XNJjRt4DbQXqQdXJj6rN4U6Tq", "0620000019", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "af142cbb-a95e-ab3e-f00a-a39f87004ec3", new DateTime(2026, 4, 5, 21, 23, 5, 54, DateTimeKind.Utc).AddTicks(839), null, "studentb02@etud.fr", "Nassim", "Belkacem", "$2b$12$2sb5dcGTkw3Qzlc7.43tdO3f1f5tSu4.Zn66OfWwJ3cHfmhfDuIPW", "0620000002", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816", new DateTime(2026, 4, 5, 21, 23, 11, 669, DateTimeKind.Utc).AddTicks(441), null, "studentb24@etud.fr", "Loubna", "Xerri", "$2b$12$OoHTDVaZyq4JTNJO9qW7c.kiiYGLPHRGUifLyHl7myWoQB5aIslXK", "0620000024", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5", new DateTime(2026, 4, 5, 21, 23, 8, 15, DateTimeKind.Utc).AddTicks(5758), null, "studentb12@etud.fr", "Karim", "Lahlou", "$2b$12$2LZmxbBWVjZgE8gIKsTPCe.GWzhehzhMV7mWoRGSqq9bUUCM6RMI6", "0620000012", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "c2dd0d11-f58f-2546-c1ca-10b453a7bc96", new DateTime(2026, 4, 5, 21, 23, 12, 568, DateTimeKind.Utc).AddTicks(507), null, "studentb27@etud.fr", "Adam", "Arif", "$2b$12$oCBhcM2KIf1J6Hxp3U.V8e3OOU5x3c7Ijx6.Z6IpeFgENQht7rD16", "0620000027", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "c668490c-dda2-f1b1-d170-72005fc34624", new DateTime(2026, 4, 5, 21, 23, 9, 238, DateTimeKind.Utc).AddTicks(2358), null, "studentb16@etud.fr", "Anis", "Perrin", "$2b$12$q0lVHUO0MnZVz2KCJuzHlOYEiJ31CKR5oGYRZAaeKEDxSRvvDJ0ey", "0620000016", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "c8936e2c-61ab-766a-1161-ed4577bda964", new DateTime(2026, 4, 5, 21, 23, 11, 369, DateTimeKind.Utc).AddTicks(9948), null, "studentb23@etud.fr", "Bilal", "Wahbi", "$2b$12$Nbq4TDd6qunDzwU/gJFQkuJ91MZ87nLitFZ2ZC5hAlUkgVX6iYd9C", "0620000023", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "ccd1db56-b977-3035-ca07-0d16377dbbe1", new DateTime(2026, 4, 5, 21, 23, 6, 542, DateTimeKind.Utc).AddTicks(6097), null, "studentb07@etud.fr", "Nour", "Ghali", "$2b$12$MppeF2Uf/2BDGgEM/KFJLetr..9/mgWg/IwrrP6ymQYbs57QJH6RS", "0620000007", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "d8924a08-9bc1-e88e-8396-1a1e86e2276b", new DateTime(2026, 4, 5, 21, 23, 5, 348, DateTimeKind.Utc).AddTicks(4017), null, "studentb03@etud.fr", "Salma", "Chebli", "$2b$12$XkqabpGhDHWWsQw2vNAyAe/irvruO7iFL/i2iRYPNa9wREgcQLbIa", "0620000003", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "user_id", "group_id" },
                values: new object[,]
                {
                    { "03428ee8-3d9a-de72-c98b-dbc65724b005", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "18241d26-a012-b189-957c-b5573ecb15d1", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "3830d83f-4097-76e0-a9e0-b90ef45d1c79", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "4d41b3e5-536d-0aa0-a3e3-024218ac6267", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "51432fb0-cda4-87aa-a2d2-e36c25823a2b", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "52fb0554-7e57-01bb-5949-987520c91eb5", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "557dd714-15d7-6df3-3ed1-22a2eec63c59", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "57f13355-ddb7-5d3c-b09a-ff2c56e22753", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "617cb820-a96f-5ce4-513e-f9de2ec06556", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "68fbd87f-0c94-976f-40de-323667ff06bf", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "8112e653-13fd-c47d-0fc5-7b36eda72bf0", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "8e85356b-dff7-0fe0-9e0a-ac24101ff81c", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "8ee02cf3-bf69-3090-c8a3-acd718cd445f", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "91f97c43-df32-927a-bb77-3f050c28c5d1", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "954d4710-fb9b-9bc8-33d6-1a00378fef99", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "95755e71-293b-5fbe-2e06-ff9c6d90e96f", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "96cb69c8-c721-11de-8075-582c3bb936c3", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "aeba3eba-9c59-d115-5781-476232f36f4c", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "af142cbb-a95e-ab3e-f00a-a39f87004ec3", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "c2dd0d11-f58f-2546-c1ca-10b453a7bc96", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "c668490c-dda2-f1b1-d170-72005fc34624", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "c8936e2c-61ab-766a-1161-ed4577bda964", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "ccd1db56-b977-3035-ca07-0d16377dbbe1", "64b93cdc-56f3-906f-6e4c-2adfe2184501" },
                    { "d8924a08-9bc1-e88e-8396-1a1e86e2276b", "64b93cdc-56f3-906f-6e4c-2adfe2184501" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "03428ee8-3d9a-de72-c98b-dbc65724b005");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "18241d26-a012-b189-957c-b5573ecb15d1");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "3830d83f-4097-76e0-a9e0-b90ef45d1c79");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "4d41b3e5-536d-0aa0-a3e3-024218ac6267");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "51432fb0-cda4-87aa-a2d2-e36c25823a2b");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "52fb0554-7e57-01bb-5949-987520c91eb5");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "557dd714-15d7-6df3-3ed1-22a2eec63c59");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "57f13355-ddb7-5d3c-b09a-ff2c56e22753");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "617cb820-a96f-5ce4-513e-f9de2ec06556");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "68fbd87f-0c94-976f-40de-323667ff06bf");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "8112e653-13fd-c47d-0fc5-7b36eda72bf0");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "8e85356b-dff7-0fe0-9e0a-ac24101ff81c");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "8ee02cf3-bf69-3090-c8a3-acd718cd445f");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "91f97c43-df32-927a-bb77-3f050c28c5d1");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "954d4710-fb9b-9bc8-33d6-1a00378fef99");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "95755e71-293b-5fbe-2e06-ff9c6d90e96f");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "96cb69c8-c721-11de-8075-582c3bb936c3");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "aeba3eba-9c59-d115-5781-476232f36f4c");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "af142cbb-a95e-ab3e-f00a-a39f87004ec3");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "c2dd0d11-f58f-2546-c1ca-10b453a7bc96");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "c668490c-dda2-f1b1-d170-72005fc34624");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "c8936e2c-61ab-766a-1161-ed4577bda964");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "ccd1db56-b977-3035-ca07-0d16377dbbe1");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "d8924a08-9bc1-e88e-8396-1a1e86e2276b");

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "group_id",
                keyValue: "64b93cdc-56f3-906f-6e4c-2adfe2184501");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "03428ee8-3d9a-de72-c98b-dbc65724b005");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "18241d26-a012-b189-957c-b5573ecb15d1");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3830d83f-4097-76e0-a9e0-b90ef45d1c79");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4d41b3e5-536d-0aa0-a3e3-024218ac6267");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "51432fb0-cda4-87aa-a2d2-e36c25823a2b");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "52fb0554-7e57-01bb-5949-987520c91eb5");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "557dd714-15d7-6df3-3ed1-22a2eec63c59");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "57f13355-ddb7-5d3c-b09a-ff2c56e22753");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "617cb820-a96f-5ce4-513e-f9de2ec06556");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "68fbd87f-0c94-976f-40de-323667ff06bf");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8112e653-13fd-c47d-0fc5-7b36eda72bf0");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e85356b-dff7-0fe0-9e0a-ac24101ff81c");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8ee02cf3-bf69-3090-c8a3-acd718cd445f");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "91f97c43-df32-927a-bb77-3f050c28c5d1");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "954d4710-fb9b-9bc8-33d6-1a00378fef99");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "95755e71-293b-5fbe-2e06-ff9c6d90e96f");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "96cb69c8-c721-11de-8075-582c3bb936c3");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "aeba3eba-9c59-d115-5781-476232f36f4c");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "af142cbb-a95e-ab3e-f00a-a39f87004ec3");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c2dd0d11-f58f-2546-c1ca-10b453a7bc96");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c668490c-dda2-f1b1-d170-72005fc34624");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c8936e2c-61ab-766a-1161-ed4577bda964");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ccd1db56-b977-3035-ca07-0d16377dbbe1");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8924a08-9bc1-e88e-8396-1a1e86e2276b");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 4, 479, DateTimeKind.Utc).AddTicks(7934), "$2b$12$2tqgNN4GkiZnQ31roef7Def9MIIrQwgi3Dw5HkTOISqyQ6SF.Dji." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 8, 603, DateTimeKind.Utc).AddTicks(8072), "$2b$12$YK8T4Zp.FVNwBBwOGtoA6ORVZ7eXHCeQsFuEREVKh4opqzkQr787C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 0, 307, DateTimeKind.Utc).AddTicks(6957), "$2b$12$ul3rb.M0F.dGxn6yHjSX..r5EH/wDBOcUK8e8F8qRflipJxWd8TtW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 11, 578, DateTimeKind.Utc).AddTicks(4189), "$2b$12$tv4csSn7.5gP1WSNbGsZkObC15CZhRyC0Kb6i9KN246bgvciHMwu2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 14, 835, DateTimeKind.Utc).AddTicks(5915), "$2b$12$pEvGRQOROG2Atyzy2SS2tu3q7NQwXQjqQ4V5zB4.ka0m..J5hNW/6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 1, 816, DateTimeKind.Utc).AddTicks(6457), "$2b$12$BgxR//YE6FD5tFaUBy6fUuC0LzrhLS9JPPJoSEdLlNlvtrw1ZDNru" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 7, 410, DateTimeKind.Utc).AddTicks(9135), "$2b$12$OcCua9Efi85AdUZ5QR6XWOmEfhalrUn4XX4.FHEcVVO864ENcYfKK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 2, 699, DateTimeKind.Utc).AddTicks(6058), "$2b$12$wKd6I8DQIuVaBVmT5JP0sex5Ajpk8TuN01HQYqp.ZSe6LzTMfma/K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 3, 292, DateTimeKind.Utc).AddTicks(4091), "$2b$12$OuJJ8LdjUMJWGeVLZ/ex6.7P1PAKUCjOpv2ARJsgLHFxEN9R4L./C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 13, 953, DateTimeKind.Utc).AddTicks(7037), "$2b$12$LrPmgLe9PxOT6/gsx2Tr6ektV5ZxuzpRzF8oV342l47DkWe.ZV9Fe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 5, 59, 404, DateTimeKind.Utc).AddTicks(8881), "$2b$12$5o28QZ.Ii1nW1a2LEnSU7eb7ZZsqFFXPOYqNe2DwiZl26Ou.GdV7S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 7, 118, DateTimeKind.Utc).AddTicks(4318), "$2b$12$sQlcHpX5zDKlswLuIHY3CeFsvjva0BADMX3tBY/yR64aRskhAN5M2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 0, 913, DateTimeKind.Utc).AddTicks(6616), "$2b$12$UNU00U/5FHdULDfxScVMaeNXCYzzxUomBq/cvJB1wxNQUU5stgEkW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 0, 606, DateTimeKind.Utc).AddTicks(331), "$2b$12$RHndgaJyNY191muNu/fAC.13HSwH2u1w7fNDiqXtSBzE9MXEMEH5O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 3, 890, DateTimeKind.Utc).AddTicks(6084), "$2b$12$la9gqf/B1JzrH8KZ7qnTAOoCAFy02tCj/G1qPyXaayOlR0S0w4H3K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 1, 221, DateTimeKind.Utc).AddTicks(2106), "$2b$12$Js099kAmxjryZjCHkY02vusxALpQuuXG2I8l40tHS9kg4rjFlxmay" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 5, 360, DateTimeKind.Utc).AddTicks(9338), "$2b$12$LVPMBW66fXLUJ/TWsgePP.xH/bOHQZU9FcgJjrao1gL/tBX05JPuO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 2, 406, DateTimeKind.Utc).AddTicks(800), "$2b$12$nqAfIomcY7p8XhriEvtJj.r8PBAZ5147kq7B7YrW5z/qkPCtgxxiG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 8, 287, DateTimeKind.Utc).AddTicks(6878), "$2b$12$g/t7ej.0obIPfkrS42S9NOXK0klXQ8qIjm8gW8e9Uldm/ULibkTCG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 12, 766, DateTimeKind.Utc).AddTicks(9623), "$2b$12$zC/MG3GlpFY1pPIQYLn1GuMz.s3pU1BZoL97ZCQX30eMzRLohjfPG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 14, 541, DateTimeKind.Utc).AddTicks(3972), "$2b$12$4byjXDp2aqFndKXLEdIub.OZE8c0J8ieTYI.xBKeuHlrwWRZwBR/K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 5, 654, DateTimeKind.Utc).AddTicks(2066), "$2b$12$oC0JvTmXRWlgpwYYO1GJGOyQmxv80OBh.Ws56gvsHLiAUlPica2zC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 13, 658, DateTimeKind.Utc).AddTicks(5880), "$2b$12$X.yyDH6YiXGZQtraL1dx3uYNZel3cMMFtLYoK8e3poALdrCvY4M/u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 10, 371, DateTimeKind.Utc).AddTicks(3663), "$2b$12$VKs5P9GWR.HTFRgEWNGszOV8UV1RoWaI.vKimjuc6JtcirKVCm322" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 10, 973, DateTimeKind.Utc).AddTicks(5757), "$2b$12$NDMj9wTyR2B/1xuasxw6SexCKW87gxD0F8Yq0gjXHGu5KQec8rmEG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 10, 664, DateTimeKind.Utc).AddTicks(4343), "$2b$12$bkTdIlEUcQdgNeYsJXma3eLAInjP/SmVTQp.yRAn7AyVaFyq2S59W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 9, 488, DateTimeKind.Utc).AddTicks(4463), "$2b$12$9iTfijh13HZPxvi808cGsuQjQp4yRkyGMRUp3aQXNkV3NyNpZYpiC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 13, 62, DateTimeKind.Utc).AddTicks(742), "$2b$12$utjtZP2yvE2sPGC65AkdQehWcMvIyf8HAa7E/GL548MqxGSmaSeV2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 9, 782, DateTimeKind.Utc).AddTicks(6915), "$2b$12$hTgAmWd8svCq3MQVwoB4DOw3qwnIOzNgowKFTPNhFWigqp00T2SBy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 11, 882, DateTimeKind.Utc).AddTicks(6454), "$2b$12$aAIXgeSwRxeGW3RnmAfENOei0MWWSt9P1JzQUciNUJuNxE8Pux0O." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 13, 356, DateTimeKind.Utc).AddTicks(4292), "$2b$12$qd/q7kYEX0y2CYsub3V8seBl45XLlfc.2OW2NRZTGbR8Syf6gi7gi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 7, 996, DateTimeKind.Utc).AddTicks(6910), "$2b$12$HiseForhqJAli88JAvR9GuKWzoYzDp50vhzhj8Sswnsf4k6oSX.CK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 5, 59, 706, DateTimeKind.Utc).AddTicks(3814), "$2b$12$FfG.tb35RGk4TB54nXdPl.Bem.9quwLMYWWG5nhEFJU5p2u3p5SwK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 5, 948, DateTimeKind.Utc).AddTicks(2859), "$2b$12$XkG4GNs55b/wp5SZq7Wbi.qg6cNLWnShGW0wH7.xUlN3rxvWK46Qu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 2, 997, DateTimeKind.Utc).AddTicks(423), "$2b$12$EhOB7UuVEUAvCo1FPocjt.DLJZpu/VRrKuu.JuoCYZ11dQcawOTRm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 7, 702, DateTimeKind.Utc).AddTicks(6040), "$2b$12$jP94iZ0vtv96qF8GaaQ.xe.T34BAJD9EZoQ/LFp16Ed6EyjPzlSnC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 6, 827, DateTimeKind.Utc).AddTicks(2622), "$2b$12$44KXkHJQ/k2Modtg5nKhiOWEMfXYjmn80irhFrnz7SfRU0AtYv1Va" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 14, 247, DateTimeKind.Utc).AddTicks(3528), "$2b$12$7gwoCXcbFRuqEOVeJjoSfuBxqYFR/WHqds8afcvWqNZD6hx43jbQC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 3, 593, DateTimeKind.Utc).AddTicks(5237), "$2b$12$oNVfOuPRLvenG1yTHD8FteQknGIx27atlshbACcDXTok/kUFEc.IO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 2, 111, DateTimeKind.Utc).AddTicks(7416), "$2b$12$DQDDMPUd2l9EVTn6xBHzf.gVM5btZcyfYOKI.2l7fPxiInu3VVY2K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 8, 900, DateTimeKind.Utc).AddTicks(197), "$2b$12$cPd3P4SACndITY7KwPWi8.tf6MgcaYq/WdbTaAT/OxVBtP6NezIE." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 0, 8, DateTimeKind.Utc).AddTicks(264), "$2b$12$NVOD6yqTojs2XglwXXZCu.dTtN1RmE9JKmAwoFBuRfEGEouVTUj2u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 10, 77, DateTimeKind.Utc).AddTicks(4568), "$2b$12$KDSGYDV6YWtG2ajHj64R/.P7h57IqAa77n1Mf.ddAyrCM37IM9osO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 4, 185, DateTimeKind.Utc).AddTicks(1917), "$2b$12$3.DFBmbkKabNB0whXsDUeeYp3ngw6i3Sjkq060fHy/W7DGTySk6BW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 12, 178, DateTimeKind.Utc).AddTicks(1990), "$2b$12$sSekxlFuIjsOazwFXHMR3OT1d8xH5tDZdyM.lQ7lcuxtpPLZd7vri" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 12, 472, DateTimeKind.Utc).AddTicks(4057), "$2b$12$WEBFZiLMAFLV1va6rghLnuUpTUwQYhJA8.3ggXfya7QDQOpA4qF3K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 11, 280, DateTimeKind.Utc).AddTicks(4980), "$2b$12$MxHgXAS34pH8IqKen9SWduXZshM8X9aFBGKHXHx40eAhK1NbDEhMO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 9, 194, DateTimeKind.Utc).AddTicks(3290), "$2b$12$tBWXqUj.d4YYgvZll43YnOhqArMrYe8FONWQ06rxxmHSL2wyBW75K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 6, 534, DateTimeKind.Utc).AddTicks(8531), "$2b$12$d23VwNHATzZbgqH7CIdqy.yJ2IoryLgK6hNtHNkeDfqS2NtFxaPAa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 5, 66, DateTimeKind.Utc).AddTicks(8418), "$2b$12$CP0dydhKzaMmGSO0sQMYuO9atnD0f8jJtuXrVIDu659sQml51N2qe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 4, 774, DateTimeKind.Utc).AddTicks(7187), "$2b$12$YadaBvL45cm7Rv9b3POxbeAz2Ft2wcopayd0TGtyuCdrEl16.DfRG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 6, 242, DateTimeKind.Utc).AddTicks(4305), "$2b$12$cvd7cL.8iOWY0pl6M/NSnO70e5uhZ2bHSuzXDxnbVw7MtEki0Byey" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 18, 6, 1, 519, DateTimeKind.Utc).AddTicks(8029), "$2b$12$3jxHjExEX/CI0jEuIMwrFuINBRJb5b60Fyg97dToJvWxOGo1CX9lG" });
        }
    }
}
