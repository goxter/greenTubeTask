using GreenTube.Games.Dto;
using System.Collections.Generic;

namespace GreenTube.Games.Services.Interfaces
{
    public interface IGameService
    {
        public List<GameDto> GetGames(int webSiteId);
    }
}
