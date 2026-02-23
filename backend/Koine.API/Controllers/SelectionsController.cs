// Koine.API/Controllers/SelectionsController.cs
using Microsoft.AspNetCore.Mvc;
using Koine.Application.DTOs.Selections;
using System.Threading.Tasks;

namespace Koine.API.Controllers
{
    [ApiController]
    [Route("api/selections")]
    public class SelectionsController : ControllerBase
    {
        private readonly ILogger<SelectionsController> _logger;

        public SelectionsController(ILogger<SelectionsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{textId}")]
        public async Task<ActionResult<SelectionsDto>> GetSelectionsByTextId(int textId)
        {
            return StatusCode(501, new { message = "Not Implemented" });
        }
    }
}
