using cadastro_conta.webapi.Models;
using System.Collections.Generic;

namespace cadastro_conta.webapi.Services
{
    public interface IClienteService
    {
        Cliente Create(Cliente cliente);
        List<Cliente> Get();
        Cliente Get(string id);
        void Remove(Cliente clienteIn);
        void Remove(string id);
        void Update(string id, Cliente clienteIn);
    }
}