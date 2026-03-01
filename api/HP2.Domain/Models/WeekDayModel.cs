namespace HP2.Domain.Models
{
    public class WeekDayModel
    {
        public string WeekdayId { get; set; } = null!;
        public byte OrderIndex { get; set; }
        public string Name { get; set; } = null!;
    }
}

