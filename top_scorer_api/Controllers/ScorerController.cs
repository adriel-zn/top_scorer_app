using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using top_scorer_api.Models;


namespace top_scorer_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScorerController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> PostScore([FromBody] Scorer score)
        {
            return Ok();
        }

        // GET api/scorers/{fullname}
        [HttpGet("{fullname}")]
        public async Task<IActionResult> GetScore(string fullname)
        { 

            return Ok();
        }

        // GET api/scorers/highest
        [HttpGet("highest")]
        public async Task<IActionResult> GetTopScores()
        {
            return Ok();
        }
    }
}
