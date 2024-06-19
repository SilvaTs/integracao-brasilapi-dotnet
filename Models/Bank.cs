using Newtonsoft.Json;

namespace IntegracaoBrasilAPI.Models
{
    public class Bank
    {
        [JsonProperty("ispb")]
        public string? Ispb { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("code")]
        public int? Code { get; set; }

        [JsonProperty("fullName")]
        public string? FullName { get; set; }
    }
}
