// Koine.Application/DTOs/Translations/SimpleTranslationDto.cs
using System;

namespace Koine.Application.DTOs.Translations
{
    public class SimpleTranslationDto
    {
        public Guid TranslationGuid { get; set; }
        public int TranslationId { get; set; }
        public int UnitId { get; set; }
        public string Content { get; set; }
    }
}
