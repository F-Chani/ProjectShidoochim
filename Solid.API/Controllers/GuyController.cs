using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Solid.API.Models;
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
        public async Task<ActionResult> Get()
        {
            var g = await _guyService.GetAll();
            return Ok(g);

        }

        // GET api/<GuyController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var result = _guyService.GetById(id);

            var GuysGet = _mapper.Map<DTOGuy>(result);
            return Ok(GuysGet);
        }


        // POST api/<GuyController>
        [HttpPost]
        public async Task<Guy> Post([FromBody] GuyPostModel value)
        {
            var guyToAdd = await _guyService.Post(_mapper.Map<Guy>(value));
            return Ok(_mapper.Map<DTOGuy>(guyToAdd));
        }

        // PUT api/<GuyController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] GuyPostModel value)

        {
            var guyToAdd = await _guyService.Put(id, _mapper.Map<Guy>(value));
            return Ok(_mapper.Map<DTOGuy>(guyToAdd));
        }

        // DELETE api/<GuyController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var g = _guyService.GetById(id);
            if (g == null)
                return NotFound();
            await _guyService.Delete(id);
            return NoContent();
        }
    }
}
