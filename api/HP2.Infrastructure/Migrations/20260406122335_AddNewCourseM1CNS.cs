using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNewCourseM1CNS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assign",
                columns: new[] { "course_id", "track_id", "hourly_volume" },
                values: new object[,]
                {
                    { "014c457e-a48a-d25e-7781-d5e483cb3dd9", "900f1499-bb04-690c-9394-eeafda3848a4", 36 },
                    { "03241339-1186-a90f-33bd-a9850f603619", "900f1499-bb04-690c-9394-eeafda3848a4", 18 },
                    { "24027d5d-e151-9a00-fd19-ac11d27b8189", "900f1499-bb04-690c-9394-eeafda3848a4", 36 },
                    { "2d4557a7-a48d-9926-3e2b-bc820396b11a", "900f1499-bb04-690c-9394-eeafda3848a4", 36 },
                    { "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", "900f1499-bb04-690c-9394-eeafda3848a4", 36 },
                    { "3b835d91-4f08-07ef-d4d5-575947097601", "900f1499-bb04-690c-9394-eeafda3848a4", 36 },
                    { "49ba4385-063d-7b8d-5f3f-aa1c7f573747", "900f1499-bb04-690c-9394-eeafda3848a4", 36 },
                    { "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", "900f1499-bb04-690c-9394-eeafda3848a4", 18 },
                    { "d059db13-ac91-760c-5bf7-6c442946e7bf", "900f1499-bb04-690c-9394-eeafda3848a4", 36 },
                    { "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", "900f1499-bb04-690c-9394-eeafda3848a4", 20 }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "course_id", "code", "name" },
                values: new object[,]
                {
                    { "2af630c1-de0d-944f-0b87-a73f1c90644f", "CNS_INFOCOM", "Information et communication" },
                    { "3aed7e82-31b6-d05a-3f46-f2ef085d313e", "CNS_SPEC_VERIF", "Spécification et vérification formelles" },
                    { "c0452911-4948-9cb2-aed9-7b949c0b6442", "CNS_MULTI_AGENTS", "Modèles et méthodes pour les systèmes multi-agents" },
                    { "c3cd3947-214d-3130-b938-a5d19a0e8eaa", "CNS_MSED", "Modélisation des systèmes à événements discrets" },
                    { "cf512e7a-117b-71d0-a07f-43e743dad7eb", "CNS_ML", "Machine Learning" },
                    { "e9cbe024-5789-9dca-e8c8-418b70f033cb", "CNS_HPC_INTRO", "Introduction à l'informatique haute performance" },
                    { "fb30b659-6817-4099-e7cb-d7c254532603", "CNS_ALGO_ADV", "Algorithmique avancée" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "011f7dd9-fd3a-3d41-6190-1f4489c299e9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 31, 735, DateTimeKind.Utc).AddTicks(1144), "$2b$12$dOett./jZjU0fGM.nO4Ze.0SdQz10JNLI1Dwnurfoc8dRX93IhiI2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "03428ee8-3d9a-de72-c98b-dbc65724b005",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 21, 976, DateTimeKind.Utc).AddTicks(2485), "$2b$12$JfcKGM7U.auJUoC1sT/kBOCpZ6nvIrxuOgrWcM7YKOJEn5B.Mp2WS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 1, 847, DateTimeKind.Utc).AddTicks(9500), "$2b$12$VN.h6J8F8/9RXH1y8cjbTu/RN49fsv9U4BBRMDIPNhdEqW34FzZ66" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 8, 637, DateTimeKind.Utc).AddTicks(7940), "$2b$12$aUrqfcUM/LAmJeSSMVJTHumshXWJ0zVkqF1kRLpRxhxrv0V/MS3gy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0a3f73e7-67a8-750c-576a-49c22125bac7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 33, 290, DateTimeKind.Utc).AddTicks(2174), "$2b$12$6krsyy5Fzj1k/K39LQ2DMuRbs7spO2dhPPi5wzrlOJnH/TGrqpDT6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 57, 403, DateTimeKind.Utc).AddTicks(3692), "$2b$12$ehIU9dZbgFOLU.fmT0Dk5uQYLn6IZT6bKCjDHV2vVddb8L9WiMYcW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b48ba68-2d76-43aa-8392-7b40b1aa1e19",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 29, 860, DateTimeKind.Utc).AddTicks(8046), "$2b$12$TSUvJUsBvoOr5y20c7O3Pe.z0G3hihZP4iCrsY4FtbEahptPs3ONC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 11, 791, DateTimeKind.Utc).AddTicks(1272), "$2b$12$J0hONoOO6Ckd81eZOV0jaeOkUctKg.72wMpXyWyUw811FWRT1Luee" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "129452cc-6c9b-3726-5c96-54b67ac3b884",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 34, 273, DateTimeKind.Utc).AddTicks(3034), "$2b$12$Uzn3GWW5G5VlVBKkru8VMOGHd7aL4p49vGT5umnCEpRfWdBb526hq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 15, 300, DateTimeKind.Utc).AddTicks(9973), "$2b$12$qublyqFbB/wdCHSyir3S3.DMOYlBLaSLAQoagRJ7nn3QTt//eI33K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 58, 993, DateTimeKind.Utc).AddTicks(4970), "$2b$12$L/OXhnHyMzCBuzFuTSM3Suisil2lSMmzVyuA5bDU0n1jHs0o9hXJa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 19, 772, DateTimeKind.Utc).AddTicks(2737), "$2b$12$gqjf6eHPPo8nFVWXfr9pjus5gcuROWByPF2zmwdCAcf6NWJ.UOsq2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 7, 376, DateTimeKind.Utc).AddTicks(4997), "$2b$12$8R.Vz9t3nDIszNWNiXG7Tugfp7Y7awlXvb6WAvlVMRvdZSqCfo/Uq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "18241d26-a012-b189-957c-b5573ecb15d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 24, 216, DateTimeKind.Utc).AddTicks(5501), "$2b$12$v.O64l55iKczyWM6F5uRBOIS2TOOTLF/UIQifztMm3PnqJZu6anhi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 59, 944, DateTimeKind.Utc).AddTicks(194), "$2b$12$8GCXerJH8eOd4BBXNc7O2.8AI.GTkybyuqnfgYDFhgms/zpbVpxD6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 0, 576, DateTimeKind.Utc).AddTicks(5826), "$2b$12$UP4a47igidM09zAFgdoWXO9m5AAtsIs9WcLBOxgWtgNBiZUFRI0HS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "288bdacf-8acb-a8d1-59f9-94f0cccb2086",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 28, 227, DateTimeKind.Utc).AddTicks(6866), "$2b$12$MvuWzTDXNMyhgnmvbUNWsuqRmpWfEb/tfOlcWkLhkCZQtiEjBwhuS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2b5c3a92-dc35-b1bd-16c3-b0f8a21f29f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 25, 882, DateTimeKind.Utc).AddTicks(2144), "$2b$12$ThOo9Mrkk7GXSfEGbufpJuP8.8zY7NN6wlZwdYosOyMfhX..gqfni" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2fa22e35-4eb2-7351-ee0e-a523ac305c44",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 30, 481, DateTimeKind.Utc).AddTicks(5382), "$2b$12$ib8hyVEHZpcPcSM6JPs0pOou2s9PUmyRS4TLZivnxx/7N9aYheWre" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 14, 357, DateTimeKind.Utc).AddTicks(5796), "$2b$12$Kged9gZSk.hM39mCXLA5zuY7r0LI7GmnUFI1l1LCMIw/dlRvyxEa." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "373399d1-2bd2-aee5-629b-43f96da8f03e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 33, 919, DateTimeKind.Utc).AddTicks(8337), "$2b$12$eZa3Bq5DWLpHR1tajHI5cOzmHbD1BgcCI2cxwRlTgum5rVMVQyx5." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3769412b-799f-6b72-f74f-9b9b735058c2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 26, 917, DateTimeKind.Utc).AddTicks(6193), "$2b$12$5.em.fh0eVKdKNokhXNnvOeed.nMMidEa5K8.Mueucq9retvS4.Fi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3830d83f-4097-76e0-a9e0-b90ef45d1c79",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 24, 863, DateTimeKind.Utc).AddTicks(657), "$2b$12$l3uthPPhV1hE4wMKKeW05OXDiSAJXvZObd0.t50ZpJeppYSCMwbLe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 56, 419, DateTimeKind.Utc).AddTicks(3846), "$2b$12$YNWcQOYPfrb1sfl3BZCCWu7htvrWvgDEXTzcOsaQVGJ2Vln95YOoK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 7, 53, DateTimeKind.Utc).AddTicks(5590), "$2b$12$yMTDTXQU7x2c.JfyRTyi1uyd6cYndu/75gPgBFR.SobeaiXYaob12" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 58, 38, DateTimeKind.Utc).AddTicks(2959), "$2b$12$6ZLSU5V7R7D7JaC/HppIceViFPjTZsc84gqKSlXuvedzNnSVMO4LO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "476292a1-d3ae-cacd-a58c-2d14790da8eb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 31, 111, DateTimeKind.Utc).AddTicks(3518), "$2b$12$MUi9vZv6Tr3JQbGjj1LJ7OItwX8Xd.wher6uAPaDGtbYUL4mi76NC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 57, 720, DateTimeKind.Utc).AddTicks(3967), "$2b$12$5CUOXxtc9491CpKBGLb01OV4occkxHwib3gO8WAoDXYtdCKIWmf6m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4d41b3e5-536d-0aa0-a3e3-024218ac6267",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 18, 828, DateTimeKind.Utc).AddTicks(7168), "$2b$12$rXASeZruYpSnV3qH2Ah4yOtXHi.IsvaRUm9H2nK3.SqlgBAUVYe/y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "51432fb0-cda4-87aa-a2d2-e36c25823a2b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 20, 92, DateTimeKind.Utc).AddTicks(1848), "$2b$12$eRLSOHujueZKQNb9OdxvXuL84HBZ.ldWkBcwL09r9Gzl09wrRFFSC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "52fb0554-7e57-01bb-5949-987520c91eb5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 17, 882, DateTimeKind.Utc).AddTicks(71), "$2b$12$8SxjYSaLel86iSqzvpGKLOUUHwi8n1sl4mWvlW49rfw399PNhxPL." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "539ead07-d571-367b-79f7-68b21513886b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 29, 525, DateTimeKind.Utc).AddTicks(5480), "$2b$12$Y0cjV31UiDUrVjZaXGYR0OTWjkqeRkrxh.hR8MyMFLF5dK2bZG7mS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "557dd714-15d7-6df3-3ed1-22a2eec63c59",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 16, 570, DateTimeKind.Utc).AddTicks(4672), "$2b$12$wCa1nxKiNXYfOrFRfNeTU.xeqWcQvf.kh/6DzN1qgHj.TUtqc78ke" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "57f13355-ddb7-5d3c-b09a-ff2c56e22753",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 15, 616, DateTimeKind.Utc).AddTicks(4576), "$2b$12$tyYC9RQP/xpp7reWNXrt1.8CxwZhYXt7CkJGHRmlH.W36.xv0GBzG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 1, 208, DateTimeKind.Utc).AddTicks(6411), "$2b$12$7mVqqurXSCUclXv659As9uNNpa/yxAUSARhs.MZO.fOViNgLicDPW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 58, 353, DateTimeKind.Utc).AddTicks(2714), "$2b$12$eGdhAj.kOOGW0jePzWXcdOHaCiYp8YUh0iwh5.tBB3HhnBUyCZDd2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 2, 806, DateTimeKind.Utc).AddTicks(5166), "$2b$12$dAA2y5Hp/Di91Y8oSXx8UetUy/uZMwLHC/akO/5Mt75xdviHZPjZ6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "617cb820-a96f-5ce4-513e-f9de2ec06556",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 19, 456, DateTimeKind.Utc).AddTicks(8816), "$2b$12$Jx55x6/p/IS1PLMIecM82.RRcsbRbl30pkvcAsiTLGGLWaa78Iaay" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "62f48843-9c38-a162-72b9-af6d09b80de3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 30, 792, DateTimeKind.Utc).AddTicks(6837), "$2b$12$8nqF2eCaEW2HsDEkLN47m.BoX6j7nqXJOjHkIx8vTkEalA4t72.D." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 59, 636, DateTimeKind.Utc).AddTicks(1181), "$2b$12$Wydx1xCvPDFWAzkZ76fsZuXyfwOiml5VJ0jP2b.78MznmG5csUFGe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "65aa7c04-2529-20cc-46f7-47c22df3e1d0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 32, 351, DateTimeKind.Utc).AddTicks(4859), "$2b$12$80HpqclVagWeiqIW/z8AU.y3seXV3v7Vqo3uSKw8q1pC4CgpD2Jr6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "68fbd87f-0c94-976f-40de-323667ff06bf",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 22, 292, DateTimeKind.Utc).AddTicks(398), "$2b$12$dJ9tEBu3nOpZ6rolwYCp5OkDhROySm4l9IxOGKKcZjeAZYP9fcEEq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 8, 321, DateTimeKind.Utc).AddTicks(680), "$2b$12$b9w6Z741HCumVLbCCS.h2.x38sejnenY0z1ofuvPZFG7Dmqz7lF2i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 13, 42, DateTimeKind.Utc).AddTicks(8861), "$2b$12$E9I/oUEt7ePFlWoe.slG4.t3WbLVyyUzC54ig.Rl2o9vBhKivehDm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6dcd090f-508b-7888-b458-17aeea49123a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 33, 612, DateTimeKind.Utc).AddTicks(4859), "$2b$12$82wssYwQfo57x7pCxenkiupHoVKwpi3naoCSk6.GYQhBR.T2f3Eky" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6e5a0735-7928-5aca-b192-5e455fca402a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 25, 185, DateTimeKind.Utc).AddTicks(3206), "$2b$12$vZtwIaJiMW7te6fgAKDg8uRWlxCDzrWXHijEdu3kYonQyPVcXN2IC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 17, 234, DateTimeKind.Utc).AddTicks(3172), "$2b$12$4R/K2tHTCdhdANINi1if2upKQYH3z47RPQJ0HbjXhSPhKMKDR7MAi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 14, 986, DateTimeKind.Utc).AddTicks(3411), "$2b$12$o8Cxhkv5.U0I5lu8zfEt9OBG4HEDeNuvSk4EoXnq.G4NC6yy/xBry" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 3, 124, DateTimeKind.Utc).AddTicks(5630), "$2b$12$RIDr1Xl7mo7DDT9O2uDcY.qtdL/Rc/0KuKHs374LO8.46h.XE5V32" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8112e653-13fd-c47d-0fc5-7b36eda72bf0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 23, 243, DateTimeKind.Utc).AddTicks(178), "$2b$12$6tqS371pUtEDKty8OqDEkeIjxkjYTy/Mskx6eBEIwil9SD7SRHwOK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8976fc22-4f3c-f5a6-a6d7-81058525ac85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 34, 589, DateTimeKind.Utc).AddTicks(1968), "$2b$12$vuSy/qpsir1BLiDt.w4/tu.wzP7X.Oi9Riqoeu3WnKVUo8ORW7v86" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8b8636d1-c1b0-1104-ebb5-a8e7e20d35ae",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 30, 173, DateTimeKind.Utc).AddTicks(5973), "$2b$12$.bpsmRiOaNkin00NTOw0quCJ0wAR4BkA2yXDApwOxUOI.HATTps3u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 21, 660, DateTimeKind.Utc).AddTicks(2217), "$2b$12$ZiLDyy/UWhYPUWfH4Rhyj.iHzVO8gXyi4ziiEUIeKoS77eE3.0bru" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 14, 9, DateTimeKind.Utc).AddTicks(5110), "$2b$12$zeeFz4FKASJnLxYO/yG/s.BbflWzGDSR74qWn8ki7FRwX.6.Fkrae" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 10, 529, DateTimeKind.Utc).AddTicks(2660), "$2b$12$bpYWpSmPK8HEJUCSp4ti0OLzGOxQ3XVVCNs8VEkdrvYesXd7JZiKm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e85356b-dff7-0fe0-9e0a-ac24101ff81c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 18, 194, DateTimeKind.Utc).AddTicks(7091), "$2b$12$f1k4FfpdcyRzkUfwdjVFpOBWDZxN68XT3FHEJkG5KEmm15uISiRUa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8ee02cf3-bf69-3090-c8a3-acd718cd445f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 16, 911, DateTimeKind.Utc).AddTicks(1698), "$2b$12$NsoVygewzmugj2ouBZhF6..GoPkhAD7ZXA2emaagwVhJRqH9vwndm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "91f97c43-df32-927a-bb77-3f050c28c5d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 18, 513, DateTimeKind.Utc).AddTicks(3028), "$2b$12$ZTQzLYiUlhE6KmoqUs56oefdQ1V9FwVt1lD1y/9gAS4c/UY0B0Tmq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "953715b4-1d71-3023-7048-42579385f359",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 27, 253, DateTimeKind.Utc).AddTicks(1866), "$2b$12$IJ1uKYtmnRI3QM6T/dQZjujWZm9gAwOquJKHaKgNzydXSAeUbIZdu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "954d4710-fb9b-9bc8-33d6-1a00378fef99",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 24, 537, DateTimeKind.Utc).AddTicks(5786), "$2b$12$h3big89J302lJtfgjvAS6.Na2OM8TvgUJPJcsvKTl0RQmxepikgiO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "95755e71-293b-5fbe-2e06-ff9c6d90e96f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 20, 715, DateTimeKind.Utc).AddTicks(4492), "$2b$12$aezUsCPAQ9YiyVbBTAPbbe2JamodiVPCnaqWo2LJTBQ.1BVwryVIq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "96cb69c8-c721-11de-8075-582c3bb936c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 23, 556, DateTimeKind.Utc).AddTicks(803), "$2b$12$SQOMFzJMcCcy1AYcpKlRwOorRkqiid3nUWUvsxxOzfBHU1gJsGywO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 11, 159, DateTimeKind.Utc).AddTicks(4746), "$2b$12$aBSEbuhYtzJkE5e7gLqw0.l5CyixKGBaGOngrgO5VKPXXH0CwuecS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9dd3d6be-aadd-a804-775f-b0817d3508fc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 28, 883, DateTimeKind.Utc).AddTicks(7892), "$2b$12$gjzmA5lUdUIbJj11w.R79e5IGH7W/JqAn96dcXx5LTWkyhNRJysFG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 10, 840, DateTimeKind.Utc).AddTicks(8904), "$2b$12$61DCtqriSKQj2KstKooM2uYu2vJ5qn76TjnOjERPGQvavfaq0haWK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 9, 581, DateTimeKind.Utc).AddTicks(8515), "$2b$12$deJgw3JmVSQzXZ95skFk8ePLpULZ99u/CzVVkq38dHoztVMgONV8G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f3e92f6-ee55-979e-23b7-f713245738cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 28, 567, DateTimeKind.Utc).AddTicks(5444), "$2b$12$KBOuKfbSfNuonTe0BlAN/uK4iOPEoS6teJTrjPc7wPXcnmm8AjSA2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 13, 366, DateTimeKind.Utc).AddTicks(1617), "$2b$12$mZLm5VzcyUA1QgGkahVPIuZLXSJP1fUyD3DOblvfk9.VGjkjfNZOi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 21, 29, DateTimeKind.Utc).AddTicks(5418), "$2b$12$T4AZMz4wcs79qFDvQx1Z1OvlaYEQQvMskV4eFJbhXFG.MDbSV7Tw6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 9, 899, DateTimeKind.Utc).AddTicks(6886), "$2b$12$fsApyLOeD7VK2VXVrXIyq.YGDXSA0wO.2t/00pUgINoUJDgclJWZq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 12, 101, DateTimeKind.Utc).AddTicks(8003), "$2b$12$woxFeduxoD36U0o3UWNmDOoChLpD5TiaDiiJlN6bbSr3lsM1OUlsu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a70a25e3-1d3d-3e25-2f6d-c728283dce2c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 32, 43, DateTimeKind.Utc).AddTicks(7604), "$2b$12$0YwiGPTj1vSRIbbqlFSt6eV.Ah.M84gfAL9NsAOTIRY5ly5EZF6I." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a81af79f-d5c1-b515-0d1e-fe2dbabc780d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 29, 209, DateTimeKind.Utc).AddTicks(3424), "$2b$12$tx6v.3j1emQCsfXuoCSwUezMKw8wS5HVrsJEbXDoyVZtOCykfH33." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a894def6-b00b-6103-0ac7-92aa2bf2a079",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 27, 579, DateTimeKind.Utc).AddTicks(360), "$2b$12$ShNzQhIPZGsur9OUpY/wDOpQ3vsR3C9QpUuMymigJmqQp7C9Cyyqa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ada69e11-1e1e-3387-80da-a6afa8505ba2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 26, 223, DateTimeKind.Utc).AddTicks(1142), "$2b$12$hklz2sKrGZKrtgEqBD1tVu4uJ/AtSgAmWYkhuqwR5G8.WPwV0L0Y." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "aeba3eba-9c59-d115-5781-476232f36f4c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 21, 345, DateTimeKind.Utc).AddTicks(3243), "$2b$12$BrnXJffLA6Ha8VdrY4fjD..n.ScBnctlcxeVQyIE5k5zz1.47AQu2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "af142cbb-a95e-ab3e-f00a-a39f87004ec3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 15, 933, DateTimeKind.Utc).AddTicks(7995), "$2b$12$vtBGLqot873xxG6HXlQeQu93JUz/gkt.OMPadTCetas5kyVDqOFFK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "afa4fe08-4af6-cc2b-778f-115de345ebba",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 32, 658, DateTimeKind.Utc).AddTicks(185), "$2b$12$8DS.5s1A9Xvefj5oid65weUiIzHEgifI0yluvuz14h0LejDAq71MS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 13, 682, DateTimeKind.Utc).AddTicks(5326), "$2b$12$rU7YNmshzQUyrXTStV4nl.NqSLTVZSug0Jw0y3DlYiSZTW8zJ8FFu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 8, 9, DateTimeKind.Utc).AddTicks(8492), "$2b$12$IbIXcFyT0/ilfKJgQxi0n.gMFZdcHZMrFmDkPptbZ19zgJv4xk/0O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 56, 764, DateTimeKind.Utc).AddTicks(8245), "$2b$12$BqQKxzVUHUXB3rj8e2KxDen0FP5Aos/xLHJhcx5enbY.9HbYh/iDm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 5, 773, DateTimeKind.Utc).AddTicks(2446), "$2b$12$KEmqKWw.kgG1ARX2F0spKeTCVW.kG/lWQFiXacLssVUrGMyxbGeVu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 22, 927, DateTimeKind.Utc).AddTicks(7675), "$2b$12$7C0yp7peW/kfrLXZjDNKfuUNsZPpddEX1L77xbwPEJw9WbrJM//LG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 0, 267, DateTimeKind.Utc).AddTicks(5321), "$2b$12$5PSOQSCqjrjyhKvysmkSm.BU3FkzV/k.HUCGY6vDGy1LwYCdF1EiW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 7, 695, DateTimeKind.Utc).AddTicks(1648), "$2b$12$MogOh3QG0UyHGxbTbdtlC.JHMgGoQIEcWdr1drUQ5sfYUyNwnWCu2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 19, 139, DateTimeKind.Utc).AddTicks(5665), "$2b$12$93ZPs7co2pmtwbue59zkNeEJY6Vo6Hi9K7CQEu0rbPnva.a.DWsPa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c2dd0d11-f58f-2546-c1ca-10b453a7bc96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 23, 866, DateTimeKind.Utc).AddTicks(636), "$2b$12$lcZWBeDMIgtm55mNevhMfOnw.xNq0EQ.qrSDoEhMBmtr2cLqAKjvm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c668490c-dda2-f1b1-d170-72005fc34624",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 20, 405, DateTimeKind.Utc).AddTicks(1836), "$2b$12$neFyJZa/n/0U8NApNj1cTOmAbS/bd5cj.piVZO7/Feh/YkeO1jMPy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 6, 725, DateTimeKind.Utc).AddTicks(6350), "$2b$12$EN7I.ysvFrcJBmhW6KGgxeLjH3BrvzfITn8.3c15ZINXoIjdSTC4." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c8936e2c-61ab-766a-1161-ed4577bda964",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 22, 617, DateTimeKind.Utc).AddTicks(2629), "$2b$12$mU/fc68VBKkTs38QVlFJYe1eAEDM7FkdBJ2pDUJjnUjeqTu0wowbK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 14, 672, DateTimeKind.Utc).AddTicks(2448), "$2b$12$QRlvh9IHnYedeYIkOesOUOsgF2.3a2KbQiGtAYgXK3DfDEzHHdRi." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ccd1db56-b977-3035-ca07-0d16377dbbe1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 17, 551, DateTimeKind.Utc).AddTicks(2728), "$2b$12$iN3yMYY15SxoylYutFkRv.FqTGcJ39oLzVMcLytkl/MH9Oc3pqhru" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 0, 890, DateTimeKind.Utc).AddTicks(6902), "$2b$12$7mI9XrrO63AZMmfzU6vrnuU8qYVplLi5BQDcWBvLYswOxv5oDXPDC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 59, 315, DateTimeKind.Utc).AddTicks(8761), "$2b$12$xPJLcgP43i7EjoomQK0BsOjgDv.kEybgqmvcZwi4J4IIOQBa4TPoe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8924a08-9bc1-e88e-8396-1a1e86e2276b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 16, 251, DateTimeKind.Utc).AddTicks(2131), "$2b$12$m6rZ6cf33aE.bfERydpxfuSQHRBc2PJrrcS0Ryl98BsSSecJQatNS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 8, 953, DateTimeKind.Utc).AddTicks(6338), "$2b$12$NXNOexqCI0rtWpJvEBhUfuaXicqesC/q/Uor5Ou3Lc.QlWwQr1DLe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 57, 93, DateTimeKind.Utc).AddTicks(9823), "$2b$12$dF4fgt0Rz/XWIdtIMO4XFuVAbCkwbBhRRsQVJspDtTp7n1q6tjs5K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 10, 216, DateTimeKind.Utc).AddTicks(6510), "$2b$12$p5C0vtuycQA8T6jOJ1ysHeF.iHQh8GtqcW.DEBORjbw8gx5dwZin6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd288475-9710-eabb-7cca-449e335c3070",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 25, 532, DateTimeKind.Utc).AddTicks(8724), "$2b$12$wtxrFjX46h2YMCrfRoigvuw9sQ9lomvCfeV9dYtiDoc9.1uIuqa6e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 1, 522, DateTimeKind.Utc).AddTicks(8207), "$2b$12$CMrQ1kVqD/pg/wTx5IH4buYIGTm1SVJ.1fmZ48PZKQJux1Af5s3Yi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 12, 415, DateTimeKind.Utc).AddTicks(5806), "$2b$12$0W8uV5pkqxGoHjfUSVcMh.P.DIvyn6D2Svu2OdSrXmkirRnB0c.z6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 12, 731, DateTimeKind.Utc).AddTicks(5560), "$2b$12$rFRISiYqTrUFJnNcU7OoOuwC8Rt45MK7LHH9XCsfjS63Yf/Uijkpi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e48c4173-bb79-99df-4cdb-550c4acb9bfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 32, 978, DateTimeKind.Utc).AddTicks(4813), "$2b$12$3YS2aTpZdMLZpEgj2Zzbmeq./7/X3ZSbjsa8bn5E.xdnVPUmfw5cu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 11, 474, DateTimeKind.Utc).AddTicks(4548), "$2b$12$EGrF1XmRGZsOSSENWJEh9upMKweOv0licAaVLUGw.I6bOM2q6lbgi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 9, 270, DateTimeKind.Utc).AddTicks(5667), "$2b$12$gGt/OEOG3fK2H8ct9kVBB.zkgWxwZ2UbG2Anx4aCfXwOclF5WIQ7a" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ecd9a403-0fa0-120e-0580-76ac458c1397",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 27, 898, DateTimeKind.Utc).AddTicks(948), "$2b$12$/IPkSg5KMXBJNA7jgbmhRO7x2LBtvPX6gGZ0r1V13jX1PKjIKFjoS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 6, 405, DateTimeKind.Utc).AddTicks(8668), "$2b$12$SKQcVvHT0JwBiibm4ODkWuIOu4WEmUZWiKWiV/LGHPUS3HKOW8gka" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f0af01b8-a5e4-18f8-889c-4863d1166ca9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 31, 425, DateTimeKind.Utc).AddTicks(8176), "$2b$12$DG5ews3fqu0TVrHvE6PGMOPOeIwkFto0YIMShO1Cysz3jS.KaWFAu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f828e1ce-18e1-0c76-9535-92a277f7875a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 26, 561, DateTimeKind.Utc).AddTicks(4723), "$2b$12$jdtEz2Lx9SPOZxQhF88pKe7OF3HI0KlKD733Y5Gj9tCiWk2PLHHli" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 2, 482, DateTimeKind.Utc).AddTicks(318), "$2b$12$fFmf1LPVUzyJsK5Jyt7Zruj5Wbh5YDqJpdmPzdhfb2Qg2yUaqVeZW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 2, 162, DateTimeKind.Utc).AddTicks(4279), "$2b$12$ejb0yuz9U091vyTn/nDNtOlLMVq/GX3K2yac1L9U816FUci8uapaS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 6, 91, DateTimeKind.Utc).AddTicks(6604), "$2b$12$m6ZfV5kMf0IQWqDxdD33WupJJYopqZeEN7X.kLbyCjMv76k05sPSq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 58, 672, DateTimeKind.Utc).AddTicks(1569), "$2b$12$hibXGfQWEjA.3Hvss5DJQOIfJGhTqkSicd8mCFNquLULjzaOC1GAu" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "user_id", "created_at", "deleted_at", "email", "first_name", "last_name", "password", "phone_number", "UpdatedAt", "user_role_id" },
                values: new object[,]
                {
                    { "015a9397-c5c4-4b03-eb4f-86048ec621f6", new DateTime(2026, 4, 6, 12, 23, 3, 764, DateTimeKind.Utc).AddTicks(6237), null, "yassine.hamzaoui@univ.fr", "Yassine", "Hamzaoui", "$2b$12$oWSnwZLd3zGHM8rouU4Bf.TD7Yg3zuOHLldtr6EAzGOTQEtU3RDUq", "0134567807", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "296e74bd-c209-7f7c-d030-28e85a1aad75", new DateTime(2026, 4, 6, 12, 23, 4, 452, DateTimeKind.Utc).AddTicks(5104), null, "amin.kerroum@univ.fr", "Amin", "Kerroum", "$2b$12$3hAlgwVNjJm9x3BcENuzMu4XPAtS6HbxBKZP/dUNC8s0c6L4ekt0i", "0134567809", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "7f2e2223-eda8-2785-2b9f-2f6cbfecc012", new DateTime(2026, 4, 6, 12, 23, 4, 796, DateTimeKind.Utc).AddTicks(5968), null, "siham.lakhdar@univ.fr", "Siham", "Lakhdar", "$2b$12$k3NG4a2FxOqhivNFahQbiunaV/IcjIEK0o3/HnY5MNe1B1rkiVnbq", "0134567810", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "8c62f6c8-d791-e825-bdef-5c14bf5ce951", new DateTime(2026, 4, 6, 12, 23, 4, 110, DateTimeKind.Utc).AddTicks(673), null, "asmaa.fellah@univ.fr", "Asmaa", "Fellah", "$2b$12$l3bAHZtaOf6v1wlTuofppOtN3gHa.XfbNUewwza8/W74TeDut9gY2", "0134567808", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "8e1a2182-9af2-5229-2104-66051e4b6220", new DateTime(2026, 4, 6, 12, 23, 5, 134, DateTimeKind.Utc).AddTicks(1187), null, "riad.mokhtar@univ.fr", "Riad", "Mokhtar", "$2b$12$zmQGOpjEXl1LC1jwSRtQke5sSgX.Mc62cRrPyEj7LFBO5HL/8ZgWu", "0134567811", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "9ade6863-7e26-4864-6736-dc579f1c7a31", new DateTime(2026, 4, 6, 12, 23, 5, 455, DateTimeKind.Utc).AddTicks(4542), null, "nour.rahmani@univ.fr", "Nour", "Rahmani", "$2b$12$OkS8.bfzVRwdVIhkpJK7DeWcIaaaTxCHr90cq/j7Ho.C/hv0f6NAu", "0134567812", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "d3f7232a-7eb6-649e-c1fc-ad010f705d7a", new DateTime(2026, 4, 6, 12, 23, 3, 439, DateTimeKind.Utc).AddTicks(5567), null, "ikram.bouziane@univ.fr", "Ikram", "Bouziane", "$2b$12$vcjw688fomL7SnHsF0ZMUe24sG44rK5LANcuVIjbywEzIU.33Dsly", "0134567806", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" }
                });

            migrationBuilder.InsertData(
                table: "Assign",
                columns: new[] { "course_id", "track_id", "hourly_volume" },
                values: new object[,]
                {
                    { "2af630c1-de0d-944f-0b87-a73f1c90644f", "900f1499-bb04-690c-9394-eeafda3848a4", 18 },
                    { "3aed7e82-31b6-d05a-3f46-f2ef085d313e", "900f1499-bb04-690c-9394-eeafda3848a4", 36 },
                    { "c0452911-4948-9cb2-aed9-7b949c0b6442", "900f1499-bb04-690c-9394-eeafda3848a4", 36 },
                    { "c3cd3947-214d-3130-b938-a5d19a0e8eaa", "900f1499-bb04-690c-9394-eeafda3848a4", 36 },
                    { "cf512e7a-117b-71d0-a07f-43e743dad7eb", "900f1499-bb04-690c-9394-eeafda3848a4", 36 },
                    { "e9cbe024-5789-9dca-e8c8-418b70f033cb", "900f1499-bb04-690c-9394-eeafda3848a4", 36 },
                    { "fb30b659-6817-4099-e7cb-d7c254532603", "900f1499-bb04-690c-9394-eeafda3848a4", 36 }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "user_id", "registration_number", "teacher_title_id" },
                values: new object[,]
                {
                    { "015a9397-c5c4-4b03-eb4f-86048ec621f6", "REG_019", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "296e74bd-c209-7f7c-d030-28e85a1aad75", "REG_021", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "7f2e2223-eda8-2785-2b9f-2f6cbfecc012", "REG_022", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "8c62f6c8-d791-e825-bdef-5c14bf5ce951", "REG_020", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "8e1a2182-9af2-5229-2104-66051e4b6220", "REG_023", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "9ade6863-7e26-4864-6736-dc579f1c7a31", "REG_024", "85279958-5b39-6e84-7c57-09f2a0174fa9" },
                    { "d3f7232a-7eb6-649e-c1fc-ad010f705d7a", "REG_018", "85279958-5b39-6e84-7c57-09f2a0174fa9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "014c457e-a48a-d25e-7781-d5e483cb3dd9", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.DeleteData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "03241339-1186-a90f-33bd-a9850f603619", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.DeleteData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "24027d5d-e151-9a00-fd19-ac11d27b8189", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.DeleteData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "2af630c1-de0d-944f-0b87-a73f1c90644f", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.DeleteData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "2d4557a7-a48d-9926-3e2b-bc820396b11a", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.DeleteData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.DeleteData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "3aed7e82-31b6-d05a-3f46-f2ef085d313e", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.DeleteData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "3b835d91-4f08-07ef-d4d5-575947097601", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.DeleteData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "49ba4385-063d-7b8d-5f3f-aa1c7f573747", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.DeleteData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.DeleteData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "c0452911-4948-9cb2-aed9-7b949c0b6442", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.DeleteData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "c3cd3947-214d-3130-b938-a5d19a0e8eaa", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.DeleteData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "cf512e7a-117b-71d0-a07f-43e743dad7eb", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.DeleteData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "d059db13-ac91-760c-5bf7-6c442946e7bf", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.DeleteData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.DeleteData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "e9cbe024-5789-9dca-e8c8-418b70f033cb", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.DeleteData(
                table: "Assign",
                keyColumns: new[] { "course_id", "track_id" },
                keyValues: new object[] { "fb30b659-6817-4099-e7cb-d7c254532603", "900f1499-bb04-690c-9394-eeafda3848a4" });

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "015a9397-c5c4-4b03-eb4f-86048ec621f6");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "296e74bd-c209-7f7c-d030-28e85a1aad75");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "7f2e2223-eda8-2785-2b9f-2f6cbfecc012");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "8c62f6c8-d791-e825-bdef-5c14bf5ce951");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "8e1a2182-9af2-5229-2104-66051e4b6220");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "9ade6863-7e26-4864-6736-dc579f1c7a31");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "user_id",
                keyValue: "d3f7232a-7eb6-649e-c1fc-ad010f705d7a");

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "2af630c1-de0d-944f-0b87-a73f1c90644f");

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "3aed7e82-31b6-d05a-3f46-f2ef085d313e");

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "c0452911-4948-9cb2-aed9-7b949c0b6442");

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "c3cd3947-214d-3130-b938-a5d19a0e8eaa");

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "cf512e7a-117b-71d0-a07f-43e743dad7eb");

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "e9cbe024-5789-9dca-e8c8-418b70f033cb");

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "course_id",
                keyValue: "fb30b659-6817-4099-e7cb-d7c254532603");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "015a9397-c5c4-4b03-eb4f-86048ec621f6");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "296e74bd-c209-7f7c-d030-28e85a1aad75");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7f2e2223-eda8-2785-2b9f-2f6cbfecc012");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c62f6c8-d791-e825-bdef-5c14bf5ce951");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e1a2182-9af2-5229-2104-66051e4b6220");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9ade6863-7e26-4864-6736-dc579f1c7a31");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d3f7232a-7eb6-649e-c1fc-ad010f705d7a");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "011f7dd9-fd3a-3d41-6190-1f4489c299e9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 57, 916, DateTimeKind.Utc).AddTicks(2566), "$2b$12$QeukJPZ490ilZd4hvXSdiu8WvPTE1EAcTfsP1V1QBzugAIPyKB48S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "03428ee8-3d9a-de72-c98b-dbc65724b005",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 48, 694, DateTimeKind.Utc).AddTicks(1977), "$2b$12$NxqV/ARMqLNb7yHgGRXSYOQazzxS4.wlQ5yRjsLSfKSD682LeYcJO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 31, 219, DateTimeKind.Utc).AddTicks(8595), "$2b$12$Y35b/pYGXZeMHelq5eL.R.6ivxYXxRV1aSm5GYAX9J7dgGM.ffq66" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 35, 778, DateTimeKind.Utc).AddTicks(9599), "$2b$12$MUvqtP5FxntcYwpwLRLvXOzJdl1ZVfy2u5CfUDjTW4mtqdyLUXwdG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0a3f73e7-67a8-750c-576a-49c22125bac7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 59, 441, DateTimeKind.Utc).AddTicks(7409), "$2b$12$rKF7yUZL0Cu/zglvLMx47u/YoNet5UFF8484zBBc6BSWGxPjlmtoK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 26, 936, DateTimeKind.Utc).AddTicks(4444), "$2b$12$zbh2Wgmc91vsJBNH1hVNIO6GwF83U8lt.JlkaHTg3WMJTDOPD28by" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b48ba68-2d76-43aa-8392-7b40b1aa1e19",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 56, 93, DateTimeKind.Utc).AddTicks(3001), "$2b$12$0kNNb8DLDMAu1QUgzjci3./xWsmfhGYl5OXYVvOmWw8K1AMbBHwSe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 38, 898, DateTimeKind.Utc).AddTicks(8264), "$2b$12$EFrqLF4L7GuD1e1lHl.q9OfWtyZPONzi2REQEcaIVAfbPKgtQjRI6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "129452cc-6c9b-3726-5c96-54b67ac3b884",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 17, 0, 366, DateTimeKind.Utc).AddTicks(5105), "$2b$12$7WnF8ExCS2nvLpLoG5ojwOtkv1EsGgzGTVcwZlCAcX27hyEG6mgB6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 42, 283, DateTimeKind.Utc).AddTicks(5668), "$2b$12$tMp.igcEIiwwp04vjcd72eqjmAWNc4TVkvJKx7Gz6yuB217NApTWW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 28, 453, DateTimeKind.Utc).AddTicks(2088), "$2b$12$pkdkwV.jmX0z1hyXKdJ9auzu6nv1l4nXAq7fwunYmFoEeKYZ/WMv2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 46, 560, DateTimeKind.Utc).AddTicks(3947), "$2b$12$8186VT/S87mxeX3scpBc5eMJlGI03rJCPi1gHUbHr5OG9a3w6AOpW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 34, 475, DateTimeKind.Utc).AddTicks(5653), "$2b$12$FodbzpNQQ.VjpTyvYWHgKefY.gTBvnO.DnzLGNSHbL46Dr.ih.3ry" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "18241d26-a012-b189-957c-b5573ecb15d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 50, 848, DateTimeKind.Utc).AddTicks(2647), "$2b$12$RQrWgTrfvzg6TCXaaT2veeks8dSIcgiP7euveGMdHyY4/NV4CbXi2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 29, 368, DateTimeKind.Utc).AddTicks(7807), "$2b$12$D9gj5peLYN4HuRAXZXz8iOI8dmzpwbfTwrzf1NAGO73.zjpK2uA7K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 29, 996, DateTimeKind.Utc).AddTicks(6161), "$2b$12$pG4XsViTIUzupw50lWZl8eiSBrHgd9M7lzx.S0OKCqwT7ledrw00u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "288bdacf-8acb-a8d1-59f9-94f0cccb2086",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 54, 569, DateTimeKind.Utc).AddTicks(3181), "$2b$12$Rb/36VPTT1vub6FTex5wOOTb.ClSnnGFsc9KsxqzbM2VqLvk5IC5G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2b5c3a92-dc35-b1bd-16c3-b0f8a21f29f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 52, 399, DateTimeKind.Utc).AddTicks(5007), "$2b$12$UWL7vCgpS0NOmFZA7PDH5.K3hghGOiwPU8uQyaQ.JsAubgkwIM19y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2fa22e35-4eb2-7351-ee0e-a523ac305c44",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 56, 700, DateTimeKind.Utc).AddTicks(8368), "$2b$12$nEy7kBlT3auJmFziLPCMAu5zJSXSJ3tOzXEiNmcH8yFB7mdDgUuOG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 41, 349, DateTimeKind.Utc).AddTicks(1638), "$2b$12$s/Wcj16knC2bffHpukL0TuML63AteXrA6yDWijHV12.9v6BnLISa." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "373399d1-2bd2-aee5-629b-43f96da8f03e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 17, 0, 59, DateTimeKind.Utc).AddTicks(1228), "$2b$12$xKR2B.pSSVi1dw05T46ofOzy9LYXibNoA3d.IpAbnHighSBxvgEHG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3769412b-799f-6b72-f74f-9b9b735058c2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 53, 313, DateTimeKind.Utc).AddTicks(5483), "$2b$12$G6Hbn0B30F8YkTRpfJ7lj.UNNzUENo4HSzHECQZ0VY0KM.NHKqwM." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3830d83f-4097-76e0-a9e0-b90ef45d1c79",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 51, 483, DateTimeKind.Utc).AddTicks(6654), "$2b$12$zEP/X1E1f3SonuzIzJcve.oSbvFYyUallmBv9mydqfKeo6hoU6V32" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 25, 994, DateTimeKind.Utc).AddTicks(1455), "$2b$12$5msbsc5GnKuf6o1C7x54MuOrweh..IxUr3dg2Xm..L1LhKTK.Zs8C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 34, 104, DateTimeKind.Utc).AddTicks(2492), "$2b$12$fG2F.8NMgS9uqYxr/hGniu6voZiwVxIMz58iBrDORq7kKY9WJLl02" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 27, 542, DateTimeKind.Utc).AddTicks(4610), "$2b$12$96EeBEDnVrdLyNuitVo.aOAD5Q8LDtThXmnKN7Pxq3wRyF4hMquYi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "476292a1-d3ae-cacd-a58c-2d14790da8eb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 57, 309, DateTimeKind.Utc).AddTicks(7588), "$2b$12$ESR3cB6MVZ3Up.j52/d1b.EI6LSY7KewQx46ksIQ/9oskBX7MNfa2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 27, 239, DateTimeKind.Utc).AddTicks(7610), "$2b$12$sTvfpylaDtajI7nr8VoQ9umXUfq4YTO3a1adW76JHvl47Vqmt71bq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4d41b3e5-536d-0aa0-a3e3-024218ac6267",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 45, 650, DateTimeKind.Utc).AddTicks(5101), "$2b$12$6F1K4CtHD2g9l.RE8ZlsF.bdCbkUVU7lZXDSbydie0gRnpuF9IF/2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "51432fb0-cda4-87aa-a2d2-e36c25823a2b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 46, 863, DateTimeKind.Utc).AddTicks(7433), "$2b$12$fdn4TJTPyM4IHCUVzPosfuB2oGedNTZf9E7FbvWQo0rRlJjTZSz4y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "52fb0554-7e57-01bb-5949-987520c91eb5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 44, 737, DateTimeKind.Utc).AddTicks(6273), "$2b$12$Hzcty4lOEZISQ1RiImbgx.I.GuvcHY1jqml7znVY8t/BikUH.lCbG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "539ead07-d571-367b-79f7-68b21513886b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 55, 789, DateTimeKind.Utc).AddTicks(2290), "$2b$12$A0owvPDqvBhqekWkgNYPleE2nyaGAGMmXFFiDUcrfWc27m.21SWTu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "557dd714-15d7-6df3-3ed1-22a2eec63c59",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 43, 504, DateTimeKind.Utc).AddTicks(4506), "$2b$12$x78Bfe6hF2iQSBwl2h1GC.gZZeOSFvlTQsbXSBeURPoim8GcCpAu2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "57f13355-ddb7-5d3c-b09a-ff2c56e22753",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 42, 587, DateTimeKind.Utc).AddTicks(7221), "$2b$12$bGKN05WeoLe5gK4QkhROB.jhP6FkkDqNH/OAYRsK62bBAObb1eLZ2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 30, 602, DateTimeKind.Utc).AddTicks(4943), "$2b$12$jjxhBMDBWUKcGF8YNrgPD.djqYesF/4tAs9vhNtVkW68aeM7ikbPW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 27, 845, DateTimeKind.Utc).AddTicks(5428), "$2b$12$uCjAF42nAIIFWa9U70LMIeLisvaL5pP3YcrYOcgPLhEgd2ksiKxri" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 32, 151, DateTimeKind.Utc).AddTicks(5276), "$2b$12$5liXtx8noaCDc8dJ8n/G7eKJhKwH0V0NL2neJgcqpcoObyxvvUdnq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "617cb820-a96f-5ce4-513e-f9de2ec06556",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 46, 257, DateTimeKind.Utc).AddTicks(2644), "$2b$12$qXsYpC7hf3Yj8.autGG2dONIDppvySYh5pai8f9wrpAvy16TnbjDW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "62f48843-9c38-a162-72b9-af6d09b80de3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 57, 4, DateTimeKind.Utc).AddTicks(8015), "$2b$12$nPppQLoBYGclgO9ra.nXAuhRPQk/Tb6XyqR5FEkaFYD.MJB1FSN1W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 29, 63, DateTimeKind.Utc).AddTicks(8764), "$2b$12$G1fYTZWOge0qYTIE0p/a5Opu7cFYt.4CDc1KwwBE9L4ZEQU610lcW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "65aa7c04-2529-20cc-46f7-47c22df3e1d0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 58, 524, DateTimeKind.Utc).AddTicks(2898), "$2b$12$93TgQI4YdTsjnFwVmGcd7.TwVcNrKLabMZ40LaJBISXeeowyz6Fle" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "68fbd87f-0c94-976f-40de-323667ff06bf",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 49, 0, DateTimeKind.Utc).AddTicks(7636), "$2b$12$ro.Y.80Yc2bNR9Cx5luOluvMfagMLZW9HGVM9gogcQGWDRAnA0vk2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 35, 446, DateTimeKind.Utc).AddTicks(6198), "$2b$12$6CVdtLRBwHj3PqS/we1zBODDs3fRpj36/LIOlOQorN6Z4jc.o62K." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 40, 114, DateTimeKind.Utc).AddTicks(8918), "$2b$12$KFtrqyEXX7hSsWSACKYkku5pl8GvDX3Bw0HItm1Vig9JsB4H7xkYW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6dcd090f-508b-7888-b458-17aeea49123a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 59, 751, DateTimeKind.Utc).AddTicks(3334), "$2b$12$0KzSjAzI3K3VFCCfCEvbh.p0OwGVxSzKWrRex9TlzQ4lhVKNA2YB2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6e5a0735-7928-5aca-b192-5e455fca402a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 51, 790, DateTimeKind.Utc).AddTicks(9381), "$2b$12$UMrjlWQ3pM.F/zYMvU1JTueY0nqRE5rNWXhXkVnWkYuUALMM7glL." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 44, 129, DateTimeKind.Utc).AddTicks(2731), "$2b$12$RhQMcxuFmEH0dn35aKxgveMCDu47rUlF87K2NTmq/fdXjR5t4l5NS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 41, 977, DateTimeKind.Utc).AddTicks(5521), "$2b$12$ceyzv/cr6b3P2MXL6U54JO37UJbo9jNKg4BmD0sC8B1NYKwvZ6r0." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 32, 456, DateTimeKind.Utc).AddTicks(8879), "$2b$12$bPObNRxPwywzq5I1SRTt3e0CXiVv42qUvAbP1RfR0bsfke1rVZJVO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8112e653-13fd-c47d-0fc5-7b36eda72bf0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 49, 936, DateTimeKind.Utc).AddTicks(7750), "$2b$12$UXRRgGEihSZXWnLHu3xPbuuCLQUas3AHlcdf.KEajXoNaMg04LvM." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8976fc22-4f3c-f5a6-a6d7-81058525ac85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 17, 0, 670, DateTimeKind.Utc).AddTicks(7224), "$2b$12$V7rkt5eEQ1NHScLgdrPjHei2qToCGk1iMpu6j24np/UKaafcIBIs2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8b8636d1-c1b0-1104-ebb5-a8e7e20d35ae",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 56, 396, DateTimeKind.Utc).AddTicks(8788), "$2b$12$9ThIocQEA.kPacTM7Hciteyo8.O0O8ie2oHUBwYIsTii3EgTjKqpq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 48, 387, DateTimeKind.Utc).AddTicks(1262), "$2b$12$jB7WFtC9h/s/GQLWsq/LA.fRX1mGcLjPfJio8AjgOLkedjZbYdqAe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 41, 27, DateTimeKind.Utc).AddTicks(8224), "$2b$12$rAqDVMHWy2JDppoz1wbLi.E.8NfFn6j79jxtOlz3CUrcgFE4bqptW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 37, 679, DateTimeKind.Utc).AddTicks(7287), "$2b$12$Ah/h.7z1N6GLfkP.IKnXA.PE195Mu9V8QimApzlQ8DxdsO6RKe.j6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e85356b-dff7-0fe0-9e0a-ac24101ff81c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 45, 40, DateTimeKind.Utc).AddTicks(7151), "$2b$12$ShmqaxrTcH9ML49w7lL.cebMfPn6sFHJVMN81.vI8XWNv6VIWoyNS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8ee02cf3-bf69-3090-c8a3-acd718cd445f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 43, 811, DateTimeKind.Utc).AddTicks(2995), "$2b$12$KKY2J/QZ5lFKhq6BU92pDeIvbhhdsVmIwCAt9DkdVI/nAzXcVaynG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "91f97c43-df32-927a-bb77-3f050c28c5d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 45, 346, DateTimeKind.Utc).AddTicks(7238), "$2b$12$HGeZ.iWjqi01rk8.3wsit.mPmUHHfP.vC/ZcFFL9ad.xZ4Apdh6H6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "953715b4-1d71-3023-7048-42579385f359",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 53, 617, DateTimeKind.Utc).AddTicks(613), "$2b$12$fScyXFEO4aCv14YX5nyHfeghpZ3uW6wdiSPV1kEqo77faSU7aKqzW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "954d4710-fb9b-9bc8-33d6-1a00378fef99",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 51, 154, DateTimeKind.Utc).AddTicks(3679), "$2b$12$PDsPwSXANxIcgPXL7O2i6O7uk8seXkzSIfS39k9Bn5OEMGkIdkkFm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "95755e71-293b-5fbe-2e06-ff9c6d90e96f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 47, 471, DateTimeKind.Utc).AddTicks(3971), "$2b$12$1YzrD8/LIt.7aLkLJffkcOVO9xNKKb/rqGnh3JFTCKALJh9h7pil6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "96cb69c8-c721-11de-8075-582c3bb936c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 50, 240, DateTimeKind.Utc).AddTicks(3749), "$2b$12$bPU/pmOFa.EOPWvd4rJUoOe/MoEnMwbsdPex.gAkJBQKUjkLSt3rS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 38, 287, DateTimeKind.Utc).AddTicks(7615), "$2b$12$CetHy89TIlmpOjua41u1m.CvSvnyY/N0CyM9/mqSdpfcnHCsJKn9K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9dd3d6be-aadd-a804-775f-b0817d3508fc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 55, 181, DateTimeKind.Utc).AddTicks(4547), "$2b$12$SxjlV4y2T.NtndU4WiDmq.WF7WsBk4/liTqvXt5we.FO5wgCnsVDK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 37, 984, DateTimeKind.Utc).AddTicks(3148), "$2b$12$/eaSJnvvIfxHl/ulGlUc8OqChA/NIFuIMILjSKoiJRS/fEjfldIRG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 36, 727, DateTimeKind.Utc).AddTicks(497), "$2b$12$Lh2Jc1gBVU4ozaszvyjZi.KY0WBNK9Zed3XKn7TP60iV1GX2X5tcS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f3e92f6-ee55-979e-23b7-f713245738cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 54, 874, DateTimeKind.Utc).AddTicks(6522), "$2b$12$gA1Wx1eA6m/wsyvVyoqGmeyEb8hDvjycA1c5wBI2ryG1COteZACYO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 40, 417, DateTimeKind.Utc).AddTicks(7384), "$2b$12$Wj.oNgOna.z9b32h57umCuvSf8kAKcVshb23YI7kOfVeRHO5NiZbO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 47, 776, DateTimeKind.Utc).AddTicks(5592), "$2b$12$KU4T6Ay4Oa9zgubM1AsuZ.Lk6Wpc2KYkpuEF1OAEO6yRXZJ.FiKgK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 37, 46, DateTimeKind.Utc).AddTicks(6357), "$2b$12$WPwW25PQGUOQ1tsYw7PuqO/mTDHwc4EE.K2UO1UXV1kMI/I/N3/W2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 39, 202, DateTimeKind.Utc).AddTicks(6022), "$2b$12$4FB..Y9GJjPhuJmNJ4BQZ.51.45L5.22WEAW5MmGi.6Q1jI13/ho6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a70a25e3-1d3d-3e25-2f6d-c728283dce2c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 58, 218, DateTimeKind.Utc).AddTicks(6033), "$2b$12$lBPoCCx2/u8MbQiK6j/4/.7H0U2/T0IeUwd4FdhA4qDzi/jxaWTTe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a81af79f-d5c1-b515-0d1e-fe2dbabc780d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 55, 485, DateTimeKind.Utc).AddTicks(5693), "$2b$12$ajwRugkbltnjfZOvTOomg.bcc5e/PGEcLdGMkvA7a.32G540RzuVi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a894def6-b00b-6103-0ac7-92aa2bf2a079",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 53, 930, DateTimeKind.Utc).AddTicks(9458), "$2b$12$sBlfNfhY.5TTMDqntyErdesgfEmVFY02gF86p/bJcRppLDW6sUkOa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ada69e11-1e1e-3387-80da-a6afa8505ba2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 52, 704, DateTimeKind.Utc).AddTicks(5846), "$2b$12$CdLlBO27YG731Y/GpWLBn.FMG20q4ycp7VjACfV2eeAAPyzI5pa2S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "aeba3eba-9c59-d115-5781-476232f36f4c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 48, 81, DateTimeKind.Utc).AddTicks(3973), "$2b$12$zosHAhLDUSH/Z3neSctZYO/SPEBn1RaV5lWMGebFxyHTmCwv1GF2e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "af142cbb-a95e-ab3e-f00a-a39f87004ec3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 42, 890, DateTimeKind.Utc).AddTicks(4583), "$2b$12$e4lXJkXsuILy/oVmIRMfQepN0nXlBX2ECCVE33na0PNDGXVWc7eSq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "afa4fe08-4af6-cc2b-778f-115de345ebba",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 58, 829, DateTimeKind.Utc).AddTicks(7101), "$2b$12$hhy3TYAJQjkxl981/czKsu9RAIazUdsNOQYPrdjRqiFj9HdlLpYoW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 40, 722, DateTimeKind.Utc).AddTicks(6295), "$2b$12$gw30i6QdISey4SRW01d3YuT4XhPKox2DpwT25F2gs6.UrxRdB1fNS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 35, 106, DateTimeKind.Utc).AddTicks(6971), "$2b$12$az.Sg4nawJyNgTTGa0kugOL5s2bmthyCczHEP5.8Z.7caOZsJA17G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 26, 321, DateTimeKind.Utc).AddTicks(3503), "$2b$12$Zc7SzLPKfNcC16Yu9DxjTO7QVj9dH/pDsD8n7h.6Mj71Io8rJ8/ni" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 32, 773, DateTimeKind.Utc).AddTicks(9428), "$2b$12$bgccH0R0Hd5EKUyd1LIw..lDPQkXG4JsGjXjDrLefzu0vuHung1pa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 49, 608, DateTimeKind.Utc).AddTicks(4942), "$2b$12$Z9jjsjwxy.vkHZBHsWxNWuuiuvh1wtXuGWOylGXYnP26Mq3xJDMt2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 29, 672, DateTimeKind.Utc).AddTicks(4111), "$2b$12$/6p6LBik0lImNTk4PiP0HOtwT2wJZjoF1ORpD0gd7VFLQjTGj7D9G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 34, 787, DateTimeKind.Utc).AddTicks(9664), "$2b$12$vDFfwjDMK3tYryIHh5fl9.RGb71nVBY8mUkXe6Ed1BuwnzLAYCT9m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 45, 953, DateTimeKind.Utc).AddTicks(7855), "$2b$12$LcJ2lQ54SWgsr4itJdeN7O3vTJ/5ic24U9I3DfNToCZGZ5wRapg56" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c2dd0d11-f58f-2546-c1ca-10b453a7bc96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 50, 544, DateTimeKind.Utc).AddTicks(4617), "$2b$12$jWJSlQ2aSGcbnxDGEFRB4OYVbg6wGHSLGzGLREHshNPDkyBV3xl76" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c668490c-dda2-f1b1-d170-72005fc34624",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 47, 167, DateTimeKind.Utc).AddTicks(89), "$2b$12$0RIX9cWbqJCaZslduVM1vORo5QmUeJXnqz7HVwOvdG/PA7N9M8Lwi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 33, 750, DateTimeKind.Utc).AddTicks(2765), "$2b$12$gEgCI/fw22xDBEx2gYETZO7o53fQVrcGjcWYcW2DkmoTrL9cqhFlG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c8936e2c-61ab-766a-1161-ed4577bda964",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 49, 305, DateTimeKind.Utc).AddTicks(5653), "$2b$12$GMr5UKAfN2S9y2Y6Dswe8.ETSJEaZ1vT2DWYY9TP361OZOrMrOk8C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 41, 664, DateTimeKind.Utc).AddTicks(5027), "$2b$12$S/jGd98nTmzIos2oPjJtcuqdmQXJgpTebspgL83akn9dNIAPT.XJC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ccd1db56-b977-3035-ca07-0d16377dbbe1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 44, 433, DateTimeKind.Utc).AddTicks(9810), "$2b$12$fEDppNCZygiFTKvczHXgU.DdV7y/z5IDw1oiIWsdyZSMVun7m7Aq2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 30, 299, DateTimeKind.Utc).AddTicks(5942), "$2b$12$dDqfsYAuPu8OQXrRGUJoEuNh8ep9IF4Gpju1oUHormRftoLqVpxiG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 28, 757, DateTimeKind.Utc).AddTicks(7803), "$2b$12$D/uOAbXyQPqHrVZEWluuB.8yb/qPIONpTszE9h4iJR1fCfXefihgS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8924a08-9bc1-e88e-8396-1a1e86e2276b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 43, 196, DateTimeKind.Utc).AddTicks(2423), "$2b$12$hTIloyh/r85bS6yVVXewOO2Zx/m/jT.TcQO6LvyF4XWQAG8k87WZy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 36, 84, DateTimeKind.Utc).AddTicks(4614), "$2b$12$4J.rFRBVH5oy8JYM8PCnBe0Tk2Ouwa4iF3kQ7iBMF3.hmAU7qO62q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 26, 632, DateTimeKind.Utc).AddTicks(8123), "$2b$12$5y2mBd0rmzdHL1qJ20W60.9/JSC8Mk56xYes50qZkZqQQwK2irAF6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 37, 353, DateTimeKind.Utc).AddTicks(7449), "$2b$12$bQmE3bPkE3BCa/WzetnZauOmSKlzW2Wz/usF8ETRoA.uet27sG2yW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd288475-9710-eabb-7cca-449e335c3070",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 52, 95, DateTimeKind.Utc).AddTicks(9713), "$2b$12$ql4aMIrBi2eXlf6xt/p/3etEzWdFrmfOnfSO.XLqqHnmjOsKyf8ga" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 30, 905, DateTimeKind.Utc).AddTicks(7310), "$2b$12$mYL6aCzbGeG.SiTtfrTfh.mtVnJ7UMnvXM4ahC5/P94bx0wMiIXHy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 39, 506, DateTimeKind.Utc).AddTicks(6541), "$2b$12$foaO0iDn6bet5DJdOWGLD.sbNnj.5m3UQYbah/pVVleeC5H5RNitK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 39, 812, DateTimeKind.Utc).AddTicks(1243), "$2b$12$8TnoutM9T5bo74wJBXFrqebbznU.2VMBnCYqxASDfyvEayorSFUby" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e48c4173-bb79-99df-4cdb-550c4acb9bfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 59, 135, DateTimeKind.Utc).AddTicks(5302), "$2b$12$c2DXrDG2BWbvI8OhAPG1W.YKuA319KZpOz2GsK5zzdU0oxTLmUSue" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 38, 594, DateTimeKind.Utc).AddTicks(1302), "$2b$12$jQBUP66BiETnfEU5NL/OOulwnqoGtydmcFran6Ort2xHFvIzq8Q8u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 36, 413, DateTimeKind.Utc).AddTicks(8798), "$2b$12$/DvL/3et4tK0xIODZhvbL.I6e1tnwOjaPGFy5MMFzoMa0i0cLU5ma" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ecd9a403-0fa0-120e-0580-76ac458c1397",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 54, 242, DateTimeKind.Utc).AddTicks(8409), "$2b$12$tpAtraTyhq6ejhv1tSh6n.2AMBMa62BQMW.wybbuNnPI4Te3HZ8Ve" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 33, 446, DateTimeKind.Utc).AddTicks(90), "$2b$12$ZRGlT0xqjZ7hrRvDJOCJIugsESLfU5WVorKZCe1UndxfGreHKP2SK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f0af01b8-a5e4-18f8-889c-4863d1166ca9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 57, 613, DateTimeKind.Utc).AddTicks(3626), "$2b$12$233CT5JMK5NMHSzuWkPhVOzyzh/omlMlR54N3noNuXjG8uuhdUTIW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f828e1ce-18e1-0c76-9535-92a277f7875a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 53, 8, DateTimeKind.Utc).AddTicks(4900), "$2b$12$/P.f1kdeEmgwJqZBMXACWOyLyUWtlUAY6kiZohjv30Mr5SD4Yp6om" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 31, 847, DateTimeKind.Utc).AddTicks(2417), "$2b$12$DqR11hzsteLsPuc4hqnOTeD1KXzY64C5okiXBcsOuot74kWTihD2i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 31, 541, DateTimeKind.Utc).AddTicks(7847), "$2b$12$SvJ65EUJ0IKrQuEvhn.kM.TyneaZsG90Nbm4zsi9R4ZEypL9MNYNe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 33, 114, DateTimeKind.Utc).AddTicks(8177), "$2b$12$H5KtMX8GjYheJzV1.mpeyO8hRb2ytNDow1s0mYp5bxXuqvOvgl/s." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 11, 16, 28, 149, DateTimeKind.Utc).AddTicks(4358), "$2b$12$BDgGNcoIsbowkCl44rWuOuzvPvl4vT6wsES5MwPjum6l1Ghxzk8IO" });
        }
    }
}
