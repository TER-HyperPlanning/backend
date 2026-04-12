using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class Teacher
{
    public string UserId { get; set; } = null!;

    public string RegistrationNumber { get; set; } = null!;

    public string TeacherTitleId { get; set; } = null!;

    public virtual ICollection<Availability> Availabilities { get; set; } = new List<Availability>();

    public virtual ICollection<SessionRoomChange> SessionRoomChanges { get; set; } = new List<SessionRoomChange>();

    public virtual ICollection<SessionRecoveryChange> SessionRecoveryChanges { get; set; } = new List<SessionRecoveryChange>();

    public virtual TeacherTitle TeacherTitle { get; set; } = null!;

    public virtual ICollection<Track> Tracks { get; set; } = new List<Track>();

    public virtual User User { get; set; } = null!;

    public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();
}
