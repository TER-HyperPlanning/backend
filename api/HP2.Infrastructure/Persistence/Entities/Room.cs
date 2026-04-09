using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class Room
{
    public string RoomId { get; set; } = null!;

    public string RoomNumber { get; set; } = null!;

    public bool? IsAvailable { get; set; }

    public int Capacity { get; set; }

    public string BuildingId { get; set; } = null!;

    public string RoomTypeId { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Building Building { get; set; } = null!;

    public virtual RoomType RoomType { get; set; } = null!;

    public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();
}
