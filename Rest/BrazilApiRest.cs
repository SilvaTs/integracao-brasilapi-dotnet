using IntegracaoBrasilAPI.DTOs;
using IntegracaoBrasilAPI.interfaces;
using IntegracaoBrasilAPI.Models;
using System.Dynamic;
using System.Text.Json;

namespace IntegracaoBrasilAPI.Rest
{
    public class BrazilApiRest : IBrazilApi
    {
        public async Task<GenericResponse<Address>> SearchAddressByZipCode(string zipCode)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{zipCode}");
            
            var genericResponse = new GenericResponse<Address>();
            using (var client = new HttpClient())
            {
                var responseBrazilApi = await client.SendAsync(request);
                var contentResponse = await responseBrazilApi.Content.ReadAsStringAsync();
                var responseAdrress = JsonSerializer.Deserialize<Address>(contentResponse);

                if (responseBrazilApi.IsSuccessStatusCode)
                {
                    genericResponse.StatusCode = responseBrazilApi.StatusCode;
                    genericResponse.ResponseData = responseAdrress;
                }
                else
                {
                    genericResponse.StatusCode = responseBrazilApi.StatusCode;
                    genericResponse.ResponseError = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return genericResponse;

        }

        public Task<GenericResponse<List<Bank>>> SearchAllBanks()
        {
            throw new NotImplementedException();
        }

        public Task<GenericResponse<Bank>> SearchBank(string bankCode)
        {
            throw new NotImplementedException();
        }
    }
}
