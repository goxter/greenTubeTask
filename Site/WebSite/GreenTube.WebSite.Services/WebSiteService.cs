using GreenTube.WebSite.DataModel.DtoMappers;
using GreenTube.WebSite.Dto;
using GreenTube.WebSite.Repositories.Interfaces;
using GreenTube.WebSite.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GreenTube.WebSite.Services
{
    public class WebSiteService : IWebSiteService
    {
        private readonly IWebSiteRepository _websiteRepository;

        public WebSiteService(IWebSiteRepository websiteRepository)
        {
            _websiteRepository = websiteRepository;
        }

        public List<WebSiteDto> GetWebSites(bool sortIsAsc, int pageIndex, int pageSize) =>
            _websiteRepository.GetWebsites(sortIsAsc, pageIndex, pageSize).Select(x => x.ToDto()).ToList();
    }
}
