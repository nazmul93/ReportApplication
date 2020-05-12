using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReportGeneration.Core.Data;
using ReportGeneration.Web.Models;

namespace ReportGeneration.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VotesController : ControllerBase
    {
        private readonly ReportDbContext _context;
        public VotesController(ReportDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateVote([FromBody] VoteModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new FailedResponse
                {
                    Errors = ModelState.Values.SelectMany(x => x.Errors.Select(e => e.ErrorMessage))
                });
            }
            try
            {
                var vote = model.Vote();
                await _context.Votes.AddAsync(vote);
                await _context.SaveChangesAsync();
                return Ok("Vote Posted");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Operation Failed. Please Try agin !!");
            }
        }
    }
}