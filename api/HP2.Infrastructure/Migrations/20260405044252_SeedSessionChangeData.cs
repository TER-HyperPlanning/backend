using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedSessionChangeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ChangeStatus",
                columns: new[] { "change_status_id", "label" },
                values: new object[,]
                {
                    { "6d1cab45-5c87-c373-3fd2-91f518c946bc", "En attente" },
                    { "d16d1a05-a70b-a5f5-6d3a-8013b24626d7", "Refusé" },
                    { "df4c997e-2e20-921e-98e9-906a9ecf8813", "Approuvé" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 46, 803, DateTimeKind.Utc).AddTicks(7761), "$2b$12$mCMGy8ow099LyYV3tk6r6u8JvCOMD0ETodJ.zipuWiZHMc9o5YUBW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 49, 426, DateTimeKind.Utc).AddTicks(4795), "$2b$12$KyXdGJVnp2Ih.iJfu/yfoe.sKjf9ycLAWhWLYOGQvhLD3lTU1/ZVO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 52, 286, DateTimeKind.Utc).AddTicks(4205), "$2b$12$Qc.MCgibNcBc/5sU7FVW7uoq4nP0dBFAe3on/kHHYkoGa4VLgh84e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 43, 696, DateTimeKind.Utc).AddTicks(7843), "$2b$12$XwlulvG5/ShH.z91VtaF/uioh.x6OWHgPwLUgFl/GPmFzdXNY2oKG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 45, 774, DateTimeKind.Utc).AddTicks(5594), "$2b$12$Xfjz/VHm.W15QJHvZyMcLuGps732lrvyOiZSGECn7/rJPIC.jz5bi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 51, 519, DateTimeKind.Utc).AddTicks(3267), "$2b$12$bwabamKjfGbmoJyt.uA4x.Oov1NO/qAGKLDysBuzqskFJCaAqu80i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 42, 621, DateTimeKind.Utc).AddTicks(8397), "$2b$12$HWzq.82IdcfKYibEthoDG.3VSfjRNMi3EPmS3MMpgJdMcrSyKCsgu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 45, 517, DateTimeKind.Utc).AddTicks(5979), "$2b$12$qJaKBODIfPndJPY4gxWEAuJ47pBaB9Y6BGaAv9P.HMtLvAvPQEG8K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 42, 902, DateTimeKind.Utc).AddTicks(5151), "$2b$12$ELuu/TQbbifwTpSKF0ciJuCVsbY.32cYpFcaz5l.bmob/33imDDUW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 43, 176, DateTimeKind.Utc).AddTicks(6701), "$2b$12$m99lhtf4vt79Ofgx54k2p.rB.uQenDxRpLbsivEqZMJhV8u.RojCi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 44, 212, DateTimeKind.Utc).AddTicks(1921), "$2b$12$KhD3pplw.xn8HdnRk7Z5G.kKBCPX8lqRVFRyL54hAwPK2d6uFm4EK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 46, 546, DateTimeKind.Utc).AddTicks(3024), "$2b$12$un0psAN2mbWAaif7wPSfwOFehbBT3groJQ8PVAImdVcSh4j/3C3vS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 50, 467, DateTimeKind.Utc).AddTicks(3614), "$2b$12$r7dvfqUQ8EvXHIl0P1.Zeu0uU.4Hvp0DOAhjRzCAqwVWqT3ns/JMS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 52, 30, DateTimeKind.Utc).AddTicks(9742), "$2b$12$FKRtjxGZ9Ox5bHCjEZ33YuWRLK7zraZ.7QtbhzT1sE722xQTznZje" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 51, 260, DateTimeKind.Utc).AddTicks(5512), "$2b$12$V04G9BhUsQBlxjsQPZR8/O/zzxZzDxwI2vPDgsUm5PPL2FzuoBZFu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 48, 389, DateTimeKind.Utc).AddTicks(3695), "$2b$12$oE7MMdzp8pIkvCWuxdvpAuT.hyo6fGz01ns49CSnc0Vo/GKa/d.ne" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 48, 911, DateTimeKind.Utc).AddTicks(8694), "$2b$12$dsRIlMlTTMGGJkXC/.pHkuNH64A7.grICWjQxC3oiTgRLA0EVSnUO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 48, 652, DateTimeKind.Utc).AddTicks(3529), "$2b$12$FBRn0EruBDHSz94xuRnlFOypYpmXMf923RkQTdcqADc.F8HrLCZv." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 47, 588, DateTimeKind.Utc).AddTicks(8323), "$2b$12$BbK1gCIsaPJAwJHqexC57ulODPT5Bb3uF1/EKG1EqPXsFs6d0r.Cq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 50, 733, DateTimeKind.Utc).AddTicks(8668), "$2b$12$lXSp9sbSY32XMgePRaYn9OFPDnp.UXwyVYxZnHrnjbJo7Txr3pz3W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 47, 872, DateTimeKind.Utc).AddTicks(9116), "$2b$12$v8f2fv5pd0iqSbch767DWOj87gmPG0WzHhR3kbzSTFLZqN6cnfe0e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 49, 692, DateTimeKind.Utc).AddTicks(1346), "$2b$12$Qv.jF1YttvajT1/AvSIUuOVqt.t83RjBltSGI7nXksUcWDIGl7U7e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 50, 999, DateTimeKind.Utc).AddTicks(6122), "$2b$12$f7ZsJfcaOmpA6Boc/PwBKeyFqtgHqBLL5fXFKFP.1JqCnbDDaIPgS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 46, 289, DateTimeKind.Utc).AddTicks(3180), "$2b$12$AhDfnkURXBmzj6WeHs/94.skhM1kSeWa2u5mTwdYS0zIzAjkRLPDm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 44, 477, DateTimeKind.Utc).AddTicks(1428), "$2b$12$kOPVBHPaHcBbpSbO7gf94.o9BKtQeX6nIxI71TxuAvupGaSuuY3tC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 46, 30, DateTimeKind.Utc).AddTicks(4829), "$2b$12$f.C21aa4Cb53E/OyRtPnFubh.vPkc5M35bQ0kydTu0Av9VUdYVbOG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 45, 257, DateTimeKind.Utc).AddTicks(9921), "$2b$12$XR38iaTJ/2zjco1HmAydEeq69hXtMYS9WcjVg1pd/o9aCFFv/MjEi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 51, 778, DateTimeKind.Utc).AddTicks(1804), "$2b$12$lYzIkyb30ardu80O.i/kruhcl0wcxiKBtk2H.VFuhcjjIKcf30jyy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 43, 952, DateTimeKind.Utc).AddTicks(5246), "$2b$12$dwMGLxIQBm7ieM8LxQ/CMObM3US7LVAV597A32.59qEhZ.eitrCZe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 47, 68, DateTimeKind.Utc).AddTicks(2763), "$2b$12$Ood9HUrfQV0679gMAtdFaOOUML3wXNFaNZ78zW3jUybkaoD1lmic." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 48, 127, DateTimeKind.Utc).AddTicks(4960), "$2b$12$/QmYkenqiJ/OIuSP74OwGuPVIC9wAuDInOSzMCugIOLviJfH9OESa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 49, 950, DateTimeKind.Utc).AddTicks(4194), "$2b$12$Z3xqqc6s5kEmRMjnZXlBHug17wk9GaMMuOOny6caq9I7NqSL67uye" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 50, 205, DateTimeKind.Utc).AddTicks(8029), "$2b$12$P/dhzme2CANV9K4g1uk2T.65MDtZ14cBqPDyq8IffB8JpeTzOGTKy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 49, 171, DateTimeKind.Utc).AddTicks(1561), "$2b$12$fwa7U4PcbiAND.9tFhoeCeBQpwxpuXf/A1uzHrvwVKs57syHi35P." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 47, 323, DateTimeKind.Utc).AddTicks(6234), "$2b$12$1lD5HNK4Qfu7gDyhByHkyOO2ROkrhx5clBuKrBTldHxnCvyPBPQX." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 45, 0, DateTimeKind.Utc).AddTicks(8971), "$2b$12$2WlaehsRFeDW42S.9DL53.dMqU2XdoWHXD8Ozi879scmbNC8atTMK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 44, 739, DateTimeKind.Utc).AddTicks(1522), "$2b$12$tigBLKRjAXSjc7rgXmpdOu/NbDS0kS9sPbZ5FPQ49PpsHwqI2pLQ." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 43, 438, DateTimeKind.Utc).AddTicks(4540), "$2b$12$V0DYlHkIdyOSZQVtjxIrfOw9uXkWJPja4YQ9aLpTvDXHmQSqcV.CK" });

            migrationBuilder.InsertData(
                table: "SessionChange",
                columns: new[] { "session_change_id", "admin_id", "approved_room_id", "change_date", "change_status_id", "change_type", "counter_proposal_date", "counter_proposal_end_time", "counter_proposal_room_id", "counter_proposal_start_time", "proposed_date", "proposed_end_time", "proposed_room_id", "proposed_start_time", "reason", "rejection_reason", "session_id", "teacher_id" },
                values: new object[,]
                {
                    { "3de6c8c7-5af9-7e9d-497d-5406e1803788", "3c22107c-0651-f328-9d16-c4eb18aed5c3", null, new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", "RoomChange", null, null, null, null, null, null, null, null, "La salle actuelle est trop petite pour accueillir tous les étudiants.", null, "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "9e195de5-6c5e-7b51-3f58-fdb509e3bf4a", "3c22107c-0651-f328-9d16-c4eb18aed5c3", null, new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", "SessionRecovery", null, null, null, null, new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0), "02bcf600-5d44-cca7-8b68-e763b00a6339", new TimeSpan(0, 14, 0, 0, 0), "Le cours annulé doit être reprogrammé.", null, "e823715d-0a77-1379-9289-b44b55c10267", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "d380b0b7-72c7-cea2-4c01-7708968cab8f", "3c22107c-0651-f328-9d16-c4eb18aed5c3", null, new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "d16d1a05-a70b-a5f5-6d3a-8013b24626d7", "RoomChange", null, null, null, null, null, null, null, null, "Demande de changement de salle pour équipement non disponible.", "Aucune salle compatible n'est disponible sur ce créneau.", "3701bc4e-401e-f4f3-00aa-b37659789636", "ff7eb421-56b5-3bbe-779c-355ceed7246b" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChangeStatus",
                keyColumn: "change_status_id",
                keyValue: "df4c997e-2e20-921e-98e9-906a9ecf8813");

            migrationBuilder.DeleteData(
                table: "SessionChange",
                keyColumn: "session_change_id",
                keyValue: "3de6c8c7-5af9-7e9d-497d-5406e1803788");

            migrationBuilder.DeleteData(
                table: "SessionChange",
                keyColumn: "session_change_id",
                keyValue: "9e195de5-6c5e-7b51-3f58-fdb509e3bf4a");

            migrationBuilder.DeleteData(
                table: "SessionChange",
                keyColumn: "session_change_id",
                keyValue: "d380b0b7-72c7-cea2-4c01-7708968cab8f");

            migrationBuilder.DeleteData(
                table: "ChangeStatus",
                keyColumn: "change_status_id",
                keyValue: "6d1cab45-5c87-c373-3fd2-91f518c946bc");

            migrationBuilder.DeleteData(
                table: "ChangeStatus",
                keyColumn: "change_status_id",
                keyValue: "d16d1a05-a70b-a5f5-6d3a-8013b24626d7");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 44, 288, DateTimeKind.Utc).AddTicks(3297), "$2b$12$idG1TxkjXP76DHpBlh9JCecQATJXVLClxF89DABZou7UVLLlw0k3m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 47, 54, DateTimeKind.Utc).AddTicks(8489), "$2b$12$2ZEILC2bk/gum1LTS/Cb.uTncZkkIeHV7NZGV85cl4FSGfPCOBpGK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 52, 84, DateTimeKind.Utc).AddTicks(2098), "$2b$12$QPYIPVtRp6V6fQ3F4jLvQep0xYLLpstniUHIevJgyqTHzmt/zJ1GW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 41, 70, DateTimeKind.Utc).AddTicks(1219), "$2b$12$P5.f6IyQcL8j9.apYpwvaOc/COYbkClb5sqFoXIPkKtt9Wmhmszy2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 43, 175, DateTimeKind.Utc).AddTicks(3368), "$2b$12$qI.DKuCrjXxofjWZjwS7Fuk1unBO4jvxdwMoPXzZmelpKbwu6nc92" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 50, 615, DateTimeKind.Utc).AddTicks(1275), "$2b$12$BHn0U2VHFrGqG/tb9/gW.egowCevgC1yYQ7ejV4UlTE.DxAZfRu3K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 39, 897, DateTimeKind.Utc).AddTicks(9000), "$2b$12$cH5SWG/ey7HSpoQ0w2C1d.S2agx9dE1C4hyfaLU/HFvqR8VVWDhsi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 42, 910, DateTimeKind.Utc).AddTicks(9615), "$2b$12$EvuC4YGeNnsEvgU5sU/E6ex10XOuUXqfxh.zXrbRmUTfyDPDnQLSa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 40, 220, DateTimeKind.Utc).AddTicks(256), "$2b$12$Ig1r3OVT2/t1rTKLuzMov.KC5JzqZYhvqLG67Zxc5Dnlf/.Q4Ijo2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 40, 524, DateTimeKind.Utc).AddTicks(7531), "$2b$12$HimkYJSJS1FJYlIayseCG.VrXkPU/Fqet1MGdBprL2s65AfHv9O8W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 41, 598, DateTimeKind.Utc).AddTicks(3519), "$2b$12$Q45Js4QJmWFE9m1Omiao5eI90F4pzFIHuKZossp7NslnKS7iiER3u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 43, 970, DateTimeKind.Utc).AddTicks(2268), "$2b$12$scNsSs3VQoaeaNKRRQFQs.yQVz.sHlfi7B6ELEfm8VmSO628L.A0W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 48, 627, DateTimeKind.Utc).AddTicks(5016), "$2b$12$PsIYHgP3XdF7US3LbkboNOM8CJSCZPcl9oe9Pj9yVH/tNXr6tEqiy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 51, 575, DateTimeKind.Utc).AddTicks(9952), "$2b$12$HXmZ3ktXIEtj.Qzclygw5eeFQ/20UnA5qO5Mepibv.61ctLTuxLny" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 50, 56, DateTimeKind.Utc).AddTicks(3859), "$2b$12$eW4KYO5fuuR6y5umgys8K.R6RboZSGdaQKL6OLmK/KGQ51cc0ZX1K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 45, 891, DateTimeKind.Utc).AddTicks(8773), "$2b$12$irvEUtSJcnXjcu9v3ULqKOqJQ5ayjXRNVlhEjfuNNHT9DdH7CgHxC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 46, 486, DateTimeKind.Utc).AddTicks(5014), "$2b$12$dsjl4hrOUHtbCwaOISdAHeC06OC1KZfjX9uPnejoo/Npn7qqS6.jm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 46, 194, DateTimeKind.Utc).AddTicks(7373), "$2b$12$GBFQ3GoLKuhzr2uocTw/GO7CeyXrsbDSofGxASqrUfvRrfoLr1lGK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 45, 97, DateTimeKind.Utc).AddTicks(4333), "$2b$12$x5uNZdagOUXfaPU1Bb268Ok8PDRDc5jWO0Hhselom09VAih5nlHfy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 49, 105, DateTimeKind.Utc).AddTicks(1841), "$2b$12$6HHlJfUYMwYhzhu3UGSmi.68q4g/dGrVxx5pM8t9cptdAJ3p6Cy3C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 45, 362, DateTimeKind.Utc).AddTicks(3945), "$2b$12$5l1ELSMyAdngRWvOca4iTeci5mQZnq7/coEi28wuEtWG2M1Wm.ohK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 47, 326, DateTimeKind.Utc).AddTicks(690), "$2b$12$2e0.J3lyATCFLM6ZI15W4.K9XOu1CRSFuiToaVFwYIEoEr0i73daK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 49, 561, DateTimeKind.Utc).AddTicks(9573), "$2b$12$jcDta3w3QiroiTyDpTkF4OH6XRGWhN53BOpzK6B0TO17xrugfpLU." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 43, 698, DateTimeKind.Utc).AddTicks(2734), "$2b$12$Hdr/dNMT.692UlxZrQVVkOdduuOVciHEhMWr2b6kSNM7F.XGcdNsq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 41, 873, DateTimeKind.Utc).AddTicks(75), "$2b$12$NT7qMWiKB94/IFZAmkVe1eMFzHYpzmHAHd/7aKdKu3172EcXMNoyK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 43, 440, DateTimeKind.Utc).AddTicks(4843), "$2b$12$E.2y0.c5gVq9hFNDZdhP4OP4aIQMSo8myHRRfULwRdQtfuBF39rqu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 42, 655, DateTimeKind.Utc).AddTicks(7238), "$2b$12$znQd9Tk1vitJIDZhOIOL2uDpoDRikYVVx65.E9ePiBVKiRUwQ68Xq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 51, 69, DateTimeKind.Utc).AddTicks(5413), "$2b$12$nydJRwa8seuMRfGbf7lXoOYSwULdnMuxUF6/aatCBXJHd4GkC.VeK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 41, 339, DateTimeKind.Utc).AddTicks(1063), "$2b$12$4UF0z2njkAqKQ6g45hMdMuyJqmeKDfX4f.5cnBwXRC1FsJcg7j8ze" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 44, 567, DateTimeKind.Utc).AddTicks(1301), "$2b$12$m9vP5.Sura7U/cmlTikfVOf.cn4YupTpRlW7c57pxMq5f7rc3IyVe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 45, 624, DateTimeKind.Utc).AddTicks(9603), "$2b$12$.FE.utFI4bqmEndeA.gg5e/wW5M.DZSTeWxmMIFAF1bqj5SYcvk/u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 47, 659, DateTimeKind.Utc).AddTicks(4271), "$2b$12$7ApGvzjR2QbS7zHu6libG.Yq8um4/VZ96WG2cbJlD2Ryz6hJ18KIK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 48, 154, DateTimeKind.Utc).AddTicks(5952), "$2b$12$g1912Z.W8ipjcIx1oQ3up.3BBQSv1ETquZB0lZt5F0w/RAmVm2oWq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 46, 770, DateTimeKind.Utc).AddTicks(6272), "$2b$12$ScNBd3XjyOUWOjFOV.rYPurOP2i.oUFe0TA1yO66rlwGaQPokri2." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 44, 837, DateTimeKind.Utc).AddTicks(4048), "$2b$12$10mcon2LACkHPqhgZT4mVOyJFfljI4Rp1ULJAYrFZg.T16vfKLnT6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 42, 402, DateTimeKind.Utc).AddTicks(6538), "$2b$12$o0LJht5fpWy.XMQppJNK8enZAPx9z2fSUQPHJNDdW9/4MZdchCKP2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 42, 144, DateTimeKind.Utc).AddTicks(566), "$2b$12$bW/8iKBLKtGizevtk1UaaO.sSWZmoUUHL3MAWzdnK.T.22r3lNwIy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 40, 793, DateTimeKind.Utc).AddTicks(4075), "$2b$12$JEX.bDIo5CVhexi2jAEc1usz4UA.eZ2OwXMwcjXuEKy876XCRRSX6" });
        }
    }
}
