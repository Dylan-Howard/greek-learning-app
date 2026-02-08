// GreekParser.Application/DTOs/Features/SimpleGrammaticalFormDto.cs
using System;

namespace GreekParser.Application.DTOs.Features
{
    public class SimpleGrammaticalFormDto
    {
        public Guid GrammarGUID { get; set; }
        public int GrammarId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public int LessonId { get; set; }
    }
}
