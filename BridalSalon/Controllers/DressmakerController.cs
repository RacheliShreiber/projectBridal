using AutoMapper;
using Bridal.Core.DTOs;
using Bridal.Core.Entities;
using Bridal.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BridalSalon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DressmakerController : ControllerBase
    {
        private readonly IDressmakerService _dressmakerService;
        private readonly IMapper _mapper;
        //private static int counter = 100;
        // GET: api/<DressmakerController>

        public DressmakerController(IDressmakerService dressmakerService,IMapper mapper)
        {
            _dressmakerService = dressmakerService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var list = _dressmakerService.GetDressmaker();
            return Ok(_mapper.Map<IEnumerable<DressmakerDTO>>(list));
        }

        // GET api/<DressmakerController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var dressmaker = _dressmakerService.GetById(id);
            if(dressmaker is null)
                return NotFound();
            return Ok(_mapper.Map<DressmakerDTO>(dressmaker));
        }
        //[HttpGet("{id}/bridals")]
        //public List<Bridal> Get(int id)
        //{
        //    return 
        //}

        // POST api/<DressmakerController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Dressmaker value)
        {
            //value.Id = counter;
            //counter += 100;
            //value.status = 1;
            return Ok(_mapper.Map<DressmakerDTO>(await _dressmakerService.AddDressmakerAsync(value)));
        }

        // PUT api/<DressmakerController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Dressmaker value)
        {
            return Ok(_mapper.Map<DressmakerDTO>(await _dressmakerService.UpdateDressmakerAsync(id, value)));
        }
        [HttpPut("{id}/experience")]
        public async Task<IActionResult> Put(int id, [FromBody] Experience value)
        {
            return Ok(_mapper.Map<DressmakerDTO>(await _dressmakerService.UpdateDressmakerAsync(id, value)));
        }
        [HttpPut("{id}/status")]
        public async Task<IActionResult> Put(int id,int status)
        {
            return Ok(_mapper.Map<DressmakerDTO>(await _dressmakerService.UpdateDressmakerAsync(id, status)));
        }

        // DELETE api/<DressmakerController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{

        //}
    }
}
