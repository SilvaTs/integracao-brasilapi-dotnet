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

        public async Task<GenericResponse<List<Bank>>> SearchAllBanks()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1");

            var genericResponse = new GenericResponse<List<Bank>>();
            using (var client = new HttpClient())
            {
                var responseBrazilApi = await client.SendAsync(request);
                var contentResponse = await responseBrazilApi.Content.ReadAsStringAsync();
                var responseBanck = JsonSerializer.Deserialize<List<Bank>>(contentResponse);

                if (responseBrazilApi.IsSuccessStatusCode)
                {
                    genericResponse.StatusCode = responseBrazilApi.StatusCode;
                    genericResponse.ResponseData = responseBanck;
                }
                else
                {
                    genericResponse.StatusCode = responseBrazilApi.StatusCode;
                    genericResponse.ResponseError = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return genericResponse;
        }

        public async Task<GenericResponse<Bank>> SearchBank(string bankCode)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{bankCode}");

            var genericResponse = new GenericResponse<Bank>();
            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();
                var responseBanck = JsonSerializer.Deserialize<Bank>(contentResponse);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    genericResponse.StatusCode = responseBrasilApi.StatusCode;
                    genericResponse.ResponseData = responseBanck;
                }
                else
                {
                    genericResponse.StatusCode = responseBrasilApi.StatusCode;
                    genericResponse.ResponseError = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return genericResponse;
        }
    }
}
