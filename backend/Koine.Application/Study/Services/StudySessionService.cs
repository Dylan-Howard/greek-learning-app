// Koine.Application/Study/Services/StudySessionService.cs
using System.Text.Json;
using Koine.Application.Study.DTOs;
using Koine.Application.Study.Ports;
using Koine.Domain.Entities;
using Koine.Domain.ValueObjects;

namespace Koine.Application.Study.Services
{
    public class StudySessionService(
        ICurrentUserProvider userProvider,
        IUserCardProgressRepository progressRepo,
        IStudySessionRepository sessionRepo,
        IVocabularyRepository vocabRepo,
        IVocabularySetItemRepository setItemRepo)
    {
        public async Task<SessionDto> StartSessionAsync(StartSessionRequest request, CancellationToken ct)
        {
            var userId = userProvider.GetUserId();
            var explicitVocabularyIds = request.VocabularyIds?
                .Where(id => id > 0)
                .Distinct()
                .ToList();
            var vocabScope = explicitVocabularyIds != null && explicitVocabularyIds.Count > 0
                ? explicitVocabularyIds
                : await ResolveVocabularyScopeAsync(request.VocabularySetId, ct);

            var limit = request.CardCount <= 0 ? int.MaxValue : request.CardCount;
            var cards = new List<UserCardProgress>();

            if (explicitVocabularyIds != null && explicitVocabularyIds.Count > 0)
            {
                foreach (var vocabId in explicitVocabularyIds.Take(limit))
                {
                    var progress = await progressRepo.GetByVocabularyIdAsync(userId, vocabId, ct)
                        ?? new UserCardProgress
                        {
                            UserId = userId,
                            VocabularyId = vocabId,
                            Stability = 0f,
                            Difficulty = 5f,
                            ElapsedDays = 0f,
                            ScheduledDays = 0f,
                            ReviewCount = 0,
                            Lapses = 0,
                            State = CardState.New,
                            NextReviewDate = DateTime.UtcNow
                        };
                    cards.Add(progress);
                }
            }
            else
            {
                if (request.Pool is CardPool.DueOnly or CardPool.Mixed)
                {
                    var due = await progressRepo.GetDueCardsAsync(userId, limit, vocabScope, ct);
                    cards.AddRange(due);
                }

                if (request.Pool is CardPool.NewOnly or CardPool.Mixed)
                {
                    var remaining = limit == int.MaxValue ? int.MaxValue : Math.Max(limit - cards.Count, 0);
                    if (remaining > 0)
                    {
                        var newCards = await progressRepo.GetNewCardsAsync(userId, remaining, vocabScope, ct);
                        cards.AddRange(newCards);
                    }
                }

                if (limit != int.MaxValue)
                {
                    cards = cards.Take(limit).ToList();
                }
            }

            var session = new StudySession
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                StartedAt = DateTime.UtcNow,
                Config = new SessionConfig
                {
                    CardCount = request.CardCount,
                    Pool = request.Pool,
                    Direction = request.Direction,
                    Mode = request.Mode,
                    VocabularySetId = request.VocabularySetId
                }
            };

            var position = 1;
            var cardSequence = explicitVocabularyIds != null && explicitVocabularyIds.Count > 0
                ? cards
                : cards.OrderBy(_ => Random.Shared.Next()).ToList();
            foreach (var card in cardSequence)
            {
                var interactionMode = ResolveInteractionMode(request.Mode, position);
                var direction = ResolveDirection(request.Direction, Random.Shared);
                var choicesJson = interactionMode == InteractionMode.MultipleChoice
                    ? await BuildChoicesJsonAsync(card.VocabularyId, direction, ct)
                    : null;

                session.Cards.Add(new SessionCard
                {
                    SessionId = session.Id,
                    VocabularyId = card.VocabularyId,
                    Position = position,
                    Mode = interactionMode,
                    ChoicesJson = choicesJson,
                    Direction = direction
                });

                position += 1;
            }

            await sessionRepo.SaveAsync(session, ct);

            return new SessionDto
            {
                Id = session.Id,
                TotalCards = session.Cards.Count,
                CardsReviewed = 0,
                StartedAt = session.StartedAt,
                CompletedAt = session.CompletedAt,
                Pool = request.Pool,
                Direction = request.Direction,
                Mode = request.Mode,
                VocabularySetId = request.VocabularySetId
            };
        }

