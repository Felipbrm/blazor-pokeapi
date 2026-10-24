using System.Text.Json.Serialization;

namespace BlazorPokeApi.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public Sprites Sprites { get; set; }
    }

    public class Sprites
    {
        public Other Other { get; set; }
    }

    public class Other
    {
        
        [JsonPropertyName("official-artwork")]
        public OfficialArtwork OfficialArtwork { get; set; }
    }

    public class OfficialArtwork
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
    }
}