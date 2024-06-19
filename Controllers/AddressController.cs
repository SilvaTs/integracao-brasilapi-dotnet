using IntegracaoBrasilAPI.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegracaoBrasilAPI.Controllers
{
    [ApiController]
    [Route("api/v1[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

    }
}
