using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjectWithSwagger.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        /// <response code="403">Authorization has been denied for this request.</response>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
