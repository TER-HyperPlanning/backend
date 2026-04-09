using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAvailabilityGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "availability_group_id",
                table: "Availability",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AvailabilityGroup",
                columns: table => new
                {
                    availability_group_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    teacher_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    number_of_available_days = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailabilityGroup", x => x.availability_group_id);
                    table.ForeignKey(
                        name: "FK_AvailabilityGroup_Teacher",
                        column: x => x.teacher_id,
                        principalTable: "Teacher",
                        principalColumn: "user_id");
                });

            migrationBuilder.UpdateData(
                table: "Availability",
                keyColumn: "availability_id",
                keyValue: "165a619b-6704-9577-6d05-311a0aed3321",
                column: "availability_group_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "Availability",
                keyColumn: "availability_id",
                keyValue: "44f1596b-900a-6743-2e95-a4e877064b0c",
                column: "availability_group_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 55, 550, DateTimeKind.Utc).AddTicks(5041), "$2b$12$q6AxPuBCyodo1WECOHAwnesv3IDYAzz0acaI.88LU9NS8YHlM24.2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 59, 41, DateTimeKind.Utc).AddTicks(9326), "$2b$12$S4dtuZDrgU1Mp1Rng81sW.W/8L7p5xAR4DuD4MVjNJ2OwqBVktpMu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 32, 2, 933, DateTimeKind.Utc).AddTicks(4789), "$2b$12$HD.Q7LF9YOCpvYjMI3XlLOskJiYTiY6Pbt/AJSpHdGXLWKrA7l5.S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 51, 384, DateTimeKind.Utc).AddTicks(5269), "$2b$12$gteLAvJiiVNUOoCSbko8xeLhh4lTj7mRd38OpgSX2JQKX9ZmTTLWm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 54, 157, DateTimeKind.Utc).AddTicks(1178), "$2b$12$zb2.4jiGbTqHrHZ9Q41PeeCEzlozfzwJ2tX69.ThJu4r0Fkj542W2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 32, 1, 881, DateTimeKind.Utc).AddTicks(7581), "$2b$12$jmZV74rXbRy8fXfMYqeNiOQo/OaldrB84yLdAikO.zCEp5SVPEpw." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 49, 910, DateTimeKind.Utc).AddTicks(7662), "$2b$12$uY4G/LkbIbIeI4SZM/deguImX7C4qDcLjnUZ2voLJAuFGjLHkzqR2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 53, 814, DateTimeKind.Utc).AddTicks(8613), "$2b$12$Uw4//DXf6zWhHf1RQfiETeZmDeauTMYtHCFeEdqMQaIuuVhTQGeXC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 50, 301, DateTimeKind.Utc).AddTicks(2868), "$2b$12$dUMH3ZtuTWBQOa.YIaDvaOusJAVafi.O6grIrUx/kONSMLkFTv/4u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 50, 675, DateTimeKind.Utc).AddTicks(3299), "$2b$12$h5X9qMCAtRaDSNzYAlohnu4FhDsFvpI.m9W1eOsI8gw523ednf9da" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 52, 62, DateTimeKind.Utc).AddTicks(9463), "$2b$12$Jh2Rx9mGVuFVWu/2eq9vgu7GWb9JAY00FUNQ9X.0v5t.skNYaeI9a" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 55, 203, DateTimeKind.Utc).AddTicks(2478), "$2b$12$xcsvin5KT5GoT4rhVECHtuDZoyO3SKzbiwGxWQqImpS1VWlqa8vT2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 32, 0, 454, DateTimeKind.Utc).AddTicks(2939), "$2b$12$2zctEFqmsgB/19Fss3otIu8qhTLQDQGTDd48ftD3R6Vjqa8mv0mLm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 32, 2, 584, DateTimeKind.Utc).AddTicks(5898), "$2b$12$2JlTChDWUfl3Hd26fOXbUedXsbr/dkdCQt3RhoqoGLXePc6RJkHIy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 32, 1, 538, DateTimeKind.Utc).AddTicks(4557), "$2b$12$PaXwmRlKga7iy17teN/kGOJQJ3hkW7HFeGa9Z2wwYKp4UA21CI/C." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 57, 646, DateTimeKind.Utc).AddTicks(7945), "$2b$12$t2lRA0u0TT7gcq3fa.4ZL.S5Y3aLiT0eI5f7M.3yfO/o9Ibrtbjqy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 58, 333, DateTimeKind.Utc).AddTicks(8166), "$2b$12$EssMzIfM0PwRiec8haUbl.fsohjVdUI8t8syj0MRwt/KVvCEuH2zW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 57, 992, DateTimeKind.Utc).AddTicks(1021), "$2b$12$MJuCRjFl2H1cDvdVN/QLeuPeZ5OVbzG0Rv.Plh7GLeuTN3751/i6K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 56, 599, DateTimeKind.Utc).AddTicks(7711), "$2b$12$UL/Vc6Pk9apY6B8S0A87qeTeavCp3kIQtqXBeyZNvXHXSeyNbMRgW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 32, 0, 837, DateTimeKind.Utc).AddTicks(3796), "$2b$12$Uu1Xjg3zilZ5YbMfolgByO792uANq./ATelZwN4F2stkfEaSJ2k9O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 56, 946, DateTimeKind.Utc).AddTicks(4210), "$2b$12$GADyVVHhuNXRphlAtwIOYOgsFl54HUq9OVeo2jndyRwPj9w5LwQua" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 59, 400, DateTimeKind.Utc).AddTicks(1578), "$2b$12$daWK2sg9BfVQ2hFva60Q9Oz2QHrOK6ecxDjetjPVpIivpQhTQZTue" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 32, 1, 180, DateTimeKind.Utc).AddTicks(170), "$2b$12$tdO5ywyOnjOb1jnT8GR9RuodnpM4FNcuQZTVmUsS3Ku3ierFRB/jy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 54, 854, DateTimeKind.Utc).AddTicks(1781), "$2b$12$0xVm8FOWegEmWqHQvI.7rOfIcrGgCDvrR/XAdWsH54ef1foILCkL6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 52, 415, DateTimeKind.Utc).AddTicks(3556), "$2b$12$mbNNB8WtrmDu8vOc4glzCead4u3K4YnEAnNGF2omWXDaRxpuCidI6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 54, 511, DateTimeKind.Utc).AddTicks(8978), "$2b$12$5augP0rKvZ0ek.WJudEpiORpg5YPOIDElKpOgGbnYHJ4WqHfeqPa6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 53, 463, DateTimeKind.Utc).AddTicks(2475), "$2b$12$wgmGiIF6Uy2dM3NAHsNbu.IHpNaApBfqGWEgtdcFtsDhdWIf1lVla" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 32, 2, 235, DateTimeKind.Utc).AddTicks(8174), "$2b$12$WAFlGpmAV.OoBqiZoiX.we0.5jKWEFhLOl2Ftze2e23NrKugIil/e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 51, 732, DateTimeKind.Utc).AddTicks(28), "$2b$12$WC/pD2OQ/w1KLTnod2nsCeDnCClYZkkiQwapRGdYS05dU9cfp2lEm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 55, 890, DateTimeKind.Utc).AddTicks(5744), "$2b$12$9tT1Qo9inM4WzfOVm3c0R.cEbTMiaPygTJYgf3bIyeegKBULH0oSG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 57, 304, DateTimeKind.Utc).AddTicks(2635), "$2b$12$9u/ARRc002r/fDj0fl4lZeAwtjL/RDdoIpXwiIBlIUYjMTw5XbaL." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 59, 750, DateTimeKind.Utc).AddTicks(2624), "$2b$12$dQMkoidsXt62nUuXH/diuuAVzLNKqha6JnsBYFOrJijGsCcMTxth." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 32, 0, 102, DateTimeKind.Utc).AddTicks(3749), "$2b$12$pXetTSmsUlCftBbu7CLisuAkMVbhYSdh5uP48cQvAxbwI.HcAm10i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 58, 692, DateTimeKind.Utc).AddTicks(9352), "$2b$12$COI1ukR8lKNSEYytQ4XGJut9Zg0J1iHLIqNsSaaoHHV/ZkaEVQkbi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 56, 231, DateTimeKind.Utc).AddTicks(7350), "$2b$12$olpx92XbFUcmWGHzIfGrp.ik5kw75fMi9szUKmS4aVrN/ocmMKeQy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 53, 121, DateTimeKind.Utc).AddTicks(3353), "$2b$12$3Zu5XwvWrUDq.GotDU84FepXA23CykMmKInXLIi2mb/vrOd3f2QaG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 52, 764, DateTimeKind.Utc).AddTicks(9003), "$2b$12$vutKp06EOeAnRi/pdhDdCumZrlLNd9kdB9P6Tm2/c.EUByZcxQnYa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 9, 1, 31, 51, 26, DateTimeKind.Utc).AddTicks(3201), "$2b$12$kQaO8L4qDHNDIq3SQpaVpuqiGGU3jXl0lCWihj418P9/jLlputg7." });

            migrationBuilder.CreateIndex(
                name: "IX_Availability_availability_group_id",
                table: "Availability",
                column: "availability_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_AvailabilityGroup_teacher_id",
                table: "AvailabilityGroup",
                column: "teacher_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Avail_AvailabilityGroup",
                table: "Availability",
                column: "availability_group_id",
                principalTable: "AvailabilityGroup",
                principalColumn: "availability_group_id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avail_AvailabilityGroup",
                table: "Availability");

            migrationBuilder.DropTable(
                name: "AvailabilityGroup");

            migrationBuilder.DropIndex(
                name: "IX_Availability_availability_group_id",
                table: "Availability");

            migrationBuilder.DropColumn(
                name: "availability_group_id",
                table: "Availability");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 37, 603, DateTimeKind.Utc).AddTicks(9419), "$2b$12$w7zm9akzss3y.mZg0iylweFrCoo4IKJDuso3c/aJyghH8e79e3C2S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 40, 581, DateTimeKind.Utc).AddTicks(8693), "$2b$12$EdUXunn4eZKoA9Sq5/pzoudKWvUCVnEmjY8OGsqiqxx891rL4DLUm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 43, 850, DateTimeKind.Utc).AddTicks(108), "$2b$12$lcm49vlkedNNPJFmIjei5uSYQPx1HxU.kh24yi/UGEkKMmnCpL/Ru" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 33, 931, DateTimeKind.Utc).AddTicks(8571), "$2b$12$YEgoprooW2CT7IzS2uO2HOPOTS/J4qOyPqcsAUs3RhaLE5mSIe3E." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 36, 412, DateTimeKind.Utc).AddTicks(8517), "$2b$12$sv9IFV7t95lAHk6uERAMoOULbQIlciEy5GZ3OH2UUm6Idve6JsO1O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 42, 964, DateTimeKind.Utc).AddTicks(202), "$2b$12$cNEMuQUEP9E9s/R.xXSVe.2HO4SAa4d2XGFywxkqolfk/P0VqSk0C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 32, 637, DateTimeKind.Utc).AddTicks(9685), "$2b$12$Fax2rjUgggIKuEW3RsF6xuK/gj/yfDE9FVxGfU/4Qt4NeDaQaE/FS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 36, 109, DateTimeKind.Utc).AddTicks(6112), "$2b$12$TYSd89QVNwNDchTpbiwA/uZisHcTrw4pOF7mfEgO6gYqoNpVlEXzS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 32, 983, DateTimeKind.Utc).AddTicks(3637), "$2b$12$/HdNOe4aldp5WmvQVPWOSub7A0/n2NAXdx4rHfAqQ2k1mIderA.L2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 33, 312, DateTimeKind.Utc).AddTicks(9159), "$2b$12$sITpASa9/SEbkqttyTP2e.LE5ORy7IrtrsVZtC6d97N/QyjFxFvpy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 34, 542, DateTimeKind.Utc).AddTicks(4947), "$2b$12$s5SlG1cOtHuxo9flV4RBXOBS4lM9tSOYE4tCiKgWxBaz0RovlXRfe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 37, 307, DateTimeKind.Utc).AddTicks(5828), "$2b$12$VB6b.mm1dj95XfiVo0QPM.Zrtuy2F0UQ17rv45QBCVV2dr8xsQ4Bi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 41, 772, DateTimeKind.Utc).AddTicks(9109), "$2b$12$rsfbaLnofQDwQzz029d4cOJ3ogiSaKSEj7B7YsMj6Hf39XC.prZim" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 43, 554, DateTimeKind.Utc).AddTicks(1782), "$2b$12$ckDn6hItM4Pq4gpwGCWXvuzQAFmGXlKEQ06WxrlA.uqwLhjVnRuku" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 42, 668, DateTimeKind.Utc).AddTicks(8780), "$2b$12$6cOHq51svhikpQzF9GnIg.rvzw9WlHOafbvJMlQGZYBqzlcSaZbNS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 39, 398, DateTimeKind.Utc).AddTicks(3955), "$2b$12$U4Bj759H4cZGSgnZ2USj9./aTEb14qSNM.uY9rAeUyCWQOGuFjBw." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 39, 990, DateTimeKind.Utc).AddTicks(7686), "$2b$12$ACbu9Qwzm4aEz0OjLdB72.ZcWTtopSU8c0yMWeEovEum5FxLA3XfW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 39, 694, DateTimeKind.Utc).AddTicks(9481), "$2b$12$mjbdpQe1vRyS.6VwsnwTjevVDN4OqP/W3XmBZlxmUj76VpmKveuai" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 38, 502, DateTimeKind.Utc).AddTicks(9040), "$2b$12$499V5.yz.7jt2rdzxV4yNOdk83hR0CQ9n8Y0EuAkYVdxyfK8gvDqK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 42, 76, DateTimeKind.Utc).AddTicks(9787), "$2b$12$gXputWw9fNLwBinfWIyXTeNWNllACy2lrMYU.kbGCKjd5sGl0E936" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 38, 803, DateTimeKind.Utc).AddTicks(5327), "$2b$12$13mY0cxwJi/HnXtNqXm2JuuhVK1KK5lmCOqkwPaKZ5/T8NhptMq5G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 40, 877, DateTimeKind.Utc).AddTicks(8479), "$2b$12$2UpEK6rTce0lzZSOvve90OEhTYvNb1qDgPGDHQEwBqtG2PlYC15HC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 42, 374, DateTimeKind.Utc).AddTicks(736), "$2b$12$6IeaDla.AvODAWj115DzoujkJYUZrp3wVequUls3IfhdybPLQnCEm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 37, 11, DateTimeKind.Utc).AddTicks(725), "$2b$12$yywEc2k9f4kFisgrF7M.ie5XWrc7DsfuV1umrEm0P3Wz8ZQHZbvvC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 34, 845, DateTimeKind.Utc).AddTicks(7282), "$2b$12$ZWppWXotYdvTBIWGmqzUEOfQyL0Q9hZfA7uQ1zEG8HVNO/qaywlXW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 36, 709, DateTimeKind.Utc).AddTicks(4919), "$2b$12$DVyYBkHa47g.Z0h/XWji2OfY2vDcHuD96fpBORTvTvEb7Qwxg/Tt." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 35, 801, DateTimeKind.Utc).AddTicks(9140), "$2b$12$/.hbdANLA76ZpCF3IHmjuucCGT.D/JHTRZuKkgsh.e03Uz6W6e7Ym" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 43, 259, DateTimeKind.Utc).AddTicks(7937), "$2b$12$fQnll/lghWz4ZfyeI/4...IdvQGVJXEZy5MIg.hjDnJjrSGoUMFAi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 34, 236, DateTimeKind.Utc).AddTicks(9354), "$2b$12$TGLfWg14oTliIO4i/VabHeP4A/2U5BrRvryoUmbdhGiAOcVI3z5u2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 37, 904, DateTimeKind.Utc).AddTicks(7054), "$2b$12$gettteKQZ9QZIeruHlJFCuvTYlIgFnS025SAFvDTb9hiuxCFPMfIa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 39, 101, DateTimeKind.Utc).AddTicks(8076), "$2b$12$/hHJhQCVoEfA.e1/.OL25uXcYW/i7vdoP3rmOp.jBSVHOe/N4x99i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 41, 181, DateTimeKind.Utc).AddTicks(1790), "$2b$12$S3M4GAu4XSEYxwEqdyeysedG9Hr/bWol9fv4FPlCpyUF9VHjkUFz." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 41, 476, DateTimeKind.Utc).AddTicks(6637), "$2b$12$CW43qFBjD2g082cnHbvtQ.8Aj3Zz3UI4q77QLBP/p.wJ7msJRjloG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 40, 286, DateTimeKind.Utc).AddTicks(4899), "$2b$12$rJoCb2uunwfxwxSj2.C/xeA4ImQSb5CO5CpPTU5Mso3AlO9scnqjC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 38, 202, DateTimeKind.Utc).AddTicks(3310), "$2b$12$nbF7D43SCNEBhblR0D4Vlu5HekacvZ.C6iSqT5LBUgj56tljifRse" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 35, 464, DateTimeKind.Utc).AddTicks(5706), "$2b$12$MpYfdCKqBqe9iOluchZBOu4Zgeq1CIPxxd.DgQUm2siRHO3Kc2jvy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 35, 150, DateTimeKind.Utc).AddTicks(8304), "$2b$12$hYXYTnKSrxaEMR.0V4q4de2Bi8YuUSfAVZT7GRo3Tx5.fTUnWiD0u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 33, 621, DateTimeKind.Utc).AddTicks(1336), "$2b$12$2d4k85iXxnmjjyH7aSUrqObuFP3jnx.jxnRMCs4519Ok1nHHxDWCG" });
        }
    }
}
