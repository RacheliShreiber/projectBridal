using Bridal.Core.Entities;
using Bridal.Core.Services;
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
        //private static int counter = 100;
        // GET: api/<DressmakerController>

        public DressmakerController(IDressmakerService dressmakerService)
        {
            _dressmakerService = dressmakerService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dressmakerService.GetDressmaker());
        }

        // GET api/<DressmakerController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var dressmaker = _dressmakerService.GetById(id);
            if(dressmaker is null)
                return NotFound();
            return Ok(dressmaker);
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
            //value.Id = counter;
            //counter += 100;
            //value.status = 1;
            _dressmakerService.AddDressmaker(value);
        }

        // PUT api/<DressmakerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Dressmaker value)
        {
            _dressmakerService.UpdateDressmaker(id, value);
        }
        [HttpPut("{id}/experience")]
        public void Put(int id, [FromBody] Experience value)
        {
            _dressmakerService.UpdateDressmaker(id, value);
        }
        [HttpPut("{id}/status")]
        public void Put(int id,int status)
        {
            _dressmakerService.UpdateDressmaker(id, status);
        }

        // DELETE api/<DressmakerController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{

        //}
    }
}
