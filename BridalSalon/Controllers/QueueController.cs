using AutoMapper;
using Bridal.Core.DTOs;
using Bridal.Core.Entities;
using Bridal.Core.Services;
using Bridal.Service;
using BridalSalon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BridalSalon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueueController : ControllerBase
    {
        private readonly IQueueBridalService _queueBridalService;
        private readonly IMapper _mapper;

        public QueueController(IQueueBridalService queueBridalService,IMapper mapper)
        {
            _queueBridalService = queueBridalService;
            _mapper = mapper;
        }

        // GET: api/<QueueController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list =await _queueBridalService.GetQueueBridalAsync();
            return Ok(_mapper.Map<IEnumerable<QueueDTO>>(list));
        }

        // GET api/<QueueController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var queue =await _queueBridalService.GetByIdAsync(id);
            if (queue is null)
                return NotFound();
            return Ok(_mapper.Map<QueueDTO>(queue));
        }
        
        // POST api/<QueueController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] QueuePostModel value)
        {
            var queue= _mapper.Map <QueueBridal>(value);
            return Ok(_mapper.Map<QueueDTO>(await _queueBridalService.AddQueueBridalAsync(queue)));           
        }

        // PUT api/<QueueController>/5
        [HttpPut("{id}/date")]
        public async Task<IActionResult> Put(int id, [FromBody] DateTime value)
        {
            return Ok(_mapper.Map<QueueDTO>(await _queueBridalService.UpdateQueueBridalAsync(id, value)));          
        }
        [HttpPut("{id}/bridal")]
        public async Task<IActionResult> Put(int id, [FromBody] BridalPostModel value)
        {
            var bridal = _mapper.Map<BridalClass>(value);
            return Ok(_mapper.Map<QueueDTO>(await _queueBridalService.UpdateQueueBridalAsync(id, bridal)));
        }

        // DELETE api/<QueueController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _queueBridalService.DeleteQueueBridalAsync(id);
        }
    }
}