        public async Task<SessionDto?> GetSessionAsync(Guid sessionId, CancellationToken ct)
        {
            var session = await sessionRepo.GetByIdAsync(sessionId, ct);
            if (session == null) return null;

            var reviewed = session.Cards.Count(c => c.GivenRating != null);
            return new SessionDto
            {
                Id = session.Id,
                TotalCards = session.Cards.Count,
                CardsReviewed = reviewed,
                StartedAt = session.StartedAt,
                CompletedAt = session.CompletedAt,
                Pool = session.Config.Pool,
                Direction = session.Config.Direction,
                Mode = session.Config.Mode,
                VocabularySetId = session.Config.VocabularySetId
            };
        }

        public async Task<CardDto?> GetNextCardAsync(Guid sessionId, CancellationToken ct)
        {
            var session = await sessionRepo.GetByIdAsync(sessionId, ct);
            if (session == null) return null;

            var next = session.Cards
                .OrderBy(c => c.Position)
                .FirstOrDefault(c => c.GivenRating == null);

            if (next == null) return null;

            var vocab = (await vocabRepo.GetByIdsAsync([next.VocabularyId], ct)).FirstOrDefault();
            if (vocab == null) return null;

            var choices = string.IsNullOrWhiteSpace(next.ChoicesJson)
                ? null
                : JsonSerializer.Deserialize<string[]>(next.ChoicesJson);

            return ToCardDto(next, vocab, session.Cards.Count, choices);
        }

        public async Task<RateCardResponse?> RateCardAsync(
            Guid sessionId,
            int vocabularyId,
            Rating rating,
            CancellationToken ct)
        {
            var userId = userProvider.GetUserId();
            var session = await sessionRepo.GetByIdAsync(sessionId, ct);
            if (session == null) return null;

            var card = session.Cards.FirstOrDefault(c => c.VocabularyId == vocabularyId);
            if (card == null) return null;

            var progress = await progressRepo.GetByVocabularyIdAsync(userId, vocabularyId, ct)
                ?? new UserCardProgress
                {
                    UserId = userId,
                    VocabularyId = vocabularyId,
                    Stability = 0f,
                    Difficulty = 5f,
                    ElapsedDays = 0f,
                    ScheduledDays = 0f,
                    ReviewCount = 0,
                    Lapses = 0,
                    State = CardState.New,
                    NextReviewDate = DateTime.UtcNow
                };

            var input = new FsrsInput(progress, rating, DateTime.UtcNow);
            var output = FsrsScheduler.Schedule(input);

            progress.Stability = output.Stability;
            progress.Difficulty = output.Difficulty;
            progress.ElapsedDays = output.ElapsedDays;
            progress.ScheduledDays = output.ScheduledDays;
            progress.State = output.NextState;
            progress.LastReviewDate = input.ReviewedAt;
            progress.NextReviewDate = output.NextReviewDate;
            progress.ReviewCount += 1;
            if (rating == Rating.Again && progress.State == CardState.Relearning)
            {
                progress.Lapses += 1;
            }

            await progressRepo.UpsertAsync(progress, ct);

            card.GivenRating = rating;
            card.ReviewedAt = input.ReviewedAt;

            await sessionRepo.SaveAsync(session, ct);

            var sessionComplete = session.Cards.All(c => c.GivenRating != null);

            return new RateCardResponse
            {
                NextReviewDate = output.NextReviewDate,
                ScheduledDays = output.ScheduledDays,
                NewState = output.NextState,
                SessionComplete = sessionComplete
            };
        }

        public async Task<SessionSummaryDto?> CompleteSessionAsync(Guid sessionId, CancellationToken ct)
        {
            var session = await sessionRepo.GetByIdAsync(sessionId, ct);
            if (session == null) return null;

            session.CompletedAt = DateTime.UtcNow;
            await sessionRepo.SaveAsync(session, ct);

            var rated = session.Cards.Where(c => c.GivenRating != null).ToList();
            var total = rated.Count;
            var correct = rated.Count(c => c.GivenRating != Rating.Again);
            var ratings = rated
                .GroupBy(c => c.GivenRating!.Value)
                .ToDictionary(g => g.Key, g => g.Count());

            var percentage = total == 0 ? 0 : (double)correct / total * 100.0;

            return new SessionSummaryDto
            {
                TotalReviewed = total,
                CorrectCount = correct,
                CorrectPercentage = percentage,
                Ratings = ratings
            };
        }

