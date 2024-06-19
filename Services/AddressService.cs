using AutoMapper;
using IntegracaoBrasilAPI.DTOs;
using IntegracaoBrasilAPI.interfaces;

namespace IntegracaoBrasilAPI.Services
{
    public class BrazilService : IAddressService
    {
        private readonly IMapper _mapper;
        private readonly IBrazilApi _brazilApi;

        public BrazilService(IMapper mapper, IBrazilApi brazilApi)
        {
            _mapper = mapper;
            _brazilApi = brazilApi;
        }

        public async Task<GenericResponse<ResponseAddress>> SearchAddress(string zipCode)
        {
            var address = await _brazilApi.SearchAddressByZipCode(zipCode);
            return _mapper.Map<GenericResponse<ResponseAddress>>(address);
        }
    }
}
