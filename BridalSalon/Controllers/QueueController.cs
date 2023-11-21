using BridalSalon.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BridalSalon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueueController : ControllerBase
    {
        private static List<QueueBridal> queues = new List<QueueBridal>();
        private static int counter = 1;
        // GET: api/<QueueController>
        [HttpGet]
        public IEnumerable<QueueBridal> Get()
        {
            return queues;
        }

        // GET api/<QueueController>/5
        [HttpGet("{id}")]
        public QueueBridal Get(int id)
        {
            return queues.Find(q=>q.Id==id);
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
            value.Id = ++counter;
            queues.Add(value);
        }

        // PUT api/<QueueController>/5
        [HttpPut("{id}/date")]
        public void Put(int id, [FromBody] DateTime value)
        {
            QueueBridal queueBridal = queues.Find(q => q.Id == id);
            if (queueBridal != null)
                queueBridal.DateQueue = value;
        }
        [HttpPut("{id}/bridal")]
        public void Put(int id, [FromBody] Bridal value)
        {
            QueueBridal queueBridal = queues.Find(q => q.Id == id);
            if (queueBridal != null)
                queueBridal.bridal = value;
        }

        // DELETE api/<QueueController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            QueueBridal queueBridal=queues.Find(q=>q.Id==id);
            if(queueBridal!=null)
                queues.Remove(queueBridal);
        }
    }
}
