using Microsoft.AspNetCore.Mvc;
using TheStreets.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheStreets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunitisController : ControllerBase
    {
        // GET: api/<CommunitisController>
        [HttpGet]
        public IEnumerable<Community> Get()
        {
            Community community = new Community();
            return community.Read();
        }

        // GET api/<CommunitisController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CommunitisController>
        [HttpPost]
        public void Post([FromBody] Community community)
        {
            community.Insert();
        }

        // PUT api/<CommunitisController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CommunitisController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
