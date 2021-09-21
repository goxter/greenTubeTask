using System;
using System.Runtime.Serialization;

namespace GreenTube.WebSite.Dto
{
    [DataContract]
    public class WebSiteDto
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "dateAdded")]
        public string DateAdded { get; set; }
    }
}
