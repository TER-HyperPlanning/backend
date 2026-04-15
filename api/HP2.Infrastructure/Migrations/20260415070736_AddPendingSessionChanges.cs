using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPendingSessionChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SessionRoomChange",
                columns: new[] { "session_room_change_id", "approved_room_id", "change_date", "change_status_id", "old_room_id", "reason", "rejection_reason", "session_id", "teacher_id" },
                values: new object[,]
                {
                    { "13fa738a-c876-a862-f6a6-b1abbaa39a10", null, new DateTime(2026, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, "La salle prévue est trop bruyante pour un examen.", null, "157d47fc-fd47-d6c6-b759-86b4049e4fff", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "30c8a480-a8a7-25c1-5e80-8520af130fe7", null, new DateTime(2026, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, "Capacité insuffisante pour accueillir tous les étudiants du groupe.", null, "c7e69e7d-d218-7f39-2087-c2c4f1ba0fb4", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "39ece48f-ff2f-2b8d-18f5-9d1bcf9b9654", null, new DateTime(2026, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, "La salle assignée manque d'équipement audiovisuel.", null, "c7e69e7d-d218-7f39-2087-c2c4f1ba0fb4", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "6f631751-7092-f7a4-67a3-3f5fee207348", null, new DateTime(2026, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, "Besoin d'une salle avec tableau numérique interactif.", null, "f00894af-9f60-232f-5012-c431bbcddee1", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "7662b4f1-01a8-88c8-269b-7debe3ffdf1a", null, new DateTime(2026, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, "Besoin d'une salle avec connexion réseau filaire pour les TPs.", null, "f00894af-9f60-232f-5012-c431bbcddee1", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "86d8738b-dc5f-6a2b-d615-a78cae1b7f8b", null, new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, "Problème de ventilation dans la salle assignée.", null, "157d47fc-fd47-d6c6-b759-86b4049e4fff", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "9d8e08ea-d574-71ba-dce2-c94b903863b7", null, new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, "Besoin d'une salle plus grande pour accueillir des invités extérieurs.", null, "c7e69e7d-d218-7f39-2087-c2c4f1ba0fb4", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "a195ccc6-c3f9-6286-299f-33aa8528d5a0", null, new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, "La salle actuelle est inaccessible aux personnes à mobilité réduite.", null, "f00894af-9f60-232f-5012-c431bbcddee1", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "b36193ff-c266-86a0-a313-f04de96c3af1", null, new DateTime(2026, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, "La salle est occupée par un autre événement non planifié.", null, "c7e69e7d-d218-7f39-2087-c2c4f1ba0fb4", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "c3d1e14b-b538-9489-411c-eead5180746f", null, new DateTime(2026, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d1cab45-5c87-c373-3fd2-91f518c946bc", null, "La salle prévue est en cours de rénovation.", null, "157d47fc-fd47-d6c6-b759-86b4049e4fff", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SessionRoomChange",
                keyColumn: "session_room_change_id",
                keyValue: "13fa738a-c876-a862-f6a6-b1abbaa39a10");

            migrationBuilder.DeleteData(
                table: "SessionRoomChange",
                keyColumn: "session_room_change_id",
                keyValue: "30c8a480-a8a7-25c1-5e80-8520af130fe7");

            migrationBuilder.DeleteData(
                table: "SessionRoomChange",
                keyColumn: "session_room_change_id",
                keyValue: "39ece48f-ff2f-2b8d-18f5-9d1bcf9b9654");

            migrationBuilder.DeleteData(
                table: "SessionRoomChange",
                keyColumn: "session_room_change_id",
                keyValue: "6f631751-7092-f7a4-67a3-3f5fee207348");

            migrationBuilder.DeleteData(
                table: "SessionRoomChange",
                keyColumn: "session_room_change_id",
                keyValue: "7662b4f1-01a8-88c8-269b-7debe3ffdf1a");

            migrationBuilder.DeleteData(
                table: "SessionRoomChange",
                keyColumn: "session_room_change_id",
                keyValue: "86d8738b-dc5f-6a2b-d615-a78cae1b7f8b");

            migrationBuilder.DeleteData(
                table: "SessionRoomChange",
                keyColumn: "session_room_change_id",
                keyValue: "9d8e08ea-d574-71ba-dce2-c94b903863b7");

            migrationBuilder.DeleteData(
                table: "SessionRoomChange",
                keyColumn: "session_room_change_id",
                keyValue: "a195ccc6-c3f9-6286-299f-33aa8528d5a0");

            migrationBuilder.DeleteData(
                table: "SessionRoomChange",
                keyColumn: "session_room_change_id",
                keyValue: "b36193ff-c266-86a0-a313-f04de96c3af1");

            migrationBuilder.DeleteData(
                table: "SessionRoomChange",
                keyColumn: "session_room_change_id",
                keyValue: "c3d1e14b-b538-9489-411c-eead5180746f");
        }
    }
}
