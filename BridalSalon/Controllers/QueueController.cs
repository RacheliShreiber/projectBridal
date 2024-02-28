using AutoMapper;
using Bridal.Core.DTOs;
using Bridal.Core.Entities;
using Bridal.Core.Services;
using Bridal.Service;
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


        //private static int counter = 1;
        // GET: api/<QueueController>
        [HttpGet]
        public IActionResult Get()
        {
            var list = _queueBridalService.GetQueueBridal();
            return Ok(_mapper.Map<IEnumerable<QueueDTO>>(list));
        }

        // GET api/<QueueController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var queue = _queueBridalService.GetById(id);
            if (queue is null)
                return NotFound();
            return Ok(_mapper.Map<QueueDTO>(queue));
        }
        //[HttpGet("{id}/date")]
        //public QueueBridal Get(int id,DateTime date)
        //{
        //    return queues.Find(q => q.Id == id);
        //}

        // POST api/<QueueController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] QueueBridal value)
        {
            //value.Id = ++counter;
            return Ok(_mapper.Map<QueueDTO>(await _queueBridalService.AddQueueBridalAsync(value)));
            
        }

        // PUT api/<QueueController>/5
        [HttpPut("{id}/date")]
        public async Task<IActionResult> Put(int id, [FromBody] DateTime value)
        {
            return Ok(_mapper.Map<QueueDTO>(await _queueBridalService.UpdateQueueBridalAsync(id, value)));
           
        }
        [HttpPut("{id}/bridal")]
        public async Task<IActionResult> Put(int id, [FromBody] BridalClass value)
        {
            return Ok(_mapper.Map<QueueDTO>(await _queueBridalService.UpdateQueueBridalAsync(id, value)));
        }

        // DELETE api/<QueueController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _queueBridalService.DeleteQueueBridalAsync(id);
        }
    }
}
