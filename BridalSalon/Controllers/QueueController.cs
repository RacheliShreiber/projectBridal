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

        public QueueController(IQueueBridalService queueBridalService)
        {
            _queueBridalService = queueBridalService;
        }


        //private static int counter = 1;
        // GET: api/<QueueController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_queueBridalService.GetQueueBridal());
        }

        // GET api/<QueueController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var queue = _queueBridalService.GetById(id);
            if (queue is null)
                return NotFound();
            return Ok(queue);
        }
        //[HttpGet("{id}/date")]
        //public QueueBridal Get(int id,DateTime date)
        //{
        //    return queues.Find(q => q.Id == id);
        //}

        // POST api/<QueueController>
        [HttpPost]
        public void Post([FromBody] QueueBridal value)
        {
            //value.Id = ++counter;
            _queueBridalService.AddQueueBridal(value);
        }

        // PUT api/<QueueController>/5
        [HttpPut("{id}/date")]
        public void Put(int id, [FromBody] DateTime value)
        {
            _queueBridalService.UpdateQueueBridal(id, value);
        }
        [HttpPut("{id}/bridal")]
        public void Put(int id, [FromBody] BridalClass value)
        {
            _queueBridalService.UpdateQueueBridal(id, value);
        }

        // DELETE api/<QueueController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _queueBridalService.DeleteQueueBridal(id);
        }
    }
}
