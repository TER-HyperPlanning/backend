using System.ComponentModel.DataAnnotations;

namespace HP2.Application.DTOs.Track
{
    public class CreateTrackRequest
    {
        [Required (ErrorMessage = "Track name is required.")]
        public string Name { get; set; } = string.Empty;

        [Required (ErrorMessage = "Teacher ID is required.")]
        public string TeacherId { get; set; } = string.Empty;

        [Required (ErrorMessage = "Program ID is required.")]
        public string ProgramId { get; set; } = string.Empty;
    }
}