using cadastro_conta.webapi.Models;
using cadastro_conta.webapi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace cadastro_conta.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        
        public ClientesController(IClienteService clienteService)
        {
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
            var x = _clienteService.Create(cliente);
            return CreatedAtRoute("GetCliente", new { id = x.Id.ToString() }, cliente);
        }
    }
}