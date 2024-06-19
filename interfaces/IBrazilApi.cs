using IntegracaoBrasilAPI.DTOs;
using IntegracaoBrasilAPI.Models;

namespace IntegracaoBrasilAPI.interfaces
{
    public interface IBrazilApi
    {
        Task<GenericResponse<Address>> SearchAddressByZipCode(string zipCode);
        Task<GenericResponse<List<Bank>>> SearchAllBanks();
        Task<GenericResponse<Bank>> SearchBank(string bankCode);
    }
}
