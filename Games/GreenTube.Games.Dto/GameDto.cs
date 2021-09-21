using System.Runtime.Serialization;

namespace GreenTube.Games.Dto
{
    [DataContract]
    public class GameDto
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "enabled")]
        public bool Enabled { get; set; }
    }
}
