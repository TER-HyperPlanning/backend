using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class TerHyperplanningContext : DbContext
{
    private static readonly DateTime seedCreatedAt = new DateTime(2025, 9, 1, 0, 0, 0, DateTimeKind.Utc);
    private const string saltBCrypt = "$2a$12$C6UzMDM.H6dfI/f/IKcEe.";

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

    public virtual DbSet<AvailabilityGroup> AvailabilityGroups { get; set; }

    public virtual DbSet<Building> Buildings { get; set; }

    public virtual DbSet<ChangeStatus> ChangeStatuses { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<UserNotification> UserNotifications { get; set; }

    public virtual DbSet<Program> Programs { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<RoomType> RoomTypes { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

    public virtual DbSet<SessionRoomChange> SessionRoomChanges { get; set; }

    public virtual DbSet<SessionRecoveryChange> SessionRecoveryChanges { get; set; }

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
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(false);
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime2");

            entity.HasQueryFilter(a => !a.IsDeleted);

            entity.HasOne(d => d.Course).WithMany(p => p.Assigns)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assign_Course");

            entity.HasOne(d => d.Track).WithMany(p => p.Assigns)
                .HasForeignKey(d => d.TrackId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assign_Track");
        });

        modelBuilder.Entity<AvailabilityGroup>(entity =>
        {
            entity.HasKey(e => e.AvailabilityGroupId);

            entity.ToTable("AvailabilityGroup");

            entity.Property(e => e.AvailabilityGroupId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("availability_group_id");
            entity.Property(e => e.TeacherId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("teacher_id");
            entity.Property(e => e.NumberOfAvailableDays)
                .HasColumnName("number_of_available_days");

            entity.HasOne(d => d.Teacher).WithMany()
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AvailabilityGroup_Teacher");
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
            entity.Property(e => e.AvailabilityGroupId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("availability_group_id")
                .IsRequired(false);

            entity.HasOne(d => d.Teacher).WithMany(p => p.Availabilities)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Avail_Teacher");

            entity.HasOne(d => d.Weekday).WithMany(p => p.Availabilities)
                .HasForeignKey(d => d.WeekdayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Avail_Weekday");

            entity.HasOne(d => d.AvailabilityGroup).WithMany(p => p.Availabilities)
                .HasForeignKey(d => d.AvailabilityGroupId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Avail_AvailabilityGroup");
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
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(false)
                .HasColumnName("is_deleted");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");

            entity.HasQueryFilter(b => !b.IsDeleted);
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

            entity.HasQueryFilter(c => !c.IsDeleted);
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
            entity.Property(e => e.Capacity).HasColumnName("capacity");
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
            entity.HasKey(e => e.NotificationId).HasName("PK_Notification");

            entity.ToTable("Notification");

            entity.Property(e => e.NotificationId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("notification_id");

            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");

            entity.Property(e => e.Message)
                .HasMaxLength(1000)
                .HasColumnName("message");

            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasDefaultValue("General")
                .HasColumnName("type");

            entity.Property(e => e.RelatedId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired(false)
                .HasColumnName("related_id");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_at");

            // Pour la compatibilité ascendante, on peut garder HasMany(...).WithMany(...) 
            // Mais pour IsRead, on utilise UserNotifications
        });

        modelBuilder.Entity<UserNotification>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.NotificationId }).HasName("PK_UserNotification");

            entity.ToTable("UserNotification");

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_id");

            entity.Property(e => e.NotificationId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("notification_id");

            entity.Property(e => e.IsRead)
                .HasDefaultValue(false)
                .HasColumnName("is_read");

            entity.HasOne(d => d.User)
                .WithMany()
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_UserNotification_User");

            entity.HasOne(d => d.Notification)
                .WithMany(p => p.UserNotifications)
                .HasForeignKey(d => d.NotificationId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_UserNotification_Notification");
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
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(false)
                .HasColumnName("is_deleted");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");

            entity.HasQueryFilter(r => !r.IsDeleted);

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

        modelBuilder.Entity<SessionRoomChange>(entity =>
        {
            entity.HasKey(e => e.SessionRoomChangeId).HasName("PK__SessionR__RoomChange");

            entity.ToTable("SessionRoomChange");

            entity.Property(e => e.SessionRoomChangeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("session_room_change_id");

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

            entity.Property(e => e.OldRoomId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("old_room_id");

            entity.Property(e => e.ApprovedRoomId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("approved_room_id");

            entity.Property(e => e.RejectionReason)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("rejection_reason");

            entity.HasOne(d => d.ChangeStatus).WithMany(p => p.SessionRoomChanges)
                .HasForeignKey(d => d.ChangeStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoomChange_Status");

            entity.HasOne(d => d.Session).WithMany(p => p.SessionRoomChanges)
                .HasForeignKey(d => d.SessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoomChange_Session");

            entity.HasOne(d => d.Teacher).WithMany(p => p.SessionRoomChanges)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoomChange_Teacher");

            entity.HasOne(d => d.OldRoom)
                .WithMany()
                .HasForeignKey(d => d.OldRoomId)
                .HasConstraintName("FK_RoomChange_OldRoom");

            entity.HasOne(d => d.ApprovedRoom)
                .WithMany()
                .HasForeignKey(d => d.ApprovedRoomId)
                .HasConstraintName("FK_RoomChange_ApprovedRoom");
        });

        modelBuilder.Entity<SessionRecoveryChange>(entity =>
        {
            entity.HasKey(e => e.SessionRecoveryChangeId).HasName("PK__SessionR__RecoveryChange");

            entity.ToTable("SessionRecoveryChange");

            entity.Property(e => e.SessionRecoveryChangeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("session_recovery_change_id");

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

            entity.Property(e => e.ProposedDate)
                .HasColumnType("date")
                .HasColumnName("proposed_date");

            entity.Property(e => e.ProposedStartTime)
                .HasColumnName("proposed_start_time");

            entity.Property(e => e.ProposedEndTime)
                .HasColumnName("proposed_end_time");

            entity.Property(e => e.ProposedRoomId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("proposed_room_id");

            entity.Property(e => e.CounterProposalDate)
                .HasColumnType("date")
                .HasColumnName("counter_proposal_date");

            entity.Property(e => e.CounterProposalStartTime)
                .HasColumnName("counter_proposal_start_time");

            entity.Property(e => e.CounterProposalEndTime)
                .HasColumnName("counter_proposal_end_time");

            entity.Property(e => e.CounterProposalRoomId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("counter_proposal_room_id");

            entity.Property(e => e.RejectionReason)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("rejection_reason");

            entity.HasOne(d => d.ChangeStatus).WithMany(p => p.SessionRecoveryChanges)
                .HasForeignKey(d => d.ChangeStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecoveryChange_Status");

            entity.HasOne(d => d.Session).WithMany(p => p.SessionRecoveryChanges)
                .HasForeignKey(d => d.SessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecoveryChange_Session");

            entity.HasOne(d => d.Teacher).WithMany(p => p.SessionRecoveryChanges)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecoveryChange_Teacher");

            entity.HasOne(d => d.ProposedRoom)
                .WithMany()
                .HasForeignKey(d => d.ProposedRoomId)
                .HasConstraintName("FK_RecoveryChange_ProposedRoom");

            entity.HasOne(d => d.CounterProposalRoom)
                .WithMany()
                .HasForeignKey(d => d.CounterProposalRoomId)
                .HasConstraintName("FK_RecoveryChange_CounterProposalRoom");
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

            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime2");

            entity.Property(e => e.IsDeleted)
                .HasColumnType("bit");

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

            entity.HasQueryFilter(t => !t.IsDeleted);
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
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(false)
                .HasColumnName("is_deleted");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.UserRoleId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_role_id");

            entity.HasQueryFilter(u => !u.IsDeleted);

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
        var adminUserId2 = GetStableId("user-admin-claire-bernard");
        var adminUserId3 = GetStableId("user-admin-julien-moreau");
        var adminUserId4 = GetStableId("user-admin-fatima-zahra");
        var adminUserId5 = GetStableId("user-admin-pierre-louis");
        var teacherUserId = GetStableId("user-marie-curie");
        var studentUserId = GetStableId("user-jean-dupont");
        var teacherUserId2 = GetStableId("user-alain-durand");
        var teacherUserId3 = GetStableId("user-sophie-lambert");
        var teacherUserId4 = GetStableId("user-karim-benali");
        var teacherUserId5 = GetStableId("user-claire-morel");
        var teacherUserId6 = GetStableId("user-thomas-renault");
        var teacherUserId7 = GetStableId("user-celine-robert");
        var teacherUserId8 = GetStableId("user-maxime-legrand");
        var teacherUserId9 = GetStableId("user-amina-cherif");
        var teacherUserId10 = GetStableId("user-nicolas-fabre");
        var teacherUserId11 = GetStableId("user-elodie-guerin");
        var teacherUserId12 = GetStableId("user-mehdi-kaci");
        var teacherUserId13 = GetStableId("user-julie-paul");
        var teacherUserId14 = GetStableId("user-adrien-morin");
        var teacherUserId15 = GetStableId("user-samira-bensalem");
        var teacherUserId16 = GetStableId("user-antoine-mercier");
        var teacherUserId17 = GetStableId("user-nawal-haddad");
        var teacherUserId18 = GetStableId("user-ikram-bouziane");
        var teacherUserId19 = GetStableId("user-yassine-hamzaoui");
        var teacherUserId20 = GetStableId("user-asmaa-fellah");
        var teacherUserId21 = GetStableId("user-amin-kerroum");
        var teacherUserId22 = GetStableId("user-siham-lakhdar");
        var teacherUserId23 = GetStableId("user-riad-mokhtar");
        var teacherUserId24 = GetStableId("user-nour-rahmani");

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
        var studentUserIdB01 = GetStableId("user-student-b-01");
        var studentUserIdB02 = GetStableId("user-student-b-02");
        var studentUserIdB03 = GetStableId("user-student-b-03");
        var studentUserIdB04 = GetStableId("user-student-b-04");
        var studentUserIdB05 = GetStableId("user-student-b-05");
        var studentUserIdB06 = GetStableId("user-student-b-06");
        var studentUserIdB07 = GetStableId("user-student-b-07");
        var studentUserIdB08 = GetStableId("user-student-b-08");
        var studentUserIdB09 = GetStableId("user-student-b-09");
        var studentUserIdB10 = GetStableId("user-student-b-10");
        var studentUserIdB11 = GetStableId("user-student-b-11");
        var studentUserIdB12 = GetStableId("user-student-b-12");
        var studentUserIdB13 = GetStableId("user-student-b-13");
        var studentUserIdB14 = GetStableId("user-student-b-14");
        var studentUserIdB15 = GetStableId("user-student-b-15");
        var studentUserIdB16 = GetStableId("user-student-b-16");
        var studentUserIdB17 = GetStableId("user-student-b-17");
        var studentUserIdB18 = GetStableId("user-student-b-18");
        var studentUserIdB19 = GetStableId("user-student-b-19");
        var studentUserIdB20 = GetStableId("user-student-b-20");
        var studentUserIdB21 = GetStableId("user-student-b-21");
        var studentUserIdB22 = GetStableId("user-student-b-22");
        var studentUserIdB23 = GetStableId("user-student-b-23");
        var studentUserIdB24 = GetStableId("user-student-b-24");
        var studentUserIdB25 = GetStableId("user-student-b-25");
        var studentUserIdB26 = GetStableId("user-student-b-26");
        var studentUserIdB27 = GetStableId("user-student-b-27");
        var studentUserIdB28 = GetStableId("user-student-b-28");
        var studentUserIdB29 = GetStableId("user-student-b-29");
        var studentUserIdB30 = GetStableId("user-student-b-30");
        var studentUserIdC01 = GetStableId("user-student-c-01");
        var studentUserIdC02 = GetStableId("user-student-c-02");
        var studentUserIdC03 = GetStableId("user-student-c-03");
        var studentUserIdC04 = GetStableId("user-student-c-04");
        var studentUserIdC05 = GetStableId("user-student-c-05");
        var studentUserIdC06 = GetStableId("user-student-c-06");
        var studentUserIdC07 = GetStableId("user-student-c-07");
        var studentUserIdC08 = GetStableId("user-student-c-08");
        var studentUserIdC09 = GetStableId("user-student-c-09");
        var studentUserIdC10 = GetStableId("user-student-c-10");
        var studentUserIdC11 = GetStableId("user-student-c-11");
        var studentUserIdC12 = GetStableId("user-student-c-12");
        var studentUserIdC13 = GetStableId("user-student-c-13");
        var studentUserIdC14 = GetStableId("user-student-c-14");
        var studentUserIdC15 = GetStableId("user-student-c-15");
        var studentUserIdC16 = GetStableId("user-student-c-16");
        var studentUserIdC17 = GetStableId("user-student-c-17");
        var studentUserIdC18 = GetStableId("user-student-c-18");
        var studentUserIdC19 = GetStableId("user-student-c-19");
        var studentUserIdC20 = GetStableId("user-student-c-20");
        var studentUserIdC21 = GetStableId("user-student-c-21");
        var studentUserIdC22 = GetStableId("user-student-c-22");
        var studentUserIdC23 = GetStableId("user-student-c-23");
        var studentUserIdC24 = GetStableId("user-student-c-24");
        var studentUserIdC25 = GetStableId("user-student-c-25");
        var studentUserIdC26 = GetStableId("user-student-c-26");
        var studentUserIdC27 = GetStableId("user-student-c-27");
        var studentUserIdC28 = GetStableId("user-student-c-28");
        var studentUserIdC29 = GetStableId("user-student-c-29");
        var studentUserIdC30 = GetStableId("user-student-c-30");

        var programId = GetStableId("prog-cs");
        var trackM1_ID_App = GetStableId("track-m1-id-app");
        var trackM1_ILSD_App = GetStableId("track-m1-ilsd-app");
        var trackM1_ILSD_Init = GetStableId("track-m1-ilsd-init");

        var trackM2_ID_App = GetStableId("track-m2-id-app");
        var trackM2_ILSD_App = GetStableId("track-m2-ilsd-app");
        var trackM2_ILSD_Init = GetStableId("track-m2-ilsd-init");

        var groupId_M1_ILSD = GetStableId("group-m1-ilsd-init-a");
        var groupId_M1_ILSD_B = GetStableId("group-m1-ilsd-init-b");
        var groupId_M1_CNS = GetStableId("group-m1-cns-init-a");

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
        var c_presence = GetStableId("c-presence-universitaire"); // Présence Universitaire
        var c_msed = GetStableId("c-msed"); // Modélisation des systèmes à événements discrets
        var c_infocom = GetStableId("c-infocom"); // Information et communication
        var c_algoav = GetStableId("c-algo-av"); // Algorithmique avancée
        var c_hpc = GetStableId("c-hpc-intro"); // Introduction à l'informatique haute performance
        var c_multiagents = GetStableId("c-multi-agents"); // Modèles et méthodes pour les systèmes multi-agents
        var c_specverif = GetStableId("c-spec-verif"); // Spécification et vérification formelles
        var c_ml = GetStableId("c-machine-learning"); // Machine Learning

        var buildingId = GetStableId("bld-A");
        var buildingIdIbgbi = GetStableId("bld-ibgbi");
        var roomTypeTdId = GetStableId("rt-td");
        var roomTypeCoursId = GetStableId("rt-cours");
        var roomTypeInfoId = GetStableId("rt-info");
        var roomTypeAmphiId = GetStableId("rt-amphitheatre");
        var roomId = GetStableId("room-a102");

        var sessionTypeId = GetStableId("st-cm");
        var sessionTypeTdId = GetStableId("st-td");
        var sessionTypeTpId = GetStableId("st-tp");
        var sessionTypeExamenId = GetStableId("st-examen");
        var sessionTypeSoutenanceId = GetStableId("st-soutenance");
        var sessionTypeEvenementId = GetStableId("st-evenement");
        var sessionStatusId = GetStableId("ss-scheduled");
        var sessionStatusCancelledId = GetStableId("ss-cancelled");
        var sessionStatusMovedId = GetStableId("ss-moved");
        var sessionStatusRecoveredId = GetStableId("ss-recovered");

        var teacherTitleId = GetStableId("tt-permanent");

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

        var changeStatusPendingId = GetStableId("change-status-pending");
        var changeStatusApprovedId = GetStableId("change-status-approved");
        var changeStatusRejectedId = GetStableId("change-status-rejected");

        var sessionChangeId1 = GetStableId("session-change-001");
        var sessionChangeId2 = GetStableId("session-change-002");
        var sessionChangeId3 = GetStableId("session-change-003");

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
            new Building { BuildingId = buildingId, Name = "Bâtiment A" },
            new Building { BuildingId = buildingIdIbgbi, Name = "IBGBI" }
        );

        // RoomTypes (requis par Room)
        modelBuilder.Entity<RoomType>().HasData(
            new RoomType { RoomTypeId = roomTypeTdId, Name = "TD" },
            new RoomType { RoomTypeId = roomTypeCoursId, Name = "COURS" },
            new RoomType { RoomTypeId = roomTypeInfoId, Name = "INFO" },
            new RoomType { RoomTypeId = roomTypeAmphiId, Name = "AMPHITHEATRE" }
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
                RoomTypeId = roomTypeTdId
            },
            new Room { RoomId = GetStableId("room-ibgbi-1"), RoomNumber = "IBGBI-1", Capacity = 36, IsAvailable = true, BuildingId = buildingIdIbgbi, RoomTypeId = roomTypeTdId },
            new Room { RoomId = GetStableId("room-ibgbi-2"), RoomNumber = "IBGBI-2", Capacity = 36, IsAvailable = true, BuildingId = buildingIdIbgbi, RoomTypeId = roomTypeTdId },
            new Room { RoomId = GetStableId("room-ibgbi-3"), RoomNumber = "IBGBI-3", Capacity = 36, IsAvailable = true, BuildingId = buildingIdIbgbi, RoomTypeId = roomTypeTdId },
            new Room { RoomId = GetStableId("room-ibgbi-4"), RoomNumber = "IBGBI-4", Capacity = 36, IsAvailable = true, BuildingId = buildingIdIbgbi, RoomTypeId = roomTypeTdId },
            new Room { RoomId = GetStableId("room-ibgbi-5"), RoomNumber = "IBGBI-5", Capacity = 36, IsAvailable = true, BuildingId = buildingIdIbgbi, RoomTypeId = roomTypeTdId },
            new Room { RoomId = GetStableId("room-ibgbi-6"), RoomNumber = "IBGBI-6", Capacity = 50, IsAvailable = true, BuildingId = buildingIdIbgbi, RoomTypeId = roomTypeCoursId },
            new Room { RoomId = GetStableId("room-ibgbi-7"), RoomNumber = "IBGBI-7", Capacity = 50, IsAvailable = true, BuildingId = buildingIdIbgbi, RoomTypeId = roomTypeCoursId },
            new Room { RoomId = GetStableId("room-ibgbi-8"), RoomNumber = "IBGBI-8", Capacity = 50, IsAvailable = true, BuildingId = buildingIdIbgbi, RoomTypeId = roomTypeCoursId },
            new Room { RoomId = GetStableId("room-ibgbi-9"), RoomNumber = "IBGBI-9", Capacity = 50, IsAvailable = true, BuildingId = buildingIdIbgbi, RoomTypeId = roomTypeCoursId },
            new Room { RoomId = GetStableId("room-ibgbi-10"), RoomNumber = "IBGBI-10", Capacity = 50, IsAvailable = true, BuildingId = buildingIdIbgbi, RoomTypeId = roomTypeCoursId }
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
            new Course { CourseId = c_innov, Name = "Implémentation du Projet Innovation", Code = "DATA_INNOV" },
            new Course { CourseId = c_presence, Name = "PRESENCE UNIVERSITAIRE", Code = "UNIV_PRESENCE" },
            new Course { CourseId = c_msed, Name = "Modélisation des systèmes à événements discrets", Code = "CNS_MSED" },
            new Course { CourseId = c_infocom, Name = "Information et communication", Code = "CNS_INFOCOM" },
            new Course { CourseId = c_algoav, Name = "Algorithmique avancée", Code = "CNS_ALGO_ADV" },
            new Course { CourseId = c_hpc, Name = "Introduction à l'informatique haute performance", Code = "CNS_HPC_INTRO" },
            new Course { CourseId = c_multiagents, Name = "Modèles et méthodes pour les systèmes multi-agents", Code = "CNS_MULTI_AGENTS" },
            new Course { CourseId = c_specverif, Name = "Spécification et vérification formelles", Code = "CNS_SPEC_VERIF" },
            new Course { CourseId = c_ml, Name = "Machine Learning", Code = "CNS_ML" }
        );

        // SessionTypes (requis par Session)
        modelBuilder.Entity<SessionType>().HasData(
            new SessionType { SessionTypeId = sessionTypeId, Label = "CM" },
            new SessionType { SessionTypeId = sessionTypeTdId, Label = "TD" },
            new SessionType { SessionTypeId = sessionTypeTpId, Label = "TP" },
            new SessionType { SessionTypeId = sessionTypeExamenId, Label = "EXAMEN" },
            new SessionType { SessionTypeId = sessionTypeSoutenanceId, Label = "SOUTENANCE" },
            new SessionType { SessionTypeId = sessionTypeEvenementId, Label = "EVENEMENT" }
        );

        // SessionStatus (requis par Session)
        modelBuilder.Entity<SessionStatus>().HasData(
            new SessionStatus { SessionStatusId = sessionStatusId, Label = "PROGRAMME" },
            new SessionStatus { SessionStatusId = sessionStatusCancelledId, Label = "ANNULE" },
            new SessionStatus { SessionStatusId = sessionStatusMovedId, Label = "DEPLACE" },
            new SessionStatus { SessionStatusId = sessionStatusRecoveredId, Label = "RATTRAPE" }
        );

        // TeacherTitles (requis par Teacher)
        modelBuilder.Entity<TeacherTitle>().HasData(
            new TeacherTitle { TeacherTitleId = teacherTitleId, Name = "PERMANENT" },
            new TeacherTitle { TeacherTitleId = GetStableId("tt-vacataire"), Name = "VACATAIRE" },
            new TeacherTitle { TeacherTitleId = GetStableId("tt-associe"), Name = "ASSOCIE" }
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
            new User { UserId = adminUserId, FirstName = "System", LastName = "Admin", Email = "admin@univ.fr", Password = HashPassword("admin123"), PhoneNumber = "0000000000", UserRoleId = roleAdminId, CreatedAt = seedCreatedAt },
            new User { UserId = adminUserId2, FirstName = "Claire", LastName = "Bernard", Email = "claire.bernard@univ.fr", Password = HashPassword("admin123"), PhoneNumber = "0102030401", UserRoleId = roleAdminId, CreatedAt = seedCreatedAt },
            new User { UserId = adminUserId3, FirstName = "Julien", LastName = "Moreau", Email = "julien.moreau@univ.fr", Password = HashPassword("admin123"), PhoneNumber = "0102030402", UserRoleId = roleAdminId, CreatedAt = seedCreatedAt },
            new User { UserId = adminUserId4, FirstName = "Fatima", LastName = "Zahra", Email = "fatima.zahra@univ.fr", Password = HashPassword("admin123"), PhoneNumber = "0102030403", UserRoleId = roleAdminId, CreatedAt = seedCreatedAt },
            new User { UserId = adminUserId5, FirstName = "Pierre", LastName = "Louis", Email = "pierre.louis@univ.fr", Password = HashPassword("admin123"), PhoneNumber = "0102030404", UserRoleId = roleAdminId, CreatedAt = seedCreatedAt }
        );

        modelBuilder.Entity<Admin>().HasData(
            new Admin { UserId = adminUserId },
            new Admin { UserId = adminUserId2 },
            new Admin { UserId = adminUserId3 },
            new Admin { UserId = adminUserId4 },
            new Admin { UserId = adminUserId5 }
        );

        // Teacher User
        modelBuilder.Entity<User>().HasData(
            new User { UserId = teacherUserId, FirstName = "Marie", LastName = "Curie", Email = "marie.curie@univ.fr", Password = HashPassword("pass123"), PhoneNumber = "0123456789", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId2, FirstName = "Alain", LastName = "Durand", Email = "alain.durand@univ.fr", Password = HashPassword("pass123_alain"), PhoneNumber = "0134567890", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId3, FirstName = "Sophie", LastName = "Lambert", Email = "sophie.lambert@univ.fr", Password = HashPassword("pass123_sophie"), PhoneNumber = "0134567891", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId4, FirstName = "Karim", LastName = "Benali", Email = "karim.benali@univ.fr", Password = HashPassword("pass123_karim"), PhoneNumber = "0134567892", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId5, FirstName = "Claire", LastName = "Morel", Email = "claire.morel@univ.fr", Password = HashPassword("pass123_claire"), PhoneNumber = "0134567893", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId6, FirstName = "Thomas", LastName = "Renault", Email = "thomas.renault@univ.fr", Password = HashPassword("pass123_thomas"), PhoneNumber = "0134567894", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId7, FirstName = "Celine", LastName = "Robert", Email = "celine.robert@univ.fr", Password = HashPassword("pass123_celine"), PhoneNumber = "0134567895", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId8, FirstName = "Maxime", LastName = "Legrand", Email = "maxime.legrand@univ.fr", Password = HashPassword("pass123_maxime"), PhoneNumber = "0134567896", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId9, FirstName = "Amina", LastName = "Cherif", Email = "amina.cherif@univ.fr", Password = HashPassword("pass123_amina"), PhoneNumber = "0134567897", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId10, FirstName = "Nicolas", LastName = "Fabre", Email = "nicolas.fabre@univ.fr", Password = HashPassword("pass123_nicolas"), PhoneNumber = "0134567898", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId11, FirstName = "Elodie", LastName = "Guerin", Email = "elodie.guerin@univ.fr", Password = HashPassword("pass123_elodie"), PhoneNumber = "0134567899", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId12, FirstName = "Mehdi", LastName = "Kaci", Email = "mehdi.kaci@univ.fr", Password = HashPassword("pass123_mehdi"), PhoneNumber = "0134567800", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId13, FirstName = "Julie", LastName = "Paul", Email = "julie.paul@univ.fr", Password = HashPassword("pass123_julie"), PhoneNumber = "0134567801", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId14, FirstName = "Adrien", LastName = "Morin", Email = "adrien.morin@univ.fr", Password = HashPassword("pass123_adrien"), PhoneNumber = "0134567802", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId15, FirstName = "Samira", LastName = "Bensalem", Email = "samira.bensalem@univ.fr", Password = HashPassword("pass123_samira"), PhoneNumber = "0134567803", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId16, FirstName = "Antoine", LastName = "Mercier", Email = "antoine.mercier@univ.fr", Password = HashPassword("pass123_antoine"), PhoneNumber = "0134567804", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId17, FirstName = "Nawal", LastName = "Haddad", Email = "nawal.haddad@univ.fr", Password = HashPassword("pass123_nawal"), PhoneNumber = "0134567805", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId18, FirstName = "Ikram", LastName = "Bouziane", Email = "ikram.bouziane@univ.fr", Password = HashPassword("pass123_ikram"), PhoneNumber = "0134567806", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId19, FirstName = "Yassine", LastName = "Hamzaoui", Email = "yassine.hamzaoui@univ.fr", Password = HashPassword("pass123_yassine"), PhoneNumber = "0134567807", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId20, FirstName = "Asmaa", LastName = "Fellah", Email = "asmaa.fellah@univ.fr", Password = HashPassword("pass123_asmaa"), PhoneNumber = "0134567808", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId21, FirstName = "Amin", LastName = "Kerroum", Email = "amin.kerroum@univ.fr", Password = HashPassword("pass123_amin"), PhoneNumber = "0134567809", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId22, FirstName = "Siham", LastName = "Lakhdar", Email = "siham.lakhdar@univ.fr", Password = HashPassword("pass123_siham"), PhoneNumber = "0134567810", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId23, FirstName = "Riad", LastName = "Mokhtar", Email = "riad.mokhtar@univ.fr", Password = HashPassword("pass123_riad"), PhoneNumber = "0134567811", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt },
            new User { UserId = teacherUserId24, FirstName = "Nour", LastName = "Rahmani", Email = "nour.rahmani@univ.fr", Password = HashPassword("pass123_nour"), PhoneNumber = "0134567812", UserRoleId = roleTeacherId, CreatedAt = seedCreatedAt }
        );

        modelBuilder.Entity<Teacher>().HasData(
            new Teacher { UserId = teacherUserId, RegistrationNumber = "REG_001", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId2, RegistrationNumber = "REG_002", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId3, RegistrationNumber = "REG_003", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId4, RegistrationNumber = "REG_004", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId5, RegistrationNumber = "REG_005", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId6, RegistrationNumber = "REG_006", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId7, RegistrationNumber = "REG_007", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId8, RegistrationNumber = "REG_008", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId9, RegistrationNumber = "REG_009", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId10, RegistrationNumber = "REG_010", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId11, RegistrationNumber = "REG_011", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId12, RegistrationNumber = "REG_012", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId13, RegistrationNumber = "REG_013", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId14, RegistrationNumber = "REG_014", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId15, RegistrationNumber = "REG_015", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId16, RegistrationNumber = "REG_016", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId17, RegistrationNumber = "REG_017", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId18, RegistrationNumber = "REG_018", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId19, RegistrationNumber = "REG_019", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId20, RegistrationNumber = "REG_020", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId21, RegistrationNumber = "REG_021", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId22, RegistrationNumber = "REG_022", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId23, RegistrationNumber = "REG_023", TeacherTitleId = teacherTitleId },
            new Teacher { UserId = teacherUserId24, RegistrationNumber = "REG_024", TeacherTitleId = teacherTitleId }
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

        // --- CURSUS M1 CNS ---
        modelBuilder.Entity<Assign>().HasData(
            new Assign { TrackId = trackM1_CNS, CourseId = c_ang, HourlyVolume = 18 },
            new Assign { TrackId = trackM1_CNS, CourseId = c_dev, HourlyVolume = 20 },
            new Assign { TrackId = trackM1_CNS, CourseId = c_sad, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_CNS, CourseId = c_data, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_CNS, CourseId = c_ro, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_CNS, CourseId = c_coo, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_CNS, CourseId = c_msed, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_CNS, CourseId = c_infocom, HourlyVolume = 18 },
            new Assign { TrackId = trackM1_CNS, CourseId = c_algoav, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_CNS, CourseId = c_hpc, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_CNS, CourseId = c_crypto, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_CNS, CourseId = c_bdd, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_CNS, CourseId = c_tech, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_CNS, CourseId = c_ter, HourlyVolume = 18 },
            new Assign { TrackId = trackM1_CNS, CourseId = c_multiagents, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_CNS, CourseId = c_specverif, HourlyVolume = 36 },
            new Assign { TrackId = trackM1_CNS, CourseId = c_ml, HourlyVolume = 36 }
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
            },
            new Group
            {
                GroupId = groupId_M1_ILSD_B,
                Name = "Groupe B - M1 ILSD",
                AcademicYear = "2025-2026",
                TrackId = trackM1_ILSD_Init
            },
            new Group
            {
                GroupId = groupId_M1_CNS,
                Name = "Groupe A - M1 CNS",
                AcademicYear = "2025-2026",
                TrackId = trackM1_CNS
            }
        );

        // Student User
        modelBuilder.Entity<User>().HasData(
            new User { UserId = studentUserId, FirstName = "Jean", LastName = "Dupont", Email = "jean.dupont@etud.fr", Password = HashPassword("pass_jean"), PhoneNumber = "0987654321", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId01, FirstName = "Lucas", LastName = "Martin", Email = "lucas.martin01@etud.fr", Password = HashPassword("pass_student_01"), PhoneNumber = "0610000001", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId02, FirstName = "Emma", LastName = "Bernard", Email = "emma.bernard02@etud.fr", Password = HashPassword("pass_student_02"), PhoneNumber = "0610000002", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId03, FirstName = "Hugo", LastName = "Petit", Email = "hugo.petit03@etud.fr", Password = HashPassword("pass_student_03"), PhoneNumber = "0610000003", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId04, FirstName = "Chloe", LastName = "Robert", Email = "chloe.robert04@etud.fr", Password = HashPassword("pass_student_04"), PhoneNumber = "0610000004", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId05, FirstName = "Nathan", LastName = "Richard", Email = "nathan.richard05@etud.fr", Password = HashPassword("pass_student_05"), PhoneNumber = "0610000005", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId06, FirstName = "Lea", LastName = "Durand", Email = "lea.durand06@etud.fr", Password = HashPassword("pass_student_06"), PhoneNumber = "0610000006", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId07, FirstName = "Arthur", LastName = "Dubois", Email = "arthur.dubois07@etud.fr", Password = HashPassword("pass_student_07"), PhoneNumber = "0610000007", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId08, FirstName = "Ines", LastName = "Moreau", Email = "ines.moreau08@etud.fr", Password = HashPassword("pass_student_08"), PhoneNumber = "0610000008", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId09, FirstName = "Jules", LastName = "Laurent", Email = "jules.laurent09@etud.fr", Password = HashPassword("pass_student_09"), PhoneNumber = "0610000009", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId10, FirstName = "Sarah", LastName = "Simon", Email = "sarah.simon10@etud.fr", Password = HashPassword("pass_student_10"), PhoneNumber = "0610000010", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId11, FirstName = "Louis", LastName = "Michel", Email = "louis.michel11@etud.fr", Password = HashPassword("pass_student_11"), PhoneNumber = "0610000011", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId12, FirstName = "Manon", LastName = "Garcia", Email = "manon.garcia12@etud.fr", Password = HashPassword("pass_student_12"), PhoneNumber = "0610000012", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId13, FirstName = "Gabriel", LastName = "Leroy", Email = "gabriel.leroy13@etud.fr", Password = HashPassword("pass_student_13"), PhoneNumber = "0610000013", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId14, FirstName = "Camille", LastName = "Roux", Email = "camille.roux14@etud.fr", Password = HashPassword("pass_student_14"), PhoneNumber = "0610000014", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId15, FirstName = "Adam", LastName = "David", Email = "adam.david15@etud.fr", Password = HashPassword("pass_student_15"), PhoneNumber = "0610000015", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId16, FirstName = "Zoe", LastName = "Bertrand", Email = "zoe.bertrand16@etud.fr", Password = HashPassword("pass_student_16"), PhoneNumber = "0610000016", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId17, FirstName = "Noe", LastName = "Thomas", Email = "noe.thomas17@etud.fr", Password = HashPassword("pass_student_17"), PhoneNumber = "0610000017", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId18, FirstName = "Lina", LastName = "Bonnet", Email = "lina.bonnet18@etud.fr", Password = HashPassword("pass_student_18"), PhoneNumber = "0610000018", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId19, FirstName = "Raphael", LastName = "Francois", Email = "raphael.francois19@etud.fr", Password = HashPassword("pass_student_19"), PhoneNumber = "0610000019", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId20, FirstName = "Yasmine", LastName = "Faure", Email = "yasmine.faure20@etud.fr", Password = HashPassword("pass_student_20"), PhoneNumber = "0610000020", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId21, FirstName = "Theo", LastName = "Andre", Email = "theo.andre21@etud.fr", Password = HashPassword("pass_student_21"), PhoneNumber = "0610000021", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId22, FirstName = "Jade", LastName = "Noel", Email = "jade.noel22@etud.fr", Password = HashPassword("pass_student_22"), PhoneNumber = "0610000022", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId23, FirstName = "Sami", LastName = "Perez", Email = "sami.perez23@etud.fr", Password = HashPassword("pass_student_23"), PhoneNumber = "0610000023", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId24, FirstName = "Clara", LastName = "Denis", Email = "clara.denis24@etud.fr", Password = HashPassword("pass_student_24"), PhoneNumber = "0610000024", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId25, FirstName = "Yanis", LastName = "Colin", Email = "yanis.colin25@etud.fr", Password = HashPassword("pass_student_25"), PhoneNumber = "0610000025", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId26, FirstName = "Laura", LastName = "Renault", Email = "laura.renault26@etud.fr", Password = HashPassword("pass_student_26"), PhoneNumber = "0610000026", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId27, FirstName = "Rayan", LastName = "Gautier", Email = "rayan.gautier27@etud.fr", Password = HashPassword("pass_student_27"), PhoneNumber = "0610000027", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId28, FirstName = "Nina", LastName = "Blanchard", Email = "nina.blanchard28@etud.fr", Password = HashPassword("pass_student_28"), PhoneNumber = "0610000028", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId29, FirstName = "Elias", LastName = "Giraud", Email = "elias.giraud29@etud.fr", Password = HashPassword("pass_student_29"), PhoneNumber = "0610000029", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserId30, FirstName = "Alice", LastName = "Perrot", Email = "alice.perrot30@etud.fr", Password = HashPassword("pass_student_30"), PhoneNumber = "0610000030", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt }
        );

        modelBuilder.Entity<User>().HasData(
            new User { UserId = studentUserIdB01, FirstName = "Lina", LastName = "Ait", Email = "studentb01@etud.fr", Password = HashPassword("pass_student_b_01"), PhoneNumber = "0620000001", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB02, FirstName = "Nassim", LastName = "Belkacem", Email = "studentb02@etud.fr", Password = HashPassword("pass_student_b_02"), PhoneNumber = "0620000002", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB03, FirstName = "Salma", LastName = "Chebli", Email = "studentb03@etud.fr", Password = HashPassword("pass_student_b_03"), PhoneNumber = "0620000003", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB04, FirstName = "Idriss", LastName = "Dahmani", Email = "studentb04@etud.fr", Password = HashPassword("pass_student_b_04"), PhoneNumber = "0620000004", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB05, FirstName = "Maya", LastName = "Elouafi", Email = "studentb05@etud.fr", Password = HashPassword("pass_student_b_05"), PhoneNumber = "0620000005", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB06, FirstName = "Youssef", LastName = "Farah", Email = "studentb06@etud.fr", Password = HashPassword("pass_student_b_06"), PhoneNumber = "0620000006", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB07, FirstName = "Nour", LastName = "Ghali", Email = "studentb07@etud.fr", Password = HashPassword("pass_student_b_07"), PhoneNumber = "0620000007", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB08, FirstName = "Riad", LastName = "Hamidi", Email = "studentb08@etud.fr", Password = HashPassword("pass_student_b_08"), PhoneNumber = "0620000008", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB09, FirstName = "Sana", LastName = "Ibrahimi", Email = "studentb09@etud.fr", Password = HashPassword("pass_student_b_09"), PhoneNumber = "0620000009", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB10, FirstName = "Adel", LastName = "Jabri", Email = "studentb10@etud.fr", Password = HashPassword("pass_student_b_10"), PhoneNumber = "0620000010", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB11, FirstName = "Ilona", LastName = "Kadi", Email = "studentb11@etud.fr", Password = HashPassword("pass_student_b_11"), PhoneNumber = "0620000011", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB12, FirstName = "Karim", LastName = "Lahlou", Email = "studentb12@etud.fr", Password = HashPassword("pass_student_b_12"), PhoneNumber = "0620000012", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB13, FirstName = "Siham", LastName = "Mansouri", Email = "studentb13@etud.fr", Password = HashPassword("pass_student_b_13"), PhoneNumber = "0620000013", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB14, FirstName = "Tarik", LastName = "Naji", Email = "studentb14@etud.fr", Password = HashPassword("pass_student_b_14"), PhoneNumber = "0620000014", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB15, FirstName = "Imane", LastName = "Ouali", Email = "studentb15@etud.fr", Password = HashPassword("pass_student_b_15"), PhoneNumber = "0620000015", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB16, FirstName = "Anis", LastName = "Perrin", Email = "studentb16@etud.fr", Password = HashPassword("pass_student_b_16"), PhoneNumber = "0620000016", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB17, FirstName = "Leila", LastName = "Qadri", Email = "studentb17@etud.fr", Password = HashPassword("pass_student_b_17"), PhoneNumber = "0620000017", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB18, FirstName = "Romy", LastName = "Rami", Email = "studentb18@etud.fr", Password = HashPassword("pass_student_b_18"), PhoneNumber = "0620000018", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB19, FirstName = "Samy", LastName = "Safi", Email = "studentb19@etud.fr", Password = HashPassword("pass_student_b_19"), PhoneNumber = "0620000019", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB20, FirstName = "Nadia", LastName = "Tazi", Email = "studentb20@etud.fr", Password = HashPassword("pass_student_b_20"), PhoneNumber = "0620000020", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB21, FirstName = "Omar", LastName = "Uzan", Email = "studentb21@etud.fr", Password = HashPassword("pass_student_b_21"), PhoneNumber = "0620000021", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB22, FirstName = "Meriem", LastName = "Vallet", Email = "studentb22@etud.fr", Password = HashPassword("pass_student_b_22"), PhoneNumber = "0620000022", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB23, FirstName = "Bilal", LastName = "Wahbi", Email = "studentb23@etud.fr", Password = HashPassword("pass_student_b_23"), PhoneNumber = "0620000023", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB24, FirstName = "Loubna", LastName = "Xerri", Email = "studentb24@etud.fr", Password = HashPassword("pass_student_b_24"), PhoneNumber = "0620000024", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB25, FirstName = "Yanis", LastName = "Yassine", Email = "studentb25@etud.fr", Password = HashPassword("pass_student_b_25"), PhoneNumber = "0620000025", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB26, FirstName = "Sara", LastName = "Ziani", Email = "studentb26@etud.fr", Password = HashPassword("pass_student_b_26"), PhoneNumber = "0620000026", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB27, FirstName = "Adam", LastName = "Arif", Email = "studentb27@etud.fr", Password = HashPassword("pass_student_b_27"), PhoneNumber = "0620000027", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB28, FirstName = "Hana", LastName = "Bouzid", Email = "studentb28@etud.fr", Password = HashPassword("pass_student_b_28"), PhoneNumber = "0620000028", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB29, FirstName = "Ilyes", LastName = "Cherkaoui", Email = "studentb29@etud.fr", Password = HashPassword("pass_student_b_29"), PhoneNumber = "0620000029", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdB30, FirstName = "Nora", LastName = "Drissi", Email = "studentb30@etud.fr", Password = HashPassword("pass_student_b_30"), PhoneNumber = "0620000030", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt }
        );

        modelBuilder.Entity<User>().HasData(
            new User { UserId = studentUserIdC01, FirstName = "Amine", LastName = "Belaid", Email = "studentc01@etud.fr", Password = HashPassword("pass_student_c_01"), PhoneNumber = "0630000001", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC02, FirstName = "Yara", LastName = "Cohen", Email = "studentc02@etud.fr", Password = HashPassword("pass_student_c_02"), PhoneNumber = "0630000002", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC03, FirstName = "Nadir", LastName = "Daoud", Email = "studentc03@etud.fr", Password = HashPassword("pass_student_c_03"), PhoneNumber = "0630000003", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC04, FirstName = "Mila", LastName = "Elmi", Email = "studentc04@etud.fr", Password = HashPassword("pass_student_c_04"), PhoneNumber = "0630000004", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC05, FirstName = "Ilyan", LastName = "Fares", Email = "studentc05@etud.fr", Password = HashPassword("pass_student_c_05"), PhoneNumber = "0630000005", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC06, FirstName = "Sofia", LastName = "Ghali", Email = "studentc06@etud.fr", Password = HashPassword("pass_student_c_06"), PhoneNumber = "0630000006", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC07, FirstName = "Rayan", LastName = "Haddou", Email = "studentc07@etud.fr", Password = HashPassword("pass_student_c_07"), PhoneNumber = "0630000007", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC08, FirstName = "Ines", LastName = "Ibnou", Email = "studentc08@etud.fr", Password = HashPassword("pass_student_c_08"), PhoneNumber = "0630000008", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC09, FirstName = "Walid", LastName = "Jaziri", Email = "studentc09@etud.fr", Password = HashPassword("pass_student_c_09"), PhoneNumber = "0630000009", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC10, FirstName = "Nora", LastName = "Kassem", Email = "studentc10@etud.fr", Password = HashPassword("pass_student_c_10"), PhoneNumber = "0630000010", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC11, FirstName = "Youssef", LastName = "Lahmar", Email = "studentc11@etud.fr", Password = HashPassword("pass_student_c_11"), PhoneNumber = "0630000011", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC12, FirstName = "Meriem", LastName = "Mabrouk", Email = "studentc12@etud.fr", Password = HashPassword("pass_student_c_12"), PhoneNumber = "0630000012", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC13, FirstName = "Karim", LastName = "Naceur", Email = "studentc13@etud.fr", Password = HashPassword("pass_student_c_13"), PhoneNumber = "0630000013", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC14, FirstName = "Lina", LastName = "Ouali", Email = "studentc14@etud.fr", Password = HashPassword("pass_student_c_14"), PhoneNumber = "0630000014", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC15, FirstName = "Samy", LastName = "Perron", Email = "studentc15@etud.fr", Password = HashPassword("pass_student_c_15"), PhoneNumber = "0630000015", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC16, FirstName = "Aya", LastName = "Quinet", Email = "studentc16@etud.fr", Password = HashPassword("pass_student_c_16"), PhoneNumber = "0630000016", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC17, FirstName = "Hicham", LastName = "Rami", Email = "studentc17@etud.fr", Password = HashPassword("pass_student_c_17"), PhoneNumber = "0630000017", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC18, FirstName = "Leila", LastName = "Saber", Email = "studentc18@etud.fr", Password = HashPassword("pass_student_c_18"), PhoneNumber = "0630000018", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC19, FirstName = "Adel", LastName = "Tahar", Email = "studentc19@etud.fr", Password = HashPassword("pass_student_c_19"), PhoneNumber = "0630000019", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC20, FirstName = "Maya", LastName = "Ury", Email = "studentc20@etud.fr", Password = HashPassword("pass_student_c_20"), PhoneNumber = "0630000020", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC21, FirstName = "Bilal", LastName = "Varet", Email = "studentc21@etud.fr", Password = HashPassword("pass_student_c_21"), PhoneNumber = "0630000021", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC22, FirstName = "Salma", LastName = "Wahbi", Email = "studentc22@etud.fr", Password = HashPassword("pass_student_c_22"), PhoneNumber = "0630000022", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC23, FirstName = "Anis", LastName = "Xavier", Email = "studentc23@etud.fr", Password = HashPassword("pass_student_c_23"), PhoneNumber = "0630000023", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC24, FirstName = "Nesrine", LastName = "Yala", Email = "studentc24@etud.fr", Password = HashPassword("pass_student_c_24"), PhoneNumber = "0630000024", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC25, FirstName = "Imad", LastName = "Zeroual", Email = "studentc25@etud.fr", Password = HashPassword("pass_student_c_25"), PhoneNumber = "0630000025", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC26, FirstName = "Sara", LastName = "Amrani", Email = "studentc26@etud.fr", Password = HashPassword("pass_student_c_26"), PhoneNumber = "0630000026", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC27, FirstName = "Tarek", LastName = "Bouzidi", Email = "studentc27@etud.fr", Password = HashPassword("pass_student_c_27"), PhoneNumber = "0630000027", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC28, FirstName = "Nour", LastName = "Chami", Email = "studentc28@etud.fr", Password = HashPassword("pass_student_c_28"), PhoneNumber = "0630000028", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC29, FirstName = "Ilias", LastName = "Djebar", Email = "studentc29@etud.fr", Password = HashPassword("pass_student_c_29"), PhoneNumber = "0630000029", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt },
            new User { UserId = studentUserIdC30, FirstName = "Rim", LastName = "Essafi", Email = "studentc30@etud.fr", Password = HashPassword("pass_student_c_30"), PhoneNumber = "0630000030", UserRoleId = roleStudentId, CreatedAt = seedCreatedAt }
        );

        modelBuilder.Entity<Student>().HasData(
            new Student { UserId = studentUserId, GroupId = groupId_M1_ILSD },
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

        modelBuilder.Entity<Student>().HasData(
            new Student { UserId = studentUserIdB01, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB02, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB03, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB04, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB05, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB06, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB07, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB08, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB09, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB10, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB11, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB12, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB13, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB14, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB15, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB16, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB17, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB18, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB19, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB20, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB21, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB22, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB23, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB24, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB25, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB26, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB27, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB28, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB29, GroupId = groupId_M1_ILSD_B },
            new Student { UserId = studentUserIdB30, GroupId = groupId_M1_ILSD_B }
        );

        modelBuilder.Entity<Student>().HasData(
            new Student { UserId = studentUserIdC01, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC02, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC03, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC04, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC05, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC06, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC07, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC08, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC09, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC10, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC11, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC12, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC13, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC14, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC15, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC16, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC17, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC18, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC19, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC20, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC21, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC22, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC23, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC24, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC25, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC26, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC27, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC28, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC29, GroupId = groupId_M1_CNS },
            new Student { UserId = studentUserIdC30, GroupId = groupId_M1_CNS }
        );

        // ========================================
        // 6. SESSIONS 2025-2026 (Groupes A et B - M1 ILSD)
        // ========================================

        var sessions = new List<Session>();
        var attendSeed = new List<object>();
        var teachSeed = new List<object>();

        var teacherIds = new List<string>
        {
            teacherUserId,
            teacherUserId2,
            teacherUserId3,
            teacherUserId4,
            teacherUserId5,
            teacherUserId6,
            teacherUserId7,
            teacherUserId8,
            teacherUserId9,
            teacherUserId10,
            teacherUserId11,
            teacherUserId12,
            teacherUserId13,
            teacherUserId14,
            teacherUserId15,
            teacherUserId16,
            teacherUserId17
        };

        // Cours du track M1 ILSD initiale, hors Stage M1 (0h) traité via l'évènement final.
        var regularCourseIds = new List<string>
        {
            c_sad,
            c_coo,
            c_icl,
            c_tech,
            c_ro,
            c_fin,
            c_droit,
            c_dev,
            c_ang,
            c_crypto,
            c_bdd,
            c_stats,
            c_ter,
            c_data,
            c_innov
        };

        // Cours M1 CNS demandés (S1/S2 uniquement).
        var cnsSemester1CourseIds = new List<string>
        {
            c_ang,
            c_dev,
            c_sad,
            c_data,
            c_ro,
            c_coo,
            c_msed,
            c_infocom
        };

        var cnsSemester2CourseIds = new List<string>
        {
            c_algoav,
            c_hpc,
            c_crypto,
            c_bdd,
            c_tech,
            c_ter,
            c_multiagents,
            c_specverif,
            c_ml
        };

        var teacherIdsCns = new List<string>
        {
            teacherUserId,
            teacherUserId2,
            teacherUserId3,
            teacherUserId4,
            teacherUserId5,
            teacherUserId6,
            teacherUserId7,
            teacherUserId8,
            teacherUserId9,
            teacherUserId10,
            teacherUserId11,
            teacherUserId12,
            teacherUserId13,
            teacherUserId14,
            teacherUserId15,
            teacherUserId16,
            teacherUserId17,
            teacherUserId18,
            teacherUserId19,
            teacherUserId20,
            teacherUserId21,
            teacherUserId22,
            teacherUserId23,
            teacherUserId24
        };

        var holidayRanges = new List<(DateTime Start, DateTime End)>
        {
            (new DateTime(2025, 10, 27), new DateTime(2025, 10, 31)),
            (new DateTime(2025, 12, 22), new DateTime(2026, 1, 2)),
            (new DateTime(2026, 3, 2), new DateTime(2026, 3, 6)),
            (new DateTime(2026, 4, 27), new DateTime(2026, 5, 1))
        };

        bool IsWeekday(DateTime date) => date.DayOfWeek >= DayOfWeek.Monday && date.DayOfWeek <= DayOfWeek.Friday;
        bool IsInExamWeek1(DateTime date) => date >= new DateTime(2026, 1, 5) && date <= new DateTime(2026, 1, 9);
        bool IsInExamWeek2(DateTime date) => date >= new DateTime(2026, 5, 4) && date <= new DateTime(2026, 5, 7);

        bool IsInHolidays(DateTime date)
        {
            foreach (var holiday in holidayRanges)
            {
                if (date >= holiday.Start && date <= holiday.End)
                {
                    return true;
                }
            }

            return false;
        }

        bool IsSpecialEventDate(DateTime date)
        {
            return date == new DateTime(2025, 12, 5) || date == new DateTime(2026, 5, 11);
        }

        bool IsRegularTeachingDay(DateTime date)
        {
            return IsWeekday(date)
                && !IsInHolidays(date)
                && !IsInExamWeek1(date)
                && !IsInExamWeek2(date)
                && !IsSpecialEventDate(date);
        }

        // Garde en mémoire les créneaux déjà attribués à un enseignant.
        var teacherAssignments = new Dictionary<string, List<(DateTime Date, TimeSpan Start, TimeSpan End)>>();
        var teacherCursor = 0;
        var teacherCursorCns = 0;

        var ibgbiRoomIds = new List<string>
        {
            GetStableId("room-ibgbi-1"),
            GetStableId("room-ibgbi-2"),
            GetStableId("room-ibgbi-3"),
            GetStableId("room-ibgbi-4"),
            GetStableId("room-ibgbi-5"),
            GetStableId("room-ibgbi-6"),
            GetStableId("room-ibgbi-7"),
            GetStableId("room-ibgbi-8"),
            GetStableId("room-ibgbi-9"),
            GetStableId("room-ibgbi-10")
        };

        var roomAssignments = new Dictionary<string, List<(DateTime Date, TimeSpan Start, TimeSpan End)>>();
        var roomDailyByGroup = new Dictionary<string, string>();
        var roomCursor = 0;

        bool Overlaps(TimeSpan aStart, TimeSpan aEnd, TimeSpan bStart, TimeSpan bEnd)
        {
            return aStart < bEnd && bStart < aEnd;
        }

        bool HasTeacherConflict(string teacherId, DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            if (!teacherAssignments.TryGetValue(teacherId, out var slots))
            {
                return false;
            }

            foreach (var slot in slots)
            {
                if (slot.Date == date && Overlaps(startTime, endTime, slot.Start, slot.End))
                {
                    return true;
                }
            }

            return false;
        }

        bool HasRoomConflict(string roomIdValue, DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            if (!roomAssignments.TryGetValue(roomIdValue, out var slots))
            {
                return false;
            }

            foreach (var slot in slots)
            {
                if (slot.Date == date && Overlaps(startTime, endTime, slot.Start, slot.End))
                {
                    return true;
                }
            }

            return false;
        }

        string PickAvailableTeacher(DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            for (var offset = 0; offset < teacherIds.Count; offset++)
            {
                var index = (teacherCursor + offset) % teacherIds.Count;
                var candidate = teacherIds[index];

                if (!HasTeacherConflict(candidate, date, startTime, endTime))
                {
                    teacherCursor = (index + 1) % teacherIds.Count;
                    return candidate;
                }
            }

            throw new InvalidOperationException(
                $"Aucun enseignant disponible le {date:yyyy-MM-dd} entre {startTime:hh\\:mm} et {endTime:hh\\:mm}.");
        }

        string PickAvailableTeacherFromPool(List<string> teacherPool, ref int teacherPoolCursor, DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            for (var offset = 0; offset < teacherPool.Count; offset++)
            {
                var index = (teacherPoolCursor + offset) % teacherPool.Count;
                var candidate = teacherPool[index];

                if (!HasTeacherConflict(candidate, date, startTime, endTime))
                {
                    teacherPoolCursor = (index + 1) % teacherPool.Count;
                    return candidate;
                }
            }

            throw new InvalidOperationException(
                $"Aucun enseignant disponible le {date:yyyy-MM-dd} entre {startTime:hh\\:mm} et {endTime:hh\\:mm}.");
        }

        void RegisterTeacherAssignment(string teacherId, DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            if (!teacherAssignments.TryGetValue(teacherId, out var slots))
            {
                slots = new List<(DateTime Date, TimeSpan Start, TimeSpan End)>();
                teacherAssignments[teacherId] = slots;
            }

            slots.Add((date, startTime, endTime));
        }

        string BuildGroupDateRoomKey(string groupIdValue, DateTime date)
        {
            return $"{groupIdValue}:{date:yyyyMMdd}";
        }

        string PickAvailableRoom(string groupIdValue, DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            var groupDateKey = BuildGroupDateRoomKey(groupIdValue, date);

            if (roomDailyByGroup.TryGetValue(groupDateKey, out var preferredRoomId)
                && !HasRoomConflict(preferredRoomId, date, startTime, endTime))
            {
                return preferredRoomId;
            }

            for (var offset = 0; offset < ibgbiRoomIds.Count; offset++)
            {
                var index = (roomCursor + offset) % ibgbiRoomIds.Count;
                var candidateRoomId = ibgbiRoomIds[index];

                if (!HasRoomConflict(candidateRoomId, date, startTime, endTime))
                {
                    roomCursor = (index + 1) % ibgbiRoomIds.Count;
                    roomDailyByGroup[groupDateKey] = candidateRoomId;
                    return candidateRoomId;
                }
            }

            throw new InvalidOperationException(
                $"Aucune salle IBGBI disponible le {date:yyyy-MM-dd} entre {startTime:hh\\:mm} et {endTime:hh\\:mm}.");
        }

        void RegisterRoomAssignment(string roomIdValue, DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            if (!roomAssignments.TryGetValue(roomIdValue, out var slots))
            {
                slots = new List<(DateTime Date, TimeSpan Start, TimeSpan End)>();
                roomAssignments[roomIdValue] = slots;
            }

            slots.Add((date, startTime, endTime));
        }

        void AddSessionForGroup(
            string groupId,
            string groupKey,
            DateTime date,
            TimeSpan startTime,
            TimeSpan endTime,
            string courseId,
            string sessionType,
            string mode)
        {
            var sessionId = GetStableId($"session-{groupKey}-{date:yyyyMMdd}-{startTime:hh\\:mm}-{endTime:hh\\:mm}-{courseId}-{sessionType}");
            var teacherId = PickAvailableTeacher(date, startTime, endTime);
            var assignedRoomId = PickAvailableRoom(groupId, date, startTime, endTime);

            RegisterTeacherAssignment(teacherId, date, startTime, endTime);
            RegisterRoomAssignment(assignedRoomId, date, startTime, endTime);

            sessions.Add(new Session
            {
                SessionId = sessionId,
                Date = date,
                StartTime = startTime,
                EndTime = endTime,
                Mode = mode,
                CourseId = courseId,
                SessionTypeId = sessionType,
                SessionStatusId = sessionStatusId,
                RoomId = assignedRoomId
            });

            attendSeed.Add(new { GroupId = groupId, SessionId = sessionId });
            teachSeed.Add(new { TeacherId = teacherId, SessionId = sessionId });
        }

        void AddSessionForGroupWithStatus(
            string groupId,
            string groupKey,
            DateTime date,
            TimeSpan startTime,
            TimeSpan endTime,
            string courseId,
            string sessionType,
            string mode,
            string customStatusId,
            string statusKey)
        {
            var sessionId = GetStableId($"session-{groupKey}-{statusKey}-{date:yyyyMMdd}-{startTime:hh\\:mm}-{endTime:hh\\:mm}-{courseId}-{sessionType}");
            var teacherId = PickAvailableTeacher(date, startTime, endTime);
            var assignedRoomId = PickAvailableRoom(groupId, date, startTime, endTime);

            RegisterTeacherAssignment(teacherId, date, startTime, endTime);
            RegisterRoomAssignment(assignedRoomId, date, startTime, endTime);

            sessions.Add(new Session
            {
                SessionId = sessionId,
                Date = date,
                StartTime = startTime,
                EndTime = endTime,
                Mode = mode,
                CourseId = courseId,
                SessionTypeId = sessionType,
                SessionStatusId = customStatusId,
                RoomId = assignedRoomId
            });

            attendSeed.Add(new { GroupId = groupId, SessionId = sessionId });
            teachSeed.Add(new { TeacherId = teacherId, SessionId = sessionId });
        }

        void AddSessionForGroupWithTeacherPool(
            string groupId,
            string groupKey,
            DateTime date,
            TimeSpan startTime,
            TimeSpan endTime,
            string courseId,
            string sessionType,
            string mode,
            List<string> teacherPool,
            ref int teacherPoolCursor)
        {
            var sessionId = GetStableId($"session-{groupKey}-{date:yyyyMMdd}-{startTime:hh\\:mm}-{endTime:hh\\:mm}-{courseId}-{sessionType}");
            var teacherId = PickAvailableTeacherFromPool(teacherPool, ref teacherPoolCursor, date, startTime, endTime);
            var assignedRoomId = PickAvailableRoom(groupId, date, startTime, endTime);

            RegisterTeacherAssignment(teacherId, date, startTime, endTime);
            RegisterRoomAssignment(assignedRoomId, date, startTime, endTime);

            sessions.Add(new Session
            {
                SessionId = sessionId,
                Date = date,
                StartTime = startTime,
                EndTime = endTime,
                Mode = mode,
                CourseId = courseId,
                SessionTypeId = sessionType,
                SessionStatusId = sessionStatusId,
                RoomId = assignedRoomId
            });

            attendSeed.Add(new { GroupId = groupId, SessionId = sessionId });
            teachSeed.Add(new { TeacherId = teacherId, SessionId = sessionId });
        }

        void GenerateRegularScheduleForGroup(string groupId, string groupKey)
        {
            var schoolStart = new DateTime(2025, 9, 8);
            var schoolEnd = new DateTime(2026, 5, 11);

            var tpMonthKeys = new HashSet<int>();
            var rareLateMonthKeys = new HashSet<int>();
            var isCmWeek = true;

            for (var weekStart = schoolStart; weekStart <= schoolEnd; weekStart = weekStart.AddDays(7))
            {
                var regularWeekDays = new List<DateTime>();

                for (var dayOffset = 0; dayOffset < 5; dayOffset++)
                {
                    var date = weekStart.AddDays(dayOffset);
                    if (date > schoolEnd)
                    {
                        break;
                    }

                    if (IsRegularTeachingDay(date))
                    {
                        regularWeekDays.Add(date);
                    }
                }

                if (regularWeekDays.Count == 0)
                {
                    continue;
                }

                var monthKey = (regularWeekDays[0].Year * 100) + regularWeekDays[0].Month;

                var isTpWeek = !tpMonthKeys.Contains(monthKey);
                if (isTpWeek)
                {
                    tpMonthKeys.Add(monthKey);
                }

                var weekSessionTypeId = isTpWeek
                    ? sessionTypeTpId
                    : (isCmWeek ? sessionTypeId : sessionTypeTdId);

                if (!isTpWeek)
                {
                    isCmWeek = !isCmWeek;
                }

                DateTime? rareLateDay = null;
                if (!rareLateMonthKeys.Contains(monthKey))
                {
                    foreach (var day in regularWeekDays)
                    {
                        if (day.DayOfWeek == DayOfWeek.Thursday)
                        {
                            rareLateDay = day;
                            rareLateMonthKeys.Add(monthKey);
                            break;
                        }
                    }
                }

                var courseQueue = new Queue<string>(regularCourseIds);

                foreach (var day in regularWeekDays)
                {
                    var slots = new List<(TimeSpan Start, TimeSpan End)>
                    {
                        (new TimeSpan(8, 30, 0), new TimeSpan(10, 0, 0)),
                        (new TimeSpan(10, 15, 0), new TimeSpan(11, 45, 0)),
                        (new TimeSpan(13, 0, 0), new TimeSpan(14, 30, 0)),
                        (new TimeSpan(14, 45, 0), new TimeSpan(16, 15, 0))
                    };

                    if (rareLateDay.HasValue && day == rareLateDay.Value)
                    {
                        slots = day.Month % 2 == 0
                            ? new List<(TimeSpan Start, TimeSpan End)>
                            {
                                (new TimeSpan(8, 30, 0), new TimeSpan(10, 0, 0)),
                                (new TimeSpan(10, 15, 0), new TimeSpan(11, 45, 0)),
                                (new TimeSpan(13, 30, 0), new TimeSpan(15, 0, 0)),
                                (new TimeSpan(15, 15, 0), new TimeSpan(16, 45, 0))
                            }
                            : new List<(TimeSpan Start, TimeSpan End)>
                            {
                                (new TimeSpan(8, 30, 0), new TimeSpan(10, 0, 0)),
                                (new TimeSpan(10, 15, 0), new TimeSpan(11, 45, 0)),
                                (new TimeSpan(14, 0, 0), new TimeSpan(15, 30, 0)),
                                (new TimeSpan(15, 45, 0), new TimeSpan(17, 15, 0))
                            };
                    }

                    foreach (var slot in slots)
                    {
                        if (courseQueue.Count == 0)
                        {
                            break;
                        }

                        AddSessionForGroup(
                            groupId,
                            groupKey,
                            day,
                            slot.Start,
                            slot.End,
                            courseQueue.Dequeue(),
                            weekSessionTypeId,
                            "PRESENTIAL");
                    }
                }
            }
        }

        void GenerateSpecialSessionsForGroup(string groupId, string groupKey)
        {
            AddSessionForGroup(
                groupId,
                groupKey,
                new DateTime(2025, 12, 5),
                new TimeSpan(8, 30, 0),
                new TimeSpan(15, 0, 0),
                c_presence,
                sessionTypeEvenementId,
                "PRESENTIAL");

            // Semaine du 05/01/2026 au 09/01/2026
            AddSessionForGroup(groupId, groupKey, new DateTime(2026, 1, 5), new TimeSpan(8, 30, 0), new TimeSpan(11, 30, 0), c_sad, sessionTypeExamenId, "PRESENTIAL");
            AddSessionForGroup(groupId, groupKey, new DateTime(2026, 1, 5), new TimeSpan(13, 30, 0), new TimeSpan(17, 30, 0), c_coo, sessionTypeExamenId, "PRESENTIAL");
            AddSessionForGroup(groupId, groupKey, new DateTime(2026, 1, 6), new TimeSpan(8, 30, 0), new TimeSpan(11, 0, 0), c_icl, sessionTypeExamenId, "PRESENTIAL");
            AddSessionForGroup(groupId, groupKey, new DateTime(2026, 1, 6), new TimeSpan(14, 0, 0), new TimeSpan(16, 0, 0), c_ter, sessionTypeSoutenanceId, "PRESENTIAL");
            AddSessionForGroup(groupId, groupKey, new DateTime(2026, 1, 8), new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0), c_tech, sessionTypeExamenId, "PRESENTIAL");
            AddSessionForGroup(groupId, groupKey, new DateTime(2026, 1, 8), new TimeSpan(13, 30, 0), new TimeSpan(16, 30, 0), c_ro, sessionTypeExamenId, "PRESENTIAL");
            AddSessionForGroup(groupId, groupKey, new DateTime(2026, 1, 9), new TimeSpan(8, 30, 0), new TimeSpan(12, 30, 0), c_fin, sessionTypeExamenId, "PRESENTIAL");
            AddSessionForGroup(groupId, groupKey, new DateTime(2026, 1, 9), new TimeSpan(14, 0, 0), new TimeSpan(17, 0, 0), c_droit, sessionTypeExamenId, "PRESENTIAL");

            // Semaine du 04/05/2026 au 07/05/2026
            AddSessionForGroup(groupId, groupKey, new DateTime(2026, 5, 4), new TimeSpan(8, 30, 0), new TimeSpan(11, 30, 0), c_crypto, sessionTypeExamenId, "PRESENTIAL");
            AddSessionForGroup(groupId, groupKey, new DateTime(2026, 5, 4), new TimeSpan(13, 30, 0), new TimeSpan(17, 30, 0), c_bdd, sessionTypeExamenId, "PRESENTIAL");
            AddSessionForGroup(groupId, groupKey, new DateTime(2026, 5, 5), new TimeSpan(9, 0, 0), new TimeSpan(13, 0, 0), c_stats, sessionTypeExamenId, "PRESENTIAL");
            AddSessionForGroup(groupId, groupKey, new DateTime(2026, 5, 6), new TimeSpan(8, 30, 0), new TimeSpan(11, 0, 0), c_data, sessionTypeExamenId, "PRESENTIAL");
            AddSessionForGroup(groupId, groupKey, new DateTime(2026, 5, 6), new TimeSpan(13, 30, 0), new TimeSpan(16, 30, 0), c_innov, sessionTypeExamenId, "PRESENTIAL");
            AddSessionForGroup(groupId, groupKey, new DateTime(2026, 5, 7), new TimeSpan(14, 0, 0), new TimeSpan(17, 0, 0), c_ang, sessionTypeExamenId, "PRESENTIAL");
        }

        void GenerateRegularScheduleForGroupCustomCourses(
            string groupId,
            string groupKey,
            DateTime schoolStart,
            DateTime schoolEnd,
            IReadOnlyList<string> courseIds,
            List<string> teacherPool,
            ref int teacherPoolCursor)
        {
            var tpMonthKeys = new HashSet<int>();
            var rareLateMonthKeys = new HashSet<int>();
            var isCmWeek = true;

            for (var weekStart = schoolStart; weekStart <= schoolEnd; weekStart = weekStart.AddDays(7))
            {
                var regularWeekDays = new List<DateTime>();

                for (var dayOffset = 0; dayOffset < 5; dayOffset++)
                {
                    var date = weekStart.AddDays(dayOffset);
                    if (date > schoolEnd)
                    {
                        break;
                    }

                    if (IsRegularTeachingDay(date))
                    {
                        regularWeekDays.Add(date);
                    }
                }

                if (regularWeekDays.Count == 0)
                {
                    continue;
                }

                var monthKey = (regularWeekDays[0].Year * 100) + regularWeekDays[0].Month;

                var isTpWeek = !tpMonthKeys.Contains(monthKey);
                if (isTpWeek)
                {
                    tpMonthKeys.Add(monthKey);
                }

                var weekSessionTypeId = isTpWeek
                    ? sessionTypeTpId
                    : (isCmWeek ? sessionTypeId : sessionTypeTdId);

                if (!isTpWeek)
                {
                    isCmWeek = !isCmWeek;
                }

                DateTime? rareLateDay = null;
                if (!rareLateMonthKeys.Contains(monthKey))
                {
                    foreach (var day in regularWeekDays)
                    {
                        if (day.DayOfWeek == DayOfWeek.Thursday)
                        {
                            rareLateDay = day;
                            rareLateMonthKeys.Add(monthKey);
                            break;
                        }
                    }
                }

                var courseQueue = new Queue<string>(courseIds);

                foreach (var day in regularWeekDays)
                {
                    var slots = new List<(TimeSpan Start, TimeSpan End)>
                    {
                        (new TimeSpan(8, 30, 0), new TimeSpan(10, 0, 0)),
                        (new TimeSpan(10, 15, 0), new TimeSpan(11, 45, 0)),
                        (new TimeSpan(13, 0, 0), new TimeSpan(14, 30, 0)),
                        (new TimeSpan(14, 45, 0), new TimeSpan(16, 15, 0))
                    };

                    if (rareLateDay.HasValue && day == rareLateDay.Value)
                    {
                        slots = day.Month % 2 == 0
                            ? new List<(TimeSpan Start, TimeSpan End)>
                            {
                                (new TimeSpan(8, 30, 0), new TimeSpan(10, 0, 0)),
                                (new TimeSpan(10, 15, 0), new TimeSpan(11, 45, 0)),
                                (new TimeSpan(13, 30, 0), new TimeSpan(15, 0, 0)),
                                (new TimeSpan(15, 15, 0), new TimeSpan(16, 45, 0))
                            }
                            : new List<(TimeSpan Start, TimeSpan End)>
                            {
                                (new TimeSpan(8, 30, 0), new TimeSpan(10, 0, 0)),
                                (new TimeSpan(10, 15, 0), new TimeSpan(11, 45, 0)),
                                (new TimeSpan(14, 0, 0), new TimeSpan(15, 30, 0)),
                                (new TimeSpan(15, 45, 0), new TimeSpan(17, 15, 0))
                            };
                    }

                    foreach (var slot in slots)
                    {
                        if (courseQueue.Count == 0)
                        {
                            break;
                        }

                        AddSessionForGroupWithTeacherPool(
                            groupId,
                            groupKey,
                            day,
                            slot.Start,
                            slot.End,
                            courseQueue.Dequeue(),
                            weekSessionTypeId,
                            "PRESENTIAL",
                            teacherPool,
                            ref teacherPoolCursor);
                    }
                }
            }
        }

        void GenerateSpecialSessionsForCnsGroup(string groupId, string groupKey, List<string> teacherPool, ref int teacherPoolCursor)
        {
            // Semaine du 05/01/2026 au 09/01/2026 - examens S1
            AddSessionForGroupWithTeacherPool(groupId, groupKey, new DateTime(2026, 1, 5), new TimeSpan(8, 30, 0), new TimeSpan(11, 30, 0), c_sad, sessionTypeExamenId, "PRESENTIAL", teacherPool, ref teacherPoolCursor);
            AddSessionForGroupWithTeacherPool(groupId, groupKey, new DateTime(2026, 1, 5), new TimeSpan(13, 30, 0), new TimeSpan(16, 30, 0), c_coo, sessionTypeExamenId, "PRESENTIAL", teacherPool, ref teacherPoolCursor);
            AddSessionForGroupWithTeacherPool(groupId, groupKey, new DateTime(2026, 1, 6), new TimeSpan(8, 30, 0), new TimeSpan(11, 30, 0), c_ro, sessionTypeExamenId, "PRESENTIAL", teacherPool, ref teacherPoolCursor);
            AddSessionForGroupWithTeacherPool(groupId, groupKey, new DateTime(2026, 1, 6), new TimeSpan(13, 30, 0), new TimeSpan(16, 30, 0), c_data, sessionTypeExamenId, "PRESENTIAL", teacherPool, ref teacherPoolCursor);
            AddSessionForGroupWithTeacherPool(groupId, groupKey, new DateTime(2026, 1, 7), new TimeSpan(8, 30, 0), new TimeSpan(11, 30, 0), c_dev, sessionTypeExamenId, "PRESENTIAL", teacherPool, ref teacherPoolCursor);
            AddSessionForGroupWithTeacherPool(groupId, groupKey, new DateTime(2026, 1, 7), new TimeSpan(13, 30, 0), new TimeSpan(16, 30, 0), c_ang, sessionTypeExamenId, "PRESENTIAL", teacherPool, ref teacherPoolCursor);
            AddSessionForGroupWithTeacherPool(groupId, groupKey, new DateTime(2026, 1, 8), new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0), c_msed, sessionTypeExamenId, "PRESENTIAL", teacherPool, ref teacherPoolCursor);
            AddSessionForGroupWithTeacherPool(groupId, groupKey, new DateTime(2026, 1, 9), new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0), c_infocom, sessionTypeExamenId, "PRESENTIAL", teacherPool, ref teacherPoolCursor);

            // Semaine du 04/05/2026 au 07/05/2026 - examens S2
            AddSessionForGroupWithTeacherPool(groupId, groupKey, new DateTime(2026, 5, 4), new TimeSpan(8, 30, 0), new TimeSpan(11, 30, 0), c_algoav, sessionTypeExamenId, "PRESENTIAL", teacherPool, ref teacherPoolCursor);
            AddSessionForGroupWithTeacherPool(groupId, groupKey, new DateTime(2026, 5, 4), new TimeSpan(13, 30, 0), new TimeSpan(16, 30, 0), c_hpc, sessionTypeExamenId, "PRESENTIAL", teacherPool, ref teacherPoolCursor);
            AddSessionForGroupWithTeacherPool(groupId, groupKey, new DateTime(2026, 5, 5), new TimeSpan(8, 30, 0), new TimeSpan(11, 30, 0), c_crypto, sessionTypeExamenId, "PRESENTIAL", teacherPool, ref teacherPoolCursor);
            AddSessionForGroupWithTeacherPool(groupId, groupKey, new DateTime(2026, 5, 5), new TimeSpan(13, 30, 0), new TimeSpan(16, 30, 0), c_bdd, sessionTypeExamenId, "PRESENTIAL", teacherPool, ref teacherPoolCursor);
            AddSessionForGroupWithTeacherPool(groupId, groupKey, new DateTime(2026, 5, 6), new TimeSpan(8, 30, 0), new TimeSpan(11, 30, 0), c_tech, sessionTypeExamenId, "PRESENTIAL", teacherPool, ref teacherPoolCursor);
            AddSessionForGroupWithTeacherPool(groupId, groupKey, new DateTime(2026, 5, 6), new TimeSpan(13, 30, 0), new TimeSpan(16, 30, 0), c_ter, sessionTypeSoutenanceId, "PRESENTIAL", teacherPool, ref teacherPoolCursor);
            AddSessionForGroupWithTeacherPool(groupId, groupKey, new DateTime(2026, 5, 7), new TimeSpan(8, 0, 0), new TimeSpan(10, 0, 0), c_multiagents, sessionTypeExamenId, "PRESENTIAL", teacherPool, ref teacherPoolCursor);
            AddSessionForGroupWithTeacherPool(groupId, groupKey, new DateTime(2026, 5, 7), new TimeSpan(10, 30, 0), new TimeSpan(12, 30, 0), c_specverif, sessionTypeExamenId, "PRESENTIAL", teacherPool, ref teacherPoolCursor);
            AddSessionForGroupWithTeacherPool(groupId, groupKey, new DateTime(2026, 5, 7), new TimeSpan(14, 0, 0), new TimeSpan(17, 0, 0), c_ml, sessionTypeExamenId, "PRESENTIAL", teacherPool, ref teacherPoolCursor);
        }

        DateTime? FindNextRegularTeachingDay(DateTime date, DateTime maxDate)
        {
            for (var current = date.Date; current <= maxDate.Date; current = current.AddDays(1))
            {
                if (IsRegularTeachingDay(current))
                {
                    return current;
                }
            }

            return null;
        }

        DateTime? FindNextRegularTeachingDayDistinctFrom(DateTime date, DateTime maxDate, DateTime first, DateTime second)
        {
            for (var current = date.Date; current <= maxDate.Date; current = current.AddDays(1))
            {
                if (!IsRegularTeachingDay(current))
                {
                    continue;
                }

                // Keep recovery on a different weekday than cancelled and moved sessions.
                if (current.DayOfWeek == first.DayOfWeek || current.DayOfWeek == second.DayOfWeek)
                {
                    continue;
                }

                return current;
            }

            return null;
        }

        void SeedBiweeklySessionStatusChanges(
            string groupId,
            string groupKey,
            string cancelledCourseId,
            string movedCourseId,
            DateTime schoolStart,
            DateTime schoolEnd)
        {
            var seededCancelledDates = new HashSet<DateTime>();
            var seededMovedDates = new HashSet<DateTime>();
            var seededRecoveryDates = new HashSet<DateTime>();

            for (var anchor = schoolStart.Date; anchor <= schoolEnd.Date; anchor = anchor.AddDays(14))
            {
                var cancelledDate = FindNextRegularTeachingDay(anchor, schoolEnd);
                if (!cancelledDate.HasValue)
                {
                    break;
                }

                if (!seededCancelledDates.Add(cancelledDate.Value.Date))
                {
                    continue;
                }

                AddSessionForGroupWithStatus(
                    groupId,
                    groupKey,
                    cancelledDate.Value,
                    new TimeSpan(17, 30, 0),
                    new TimeSpan(19, 0, 0),
                    cancelledCourseId,
                    sessionTypeTdId,
                    "PRESENTIAL",
                    sessionStatusCancelledId,
                    "annule");

                var movedDate = FindNextRegularTeachingDay(cancelledDate.Value.AddDays(1), schoolEnd);
                if (!movedDate.HasValue)
                {
                    continue;
                }

                if (!seededMovedDates.Add(movedDate.Value.Date))
                {
                    continue;
                }

                AddSessionForGroupWithStatus(
                    groupId,
                    groupKey,
                    movedDate.Value,
                    new TimeSpan(19, 15, 0),
                    new TimeSpan(20, 45, 0),
                    movedCourseId,
                    sessionTypeTdId,
                    "PRESENTIAL",
                    sessionStatusMovedId,
                    "deplace");

                var recoveryDate = FindNextRegularTeachingDayDistinctFrom(
                    movedDate.Value.AddDays(14),
                    schoolEnd,
                    cancelledDate.Value,
                    movedDate.Value);
                if (!recoveryDate.HasValue)
                {
                    continue;
                }

                if (!seededRecoveryDates.Add(recoveryDate.Value.Date))
                {
                    continue;
                }

                AddSessionForGroupWithStatus(
                    groupId,
                    groupKey,
                    recoveryDate.Value,
                    new TimeSpan(19, 15, 0),
                    new TimeSpan(20, 45, 0),
                    movedCourseId,
                    sessionTypeTdId,
                    "PRESENTIAL",
                    sessionStatusRecoveredId,
                    "rattrape");
            }
        }

        // 1) Génération du planning Groupe A
        GenerateRegularScheduleForGroup(groupId_M1_ILSD, "group-a");
        GenerateSpecialSessionsForGroup(groupId_M1_ILSD, "group-a");
        SeedBiweeklySessionStatusChanges(groupId_M1_ILSD, "group-a", c_sad, c_coo, new DateTime(2025, 9, 8), new DateTime(2026, 5, 11));

        // 2) Génération du planning Groupe B avec garde anti-conflit prof déjà en cours
        GenerateRegularScheduleForGroup(groupId_M1_ILSD_B, "group-b");
        GenerateSpecialSessionsForGroup(groupId_M1_ILSD_B, "group-b");
        SeedBiweeklySessionStatusChanges(groupId_M1_ILSD_B, "group-b", c_crypto, c_bdd, new DateTime(2025, 9, 8), new DateTime(2026, 5, 11));

        // 3) Génération du planning Groupe A - M1 CNS (sans évènement final de stage)
        GenerateRegularScheduleForGroupCustomCourses(
            groupId_M1_CNS,
            "group-cns-s1",
            new DateTime(2025, 9, 8),
            new DateTime(2025, 12, 19),
            cnsSemester1CourseIds,
            teacherIdsCns,
            ref teacherCursorCns);

        GenerateRegularScheduleForGroupCustomCourses(
            groupId_M1_CNS,
            "group-cns-s2",
            new DateTime(2026, 1, 12),
            new DateTime(2026, 5, 11),
            cnsSemester2CourseIds,
            teacherIdsCns,
            ref teacherCursorCns);

        GenerateSpecialSessionsForCnsGroup(groupId_M1_CNS, "group-cns", teacherIdsCns, ref teacherCursorCns);
        SeedBiweeklySessionStatusChanges(groupId_M1_CNS, "group-cns", c_msed, c_ml, new DateTime(2025, 9, 8), new DateTime(2026, 5, 11));

        // Evenement final commun aux deux groupes (sans enseignant affecte).
        var sharedFinalEventSessionId = GetStableId("session-shared-m1-ilsd-final-event-20260511");
        var sharedFinalEventRoomId = PickAvailableRoom(groupId_M1_ILSD, new DateTime(2026, 5, 11), new TimeSpan(8, 30, 0), new TimeSpan(18, 0, 0));
        RegisterRoomAssignment(sharedFinalEventRoomId, new DateTime(2026, 5, 11), new TimeSpan(8, 30, 0), new TimeSpan(18, 0, 0));
        sessions.Add(new Session
        {
            SessionId = sharedFinalEventSessionId,
            Date = new DateTime(2026, 5, 11),
            StartTime = new TimeSpan(8, 30, 0),
            EndTime = new TimeSpan(18, 0, 0),
            Mode = "PRESENTIAL",
            CourseId = c_stage,
            SessionTypeId = sessionTypeEvenementId,
            SessionStatusId = sessionStatusId,
            RoomId = sharedFinalEventRoomId
        });

        attendSeed.Add(new { GroupId = groupId_M1_ILSD, SessionId = sharedFinalEventSessionId });
        attendSeed.Add(new { GroupId = groupId_M1_ILSD_B, SessionId = sharedFinalEventSessionId });

        // Sessions de reference stables pour les changements de seance/salle.
        var seedSessionId1 = GetStableId("seed-session-room-change-001");
        var seedSessionId2 = GetStableId("seed-session-room-change-002");
        var seedSessionId3 = GetStableId("seed-session-recovery-change-001");

        var seedSessionDate1 = new DateTime(2026, 4, 7);
        var seedSessionDate2 = new DateTime(2026, 4, 8);
        var seedSessionDate3 = new DateTime(2026, 4, 9);

        var seedSessionRoom1 = PickAvailableRoom(groupId_M1_ILSD, seedSessionDate1, new TimeSpan(8, 30, 0), new TimeSpan(10, 0, 0));
        RegisterRoomAssignment(seedSessionRoom1, seedSessionDate1, new TimeSpan(8, 30, 0), new TimeSpan(10, 0, 0));
        sessions.Add(new Session
        {
            SessionId = seedSessionId1,
            Date = seedSessionDate1,
            StartTime = new TimeSpan(8, 30, 0),
            EndTime = new TimeSpan(10, 0, 0),
            Mode = "PRESENTIAL",
            CourseId = c_sad,
            SessionTypeId = sessionTypeTdId,
            SessionStatusId = sessionStatusId,
            RoomId = seedSessionRoom1
        });
        attendSeed.Add(new { GroupId = groupId_M1_ILSD, SessionId = seedSessionId1 });
        teachSeed.Add(new { TeacherId = teacherUserId, SessionId = seedSessionId1 });

        var seedSessionRoom2 = PickAvailableRoom(groupId_M1_ILSD_B, seedSessionDate2, new TimeSpan(10, 15, 0), new TimeSpan(11, 45, 0));
        RegisterRoomAssignment(seedSessionRoom2, seedSessionDate2, new TimeSpan(10, 15, 0), new TimeSpan(11, 45, 0));
        sessions.Add(new Session
        {
            SessionId = seedSessionId2,
            Date = seedSessionDate2,
            StartTime = new TimeSpan(10, 15, 0),
            EndTime = new TimeSpan(11, 45, 0),
            Mode = "PRESENTIAL",
            CourseId = c_coo,
            SessionTypeId = sessionTypeTdId,
            SessionStatusId = sessionStatusId,
            RoomId = seedSessionRoom2
        });
        attendSeed.Add(new { GroupId = groupId_M1_ILSD_B, SessionId = seedSessionId2 });
        teachSeed.Add(new { TeacherId = teacherUserId2, SessionId = seedSessionId2 });

        var seedSessionRoom3 = PickAvailableRoom(groupId_M1_ILSD, seedSessionDate3, new TimeSpan(14, 0, 0), new TimeSpan(16, 0, 0));
        RegisterRoomAssignment(seedSessionRoom3, seedSessionDate3, new TimeSpan(14, 0, 0), new TimeSpan(16, 0, 0));
        sessions.Add(new Session
        {
            SessionId = seedSessionId3,
            Date = seedSessionDate3,
            StartTime = new TimeSpan(14, 0, 0),
            EndTime = new TimeSpan(16, 0, 0),
            Mode = "PRESENTIAL",
            CourseId = c_data,
            SessionTypeId = sessionTypeTdId,
            SessionStatusId = sessionStatusId,
            RoomId = seedSessionRoom3
        });
        attendSeed.Add(new { GroupId = groupId_M1_ILSD, SessionId = seedSessionId3 });
        teachSeed.Add(new { TeacherId = teacherUserId, SessionId = seedSessionId3 });

        modelBuilder.Entity<Session>().HasData(sessions.ToArray());

        // ========================================
        // 9. ATTEND (Group <-> Session)
        // ========================================

        modelBuilder.Entity("Attend").HasData(attendSeed.ToArray());

        // ========================================
        // 10. TEACH (Teacher <-> Session)
        // ========================================

    modelBuilder.Entity("Teach").HasData(teachSeed.ToArray());

    modelBuilder.Entity<ChangeStatus>().HasData(
    new ChangeStatus
    {
        ChangeStatusId = changeStatusPendingId,
        Label = "En attente"
    },
    new ChangeStatus
    {
        ChangeStatusId = changeStatusApprovedId,
        Label = "Approuvé"
    },
    new ChangeStatus
    {
        ChangeStatusId = changeStatusRejectedId,
        Label = "Refusé"
    }
);

    var ibgbiRoom1Id = GetStableId("room-ibgbi-1");
    var ibgbiRoom2Id = GetStableId("room-ibgbi-2");

    // SessionRoomChange : 2 En attente, 2 Approuvé, 2 Refusé
    modelBuilder.Entity<SessionRoomChange>().HasData(
        // --- En attente (2) ---
        new SessionRoomChange
        {
            SessionRoomChangeId = GetStableId("seed-room-change-001"),
            ChangeDate = new DateTime(2026, 4, 5),
            Reason = "La salle actuelle est trop petite pour accueillir tous les étudiants.",
            TeacherId = teacherUserId,
            SessionId = seedSessionId1,
            ChangeStatusId = changeStatusPendingId,
            OldRoomId = null,
            ApprovedRoomId = null,
            RejectionReason = null
        },
        new SessionRoomChange
        {
            SessionRoomChangeId = GetStableId("seed-room-change-003"),
            ChangeDate = new DateTime(2026, 4, 6),
            Reason = "Problème de climatisation dans la salle assignée.",
            TeacherId = teacherUserId3,
            SessionId = seedSessionId2,
            ChangeStatusId = changeStatusPendingId,
            OldRoomId = null,
            ApprovedRoomId = null,
            RejectionReason = null
        },
        // --- Approuvé (2) ---
        new SessionRoomChange
        {
            SessionRoomChangeId = GetStableId("seed-room-change-004"),
            ChangeDate = new DateTime(2026, 3, 10),
            Reason = "Besoin d'une salle avec projecteur fonctionnel.",
            TeacherId = teacherUserId2,
            SessionId = seedSessionId3,
            ChangeStatusId = changeStatusApprovedId,
            OldRoomId = roomId,
            ApprovedRoomId = ibgbiRoom1Id,
            RejectionReason = null
        },
        new SessionRoomChange
        {
            SessionRoomChangeId = GetStableId("seed-room-change-005"),
            ChangeDate = new DateTime(2026, 3, 15),
            Reason = "La salle prévue est occupée par un autre cours.",
            TeacherId = teacherUserId4,
            SessionId = seedSessionId1,
            ChangeStatusId = changeStatusApprovedId,
            OldRoomId = ibgbiRoom1Id,
            ApprovedRoomId = ibgbiRoom2Id,
            RejectionReason = null
        },
        // --- Refusé (2) ---
        new SessionRoomChange
        {
            SessionRoomChangeId = GetStableId("seed-room-change-002"),
            ChangeDate = new DateTime(2026, 4, 5),
            Reason = "Équipement audiovisuel non disponible dans la salle actuelle.",
            TeacherId = teacherUserId2,
            SessionId = seedSessionId2,
            ChangeStatusId = changeStatusRejectedId,
            OldRoomId = null,
            ApprovedRoomId = null,
            RejectionReason = "Aucune salle compatible n'est disponible sur ce créneau."
        },
        new SessionRoomChange
        {
            SessionRoomChangeId = GetStableId("seed-room-change-006"),
            ChangeDate = new DateTime(2026, 3, 20),
            Reason = "Demande de salle plus grande pour un exposé.",
            TeacherId = teacherUserId5,
            SessionId = seedSessionId3,
            ChangeStatusId = changeStatusRejectedId,
            OldRoomId = null,
            ApprovedRoomId = null,
            RejectionReason = "La demande ne respecte pas le délai minimum de 48h avant la séance."
        }
    );

    // SessionRecoveryChange : 2 En attente, 2 Approuvé, 2 Refusé
    modelBuilder.Entity<SessionRecoveryChange>().HasData(
        // --- En attente (2) ---
        new SessionRecoveryChange
        {
            SessionRecoveryChangeId = GetStableId("seed-recovery-change-001"),
            ChangeDate = new DateTime(2026, 4, 5),
            Reason = "Le cours a été annulé, il faut le rattraper.",
            TeacherId = teacherUserId,
            SessionId = seedSessionId3,
            ChangeStatusId = changeStatusPendingId,
            ProposedDate = new DateTime(2026, 4, 20),
            ProposedStartTime = new TimeSpan(14, 0, 0),
            ProposedEndTime = new TimeSpan(16, 0, 0),
            ProposedRoomId = roomId,
            CounterProposalDate = null,
            CounterProposalStartTime = null,
            CounterProposalEndTime = null,
            CounterProposalRoomId = null,
            RejectionReason = null
        },
        new SessionRecoveryChange
        {
            SessionRecoveryChangeId = GetStableId("seed-recovery-change-002"),
            ChangeDate = new DateTime(2026, 4, 7),
            Reason = "Cours manqué suite à une grève des transports.",
            TeacherId = teacherUserId2,
            SessionId = seedSessionId1,
            ChangeStatusId = changeStatusPendingId,
            ProposedDate = new DateTime(2026, 4, 25),
            ProposedStartTime = new TimeSpan(10, 0, 0),
            ProposedEndTime = new TimeSpan(12, 0, 0),
            ProposedRoomId = ibgbiRoom1Id,
            CounterProposalDate = null,
            CounterProposalStartTime = null,
            CounterProposalEndTime = null,
            CounterProposalRoomId = null,
            RejectionReason = null
        },
        // --- Approuvé (2) ---
        new SessionRecoveryChange
        {
            SessionRecoveryChangeId = GetStableId("seed-recovery-change-003"),
            ChangeDate = new DateTime(2026, 3, 5),
            Reason = "Absence de l'enseignant pour maladie, cours à récupérer.",
            TeacherId = teacherUserId3,
            SessionId = seedSessionId2,
            ChangeStatusId = changeStatusApprovedId,
            ProposedDate = new DateTime(2026, 3, 18),
            ProposedStartTime = new TimeSpan(8, 0, 0),
            ProposedEndTime = new TimeSpan(10, 0, 0),
            ProposedRoomId = ibgbiRoom2Id,
            CounterProposalDate = null,
            CounterProposalStartTime = null,
            CounterProposalEndTime = null,
            CounterProposalRoomId = null,
            RejectionReason = null
        },
        new SessionRecoveryChange
        {
            SessionRecoveryChangeId = GetStableId("seed-recovery-change-004"),
            ChangeDate = new DateTime(2026, 3, 10),
            Reason = "Cours reporté en raison d'une réunion pédagogique.",
            TeacherId = teacherUserId4,
            SessionId = seedSessionId3,
            ChangeStatusId = changeStatusApprovedId,
            ProposedDate = new DateTime(2026, 3, 22),
            ProposedStartTime = new TimeSpan(14, 0, 0),
            ProposedEndTime = new TimeSpan(16, 0, 0),
            ProposedRoomId = roomId,
            CounterProposalDate = null,
            CounterProposalStartTime = null,
            CounterProposalEndTime = null,
            CounterProposalRoomId = null,
            RejectionReason = null
        },
        // --- Refusé (2) ---
        new SessionRecoveryChange
        {
            SessionRecoveryChangeId = GetStableId("seed-recovery-change-005"),
            ChangeDate = new DateTime(2026, 3, 15),
            Reason = "Cours annulé pour cause de conférence externe.",
            TeacherId = teacherUserId5,
            SessionId = seedSessionId1,
            ChangeStatusId = changeStatusRejectedId,
            ProposedDate = new DateTime(2026, 3, 28),
            ProposedStartTime = new TimeSpan(16, 0, 0),
            ProposedEndTime = new TimeSpan(18, 0, 0),
            ProposedRoomId = ibgbiRoom1Id,
            CounterProposalDate = new DateTime(2026, 4, 2),
            CounterProposalStartTime = new TimeSpan(10, 0, 0),
            CounterProposalEndTime = new TimeSpan(12, 0, 0),
            CounterProposalRoomId = ibgbiRoom2Id,
            RejectionReason = "Le créneau proposé est déjà réservé. Une contre-proposition a été soumise."
        },
        new SessionRecoveryChange
        {
            SessionRecoveryChangeId = GetStableId("seed-recovery-change-006"),
            ChangeDate = new DateTime(2026, 3, 20),
            Reason = "Absence imprévue de l'enseignant.",
            TeacherId = teacherUserId,
            SessionId = seedSessionId2,
            ChangeStatusId = changeStatusRejectedId,
            ProposedDate = new DateTime(2026, 4, 5),
            ProposedStartTime = new TimeSpan(8, 0, 0),
            ProposedEndTime = new TimeSpan(10, 0, 0),
            ProposedRoomId = roomId,
            CounterProposalDate = null,
            CounterProposalStartTime = null,
            CounterProposalEndTime = null,
            CounterProposalRoomId = null,
            RejectionReason = "La date proposée est en dehors de la période académique autorisée."
        }
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
        return BCrypt.Net.BCrypt.HashPassword(password, saltBCrypt);
    }
}
