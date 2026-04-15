using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPendingRecoveryChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SessionRecoveryChange",
                columns: new[] { "session_recovery_change_id", "change_date", "change_status_id", "counter_proposal_date", "counter_proposal_end_time", "counter_proposal_room_id", "counter_proposal_start_time", "proposed_date", "proposed_end_time", "proposed_room_id", "proposed_start_time", "reason", "rejection_reason", "session_id", "teacher_id" },
                values: new object[,]
                {
                    { "13cbeb74-0d1a-3748-93e6-df6266a81952", new DateTime(2026, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, null, null, null, new DateTime(2026, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0), "5863a804-6ac2-3f05-38ed-472541726740", new TimeSpan(0, 10, 0, 0, 0), "Absence pour participation à un jury de thèse.", null, "f00894af-9f60-232f-5012-c431bbcddee1", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "2094bf3b-43b9-5ba4-be7a-e41dccb472d3", new DateTime(2026, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, null, null, null, new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0), "02bcf600-5d44-cca7-8b68-e763b00a6339", new TimeSpan(0, 14, 0, 0, 0), "Cours annulé en raison d'une panne informatique.", null, "c7e69e7d-d218-7f39-2087-c2c4f1ba0fb4", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "218f42fb-3230-2aea-827b-8723163953d2", new DateTime(2026, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, null, null, null, new DateTime(2026, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0), "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9", new TimeSpan(0, 10, 0, 0, 0), "Cours manqué en raison d'un déplacement professionnel.", null, "157d47fc-fd47-d6c6-b759-86b4049e4fff", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "80172530-bb8b-cc50-2f53-dfa3b0f29b0b", new DateTime(2026, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, null, null, null, new DateTime(2026, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0), "5863a804-6ac2-3f05-38ed-472541726740", new TimeSpan(0, 8, 0, 0, 0), "Cours annulé suite à un problème de chauffage dans la salle.", null, "f00894af-9f60-232f-5012-c431bbcddee1", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "83937ad0-dba1-ba1f-7efd-0a56482244e6", new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, null, null, null, new DateTime(2026, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0), "02bcf600-5d44-cca7-8b68-e763b00a6339", new TimeSpan(0, 8, 0, 0, 0), "Absence imprévue pour raison médicale.", null, "c7e69e7d-d218-7f39-2087-c2c4f1ba0fb4", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "8e6fe33d-7b31-dcc9-153f-1b918148e8b4", new DateTime(2026, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, null, null, null, new DateTime(2026, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0), "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9", new TimeSpan(0, 14, 0, 0, 0), "Cours interrompu suite à une alerte incendie.", null, "157d47fc-fd47-d6c6-b759-86b4049e4fff", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "baef5bd0-85de-8684-4b8b-4be6af478d7d", new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, null, null, null, new DateTime(2026, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0), "5863a804-6ac2-3f05-38ed-472541726740", new TimeSpan(0, 16, 0, 0, 0), "Séance annulée suite à une réunion de département imprévue.", null, "f00894af-9f60-232f-5012-c431bbcddee1", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "bd8de704-c14e-19fc-42ca-dd7fcb2baa3d", new DateTime(2026, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, null, null, null, new DateTime(2026, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0), "02bcf600-5d44-cca7-8b68-e763b00a6339", new TimeSpan(0, 14, 0, 0, 0), "Séance annulée en raison de travaux dans le bâtiment.", null, "c7e69e7d-d218-7f39-2087-c2c4f1ba0fb4", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "e3236962-8cf5-f55c-078b-4bd141ddba2a", new DateTime(2026, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, null, null, null, new DateTime(2026, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0), "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9", new TimeSpan(0, 16, 0, 0, 0), "Absence pour formation pédagogique obligatoire.", null, "157d47fc-fd47-d6c6-b759-86b4049e4fff", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "eaa567ec-8ad4-3c30-af35-ed6d21520bca", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, null, null, null, new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0), "02bcf600-5d44-cca7-8b68-e763b00a6339", new TimeSpan(0, 10, 0, 0, 0), "Séance annulée pour participation à une conférence internationale.", null, "c7e69e7d-d218-7f39-2087-c2c4f1ba0fb4", "f8360932-cad7-22ba-add7-d31883af9229" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "13cbeb74-0d1a-3748-93e6-df6266a81952");

            migrationBuilder.DeleteData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "2094bf3b-43b9-5ba4-be7a-e41dccb472d3");

            migrationBuilder.DeleteData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "218f42fb-3230-2aea-827b-8723163953d2");

            migrationBuilder.DeleteData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "80172530-bb8b-cc50-2f53-dfa3b0f29b0b");

            migrationBuilder.DeleteData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "83937ad0-dba1-ba1f-7efd-0a56482244e6");

            migrationBuilder.DeleteData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "8e6fe33d-7b31-dcc9-153f-1b918148e8b4");

            migrationBuilder.DeleteData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "baef5bd0-85de-8684-4b8b-4be6af478d7d");

            migrationBuilder.DeleteData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "bd8de704-c14e-19fc-42ca-dd7fcb2baa3d");

            migrationBuilder.DeleteData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "e3236962-8cf5-f55c-078b-4bd141ddba2a");

            migrationBuilder.DeleteData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "eaa567ec-8ad4-3c30-af35-ed6d21520bca");
        }
    }
}
