using CsvHelper;
using GreenTube.Games.DataModel.Models;
using GreenTube.Games.Repositories.Interfaces;
using GreenTube.Games.Repositories.Mappers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace GreenTube.Games.Repositories
{
    public class GameRepository : IGameRepository
    {
        public List<GameModel> GetGamesBySiteId(int webSiteId)
        {
            try
            {
                using (var reader = new StreamReader(@"C:\Users\gmaric\OneDrive - Clarivate Analytics\Desktop\GreenTubeProject\Games\GreenTube.Games.Repositories\CSV\games.csv", Encoding.Default))
                using (var csvReader = new CsvReader(reader, new CultureInfo("en-EN")))
                {
                    csvReader.Context.RegisterClassMap<GameMapper>();
                    var records = csvReader.GetRecords<GameModel>();
                    return records.Where(g => g.WebsiteId == webSiteId).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
