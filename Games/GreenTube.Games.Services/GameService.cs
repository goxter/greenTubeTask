using GreenTube.Games.DataModel.DtoMappers;
using GreenTube.Games.Dto;
using GreenTube.Games.Repositories.Interfaces;
using GreenTube.Games.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GreenTube.Games.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public List<GameDto> GetGames(int webSiteId) =>
            _gameRepository.GetGamesBySiteId(webSiteId).Select(x => x.ToDto()).ToList();
    }
}
