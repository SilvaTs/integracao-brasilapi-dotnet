using AutoMapper;
using IntegracaoBrasilAPI.DTOs;
using IntegracaoBrasilAPI.interfaces;

namespace IntegracaoBrasilAPI.Services
{
    public class BankService : IBankService
    {
        private readonly IMapper _mapper;
        private readonly IBrazilApi _brazilApi;

        public BankService(IMapper mapper, IBrazilApi brazilApi)
        {
            _mapper = mapper;
            _brazilApi = brazilApi;
        }

        public async Task<GenericResponse<List<ResponseBank>>> SearchAllBanks()
        {
            var banks = await _brazilApi.SearchAllBanks();
            return _mapper.Map<GenericResponse<List<ResponseBank>>>(banks);
        }

        public async Task<GenericResponse<ResponseBank>> SearchBank(string bankCode)
        {
            var bank = await _brazilApi.SearchBank(bankCode);
            return _mapper.Map<GenericResponse<ResponseBank>>(bank);
        }
    }
}
