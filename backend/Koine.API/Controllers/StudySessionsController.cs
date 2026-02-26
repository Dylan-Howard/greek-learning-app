// Koine.API/Controllers/StudySessionsController.cs
using Koine.Application.Study.DTOs;
using Koine.Application.Study.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Koine.API.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/study")]
    public class StudySessionsController : ControllerBase
    {
        private readonly StudySessionService _studySessionService;

        public StudySessionsController(StudySessionService studySessionService)
        {
            _studySessionService = studySessionService;
        }

        [HttpPost("sessions")]
        public async Task<ActionResult<SessionDto>> StartSession([FromBody] StartSessionRequest request, CancellationToken ct)
        {
            var session = await _studySessionService.StartSessionAsync(request, ct);
            return CreatedAtAction(nameof(GetSession), new { id = session.Id }, session);
        }

        [HttpGet("sessions/{id:guid}")]
        public async Task<ActionResult<SessionDto>> GetSession(Guid id, CancellationToken ct)
        {
            var session = await _studySessionService.GetSessionAsync(id, ct);
            if (session == null)
            {
                return NotFound(new { message = "Session not found" });
            }

            return Ok(session);
        }

        [HttpGet("sessions/{id:guid}/next-card")]
        public async Task<ActionResult<CardDto>> GetNextCard(Guid id, CancellationToken ct)
        {
            var card = await _studySessionService.GetNextCardAsync(id, ct);
            if (card == null)
            {
                return NotFound(new { message = "No cards available" });
            }

            return Ok(card);
        }

        [HttpPost("sessions/{id:guid}/cards/{vocabId:int}/rate")]
        public async Task<ActionResult<RateCardResponse>> RateCard(
            Guid id,
            int vocabId,
            [FromBody] RateCardRequest request,
            CancellationToken ct)
        {
            var response = await _studySessionService.RateCardAsync(id, vocabId, request.Rating, ct);
            if (response == null)
            {
                return NotFound(new { message = "Session or card not found" });
            }

            return Ok(response);
        }

        [HttpPost("sessions/{id:guid}/complete")]
        public async Task<ActionResult<SessionSummaryDto>> Complete(Guid id, CancellationToken ct)
        {
            var summary = await _studySessionService.CompleteSessionAsync(id, ct);
            if (summary == null)
            {
                return NotFound(new { message = "Session not found" });
            }

            return Ok(summary);
        }

        [HttpGet("dashboard")]
        public async Task<ActionResult<DashboardDto>> GetDashboard(CancellationToken ct)
        {
            var dashboard = await _studySessionService.GetDashboardAsync(ct);
            return Ok(dashboard);
        }

        [HttpGet("progress")]
        public async Task<ActionResult<List<CardProgressDto>>> GetProgress(CancellationToken ct)
        {
            var progress = await _studySessionService.GetProgressAsync(ct);
            return Ok(progress);
        }
    }
}
