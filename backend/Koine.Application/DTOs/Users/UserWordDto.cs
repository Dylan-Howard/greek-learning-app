// GreekParser.Application/DTOs/Users/UserWordDto.cs
namespace GreekParser.Application.DTOs.Users
{
    public class UserWordDto
    {
        public int WordId { get; set; }
        public string? GreekWord { get; set; }
        public string? EnglishMeaning { get; set; }
        public int KnowledgeLevel { get; set; }
    }
}
