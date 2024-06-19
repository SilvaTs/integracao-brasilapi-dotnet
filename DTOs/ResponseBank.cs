using Newtonsoft.Json;

namespace IntegracaoBrasilAPI.DTOs
{
    public class ResponseBank
    {     
        public string? Ispb { get; set; }
  
        public string? Name { get; set; }

        public int? Code { get; set; }
     
        public string? FullName { get; set; }
    }
}
