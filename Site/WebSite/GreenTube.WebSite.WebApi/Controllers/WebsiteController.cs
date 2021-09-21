using GreenTube.WebSite.Dto;
using GreenTube.WebSite.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GreenTube.WebSite.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebsiteController : Controller
    {
        private readonly IWebSiteService _websiteService;

        public WebsiteController(IWebSiteService websiteService)
        {
            _websiteService = websiteService;
        }

        [HttpGet]
        public List<WebSiteDto> GetWebSites(bool sortIsAsc = true, int pageIndex = 0, int pageSize = 20)
        {
            return _websiteService.GetWebSites(sortIsAsc, pageIndex, pageSize);
        }
    }
}
