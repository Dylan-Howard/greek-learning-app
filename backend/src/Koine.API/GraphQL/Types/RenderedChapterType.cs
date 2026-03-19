using GraphQL.Types;
using Koine.Application.DTOs.Reader;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="RenderedChapterDto"/>.</summary>
public class RenderedChapterType : ObjectGraphType<RenderedChapterDto>
{
    public RenderedChapterType()
    {
        Name = "RenderedChapter";
        Description = "A fully rendered chapter with its tree of display units.";

        Field<NonNullGraphType<IntGraphType>>("chapterId").Resolve(ctx => ctx.Source.ChapterId);
        Field<NonNullGraphType<StringGraphType>>("title").Resolve(ctx => ctx.Source.Title);
        Field<NonNullGraphType<ListGraphType<NonNullGraphType<RenderedUnitType>>>>("units")
            .Resolve(ctx => ctx.Source.Units);
    }
}
