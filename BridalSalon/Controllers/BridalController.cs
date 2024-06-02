using AutoMapper;
using Bridal.Core.DTOs;
using Bridal.Core.Entities;
using Bridal.Core.Services;
using BridalSalon.Models;
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
        public async Task<IActionResult> Get()
        {
            var list =await _bridalService.GetBridalAsync();
            var listDTO=_mapper.Map<IEnumerable<BridalDTO>>(list);
            return Ok(listDTO);
        }

        // GET api/<BridalController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var bridal =await _bridalService.GetByIdAsync(id);
            if(bridal is null)
                return NotFound();
            var bridalDTO = _mapper.Map<BridalDTO>(bridal);
            return Ok(bridalDTO);
        }

        // POST api/<BridalController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BridalPostModel value)
        {
            var bridal = _mapper.Map<BridalClass>(value);
            return Ok(_mapper.Map<BridalDTO>(await _bridalService.AddBridalAsync(bridal)));
        }

        // PUT api/<BridalController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] BridalPostModel value)
        {
            var b = _mapper.Map<BridalClass>(value);
            var bridal = await _bridalService.UpdateBridalAsync(id, b);
            return Ok(_mapper.Map<BridalDTO>(bridal));
            
        }

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
