using System.ComponentModel.DataAnnotations;

namespace HP2.Application.DTOs.Track
{
    public class UpdateTrackRequest
    {
        [Required (ErrorMessage = "Track name is required.")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Teacher ID is required.")]
        public string TeacherId { get; set; }

        [Required (ErrorMessage = "Program ID is required.")]
        public string ProgramId { get; set; }
        public string? Description { get; set; }
        public string? Lieu { get; set; }
    }
}