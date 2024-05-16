 using Microsoft.AspNetCore.Mvc;
using Solid.Core.Models;
using Solid.Core.Services;
using Solid.Data;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GirlController : ControllerBase
    {
      private readonly IGirlService _girlService;
        public GirlController(IGirlService girlService)
        {
            _girlService = girlService;
        }

        // GET: api/<GirlController>
        [HttpGet]
        public  async Task<ActionResult<Girl>> Get()
        {
          var g= _girlService.GetAll();
            return  Ok(g);
        }
      
        // GET api/<GirlController>/5
        [HttpGet("{id}")]
        public async Task< ActionResult< Girl>> GetById(int id)
        {
            var g= _girlService.GetById(id);
            return Ok(g);
        }

        // POST api/<GirlController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Girl girl)
        {
            var result = _girlService.Post(girl);
            return Ok(result.Result);
        }

        // PUT api/<GirlController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Girl girl)
        {
            var g = await _girlService.GetById(id);
            if (g == null)
                return NotFound();
            g=await _girlService.put(id, girl);
            return Ok(g);
        }

        // DELETE api/<GirlController>/5
        [HttpDelete("{id}")]
        public async Task< ActionResult> Delete(int id)
        {
           var g=await _girlService.GetById(id);
            if (g==null)
                return NotFound();
            await _girlService.Delete(id);
            return NoContent();
        }
    }
}
