using GreenTube.WebSite.DataModel.Models;
using GreenTube.WebSite.Dto;

namespace GreenTube.WebSite.DataModel.DtoMappers
{
    public static class WebSiteMapper
    {
        public static WebSiteDto ToDto(this WebSiteModel model) =>
            new WebSiteDto()
            {
                Id = model.Id,
                Name = model.Name,
                DateAdded = model.DateAdded.Date.ToString("dd-MM-yyyy")
            };
    }
}
