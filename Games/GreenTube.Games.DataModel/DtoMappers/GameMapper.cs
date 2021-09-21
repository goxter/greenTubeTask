using GreenTube.Games.DataModel.Models;
using GreenTube.Games.Dto;

namespace GreenTube.Games.DataModel.DtoMappers
{
    public static class GameMapper
    {
        public static GameDto ToDto(this GameModel model) =>
            new GameDto()
            {
                Id = model.Id,
                Name = model.Name,
                Enabled = model.Enabled
            };
    }
}
