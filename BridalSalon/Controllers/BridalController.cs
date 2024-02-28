using AutoMapper;
using Bridal.Core.DTOs;
using Bridal.Core.Entities;
using Bridal.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BridalSalon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BridalController : ControllerBase
    {
        //private
        private readonly IBridalService _bridalService;
        private readonly IMapper _mapper;

        public BridalController(IBridalService bridalService,IMapper mapper)
        {
            _bridalService = bridalService;
            _mapper = mapper;
        }
        // GET: api/<BridalController>
        [HttpGet]
        public IActionResult Get()
        {
            var list = _bridalService.GetBridal();
            var listDTO=_mapper.Map<IEnumerable<BridalDTO>>(list);
            // return bridals;
            return Ok(listDTO);
        }

        // GET api/<BridalController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var bridal = _bridalService.GetById(id);
            if(bridal is null)
                return NotFound();
            var bridalDTO = _mapper.Map<BridalDTO>(bridal);
            return Ok(bridalDTO);
            //return bridals.Find(b=>b.Id==id);
        }

        // POST api/<BridalController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BridalClass value)
        {
            return Ok(_mapper.Map<BridalDTO>(await _bridalService.AddBridalAsync(value)));
        }

        // PUT api/<BridalController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] BridalClass value)
        {
            var bridal = await _bridalService.UpdateBridalAsync(id, value);
            return Ok(_mapper.Map<BridalDTO>(bridal));
            
        }
        //[HttpPut("{id}/dressmaker")]
        //public void Put(int id, [FromBody] Dressmaker value)
        //{
        //    _bridalService.UpdateBridal(id, value);
        //}
        [HttpPut("{id}/date")]
        public async Task<IActionResult> Put(int id, [FromBody] DateTime value)
        {
            var bridal =await _bridalService.UpdateBridalAsync(id, value);
            return Ok(_mapper.Map<BridalDTO>(bridal));
        }

        // DELETE api/<BridalController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
           await _bridalService.DeleteBridalAsync(id);
        }
    }
}
