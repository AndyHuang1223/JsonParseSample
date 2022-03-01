using System.Text.Json.Serialization;

namespace JsonParseSample01.Models
{
    public class BaseModel<T> where T : class
    {
        [JsonPropertyName("Code")]
        public int Code { get; set; } = -1;
        [JsonPropertyName("Msg")]
        public string Message { get; set; }
        [JsonPropertyName("Response")]
        public T Response { get; set; }
    }
}