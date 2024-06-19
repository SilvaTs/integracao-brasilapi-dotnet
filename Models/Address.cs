using Newtonsoft.Json;

namespace IntegracaoBrasilAPI.Models
{
    public class Address
    {
        [JsonProperty("cep")]
        public string? Cep { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("neighborhood")]
        public string? Neighborhood { get; set; }

        [JsonProperty("street")]
        public string? Street { get; set; }

        [JsonProperty("service")]
        public string? Service { get; set; }
    }
}
