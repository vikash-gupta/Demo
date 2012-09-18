using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers
{
    public class TransferController : ApiController
    {
        // GET api/transfer
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/transfer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/transfer
        public void Post([FromBody]string value)
        {
        }

        // PUT api/transfer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/transfer/5
        public void Delete(int id)
        {
        }
    }
}
