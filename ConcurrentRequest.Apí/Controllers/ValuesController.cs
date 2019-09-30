using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ConcurrentRequest.Apí.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/values")]
    public class ValuesController : ControllerBase
    {
        public IEnumerable<string> _values;

        public ValuesController()
        {
            _values = new List<string> {"value1", "value2", "value3" };
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var r = _values.Select((item, index) => new { item, index }).FirstOrDefault(x => x.index == id).item;
            return Ok(r);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
