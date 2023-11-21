using BridalSalon.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BridalSalon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BridalController : ControllerBase
    {
        //private
        private static List<Bridal> bridals = new List<Bridal>();
        // GET: api/<BridalController>
        [HttpGet]
        public IEnumerable<Bridal> Get()
        {
            return bridals;
        }

        // GET api/<BridalController>/5
        [HttpGet("{id}")]
        public Bridal Get(int id)
        {
            return bridals.Find(b=>b.Id==id);
        }

        // POST api/<BridalController>
        [HttpPost]
        public void Post([FromBody] Bridal value)
        {
            bridals.Add(value);
        }

        // PUT api/<BridalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Bridal value)
        {
            Bridal bridal = bridals.Find(b => b.Id == id);
            if (bridal != null)
            {
                bridal.Name=value.Name;
                bridal.Phone=value.Phone;
            }
        }
        [HttpPut("{id}/dressmaker")]
        public void Put(int id, [FromBody] Dressmaker value)
        {
            Bridal bridal = bridals.Find(b => b.Id == id);
            if (bridal != null)
                bridal.dressmaker=value;
        }
        [HttpPut("{id}/date")]
        public void Put(int id, [FromBody] DateTime value)
        {
            Bridal bridal = bridals.Find(b => b.Id == id);
            if (bridal != null)
                bridal.DateWedding = value;
        }

        // DELETE api/<BridalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Bridal bridal = bridals.Find(b=>b.Id==id);
            if(bridal!=null)
               bridals.Remove(bridal);
        }
    }
}
