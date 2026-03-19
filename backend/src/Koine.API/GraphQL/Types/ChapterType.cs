using GraphQL;
using GraphQL.Types;
using Koine.API.GraphQL.DataLoaders;
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

        Field<NonNullGraphType<ListGraphType<NonNullGraphType<WordType>>>>("words")
            .Description("Words in this chapter, resolved via WordsByChapterIdDataLoader.")
            .Resolve(ctx =>
            {
                var loader = ctx.RequestServices!.GetRequiredService<WordsByChapterIdDataLoader>();
                return loader.LoadAsync(ctx.Source.Id);
            });
    }
}
