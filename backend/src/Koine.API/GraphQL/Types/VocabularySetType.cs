using GraphQL.Types;
using Koine.Application.DTOs.Study;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="VocabularySetDto"/>.</summary>
public class VocabularySetType : ObjectGraphType<VocabularySetDto>
{
    public VocabularySetType()
    {
        Name = "VocabularySet";
        Description = "A named collection of vocabulary words used for spaced-repetition study.";

        Field<NonNullGraphType<IntGraphType>>("id").Resolve(ctx => ctx.Source.Id);
        Field<IntGraphType>("ownerUserId").Resolve(ctx => ctx.Source.OwnerUserId);
        Field<NonNullGraphType<BooleanGraphType>>("isSystem").Resolve(ctx => ctx.Source.IsSystem);
        Field<NonNullGraphType<StringGraphType>>("slug").Resolve(ctx => ctx.Source.Slug);
        Field<IntGraphType>("bookId").Resolve(ctx => ctx.Source.BookId);
        Field<NonNullGraphType<StringGraphType>>("title").Resolve(ctx => ctx.Source.Title);
        Field<NonNullGraphType<StringGraphType>>("description").Resolve(ctx => ctx.Source.Description);
        Field<NonNullGraphType<StringGraphType>>("createdAt")
            .Resolve(ctx => ctx.Source.CreatedAt.ToString("O"));
        Field<StringGraphType>("lastPracticed")
            .Resolve(ctx => ctx.Source.LastPracticed?.ToString("O"));
        Field<NonNullGraphType<IntGraphType>>("totalCount").Resolve(ctx => ctx.Source.TotalCount);
        Field<NonNullGraphType<IntGraphType>>("knownCount").Resolve(ctx => ctx.Source.KnownCount);
        Field<NonNullGraphType<IntGraphType>>("learningCount").Resolve(ctx => ctx.Source.LearningCount);
        Field<NonNullGraphType<FloatGraphType>>("percentComplete").Resolve(ctx => ctx.Source.PercentComplete);
        Field<NonNullGraphType<ListGraphType<NonNullGraphType<VocabularySetItemType>>>>("items")
            .Resolve(ctx => ctx.Source.Items);
    }
}