        public async Task<DashboardDto> GetDashboardAsync(CancellationToken ct)
        {
            var userId = userProvider.GetUserId();
            var stats = await progressRepo.GetDashboardStatsAsync(userId, ct);
            var history = await sessionRepo.GetReviewHistoryAsync(userId, 7, ct);

            return new DashboardDto
            {
                TotalCards = stats.TotalCards,
                DueToday = stats.DueToday,
                NewCards = stats.NewCards,
                LearningCards = stats.LearningCards,
                ReviewCards = stats.ReviewCards,
                RelearningCards = stats.RelearningCards,
                CurrentStreak = stats.CurrentStreak,
                ReviewHistory = history
                    .Select(h => new ReviewHistoryDto { Date = h.Date, Count = h.Count })
                    .ToList()
            };
        }

        public async Task<List<CardProgressDto>> GetProgressAsync(CancellationToken ct)
        {
            var userId = userProvider.GetUserId();
            var progress = await progressRepo.GetAllForUserAsync(userId, ct);
            var vocab = await vocabRepo.GetByIdsAsync(progress.Select(p => p.VocabularyId), ct);
            var vocabById = vocab.ToDictionary(v => v.Id);

            return progress.Select(p =>
            {
                vocabById.TryGetValue(p.VocabularyId, out var v);
                return new CardProgressDto
                {
                    VocabularyId = p.VocabularyId,
                    Root = v?.Root ?? string.Empty,
                    Gloss = v?.Gloss ?? string.Empty,
                    State = p.State,
                    Difficulty = p.Difficulty,
                    Stability = p.Stability,
                    NextReviewDate = p.NextReviewDate,
                    ReviewCount = p.ReviewCount,
                    Lapses = p.Lapses
                };
            }).ToList();
        }

        private async Task<IEnumerable<int>?> ResolveVocabularyScopeAsync(int? vocabularySetId, CancellationToken ct)
        {
            if (!vocabularySetId.HasValue) return null;
            return await setItemRepo.GetVocabularyIdsForSetAsync(vocabularySetId.Value, ct);
        }

        private static InteractionMode ResolveInteractionMode(InteractionMode configMode, int position)
        {
            return configMode switch
            {
                InteractionMode.Mix => position % 2 == 0 ? InteractionMode.MultipleChoice : InteractionMode.Flip,
                _ => configMode
            };
        }

        private static StudyDirection ResolveDirection(StudyDirection direction, Random rng)
        {
            if (direction != StudyDirection.Random) return direction;
            return rng.Next(0, 2) == 0 ? StudyDirection.GreekToEnglish : StudyDirection.EnglishToGreek;
        }

        private async Task<string> BuildChoicesJsonAsync(int vocabularyId, StudyDirection direction, CancellationToken ct)
        {
            var vocab = (await vocabRepo.GetByIdsAsync([vocabularyId], ct)).FirstOrDefault();
            if (vocab == null) return "[]";

            var distractors = new List<string>();
            var attempts = 0;
            while (distractors.Count < 3 && attempts < 25)
            {
                attempts += 1;
                var sample = await vocabRepo.GetRandomSampleAsync(1, ct);
                var candidate = sample.FirstOrDefault();
                if (candidate == null || candidate.Id == vocabularyId) continue;

                var value = direction == StudyDirection.GreekToEnglish
                    ? candidate.Gloss
                    : candidate.Root;

                if (!string.IsNullOrWhiteSpace(value) && !distractors.Contains(value))
                {
                    distractors.Add(value);
                }
            }

            var correct = direction == StudyDirection.GreekToEnglish ? vocab.Gloss : vocab.Root;
            var choices = distractors.Concat([correct]).Distinct().OrderBy(_ => Guid.NewGuid()).ToArray();
            return JsonSerializer.Serialize(choices);
        }

        private static CardDto ToCardDto(SessionCard card, Vocabulary vocab, int totalCards, string[]? choices)
        {
            var frontRoot = card.Direction == StudyDirection.EnglishToGreek ? vocab.Gloss : vocab.Root;
            var backGloss = card.Direction == StudyDirection.EnglishToGreek ? vocab.Root : vocab.Gloss;

            return new CardDto
            {
                SessionCardId = card.Id,
                VocabularyId = vocab.Id,
                Position = card.Position,
                TotalCards = totalCards,
                Front = new CardDto.CardFront
                {
                    Root = frontRoot,
                    Transliteration = vocab.Transliteration,
                    PartOfSpeech = vocab.PartOfSpeech,
                    Occurrences = vocab.Occurrences
                },
                Back = new CardDto.CardBack
                {
                    Gloss = backGloss
                },
                InteractionMode = card.Mode,
                Choices = choices,
                Direction = card.Direction
            };
        }
    }
}
