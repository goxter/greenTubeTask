using Microsoft.AspNetCore.Mvc;

namespace GreenTube.WebSite.WebApi.Controllers
{
    [Route("api/probe")]
    public class ProbeController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Probe";
        }
    }
}
