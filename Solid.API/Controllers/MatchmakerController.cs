using Microsoft.AspNetCore.Mvc;
using Solid.Core.Models;
using Solid.Core.Services;
using Solid.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchmakerController : ControllerBase
    {
        private readonly IMatchmakerService _matchMakerService;
        public MatchmakerController(IMatchmakerService matchMakerService)
        {
            _matchMakerService = matchMakerService;
        }
    
        // GET: api/<MatchmakerController>
        [HttpGet]
        public async Task< ActionResult<Matchmaker>> Get()
        {
            var m= _matchMakerService.GetAll();
            return Ok(m);
        }

        // GET api/<MatchmakerController>/5
        [HttpGet("{id}")]
        public ActionResult<Matchmaker> GetById(int id)
        {
            var matchmaker = _matchMakerService.GetById(id);    
            return Ok(matchmaker);
        }

        // POST api/<MatchmakerController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Matchmaker value)
        {

           var m= await _matchMakerService.Post(value);
            return Ok(m);
        }

        // PUT api/<MatchmakerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Matchmaker value)
        {
            var m= await _matchMakerService.Put(id, value);
           return Ok(m);
        }

        // DELETE api/<MatchmakerController>/5
        [HttpDelete("{id}")]
        public async Task< ActionResult> Delete(int id)
        {
            var m= await _matchMakerService.GetById(id); 
            if(m==null)
                return NotFound();

            return NoContent();
        }
    }
}
