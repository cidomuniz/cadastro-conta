using cadastro_conta.webapi.Models;
using cadastro_conta.webapi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace cadastro_conta.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ILogger<ClientesController> _logger;
        private readonly IClienteService _clienteService;
        
        public ClientesController(IClienteService clienteService, ILogger<ClientesController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog injected into ClientesController");
            _clienteService = clienteService;
        }

        [HttpGet]
        public ActionResult<List<Cliente>> Get() =>
            _clienteService.Get();

        [HttpGet("{id:length(24)}", Name = "GetCliente")]
        public ActionResult<Cliente> Get(string id)
        {
            var cliente = _clienteService.Get(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        [HttpPost]
        public ActionResult<Cliente> Create(Cliente cliente)
        {
            _logger.LogInformation("Created method called!");
            var x = _clienteService.Create(cliente);
            return CreatedAtRoute("GetCliente", new { id = x.Id.ToString() }, cliente);
        }
    }
}