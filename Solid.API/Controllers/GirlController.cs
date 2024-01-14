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
        public ActionResult<Girl> Get()
        {
            return Ok(_girlService.GetAll());
        }
        //[HttpGet("{age}")]
        //public IEnumerable<Girl> GetAge(int age)
        //{
        //    return contaxt.girls.Where(x => x.Age == age);
        //}

        // GET api/<GirlController>/5
        [HttpGet("{id}")]
        public ActionResult< Girl> GetById(int id)
        {
            return Ok(_girlService.GetById(id));
        }

        // POST api/<GirlController>
        [HttpPost]
        public void Post([FromBody] Girl girl)
        {
            _girlService.Post(girl);
        }

        // PUT api/<GirlController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Girl girl)
        {
            _girlService.put(id, girl);
        }

        // DELETE api/<GirlController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _girlService.Delete(id);
            return NoContent();
        }
    }
}
