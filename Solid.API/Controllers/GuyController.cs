using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Solid.API;
using Solid.Core.DTOs;
using Solid.Core.Models;
using Solid.Core.Services;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuyController : ControllerBase
    {
        private readonly IGuyService _guyService;
        private readonly IMapper _mapper;
        public GuyController(IGuyService guyService, IMapper mapper)
        {
            _guyService = guyService;
            _mapper = mapper;   
        }


        // GET: api/<GuyController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_guyService.GetAll());

        }

        // GET api/<GuyController>/5
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var result = _guyService.GetById(id);
            var GuysGet = _mapper.Map<DTOGuy>(result);
            return Ok(GuysGet);   
        }
        //[HttpGet("{age}")]
        //public IEnumerable<Guy> GetAge(int age)
        //{
        //    return contaxt.guys.Where(x => x.Age == age);
        //}

        // POST api/<GuyController>
        [HttpPost]
        public void Post([FromBody] GuyPost value)
        {
            var GuyToAdd=new Guy() { Age=value.Age,Name=value.Name, Heigh=value.Heigh, IfGiveFlat=value.IfGiveFlat, Sector=value.Sector, Yeshiva=value.Yeshiva}; 

            _guyService.Post(GuyToAdd);
        }

        // PUT api/<GuyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] GuyPost value)

        {
            var GuyToAdd = new Guy() { Age = value.Age, Name = value.Name, Heigh = value.Heigh, IfGiveFlat = value.IfGiveFlat, Sector = value.Sector, Yeshiva = value.Yeshiva };

            _guyService.put(id, GuyToAdd); 
        }

        // DELETE api/<GuyController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _guyService.Delete(id);
            return NoContent();
        }
    }
}
