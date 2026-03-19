// Koine.Application/DTOs/Users/OnboardingDto.cs
namespace Koine.Application.DTOs.Users
{
    /// <summary>Request body for the onboarding rank endpoint.</summary>
    public class OnboardingDto
    {
        /// <summary>
        /// The user's self-reported knowledge rank.
        /// Valid values: beginner | intermediate | scholar | advanced
        /// </summary>
        public string Rank { get; set; } = string.Empty;
    }
}
