// Koine.Application/Study/Services/FsrsScheduler.cs
using Koine.Domain.Entities;

namespace Koine.Application.Study.Services
{
    public record FsrsInput(
        UserCardProgress Card,
        Rating Rating,
        DateTime ReviewedAt,
        float DesiredRetention = 0.9f,
        float[]? Weights = null
    );

    public record FsrsOutput(
        float Stability,
        float Difficulty,
        float ScheduledDays,
        float ElapsedDays,
        CardState NextState,
        DateTime NextReviewDate
    );

    public static class FsrsScheduler
    {
        private const float Factor = 19f / 81f;
        private const float Decay = -0.5f;
        private const int MaxIntervalDays = 36500;

        private static readonly float[] DefaultWeights =
        [
            0.4072f, 1.1829f, 3.1262f, 15.4722f, 7.2102f, 0.5316f, 1.0651f,
            0.0589f, 1.5330f, 0.1544f, 1.0070f, 1.9395f, 0.1100f, 0.2900f,
            2.2700f, 0.0700f, 2.9898f, 0.5100f, 0.4300f
        ];

        public static FsrsOutput Schedule(FsrsInput input)
        {
            var w = input.Weights ?? DefaultWeights;
            var card = input.Card;
            var rating = input.Rating;
            var now = input.ReviewedAt;

            var elapsedDays = card.LastReviewDate.HasValue
                ? (float)Math.Max((now - card.LastReviewDate.Value).TotalDays, 0)
                : 0f;

            var nextState = GetNextState(card.State, rating);

            if (card.State is CardState.New or CardState.Learning or CardState.Relearning)
            {
                return ScheduleLearning(card, rating, now, elapsedDays, nextState, w, input.DesiredRetention);
            }

            return ScheduleReview(card, rating, now, elapsedDays, nextState, w, input.DesiredRetention);
        }

        private static FsrsOutput ScheduleLearning(
            UserCardProgress card,
            Rating rating,
            DateTime now,
            float elapsedDays,
            CardState nextState,
            float[] w,
            float desiredRetention)
        {
            if (rating == Rating.Easy)
            {
                /// <summary>Initial stability S0(rating) = w[rating-1].</summary>
                var stability = InitialStability(rating, w);
                /// <summary>Initial difficulty D0(rating) = w4 - exp(w5*(rating-1)) + 1.</summary>
                var difficulty = InitialDifficulty(rating, w);
                /// <summary>Next interval calculation from desired retention.</summary>
                var scheduledDays = ComputeIntervalDays(stability, desiredRetention);
                var nextReview = now.AddDays(scheduledDays);

                return new FsrsOutput(
                    stability,
                    difficulty,
                    scheduledDays,
                    elapsedDays,
                    CardState.Review,
                    nextReview
                );
            }

            var minutes = rating switch
            {
                Rating.Again => 1,
                Rating.Hard => 5,
                _ => 10
            };

            var nextReviewDate = now.AddMinutes(minutes);
            var scheduledDaysLearning = (float)TimeSpan.FromMinutes(minutes).TotalDays;

            var stabilityLearning = card.Stability <= 0f
                ? InitialStability(rating, w)
                : card.Stability;

            var difficultyLearning = card.Difficulty <= 0f
                ? InitialDifficulty(rating, w)
                : card.Difficulty;

            return new FsrsOutput(
                stabilityLearning,
                difficultyLearning,
                scheduledDaysLearning,
                elapsedDays,
                nextState,
                nextReviewDate
            );
        }

        private static FsrsOutput ScheduleReview(
            UserCardProgress card,
            Rating rating,
            DateTime now,
            float elapsedDays,
            CardState nextState,
            float[] w,
            float desiredRetention)
        {
            var retrievability = Retrievability(elapsedDays, card.Stability);

            float stability;
            if (rating == Rating.Again)
            {
                /// <summary>Stability after forgetting Sl(D,S,R).</summary>
                stability = StabilityAfterLapse(card.Difficulty, card.Stability, retrievability, w);
            }
            else
            {
                /// <summary>Stability after recall Sr(D,S,R,rating).</summary>
                stability = StabilityAfterRecall(card.Difficulty, card.Stability, retrievability, rating, w);
            }

            /// <summary>Difficulty update D' using ΔD and D0(4).</summary>
            var difficulty = UpdatedDifficulty(card.Difficulty, rating, w);

            /// <summary>Next interval calculation from desired retention.</summary>
            var scheduledDays = ComputeIntervalDays(stability, desiredRetention);
            var nextReview = now.AddDays(scheduledDays);

            return new FsrsOutput(
                stability,
                difficulty,
                scheduledDays,
                elapsedDays,
                nextState,
                nextReview
            );
        }

        private static CardState GetNextState(CardState state, Rating rating)
        {
            return state switch
            {
                CardState.New => CardState.Learning,
                CardState.Learning => rating == Rating.Easy ? CardState.Review : CardState.Learning,
                CardState.Review => rating == Rating.Again ? CardState.Relearning : CardState.Review,
                CardState.Relearning => rating == Rating.Again ? CardState.Relearning : CardState.Review,
                _ => CardState.Learning
            };
        }

        private static float InitialStability(Rating rating, float[] w)
        {
            return w[(int)rating - 1];
        }

        private static float InitialDifficulty(Rating rating, float[] w)
        {
            var d0 = w[4] - (float)Math.Exp(w[5] * ((int)rating - 1)) + 1f;
            return Clamp(d0, 1f, 10f);
        }

        private static float Retrievability(float elapsedDays, float stability)
        {
            if (stability <= 0f)
            {
                return 0f;
            }

            return (float)Math.Pow(1f + Factor * elapsedDays / stability, Decay);
        }

        private static float ComputeIntervalDays(float stability, float desiredRetention)
        {
            if (stability <= 0f)
            {
                return 1f;
            }

            var nextInterval = (stability / Factor) * (Math.Pow(desiredRetention, 1 / Decay) - 1);
            var interval = (int)Math.Round(nextInterval);
            return Clamp(interval, 1, MaxIntervalDays);
        }

        private static float StabilityAfterRecall(
            float difficulty,
            float stability,
            float retrievability,
            Rating rating,
            float[] w)
        {
            var hardPenalty = rating == Rating.Hard ? w[15] : 1f;
            var easyBonus = rating == Rating.Easy ? w[16] : 1f;

            var multiplier =
                (float)Math.Exp(w[8]) *
                (11f - difficulty) *
                (float)Math.Pow(stability, -w[9]) *
                ((float)Math.Exp(w[10] * (1f - retrievability)) - 1f) *
                hardPenalty *
                easyBonus;

            return stability * (multiplier + 1f);
        }

        private static float StabilityAfterLapse(
            float difficulty,
            float stability,
            float retrievability,
            float[] w)
        {
            return w[11] *
                   (float)Math.Pow(difficulty, -w[12]) *
                   ((float)Math.Pow(stability + 1f, w[13]) - 1f) *
                   (float)Math.Exp(w[14] * (1f - retrievability));
        }

        private static float UpdatedDifficulty(float difficulty, Rating rating, float[] w)
        {
            var d0easy = InitialDifficulty(Rating.Easy, w);
            var delta = -w[6] * ((int)rating - 3);
            var updated = w[7] * d0easy + (1f - w[7]) * (difficulty + delta * ((10f - difficulty) / 9f));
            return Clamp(updated, 1f, 10f);
        }

        private static float Clamp(float value, float min, float max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        private static int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }
}
