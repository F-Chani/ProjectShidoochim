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
        public ActionResult<Matchmaker> Get()
        {
            return Ok(_matchMakerService.GetAll());
        }

        // GET api/<MatchmakerController>/5
        [HttpGet("{id}")]
        public ActionResult<Matchmaker> GetById(int id)
        {
            return Ok(_matchMakerService.GetById(id));
        }
       // [HttpGet("{ExperienceYear}")]
        //public IEnumerable<Girl> GetAge(int experienceYear)
        //{
          //  return matchmaker.Where(x => x.ExperienceYear>=GetAge());
        //}
        // POST api/<MatchmakerController>
        [HttpPost]
        public void Post([FromBody] Matchmaker value)
        {
            _matchMakerService.Post(value);
        }

        // PUT api/<MatchmakerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Matchmaker value)
        {
            _matchMakerService.put(id, value);
        }

        // DELETE api/<MatchmakerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _matchMakerService.Delete(id);  
            return NoContent();
        }
    }
}
