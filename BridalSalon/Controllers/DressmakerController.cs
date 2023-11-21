using BridalSalon.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BridalSalon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DressmakerController : ControllerBase
    {
        private static List<Dressmaker> dressmakers = new List<Dressmaker>();
        private static int counter = 100;
        // GET: api/<DressmakerController>
        [HttpGet]
        public IEnumerable<Dressmaker> Get()
        {
            return dressmakers;
        }

        // GET api/<DressmakerController>/5
        [HttpGet("{id}")]
        public Dressmaker Get(int id)
        {
            return dressmakers.Find(d=>d.Id==id);
        }
        //[HttpGet("{id}/bridals")]
        //public List<Bridal> Get(int id)
        //{
        //    return 
        //}

        // POST api/<DressmakerController>
        [HttpPost]
        public void Post([FromBody] Dressmaker value)
        {
            value.Id = counter;
            counter += 100;
            value.status = 1;
            dressmakers.Add(value);
        }

        // PUT api/<DressmakerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Dressmaker value)
        {
            Dressmaker dressmaker=dressmakers.Find(d=>d.Id==id);
            if(dressmaker!=null)
                dressmaker.Name=value.Name;
        }
        [HttpPut("{id}/experience")]
        public void Put(int id, [FromBody] Experience value)
        {
            Dressmaker dressmaker = dressmakers.Find(d => d.Id == id);
            if (dressmaker != null)
                dressmaker.experience = value;
        }
        [HttpPut("{id}/status")]
        public void Put(int id,int status)
        {
            Dressmaker dressmaker = dressmakers.Find(d => d.Id == id);
            if (dressmaker != null)
                dressmaker.status =status;
        }

        // DELETE api/<DressmakerController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{

        //}
    }
}
