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
        public async Task< ActionResult<Proposal>> Get()
        {

            var p=await _ProposalService.GetAllAsync();
            return Ok(p);
        }

        // GET api/<ProposalController>/5
        [HttpGet("{id}")]
        public async Task< ActionResult<Proposal>> GetById(int id)
        {
            var p = await _ProposalService.GetByIdAsync(id);
            return Ok(p);
        }

        // POST api/<ProposalController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Proposal proposal)
        {
          var p= await  _ProposalService.PostAsync(proposal);
            return Ok(p);   
        }

        // PUT api/<ProposalController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Proposal proposal)
        {
           var p=await _ProposalService.PutAsync(id, proposal); 
            return Ok(p);
        }

        // DELETE api/<ProposalController>/5
        [HttpDelete("{id}")]
        public async Task< ActionResult> Delete(int id)
        {
           var p=await _ProposalService.GetByIdAsync(id);
            if(p== null)
                return NotFound();
            await _ProposalService.DeleteAsync(id);
            return NoContent();
        }
    }
}
