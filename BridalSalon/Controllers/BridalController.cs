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

        public BridalController(IBridalService bridalService)
        {
            _bridalService = bridalService;
        }
        // GET: api/<BridalController>
        [HttpGet]
        public IActionResult Get()
        {
            // return bridals;
            return Ok(_bridalService.GetBridal());
        }

        // GET api/<BridalController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var bridal = _bridalService.GetById(id);
            if(bridal is null)
                return NotFound();
            return Ok(bridal);
            //return bridals.Find(b=>b.Id==id);
        }

        // POST api/<BridalController>
        [HttpPost]
        public void Post([FromBody] BridalClass value)
        {
            _bridalService.AddBridal(value);
        }

        // PUT api/<BridalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] BridalClass value)
        {
            _bridalService.UpdateBridal(id, value);
        }
        [HttpPut("{id}/dressmaker")]
        public void Put(int id, [FromBody] Dressmaker value)
        {
            _bridalService.UpdateBridal(id, value);
        }
        [HttpPut("{id}/date")]
        public void Put(int id, [FromBody] DateTime value)
        {
            _bridalService.UpdateBridal(id, value);
        }

        // DELETE api/<BridalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _bridalService.DeleteBridal(id);
        }
    }
}
