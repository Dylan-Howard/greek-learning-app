// Koine.Application/DTOs/Progress/UserProgressDto.cs
namespace Koine.Application.DTOs.Progress
{
    public class UserProgressDto
    {
        public List<int> CompletedLessonIds { get; set; } = new();
        public Dictionary<int, FeatureProgressDto> GrammaticalFeatureProgress { get; set; } = new();
        public Dictionary<int, FeatureProgressDto> SyntacticalFeatureProgress { get; set; } = new();
        public Dictionary<int, VocabularyProgressDto> VocabularyProgress { get; set; } = new();
        public DateTime UpdatedAt { get; set; }
    }
}
