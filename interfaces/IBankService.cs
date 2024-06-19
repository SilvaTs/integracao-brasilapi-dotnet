using IntegracaoBrasilAPI.DTOs;

namespace IntegracaoBrasilAPI.interfaces
{
    public interface IBankService
    {
        Task<GenericResponse<List<ResponseBank>>> SearchAllBanks();
        Task<GenericResponse<ResponseBank>> SearchBank(string bankCode);
    }
}
