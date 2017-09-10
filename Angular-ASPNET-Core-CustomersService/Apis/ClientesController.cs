using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Angular_ASPNETCore_CustomersService.Infrastructure;
using Angular_ASPNETCore_CustomersService.Models;
using Angular_ASPNETCore_CustomersService.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Angular_ASPNETCore_CustomersService.Apis
{

    [Route("api/clientes")]
    public class ClientesController : Controller
    {
        private readonly ICustomersRepository _customersRepository;
        private readonly ILogger _logger;

        public ClientesController(ICustomersRepository customersRepository, ILoggerFactory loggerFactory)
        {
            _customersRepository = customersRepository;
            _logger = loggerFactory.CreateLogger(nameof(ClientesController));
        }


        // GET api/clientes
        [HttpGet]
        [NoCache]
        [ProducesResponseType(typeof(List<Customer>), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> Customers()
        {
            try
            {
                var customers = await _customersRepository.GetCustomersAsync();
                return Ok(customers);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp.Message);
                return BadRequest(new ApiResponse { Status = false });
            }
        }


    }
}