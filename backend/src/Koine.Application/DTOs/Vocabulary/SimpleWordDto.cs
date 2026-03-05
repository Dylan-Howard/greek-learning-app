// Koine.Application/DTOs/Vocabulary/SimpleWordDto.cs
using System;

namespace Koine.Application.DTOs.Vocabulary
{
    public class SimpleWordDto
    {
        public Guid RootGUID { get; set; }
        public int RootId { get; set; }
        public string Content { get; set; } = string.Empty;
        public int Occurrences { get; set; }
        public string? Gloss { get; set; }
    }
}
