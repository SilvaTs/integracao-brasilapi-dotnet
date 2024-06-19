using IntegracaoBrasilAPI.interfaces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace IntegracaoBrasilAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BankController : ControllerBase
    {
        private readonly IBankService _bankService;

        public BankController(IBankService bankService)
        {
            _bankService = bankService;
        }

        [HttpGet("search/everyone")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> SearchAll()
        {
            var response = await _bankService.SearchAllBanks();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(response.ResponseData);
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.ResponseError);
            }
        }

        [HttpGet("search/{bankCode}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> SearchBank([RegularExpression("^[0-9]*$")] string bankCode)
        {
            var responseBank = await _bankService.SearchBank(bankCode);

            if (responseBank.StatusCode == HttpStatusCode.OK)
            {
                return Ok(responseBank.ResponseData);
            }
            else
            {
                return StatusCode((int)responseBank.StatusCode, responseBank.ResponseError);
            }
        }
    }
}
