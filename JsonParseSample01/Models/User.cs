using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonParseSample01.Models
{
    public class User
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Age")]
        public int Age { get; set; }
    }
}