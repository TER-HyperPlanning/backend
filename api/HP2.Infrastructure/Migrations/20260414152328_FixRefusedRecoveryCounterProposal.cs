using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixRefusedRecoveryCounterProposal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "7d523e68-1971-6f1c-971d-1b89e8681d48",
                columns: new[] { "counter_proposal_date", "counter_proposal_end_time", "counter_proposal_room_id", "counter_proposal_start_time" },
                values: new object[] { new DateTime(2026, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0), "5863a804-6ac2-3f05-38ed-472541726740", new TimeSpan(0, 10, 0, 0, 0) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SessionRecoveryChange",
                keyColumn: "session_recovery_change_id",
                keyValue: "7d523e68-1971-6f1c-971d-1b89e8681d48",
                columns: new[] { "counter_proposal_date", "counter_proposal_end_time", "counter_proposal_room_id", "counter_proposal_start_time" },
                values: new object[] { null, null, null, null });
        }
    }
}
