using Microsoft.AspNetCore.Mvc;

namespace GreenTube.Games.WebApi.Controllers
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
