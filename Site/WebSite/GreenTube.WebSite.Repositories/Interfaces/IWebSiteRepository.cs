using GreenTube.WebSite.DataModel.Models;
using System.Collections.Generic;

namespace GreenTube.WebSite.Repositories.Interfaces
{
    public interface IWebSiteRepository
    {
        List<WebSiteModel> GetWebsites(bool sortIsAsc, int pageIndex, int pageSize);
    }
}
