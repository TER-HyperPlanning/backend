using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoomAndRecoveryChangeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SessionRecoveryChange",
                columns: new[] { "session_recovery_change_id", "change_date", "change_status_id", "counter_proposal_date", "counter_proposal_end_time", "counter_proposal_room_id", "counter_proposal_start_time", "proposed_date", "proposed_end_time", "proposed_room_id", "proposed_start_time", "reason", "rejection_reason", "session_id", "teacher_id" },
                values: new object[] { "81b21082-3ff6-6699-2b66-67d6f6ead3e7", new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, null, null, null, new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0), "02bcf600-5d44-cca7-8b68-e763b00a6339", new TimeSpan(0, 14, 0, 0, 0), "Le cours a été annulé, il faut le rattraper.", null, "bac650fc-e433-b6c8-ea8c-5897aaca3ec4", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.InsertData(
                table: "SessionRoomChange",
                columns: new[] { "session_room_change_id", "approved_room_id", "change_date", "change_status_id", "reason", "rejection_reason", "session_id", "teacher_id" },
                values: new object[,]
                {
                    { "863cdc3c-e440-3359-c69c-777871286814", null, new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", "La salle actuelle est trop petite pour accueillir tous les étudiants.", null, "0a1e6c34-263b-19da-8f16-af1a8c36f35f", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "e2f35a55-7db2-4df9-3bbc-17e566a55b03", null, new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "d16d1a05-a70b-a5f5-6d3a-8013b24626d7", "Équipement audiovisuel non disponible dans la salle actuelle.", "Aucune salle compatible n'est disponible sur ce créneau.", "13000bbc-8fd6-1578-7278-d709f023eed3", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "011f7dd9-fd3a-3d41-6190-1f4489c299e9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 13, 7, DateTimeKind.Utc).AddTicks(3636), "$2b$12$k.KmozbpDrHgtjtF7bO8yO1yzwAkPu5g/qB1oDJQTLGoayC5IYqLO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "015a9397-c5c4-4b03-eb4f-86048ec621f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 34, 636, DateTimeKind.Utc).AddTicks(9592), "$2b$12$HhdIf6ahBrvQyIoDwcAQMOsxoK0F9paU8jTlNwMLvqTCRBSQlIDi2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "03428ee8-3d9a-de72-c98b-dbc65724b005",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 59, 785, DateTimeKind.Utc).AddTicks(5568), "$2b$12$UO646bJ3V1vcdqS961/voeCKaiFMqLZP2eDx4aFMFy/wJv8RAH06q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 32, 12, DateTimeKind.Utc).AddTicks(885), "$2b$12$Wvkk3tqY62DiflP14mLWp.Hs1ZCbAXRXRNlft.Ro1iEIRppca2T3O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 41, 208, DateTimeKind.Utc).AddTicks(5662), "$2b$12$GdIro2iSLwSuXa5zntYrKe3df04tG9G.kL70nlkoWLFreuRdqoEx6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0a3f73e7-67a8-750c-576a-49c22125bac7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 15, 209, DateTimeKind.Utc).AddTicks(2428), "$2b$12$SQ5f/rojyB7Lmm/8QNrfmujd1QxFyGarxoLTDS9Yqzd2BJAbU7TC6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 25, 878, DateTimeKind.Utc).AddTicks(6536), "$2b$12$4K05BeG5B2FI82s0c6whUeNyEZauobAW21bcOHfpjsGT7pj3J5vDC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b48ba68-2d76-43aa-8392-7b40b1aa1e19",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 10, 349, DateTimeKind.Utc).AddTicks(1114), "$2b$12$UHFnBIzKGS4kDnaCmMaNH.8Mbd.QCCWWTEca1hG7FfPrqvFgkkJCu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 45, 639, DateTimeKind.Utc).AddTicks(9163), "$2b$12$parR2XP7fV2GRQ/71Oelh.xWFFIworX3VgakA3xxaYrgsqwtDXSzq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "129452cc-6c9b-3726-5c96-54b67ac3b884",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 16, 542, DateTimeKind.Utc).AddTicks(2892), "$2b$12$Np/q80Yebv8BKFFjJMOQYe7BEslluE2RfpKOA9yEzGjlFKgaj47kq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 50, 494, DateTimeKind.Utc).AddTicks(281), "$2b$12$8.cqfBlDhZM.ni2zfrQYTO4AUdWS0rPU6rr/aVKJqXRICuNgq9PT2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 28, 60, DateTimeKind.Utc).AddTicks(6073), "$2b$12$Zqin7YPnSMUePmopPwRJteTjWBtjbwEY/P7689ppQDiVFIio4L3Eq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 56, 608, DateTimeKind.Utc).AddTicks(1837), "$2b$12$HiM21afqMT7Aw0svSDN9O.uzm0bKMsJpg/TufeLRLwYpoE8AQ.ZaK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 39, 454, DateTimeKind.Utc).AddTicks(6235), "$2b$12$T5yDEtQcb8bNqQdF0IGcSu/PS1DVzXtUbPDhpqUl8eSDx4dB3.24S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "18241d26-a012-b189-957c-b5573ecb15d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 2, 903, DateTimeKind.Utc).AddTicks(8257), "$2b$12$qQkgHdhD9/2XPuEq91JQvufy9VJ11.CiBkfRaGZT3CCPYIOoFkuYS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 29, 367, DateTimeKind.Utc).AddTicks(8181), "$2b$12$R0cOB5oCAeJUWqp.JxA5P.KmVH58fiQYXsHXw2yP1ASw4KqV3h6xm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 30, 246, DateTimeKind.Utc).AddTicks(9237), "$2b$12$XVsMR0rb5BTDBJd/DM8Fvu7AUzS0MyElEOdesLGRxKJmTdZL7qiCi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "288bdacf-8acb-a8d1-59f9-94f0cccb2086",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 8, 143, DateTimeKind.Utc).AddTicks(6207), "$2b$12$4zWCLQebbwVSs6vXZkdnJe8XaJmd9rzdolAPHhdblvlzcswlD3KVS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "296e74bd-c209-7f7c-d030-28e85a1aad75",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 35, 508, DateTimeKind.Utc).AddTicks(5699), "$2b$12$K1CIIeJPQkNND3bWSe8XIO1wHrByN7p9WSJrZQ5UvouIANZuLqbOu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2b5c3a92-dc35-b1bd-16c3-b0f8a21f29f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 5, 90, DateTimeKind.Utc).AddTicks(5390), "$2b$12$TsiAStejy9TVQRydSG05Qu.OH5/OPDguoCFHNTdu37Xb5/lQWb53C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2fa22e35-4eb2-7351-ee0e-a523ac305c44",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 11, 233, DateTimeKind.Utc).AddTicks(5317), "$2b$12$3WauCNuYNIyyD8WLDKK2p.NltPCRUlTNRsdDIdt9w6FI02rV3DOpy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 49, 180, DateTimeKind.Utc).AddTicks(9376), "$2b$12$NgyvzYXmTRQRbBVgoRTBPOFe6mmEMUYdTp07ylIeCewB4MYzdWbMq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "373399d1-2bd2-aee5-629b-43f96da8f03e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 16, 104, DateTimeKind.Utc).AddTicks(975), "$2b$12$fEbOu9rK67c6HV4oyhELPOYmDkkiZlPUaxKVRH9Lj.7hNUeGDwoqG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3769412b-799f-6b72-f74f-9b9b735058c2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 6, 394, DateTimeKind.Utc).AddTicks(4613), "$2b$12$n9sG.TrwWm7Iwwms7Td6Cuwl4SoPiOQ51DjB/EBk.z0w1JhCcpvvO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3830d83f-4097-76e0-a9e0-b90ef45d1c79",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 3, 789, DateTimeKind.Utc).AddTicks(1009), "$2b$12$CCUfR4LL.Z6tDJC/Cmd2se2emaUIgj8gUhTVhsGiS4OitdY2cBVPq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 24, 561, DateTimeKind.Utc).AddTicks(6978), "$2b$12$bVoJgmMBAwL/Rw8G3jSIBOWDl4uX84ms/3olUowp50vEXzTprNE.W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 39, 12, DateTimeKind.Utc).AddTicks(1699), "$2b$12$F89/p/n8NEupXZlnkcMREOY24w2cYZLiMmiPEad9n8h8581zoxt4." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 26, 750, DateTimeKind.Utc).AddTicks(350), "$2b$12$bV4dPZhYkVB6w07MwLbvcOktK.z7MAfZ.cGmZxyLzOX799L/ECJYy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "476292a1-d3ae-cacd-a58c-2d14790da8eb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 12, 122, DateTimeKind.Utc).AddTicks(4260), "$2b$12$dYRjsFjnNYzTm9XwHWboouwOOXmK3xP1I6m/Mqj/a6JYXFb4VRiba" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 26, 313, DateTimeKind.Utc).AddTicks(35), "$2b$12$GAZKg.GNpVAHlSMUHvkdY.lFUcVk4fNx5xFRA9oiN6Uqo42UpQOfm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4d41b3e5-536d-0aa0-a3e3-024218ac6267",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 55, 292, DateTimeKind.Utc).AddTicks(6749), "$2b$12$MrVuUYjmysKPfuSLUAhNDO6sD95j/X2iiSXodBYojRpUR3dig.opC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "51432fb0-cda4-87aa-a2d2-e36c25823a2b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 57, 53, DateTimeKind.Utc).AddTicks(9682), "$2b$12$R3vt7qc9YLIhj4tlStAgheJOdRvq810A9MvHpTKSAg221kkzv.iia" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "52fb0554-7e57-01bb-5949-987520c91eb5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 53, 990, DateTimeKind.Utc).AddTicks(4277), "$2b$12$Atxg.yX1cJMnVf5nO2xDfOdfnZ85ED1SSmgjOtAHZnG5M6156SFGe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "539ead07-d571-367b-79f7-68b21513886b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 9, 909, DateTimeKind.Utc).AddTicks(6178), "$2b$12$uAVezQI./6zY65mF4k9vl.WKJhDK2uo/p0Kw6NA9la/ixPZ91XWsq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "557dd714-15d7-6df3-3ed1-22a2eec63c59",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 52, 256, DateTimeKind.Utc).AddTicks(5312), "$2b$12$9ABXgrPLREHX/ub7qJtePOCy1LKq225AacFsWvhxPUnXOibTYLX3W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "57f13355-ddb7-5d3c-b09a-ff2c56e22753",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 50, 934, DateTimeKind.Utc).AddTicks(8377), "$2b$12$EEYn7ckJoA6uMtKaDlXN3OSBI96lAdpNZzV0jAlkSlNzWzh6H9GAa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 31, 130, DateTimeKind.Utc).AddTicks(1263), "$2b$12$oBdzu7ruzaY9sD1KgOSTjez/egbjY7GU0rVD/nVfw3ZwZ9450Q3f." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 27, 185, DateTimeKind.Utc).AddTicks(225), "$2b$12$oZzjVUt/mN7STZouoq34n.oUMlBTdZcmSOrYvoNeq7usud5FsdfV2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 33, 320, DateTimeKind.Utc).AddTicks(2503), "$2b$12$WlBSiObVkRZ/d.ityNDyeeyFyUJ6ffDooXJ9bgzmV36BRiPuM0CHO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "617cb820-a96f-5ce4-513e-f9de2ec06556",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 56, 168, DateTimeKind.Utc).AddTicks(5275), "$2b$12$pzYjWRSky/5INn0HQg9dfe3JRQVFpwc0q8CrDWPqMQPuF9D3VA/5e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "62f48843-9c38-a162-72b9-af6d09b80de3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 11, 673, DateTimeKind.Utc).AddTicks(1136), "$2b$12$cZng2TT0NSXxdFqpec32MOi/OF2PqKc7i.zK23alzP78mPhNE6hcm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 28, 935, DateTimeKind.Utc).AddTicks(5481), "$2b$12$5ObFH7UlYhL5jizWsQcGmudsni3rYDMoF9xyMSt2kDVdxDZz4wxmu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "65aa7c04-2529-20cc-46f7-47c22df3e1d0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 13, 885, DateTimeKind.Utc).AddTicks(6878), "$2b$12$n5k4At6AL0tZBzwT/D1DHOJiuprm5nxFy9C36eO5.SYNuRHRMyWxi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "68fbd87f-0c94-976f-40de-323667ff06bf",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 0, 244, DateTimeKind.Utc).AddTicks(9417), "$2b$12$DbzgmnyyHqx87vN07Xb7But/p6/5nWtRJydtKwvWd4ncETacsDdaG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 40, 769, DateTimeKind.Utc).AddTicks(2492), "$2b$12$y7QBK9Xjp3duFXCUV0ns8es6OFwBJqc5X0aOvbbdSmYsOECqLloo6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 47, 411, DateTimeKind.Utc).AddTicks(9605), "$2b$12$aR732rRpj8C2QzS9IOjhL.fPJqc2bd9Ps/dyhZR3wnnWRIuGJ5noq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6dcd090f-508b-7888-b458-17aeea49123a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 15, 648, DateTimeKind.Utc).AddTicks(6318), "$2b$12$704yPOx5IRI18L.IKxNiLuq9TIXJ.sJsejz4Ln7H6m4QGJqy7z/Ei" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6e5a0735-7928-5aca-b192-5e455fca402a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 4, 225, DateTimeKind.Utc).AddTicks(9390), "$2b$12$DVL0DfyP.xIuqkg.k56KoeJms/atZQTJt2KN6s62Io.ablDEJLVqO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 53, 132, DateTimeKind.Utc).AddTicks(1989), "$2b$12$YUKgBEUJ6Qn4oHTQagCJ6eAs7Fy3jclvKFkLOa8/wLlA3QBIaiAvm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 50, 59, DateTimeKind.Utc).AddTicks(4383), "$2b$12$HkfI8LmlkEtEYqonffcj1O8DmWuO2te5gj/Hm3bcs9UY6ZHdsIWXa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 33, 755, DateTimeKind.Utc).AddTicks(6925), "$2b$12$5VYrHR/P5a6cu7l22dZt6uU4pD3lPxl1uykhMuU3a5oJvorCgnXBO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7f2e2223-eda8-2785-2b9f-2f6cbfecc012",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 35, 945, DateTimeKind.Utc).AddTicks(5468), "$2b$12$SjKQlJ.EkhmDkhvtsxhr/epK0V9q7K..QB2CBaymTK7dyMgQ26SgC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8112e653-13fd-c47d-0fc5-7b36eda72bf0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 1, 576, DateTimeKind.Utc).AddTicks(541), "$2b$12$eeD1dJ00idIjSRWmJCghk.KmUDsphHsnis/M4loJxFYxLfANoHY0a" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8976fc22-4f3c-f5a6-a6d7-81058525ac85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 16, 981, DateTimeKind.Utc).AddTicks(2143), "$2b$12$5Alg2qOd/DvfxLggiq5fh.7Je9emjr85WWAYfECwZdnXaLjybVZP." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8b8636d1-c1b0-1104-ebb5-a8e7e20d35ae",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 10, 791, DateTimeKind.Utc).AddTicks(6913), "$2b$12$j43Aby2fEPG9sIgte.As4urAPYmKGy7gVvZFr1ybfZEk.T/ol2Wa." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 59, 318, DateTimeKind.Utc).AddTicks(7097), "$2b$12$78A3tnkHDCRbM1eoRrm1Ee7VCIwmoFWxGJON26R8W5bTRGEzZUZ42" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c62f6c8-d791-e825-bdef-5c14bf5ce951",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 35, 79, DateTimeKind.Utc).AddTicks(1516), "$2b$12$6xwbp5WqrC/5AutA.9mK5.elJNMDy0gynk2SFIKwPkQKmBg.9fK4G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 48, 739, DateTimeKind.Utc).AddTicks(8266), "$2b$12$Uv9DFax3ZdPs72LXZwP1Lur7F4PmAygi7ynbvCP1pnlVCRFFNJYdC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 43, 869, DateTimeKind.Utc).AddTicks(5952), "$2b$12$hM2hELgAEY9.g.wW19EuTetx82gQDW.WwGchaKD0A2Sdaga4pin6." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e1a2182-9af2-5229-2104-66051e4b6220",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 36, 386, DateTimeKind.Utc).AddTicks(2676), "$2b$12$EwVaxX0X8uY9vLI/iV35FehPUE5WDWV0Drb7Dahii1kFmBJGfJjY6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e85356b-dff7-0fe0-9e0a-ac24101ff81c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 54, 423, DateTimeKind.Utc).AddTicks(8682), "$2b$12$349CGNcsmuR2dMFLpgqvTeW.3TDilCDIGm23NGn2lLFdoHdNnRdHe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8ee02cf3-bf69-3090-c8a3-acd718cd445f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 52, 692, DateTimeKind.Utc).AddTicks(3918), "$2b$12$XKIJMwBT/OgKAlXnmgKYhe4tleryjv1mgdKifOg2zI8IDL2DxyEMK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "91f97c43-df32-927a-bb77-3f050c28c5d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 54, 856, DateTimeKind.Utc).AddTicks(3659), "$2b$12$NlRHUYrb92ZmznJ2dt7oN.du/FRd9mPeTcNgU0KiAltyrbAGEPAHq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "953715b4-1d71-3023-7048-42579385f359",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 6, 827, DateTimeKind.Utc).AddTicks(9144), "$2b$12$Di3NJBKgjfcVUg8c6x6B9uC9MzIuepJU3wmgOsoLYkOsev5/NqELO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "954d4710-fb9b-9bc8-33d6-1a00378fef99",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 3, 345, DateTimeKind.Utc).AddTicks(8157), "$2b$12$iCm2G8sgbZDjMfC9nQlpz.nvjmCaQk.qf1gpPiOuIxQyOLlzSSNru" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "95755e71-293b-5fbe-2e06-ff9c6d90e96f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 57, 939, DateTimeKind.Utc).AddTicks(2730), "$2b$12$qGf7OCKYEBZNr3kGab2T7OrFI4NYkRtA1aOZ4fYV8erAOXEzJB5KS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "96cb69c8-c721-11de-8075-582c3bb936c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 2, 17, DateTimeKind.Utc).AddTicks(5510), "$2b$12$wiCj557Hd0niow0FDNKMMOiJ4RFNkcEwdG3YLvZ/QLmcl8oj8g4li" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 44, 759, DateTimeKind.Utc).AddTicks(5836), "$2b$12$CGbE8JXU2Vg075rQCd0iqufIwPI3QH3W12P9L5UdN.9rC8QQV.csS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9ade6863-7e26-4864-6736-dc579f1c7a31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 36, 824, DateTimeKind.Utc).AddTicks(4783), "$2b$12$r6O.5PK1VZMCQ7QEVxyt7OVuPd.SRAF38a/v5EuYAHx2iRzz9kj/m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9dd3d6be-aadd-a804-775f-b0817d3508fc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 9, 24, DateTimeKind.Utc).AddTicks(5872), "$2b$12$5cDH.9qCSaAipIW2AvDdJeVjdPJaTgCuWmLuDrkEJGwhUFlmZgW5e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 44, 309, DateTimeKind.Utc).AddTicks(3493), "$2b$12$orRTE5TS2czI.czxlf27.uXACkEWd.JsnAZr3QvIJDBkvqeen.BV6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 42, 534, DateTimeKind.Utc).AddTicks(4844), "$2b$12$g7GJ/g.gWZ0gABdlqTM4fOLPnROZIrFgu8pKBLwgkC3KkZQTbSdcy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f3e92f6-ee55-979e-23b7-f713245738cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 8, 578, DateTimeKind.Utc).AddTicks(8621), "$2b$12$Y.BlXwPvlO1t8ZOZMo2XmeQepkisiz7QmGxDHLMNb331ropnEc8qq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 47, 853, DateTimeKind.Utc).AddTicks(7318), "$2b$12$bvjGhQvE3xYmVPDfoY1fNewj4TUKjjgeqtRMXLjOjOtDFctrZ3lPa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 58, 379, DateTimeKind.Utc).AddTicks(2038), "$2b$12$ZvabLCnuIpKr2ZkFZSRNLecaRx2ILHT1jWODmZjib7zUX4YYEmsNy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 42, 984, DateTimeKind.Utc).AddTicks(8062), "$2b$12$ghuGQSI2pZ4f3ZZH.lWY8.qTrmAJkl.Qpc/upAYIOAdpG/1mEe5WK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 46, 74, DateTimeKind.Utc).AddTicks(1778), "$2b$12$8cwr6ywYENy0ZeVEiY4QSeMCjf5Qi02DbBWV9sBDmaHRHd7LPtf4e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a70a25e3-1d3d-3e25-2f6d-c728283dce2c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 13, 447, DateTimeKind.Utc).AddTicks(7103), "$2b$12$nxSxuoVWOcVt7f4MqnUiquFzmpoM9CdvzDjxAKBUMvts1cII46RP." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a81af79f-d5c1-b515-0d1e-fe2dbabc780d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 9, 464, DateTimeKind.Utc).AddTicks(9435), "$2b$12$PFV3ZDt.AKzRZFvSTcqmaucj25R3hDhJDbbyiIbyyX8A6EkZv8jQu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a894def6-b00b-6103-0ac7-92aa2bf2a079",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 7, 263, DateTimeKind.Utc).AddTicks(2422), "$2b$12$Rjyuwh8ZnvCEYkIvliiFbON2AUPvIEhygDky3LAUC8H266aUm4sUi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ada69e11-1e1e-3387-80da-a6afa8505ba2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 5, 524, DateTimeKind.Utc).AddTicks(2490), "$2b$12$4henAt5TPtMCMpiJEN566eTnU8bKxWZz4E/lfcEcbMxtv/FuNAEHS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "aeba3eba-9c59-d115-5781-476232f36f4c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 58, 862, DateTimeKind.Utc).AddTicks(5170), "$2b$12$C1PHRzhX47jWhAYbgqvO..ftzh7DbD5vPn0PQoHTUuyFI2B3mo92." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "af142cbb-a95e-ab3e-f00a-a39f87004ec3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 51, 366, DateTimeKind.Utc).AddTicks(8379), "$2b$12$NQzlE.I4s6H0AXE6ihTsGubB5/8VyNTDQ3QVDlgh1zz9/a0LMFcu2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "afa4fe08-4af6-cc2b-778f-115de345ebba",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 14, 322, DateTimeKind.Utc).AddTicks(4486), "$2b$12$pD0TiqlzsCb16w9JMxYulOORRQMuWMjelgttXDbjAgcc4wd1P4d0." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 48, 297, DateTimeKind.Utc).AddTicks(9017), "$2b$12$mb2EcvjzC4OJBqqrbyRH7umneOJmN0hB5r1Nly/fsEFD07kVD0w1i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 40, 333, DateTimeKind.Utc).AddTicks(1968), "$2b$12$gTjcK/ZihMvSHhCtAGxjp.YS9fzkWO6g9Vl2cAB9qpR7JZgVVCpa." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 24, 999, DateTimeKind.Utc).AddTicks(5844), "$2b$12$wkFZ7yX2qhzU54YtgiNWLusVgmJmVjDkhZNm2oK49gdRpceFV27be" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 37, 260, DateTimeKind.Utc).AddTicks(5950), "$2b$12$MHMeZBJBmI2xtghAK2jsb.F3722hJMMxD9PQ3Lv8T4L4vmgu1mUs2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 1, 128, DateTimeKind.Utc).AddTicks(5896), "$2b$12$M0ekbq6WBxgxuHNR4GAmW.Aa6wjP4ADkY9L8kbLmTsNUYNCdcOYxm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 29, 810, DateTimeKind.Utc).AddTicks(9400), "$2b$12$QxJfCcDl0UmvpRoOF5hQsudvp5QKvO7a36SM3fnIHfHxUHIR8Tl.G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 39, 889, DateTimeKind.Utc).AddTicks(7205), "$2b$12$m7HkPwJbWvl6y3s5FiYs0e3L39o.TInya3XBnjOVLhEhjaMLy/KSW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 55, 726, DateTimeKind.Utc).AddTicks(2393), "$2b$12$yupi9xhrhJAUC0ev2VA2y.0QIMJKRwjnTJg9Clp4CtR.EugantOWi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c2dd0d11-f58f-2546-c1ca-10b453a7bc96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 2, 453, DateTimeKind.Utc).AddTicks(7566), "$2b$12$tr1VJ2d2FcEVPGwcuA3IH.4qX8Hfxvg2kj8s89zL7KSZR/iwrekVG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c668490c-dda2-f1b1-d170-72005fc34624",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 57, 498, DateTimeKind.Utc).AddTicks(9545), "$2b$12$XGuw.as4.ZeQrcRxAyWlueadASswsfoOhK2UqjrEskOKdSX0xOE22" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 38, 576, DateTimeKind.Utc).AddTicks(5962), "$2b$12$KRJZOB3mJbqA/2STFuttouI5uMIdzXlUgsnHS3BsNS9yRvjKSwnca" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c8936e2c-61ab-766a-1161-ed4577bda964",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 0, 684, DateTimeKind.Utc).AddTicks(4243), "$2b$12$Hcl8ShlmiJOzpOuethZBReVpqWpmw3hK6ziuIoCYVzvq5Id3wYgzO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 49, 624, DateTimeKind.Utc).AddTicks(7465), "$2b$12$ptab91JzAyQH2W8FW00wrujMSKnNagcI/xS4DPabhIHGxcIhzAxMa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ccd1db56-b977-3035-ca07-0d16377dbbe1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 53, 560, DateTimeKind.Utc).AddTicks(7947), "$2b$12$2SOWioaIeKsJOjb/iGuY1.c0NMpYkU0BQV7F9bGvXMcLpaMzs67q." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d3f7232a-7eb6-649e-c1fc-ad010f705d7a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 34, 199, DateTimeKind.Utc).AddTicks(6174), "$2b$12$zCFYA3pSukztIhhcFGz7TOqSyKiFhQ0D1Kry50feUR1DtmYXeXveq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 30, 692, DateTimeKind.Utc).AddTicks(1781), "$2b$12$0asG15jcfY2sOpJA4dlkbeZdL0/DpIpwdUhr9lEA3bss00Hyszh.G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 28, 498, DateTimeKind.Utc).AddTicks(8176), "$2b$12$mUlwg9aqfblBjsif8g7UF.fOBjzf6Vcp.Jk4O3KzoVNYCi83O9pnu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8924a08-9bc1-e88e-8396-1a1e86e2276b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 51, 800, DateTimeKind.Utc).AddTicks(5908), "$2b$12$SPezey.UJV.duINkZ6cZWeAkHassPFq01xXRQSbD9QiccFmaoijRO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 41, 643, DateTimeKind.Utc).AddTicks(8034), "$2b$12$0ovjT2DoFOp06atWwkFyfuhWUTtWm30CFJjF5x/QDmJi53GHbF972" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 25, 433, DateTimeKind.Utc).AddTicks(2833), "$2b$12$diBP5zAsRSgzFSCU58n6juYN4/h.0Iz19hyswvQVhLFksrV9ks.dG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 43, 429, DateTimeKind.Utc).AddTicks(6563), "$2b$12$PNyCpTHB14MiPxREz1/EmOG993Eex0Gl8OAztPyGP.nCmX/oYIRdG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd288475-9710-eabb-7cca-449e335c3070",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 4, 658, DateTimeKind.Utc).AddTicks(2350), "$2b$12$24k9s5GfGtWf61SJuK/x5OYGoWGZfBCp4CBdaPc6YSfY.kkf0b0/m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 31, 569, DateTimeKind.Utc).AddTicks(1629), "$2b$12$dRKNFwH9WwsV3sQORBK7zu9BlOlLLGzF6HwwcHwhp8aZ9ReYOyCWC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 46, 520, DateTimeKind.Utc).AddTicks(5909), "$2b$12$LKjSDsP2tXDxvZUmWlKX9.6PzqMvACL84PWjrUtThy02eaJHasRe." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 46, 964, DateTimeKind.Utc).AddTicks(4777), "$2b$12$jeQOO8no.PbMsOAJgk6zw.M2EcK/CV3lnzu13zXjYLmqt9Q9ijisC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e48c4173-bb79-99df-4cdb-550c4acb9bfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 14, 773, DateTimeKind.Utc).AddTicks(3280), "$2b$12$ypoxWcepcPgZJdZhOQgdju7.xBhvTSdS.NY2N.HPoaU.jp3.XS/5W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 45, 197, DateTimeKind.Utc).AddTicks(5021), "$2b$12$7lLqqZKtlzTDMZuPqNll5ecXQ6TvEOV/ou2pnRC8wHHMExGE.4GLy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 42, 79, DateTimeKind.Utc).AddTicks(9464), "$2b$12$rhK0lALCiho1ABSfFX2ZBuYeVXpMImc9BGQbM.ihQEbu2D5DBLCeC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ecd9a403-0fa0-120e-0580-76ac458c1397",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 7, 706, DateTimeKind.Utc).AddTicks(8165), "$2b$12$frD7rkNvhk4fRFVOS/zc.uNJxQP1IKq5xXYuN4dEW4aefDFAbEl6i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 38, 135, DateTimeKind.Utc).AddTicks(7293), "$2b$12$8sbm07s0YOI7Ri7/m/0Y4.ljZ1seAnNIw5crRdz//nBuyCJpc8c.q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f0af01b8-a5e4-18f8-889c-4863d1166ca9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 12, 562, DateTimeKind.Utc).AddTicks(3967), "$2b$12$fgqkiewkZXn61Cy3DlXhyews0ynPXlwMA.8Ry5IohyFxCfkkldyXu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f828e1ce-18e1-0c76-9535-92a277f7875a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 37, 5, 958, DateTimeKind.Utc).AddTicks(699), "$2b$12$GGRq3RTjysHziTT.0xFwZ.c2B1t15WdMhDosZNoYJBRRfxkHS5OWa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 32, 884, DateTimeKind.Utc).AddTicks(4518), "$2b$12$vHeMP05X4u0kVf1yg.KO8.Wg83NMgEkP2JmIbO98UHm.NRA9KE6ui" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 32, 449, DateTimeKind.Utc).AddTicks(1027), "$2b$12$QAOlBEidvNAGXOPF955FP.xLe6BDqnrLpGNlP0LK4nnXCDhV8M3Ay" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 37, 697, DateTimeKind.Utc).AddTicks(1856), "$2b$12$x/gl8FXJR7C0k.TRzhJ8su8gU60BN10VHuFG.C3kXBKefgLPTKqDC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 11, 36, 27, 617, DateTimeKind.Utc).AddTicks(7306), "$2b$12$eZ/ZvXfX2nmiv21dGEC4jOvjczxdzlIx6SSgf4.7WrPK2bjnbgoeS" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "81b21082-3ff6-6699-2b66-67d6f6ead3e7");

            migrationBuilder.DeleteData(
                table: "SessionRoomChange",
                keyColumn: "session_room_change_id",
                keyValue: "863cdc3c-e440-3359-c69c-777871286814");

            migrationBuilder.DeleteData(
                table: "SessionRoomChange",
                keyColumn: "session_room_change_id",
                keyValue: "e2f35a55-7db2-4df9-3bbc-17e566a55b03");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "011f7dd9-fd3a-3d41-6190-1f4489c299e9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 32, 371, DateTimeKind.Utc).AddTicks(2153), "$2b$12$tHFuXtAuMQRRnyUyrNzdEO/bjG.Gf6505fTkUYmOjPS1fTCOIF.Mm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "015a9397-c5c4-4b03-eb4f-86048ec621f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 1, 132, DateTimeKind.Utc).AddTicks(4144), "$2b$12$zArumnURxoUfKReYO1Wt2.oRFpgKkWkU0vAvMnx9rZjVQ8a26bisC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "03428ee8-3d9a-de72-c98b-dbc65724b005",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 21, 111, DateTimeKind.Utc).AddTicks(9848), "$2b$12$NSwMNzuxP4S.85aX7HMKPOIiV/Mlo5f9TZMFlF76FzxIYR70J7cU2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 59, 129, DateTimeKind.Utc).AddTicks(1721), "$2b$12$t.fHOzW.LBOMphfZ7gBqI.wTRgk83c1iBJpuNB6FOJeiHOf1wSePu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 6, 522, DateTimeKind.Utc).AddTicks(7839), "$2b$12$r0eP9rX3k5dQ8iN0tqbO4.f6DJy2NI7Aj7JiCk7eVzPY7rS0hkjh2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0a3f73e7-67a8-750c-576a-49c22125bac7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 33, 827, DateTimeKind.Utc).AddTicks(5738), "$2b$12$zImfYeYocLYh2A71hOY1/e8TKqJ4YxN2cPtsmjARmTiMFH9YY5bhW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 53, 981, DateTimeKind.Utc).AddTicks(6612), "$2b$12$C/YBtns8p7Z.bRJZmCtomejKwMG6ERBwkzoY.23mFSeshXVnk9xKy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b48ba68-2d76-43aa-8392-7b40b1aa1e19",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 30, 273, DateTimeKind.Utc).AddTicks(1837), "$2b$12$UFlGeCNNAKj1MIm9iBPC3u/YBbu1keRDKEe.OufwZKTgouMplf/JO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 10, 95, DateTimeKind.Utc).AddTicks(7267), "$2b$12$qSFNeIoQSgJl1GeoyXW23.CCEuFLqrSF3rQC7Q/Y11lptohabMUlW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "129452cc-6c9b-3726-5c96-54b67ac3b884",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 34, 953, DateTimeKind.Utc).AddTicks(4190), "$2b$12$K4h0Ye7n4imkMyGwSQQIfu3UJrn0pNTzCFQHhQ.oc5Vjn8FKcG3B6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 13, 634, DateTimeKind.Utc).AddTicks(481), "$2b$12$5ywYYzz5hx301kBce/qgs.2OPQsBXjsgsXWTG2c2HcWKvuwdsU.oC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 55, 717, DateTimeKind.Utc).AddTicks(6795), "$2b$12$Cf28JkQH0C9IyYqyAQapFeCtUs8YOidtdzlnkVcb5vQCqcSSV0Jyy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 18, 735, DateTimeKind.Utc).AddTicks(5492), "$2b$12$DxLsh.0qGZNog6IGVAChBen0um/6YeVr6s7TOh69OTsZRSDo7N3vC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 5, 53, DateTimeKind.Utc).AddTicks(8914), "$2b$12$Lizqax5nR3Z81L74RzYOx.ORXcAjNAh1vtpccdiNfuDODtRahWo5G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "18241d26-a012-b189-957c-b5573ecb15d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 23, 658, DateTimeKind.Utc).AddTicks(7713), "$2b$12$8zESNOHLinG0ZbhqDhB2x.YhM/x2hmpryq3iljlYI/Nc/0aZ3Cfu." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 57, 10, DateTimeKind.Utc).AddTicks(6461), "$2b$12$Bdi.5C/IqFR50cGAJ2hc9O3CGoMmIXE5mPSJ4hvBxka.2UxB1wLCm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 57, 881, DateTimeKind.Utc).AddTicks(753), "$2b$12$dc9k1ixfxBDydzSkxMiyyu1Dycc3Y9wH2R0vUFcZg0t7amevflc/K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "288bdacf-8acb-a8d1-59f9-94f0cccb2086",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 28, 148, DateTimeKind.Utc).AddTicks(4922), "$2b$12$ZbPwdmKIlYsaOhvyygyQr.KCTcmFaDiM68HB6624ZjK.wpayXz9la" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "296e74bd-c209-7f7c-d030-28e85a1aad75",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 1, 720, DateTimeKind.Utc).AddTicks(668), "$2b$12$/m7Koxkc9Uv6x9VK9YnO6uF8eU3iv8furRH1MPwxz7BDocGZ05s3C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2b5c3a92-dc35-b1bd-16c3-b0f8a21f29f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 25, 346, DateTimeKind.Utc).AddTicks(5911), "$2b$12$FW2xJNKE3rtGxddLpBkUkur7bZLwAE7wTxlRkW/UZzCJpSF4OxEAm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2fa22e35-4eb2-7351-ee0e-a523ac305c44",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 30, 846, DateTimeKind.Utc).AddTicks(6160), "$2b$12$7nz/ioxFU/ybmAr.F24Dw.dN4dHE5UcoffSghb.RtCo202PVVW8S." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 12, 765, DateTimeKind.Utc).AddTicks(9985), "$2b$12$DirMw.Bw9t8GOVi8ohyG..rmd7UyqoiU1fnP6TKgdzdl4PaT9Wugu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "373399d1-2bd2-aee5-629b-43f96da8f03e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 34, 517, DateTimeKind.Utc).AddTicks(5558), "$2b$12$Zhjxn0nievmNFOltlpkPjOPg3tD3WbzpFtctrLc4/Lnpu4jCi3CWu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3769412b-799f-6b72-f74f-9b9b735058c2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 26, 471, DateTimeKind.Utc).AddTicks(6050), "$2b$12$dPHG426PxU6scrycjH.AjOq08ktROe5f/CEFPkYFxFQOeUsb4otBy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3830d83f-4097-76e0-a9e0-b90ef45d1c79",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 24, 388, DateTimeKind.Utc).AddTicks(6536), "$2b$12$6nVfswt5dACCmqeTfIdRduc4usLijurxoGrqcIuFhrvEg4N1jGqi2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 52, 765, DateTimeKind.Utc).AddTicks(6213), "$2b$12$d.FraV6LmhvpFkEHCr.XPeDMAt.aQ2RsxOnv3686H2NtCnSFJ6g5q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 4, 724, DateTimeKind.Utc).AddTicks(7099), "$2b$12$R145vinLrs3uu4K9.XpPoOnXHA9DxWyKBHz7axXkJWuCZYNsUA7re" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 54, 569, DateTimeKind.Utc).AddTicks(5404), "$2b$12$LM1EFULEHayh8jx9Qfe6feeHQAueomDL6a3aqGkbsdCKXjNslWIhS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "476292a1-d3ae-cacd-a58c-2d14790da8eb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 31, 581, DateTimeKind.Utc).AddTicks(4145), "$2b$12$7H9/FhqmQWXaSLHwFfRWhObV19IES9tFwAn18.5IiSgiWpd2pjVji" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 54, 275, DateTimeKind.Utc).AddTicks(4312), "$2b$12$zq.Tlw.0qvs4U.eQIZ42r.sohfl6CpIq/ldaTGwAp7FKIANISvR3e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4d41b3e5-536d-0aa0-a3e3-024218ac6267",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 17, 762, DateTimeKind.Utc).AddTicks(1029), "$2b$12$TIxoECGBORseZQrbcVKXguuSpn51q/qpi8yq722UXV2V4z886oJkO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "51432fb0-cda4-87aa-a2d2-e36c25823a2b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 19, 23, DateTimeKind.Utc).AddTicks(7323), "$2b$12$eE1zApbgAR1MElZYnBazI.FkDuUx.0Ygko1aHWUE16EsTFLREO/za" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "52fb0554-7e57-01bb-5949-987520c91eb5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 16, 649, DateTimeKind.Utc).AddTicks(7804), "$2b$12$qfZ7QYECGBUU1C.JKT2gL.ArEJU48ESpZFYxSlffXGmjyCPjYIIva" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "539ead07-d571-367b-79f7-68b21513886b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 29, 892, DateTimeKind.Utc).AddTicks(1568), "$2b$12$Xv6sHP0cIWdYcQgcOoMaGePJ8x0/w337f13x33PBmp3RJ9a1vI10y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "557dd714-15d7-6df3-3ed1-22a2eec63c59",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 15, 206, DateTimeKind.Utc).AddTicks(2303), "$2b$12$v9wvPwl63q8yd4gst6sHIuLuQdsXqCtCLQQvjsAavDh/tmyV/Xhci" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "57f13355-ddb7-5d3c-b09a-ff2c56e22753",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 13, 923, DateTimeKind.Utc).AddTicks(7706), "$2b$12$n/NSd1btJewKFUC8kZ8PwOthd/JDtdmKSO5a5ozYz.STPBS9Rv1A." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 58, 476, DateTimeKind.Utc).AddTicks(9882), "$2b$12$sIVpHGQpbO2X/Y9h4V5BEORcuM32HsNSJhrJWi8xnh8PxbmdyHhMO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 54, 863, DateTimeKind.Utc).AddTicks(781), "$2b$12$p1XIFyS4DqhcVKLzERcLPOWcWb9BcVTPnmbBcDiBIFdfxhQgeljQq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 0, 267, DateTimeKind.Utc).AddTicks(9195), "$2b$12$FsKp.wqw46Y/AeXozbzOWOsTo7cXLUeY2sEADWroGgo5fgsqtJL8K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "617cb820-a96f-5ce4-513e-f9de2ec06556",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 18, 446, DateTimeKind.Utc).AddTicks(4207), "$2b$12$63h9dbc2I1xD9FvNS/GE0uEnaTBJ1wPaF0B4FQSY1IfkwTjKSNWe6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "62f48843-9c38-a162-72b9-af6d09b80de3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 31, 144, DateTimeKind.Utc).AddTicks(6525), "$2b$12$iY9QNK4TQAxKm6Egtq2EXOonalI6Q1HP4wSqDKEfSkU8SBPdSMnoq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 56, 578, DateTimeKind.Utc).AddTicks(3526), "$2b$12$sPuw.6vile.trYj9StleK.HqjsIxNmCAO/14sz24HanPIJs0zPTAm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "65aa7c04-2529-20cc-46f7-47c22df3e1d0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 32, 962, DateTimeKind.Utc).AddTicks(3965), "$2b$12$d0Potie/p6p0ew/BS1r.2OhDi5QYnIPN8RlpUvuStvI7rk1Om21Oe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "68fbd87f-0c94-976f-40de-323667ff06bf",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 21, 547, DateTimeKind.Utc).AddTicks(4091), "$2b$12$RzZFpHR1jYWiKXi0cAzFO..o9sFpEeK/upfdBksSdiJ8AlXdXkFv." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 6, 232, DateTimeKind.Utc).AddTicks(9632), "$2b$12$ayulH2f3QeSDZhNxT0u6ZOT3obqzPfrT5BwZG.tz6Gz7CxsmUos4W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 11, 395, DateTimeKind.Utc).AddTicks(2255), "$2b$12$XQz8L8IMbt1pAA6MdmW1vuzhXPsuQE9GMY/gQQNA/R3JJ0NFNuPnW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6dcd090f-508b-7888-b458-17aeea49123a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 34, 115, DateTimeKind.Utc).AddTicks(7117), "$2b$12$jZKDgQrP8nH3FbKxw.pQGOJdUnX9XO3RgEZXv.BPkU99B1NW7AJQG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6e5a0735-7928-5aca-b192-5e455fca402a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 24, 684, DateTimeKind.Utc).AddTicks(5629), "$2b$12$eaYm62lXA42bCzoiqhWnDOAGxk91s3oqlZWdIqomHWqRarsu2tCSi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 16, 71, DateTimeKind.Utc).AddTicks(7046), "$2b$12$lB6IeBS5NMp/d2wHN.3dw.EVM08Fhd.zVuwh1rxVGo8YEkqInjROK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 13, 342, DateTimeKind.Utc).AddTicks(6275), "$2b$12$klISlvDcdHuWjdgHmAIhOeg3YgeOklp7GNdeMnx.MnosYJvcNttOG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 0, 553, DateTimeKind.Utc).AddTicks(4787), "$2b$12$2o1QBWOTjoMZXDg43CD3QOFBBd6hi8wBdSwVOTvqommBsPqJp5zWi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7f2e2223-eda8-2785-2b9f-2f6cbfecc012",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 2, 54, DateTimeKind.Utc).AddTicks(7488), "$2b$12$n1ma5tGLu73rRb5IARLfd.gBEcUS0PUDc2p8MOGug/UZx4.asdn8m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8112e653-13fd-c47d-0fc5-7b36eda72bf0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 22, 604, DateTimeKind.Utc).AddTicks(9317), "$2b$12$qkA/C2p8.AEAtiikHSPJeupBc.iK0X38cPYKfjmEupm.fXwyJ9FVW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8976fc22-4f3c-f5a6-a6d7-81058525ac85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 35, 399, DateTimeKind.Utc).AddTicks(482), "$2b$12$5gv5dB03CrdEld6YqWIBzOMKkD0WLMlAQHPhr4Ire3mpbpo/JV0oe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8b8636d1-c1b0-1104-ebb5-a8e7e20d35ae",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 30, 560, DateTimeKind.Utc).AddTicks(7187), "$2b$12$zuVyrHRQ/wKNPYuAPkCGRO3TfieciDmX..3WDZHVzbiKRUE3nesru" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 20, 677, DateTimeKind.Utc).AddTicks(4408), "$2b$12$6OcxZDoATs9KkvEMLLVyWuUh0YEtm3c16cxGSL1ETrBbhKnxq7Z9y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c62f6c8-d791-e825-bdef-5c14bf5ce951",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 1, 426, DateTimeKind.Utc).AddTicks(6522), "$2b$12$e/BPYj4v0KBczLNnWmhpyOdk4wxgw/0RJ2UzvGHLHdtDDeOSdiPcG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 12, 472, DateTimeKind.Utc).AddTicks(6742), "$2b$12$6bbAZ1DAjctv0ZhLgjYtXuk8QcmV/q3s7xu3ABsWNRjpj5CLiENPu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 8, 402, DateTimeKind.Utc).AddTicks(3103), "$2b$12$XDoKOMkyTR240KrKytOF1edtAjRb0lu7AayIdLNGcsfEHFEChgIqm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e1a2182-9af2-5229-2104-66051e4b6220",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 2, 494, DateTimeKind.Utc).AddTicks(8607), "$2b$12$fXXAb.v8BZmZ5WMuY81aOu1FE9/MDct9afGHmp8Wke//oqmD5hhIi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e85356b-dff7-0fe0-9e0a-ac24101ff81c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 16, 936, DateTimeKind.Utc).AddTicks(7685), "$2b$12$hVCZefpoYw/7PM7Z0holNeRa7L2lXndwgmuu.rciLNLAO8dPez8PK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8ee02cf3-bf69-3090-c8a3-acd718cd445f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 15, 644, DateTimeKind.Utc).AddTicks(7673), "$2b$12$.y7sB7UeTukqDG.MJxY31uteJ0.BLApbjF6DAOnwFJo7Y4PIRUR9C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "91f97c43-df32-927a-bb77-3f050c28c5d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 17, 324, DateTimeKind.Utc).AddTicks(5640), "$2b$12$mIardiKODlz1oNxJaznsFu/P5F7efG3gXkLgXr0C7HU0eJvW3qGpC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "953715b4-1d71-3023-7048-42579385f359",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 26, 919, DateTimeKind.Utc).AddTicks(1037), "$2b$12$ZUocOGBuFejKBksJ0BDBze2V9Kd34QPlXkEM.q6mLU//3Al.0M6di" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "954d4710-fb9b-9bc8-33d6-1a00378fef99",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 24, 98, DateTimeKind.Utc).AddTicks(1774), "$2b$12$FDhev3/ow1HrTOHJ8uzGpeLSqHk6Gu3zyaMCmMgIWGzVCu5HZE59W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "95755e71-293b-5fbe-2e06-ff9c6d90e96f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 19, 599, DateTimeKind.Utc).AddTicks(5395), "$2b$12$Df0SoISJysyGqCHnZN.bKeR0Oyzuo4dh3.L7zSRfSrozll/cWnnHW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "96cb69c8-c721-11de-8075-582c3bb936c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 22, 891, DateTimeKind.Utc).AddTicks(1052), "$2b$12$TrM4Ls3y/wn8eFEnt.T2JOcNxIn/oH8G20SwoVZQc14X1g1W0bQEO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 9, 270, DateTimeKind.Utc).AddTicks(6971), "$2b$12$s3WX.pQSFOeA7PX8tf7xZ.eYdnYG0V9R9M.bSQXxKLQih.fLVtI.a" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9ade6863-7e26-4864-6736-dc579f1c7a31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 2, 926, DateTimeKind.Utc).AddTicks(9065), "$2b$12$ywDCTCgFpto83eA8zHjPauWhzFYkyZtaCysZKMa0jAzZknWb9TLNi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9dd3d6be-aadd-a804-775f-b0817d3508fc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 29, 25, DateTimeKind.Utc).AddTicks(3656), "$2b$12$arXh7lpjDzzO5.34aSAEDOrL5SflURl6jLz2f9.9OjR4AAIaSXJk2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 8, 836, DateTimeKind.Utc).AddTicks(2011), "$2b$12$BrvUi2LxFWhZC6p3aK0Yne0VzjwGhRqW/dfzGlfgqU3qIGhjOHugm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 7, 387, DateTimeKind.Utc).AddTicks(276), "$2b$12$ZW1hu5d8wICdCwAuip0P/.TbSUlhSkuGnPMfzuPLz7lmg3o4LEYBW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f3e92f6-ee55-979e-23b7-f713245738cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 28, 583, DateTimeKind.Utc).AddTicks(4194), "$2b$12$EBLzKg5D.HGP7ziJIRgPKuYvE6kcndnPtiWwWniHdYeDREZgBC.qu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 11, 829, DateTimeKind.Utc).AddTicks(5508), "$2b$12$LPfBzEwdYYKgKyvr/bPWTOdrKBFppNHHLCfbJN38USzefUD/c5NXC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 19, 888, DateTimeKind.Utc).AddTicks(9020), "$2b$12$k3g.kVGXAYQeAqmLqlU14.py/.uH7zrg5XDYIF6U1o0FYtoKDW0ae" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 7, 676, DateTimeKind.Utc).AddTicks(2937), "$2b$12$0k..m5GigqBYHsrXPGIdieCtQXbbfkTyYxmpLwwzjARPJhKLnnwJG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 10, 384, DateTimeKind.Utc).AddTicks(8230), "$2b$12$y27UYZlfedZMs0HEnrys7uCDvomu4G4nQN6tUDN62D.sskFCY5qbS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a70a25e3-1d3d-3e25-2f6d-c728283dce2c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 32, 663, DateTimeKind.Utc).AddTicks(6168), "$2b$12$mCxk//HAhZ9XCJZ1wO.YI.AJPi3a9E4azH.GnX0dya/dsIq/eupb6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a81af79f-d5c1-b515-0d1e-fe2dbabc780d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 29, 459, DateTimeKind.Utc).AddTicks(6949), "$2b$12$xas.gultRGS1VUqmwEyIouudfszIEG9uEE0B6wATKC/CWaVYgN4z2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a894def6-b00b-6103-0ac7-92aa2bf2a079",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 27, 267, DateTimeKind.Utc).AddTicks(5101), "$2b$12$XeN6DrcCJ.RiSplXSWTkUOjU50p5gWeBXjsjxdaaQF4F6/Qh1IdSy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ada69e11-1e1e-3387-80da-a6afa8505ba2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 25, 781, DateTimeKind.Utc).AddTicks(1444), "$2b$12$CH9l0hjaRQa9YqXnPMoSb.nKUKt3w5KLADfzsCdYvprqYJKbuzMWK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "aeba3eba-9c59-d115-5781-476232f36f4c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 20, 235, DateTimeKind.Utc).AddTicks(6311), "$2b$12$130ihZ36aYQU6U1L1PiVU.hs1zSycmDzpf46ja9.uhzlOQGIn917a" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "af142cbb-a95e-ab3e-f00a-a39f87004ec3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 14, 326, DateTimeKind.Utc).AddTicks(639), "$2b$12$9KXXnoEEBKNoSJjms6dXOewBE.4iENoRZGcJOVMlQK3J8IXVrsUZW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "afa4fe08-4af6-cc2b-778f-115de345ebba",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 33, 250, DateTimeKind.Utc).AddTicks(8207), "$2b$12$RRFb7JP/TOwVJt3jagZlPuzfWG3ZXA43LlVMG0B3baFTCM9Azbxf." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 12, 180, DateTimeKind.Utc).AddTicks(7095), "$2b$12$9LcsFpQ6k02ZZ14o1LwiIe07aoP28FA0zQ9MfR2lY4FiPY2fwvMeq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 5, 926, DateTimeKind.Utc).AddTicks(7668), "$2b$12$Z8RpyOQmd9ZZXHq1T7Yu4uq06iYhzE8WQVjcmaxSLfrEmRp/tfrfe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 53, 142, DateTimeKind.Utc).AddTicks(3220), "$2b$12$kvjTFD3accj9e6DPtWpzCePXXM7h5lO1yOuDNYS/Ty0eq5duXbFK6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 3, 362, DateTimeKind.Utc).AddTicks(9757), "$2b$12$ZgRi6PZMU623eiRZtBOWM.iBOvAo5fMjKU1.7/xcX2l.Fb.c5Ybve" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 22, 309, DateTimeKind.Utc).AddTicks(7121), "$2b$12$tAVrupxHmo8L1X.JaKhIRuD/L1I.ZnWEF5YdLVV6joPnceAqa9IfC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 57, 448, DateTimeKind.Utc).AddTicks(6004), "$2b$12$cq5aXx144zzs9QcRiBrGvutnNlOfb/St6ejoFmP28rzl76Poq8kZO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 5, 486, DateTimeKind.Utc).AddTicks(726), "$2b$12$zX7M4UTahMvHeYyHz5pHg.Zo.MxfkCCYGhUzTOpkgAP9P9qhMdnwm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 18, 150, DateTimeKind.Utc).AddTicks(9131), "$2b$12$GAmovV3xBv.aPVJq1JhS3.7k8pYMLHtt0XSeUj3obTTMVPlk65i9m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c2dd0d11-f58f-2546-c1ca-10b453a7bc96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 23, 225, DateTimeKind.Utc).AddTicks(7722), "$2b$12$SxF.j5R2Dl9SnluIyXZxNu82C144vloolwMDStFJbj1CFtn4jjHum" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c668490c-dda2-f1b1-d170-72005fc34624",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 19, 312, DateTimeKind.Utc).AddTicks(9499), "$2b$12$0CJDZrypBRBJ1pknQvT3luZPTmvhBrKbwO192IV1oI3qObJ417mhK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 4, 435, DateTimeKind.Utc).AddTicks(4742), "$2b$12$ToVfe9U7Brra0QO5o1l/zeqt2YTyOif5WqD0v1KduSV.z/kAdVhEe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c8936e2c-61ab-766a-1161-ed4577bda964",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 21, 981, DateTimeKind.Utc).AddTicks(1740), "$2b$12$jp.zFLpwjlXxRl6wljWH9OqZZNQnLV2iB6HJ5FayRQvJykWD51IIW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 13, 55, DateTimeKind.Utc).AddTicks(3911), "$2b$12$4KTcT5teiU4id2fDl1PfGefUEOJxZQynBfaNjOl0SVPlcurzqYPSq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ccd1db56-b977-3035-ca07-0d16377dbbe1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 16, 361, DateTimeKind.Utc).AddTicks(6749), "$2b$12$yKICvgQyfdcOjN6x9h3gJewfafTKp9JRingR0W1rJNYut4q1ZgxAa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d3f7232a-7eb6-649e-c1fc-ad010f705d7a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 0, 841, DateTimeKind.Utc).AddTicks(409), "$2b$12$uhQ61Ziw/GQM0mgLr4lpkeg2TPTvtcCRgRqsGzNW7DVyziwZL0u5G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 58, 188, DateTimeKind.Utc).AddTicks(1176), "$2b$12$n9lTxYZ7gVTUEODM9tJemeZaaOF.UAGEPeaPGhXHJKSmKaDMJ26YO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 56, 148, DateTimeKind.Utc).AddTicks(9119), "$2b$12$eO3IxHVpBeaCE43iHqOoSefQyfetbNxi9FcWVpe6yucXPXbmPg.Wy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8924a08-9bc1-e88e-8396-1a1e86e2276b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 14, 770, DateTimeKind.Utc).AddTicks(88), "$2b$12$fqgL9YscjbOd09F6L/oWv.GSu0L.5vycitgleB5LapyrLXCtZOaH6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 6, 807, DateTimeKind.Utc).AddTicks(7477), "$2b$12$St4A04HMUPvyjkkiT2KvM.l11Vt0cj7oRJI1BnaqqdJcOiajceZ5O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 53, 579, DateTimeKind.Utc).AddTicks(5962), "$2b$12$3Jw2WrTeBkPriUKepBBUsuPhhtygND.7M1HEwZ9sT3eD5NVdJhx6G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 7, 970, DateTimeKind.Utc).AddTicks(2087), "$2b$12$VnWBfLWSgnhBtmYAsihmOenLnvmigkyIYmTD9vgVF8WuPIe1LGihq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd288475-9710-eabb-7cca-449e335c3070",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 24, 973, DateTimeKind.Utc).AddTicks(9902), "$2b$12$3n7zxFok60PpuRtFnvfSn.AihfeL369BhCKbeLVIMB/Q8Z5zV5G1O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 58, 765, DateTimeKind.Utc).AddTicks(1413), "$2b$12$yE/8hWDfGpZyusPh9979Ru.JzMkKL4s2NleSrc5f0Qd1X0ACrLG5i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 10, 677, DateTimeKind.Utc).AddTicks(27), "$2b$12$KKKVEiKN/wTuONRJbVNK/evEiPZVb9uRZWKTKt6pRbmRIOw/Kt08W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 10, 965, DateTimeKind.Utc).AddTicks(2960), "$2b$12$7WRhKTuuj.3wL8TAvT8mX.ZqYdvfUPgzKLfDLXfyPsDA4awIQro8W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e48c4173-bb79-99df-4cdb-550c4acb9bfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 33, 541, DateTimeKind.Utc).AddTicks(491), "$2b$12$W1BuTwdBsNVtxwG9m1EKC.UaukhXbWlwjh6LzKpUmHfpTmf4lyHei" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 9, 707, DateTimeKind.Utc).AddTicks(9176), "$2b$12$gV2yVtAu4CKj9gYvaMkEs.AvvpZFyKc7RVY/YmMX8Zf37yjtHWV72" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 7, 95, DateTimeKind.Utc).AddTicks(4401), "$2b$12$DlmdHYQS7xyzuiJAZcpZZuO3gFvFxBa1s0PysUdJZ5PM.BnZranqq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ecd9a403-0fa0-120e-0580-76ac458c1397",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 27, 714, DateTimeKind.Utc).AddTicks(8665), "$2b$12$iBNmppcwNCYUZwBKtsWPBeLqMTG81XG/jDRenBuaiNszEIpsyr/T." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 4, 143, DateTimeKind.Utc).AddTicks(7227), "$2b$12$Xmm1CdKALGYoI0SMAVsUrO8.SV5sirP/MkpmbgEkobz8VlL/SmqpC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f0af01b8-a5e4-18f8-889c-4863d1166ca9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 32, 25, DateTimeKind.Utc).AddTicks(2759), "$2b$12$Q/Lwe2Z4DvpY2TGbF8Y/Oue.xDAK8izle5IYE2PFIc.4G3mSqLNsW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f828e1ce-18e1-0c76-9535-92a277f7875a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 26, 182, DateTimeKind.Utc).AddTicks(4203), "$2b$12$VL4oOkmyqDOgUFK/e4aq6eyCF36x40SQBO6XcAZchK0caghO/xjPm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 59, 980, DateTimeKind.Utc).AddTicks(1103), "$2b$12$I8EZRwEGWzc8fMbf/99eye9N9ECM6bEgUoO5wdEWqwTANJPY79M5." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 59, 570, DateTimeKind.Utc).AddTicks(3582), "$2b$12$Z5aK2CAJ25Uf2hBGEr0mxeAUxX9figT7J5WWPau8DhXfJVvZKIUoW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 28, 3, 805, DateTimeKind.Utc).AddTicks(4569), "$2b$12$g7zGjYaoyfRr5SVfVJguXOaV5gS47Ox137gtoHsJ.JLYAcZGIPmay" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 8, 10, 27, 55, 287, DateTimeKind.Utc).AddTicks(9713), "$2b$12$64CH13zrlOyzvz8SrbCm9ORk54074UXR.pOlf5zlCG0vhooekjaKK" });
        }
    }
}
