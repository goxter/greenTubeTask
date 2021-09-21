using GreenTube.Games.DataModel.Models;
using System.Collections.Generic;

namespace GreenTube.Games.Repositories.Interfaces
{
    public interface IGameRepository
    {
        List<GameModel> GetGamesBySiteId(int webSiteId);
    }
}
