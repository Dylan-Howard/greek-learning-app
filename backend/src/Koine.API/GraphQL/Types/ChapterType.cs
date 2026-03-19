using GraphQL.Types;
using Koine.Application.DTOs.Chapters;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="ChapterDto"/>.</summary>
public class ChapterType : ObjectGraphType<ChapterDto>
{
    public ChapterType()
    {
        Name = "Chapter";
        Description = "A chapter within a book, containing a tree of rendered units.";

        Field<NonNullGraphType<IntGraphType>>("id").Resolve(ctx => ctx.Source.Id);
        Field<NonNullGraphType<IntGraphType>>("bookId").Resolve(ctx => ctx.Source.BookId);
        Field<NonNullGraphType<IntGraphType>>("chapterIndex").Resolve(ctx => ctx.Source.ChapterIndex);
        Field<StringGraphType>("title").Resolve(ctx => ctx.Source.Title);
        Field<NonNullGraphType<StringGraphType>>("createdAt")
            .Resolve(ctx => ctx.Source.CreatedAt.ToString("O"));

        // words field is resolved via WordsByChapterIdDataLoader — wired in Task 3
        Field<NonNullGraphType<ListGraphType<NonNullGraphType<WordType>>>>("words")
            .Description("Words in this chapter — resolved via DataLoader in Task 3.")
            .Resolve(_ => new List<Application.DTOs.Vocabulary.VocabularyDto>());
    }
}
