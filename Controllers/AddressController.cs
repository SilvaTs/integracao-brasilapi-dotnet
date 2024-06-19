using IntegracaoBrasilAPI.interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegracaoBrasilAPI.Controllers
{
    [ApiController]
    [Route("api/v1/Endereco")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet("busca/{zipCode}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> SearchAddress([FromRoute] string zipCode)
        {
            var response = await _addressService.SearchAddress(zipCode);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(response.ResponseData);
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.ResponseError);
            }
        }
    }
}
