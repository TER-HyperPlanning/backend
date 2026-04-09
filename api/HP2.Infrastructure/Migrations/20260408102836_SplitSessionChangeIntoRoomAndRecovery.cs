using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SplitSessionChangeIntoRoomAndRecovery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SessionChange");

            migrationBuilder.CreateTable(
                name: "SessionRecoveryChange",
                columns: table => new
                {
                    session_recovery_change_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    change_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    reason = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    teacher_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    session_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    change_status_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    proposed_date = table.Column<DateTime>(type: "date", nullable: true),
                    proposed_start_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    proposed_end_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    proposed_room_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    counter_proposal_date = table.Column<DateTime>(type: "date", nullable: true),
                    counter_proposal_start_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    counter_proposal_end_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    counter_proposal_room_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    rejection_reason = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SessionR__RecoveryChange", x => x.session_recovery_change_id);
                    table.ForeignKey(
                        name: "FK_RecoveryChange_CounterProposalRoom",
                        column: x => x.counter_proposal_room_id,
                        principalTable: "Room",
                        principalColumn: "room_id");
                    table.ForeignKey(
                        name: "FK_RecoveryChange_ProposedRoom",
                        column: x => x.proposed_room_id,
                        principalTable: "Room",
                        principalColumn: "room_id");
                    table.ForeignKey(
                        name: "FK_RecoveryChange_Session",
                        column: x => x.session_id,
                        principalTable: "Session",
                        principalColumn: "session_id");
                    table.ForeignKey(
                        name: "FK_RecoveryChange_Status",
                        column: x => x.change_status_id,
                        principalTable: "ChangeStatus",
                        principalColumn: "change_status_id");
                    table.ForeignKey(
                        name: "FK_RecoveryChange_Teacher",
                        column: x => x.teacher_id,
                        principalTable: "Teacher",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateTable(
                name: "SessionRoomChange",
                columns: table => new
                {
                    session_room_change_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    change_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    reason = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    teacher_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    session_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    change_status_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    approved_room_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    rejection_reason = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SessionR__RoomChange", x => x.session_room_change_id);
                    table.ForeignKey(
                        name: "FK_RoomChange_ApprovedRoom",
                        column: x => x.approved_room_id,
                        principalTable: "Room",
                        principalColumn: "room_id");
                    table.ForeignKey(
                        name: "FK_RoomChange_Session",
                        column: x => x.session_id,
                        principalTable: "Session",
                        principalColumn: "session_id");
                    table.ForeignKey(
                        name: "FK_RoomChange_Status",
                        column: x => x.change_status_id,
                        principalTable: "ChangeStatus",
                        principalColumn: "change_status_id");
                    table.ForeignKey(
                        name: "FK_RoomChange_Teacher",
                        column: x => x.teacher_id,
                        principalTable: "Teacher",
                        principalColumn: "user_id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_SessionRecoveryChange_change_status_id",
                table: "SessionRecoveryChange",
                column: "change_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionRecoveryChange_counter_proposal_room_id",
                table: "SessionRecoveryChange",
                column: "counter_proposal_room_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionRecoveryChange_proposed_room_id",
                table: "SessionRecoveryChange",
                column: "proposed_room_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionRecoveryChange_session_id",
                table: "SessionRecoveryChange",
                column: "session_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionRecoveryChange_teacher_id",
                table: "SessionRecoveryChange",
                column: "teacher_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionRoomChange_approved_room_id",
                table: "SessionRoomChange",
                column: "approved_room_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionRoomChange_change_status_id",
                table: "SessionRoomChange",
                column: "change_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionRoomChange_session_id",
                table: "SessionRoomChange",
                column: "session_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionRoomChange_teacher_id",
                table: "SessionRoomChange",
                column: "teacher_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SessionRecoveryChange");

            migrationBuilder.DropTable(
                name: "SessionRoomChange");

            migrationBuilder.CreateTable(
                name: "SessionChange",
                columns: table => new
                {
                    session_change_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    admin_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    approved_room_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    change_status_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    counter_proposal_room_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    proposed_room_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    session_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    teacher_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    change_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    change_type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    counter_proposal_date = table.Column<DateTime>(type: "date", nullable: true),
                    counter_proposal_end_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    counter_proposal_start_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    proposed_date = table.Column<DateTime>(type: "date", nullable: true),
                    proposed_end_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    proposed_start_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    reason = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    rejection_reason = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SessionC__D5E31D8F21E5A4A9", x => x.session_change_id);
                    table.ForeignKey(
                        name: "FK_Change_Admin",
                        column: x => x.admin_id,
                        principalTable: "Admin",
                        principalColumn: "user_id");
                    table.ForeignKey(
                        name: "FK_Change_Session",
                        column: x => x.session_id,
                        principalTable: "Session",
                        principalColumn: "session_id");
                    table.ForeignKey(
                        name: "FK_Change_Status",
                        column: x => x.change_status_id,
                        principalTable: "ChangeStatus",
                        principalColumn: "change_status_id");
                    table.ForeignKey(
                        name: "FK_Change_Teacher",
                        column: x => x.teacher_id,
                        principalTable: "Teacher",
                        principalColumn: "user_id");
                    table.ForeignKey(
                        name: "FK_SessionChange_ApprovedRoom",
                        column: x => x.approved_room_id,
                        principalTable: "Room",
                        principalColumn: "room_id");
                    table.ForeignKey(
                        name: "FK_SessionChange_CounterProposalRoom",
                        column: x => x.counter_proposal_room_id,
                        principalTable: "Room",
                        principalColumn: "room_id");
                    table.ForeignKey(
                        name: "FK_SessionChange_ProposedRoom",
                        column: x => x.proposed_room_id,
                        principalTable: "Room",
                        principalColumn: "room_id");
                });

            migrationBuilder.InsertData(
                table: "SessionChange",
                columns: new[] { "session_change_id", "admin_id", "approved_room_id", "change_date", "change_status_id", "change_type", "counter_proposal_date", "counter_proposal_end_time", "counter_proposal_room_id", "counter_proposal_start_time", "proposed_date", "proposed_end_time", "proposed_room_id", "proposed_start_time", "reason", "rejection_reason", "session_id", "teacher_id" },
                values: new object[,]
                {
                    { "3de6c8c7-5af9-7e9d-497d-5406e1803788", "3c22107c-0651-f328-9d16-c4eb18aed5c3", null, new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", "RoomChange", null, null, null, null, null, null, null, null, "La salle actuelle est trop petite pour accueillir tous les étudiants.", null, "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "9e195de5-6c5e-7b51-3f58-fdb509e3bf4a", "3c22107c-0651-f328-9d16-c4eb18aed5c3", null, new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", "SessionRecovery", null, null, null, null, new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0), "02bcf600-5d44-cca7-8b68-e763b00a6339", new TimeSpan(0, 14, 0, 0, 0), "Le cours annulé doit être reprogrammé.", null, "e823715d-0a77-1379-9289-b44b55c10267", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "d380b0b7-72c7-cea2-4c01-7708968cab8f", "3c22107c-0651-f328-9d16-c4eb18aed5c3", null, new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "d16d1a05-a70b-a5f5-6d3a-8013b24626d7", "RoomChange", null, null, null, null, null, null, null, null, "Demande de changement de salle pour équipement non disponible.", "Aucune salle compatible n'est disponible sur ce créneau.", "3701bc4e-401e-f4f3-00aa-b37659789636", "ff7eb421-56b5-3bbe-779c-355ceed7246b" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "011f7dd9-fd3a-3d41-6190-1f4489c299e9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 53, 407, DateTimeKind.Utc).AddTicks(6818), "$2b$12$XCBSr.a4fc4TI/u7VrpdAOE/hIWC/gMZmY6nGAlv0VqGAW/AuQOPC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "015a9397-c5c4-4b03-eb4f-86048ec621f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 24, 425, DateTimeKind.Utc).AddTicks(8858), "$2b$12$Qhm6Tz1Hd3v0ZpNFyOF0HOB4KrVVWbqmMKZHyiAfrTgoywL3VIItK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "03428ee8-3d9a-de72-c98b-dbc65724b005",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 43, 440, DateTimeKind.Utc).AddTicks(6983), "$2b$12$0U6L5Y8ziGsbt5f9VlQCDOHRUZ4ot0t/FPpOaGF5fvboPbSshilTK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 22, 367, DateTimeKind.Utc).AddTicks(2479), "$2b$12$TKJjcwKhjkN59ytfJ4xGTeKcTHd1xN6.JPpLOqjFRoHRtGM03NMyy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 46, 803, DateTimeKind.Utc).AddTicks(7761), "$2b$12$mCMGy8ow099LyYV3tk6r6u8JvCOMD0ETodJ.zipuWiZHMc9o5YUBW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0a3f73e7-67a8-750c-576a-49c22125bac7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 55, 213, DateTimeKind.Utc).AddTicks(7551), "$2b$12$CqSpYD7iEzs9KCUxobbA2.NTB5ZcDZ67dt1NQKgd4RHNbPc3lFz8O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 17, 486, DateTimeKind.Utc).AddTicks(7383), "$2b$12$TXLTdC10zVAPFErLilDRlO3MkqDV1WXXntMQV6USV5TePDUjQcL3q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b48ba68-2d76-43aa-8392-7b40b1aa1e19",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 51, 396, DateTimeKind.Utc).AddTicks(2171), "$2b$12$eGyOF6BX0CI2JJUUn.Q1d.yxKwNngHjfwlPYR.j7VHkCQ7D6k14Pm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 49, 426, DateTimeKind.Utc).AddTicks(4795), "$2b$12$KyXdGJVnp2Ih.iJfu/yfoe.sKjf9ycLAWhWLYOGQvhLD3lTU1/ZVO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "129452cc-6c9b-3726-5c96-54b67ac3b884",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 56, 193, DateTimeKind.Utc).AddTicks(1498), "$2b$12$IFho0FW4M8pCz0DbKswfpOl4QCZYK7kSYul1YDs4/FiJIErvn1sFS" });

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
                keyValue: "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 41, 55, DateTimeKind.Utc).AddTicks(9244), "$2b$12$TwvR2vzqsa19mU2KVTW4I.Zd8Cvb3RY4eE82DQk4hRavnkCtBXdZK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 45, 774, DateTimeKind.Utc).AddTicks(5594), "$2b$12$Xfjz/VHm.W15QJHvZyMcLuGps732lrvyOiZSGECn7/rJPIC.jz5bi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "18241d26-a012-b189-957c-b5573ecb15d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 45, 696, DateTimeKind.Utc).AddTicks(8177), "$2b$12$2/9bTh.s37XF9aGlilpFWu3f/z1h5j3eLPNTsmEJsEGasNYhBYabe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 20, 171, DateTimeKind.Utc).AddTicks(9615), "$2b$12$lbuQMlOPpO6rFkQMsty2tOZSkta7i9BGF7vgGeUvGPMJkyF40w9Zy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 20, 886, DateTimeKind.Utc).AddTicks(7323), "$2b$12$b9SvjQXMHZSNzjXMnoYfquRyVS0HMYOCfd/lFACqPAXk4GSfWbz.2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "288bdacf-8acb-a8d1-59f9-94f0cccb2086",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 49, 629, DateTimeKind.Utc).AddTicks(9306), "$2b$12$dzCfAP8DZntHiD10qFsf8.C86TRwPuoeb2CGzjysnFwE9liR/XVbG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "296e74bd-c209-7f7c-d030-28e85a1aad75",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 25, 80, DateTimeKind.Utc).AddTicks(2341), "$2b$12$GULcqrvZK384R4SehvhhsuosD4OXGvYg1hdR1k1VvqzE9cZSIwuja" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2b5c3a92-dc35-b1bd-16c3-b0f8a21f29f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 47, 307, DateTimeKind.Utc).AddTicks(1231), "$2b$12$TAeKsyb48AQUKxieAg/HGej2T8uw0VnGjTZL2AMVbaxDrqVZQTDSC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2fa22e35-4eb2-7351-ee0e-a523ac305c44",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 52, 68, DateTimeKind.Utc).AddTicks(3563), "$2b$12$AxRq.zDMZG6Ziub0NB56qe41WU29ErjLGDA1.P8KFe206P2UiPyuC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 51, 519, DateTimeKind.Utc).AddTicks(3267), "$2b$12$bwabamKjfGbmoJyt.uA4x.Oov1NO/qAGKLDysBuzqskFJCaAqu80i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "373399d1-2bd2-aee5-629b-43f96da8f03e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 55, 874, DateTimeKind.Utc).AddTicks(6124), "$2b$12$XrO5KEgjpaEnqYWKElmXO.6FPc2khuWD8u1dtiGcVTpCIhkzstHyO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3769412b-799f-6b72-f74f-9b9b735058c2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 48, 332, DateTimeKind.Utc).AddTicks(6035), "$2b$12$1DVqt0E7iWrEyQ1Gy2YrneFGxqc3w7N7bA2JEpgoBJKhx57RK5/dy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3830d83f-4097-76e0-a9e0-b90ef45d1c79",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 46, 332, DateTimeKind.Utc).AddTicks(6930), "$2b$12$lu3JnL9/jf0a7x63TMjENuLWcoCdMn1ZaUN0ohXKwD77b72t45AAW" });

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
                keyValue: "476292a1-d3ae-cacd-a58c-2d14790da8eb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 52, 748, DateTimeKind.Utc).AddTicks(5925), "$2b$12$TyX6At5s3Z.Bl0ZoCQZ6Uusv.Dsp2ynWgh86TajvDKxbWXgWPbfS6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 17, 805, DateTimeKind.Utc).AddTicks(1424), "$2b$12$RkqT5Lq6pP44tzrceLdQDOEHZSfDTpVajeIcFkVY0bxOwt7e3szDG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4d41b3e5-536d-0aa0-a3e3-024218ac6267",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 40, 51, DateTimeKind.Utc).AddTicks(196), "$2b$12$vcw4y1TFzQin1poUPsOVfeoeA3pGqz4J486Y0DNmOxbvqBwHCf7gi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "51432fb0-cda4-87aa-a2d2-e36c25823a2b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 41, 385, DateTimeKind.Utc).AddTicks(9077), "$2b$12$MbO0aCzGZh0fHure4DmbUevaTw7ueSwLI1Qr0DlrKjzHJCQDpm/Oi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "52fb0554-7e57-01bb-5949-987520c91eb5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 39, 36, DateTimeKind.Utc).AddTicks(362), "$2b$12$TDT/lpnghaESZYgf8vPktuK.j1o6ailG629FjitjTAC68eXnF4spO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "539ead07-d571-367b-79f7-68b21513886b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 51, 20, DateTimeKind.Utc).AddTicks(2917), "$2b$12$AFZdvlUJKyPBz3kAGrpe1uNegWuUtY4A1agyPgJzfJ/hWyzje58Qq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "557dd714-15d7-6df3-3ed1-22a2eec63c59",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 37, 743, DateTimeKind.Utc).AddTicks(1454), "$2b$12$TdWSzgfGwR0KuZNKpSl.luSuwzmOIaBEdP9bOppYSXTR3wNkz2tj." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "57f13355-ddb7-5d3c-b09a-ff2c56e22753",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 36, 789, DateTimeKind.Utc).AddTicks(8233), "$2b$12$8eJfv4kzOLFXXy/JuBHvx.zXub88NQGGyoPT546B/3Ss32mWqW5ZO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 21, 620, DateTimeKind.Utc).AddTicks(3201), "$2b$12$A3QAtMo40R2oN7OS23RakehGiWjg39p98Ne6mBuPFCxY//XSrCwwa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 43, 176, DateTimeKind.Utc).AddTicks(6701), "$2b$12$m99lhtf4vt79Ofgx54k2p.rB.uQenDxRpLbsivEqZMJhV8u.RojCi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 23, 437, DateTimeKind.Utc).AddTicks(5806), "$2b$12$rWXQsHhy3PjKk6m9e42o5uOqp2GhkUSBeFu6r3gNZqRowOWGNp.p." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "617cb820-a96f-5ce4-513e-f9de2ec06556",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 40, 727, DateTimeKind.Utc).AddTicks(2925), "$2b$12$ib6U0R2PXZ5vrhKAqgXbieoTBPexm2Pjf.Jp.l71q1YtwQpAZsFfy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "62f48843-9c38-a162-72b9-af6d09b80de3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 52, 401, DateTimeKind.Utc).AddTicks(4138), "$2b$12$GkoXyBF.oTa4pcUYaYFbYe13.AqugjHVe5np8/Tkwdv7BceH2C/e6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 44, 212, DateTimeKind.Utc).AddTicks(1921), "$2b$12$KhD3pplw.xn8HdnRk7Z5G.kKBCPX8lqRVFRyL54hAwPK2d6uFm4EK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "65aa7c04-2529-20cc-46f7-47c22df3e1d0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 54, 120, DateTimeKind.Utc).AddTicks(1702), "$2b$12$GDm1PR8S5ud9gbddLLCV2egoYMqJpQqiMuvwlzfgLwZP2OmeXzILC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "68fbd87f-0c94-976f-40de-323667ff06bf",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 43, 756, DateTimeKind.Utc).AddTicks(8996), "$2b$12$o3HaoxxuADbzwcNRfze2le3EpGVD3ffBezCOqKbTSdP0zvoxlaneG" });

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
                keyValue: "6dcd090f-508b-7888-b458-17aeea49123a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 55, 551, DateTimeKind.Utc).AddTicks(727), "$2b$12$ix2sXJZW2oZsj6ozMOK1K.Af.f8NzHjIxncOtER85xGjExPUg3yz." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6e5a0735-7928-5aca-b192-5e455fca402a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 46, 641, DateTimeKind.Utc).AddTicks(6636), "$2b$12$XmptYhHefOPBHgDksDROe.jKa8N5L8/8meA3TkOmwUhR8Tj21..Y2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 38, 385, DateTimeKind.Utc).AddTicks(4762), "$2b$12$LnSMwJom2zvyL68gcK7djOBgzI/TO4NtslYYfe2OMo3JhcLzxJQkm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 52, 30, DateTimeKind.Utc).AddTicks(9742), "$2b$12$FKRtjxGZ9Ox5bHCjEZ33YuWRLK7zraZ.7QtbhzT1sE722xQTznZje" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 23, 773, DateTimeKind.Utc).AddTicks(3998), "$2b$12$jBB.TrIFDoCvXzfsZeBPsOPCim10vp6qMLOLeztwYkpa/d/i8acUO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7f2e2223-eda8-2785-2b9f-2f6cbfecc012",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 25, 414, DateTimeKind.Utc).AddTicks(4821), "$2b$12$19yvVmn8axlUsW49qcZMqewSLntzgCo6nmEux2bN4Lvxq0VwM4y.6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8112e653-13fd-c47d-0fc5-7b36eda72bf0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 44, 731, DateTimeKind.Utc).AddTicks(1740), "$2b$12$gJOrqSdyn/XC/sOHHcw3h.NIPHxUfB9ZSr8qduhpinmGKV8NUA5G." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8976fc22-4f3c-f5a6-a6d7-81058525ac85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 56, 525, DateTimeKind.Utc).AddTicks(7999), "$2b$12$l3t.5VJY81qc0SIL.nMS6.SZloT9JxzNKVC/HYj5pc4iBbgKof7Uy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8b8636d1-c1b0-1104-ebb5-a8e7e20d35ae",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 51, 721, DateTimeKind.Utc).AddTicks(5037), "$2b$12$bNaTpOc1JEEsrvOOS9wwAuov63p3oFBIgDcuFwJQ53HkxeULFSpKq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 43, 113, DateTimeKind.Utc).AddTicks(474), "$2b$12$jNSJkfHbXHBtL4n1XQKTKeOT2q298FuYjy7tYJJREtTRorMpEeQVC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c62f6c8-d791-e825-bdef-5c14bf5ce951",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 24, 758, DateTimeKind.Utc).AddTicks(1226), "$2b$12$rTDFs.scZMKbI81BHJUc/usJgpMm7mcvXlvn9curgB7Dmc7lMrJRm" });

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
                keyValue: "8e1a2182-9af2-5229-2104-66051e4b6220",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 25, 767, DateTimeKind.Utc).AddTicks(4961), "$2b$12$SWrhcFsmKQZquyPwMAOYBOyXyk6AzRqTeqNVnDA8FpeF/Dzsui2P6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e85356b-dff7-0fe0-9e0a-ac24101ff81c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 39, 370, DateTimeKind.Utc).AddTicks(7716), "$2b$12$Nc.6M1FbE5c6t5VMaRqlJ..bbm0YSyPoyZ4ixu4ABLir.Y8p2/VW." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8ee02cf3-bf69-3090-c8a3-acd718cd445f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 38, 66, DateTimeKind.Utc).AddTicks(6166), "$2b$12$Rjq8BwP4nZm5tCFI2ShgKeReTA2KoI1KomraE7.x3mn9Yg5Q4sJiW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "91f97c43-df32-927a-bb77-3f050c28c5d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 39, 697, DateTimeKind.Utc).AddTicks(1729), "$2b$12$/8HRxic2bkw1BquQGww/IOFZjV.66DPB7onvM29XSFqWlzPfFhvU2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "953715b4-1d71-3023-7048-42579385f359",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 48, 652, DateTimeKind.Utc).AddTicks(6787), "$2b$12$04rPy9QMygPuhCJuEe6NH.4GAW/8HqPcwSUb2Nq5Px8EnkNspu7cG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "954d4710-fb9b-9bc8-33d6-1a00378fef99",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 46, 8, DateTimeKind.Utc).AddTicks(7742), "$2b$12$6qQ8bxg/XSDcCU8qQZBgNOUjAv04YgosKXIvTM4AzAdfKtpnxvWr." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "95755e71-293b-5fbe-2e06-ff9c6d90e96f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 42, 91, DateTimeKind.Utc).AddTicks(9108), "$2b$12$wFkXTl43acDPbZUZ5bWspe/yThqAmfCe9Yruv15VCUO7SfhTGdawS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "96cb69c8-c721-11de-8075-582c3bb936c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 45, 66, DateTimeKind.Utc).AddTicks(466), "$2b$12$HAsS/xo6kjoX5OvOuwwuhuBb0xIVIJcuElM/qRqdOmMB7PB2QGfjm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 48, 911, DateTimeKind.Utc).AddTicks(8694), "$2b$12$dsRIlMlTTMGGJkXC/.pHkuNH64A7.grICWjQxC3oiTgRLA0EVSnUO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9ade6863-7e26-4864-6736-dc579f1c7a31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 26, 107, DateTimeKind.Utc).AddTicks(5998), "$2b$12$oSeTxuHcc7IJEfPgWyfvCe4RUXXbSa4UB.kwNO3IHNQBcVCZEnQZy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9dd3d6be-aadd-a804-775f-b0817d3508fc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 50, 339, DateTimeKind.Utc).AddTicks(782), "$2b$12$GQARe2E3ojIjtOGRWI7l0uyUOXBy3duZ.MuPcl2kFc6W3WgWXAGcC" });

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
                keyValue: "9f3e92f6-ee55-979e-23b7-f713245738cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 50, 0, DateTimeKind.Utc).AddTicks(8402), "$2b$12$qeMJp17HSVjk42npWrsZEuXU7LFC9hAUzIWdvybLrARZGGL7PuRjO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 50, 733, DateTimeKind.Utc).AddTicks(8668), "$2b$12$lXSp9sbSY32XMgePRaYn9OFPDnp.UXwyVYxZnHrnjbJo7Txr3pz3W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 42, 426, DateTimeKind.Utc).AddTicks(4592), "$2b$12$FI7NonmHHTDXxz/6uM/yyua6tt7zKxQyyvDt24JZH3vNuIhpz2Edu" });

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
                keyValue: "a70a25e3-1d3d-3e25-2f6d-c728283dce2c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 53, 777, DateTimeKind.Utc).AddTicks(2999), "$2b$12$laLyxdC987sy.laFCm0Ilu2Jjw2nMLV2ICxSRuSUcfAYjB5HJK2.K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a81af79f-d5c1-b515-0d1e-fe2dbabc780d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 50, 674, DateTimeKind.Utc).AddTicks(4918), "$2b$12$O289tt5GrfLjuIlnOoBWxeToqlTChdgVoDwio5kyg4trFVRQwKQY6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a894def6-b00b-6103-0ac7-92aa2bf2a079",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 48, 981, DateTimeKind.Utc).AddTicks(3346), "$2b$12$e/1zHISZJHi7AKPhU4vDsu9sAGfHc33odG1aRXQP1MbJVVG9ziJGy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ada69e11-1e1e-3387-80da-a6afa8505ba2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 47, 675, DateTimeKind.Utc).AddTicks(6633), "$2b$12$MbkdN5wMhDb4gXGexj3Xe.5U7bg/dh7J9Jgb22DkjyJK4gv5sbqMW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "aeba3eba-9c59-d115-5781-476232f36f4c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 42, 779, DateTimeKind.Utc).AddTicks(4278), "$2b$12$V4h4UUdqHha.tReBVQFxieNYA0YMPRofa8QHSQ878q8HjPs05nccy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "af142cbb-a95e-ab3e-f00a-a39f87004ec3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 37, 112, DateTimeKind.Utc).AddTicks(2449), "$2b$12$AdoYS6KHBtu/KHwHHnBNvuq7N9.TT9HHH0iYTjWmCWZ2DZbGgI/Cy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "afa4fe08-4af6-cc2b-778f-115de345ebba",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 54, 500, DateTimeKind.Utc).AddTicks(1819), "$2b$12$dSoqe0VUZFwwXrcJwojvOOjQP7GXL4QXEoAryCS9XHHkg1UQ5Eaj." });

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
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 16, 833, DateTimeKind.Utc).AddTicks(7352), "$2b$12$pGb1EWcTfwgUrxuYtZXJhezE7L658luhHPTM/FW6NX4X0TBizD1vu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 44, 477, DateTimeKind.Utc).AddTicks(1428), "$2b$12$kOPVBHPaHcBbpSbO7gf94.o9BKtQeX6nIxI71TxuAvupGaSuuY3tC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 44, 399, DateTimeKind.Utc).AddTicks(6256), "$2b$12$YsaL0ijrWn0nRB/oNVNc5OJtHV6NTXLP1WEKdnkGre6tdRM9O5YXC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 20, 518, DateTimeKind.Utc).AddTicks(1799), "$2b$12$NHTwKq9RI9.t2C0wf8m4wuwPLNSs/azLPQfvag1J28u.Qyhg.1Utq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 46, 30, DateTimeKind.Utc).AddTicks(4829), "$2b$12$f.C21aa4Cb53E/OyRtPnFubh.vPkc5M35bQ0kydTu0Av9VUdYVbOG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 40, 387, DateTimeKind.Utc).AddTicks(5979), "$2b$12$Wcc0LITvjc5g3YXC//eX4ex59r/65clzZFMlh12eTMa32YFk5zaoq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c2dd0d11-f58f-2546-c1ca-10b453a7bc96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 45, 375, DateTimeKind.Utc).AddTicks(3408), "$2b$12$S5P7paO0hLubAc9Lj0pSquPPUuHS7X9qUvhjo7x.qRmHgejQ1KR4y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c668490c-dda2-f1b1-d170-72005fc34624",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 41, 736, DateTimeKind.Utc).AddTicks(642), "$2b$12$pSL1ra67.67B5FvD6pQKSOP2HxZBfYHg1Gqv0ratm5og2NY5W2NYC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 45, 257, DateTimeKind.Utc).AddTicks(9921), "$2b$12$XR38iaTJ/2zjco1HmAydEeq69hXtMYS9WcjVg1pd/o9aCFFv/MjEi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c8936e2c-61ab-766a-1161-ed4577bda964",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 44, 76, DateTimeKind.Utc).AddTicks(3591), "$2b$12$17BMuXoMAoRpZX4NWEueheC6aQFbnzdtogdz8TptAh.ZAopj97oaa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 51, 778, DateTimeKind.Utc).AddTicks(1804), "$2b$12$lYzIkyb30ardu80O.i/kruhcl0wcxiKBtk2H.VFuhcjjIKcf30jyy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ccd1db56-b977-3035-ca07-0d16377dbbe1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 38, 696, DateTimeKind.Utc).AddTicks(9704), "$2b$12$cYp4Dh34D0n57.18e3n94e6lpTquhX785xEWIvsRhpc116LTOv7Ry" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d3f7232a-7eb6-649e-c1fc-ad010f705d7a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 24, 100, DateTimeKind.Utc).AddTicks(2808), "$2b$12$KzlEse98aDn7aQCSWKWAUO9b5jkbP.xkQbkMcqwPZM0YNmCcgyoYC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 21, 245, DateTimeKind.Utc).AddTicks(9377), "$2b$12$rwXv0ZCR/ztoWIVH96eAeevKOrCMCGWq512u7CWVG92AmlZtkfLgq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 43, 952, DateTimeKind.Utc).AddTicks(5246), "$2b$12$dwMGLxIQBm7ieM8LxQ/CMObM3US7LVAV597A32.59qEhZ.eitrCZe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8924a08-9bc1-e88e-8396-1a1e86e2276b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 37, 420, DateTimeKind.Utc).AddTicks(6758), "$2b$12$CQ.J2B/DiJthYU24ZaH/5.yXBIcPWMsc8EDmWjkuMegWLBMyAdWDK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 47, 68, DateTimeKind.Utc).AddTicks(2763), "$2b$12$Ood9HUrfQV0679gMAtdFaOOUML3wXNFaNZ78zW3jUybkaoD1lmic." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 17, 146, DateTimeKind.Utc).AddTicks(8187), "$2b$12$1zpUmWUaTQczC2nyc/EmTe3T5uqGeWUENMwAcXW7WuOIZ0tqOAJV6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 48, 127, DateTimeKind.Utc).AddTicks(4960), "$2b$12$/QmYkenqiJ/OIuSP74OwGuPVIC9wAuDInOSzMCugIOLviJfH9OESa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd288475-9710-eabb-7cca-449e335c3070",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 46, 968, DateTimeKind.Utc).AddTicks(2597), "$2b$12$HygKCxCgFvk3pdcuqYGtjOyqz3nhuWrhS.GOKtMwhZVLJDwhyDMQa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 22, 8, DateTimeKind.Utc).AddTicks(7033), "$2b$12$AWSI0j7HtdAdqOJlcf3Fj.JOlbIAy8Wck8QC7Xv44GGOp9GfREvcO" });

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
                keyValue: "e48c4173-bb79-99df-4cdb-550c4acb9bfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 54, 859, DateTimeKind.Utc).AddTicks(1231), "$2b$12$3UEoukUqlaKXHY7HuoEq2eEQXKlPX/o6.iStbeT1SsVYL2.8uGnFi" });

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
                keyValue: "ecd9a403-0fa0-120e-0580-76ac458c1397",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 49, 308, DateTimeKind.Utc).AddTicks(5548), "$2b$12$PePvwl8FiIu.Z8OgbuSnEuIEUFsYu7epie9mFa8ReH/YtTmEE8n.m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 4, 42, 45, 0, DateTimeKind.Utc).AddTicks(8971), "$2b$12$2WlaehsRFeDW42S.9DL53.dMqU2XdoWHXD8Ozi879scmbNC8atTMK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f0af01b8-a5e4-18f8-889c-4863d1166ca9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 53, 81, DateTimeKind.Utc).AddTicks(6367), "$2b$12$qBEqzJo8qlJ/y9mnPxiwq.OXJ8GN/H0bS1a8RR8BdY6oGFEPGLPGW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f828e1ce-18e1-0c76-9535-92a277f7875a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 47, 995, DateTimeKind.Utc).AddTicks(2761), "$2b$12$yoDqwNCTPecrJMH1G.MZMuN8D16yB4bgI4KAiUQOzT/Kobq.QEhpK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 23, 109, DateTimeKind.Utc).AddTicks(5736), "$2b$12$v5WrjRmmNVIYHd2PDqnwJezvcBvE1Xn0fi2a19wU4J98yOqxn1QAa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 22, 766, DateTimeKind.Utc).AddTicks(5140), "$2b$12$U67a5McM78sgAfdVgePh5eCsdFkzUcQQk3zfuitnQIY6ycSK/771S" });

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

            migrationBuilder.CreateIndex(
                name: "IX_SessionChange_admin_id",
                table: "SessionChange",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionChange_approved_room_id",
                table: "SessionChange",
                column: "approved_room_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionChange_change_status_id",
                table: "SessionChange",
                column: "change_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionChange_counter_proposal_room_id",
                table: "SessionChange",
                column: "counter_proposal_room_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionChange_proposed_room_id",
                table: "SessionChange",
                column: "proposed_room_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionChange_session_id",
                table: "SessionChange",
                column: "session_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionChange_teacher_id",
                table: "SessionChange",
                column: "teacher_id");
        }
    }
}
