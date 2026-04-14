using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixChangeStatusLabelsAndProposedDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ChangeStatus",
                keyColumn: "change_status_id",
                keyValue: "6d1cab45-5c87-c373-3fd2-91f518c946bc",
                column: "label",
                value: "En attente");

            migrationBuilder.UpdateData(
                table: "ChangeStatus",
                keyColumn: "change_status_id",
                keyValue: "d16d1a05-a70b-a5f5-6d3a-8013b24626d7",
                column: "label",
                value: "Refusé");

            migrationBuilder.UpdateData(
                table: "ChangeStatus",
                keyColumn: "change_status_id",
                keyValue: "df4c997e-2e20-921e-98e9-906a9ecf8813",
                column: "label",
                value: "Approuvé");

            migrationBuilder.UpdateData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "33cecfa5-b149-cfc6-bb5d-597f81dbff5f",
                column: "proposed_date",
                value: new DateTime(2026, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "3f8e497b-6213-d701-5cb4-c79f33d63206",
                columns: new[] { "counter_proposal_date", "proposed_date" },
                values: new object[] { new DateTime(2026, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "7b8f94b3-7dfc-f396-54c8-1d716494c73b",
                column: "proposed_date",
                value: new DateTime(2026, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "7d523e68-1971-6f1c-971d-1b89e8681d48",
                column: "proposed_date",
                value: new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ChangeStatus",
                keyColumn: "change_status_id",
                keyValue: "6d1cab45-5c87-c373-3fd2-91f518c946bc",
                column: "label",
                value: "ATTENTE");

            migrationBuilder.UpdateData(
                table: "ChangeStatus",
                keyColumn: "change_status_id",
                keyValue: "d16d1a05-a70b-a5f5-6d3a-8013b24626d7",
                column: "label",
                value: "REFUSE");

            migrationBuilder.UpdateData(
                table: "ChangeStatus",
                keyColumn: "change_status_id",
                keyValue: "df4c997e-2e20-921e-98e9-906a9ecf8813",
                column: "label",
                value: "APPROUVE");

            migrationBuilder.UpdateData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "33cecfa5-b149-cfc6-bb5d-597f81dbff5f",
                column: "proposed_date",
                value: new DateTime(2026, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "3f8e497b-6213-d701-5cb4-c79f33d63206",
                columns: new[] { "counter_proposal_date", "proposed_date" },
                values: new object[] { new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "7b8f94b3-7dfc-f396-54c8-1d716494c73b",
                column: "proposed_date",
                value: new DateTime(2026, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "7d523e68-1971-6f1c-971d-1b89e8681d48",
                column: "proposed_date",
                value: new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
