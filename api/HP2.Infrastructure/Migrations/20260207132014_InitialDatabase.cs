using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    building_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Building__9C9FBF7FE50B0CAC", x => x.building_id);
                });

            migrationBuilder.CreateTable(
                name: "ChangeStatus",
                columns: table => new
                {
                    change_status_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    label = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChangeSt__A56D1762FE15A3C1", x => x.change_status_id);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    course_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Course__8F1EF7AEBDCFF738", x => x.course_id);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    notification_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    message = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Notifica__E059842FEA1D001E", x => x.notification_id);
                });

            migrationBuilder.CreateTable(
                name: "Program",
                columns: table => new
                {
                    program_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    field = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Program__3A7890ACB88F30E8", x => x.program_id);
                });

            migrationBuilder.CreateTable(
                name: "RoomType",
                columns: table => new
                {
                    room_type_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RoomType__42395E843B585784", x => x.room_type_id);
                });

            migrationBuilder.CreateTable(
                name: "SessionStatus",
                columns: table => new
                {
                    session_status_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    label = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SessionS__2155C5FD91FDE861", x => x.session_status_id);
                });

            migrationBuilder.CreateTable(
                name: "SessionType",
                columns: table => new
                {
                    session_type_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    label = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SessionT__FDFD72DC103257F8", x => x.session_type_id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherTitle",
                columns: table => new
                {
                    teacher_title_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TeacherT__E0AD9FB30F212BF5", x => x.teacher_title_id);
                });

            migrationBuilder.CreateTable(
                name: "UnavailableDayType",
                columns: table => new
                {
                    unavailable_day_type_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Unavaila__A069F8F805C63049", x => x.unavailable_day_type_id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    user_role_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserRole__B8D9ABA28E202902", x => x.user_role_id);
                });

            migrationBuilder.CreateTable(
                name: "WeekDay",
                columns: table => new
                {
                    weekday_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    order_index = table.Column<byte>(type: "tinyint", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__WeekDay__A22693C27BF1A566", x => x.weekday_id);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    room_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    room_number = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    is_available = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    capacity = table.Column<int>(type: "int", nullable: false),
                    building_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    room_type_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Room__19675A8A523A40B4", x => x.room_id);
                    table.ForeignKey(
                        name: "FK_Room_Building",
                        column: x => x.building_id,
                        principalTable: "Building",
                        principalColumn: "building_id");
                    table.ForeignKey(
                        name: "FK_Room_Type",
                        column: x => x.room_type_id,
                        principalTable: "RoomType",
                        principalColumn: "room_type_id");
                });

            migrationBuilder.CreateTable(
                name: "UnavailableDay",
                columns: table => new
                {
                    unavailable_day_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    start_date = table.Column<DateTime>(type: "date", nullable: false),
                    end_date = table.Column<DateTime>(type: "date", nullable: false),
                    start_time = table.Column<TimeSpan>(type: "time", nullable: false),
                    end_time = table.Column<TimeSpan>(type: "time", nullable: false),
                    unavailable_day_type_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Unavaila__C40999EABBDBA6A9", x => x.unavailable_day_id);
                    table.ForeignKey(
                        name: "FK_Unavail_Type",
                        column: x => x.unavailable_day_type_id,
                        principalTable: "UnavailableDayType",
                        principalColumn: "unavailable_day_type_id");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    last_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    first_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    phone_number = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    user_role_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__User__B9BE370F14AAA68A", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_User_Role",
                        column: x => x.user_role_id,
                        principalTable: "UserRole",
                        principalColumn: "user_role_id");
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    session_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    date = table.Column<DateTime>(type: "date", nullable: false),
                    start_time = table.Column<TimeSpan>(type: "time", nullable: false),
                    end_time = table.Column<TimeSpan>(type: "time", nullable: false),
                    mode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    session_type_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    course_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    session_status_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    room_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Session__69B13FDCA8536546", x => x.session_id);
                    table.ForeignKey(
                        name: "FK_Session_Course",
                        column: x => x.course_id,
                        principalTable: "Course",
                        principalColumn: "course_id");
                    table.ForeignKey(
                        name: "FK_Session_Room",
                        column: x => x.room_id,
                        principalTable: "Room",
                        principalColumn: "room_id");
                    table.ForeignKey(
                        name: "FK_Session_Status",
                        column: x => x.session_status_id,
                        principalTable: "SessionStatus",
                        principalColumn: "session_status_id");
                    table.ForeignKey(
                        name: "FK_Session_Type",
                        column: x => x.session_type_id,
                        principalTable: "SessionType",
                        principalColumn: "session_type_id");
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Admin__B9BE370F05D6D465", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_Admin_User",
                        column: x => x.user_id,
                        principalTable: "User",
                        principalColumn: "user_id");
                });

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

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    registration_number = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    teacher_title_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Teacher__B9BE370F6574A8CD", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_Teacher_Title",
                        column: x => x.teacher_title_id,
                        principalTable: "TeacherTitle",
                        principalColumn: "teacher_title_id");
                    table.ForeignKey(
                        name: "FK_Teacher_User",
                        column: x => x.user_id,
                        principalTable: "User",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateTable(
                name: "Availability",
                columns: table => new
                {
                    availability_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    start_date = table.Column<DateTime>(type: "date", nullable: false),
                    end_date = table.Column<DateTime>(type: "date", nullable: false),
                    weekday_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    start_time = table.Column<TimeSpan>(type: "time", nullable: false),
                    end_time = table.Column<TimeSpan>(type: "time", nullable: false),
                    teacher_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Availabi__86E3A8015B49D583", x => x.availability_id);
                    table.ForeignKey(
                        name: "FK_Avail_Teacher",
                        column: x => x.teacher_id,
                        principalTable: "Teacher",
                        principalColumn: "user_id");
                    table.ForeignKey(
                        name: "FK_Avail_Weekday",
                        column: x => x.weekday_id,
                        principalTable: "WeekDay",
                        principalColumn: "weekday_id");
                });

            migrationBuilder.CreateTable(
                name: "SessionChange",
                columns: table => new
                {
                    session_change_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    change_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    reason = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    teacher_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    admin_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    session_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    change_status_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Teach",
                columns: table => new
                {
                    session_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    teacher_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Teach__998BD8AB8CF334DE", x => new { x.session_id, x.teacher_id });
                    table.ForeignKey(
                        name: "FK_Teach_Session",
                        column: x => x.session_id,
                        principalTable: "Session",
                        principalColumn: "session_id");
                    table.ForeignKey(
                        name: "FK_Teach_Teacher",
                        column: x => x.teacher_id,
                        principalTable: "Teacher",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateTable(
                name: "Track",
                columns: table => new
                {
                    track_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    teacher_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    program_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Track__24ECC82E86A583BD", x => x.track_id);
                    table.ForeignKey(
                        name: "FK_Track_Program",
                        column: x => x.program_id,
                        principalTable: "Program",
                        principalColumn: "program_id");
                    table.ForeignKey(
                        name: "FK_Track_Teacher",
                        column: x => x.teacher_id,
                        principalTable: "Teacher",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateTable(
                name: "Assign",
                columns: table => new
                {
                    track_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    course_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    hourly_volume = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Assign__DC1D2754232CB863", x => new { x.track_id, x.course_id });
                    table.ForeignKey(
                        name: "FK_Assign_Course",
                        column: x => x.course_id,
                        principalTable: "Course",
                        principalColumn: "course_id");
                    table.ForeignKey(
                        name: "FK_Assign_Track",
                        column: x => x.track_id,
                        principalTable: "Track",
                        principalColumn: "track_id");
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    group_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    academic_year = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    track_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Group__D57795A032F181A4", x => x.group_id);
                    table.ForeignKey(
                        name: "FK_Group_Track",
                        column: x => x.track_id,
                        principalTable: "Track",
                        principalColumn: "track_id");
                });

            migrationBuilder.CreateTable(
                name: "Attend",
                columns: table => new
                {
                    group_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    session_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Attend__03EC865D5035A816", x => new { x.group_id, x.session_id });
                    table.ForeignKey(
                        name: "FK_Attend_Group",
                        column: x => x.group_id,
                        principalTable: "Group",
                        principalColumn: "group_id");
                    table.ForeignKey(
                        name: "FK_Attend_Session",
                        column: x => x.session_id,
                        principalTable: "Session",
                        principalColumn: "session_id");
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    group_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Student__B9BE370F16202FD8", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_Student_Group",
                        column: x => x.group_id,
                        principalTable: "Group",
                        principalColumn: "group_id");
                    table.ForeignKey(
                        name: "FK_Student_User",
                        column: x => x.user_id,
                        principalTable: "User",
                        principalColumn: "user_id");
                });

            migrationBuilder.InsertData(
                table: "Building",
                columns: new[] { "building_id", "name" },
                values: new object[] { "2e79e28c-e7d5-27ea-f06e-6c6bb037b3d1", "Bâtiment A" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "course_id", "code", "name" },
                values: new object[,]
                {
                    { "014c457e-a48a-d25e-7781-d5e483cb3dd9", "DATA_BDD", "Bases de Données Avancées" },
                    { "02e0e667-183a-1225-d0ed-19fe4c25f963", "GEST_FIN", "Gestion Financière" },
                    { "03241339-1186-a90f-33bd-a9850f603619", "LANG_ANG", "Anglais" },
                    { "1cb2dee1-fb12-6e48-69ea-2be4c527cbf0", "PRO_MEM", "Rapport d'activité / Mémoire" },
                    { "24027d5d-e151-9a00-fd19-ac11d27b8189", "INFO_TECH", "Technologies Logicielles" },
                    { "2d4557a7-a48d-9926-3e2b-bc820396b11a", "INFO_SAD", "Systèmes et Applications Distribués" },
                    { "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", "INFO_COO", "Conception Orientée Objet de Logiciel" },
                    { "3448ddd0-694c-35d0-f117-7d5834e6ca81", "DATA_INNOV", "Implémentation du Projet Innovation" },
                    { "3b835d91-4f08-07ef-d4d5-575947097601", "INFO_RO", "Recherche Opérationnelle" },
                    { "49ba4385-063d-7b8d-5f3f-aa1c7f573747", "DATA_CRYPTO", "Cryptographie et Sécurité" },
                    { "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", "DATA_TER", "Travaux d'étude et de recherche (TER)" },
                    { "93b97065-831b-a4dc-8179-be986f0772b8", "INFO_ICL", "Ingénierie des Composants Logiciels" },
                    { "d059db13-ac91-760c-5bf7-6c442946e7bf", "DATA_ANALYSE", "Analyse de Données" },
                    { "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", "DATA_STATS", "Statistiques Appliquées aux Données" },
                    { "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", "GEST_DEV", "Développement Soutenable" },
                    { "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", "DROIT_CONT", "Droit des Contrats" },
                    { "f8c83971-d090-c665-8911-cd645e1a3c87", "PRO_STAGE", "Stage M1" }
                });

            migrationBuilder.InsertData(
                table: "Program",
                columns: new[] { "program_id", "field", "name" },
                values: new object[,]
                {
                    { "1c6c23e0-16b5-6208-2733-cf363a81e9d2", "Informatique & Gestion", "Master MIAGE" },
                    { "64cb6778-fd4f-ba09-1402-010a1e0e30ce", "Informatique Fondamentale & Appliquée", "Master Informatique" },
                    { "6fecdbc8-b9a0-3c82-511f-b30cc40fa9df", "Physique Fondamentale & Appliquée", "Master Physique" }
                });

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "room_type_id", "name" },
                values: new object[] { "2ebbc802-19e3-1c66-7809-e0126364f9f3", "Salle de TD" });

            migrationBuilder.InsertData(
                table: "SessionStatus",
                columns: new[] { "session_status_id", "label" },
                values: new object[] { "09de5696-05df-5b4a-ca95-666d0306b369", "Programmé" });

            migrationBuilder.InsertData(
                table: "SessionType",
                columns: new[] { "session_type_id", "label" },
                values: new object[] { "7f2d1749-7a62-0b12-0f4e-3b943af03674", "Cours Magistral" });

            migrationBuilder.InsertData(
                table: "TeacherTitle",
                columns: new[] { "teacher_title_id", "name" },
                values: new object[] { "025afe74-4e45-ca60-93e0-035aa84f648d", "Professeur" });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "user_role_id", "name" },
                values: new object[,]
                {
                    { "0a5d76e1-f1e4-946f-9f3c-d757a576d60e", "Admin" },
                    { "3eca46e4-1e66-8343-3f88-c667fd48550e", "Student" },
                    { "4c92966c-ae01-8e31-eb08-fa56e3a54d2a", "Teacher" }
                });

            migrationBuilder.InsertData(
                table: "WeekDay",
                columns: new[] { "weekday_id", "name", "order_index" },
                values: new object[] { "a1572cec-402d-a254-39ac-c88335d6d1d1", "Lundi", (byte)1 });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "room_id", "building_id", "capacity", "is_available", "room_number", "room_type_id" },
                values: new object[] { "02bcf600-5d44-cca7-8b68-e763b00a6339", "2e79e28c-e7d5-27ea-f06e-6c6bb037b3d1", 40, true, "A-102", "2ebbc802-19e3-1c66-7809-e0126364f9f3" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "user_id", "created_at", "email", "first_name", "last_name", "password", "phone_number", "user_role_id" },
                values: new object[,]
                {
                    { "3c22107c-0651-f328-9d16-c4eb18aed5c3", new DateTime(2026, 2, 7, 13, 20, 14, 189, DateTimeKind.Utc).AddTicks(2589), "admin@univ.fr", "System", "Admin", "admin123", "0000000000", "0a5d76e1-f1e4-946f-9f3c-d757a576d60e" },
                    { "455c6918-8f55-8171-e3b6-573e17977cfc", new DateTime(2026, 2, 7, 13, 20, 14, 189, DateTimeKind.Utc).AddTicks(2629), "marie.curie@univ.fr", "Marie", "Curie", "pass123", "0123456789", "4c92966c-ae01-8e31-eb08-fa56e3a54d2a" },
                    { "b49e8575-9a94-b93d-703c-1fc9cf200f96", new DateTime(2026, 2, 7, 13, 20, 14, 189, DateTimeKind.Utc).AddTicks(2931), "jean.dupont@etud.fr", "Jean", "Dupont", "pass_jean", "0987654321", "3eca46e4-1e66-8343-3f88-c667fd48550e" }
                });

            migrationBuilder.InsertData(
                table: "Admin",
                column: "user_id",
                value: "3c22107c-0651-f328-9d16-c4eb18aed5c3");

            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "session_id", "course_id", "date", "end_time", "mode", "room_id", "session_status_id", "session_type_id", "start_time" },
                values: new object[] { "5b7d0dd2-a75d-475e-0f03-d4d2b7f3c55f", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 2, 14, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "user_id", "registration_number", "teacher_title_id" },
                values: new object[] { "455c6918-8f55-8171-e3b6-573e17977cfc", "REG_001", "025afe74-4e45-ca60-93e0-035aa84f648d" });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "track_id", "name", "program_id", "teacher_id" },
                values: new object[,]
                {
                    { "16e8879d-d190-3771-1b74-ca91c2f021fe", "M2 Ingénierie Logicielle pour la Science des Données", "1c6c23e0-16b5-6208-2733-cf363a81e9d2", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "34d303a1-eecd-13ed-de46-36c8efe0f0d5", "M1 Ingénierie Logicielle pour la Science des Données - Apprentissage", "1c6c23e0-16b5-6208-2733-cf363a81e9d2", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "4a9d5b23-9f25-3816-a32e-0f206d9b4bb6", "M2 Artificial Intelligence", "64cb6778-fd4f-ba09-1402-010a1e0e30ce", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "4defa7f6-3ce5-c643-a522-861cf94ee2e7", "M1 Master parisien de recherche en Informatique (MPRI)", "64cb6778-fd4f-ba09-1402-010a1e0e30ce", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "5942bd81-7485-6e92-c7e6-66ad363c6bee", "M1 Artificial Intelligence", "64cb6778-fd4f-ba09-1402-010a1e0e30ce", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3", "M1 Ingénierie Logicielle pour la Science des Données", "1c6c23e0-16b5-6208-2733-cf363a81e9d2", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "86de5246-d552-d203-3cfb-450e00d82845", "M2 Informatique Décisionnelle - Apprentissage", "1c6c23e0-16b5-6208-2733-cf363a81e9d2", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "900f1499-bb04-690c-9394-eeafda3848a4", "M1 Computer and Network Systems", "64cb6778-fd4f-ba09-1402-010a1e0e30ce", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "b4f9989d-1aa6-eb1c-b68d-f02b595a4e91", "M1 Informatique Décisionnelle - Apprentissage", "1c6c23e0-16b5-6208-2733-cf363a81e9d2", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "ce0e0c1e-322e-f894-4476-dc9682a4bdea", "M2 Ingénierie Logicielle pour la Science des Données - Apprentissage", "1c6c23e0-16b5-6208-2733-cf363a81e9d2", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "e06ac778-10f0-5ca0-04e6-0df679676eb3", "M2 Computer and Network Systems (CNS) - Systèmes Autonomiques", "64cb6778-fd4f-ba09-1402-010a1e0e30ce", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "ec7f0b9a-dbe5-a250-41e3-d2857ef80ccf", "M2 Master parisien de recherche en Informatique (MPRI)", "64cb6778-fd4f-ba09-1402-010a1e0e30ce", "455c6918-8f55-8171-e3b6-573e17977cfc" }
                });

            migrationBuilder.InsertData(
                table: "Assign",
                columns: new[] { "course_id", "track_id", "hourly_volume" },
                values: new object[,]
                {
                    { "014c457e-a48a-d25e-7781-d5e483cb3dd9", "34d303a1-eecd-13ed-de46-36c8efe0f0d5", 36 },
                    { "02e0e667-183a-1225-d0ed-19fe4c25f963", "34d303a1-eecd-13ed-de46-36c8efe0f0d5", 36 },
                    { "03241339-1186-a90f-33bd-a9850f603619", "34d303a1-eecd-13ed-de46-36c8efe0f0d5", 18 },
                    { "1cb2dee1-fb12-6e48-69ea-2be4c527cbf0", "34d303a1-eecd-13ed-de46-36c8efe0f0d5", 0 },
                    { "24027d5d-e151-9a00-fd19-ac11d27b8189", "34d303a1-eecd-13ed-de46-36c8efe0f0d5", 36 },
                    { "2d4557a7-a48d-9926-3e2b-bc820396b11a", "34d303a1-eecd-13ed-de46-36c8efe0f0d5", 36 },
                    { "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", "34d303a1-eecd-13ed-de46-36c8efe0f0d5", 36 },
                    { "3448ddd0-694c-35d0-f117-7d5834e6ca81", "34d303a1-eecd-13ed-de46-36c8efe0f0d5", 18 },
                    { "3b835d91-4f08-07ef-d4d5-575947097601", "34d303a1-eecd-13ed-de46-36c8efe0f0d5", 36 },
                    { "49ba4385-063d-7b8d-5f3f-aa1c7f573747", "34d303a1-eecd-13ed-de46-36c8efe0f0d5", 36 },
                    { "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", "34d303a1-eecd-13ed-de46-36c8efe0f0d5", 18 },
                    { "93b97065-831b-a4dc-8179-be986f0772b8", "34d303a1-eecd-13ed-de46-36c8efe0f0d5", 36 },
                    { "d059db13-ac91-760c-5bf7-6c442946e7bf", "34d303a1-eecd-13ed-de46-36c8efe0f0d5", 36 },
                    { "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", "34d303a1-eecd-13ed-de46-36c8efe0f0d5", 36 },
                    { "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", "34d303a1-eecd-13ed-de46-36c8efe0f0d5", 12 },
                    { "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", "34d303a1-eecd-13ed-de46-36c8efe0f0d5", 36 },
                    { "014c457e-a48a-d25e-7781-d5e483cb3dd9", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3", 36 },
                    { "02e0e667-183a-1225-d0ed-19fe4c25f963", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3", 36 },
                    { "03241339-1186-a90f-33bd-a9850f603619", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3", 18 },
                    { "24027d5d-e151-9a00-fd19-ac11d27b8189", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3", 36 },
                    { "2d4557a7-a48d-9926-3e2b-bc820396b11a", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3", 36 },
                    { "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3", 36 },
                    { "3448ddd0-694c-35d0-f117-7d5834e6ca81", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3", 18 },
                    { "3b835d91-4f08-07ef-d4d5-575947097601", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3", 36 },
                    { "49ba4385-063d-7b8d-5f3f-aa1c7f573747", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3", 36 },
                    { "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3", 18 },
                    { "93b97065-831b-a4dc-8179-be986f0772b8", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3", 36 },
                    { "d059db13-ac91-760c-5bf7-6c442946e7bf", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3", 36 },
                    { "dd9ec16b-bbf2-e937-3ef4-059bf6b9091d", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3", 36 },
                    { "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3", 20 },
                    { "f4bf5287-38ea-e0ad-d6de-8c9aa20888a0", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3", 36 },
                    { "f8c83971-d090-c665-8911-cd645e1a3c87", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3", 0 }
                });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "group_id", "academic_year", "name", "track_id" },
                values: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "2025-2026", "Groupe A - M1 ILSD", "7e30cfbb-d683-d9c0-bbd0-e7bf86f6bcd3" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "user_id", "group_id" },
                values: new object[] { "b49e8575-9a94-b93d-703c-1fc9cf200f96", "57bf1149-8880-c27c-d603-3546214d03a8" });

            migrationBuilder.CreateIndex(
                name: "IX_Assign_course_id",
                table: "Assign",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_Attend_session_id",
                table: "Attend",
                column: "session_id");

            migrationBuilder.CreateIndex(
                name: "IX_Availability_teacher_id",
                table: "Availability",
                column: "teacher_id");

            migrationBuilder.CreateIndex(
                name: "IX_Availability_weekday_id",
                table: "Availability",
                column: "weekday_id");

            migrationBuilder.CreateIndex(
                name: "UQ__Building__72E12F1B5E0C81DB",
                table: "Building",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__ChangeSt__4823FDB21188E1FE",
                table: "ChangeStatus",
                column: "label",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Course__357D4CF979D2E3A3",
                table: "Course",
                column: "code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Group_track_id",
                table: "Group",
                column: "track_id");

            migrationBuilder.CreateIndex(
                name: "IX_Receive_user_id",
                table: "Receive",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_building_id",
                table: "Room",
                column: "building_id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_room_type_id",
                table: "Room",
                column: "room_type_id");

            migrationBuilder.CreateIndex(
                name: "UQ__Room__FE22F61BA8D6C767",
                table: "Room",
                column: "room_number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__RoomType__72E12F1BD83CFC8E",
                table: "RoomType",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Session_course_id",
                table: "Session",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_Session_room_id",
                table: "Session",
                column: "room_id");

            migrationBuilder.CreateIndex(
                name: "IX_Session_session_status_id",
                table: "Session",
                column: "session_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_Session_session_type_id",
                table: "Session",
                column: "session_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionChange_admin_id",
                table: "SessionChange",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionChange_change_status_id",
                table: "SessionChange",
                column: "change_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionChange_session_id",
                table: "SessionChange",
                column: "session_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionChange_teacher_id",
                table: "SessionChange",
                column: "teacher_id");

            migrationBuilder.CreateIndex(
                name: "UQ__SessionS__4823FDB2F2E6150E",
                table: "SessionStatus",
                column: "label",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__SessionT__4823FDB29B0B4B02",
                table: "SessionType",
                column: "label",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_group_id",
                table: "Student",
                column: "group_id");

            migrationBuilder.CreateIndex(
                name: "IX_Teach_teacher_id",
                table: "Teach",
                column: "teacher_id");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_teacher_title_id",
                table: "Teacher",
                column: "teacher_title_id");

            migrationBuilder.CreateIndex(
                name: "UQ__Teacher__125DB2A3F2E1D6C6",
                table: "Teacher",
                column: "registration_number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__TeacherT__72E12F1B2FE6B18C",
                table: "TeacherTitle",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Track_program_id",
                table: "Track",
                column: "program_id");

            migrationBuilder.CreateIndex(
                name: "IX_Track_teacher_id",
                table: "Track",
                column: "teacher_id");

            migrationBuilder.CreateIndex(
                name: "IX_UnavailableDay_unavailable_day_type_id",
                table: "UnavailableDay",
                column: "unavailable_day_type_id");

            migrationBuilder.CreateIndex(
                name: "UQ__Unavaila__72E12F1BF8500212",
                table: "UnavailableDayType",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_user_role_id",
                table: "User",
                column: "user_role_id");

            migrationBuilder.CreateIndex(
                name: "UQ__User__AB6E6164E818E98E",
                table: "User",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__UserRole__72E12F1B2D3E741A",
                table: "UserRole",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__WeekDay__72E12F1B20DB09AA",
                table: "WeekDay",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__WeekDay__BB0767F6AAD89115",
                table: "WeekDay",
                column: "order_index",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assign");

            migrationBuilder.DropTable(
                name: "Attend");

            migrationBuilder.DropTable(
                name: "Availability");

            migrationBuilder.DropTable(
                name: "Receive");

            migrationBuilder.DropTable(
                name: "SessionChange");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Teach");

            migrationBuilder.DropTable(
                name: "UnavailableDay");

            migrationBuilder.DropTable(
                name: "WeekDay");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "ChangeStatus");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "UnavailableDayType");

            migrationBuilder.DropTable(
                name: "Track");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "SessionStatus");

            migrationBuilder.DropTable(
                name: "SessionType");

            migrationBuilder.DropTable(
                name: "Program");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Building");

            migrationBuilder.DropTable(
                name: "RoomType");

            migrationBuilder.DropTable(
                name: "TeacherTitle");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserRole");
        }
    }
}
