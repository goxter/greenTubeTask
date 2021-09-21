using GreenTube.Games.Dto;
using GreenTube.Games.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GreenTube.Games.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : Controller
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public List<GameDto> GetGames(int webSiteId)
        {
            return _gameService.GetGames(webSiteId);
        }
    }
}
