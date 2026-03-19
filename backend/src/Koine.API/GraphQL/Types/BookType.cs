using GraphQL.Types;
using Koine.Application.DTOs.Books;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="BookDto"/>.</summary>
public class BookType : ObjectGraphType<BookDto>
{
    public BookType()
    {
        Name = "Book";
        Description = "A book in the corpus (e.g. a NT book).";

        Field<NonNullGraphType<IntGraphType>>("id").Resolve(ctx => ctx.Source.Id);
        Field<NonNullGraphType<StringGraphType>>("title").Resolve(ctx => ctx.Source.Title);
        Field<NonNullGraphType<StringGraphType>>("languageCode").Resolve(ctx => ctx.Source.LanguageCode);
        Field<NonNullGraphType<IntGraphType>>("chapterCount").Resolve(ctx => ctx.Source.ChapterCount);

        // chapters field is resolved via ChaptersByBookIdDataLoader — wired in Task 3
        Field<NonNullGraphType<ListGraphType<NonNullGraphType<ChapterType>>>>("chapters")
            .Description("Chapters in this book — resolved via DataLoader in Task 3.")
            .Resolve(_ => new List<Application.DTOs.Chapters.ChapterDto>());
    }
}
