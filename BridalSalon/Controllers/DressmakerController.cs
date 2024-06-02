using AutoMapper;
using Bridal.Core.DTOs;
using Bridal.Core.Entities;
using Bridal.Core.Services;
using BridalSalon.Models;
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
    
        public DressmakerController(IDressmakerService dressmakerService,IMapper mapper)
        {
            _dressmakerService = dressmakerService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list =await _dressmakerService.GetDressmakerAsync();
            return Ok(_mapper.Map<IEnumerable<DressmakerDTO>>(list));
        }

        // GET api/<DressmakerController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var dressmaker =await _dressmakerService.GetByIdAsync(id);
            if(dressmaker is null)
                return NotFound();
            return Ok(_mapper.Map<DressmakerDTO>(dressmaker));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DressmakerPostModel value)
        {
            var dressmaker= _mapper.Map <Dressmaker>(value);
            return Ok(_mapper.Map<DressmakerDTO>(await _dressmakerService.AddDressmakerAsync(dressmaker)));
        }

        // PUT api/<DressmakerController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] DressmakerPostModel value)
        {
            var d= _mapper.Map<Dressmaker>(value);   
            return Ok(_mapper.Map<DressmakerDTO>(await _dressmakerService.UpdateDressmakerAsync(id, d)));
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
    }
}
