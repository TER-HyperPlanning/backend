namespace HP2.Application.DTOs.Unavailableday
{
    public class UpdateUnavailableDayRequest
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string UnavailableDayTypeId { get; set; } = string.Empty;
    }
}