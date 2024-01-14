using Microsoft.AspNetCore.Mvc;
using Solid.Core.Services;
using Solid.Core.Models;
using Solid.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProposalController : ControllerBase
    {
        private readonly IProposalService _ProposalService;
        public ProposalController(IProposalService proposalService)
        {
            _ProposalService = proposalService;
        }
        // GET: api/<ProposalController>
        [HttpGet]
        public ActionResult<Proposal> Get()
        {
            return Ok(_ProposalService.GetAll());
        }

        // GET api/<ProposalController>/5
        [HttpGet("{id}")]
        public ActionResult<Proposal> GetById(int id)
        {
            return Ok(_ProposalService.GetById(id));
        }

        // POST api/<ProposalController>
        [HttpPost]
        public void Post([FromBody] Proposal proposal)
        {
            _ProposalService.Post(proposal);
        }

        // PUT api/<ProposalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Proposal proposal)
        {
            _ProposalService.put(id, proposal); 
        }

        // DELETE api/<ProposalController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _ProposalService.Delete(id);
            return NoContent();
        }
    }
}
