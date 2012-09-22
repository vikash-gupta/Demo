using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers
{
    //[Authorize]
    public class TransferController : ApiController
    {
        public string Post(Transfer transferModel)
        {
            if(!ModelState.IsValid)
            {
                var values = ModelState.Values;
                foreach(var value in values)
                {
                    return value.Errors[0].ErrorMessage;
                }
            }
            return "Data posted successfully";

        }
    }
}
