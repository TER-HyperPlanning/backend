using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class Session
{
    public string SessionId { get; set; } = null!;

    public DateTime Date { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public string Mode { get; set; } = null!;

    public string SessionTypeId { get; set; } = null!;

    public string CourseId { get; set; } = null!;

    public string SessionStatusId { get; set; } = null!;

    public string RoomId { get; set; } = null!;

    public string? Description { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;

    public virtual ICollection<SessionChange> SessionChanges { get; set; } = new List<SessionChange>();

    public virtual SessionStatus SessionStatus { get; set; } = null!;

    public virtual SessionType SessionType { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
