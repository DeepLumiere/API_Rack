using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeepRack
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentBook : ControllerBase
    {
        // GET: api/<AppointmentBook>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AppointmentBook>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AppointmentBook>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AppointmentBook>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AppointmentBook>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
