﻿using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace IntegracaoBrasilAPI.Models
{
    public class Bank
    {
        [JsonPropertyName("ispb")]
        public string? Ispb { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("code")]
        public int? Code { get; set; }

        [JsonPropertyName("fullName")]
        public string? FullName { get; set; }
    }
}
