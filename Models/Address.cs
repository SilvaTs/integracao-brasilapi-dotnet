﻿using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace IntegracaoBrasilAPI.Models
{
    public class Address
    {
        [JsonPropertyName("cep")]
        public string? Cep { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }

        [JsonPropertyName("city")]
        public string? City { get; set; }

        [JsonPropertyName("neighborhood")]
        public string? Neighborhood { get; set; }

        [JsonPropertyName("street")]
        public string? Street { get; set; }

        [JsonPropertyName("service")]
        public string? Service { get; set; }
    }
}
