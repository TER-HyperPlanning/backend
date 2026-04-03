using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class TerHyperplanningContext : DbContext
{
    public TerHyperplanningContext()
    {
    }

    public TerHyperplanningContext(DbContextOptions<TerHyperplanningContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Assign> Assigns { get; set; }

    public virtual DbSet<Availability> Availabilities { get; set; }

    public virtual DbSet<Building> Buildings { get; set; }

    public virtual DbSet<ChangeStatus> ChangeStatuses { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Program> Programs { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<RoomType> RoomTypes { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

    public virtual DbSet<SessionChange> SessionChanges { get; set; }

    public virtual DbSet<SessionStatus> SessionStatuses { get; set; }

    public virtual DbSet<SessionType> SessionTypes { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<TeacherTitle> TeacherTitles { get; set; }

    public virtual DbSet<Track> Tracks { get; set; }

    public virtual DbSet<UnavailableDay> UnavailableDays { get; set; }

    public virtual DbSet<UnavailableDayType> UnavailableDayTypes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<WeekDay> WeekDays { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Name=ConnectionStrings:LocalConnection");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Admin__B9BE370F05D6D465");

            entity.ToTable("Admin");

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithOne(p => p.Admin)
                .HasForeignKey<Admin>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Admin_User");
        });

        modelBuilder.Entity<Assign>(entity =>
        {
            entity.HasKey(e => new { e.TrackId, e.CourseId }).HasName("PK__Assign__DC1D2754232CB863");

            entity.ToTable("Assign");

            entity.Property(e => e.TrackId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("track_id");
            entity.Property(e => e.CourseId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("course_id");
            entity.Property(e => e.HourlyVolume).HasColumnName("hourly_volume");

            entity.HasOne(d => d.Course).WithMany(p => p.Assigns)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assign_Course");

            entity.HasOne(d => d.Track).WithMany(p => p.Assigns)
                .HasForeignKey(d => d.TrackId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assign_Track");
        });

        modelBuilder.Entity<Availability>(entity =>
        {
            entity.HasKey(e => e.AvailabilityId).HasName("PK__Availabi__86E3A8015B49D583");

            entity.ToTable("Availability");

            entity.Property(e => e.AvailabilityId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("availability_id");
            entity.Property(e => e.EndDate)
                .HasColumnType("date")
                .HasColumnName("end_date");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("start_date");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.TeacherId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("teacher_id");
            entity.Property(e => e.WeekdayId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("weekday_id");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Availabilities)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Avail_Teacher");

            entity.HasOne(d => d.Weekday).WithMany(p => p.Availabilities)
                .HasForeignKey(d => d.WeekdayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Avail_Weekday");
        });

        modelBuilder.Entity<Building>(entity =>
        {
            entity.HasKey(e => e.BuildingId).HasName("PK__Building__9C9FBF7FE50B0CAC");

            entity.ToTable("Building");

            entity.HasIndex(e => e.Name, "UQ__Building__72E12F1B5E0C81DB").IsUnique();

            entity.Property(e => e.BuildingId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("building_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ChangeStatus>(entity =>
        {
            entity.HasKey(e => e.ChangeStatusId).HasName("PK__ChangeSt__A56D1762FE15A3C1");

            entity.ToTable("ChangeStatus");

            entity.HasIndex(e => e.Label, "UQ__ChangeSt__4823FDB21188E1FE").IsUnique();

            entity.Property(e => e.ChangeStatusId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("change_status_id");
            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("label");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__Course__8F1EF7AEBDCFF738");

            entity.ToTable("Course");

            entity.HasIndex(e => e.Code, "UQ__Course__357D4CF979D2E3A3").IsUnique();

            entity.Property(e => e.CourseId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("course_id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK__Group__D57795A032F181A4");

            entity.ToTable("Group");

            entity.Property(e => e.GroupId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("group_id");
            entity.Property(e => e.AcademicYear)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("academic_year");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.TrackId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("track_id");

            entity.HasOne(d => d.Track).WithMany(p => p.Groups)
                .HasForeignKey(d => d.TrackId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Group_Track");

            entity.HasMany(d => d.Sessions).WithMany(p => p.Groups)
                .UsingEntity<Dictionary<string, object>>(
                    "Attend",
                    r => r.HasOne<Session>().WithMany()
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Attend_Session"),
                    l => l.HasOne<Group>().WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Attend_Group"),
                    j =>
                    {
                        j.HasKey("GroupId", "SessionId").HasName("PK__Attend__03EC865D5035A816");
                        j.ToTable("Attend");
                        j.IndexerProperty<string>("GroupId")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("group_id");
                        j.IndexerProperty<string>("SessionId")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("session_id");
                    });
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PK__Notifica__E059842FEA1D001E");

            entity.ToTable("Notification");

            entity.Property(e => e.NotificationId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("notification_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Message)
                .IsUnicode(false)
                .HasColumnName("message");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("title");

            entity.HasMany(d => d.Users).WithMany(p => p.Notifications)
                .UsingEntity<Dictionary<string, object>>(
                    "Receive",
                    r => r.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Receive_User"),
                    l => l.HasOne<Notification>().WithMany()
                        .HasForeignKey("NotificationId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Receive_Notif"),
                    j =>
                    {
                        j.HasKey("NotificationId", "UserId").HasName("PK__Receive__0BC2675F6B31FA1F");
                        j.ToTable("Receive");
                        j.IndexerProperty<string>("NotificationId")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("notification_id");
                        j.IndexerProperty<string>("UserId")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("user_id");
                    });
        });

        modelBuilder.Entity<Program>(entity =>
        {
            entity.HasKey(e => e.ProgramId).HasName("PK__Program__3A7890ACB88F30E8");

            entity.ToTable("Program");

            entity.Property(e => e.ProgramId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("program_id");
            entity.Property(e => e.Field)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("field");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK__Room__19675A8A523A40B4");

            entity.ToTable("Room");

            entity.HasIndex(e => e.RoomNumber, "UQ__Room__FE22F61BA8D6C767").IsUnique();

            entity.Property(e => e.RoomId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("room_id");
            entity.Property(e => e.BuildingId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("building_id");
            entity.Property(e => e.Capacity).HasColumnName("capacity");
            entity.Property(e => e.IsAvailable)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_available");
            entity.Property(e => e.RoomNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("room_number");
            entity.Property(e => e.RoomTypeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("room_type_id");

            entity.HasOne(d => d.Building).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.BuildingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Room_Building");

            entity.HasOne(d => d.RoomType).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.RoomTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Room_Type");
        });

        modelBuilder.Entity<RoomType>(entity =>
        {
            entity.HasKey(e => e.RoomTypeId).HasName("PK__RoomType__42395E843B585784");

            entity.ToTable("RoomType");

            entity.HasIndex(e => e.Name, "UQ__RoomType__72E12F1BD83CFC8E").IsUnique();

            entity.Property(e => e.RoomTypeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("room_type_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasName("PK__Session__69B13FDCA8536546");

            entity.ToTable("Session");

            entity.Property(e => e.SessionId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("session_id");
            entity.Property(e => e.CourseId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("course_id");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.Mode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mode");
            entity.Property(e => e.RoomId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("room_id");
            entity.Property(e => e.SessionStatusId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("session_status_id");
            entity.Property(e => e.SessionTypeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("session_type_id");
            entity.Property(e => e.StartTime).HasColumnName("start_time");

            entity.HasOne(d => d.Course).WithMany(p => p.Sessions)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Session_Course");

            entity.HasOne(d => d.Room).WithMany(p => p.Sessions)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Session_Room");

            entity.HasOne(d => d.SessionStatus).WithMany(p => p.Sessions)
                .HasForeignKey(d => d.SessionStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Session_Status");

            entity.HasOne(d => d.SessionType).WithMany(p => p.Sessions)
                .HasForeignKey(d => d.SessionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Session_Type");

            entity.HasMany(d => d.Teachers).WithMany(p => p.Sessions)
                .UsingEntity<Dictionary<string, object>>(
                    "Teach",
                    r => r.HasOne<Teacher>().WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Teach_Teacher"),
                    l => l.HasOne<Session>().WithMany()
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Teach_Session"),
                    j =>
                    {
                        j.HasKey("SessionId", "TeacherId").HasName("PK__Teach__998BD8AB8CF334DE");
                        j.ToTable("Teach");
                        j.IndexerProperty<string>("SessionId")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("session_id");
                        j.IndexerProperty<string>("TeacherId")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("teacher_id");
                    });
        });

        modelBuilder.Entity<SessionChange>(entity =>
        {
            entity.HasKey(e => e.SessionChangeId).HasName("PK__SessionC__D5E31D8F21E5A4A9");

            entity.ToTable("SessionChange");

            entity.Property(e => e.SessionChangeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("session_change_id");
            entity.Property(e => e.AdminId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("admin_id");
            entity.Property(e => e.ChangeDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("change_date");
            entity.Property(e => e.ChangeStatusId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("change_status_id");
            entity.Property(e => e.Reason)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.SessionId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("session_id");
            entity.Property(e => e.TeacherId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("teacher_id");

            entity.HasOne(d => d.Admin).WithMany(p => p.SessionChanges)
                .HasForeignKey(d => d.AdminId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Change_Admin");

            entity.HasOne(d => d.ChangeStatus).WithMany(p => p.SessionChanges)
                .HasForeignKey(d => d.ChangeStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Change_Status");

            entity.HasOne(d => d.Session).WithMany(p => p.SessionChanges)
                .HasForeignKey(d => d.SessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Change_Session");

            entity.HasOne(d => d.Teacher).WithMany(p => p.SessionChanges)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Change_Teacher");
        });

        modelBuilder.Entity<SessionStatus>(entity =>
        {
            entity.HasKey(e => e.SessionStatusId).HasName("PK__SessionS__2155C5FD91FDE861");

            entity.ToTable("SessionStatus");

            entity.HasIndex(e => e.Label, "UQ__SessionS__4823FDB2F2E6150E").IsUnique();

            entity.Property(e => e.SessionStatusId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("session_status_id");
            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("label");
        });

        modelBuilder.Entity<SessionType>(entity =>
        {
            entity.HasKey(e => e.SessionTypeId).HasName("PK__SessionT__FDFD72DC103257F8");

            entity.ToTable("SessionType");

            entity.HasIndex(e => e.Label, "UQ__SessionT__4823FDB29B0B4B02").IsUnique();

            entity.Property(e => e.SessionTypeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("session_type_id");
            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("label");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Student__B9BE370F16202FD8");

            entity.ToTable("Student");

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.GroupId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("group_id");

            entity.HasOne(d => d.Group).WithMany(p => p.Students)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Group");

            entity.HasOne(d => d.User).WithOne(p => p.Student)
                .HasForeignKey<Student>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_User");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Teacher__B9BE370F6574A8CD");

            entity.ToTable("Teacher");

            entity.HasIndex(e => e.RegistrationNumber, "UQ__Teacher__125DB2A3F2E1D6C6").IsUnique();

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.RegistrationNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("registration_number");
            entity.Property(e => e.TeacherTitleId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("teacher_title_id");

            entity.HasOne(d => d.TeacherTitle).WithMany(p => p.Teachers)
                .HasForeignKey(d => d.TeacherTitleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Teacher_Title");

            entity.HasOne(d => d.User).WithOne(p => p.Teacher)
                .HasForeignKey<Teacher>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Teacher_User");
        });

        modelBuilder.Entity<TeacherTitle>(entity =>
        {
            entity.HasKey(e => e.TeacherTitleId).HasName("PK__TeacherT__E0AD9FB30F212BF5");

            entity.ToTable("TeacherTitle");

            entity.HasIndex(e => e.Name, "UQ__TeacherT__72E12F1B2FE6B18C").IsUnique();

            entity.Property(e => e.TeacherTitleId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("teacher_title_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Track>(entity =>
        {
            entity.HasKey(e => e.TrackId).HasName("PK__Track__24ECC82E86A583BD");

            entity.ToTable("Track");

            entity.Property(e => e.TrackId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("track_id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.ProgramId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("program_id");
            entity.Property(e => e.TeacherId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("teacher_id");

            entity.HasOne(d => d.Program).WithMany(p => p.Tracks)
                .HasForeignKey(d => d.ProgramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Track_Program");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Tracks)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Track_Teacher");
        });

        modelBuilder.Entity<UnavailableDay>(entity =>
        {
            entity.HasKey(e => e.UnavailableDayId).HasName("PK__Unavaila__C40999EABBDBA6A9");

            entity.ToTable("UnavailableDay");

            entity.Property(e => e.UnavailableDayId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("unavailable_day_id");
            entity.Property(e => e.EndDate)
                .HasColumnType("date")
                .HasColumnName("end_date");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("start_date");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.UnavailableDayTypeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unavailable_day_type_id");

            entity.HasOne(d => d.UnavailableDayType).WithMany(p => p.UnavailableDays)
                .HasForeignKey(d => d.UnavailableDayTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Unavail_Type");
        });

        modelBuilder.Entity<UnavailableDayType>(entity =>
        {
            entity.HasKey(e => e.UnavailableDayTypeId).HasName("PK__Unavaila__A069F8F805C63049");

            entity.ToTable("UnavailableDayType");

            entity.HasIndex(e => e.Name, "UQ__Unavaila__72E12F1BF8500212").IsUnique();

            entity.Property(e => e.UnavailableDayTypeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("unavailable_day_type_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__B9BE370F14AAA68A");

            entity.ToTable("User");

            entity.HasIndex(e => e.Email, "UQ__User__AB6E6164E818E98E").IsUnique();

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("user_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone_number");
            entity.Property(e => e.UserRoleId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_role_id");

            entity.HasOne(d => d.UserRole).WithMany(p => p.Users)
                .HasForeignKey(d => d.UserRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Role");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.UserRoleId).HasName("PK__UserRole__B8D9ABA28E202902");

            entity.ToTable("UserRole");

            entity.HasIndex(e => e.Name, "UQ__UserRole__72E12F1B2D3E741A").IsUnique();

            entity.Property(e => e.UserRoleId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("user_role_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<WeekDay>(entity =>
        {
            entity.HasKey(e => e.WeekdayId).HasName("PK__WeekDay__A22693C27BF1A566");

            entity.ToTable("WeekDay");

            entity.HasIndex(e => e.Name, "UQ__WeekDay__72E12F1B20DB09AA").IsUnique();

            entity.HasIndex(e => e.OrderIndex, "UQ__WeekDay__BB0767F6AAD89115").IsUnique();

            entity.Property(e => e.WeekdayId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("weekday_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.OrderIndex).HasColumnName("order_index");
        });

        // Seed initial data
        SeedData(modelBuilder);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    // -- Seed Data Part --
    private void SeedData(ModelBuilder modelBuilder)
    {
        // Fixed IDs for referential integrity
        var adminUserId = GetStableId("user-admin");
        var teacherUserId = GetStableId("user-marie-curie");
        var studentUserId = GetStableId("user-jean-dupont");
        var teacherUserId2 = GetStableId("user-alain-durand");
        var teacherUserId3 = GetStableId("user-sophie-lambert");
        var teacherUserId4 = GetStableId("user-karim-benali");
        var teacherUserId5 = GetStableId("user-claire-morel");
        var teacherUserId6 = GetStableId("user-thomas-renault");

        var studentUserId01 = GetStableId("user-student-01");
        var studentUserId02 = GetStableId("user-student-02");
        var studentUserId03 = GetStableId("user-student-03");
        var studentUserId04 = GetStableId("user-student-04");
        var studentUserId05 = GetStableId("user-student-05");
        var studentUserId06 = GetStableId("user-student-06");
        var studentUserId07 = GetStableId("user-student-07");
        var studentUserId08 = GetStableId("user-student-08");
        var studentUserId09 = GetStableId("user-student-09");
        var studentUserId10 = GetStableId("user-student-10");
        var studentUserId11 = GetStableId("user-student-11");
        var studentUserId12 = GetStableId("user-student-12");
        var studentUserId13 = GetStableId("user-student-13");
        var studentUserId14 = GetStableId("user-student-14");
        var studentUserId15 = GetStableId("user-student-15");
        var studentUserId16 = GetStableId("user-student-16");
        var studentUserId17 = GetStableId("user-student-17");
        var studentUserId18 = GetStableId("user-student-18");
        var studentUserId19 = GetStableId("user-student-19");
        var studentUserId20 = GetStableId("user-student-20");
        var studentUserId21 = GetStableId("user-student-21");
        var studentUserId22 = GetStableId("user-student-22");
        var studentUserId23 = GetStableId("user-student-23");
        var studentUserId24 = GetStableId("user-student-24");
        var studentUserId25 = GetStableId("user-student-25");
        var studentUserId26 = GetStableId("user-student-26");
        var studentUserId27 = GetStableId("user-student-27");
        var studentUserId28 = GetStableId("user-student-28");
        var studentUserId29 = GetStableId("user-student-29");
        var studentUserId30 = GetStableId("user-student-30");

        var programId = GetStableId("prog-cs");
        var trackM1_ID_App = GetStableId("track-m1-id-app");
        var trackM1_ILSD_App = GetStableId("track-m1-ilsd-app");
        var trackM1_ILSD_Init = GetStableId("track-m1-ilsd-init");

        var trackM2_ID_App = GetStableId("track-m2-id-app");
        var trackM2_ILSD_App = GetStableId("track-m2-ilsd-app");
        var trackM2_ILSD_Init = GetStableId("track-m2-ilsd-init");

        var groupId_M1_ILSD = GetStableId("group-m1-ilsd-init-a");

        // --- NOUVEAU PROGRAMME : MASTER INFORMATIQUE ---
        var programInfoId = GetStableId("prog-informatique");

        var trackM1_AI = GetStableId("track-m1-ai");
        var trackM1_CNS = GetStableId("track-m1-cns");
        var trackM1_MPRI = GetStableId("track-m1-mpri");

        var trackM2_AI = GetStableId("track-m2-ai");
        var trackM2_CNS = GetStableId("track-m2-cns");

        // --- COURS IDS ---
        var c_sad = GetStableId("c-sad"); // Systèmes et Applications Distribués
        var c_coo = GetStableId("c-coo"); // Conception Orientée Objet
        var c_icl = GetStableId("c-icl"); // Ingénierie des Composants Logiciels
        var c_tech = GetStableId("c-tech"); // Technologies logicielles
        var c_ro = GetStableId("c-ro"); // Recherche opérationnelle
        var c_fin = GetStableId("c-fin"); // Gestion financière
        var c_droit = GetStableId("c-droit"); // Droit des contrats
        var c_dev = GetStableId("c-dev"); // Développement soutenable
        var c_ang = GetStableId("c-ang"); // Anglais
        var c_stage = GetStableId("c-stage"); // Stage M1
        var c_mem = GetStableId("c-mem"); // Mémoire
        var c_crypto = GetStableId("c-crypto"); // Cryptographie
        var c_bdd = GetStableId("c-bdd"); // BDD Avancées
        var c_stats = GetStableId("c-stats"); // Stats Appliquées
        var c_ter = GetStableId("c-ter"); // TER
        var c_data = GetStableId("c-data"); // Analyse de données
        var c_innov = GetStableId("c-innov"); // Projet Innovation

        var buildingId = GetStableId("bld-A");
        var roomTypeId = GetStableId("rt-td");
        var roomId = GetStableId("room-a102");

        var sessionTypeId = GetStableId("st-cm");
        var sessionTypeTdId = GetStableId("st-td");
        var sessionTypeTpId = GetStableId("st-tp");
        var sessionStatusId = GetStableId("ss-scheduled");

        var teacherTitleId = GetStableId("tt-prof");
        var sessionId = GetStableId("session-001");
        var sessionId2 = GetStableId("session-002");
        var sessionId3 = GetStableId("session-003");
        var sessionId4 = GetStableId("session-004");
        var sessionId5 = GetStableId("session-005");
        var sessionId6 = GetStableId("session-006");

        var wdMondayId = GetStableId("wd-monday");
        var wdTuesdayId = GetStableId("wd-tuesday");
        var wdWednesdayId = GetStableId("wd-wednesday");
        var wdThursdayId = GetStableId("wd-thursday");
        var wdFridayId = GetStableId("wd-friday");
        var wdSaturdayId = GetStableId("wd-saturday");
        var wdSundayId = GetStableId("wd-sunday");

        // User Role IDs
        var roleAdminId = GetStableId("role-admin");
        var roleTeacherId = GetStableId("role-teacher");
        var roleStudentId = GetStableId("role-student");

        // ========================================
        // 1. TABLES DE RÉFÉRENCE (sans dépendances)
        // ========================================

        // UserRoles (TOUJOURS EN PREMIER - requis par User)
        modelBuilder.Entity<UserRole>().HasData(
            new UserRole { UserRoleId = roleAdminId, Name = "Admin" },
            new UserRole { UserRoleId = roleTeacherId, Name = "Teacher" },
            new UserRole { UserRoleId = roleStudentId, Name = "Student" }
        );

        // Buildings (requis par Room)
        modelBuilder.Entity<Building>().HasData(
            new Building { BuildingId = buildingId, Name = "Bâtiment A" }
        );

        // RoomTypes (requis par Room)
        modelBuilder.Entity<RoomType>().HasData(
            new RoomType { RoomTypeId = roomTypeId, Name = "Salle de TD" }
        );

        // Rooms (requis par Session)
        modelBuilder.Entity<Room>().HasData(
            new Room
            {
                RoomId = roomId,
                RoomNumber = "A-102",
                Capacity = 40,
                IsAvailable = true,
                BuildingId = buildingId,
                RoomTypeId = roomTypeId
            }
        );

        // Courses (requis par Session et Assign)
        modelBuilder.Entity<Course>().HasData(
            new Course { CourseId = c_sad, Name = "Systèmes et Applications Distribués", Code = "INFO_SAD" },
            new Course { CourseId = c_coo, Name = "Conception Orientée Objet de Logiciel", Code = "INFO_COO" },
            new Course { CourseId = c_icl, Name = "Ingénierie des Composants Logiciels", Code = "INFO_ICL" },
            new Course { CourseId = c_tech, Name = "Technologies Logicielles", Code = "INFO_TECH" },
            new Course { CourseId = c_ro, Name = "Recherche Opérationnelle", Code = "INFO_RO" },
            new Course { CourseId = c_fin, Name = "Gestion Financière", Code = "GEST_FIN" },
            new Course { CourseId = c_droit, Name = "Droit des Contrats", Code = "DROIT_CONT" },
            new Course { CourseId = c_dev, Name = "Développement Soutenable", Code = "GEST_DEV" },
            new Course { CourseId = c_ang, Name = "Anglais", Code = "LANG_ANG" },
            new Course { CourseId = c_stage, Name = "Stage M1", Code = "PRO_STAGE" },
            new Course { CourseId = c_mem, Name = "Rapport d'activité / Mémoire", Code = "PRO_MEM" },
            new Course { CourseId = c_crypto, Name = "Cryptographie et Sécurité", Code = "DATA_CRYPTO" },
            new Course { CourseId = c_bdd, Name = "Bases de Données Avancées", Code = "DATA_BDD" },
            new Course { CourseId = c_stats, Name = "Statistiques Appliquées aux Données", Code = "DATA_STATS" },
            new Course { CourseId = c_ter, Name = "Travaux d'étude et de recherche (TER)", Code = "DATA_TER" },
            new Course { CourseId = c_data, Name = "Analyse de Données", Code = "DATA_ANALYSE" },
            new Course { CourseId = c_innov, Name = "Implémentation du Projet Innovation", Code = "DATA_INNOV" }
        );

        // SessionTypes (requis par Session)
        modelBuilder.Entity<SessionType>().HasData(
            new SessionType { SessionTypeId = sessionTypeId, Label = "CM" },
            new SessionType { SessionTypeId = sessionTypeTdId, Label = "TD" },
            new SessionType { SessionTypeId = sessionTypeTpId, Label = "TP" }
        );

        // SessionStatus (requis par Session)
        modelBuilder.Entity<SessionStatus>().HasData(
            new SessionStatus { SessionStatusId = sessionStatusId, Label = "Programmé" }
        );

        // TeacherTitles (requis par Teacher)
        modelBuilder.Entity<TeacherTitle>().HasData(
            new TeacherTitle { TeacherTitleId = teacherTitleId, Name = "Professeur" }
        );

                // WeekDays (requis par Availability)
        modelBuilder.Entity<WeekDay>().HasData(
        new WeekDay { WeekdayId = wdMondayId,    OrderIndex = 1, Name = "Lundi" },
        new WeekDay { WeekdayId = wdTuesdayId,   OrderIndex = 2, Name = "Mardi" },
        new WeekDay { WeekdayId = wdWednesdayId, OrderIndex = 3, Name = "Mercredi" },
        new WeekDay { WeekdayId = wdThursdayId,  OrderIndex = 4, Name = "Jeudi" },
        new WeekDay { WeekdayId = wdFridayId,    OrderIndex = 5, Name = "Vendredi" },
        new WeekDay { WeekdayId = wdSaturdayId,  OrderIndex = 6, Name = "Samedi" },
        new WeekDay { WeekdayId = wdSundayId,    OrderIndex = 7, Name = "Dimanche" }
        );

        // ============================
        // AVAILABILITIES (Seed)
        // ============================

        var avail1 = GetStableId("avail-marie-curie-lundi-matin");
        var avail2 = GetStableId("avail-marie-curie-lundi-aprem");

        modelBuilder.Entity<Availability>().HasData(
            new Availability
            {
                AvailabilityId = avail1,
                TeacherId = teacherUserId,
                WeekdayId = wdMondayId,
                StartDate = new DateTime(2026, 2, 1),
                EndDate = new DateTime(2026, 6, 30),
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(12, 0, 0)
            },
            new Availability
            {
                AvailabilityId = avail2,
                TeacherId = teacherUserId,
                WeekdayId = wdMondayId,
                StartDate = new DateTime(2026, 2, 1),
                EndDate = new DateTime(2026, 6, 30),
                StartTime = new TimeSpan(13, 0, 0),
                EndTime = new TimeSpan(17, 0, 0)
            }
        );
        // ========================================
        // 2. USERS ET RÔLES SPÉCIFIQUES
        // ========================================

        // Admin User
        modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = adminUserId,
                FirstName = "System",
                LastName = "Admin",
                Email = "admin@univ.fr",
                Password = HashPassword("admin123"),
                PhoneNumber = "0000000000",
                UserRoleId = roleAdminId,
                CreatedAt = DateTime.UtcNow
            }
        );

        modelBuilder.Entity<Admin>().HasData(
            new Admin { UserId = adminUserId }
        );

        // Teacher User
        modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = teacherUserId,
                FirstName = "Marie",
                LastName = "Curie",
                Email = "marie.curie@univ.fr",
                Password = HashPassword("pass123"),
                PhoneNumber = "0123456789",
                UserRoleId = roleTeacherId,
                CreatedAt = DateTime.UtcNow
            }
        );

        modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = teacherUserId2,
                FirstName = "Alain",
                LastName = "Durand",
                Email = "alain.durand@univ.fr",
                Password = HashPassword("pass123_alain"),
                PhoneNumber = "0134567890",
                UserRoleId = roleTeacherId,
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                UserId = teacherUserId3,
                FirstName = "Sophie",
                LastName = "Lambert",
                Email = "sophie.lambert@univ.fr",
                Password = HashPassword("pass123_sophie"),
                PhoneNumber = "0134567891",
                UserRoleId = roleTeacherId,
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                UserId = teacherUserId4,
                FirstName = "Karim",
                LastName = "Benali",
                Email = "karim.benali@univ.fr",
                Password = HashPassword("pass123_karim"),
                PhoneNumber = "0134567892",
                UserRoleId = roleTeacherId,
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                UserId = teacherUserId5,
                FirstName = "Claire",
                LastName = "Morel",
                Email = "claire.morel@univ.fr",
                Password = HashPassword("pass123_claire"),
                PhoneNumber = "0134567893",
                UserRoleId = roleTeacherId,
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                UserId = teacherUserId6,
                FirstName = "Thomas",
                LastName = "Renault",
                Email = "thomas.renault@univ.fr",
                Password = HashPassword("pass123_thomas"),
                PhoneNumber = "0134567894",
                UserRoleId = roleTeacherId,
                CreatedAt = DateTime.UtcNow
            }
        );

        modelBuilder.Entity<Teacher>().HasData(
            new Teacher
            {
                UserId = teacherUserId,
                RegistrationNumber = "REG_001",
                TeacherTitleId = teacherTitleId
            },
            new Teacher
            {
                UserId = teacherUserId2,
                RegistrationNumber = "REG_002",
                TeacherTitleId = teacherTitleId
            },
            new Teacher
            {
                UserId = teacherUserId3,
                RegistrationNumber = "REG_003",
                TeacherTitleId = teacherTitleId
            },
            new Teacher
            {
                UserId = teacherUserId4,
                RegistrationNumber = "REG_004",
                TeacherTitleId = teacherTitleId
            },
            new Teacher
            {
                UserId = teacherUserId5,
                RegistrationNumber = "REG_005",
                TeacherTitleId = teacherTitleId
            },
            new Teacher
            {
                UserId = teacherUserId6,
                RegistrationNumber = "REG_006",
                TeacherTitleId = teacherTitleId
            }
        );

        // ========================================
        // 3. PROGRAMS ET TRACKS
        // ========================================

        // Programs
        modelBuilder.Entity<Program>().HasData(
            new Program
            {
                ProgramId = programId,
                Name = "Master MIAGE",
                Field = "Informatique & Gestion"
            },
            new Program
            {
                ProgramId = programInfoId,
                Name = "Master Informatique",
                Field = "Informatique Fondamentale & Appliquée"
            },
            new Program
            {
                ProgramId = GetStableId("prog-physique"),
                Name = "Master Physique",
                Field = "Physique Fondamentale & Appliquée"
            }
        );

        // Tracks (Parcours)
        modelBuilder.Entity<Track>().HasData(
            new Track { TrackId = trackM1_ID_App, Name = "M1 Informatique Décisionnelle - Apprentissage", ProgramId = programId, TeacherId = teacherUserId },
            new Track { TrackId = trackM1_ILSD_App, Name = "M1 Ingénierie Logicielle pour la Science des Données - Apprentissage", ProgramId = programId, TeacherId = teacherUserId },
            new Track { TrackId = trackM1_ILSD_Init, Name = "M1 Ingénierie Logicielle pour la Science des Données", ProgramId = programId, TeacherId = teacherUserId },
            new Track { TrackId = trackM2_ID_App, Name = "M2 Informatique Décisionnelle - Apprentissage", ProgramId = programId, TeacherId = teacherUserId },
            new Track { TrackId = trackM2_ILSD_App, Name = "M2 Ingénierie Logicielle pour la Science des Données - Apprentissage", ProgramId = programId, TeacherId = teacherUserId },
            new Track { TrackId = trackM2_ILSD_Init, Name = "M2 Ingénierie Logicielle pour la Science des Données", ProgramId = programId, TeacherId = teacherUserId },
            new Track { TrackId = trackM1_AI, Name = "M1 Artificial Intelligence", ProgramId = programInfoId, TeacherId = teacherUserId },
            new Track { TrackId = trackM1_CNS, Name = "M1 Computer and Network Systems", ProgramId = programInfoId, TeacherId = teacherUserId },
            new Track { TrackId = trackM1_MPRI, Name = "M1 Master parisien de recherche en Informatique (MPRI)", ProgramId = programInfoId, TeacherId = teacherUserId },
            new Track { TrackId = trackM2_AI, Name = "M2 Artificial Intelligence", ProgramId = programInfoId, TeacherId = teacherUserId },
            new Track { TrackId = trackM2_CNS, Name = "M2 Computer and Network Systems (CNS) - Systèmes Autonomiques", ProgramId = programInfoId, TeacherId = teacherUserId },
            new Track { TrackId = GetStableId("track-m2-mpri"), Name = "M2 Master parisien de recherche en Informatique (MPRI)", ProgramId = programInfoId, TeacherId = teacherUserId }
        );

        // ========================================
        // 4. ASSIGN (Curriculum)
        // ========================================
        // Note: Assign n'a qu'une propriété HourlyVolume selon l'entité

        // --- CURSUS M1 ILSD - INITIALE ---
        modelBuilder.Entity<Assign>().HasData(
            new Assign { TrackId = trackM1_ILSD_Init, CourseId = c_sad, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_Init, CourseId = c_coo, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_Init, CourseId = c_icl, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_Init, CourseId = c_tech, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_Init, CourseId = c_ro, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_Init, CourseId = c_fin, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_Init, CourseId = c_droit, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_Init, CourseId = c_dev, HourlyVolume = 20 },
            new Assign { TrackId = trackM1_ILSD_Init, CourseId = c_ang, HourlyVolume = 18 },
            new Assign { TrackId = trackM1_ILSD_Init, CourseId = c_stage, HourlyVolume = 0 },
            new Assign { TrackId = trackM1_ILSD_Init, CourseId = c_crypto, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_Init, CourseId = c_bdd, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_Init, CourseId = c_stats, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_Init, CourseId = c_ter, HourlyVolume = 18 },
            new Assign { TrackId = trackM1_ILSD_Init, CourseId = c_data, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_Init, CourseId = c_innov, HourlyVolume = 18 }
        );

        // --- CURSUS M1 ILSD - APPRENTISSAGE ---
        modelBuilder.Entity<Assign>().HasData(
            new Assign { TrackId = trackM1_ILSD_App, CourseId = c_sad, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_App, CourseId = c_coo, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_App, CourseId = c_icl, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_App, CourseId = c_tech, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_App, CourseId = c_ro, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_App, CourseId = c_fin, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_App, CourseId = c_droit, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_App, CourseId = c_dev, HourlyVolume = 12 },
            new Assign { TrackId = trackM1_ILSD_App, CourseId = c_ang, HourlyVolume = 18 },
            new Assign { TrackId = trackM1_ILSD_App, CourseId = c_mem, HourlyVolume = 0 },
            new Assign { TrackId = trackM1_ILSD_App, CourseId = c_crypto, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_App, CourseId = c_bdd, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_App, CourseId = c_stats, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_App, CourseId = c_ter, HourlyVolume = 18 },
            new Assign { TrackId = trackM1_ILSD_App, CourseId = c_data, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_ILSD_App, CourseId = c_innov, HourlyVolume = 18 }
        );

        // ========================================
        // 5. GROUPS ET STUDENTS
        // ========================================

        // Group
        modelBuilder.Entity<Group>().HasData(
            new Group
            {
                GroupId = groupId_M1_ILSD,
                Name = "Groupe A - M1 ILSD",
                AcademicYear = "2025-2026",
                TrackId = trackM1_ILSD_Init
            }
        );

        // Student User
        modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = studentUserId,
                FirstName = "Jean",
                LastName = "Dupont",
                Email = "jean.dupont@etud.fr",
                Password = HashPassword("pass_jean"),
                PhoneNumber = "0987654321",
                UserRoleId = roleStudentId,
                CreatedAt = DateTime.UtcNow
            }
        );

        modelBuilder.Entity<User>().HasData(
            new User { UserId = studentUserId01, FirstName = "Lucas", LastName = "Martin", Email = "lucas.martin01@etud.fr", Password = HashPassword("pass_student_01"), PhoneNumber = "0610000001", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId02, FirstName = "Emma", LastName = "Bernard", Email = "emma.bernard02@etud.fr", Password = HashPassword("pass_student_02"), PhoneNumber = "0610000002", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId03, FirstName = "Hugo", LastName = "Petit", Email = "hugo.petit03@etud.fr", Password = HashPassword("pass_student_03"), PhoneNumber = "0610000003", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId04, FirstName = "Chloe", LastName = "Robert", Email = "chloe.robert04@etud.fr", Password = HashPassword("pass_student_04"), PhoneNumber = "0610000004", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId05, FirstName = "Nathan", LastName = "Richard", Email = "nathan.richard05@etud.fr", Password = HashPassword("pass_student_05"), PhoneNumber = "0610000005", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId06, FirstName = "Lea", LastName = "Durand", Email = "lea.durand06@etud.fr", Password = HashPassword("pass_student_06"), PhoneNumber = "0610000006", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId07, FirstName = "Arthur", LastName = "Dubois", Email = "arthur.dubois07@etud.fr", Password = HashPassword("pass_student_07"), PhoneNumber = "0610000007", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId08, FirstName = "Ines", LastName = "Moreau", Email = "ines.moreau08@etud.fr", Password = HashPassword("pass_student_08"), PhoneNumber = "0610000008", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId09, FirstName = "Jules", LastName = "Laurent", Email = "jules.laurent09@etud.fr", Password = HashPassword("pass_student_09"), PhoneNumber = "0610000009", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId10, FirstName = "Sarah", LastName = "Simon", Email = "sarah.simon10@etud.fr", Password = HashPassword("pass_student_10"), PhoneNumber = "0610000010", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId11, FirstName = "Louis", LastName = "Michel", Email = "louis.michel11@etud.fr", Password = HashPassword("pass_student_11"), PhoneNumber = "0610000011", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId12, FirstName = "Manon", LastName = "Garcia", Email = "manon.garcia12@etud.fr", Password = HashPassword("pass_student_12"), PhoneNumber = "0610000012", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId13, FirstName = "Gabriel", LastName = "Leroy", Email = "gabriel.leroy13@etud.fr", Password = HashPassword("pass_student_13"), PhoneNumber = "0610000013", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId14, FirstName = "Camille", LastName = "Roux", Email = "camille.roux14@etud.fr", Password = HashPassword("pass_student_14"), PhoneNumber = "0610000014", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId15, FirstName = "Adam", LastName = "David", Email = "adam.david15@etud.fr", Password = HashPassword("pass_student_15"), PhoneNumber = "0610000015", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId16, FirstName = "Zoe", LastName = "Bertrand", Email = "zoe.bertrand16@etud.fr", Password = HashPassword("pass_student_16"), PhoneNumber = "0610000016", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId17, FirstName = "Noe", LastName = "Thomas", Email = "noe.thomas17@etud.fr", Password = HashPassword("pass_student_17"), PhoneNumber = "0610000017", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId18, FirstName = "Lina", LastName = "Bonnet", Email = "lina.bonnet18@etud.fr", Password = HashPassword("pass_student_18"), PhoneNumber = "0610000018", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId19, FirstName = "Raphael", LastName = "Francois", Email = "raphael.francois19@etud.fr", Password = HashPassword("pass_student_19"), PhoneNumber = "0610000019", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId20, FirstName = "Yasmine", LastName = "Faure", Email = "yasmine.faure20@etud.fr", Password = HashPassword("pass_student_20"), PhoneNumber = "0610000020", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId21, FirstName = "Theo", LastName = "Andre", Email = "theo.andre21@etud.fr", Password = HashPassword("pass_student_21"), PhoneNumber = "0610000021", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId22, FirstName = "Jade", LastName = "Noel", Email = "jade.noel22@etud.fr", Password = HashPassword("pass_student_22"), PhoneNumber = "0610000022", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId23, FirstName = "Sami", LastName = "Perez", Email = "sami.perez23@etud.fr", Password = HashPassword("pass_student_23"), PhoneNumber = "0610000023", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId24, FirstName = "Clara", LastName = "Denis", Email = "clara.denis24@etud.fr", Password = HashPassword("pass_student_24"), PhoneNumber = "0610000024", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId25, FirstName = "Yanis", LastName = "Colin", Email = "yanis.colin25@etud.fr", Password = HashPassword("pass_student_25"), PhoneNumber = "0610000025", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId26, FirstName = "Laura", LastName = "Renault", Email = "laura.renault26@etud.fr", Password = HashPassword("pass_student_26"), PhoneNumber = "0610000026", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId27, FirstName = "Rayan", LastName = "Gautier", Email = "rayan.gautier27@etud.fr", Password = HashPassword("pass_student_27"), PhoneNumber = "0610000027", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId28, FirstName = "Nina", LastName = "Blanchard", Email = "nina.blanchard28@etud.fr", Password = HashPassword("pass_student_28"), PhoneNumber = "0610000028", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId29, FirstName = "Elias", LastName = "Giraud", Email = "elias.giraud29@etud.fr", Password = HashPassword("pass_student_29"), PhoneNumber = "0610000029", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow },
            new User { UserId = studentUserId30, FirstName = "Alice", LastName = "Perrot", Email = "alice.perrot30@etud.fr", Password = HashPassword("pass_student_30"), PhoneNumber = "0610000030", UserRoleId = roleStudentId, CreatedAt = DateTime.UtcNow }
        );

        modelBuilder.Entity<Student>().HasData(
            new Student
            {
                UserId = studentUserId,
                GroupId = groupId_M1_ILSD
            }
        );

        modelBuilder.Entity<Student>().HasData(
            new Student { UserId = studentUserId01, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId02, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId03, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId04, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId05, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId06, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId07, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId08, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId09, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId10, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId11, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId12, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId13, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId14, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId15, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId16, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId17, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId18, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId19, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId20, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId21, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId22, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId23, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId24, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId25, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId26, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId27, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId28, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId29, GroupId = groupId_M1_ILSD },
            new Student { UserId = studentUserId30, GroupId = groupId_M1_ILSD }
        );

        // ========================================
        // 6. SESSION EXAMPLE
        // ========================================

        modelBuilder.Entity<Session>().HasData(
            new Session
            {
                SessionId = sessionId,
                Date = new DateTime(2026, 3, 30),
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                Mode = "PRESENTIAL",
                CourseId = c_sad,
                SessionTypeId = sessionTypeId,
                SessionStatusId = sessionStatusId,
                RoomId = roomId
            }
        );

        modelBuilder.Entity<Session>().HasData(
            new Session
            {
                SessionId = sessionId2,
                Date = new DateTime(2026, 3, 31),
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(12, 0, 0),
                Mode = "PRESENTIAL",
                CourseId = c_coo,
                SessionTypeId = sessionTypeTdId,
                SessionStatusId = sessionStatusId,
                RoomId = roomId
            },
            new Session
            {
                SessionId = sessionId3,
                Date = new DateTime(2026, 4, 1),
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                Mode = "PRESENTIAL",
                CourseId = c_icl,
                SessionTypeId = sessionTypeTpId,
                SessionStatusId = sessionStatusId,
                RoomId = roomId
            },
            new Session
            {
                SessionId = sessionId4,
                Date = new DateTime(2026, 4, 2),
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(10, 0, 0),
                Mode = "PRESENTIAL",
                CourseId = c_tech,
                SessionTypeId = sessionTypeId,
                SessionStatusId = sessionStatusId,
                RoomId = roomId
            },
            new Session
            {
                SessionId = sessionId5,
                Date = new DateTime(2026, 4, 3),
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(12, 0, 0),
                Mode = "PRESENTIAL",
                CourseId = c_ro,
                SessionTypeId = sessionTypeTdId,
                SessionStatusId = sessionStatusId,
                RoomId = roomId
            },
            new Session
            {
                SessionId = sessionId6,
                Date = new DateTime(2026, 4, 6),
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                Mode = "PRESENTIAL",
                CourseId = c_data,
                SessionTypeId = sessionTypeTpId,
                SessionStatusId = sessionStatusId,
                RoomId = roomId
            }
        );

        // ========================================
        // 7. ATTEND (Group <-> Session)
        // ========================================

        modelBuilder.Entity("Attend").HasData(
            new { GroupId = groupId_M1_ILSD, SessionId = sessionId2 },
            new { GroupId = groupId_M1_ILSD, SessionId = sessionId3 },
            new { GroupId = groupId_M1_ILSD, SessionId = sessionId4 },
            new { GroupId = groupId_M1_ILSD, SessionId = sessionId5 },
            new { GroupId = groupId_M1_ILSD, SessionId = sessionId6 }
        );
    }

    private string GetStableId(string input)
    {
        using (var md5 = System.Security.Cryptography.MD5.Create())
        {
            var hash = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
            return new Guid(hash).ToString();
        }
    }

    private string HashPassword(string password)
    {
        const int workFactor = 12;
        return BCrypt.Net.BCrypt.HashPassword(password, workFactor: workFactor);
    }
}
