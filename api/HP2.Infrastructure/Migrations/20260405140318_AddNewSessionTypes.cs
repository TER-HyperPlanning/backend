using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNewSessionTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SessionType",
                columns: new[] { "session_type_id", "label" },
                values: new object[,]
                {
                    { "0fc6aed4-11a4-4bca-c1f3-c7060734aa3c", "SOUTENANCE" },
                    { "7d12ed93-7363-9686-49c3-77ad3ccb2da0", "EVENEMENT" },
                    { "b078845c-908b-88e0-b39f-65cac002c8e9", "EXAMEN" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 11, 371, DateTimeKind.Utc).AddTicks(9356), "$2b$12$xlqF/YsQee4gj1Vpl4YlQ.fw2XwByrizSPlF2MOhzPRvXJXvMbgeS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 6, 186, DateTimeKind.Utc).AddTicks(1817), "$2b$12$gMfRupjogGO5LSrFbDxbRefU5izQCBR/EtXOM1NmiPUiPpcwiIBYe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 14, 397, DateTimeKind.Utc).AddTicks(6390), "$2b$12$RHv7rb0DcpzbE0oFraebY.6HJvG9kY41UKUkjVbVsqStW3kySdcr." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 17, 862, DateTimeKind.Utc).AddTicks(7605), "$2b$12$IHZkyxHEeK4jrT953italeQJ9zizb3HjN3Ds7tXbo1FKVqPia87ly" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 7, 718, DateTimeKind.Utc).AddTicks(89), "$2b$12$ZG1sEJBmV6ud7HL3gSfXZ.kZAo.FNRHbEF/.ADyP/sjjDpg3vYomW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 10, 173, DateTimeKind.Utc).AddTicks(1848), "$2b$12$a6L.wT7tIM/AZXScVyDsRu4PKvT3TrpRyuUfNQ6xL4cFcn/TXNtWW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 16, 938, DateTimeKind.Utc).AddTicks(7740), "$2b$12$KqMbRmuzt9dCnEMDtEwfc.7Mo5vFP8.QFJW6Eup7S5Pe.bdDnAkVm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 5, 265, DateTimeKind.Utc).AddTicks(6840), "$2b$12$FrXXhp0Ytq5PcoIIJjj6wOefyzu9twUjW9/QTqdgSlpelEtA9uaWG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 9, 877, DateTimeKind.Utc).AddTicks(5365), "$2b$12$ZSrF0AwNZ.ijYOMtvwMKPeEG5.H5NBP5eL1E26lYc/LcoqeSWRBQy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 6, 799, DateTimeKind.Utc).AddTicks(6241), "$2b$12$h5fWnHzGgTuN8j83tC5bzuD5JFd3P1uoAWP/WJ4ZmxGBr1XgBEyXG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 6, 488, DateTimeKind.Utc).AddTicks(7722), "$2b$12$3O8TqNViqwh67tZV4sFtTuMJ1RPtW5AoZ.TbNBnqfN1reqdKAMtgy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 7, 115, DateTimeKind.Utc).AddTicks(8390), "$2b$12$.MmRlqD4ajr9FFKr5xvfMuEiePtYaYsyQ9clh7EXFb6uEOc4mmTMC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 8, 369, DateTimeKind.Utc).AddTicks(8518), "$2b$12$Jd4iCM3aT.VbregCr676AuQdgJpVTQhjcN7IFpZOVinBz6woQKweS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 11, 70, DateTimeKind.Utc).AddTicks(6730), "$2b$12$LsRB.Pd0rOk13/PsnlRrzOLzCeK.k7uN/IbTWaCpyNbkcvWABSPo6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 15, 715, DateTimeKind.Utc).AddTicks(3091), "$2b$12$gFekeZmvF3UIPi72rgLIBOyBZncDPhSj5DMgXczlTl//Vp5834UGG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 17, 557, DateTimeKind.Utc).AddTicks(8161), "$2b$12$XSh658gWoWlRhpQ0tNrSMepFlGYypKdsfo73MphNdA.qaroP9c.4i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 16, 632, DateTimeKind.Utc).AddTicks(3833), "$2b$12$aDXwObQ1AkmhQ0CCaNpOsOpbgKQJAq4/RcUY6Iim06sLKSQDZM1gC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 13, 164, DateTimeKind.Utc).AddTicks(5374), "$2b$12$Loe/gYiEeb8VDHGAo21.Vuza9CMtwp6F5M4nUv2RuTBIr2mVQ3nDK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 13, 772, DateTimeKind.Utc).AddTicks(359), "$2b$12$t44G/.EkWuZHE2/C6sEWq.dxX8C5okR4C2s02QCd/ioB.HpLzjhHG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 13, 466, DateTimeKind.Utc).AddTicks(4585), "$2b$12$PXoPGvTN3MAXyoxpMcCZv.091GMNSzfYyL8w91Q4jiJ92v1.C/Bri" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 12, 265, DateTimeKind.Utc).AddTicks(9962), "$2b$12$MSr4e5WhTVo4PfCePsemxOqbxO8XdOb3WSBT84TVhaQxBibrK/zRu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 16, 20, DateTimeKind.Utc).AddTicks(3694), "$2b$12$WDpV1cWkw/WyjEQi9R67QOZnqWMTjxzoKd5CHIYgKlyLRWrlezbo." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 12, 561, DateTimeKind.Utc).AddTicks(5111), "$2b$12$.2Ut2b0b9aj3oTX9qa.a3uLbBW7OjGYChwzYhtjVlgp6sEQ6T23dS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 14, 708, DateTimeKind.Utc).AddTicks(9021), "$2b$12$c8aZb8tCM6hRWNQgA3U/P.UU1vpM9C.uTpPYiDiOOLW2.hWq2QQZC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 16, 326, DateTimeKind.Utc).AddTicks(9610), "$2b$12$lyDGbbwZPe4yWWWFcIsbM.9MyYE59QcLDdgH2M6vdkJAvkOtQ5Qcq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 10, 770, DateTimeKind.Utc).AddTicks(43), "$2b$12$DcRmG3xIUB6IYpJJTLTw1u8hQhy7bek0fB11WJaS3rK.MUFuSYp4G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 5, 573, DateTimeKind.Utc).AddTicks(4375), "$2b$12$v5hu4FRU0C.4cZBTFw3nmOBy1ZsRUvtZY8OsiJptvIKgc4wlHlneS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 8, 674, DateTimeKind.Utc).AddTicks(3677), "$2b$12$Lhcu1SKm5j65UqMk.r2ewuOc4GzjC22IAts859dzQt/plpvP2hXjO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 10, 470, DateTimeKind.Utc).AddTicks(2332), "$2b$12$B4Zd/1wc8shJ514FPYAVaeXOUAam7wHdLmxfKKfqFbCLjVpTbtIcS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 9, 576, DateTimeKind.Utc).AddTicks(1062), "$2b$12$/qBtauZaDMfQfJ61dY8yxercAKEw90GTcDAN3XYPargoGyPUlcbQi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 17, 254, DateTimeKind.Utc).AddTicks(5189), "$2b$12$JiKJjQvJkDl9.I/tzPqGEuYYxsro20BNemvtDDWEPwWePUmPG3WTi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 8, 62, DateTimeKind.Utc).AddTicks(6844), "$2b$12$PxEH1kElZgbGWMQ0xudXXebX2WQa8Krj3pH3h4AqQ7PASA7ysML6O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 11, 672, DateTimeKind.Utc).AddTicks(1438), "$2b$12$xd9JvpHh7Pbb7aoq0F1AseLtieoiKTDz13WaNzwII/yA1kYwyvLqW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 5, 880, DateTimeKind.Utc).AddTicks(8130), "$2b$12$/gSK/HvC0Hls2T0lRwty6O.Sab7N6CYMurhVlSTxnQaoG5HcwLcxm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 12, 862, DateTimeKind.Utc).AddTicks(7657), "$2b$12$cvLys0Gr9iFJuaYo576PO.xXj4KWv6NShzPbQkQGzjwWVF9zhMLS2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 15, 59, DateTimeKind.Utc).AddTicks(8918), "$2b$12$Xw3zESgQoguvkmQnZ4wTjeBLmcaBkr78Jwx/EkiP8jXiys/78KVYO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 15, 410, DateTimeKind.Utc).AddTicks(1545), "$2b$12$wS/.pOMhcqvjaF/O0z7A7.tgq8w3SWKMDNmm8m542wSdoz6ibQKIu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 14, 82, DateTimeKind.Utc).AddTicks(9259), "$2b$12$EBNv4ZWi8CKFg2hejW0nZeouPBLNueNDR/G8.KDacGceqNstT3pIa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 11, 970, DateTimeKind.Utc).AddTicks(4269), "$2b$12$ioezvQbun.1QcluMxgBV2e.hPyKFo.5Qd6gkTi4sYIyqsQjnb0eO6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 9, 274, DateTimeKind.Utc).AddTicks(5948), "$2b$12$zMJUuXE8h3yBqHwaGAJX3O4yOS2NyF3TnpWSnDESS.L3h7uGbMFq6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 8, 972, DateTimeKind.Utc).AddTicks(9237), "$2b$12$2u4Ogab2twphNbbBxlytyeuVV9w5m/7fuuTIJu9VZbEVZDbKEGJcO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 14, 3, 7, 415, DateTimeKind.Utc).AddTicks(7315), "$2b$12$LxiNIktkWkk/y9YGZb3NxO7gN.w/xyshUZxuSlqlVuuFNb.phOm9m" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SessionType",
                keyColumn: "session_type_id",
                keyValue: "0fc6aed4-11a4-4bca-c1f3-c7060734aa3c");

            migrationBuilder.DeleteData(
                table: "SessionType",
                keyColumn: "session_type_id",
                keyValue: "7d12ed93-7363-9686-49c3-77ad3ccb2da0");

            migrationBuilder.DeleteData(
                table: "SessionType",
                keyColumn: "session_type_id",
                keyValue: "b078845c-908b-88e0-b39f-65cac002c8e9");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 11, 801, DateTimeKind.Utc).AddTicks(9548), "$2b$12$3yUR9HAMyeFIL33dIhp.K.cuJK3hdk.8fVRYQ337E20lya1MYbw6S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 6, 506, DateTimeKind.Utc).AddTicks(9698), "$2b$12$13BKNGc2XJ1w6zPJ0JR.ZOXlE3Qv93LZ41/dTdsEiOFoW2SfH/hR2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 14, 882, DateTimeKind.Utc).AddTicks(3445), "$2b$12$L1mpndTvsLNPsaDaPQJDxuYkZfOvZVnuCWfSCoZ0Ih4Iuy1ocRTWK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 18, 270, DateTimeKind.Utc).AddTicks(2968), "$2b$12$MjrCzgrXsXvzdxOw4YtdWeuuN1H.9sHS28mPfynZFiaOSZ82DyZ0." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 8, 50, DateTimeKind.Utc).AddTicks(5774), "$2b$12$dbqU2.UkpGi2gyN3BUF7NOvEKA6waHM0WsTPVD3RZ/gJpn8nY5tB." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 10, 547, DateTimeKind.Utc).AddTicks(3344), "$2b$12$fErG0K9NMJH3htOOvzY0Q.JOhTwxDhwvUFl9JVQcYDHQbU0vaPfAa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 17, 277, DateTimeKind.Utc).AddTicks(8787), "$2b$12$MWdJZcMYd5Vzcjq5lUeaLOZRxD0JIwvIkxmfvgo6C5wZpiz0uEu.u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 5, 515, DateTimeKind.Utc).AddTicks(8938), "$2b$12$BPriICWc4A8CB8hsDkN23udBZTqdGmm8hP5SpdIl0teVOfYCLX0GK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 10, 239, DateTimeKind.Utc).AddTicks(1803), "$2b$12$yeWQ0LrxHPfCDWo.Mtf4n.WWLSb4o0kWSK4K4SNDM7XNKHjilhmei" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 7, 109, DateTimeKind.Utc).AddTicks(4879), "$2b$12$ra993J1/kelYnbmV30b7SeN71Db2Mjk1Di16x1rQdxFNGcnEbMpi2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 6, 806, DateTimeKind.Utc).AddTicks(5225), "$2b$12$eUjyBKO4RvmPsg3BoVb7jepgk9eQEzwJoMxEFRd3wdoHGaMWhRobK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 7, 413, DateTimeKind.Utc).AddTicks(9312), "$2b$12$SLyUBQXsvFPQMNZ5Lko6DOyoyOHphFsDG/c0uofy9682xRct72pWe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 8, 698, DateTimeKind.Utc).AddTicks(4060), "$2b$12$ew.Y9nUY4zM/fWoUwwOp6uKvNDTd5RyZA3etEZ9UMUF3hHh25..nu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 11, 503, DateTimeKind.Utc).AddTicks(2430), "$2b$12$PhGbm5WVADRsn0nAXL.PyeTjncltUE1USh1/CiWxdy3IkWSL8sH8G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 16, 80, DateTimeKind.Utc).AddTicks(8092), "$2b$12$ZlO4W9i3kENttn/5qv0W.OWo1Ki6rA6bMX0Py9McWn3L5pcu.vbLW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 17, 952, DateTimeKind.Utc).AddTicks(3191), "$2b$12$Z6aR/zZ/pktjsxP0PZjmueERbbyFLpMHQxZmgaDkliqQ/GmqT0yH6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 16, 982, DateTimeKind.Utc).AddTicks(3234), "$2b$12$aX/K5L3pgKA.u4YrVrftL.KWajesiNa.ApDj2vt09TMboq79UBnLm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 13, 629, DateTimeKind.Utc).AddTicks(5748), "$2b$12$G2PAUfhpsKk6WgXH8PDYEOTAvAnBauJCTwz7puXkdeyGvBe6eq8T." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 14, 238, DateTimeKind.Utc).AddTicks(8209), "$2b$12$5tuwiRav2quiPg/f7CnkpOx2LsN/YYIAwHdahgvW9ht1fdRf.G8B2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 13, 932, DateTimeKind.Utc).AddTicks(3390), "$2b$12$6LuE/DMcESbqtfHBtfwFkuKgfeseoOXdowkaAL1uN1CdlhB2Pkqk6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 12, 719, DateTimeKind.Utc).AddTicks(5526), "$2b$12$HcXcNNvPh.BRtC/LojruJeOwbeTQxgBTq2iUHblHtyPs/TfRkbXUK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 16, 378, DateTimeKind.Utc).AddTicks(2495), "$2b$12$fWz5Uge7RA0VWERDX06gjuxMPiDb8pxABHfn.0AEVPxCdXcXUqff2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 13, 25, DateTimeKind.Utc).AddTicks(8432), "$2b$12$To6SWWS8dmf8OnhAzgx/r.kIAdZNOwd0jC1974Go52sc4Yp3H8qTq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 15, 192, DateTimeKind.Utc).AddTicks(6311), "$2b$12$XusTTp9ojwiMH0CGyYiIIefyzuKpoyJGmuhABM9xuCROfX/FxMjYu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 16, 687, DateTimeKind.Utc).AddTicks(675), "$2b$12$o/0w2tUJq.yhRqspvzH33.sFUN8U1hnZzDlf35PqDTAawMxmJJu1K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 11, 165, DateTimeKind.Utc).AddTicks(4223), "$2b$12$2Ng.BWbM3InOHqb/kV.PruVC5Kxlyv5MAmUmcEVHcCa4QDG1wMOb6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 5, 880, DateTimeKind.Utc).AddTicks(2961), "$2b$12$CfBJx2vx1NhiZeh4vcRt8eY55UiBjXmc9NAau4FBo3R2OrvIdru8C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 9, 12, DateTimeKind.Utc).AddTicks(5457), "$2b$12$ITNm5hx90J2eJqYOhD4ytOyGITZ8BtXFX3D8GpwH6g63lBvvnkTna" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 10, 861, DateTimeKind.Utc).AddTicks(3066), "$2b$12$exmYkn4Lu09Z2c5oscdbpes2LbhWC7BBt0E8U0SS4fRLtmi.h5nlW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 9, 936, DateTimeKind.Utc).AddTicks(6953), "$2b$12$D6dMYy1/y25PiiuS5om.AOWvaHEn22nJ4ucBvD1GXx9EqX/CwslQK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 17, 627, DateTimeKind.Utc).AddTicks(1856), "$2b$12$IIjgpA9gz0NlAes0ddyYf.7uWmOvyQlKVSVy2uC2Ty86wGVtlmXHS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 8, 352, DateTimeKind.Utc).AddTicks(6278), "$2b$12$cdkpqzyXktVBnspzcUjsxejggYFCQ11oSYzGP3UKQ3Xkkn0C4LDEK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 12, 103, DateTimeKind.Utc).AddTicks(8716), "$2b$12$F1HN1Mh2ogFkY4uBkvs2POGDcGh0I/mYiEnNpKKuo5/avI3VX6f1G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 6, 204, DateTimeKind.Utc).AddTicks(7197), "$2b$12$oqKhwD7.IaGYYTEUPkPJH.Ed3pAcFcPtwcKhk0Roh.7sHUGoC0NRe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 13, 323, DateTimeKind.Utc).AddTicks(4445), "$2b$12$S19p0GASwMyqQ6ZOnS4u9eIiOPW2XZUbdd0zkXXAxlyoIuuqh9GCq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 15, 489, DateTimeKind.Utc).AddTicks(719), "$2b$12$1igH2lJ3YlM8eOBEyohtOu.XhkCOcUM2GUmEBmakGsON0K.W1u8Di" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 15, 785, DateTimeKind.Utc).AddTicks(5261), "$2b$12$9MTP78hHcIMVhfcSjU9WKeDoB/dcB97q0yc5hEj6GbWeHcsXOFS1q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 14, 550, DateTimeKind.Utc).AddTicks(9529), "$2b$12$a2BXtrLs6sFnlLuFHs/03ejz9BUxIrOvz4Iip986KZen2/LddGgF6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 12, 405, DateTimeKind.Utc).AddTicks(216), "$2b$12$TbJp.qYuQc2RrOfcup8BReUpHHvrB1yaVRvQWUsItKwyNDBk5WJT2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 9, 627, DateTimeKind.Utc).AddTicks(2069), "$2b$12$TlUUhYPafL5U6qTlM1XI5.tnSEijyHo1J7jH4wzyaoA5v3tfIDIcK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 9, 320, DateTimeKind.Utc).AddTicks(8502), "$2b$12$IL699Z6Op0NVE5YSpKL2u.mKYAb6xjAxy1XsDhFncmmfD0UVQ/VeC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 11, 33, 7, 732, DateTimeKind.Utc).AddTicks(9314), "$2b$12$swkBVgc9frCNffcz9mq4ZOt0ztEPQWflKPPhOy/l7IiIWzi0u3OSm" });
        }
    }
}
