using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace netcore_lab.Controllers
{
    [ApiController]
    [Route("health")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public object GetIndex()
        {
            return new { message = "Services are running" };
        }
    }
}
