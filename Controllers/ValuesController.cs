using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_template.Controllers
{
    public class TestContainer
    {
        public string content { get; set; }
    }
    
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<TestContainer> Get()
        {
            List<TestContainer> exit = new List<TestContainer>();
            TestContainer value1 = new TestContainer();
            value1.content = "value1";
            exit.Add(value1);
            TestContainer value2 = new TestContainer();
            value2.content = "value2";
            exit.Add(value2);
            return exit.ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
