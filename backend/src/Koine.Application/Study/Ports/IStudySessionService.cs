using Koine.Application.Study.DTOs;
using Koine.Domain.Entities;
using Koine.Domain.ValueObjects;

namespace Koine.Application.Study.Ports;

/// <summary>
/// Port for study session operations: starting sessions, rating cards,
/// completing sessions, and retrieving dashboard/progress data.
/// </summary>
public interface IStudySessionService
{
    /// <summary>Starts a new study session for the current user.</summary>
    Task<SessionDto> StartSessionAsync(StartSessionRequest request, CancellationToken ct);

    /// <summary>Returns the session with the given ID, or null if not found.</summary>
    Task<SessionDto?> GetSessionAsync(Guid sessionId, CancellationToken ct);

    /// <summary>Returns the next card in the session, or null if the session is complete.</summary>
    Task<CardDto?> GetNextCardAsync(Guid sessionId, CancellationToken ct);

    /// <summary>Records a rating for a card and advances the session.</summary>
    Task<RateCardResponse?> RateCardAsync(Guid sessionId, int vocabularyId, Rating rating, CancellationToken ct);

    /// <summary>Completes the session and returns a summary.</summary>
    Task<SessionSummaryDto?> CompleteSessionAsync(Guid sessionId, CancellationToken ct);

    /// <summary>Returns the study dashboard for the current user.</summary>
    Task<DashboardDto> GetDashboardAsync(CancellationToken ct);

    /// <summary>Returns card progress records for the current user.</summary>
    Task<List<CardProgressDto>> GetProgressAsync(CancellationToken ct);
}
