using CsvHelper;
using GreenTube.WebSite.DataModel.Models;
using GreenTube.WebSite.Repositories.Interfaces;
using GreenTube.WebSite.Repositories.Mappers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace GreenTube.WebSite.Repositories
{
    public class WebSiteRepository : IWebSiteRepository
    {
        public List<WebSiteModel> GetWebsites(bool sortIsAsc, int pageIndex, int pageSize)
        {
            try
            {
                var test = Path.GetFullPath("websites.csv");
                //"C:\Users\gmaric\OneDrive - Clarivate Analytics\Desktop\GreenTubeProject\Site\WebSite\GreenTube.WebSite.Repositories\CSV\websites.csv"
                using (var reader = new StreamReader(test, Encoding.Default))
                using (var csvReader = new CsvReader(reader, new CultureInfo("en-EN")))
                {
                    csvReader.Context.RegisterClassMap<WebSiteMapper>();
                    var records = csvReader.GetRecords<WebSiteModel>();
                    return records.OrderBy(w => w.Id)
                        .Skip(pageIndex * pageSize)
                        .Take(pageSize)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
