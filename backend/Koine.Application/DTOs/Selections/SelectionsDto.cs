// GreekParser.Application/DTOs/Selections/SelectionsDto.cs
namespace GreekParser.Application.DTOs.Selections
{
    public class SelectionsDto
    {
        public TextSelectionDto[] Texts { get; set; }
        public ChapterSelectionDto[] Chapters { get; set; }
    }
}
