using IntegracaoBrasilAPI.DTOs;

namespace IntegracaoBrasilAPI.interfaces
{
    public interface IAddressService
    {
        Task<GenericResponse<ResponseAddress>> SearchAddress(string zipCode);
    }
}
