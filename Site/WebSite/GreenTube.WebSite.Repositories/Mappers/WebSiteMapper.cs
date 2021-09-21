using CsvHelper.Configuration;
using GreenTube.WebSite.DataModel.Models;

namespace GreenTube.WebSite.Repositories.Mappers
{
    public class WebSiteMapper : ClassMap<WebSiteModel>
    {
        public WebSiteMapper()
        {
            Map(x => x.Id).Name("Id");
            Map(x => x.Name).Name("Name");
            Map(x => x.DateAdded).Name("DateAdded");
        }
    }
}
