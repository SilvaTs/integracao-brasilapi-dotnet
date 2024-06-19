using AutoMapper;
using IntegracaoBrasilAPI.DTOs;
using IntegracaoBrasilAPI.Models;

namespace IntegracaoBrasilAPI.Profiles
{
    public class AddressProfiles : Profile
    {
        public AddressProfiles()
        {
            CreateMap(typeof(GenericResponse<>), typeof(GenericResponse<>));
            CreateMap<ResponseAddress, Address>().ReverseMap();           
        }
    }
}
