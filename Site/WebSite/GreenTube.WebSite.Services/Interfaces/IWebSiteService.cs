using GreenTube.WebSite.Dto;
using System.Collections.Generic;

namespace GreenTube.WebSite.Services.Interfaces
{
    public interface IWebSiteService
    {
        List<WebSiteDto> GetWebSites(bool sortIsAsc, int pageIndex, int pageSize);
    }
}
