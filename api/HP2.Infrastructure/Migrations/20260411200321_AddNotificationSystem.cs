using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNotificationSystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receive");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Notifica__E059842FEA1D001E",
                table: "Notification");

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "Notification",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "message",
                table: "Notification",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldUnicode: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "Notification",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "notification_id",
                table: "Notification",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldDefaultValueSql: "(newid())");

            migrationBuilder.AddColumn<string>(
                name: "related_id",
                table: "Notification",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "Notification",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValue: "General");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notification",
                table: "Notification",
                column: "notification_id");

            migrationBuilder.CreateTable(
                name: "NotificationUser",
                columns: table => new
                {
                    NotificationsNotificationId = table.Column<string>(type: "varchar(50)", nullable: false),
                    UsersUserId = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationUser", x => new { x.NotificationsNotificationId, x.UsersUserId });
                    table.ForeignKey(
                        name: "FK_NotificationUser_Notification_NotificationsNotificationId",
                        column: x => x.NotificationsNotificationId,
                        principalTable: "Notification",
                        principalColumn: "notification_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotificationUser_User_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "User",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserNotification",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    notification_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    is_read = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNotification", x => new { x.user_id, x.notification_id });
                    table.ForeignKey(
                        name: "FK_UserNotification_Notification",
                        column: x => x.notification_id,
                        principalTable: "Notification",
                        principalColumn: "notification_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserNotification_User",
                        column: x => x.user_id,
                        principalTable: "User",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotificationUser_UsersUserId",
                table: "NotificationUser",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNotification_notification_id",
                table: "UserNotification",
                column: "notification_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotificationUser");

            migrationBuilder.DropTable(
                name: "UserNotification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notification",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "related_id",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "type",
                table: "Notification");

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "Notification",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "message",
                table: "Notification",
                type: "varchar(max)",
                unicode: false,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "Notification",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "notification_id",
                table: "Notification",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValueSql: "(newid())",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK__Notifica__E059842FEA1D001E",
                table: "Notification",
                column: "notification_id");

            migrationBuilder.CreateTable(
                name: "Receive",
                columns: table => new
                {
                    notification_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    user_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Receive__0BC2675F6B31FA1F", x => new { x.notification_id, x.user_id });
                    table.ForeignKey(
                        name: "FK_Receive_Notif",
                        column: x => x.notification_id,
                        principalTable: "Notification",
                        principalColumn: "notification_id");
                    table.ForeignKey(
                        name: "FK_Receive_User",
                        column: x => x.user_id,
                        principalTable: "User",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receive_user_id",
                table: "Receive",
                column: "user_id");
        }
    }
}
