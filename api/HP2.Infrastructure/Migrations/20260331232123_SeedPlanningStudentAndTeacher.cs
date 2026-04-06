using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedPlanningStudentAndTeacher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f",
                column: "date",
                value: new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 12, 238, DateTimeKind.Utc).AddTicks(163), "$2b$12$B3voQFZJZOTHCUX8LJ7Ww.W.0NJ1SA8nUNHbcxncWBM/z4w1zNJbm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 12, 567, DateTimeKind.Utc).AddTicks(2760), "$2b$12$CXHRfcXy68hL0FYs09lZy.Ms6bD0zz1kpcj/vMiVY3sPqhI9VA1zq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 3, 31, 23, 21, 14, 457, DateTimeKind.Utc).AddTicks(2514), "$2b$12$uHeMsxGxLOnxbgKA7JchX.XX3d4lcWkHDHccS7wn/DvnyNSWusrwu" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "user_id", "created_at", "email", "first_name", "last_name", "password", "phone_number", "UpdatedAt", "user_role_id" },
                values: new object[,]
                {
                    { "09095bf3-fa8c-0e49-eecb-f4bf320842ea", new DateTime(2026, 3, 31, 23, 21, 17, 216, DateTimeKind.Utc).AddTicks(9614), "jules.laurent09@etud.fr", "Jules", "Laurent", "$2b$12$wiU.z.oypUKkARKUAopZxOPwr5DWm3urBJ962Y1AXtnjn2CtvEGaa", "0610000009", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "11819a20-b220-4acf-fee3-7294e4971100", new DateTime(2026, 3, 31, 23, 21, 20, 263, DateTimeKind.Utc).AddTicks(5644), "raphael.francois19@etud.fr", "Raphael", "Francois", "$2b$12$JxBvr1e5xoUzl9etc97OVu/2nXmgq5QTVkExvDB9bSbPsOmqAgHRS", "0610000019", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "13aacf42-836e-5f88-2ccd-f93c81b68f7d", new DateTime(2026, 3, 31, 23, 21, 23, 672, DateTimeKind.Utc).AddTicks(1181), "alice.perrot30@etud.fr", "Alice", "Perrot", "$2b$12$KsLFbEIgiJ8hMhTVBQiCUOQHFEHnoRCgmlDXojt4bwq1KU4wJQdjW", "0610000030", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "14185a87-c07d-c0db-e37b-536e871528f2", new DateTime(2026, 3, 31, 23, 21, 13, 508, DateTimeKind.Utc).AddTicks(589), "karim.benali@univ.fr", "Karim", "Benali", "$2b$12$xu1uphKL1emXzRqHGMEb6eXT.hPZGpIsT.PCVRhPxZyti2PnMHJbC", "0134567892", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "15f55f4b-c16e-2fc7-26dc-5d0d607d1778", new DateTime(2026, 3, 31, 23, 21, 15, 988, DateTimeKind.Utc).AddTicks(9532), "nathan.richard05@etud.fr", "Nathan", "Richard", "$2b$12$YKsspBsgl./NBD9B6kKnR./DixECbBTiSlWBDdEP4WOtPKf7Nu2uO", "0610000005", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "32573a03-d414-5891-15fe-b991e1f6d0a7", new DateTime(2026, 3, 31, 23, 21, 22, 763, DateTimeKind.Utc).AddTicks(3791), "rayan.gautier27@etud.fr", "Rayan", "Gautier", "$2b$12$1VOe2kmNa8TYVkJ6rWDKX.zoBHYJwrqF9BMiY1S65jX5zHYsEuyjK", "0610000027", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "3fca4239-b5f4-f163-c65c-8d835f1a0154", new DateTime(2026, 3, 31, 23, 21, 15, 680, DateTimeKind.Utc).AddTicks(9547), "chloe.robert04@etud.fr", "Chloe", "Robert", "$2b$12$CsbqLAvGj1ZPHxgCCEmoxuetnoskARblr/7dj47bDc08Z5zfOSh2y", "0610000004", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31", new DateTime(2026, 3, 31, 23, 21, 12, 889, DateTimeKind.Utc).AddTicks(5408), "alain.durand@univ.fr", "Alain", "Durand", "$2b$12$e0s.mcNRGesUfymK0g2kf.Pm5trcoJ/X3if5FUUEuqsCJUGG2Wa2G", "0134567890", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "63d58b13-c957-6ee8-4ed6-303e20d09973", new DateTime(2026, 3, 31, 23, 21, 14, 123, DateTimeKind.Utc).AddTicks(3996), "thomas.renault@univ.fr", "Thomas", "Renault", "$2b$12$hVGwxEG6k/qMMD4vGCTzrehBtIhs63Nsbx/ByngvTN/LTu9dshtO2", "0134567894", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11", new DateTime(2026, 3, 31, 23, 21, 16, 905, DateTimeKind.Utc).AddTicks(5511), "ines.moreau08@etud.fr", "Ines", "Moreau", "$2b$12$OaH61znkePpgy9D3Eh3CmOhWWE7MUc23DoAw3.syZCtI9hEf65ymu", "0610000008", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7", new DateTime(2026, 3, 31, 23, 21, 21, 527, DateTimeKind.Utc).AddTicks(1989), "sami.perez23@etud.fr", "Sami", "Perez", "$2b$12$Y0JzsvnQbWlD41MyTckZ3O04f9aILLVk6eAKzzSPOeaeyr2Be9knm", "0610000023", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "77eb8c7e-d27b-ca0d-7b40-66def436466b", new DateTime(2026, 3, 31, 23, 21, 23, 368, DateTimeKind.Utc).AddTicks(4269), "elias.giraud29@etud.fr", "Elias", "Giraud", "$2b$12$YiHYzEdplQksnGCUw454kODWlBUJ.WSdgMCGmqHYbIQnSn/PTr6ze", "0610000029", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "8c6614ce-430a-30a5-a877-fc157f5b7ad7", new DateTime(2026, 3, 31, 23, 21, 22, 456, DateTimeKind.Utc).AddTicks(6622), "laura.renault26@etud.fr", "Laura", "Renault", "$2b$12$vkLxql69N76zzHQg7aVpdO7DdxFBqFdL8wJo9S7KwG67h/t9uDD1.", "0610000026", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "8d936d9f-0ae5-8334-3197-ce641e6873bb", new DateTime(2026, 3, 31, 23, 21, 19, 54, DateTimeKind.Utc).AddTicks(5210), "adam.david15@etud.fr", "Adam", "David", "$2b$12$XwgOInFZKCdBiFHDDFJ0Ium2Bfs6nagepE7sljY9O07pwWYm/Cb.O", "0610000015", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "985474c8-8b56-e296-730f-d011dd6d63ad", new DateTime(2026, 3, 31, 23, 21, 19, 658, DateTimeKind.Utc).AddTicks(3133), "noe.thomas17@etud.fr", "Noe", "Thomas", "$2b$12$Pig6cM8jNryhvVcltqCAbeB6dzX91uPvWqjQA.aD/3HmK37z5air2", "0610000017", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787", new DateTime(2026, 3, 31, 23, 21, 19, 356, DateTimeKind.Utc).AddTicks(2927), "zoe.bertrand16@etud.fr", "Zoe", "Bertrand", "$2b$12$f.Szd/9kboZiy945b7tveOJyAgalLa/2XHcYSRZW1YFxWig.EQXLm", "0610000016", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "9f33ca92-97a2-351d-cf5a-e9841c28e7f7", new DateTime(2026, 3, 31, 23, 21, 18, 141, DateTimeKind.Utc).AddTicks(4973), "manon.garcia12@etud.fr", "Manon", "Garcia", "$2b$12$PI0QoJWYYJXNfp/JqNdv8uevOke.RyX8rIuPzJYHbkcViAUhB4Wjm", "0610000012", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "a1e5a516-c159-675d-0f0d-96289cd47e35", new DateTime(2026, 3, 31, 23, 21, 21, 845, DateTimeKind.Utc).AddTicks(751), "clara.denis24@etud.fr", "Clara", "Denis", "$2b$12$VrDJyaQcCQJjJhSBYerVUuLwYzCATFN3fIuUXIH9gAqf9SKbr9yam", "0610000024", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f", new DateTime(2026, 3, 31, 23, 21, 18, 447, DateTimeKind.Utc).AddTicks(3121), "gabriel.leroy13@etud.fr", "Gabriel", "Leroy", "$2b$12$XA8tIP.HKA6ifpDnP/6hMO2q18zmkNhpJ63atwFCj97v.yymhGTde", "0610000013", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "a5e38765-a824-e761-1cfd-a76a2136091c", new DateTime(2026, 3, 31, 23, 21, 20, 567, DateTimeKind.Utc).AddTicks(6118), "yasmine.faure20@etud.fr", "Yasmine", "Faure", "$2b$12$RS4TIEXFTMv.U5BQC.ris.jvtvTPbirUg2/KAT7Xie6WhH2wF71ky", "0610000020", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "b008fcd4-f3ad-f24d-91a7-c16be33fe62b", new DateTime(2026, 3, 31, 23, 21, 22, 150, DateTimeKind.Utc).AddTicks(3386), "yanis.colin25@etud.fr", "Yanis", "Colin", "$2b$12$zPFLGtNrn9ljvJxQc0MMceyZGI4fllWlUx/k/l8telhbLU7Qi5yHC", "0610000025", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "b11e5b82-12d0-5a31-1105-780499cbfc20", new DateTime(2026, 3, 31, 23, 21, 16, 605, DateTimeKind.Utc).AddTicks(3163), "arthur.dubois07@etud.fr", "Arthur", "Dubois", "$2b$12$88ZzPB6STqrqTeu5qMSniO7BZbh8eEgBSj/V2erUIMcOLO7Gh8NhO", "0610000007", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3", new DateTime(2026, 3, 31, 23, 21, 16, 302, DateTimeKind.Utc).AddTicks(6532), "lea.durand06@etud.fr", "Lea", "Durand", "$2b$12$gaX5wDpMRu1v8DsHwMf/XOAa1n/6qbX3LOY.Jyl65uNKtTCJQ2zuO", "0610000006", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "c67f2f50-8142-b095-ad35-e91badccbc00", new DateTime(2026, 3, 31, 23, 21, 15, 376, DateTimeKind.Utc).AddTicks(8454), "hugo.petit03@etud.fr", "Hugo", "Petit", "$2b$12$fK/bwY88dT8g/aw8RVEWtOvq/wy7Owu5wJ/xWlpcz3eKgJrXV8Odq", "0610000003", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "cafb714b-44d5-a183-e909-da93f4a926c8", new DateTime(2026, 3, 31, 23, 21, 23, 66, DateTimeKind.Utc).AddTicks(3741), "nina.blanchard28@etud.fr", "Nina", "Blanchard", "$2b$12$E136fv9L18yZ6P7UcH.kO.qcnTi7i6Jv7hYE7rKlW7rKfxWoPWcK2", "0610000028", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "d6b75c65-0e4e-21d2-1215-b541eb0ebef5", new DateTime(2026, 3, 31, 23, 21, 13, 813, DateTimeKind.Utc).AddTicks(3754), "claire.morel@univ.fr", "Claire", "Morel", "$2b$12$a6p5WEkoFDEPcHJITGQ4COH9gd91CyvnBitq1Scda4lZ1z1vwQedW", "0134567893", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "d8ba01ab-6a2c-951c-02c4-d6a0150808a3", new DateTime(2026, 3, 31, 23, 21, 17, 526, DateTimeKind.Utc).AddTicks(2025), "sarah.simon10@etud.fr", "Sarah", "Simon", "$2b$12$VmVcGtE0KXxgDYEOvWoMYe9ByDEqVRRrk9GALbCy811mRhgYBdX12", "0610000010", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "dd0b032a-0b32-dfa0-1dbe-c55b3db45489", new DateTime(2026, 3, 31, 23, 21, 18, 746, DateTimeKind.Utc).AddTicks(6261), "camille.roux14@etud.fr", "Camille", "Roux", "$2b$12$8GeRobtuo7e3Qk9jePfHY.GpX0E/3E89H.AkIH1Gcz7G7gpw76Tn6", "0610000014", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "e115db87-7553-5590-e81c-cf366ee4dc30", new DateTime(2026, 3, 31, 23, 21, 20, 873, DateTimeKind.Utc).AddTicks(7558), "theo.andre21@etud.fr", "Theo", "Andre", "$2b$12$ntbmE7D7rjTrJnXoDyctj.KGPayQKr6JFu421TIvG2.5UhPVo2ioS", "0610000021", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7", new DateTime(2026, 3, 31, 23, 21, 21, 182, DateTimeKind.Utc).AddTicks(3800), "jade.noel22@etud.fr", "Jade", "Noel", "$2b$12$gisf6eB0c2yUId7T7K796uNXCRZKE3B2U6CTzuoDrKMXkoVpjvJ7G", "0610000022", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "e894b918-a541-2628-3bcd-376cf02e4986", new DateTime(2026, 3, 31, 23, 21, 19, 955, DateTimeKind.Utc).AddTicks(955), "lina.bonnet18@etud.fr", "Lina", "Bonnet", "$2b$12$yiA70a5eZSlyqOWumR0Vse8bQdy4k/vuwy9LEWlpidWkeLpQN1nI.", "0610000018", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "e9e3bb79-3eab-df5e-de27-f8914cef210a", new DateTime(2026, 3, 31, 23, 21, 17, 837, DateTimeKind.Utc).AddTicks(9324), "louis.michel11@etud.fr", "Louis", "Michel", "$2b$12$4dSwzSsUoaPrvgW9y71x4u6awbVxfE9Wi15G0G.4tpCnPyHGrnL46", "0610000011", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85", new DateTime(2026, 3, 31, 23, 21, 15, 66, DateTimeKind.Utc).AddTicks(3834), "emma.bernard02@etud.fr", "Emma", "Bernard", "$2b$12$yeGzhnXvgacjpD88t0./Tej7p4OhdDLbULEON6.Ku0OXZP.mg5A3K", "0610000002", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "fd2b34ab-7283-eff1-ce41-b75fe87946b9", new DateTime(2026, 3, 31, 23, 21, 14, 763, DateTimeKind.Utc).AddTicks(8157), "lucas.martin01@etud.fr", "Lucas", "Martin", "$2b$12$53yLTRijXgmpu4GljOt68.JxOUH1gPMay6.3VZxXuDVLFhCHH7u4m", "0610000001", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eca46e4-1e66-8343-3f88-c667fd48550e" },
                    { "ff7eb421-56b5-3bbe-779c-355ceed7246b", new DateTime(2026, 3, 31, 23, 21, 13, 194, DateTimeKind.Utc).AddTicks(6677), "sophie.lambert@univ.fr", "Sophie", "Lambert", "$2b$12$hOT7I2RDRq4H4qtX28oVg.9YR.cDtig2QzLivjDy41/OkfekWYI2a", "0134567891", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "user_id", "group_id" },
                values: new object[,]
                {
                    { "09095bf3-fa8c-0e49-eecb-f4bf320842ea", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "11819a20-b220-4acf-fee3-7294e4971100", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "13aacf42-836e-5f88-2ccd-f93c81b68f7d", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "15f55f4b-c16e-2fc7-26dc-5d0d607d1778", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "32573a03-d414-5891-15fe-b991e1f6d0a7", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "3fca4239-b5f4-f163-c65c-8d835f1a0154", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "77eb8c7e-d27b-ca0d-7b40-66def436466b", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "8c6614ce-430a-30a5-a877-fc157f5b7ad7", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "8d936d9f-0ae5-8334-3197-ce641e6873bb", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "985474c8-8b56-e296-730f-d011dd6d63ad", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "9f33ca92-97a2-351d-cf5a-e9841c28e7f7", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "a1e5a516-c159-675d-0f0d-96289cd47e35", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "a5e38765-a824-e761-1cfd-a76a2136091c", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "b008fcd4-f3ad-f24d-91a7-c16be33fe62b", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "b11e5b82-12d0-5a31-1105-780499cbfc20", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "c67f2f50-8142-b095-ad35-e91badccbc00", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "cafb714b-44d5-a183-e909-da93f4a926c8", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "d8ba01ab-6a2c-951c-02c4-d6a0150808a3", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "dd0b032a-0b32-dfa0-1dbe-c55b3db45489", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "e115db87-7553-5590-e81c-cf366ee4dc30", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "e894b918-a541-2628-3bcd-376cf02e4986", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "e9e3bb79-3eab-df5e-de27-f8914cef210a", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85", "57bf1149-8880-c27c-d603-3546214d03a8" },
                    { "fd2b34ab-7283-eff1-ce41-b75fe87946b9", "57bf1149-8880-c27c-d603-3546214d03a8" }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "user_id", "registration_number", "teacher_title_id" },
                values: new object[,]
                {
                    { "14185a87-c07d-c0db-e37b-536e871528f2", "REG_004", "025afe74-4e45-ca60-93e0-035aa84f648d" },
                    { "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31", "REG_002", "025afe74-4e45-ca60-93e0-035aa84f648d" },
                    { "63d58b13-c957-6ee8-4ed6-303e20d09973", "REG_006", "025afe74-4e45-ca60-93e0-035aa84f648d" },
                    { "d6b75c65-0e4e-21d2-1215-b541eb0ebef5", "REG_005", "025afe74-4e45-ca60-93e0-035aa84f648d" },
                    { "ff7eb421-56b5-3bbe-779c-355ceed7246b", "REG_003", "025afe74-4e45-ca60-93e0-035aa84f648d" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f",
                column: "date",
                value: new DateTime(2026, 3, 2, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 2, 23, 13, 14, 57, 76, DateTimeKind.Utc).AddTicks(6986), "$2b$12$RnmWIN1BGxHRaUGOy1nE3eFDeIcxygIgm.eQwy2Fwq54HKtSeK0zS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 2, 23, 13, 14, 57, 374, DateTimeKind.Utc).AddTicks(4987), "$2b$12$CQ4XOgBc7EolHGCDXBUsEeKoWcIrIYy8Ha1nw9KEZgUZGoSnre17m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 2, 23, 13, 14, 57, 669, DateTimeKind.Utc).AddTicks(6272), "$2b$12$q4xHD3m9.kzlCSkueUnpeuzsODntgdhlteX5NxJ4ZZl9hzjchL/yC" });
        }
    }
}
