using System.ComponentModel.DataAnnotations;
using HP2.Domain.Enums;

namespace HP2.Application.DTOs.Unavailableday
{
    public class UpdateUnavailableDayRequest
    {
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public string StartTime { get; set; } = null!;

        [Required]
        public string EndTime { get; set; } = null!;

        [Required]
        public UnavailableDayTypeEnum Type { get; set; }
    }
}