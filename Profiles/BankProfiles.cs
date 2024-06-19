using AutoMapper;
using IntegracaoBrasilAPI.DTOs;
using IntegracaoBrasilAPI.Models;

namespace IntegracaoBrasilAPI.Profiles
{
    public class BankProfiles : Profile
    {
        public BankProfiles()
        {
            CreateMap(typeof(GenericResponse<>), typeof(GenericResponse<>));
            CreateMap<ResponseBank, Bank>().ReverseMap();
        }
    }
}
