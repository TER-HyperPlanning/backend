using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class RoomType
{
    public string RoomTypeId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
