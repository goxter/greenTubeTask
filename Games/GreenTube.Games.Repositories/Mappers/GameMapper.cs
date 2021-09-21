using CsvHelper.Configuration;
using GreenTube.Games.DataModel.Models;

namespace GreenTube.Games.Repositories.Mappers
{
    public class GameMapper : ClassMap<GameModel>
    {
        public GameMapper()
        {
            Map(x => x.Id).Name("Id");
            Map(x => x.Name).Name("Name");
            Map(x => x.Enabled).Name("Enabled");
            Map(x => x.WebsiteId).Name("WebsiteId");
        }
    }
}
