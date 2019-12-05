using cadastro_conta.webapi.Controllers;
using cadastro_conta.webapi.Models;
using cadastro_conta.webapi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Net;

namespace cadastro_conta.test.Controllers
{
    [TestClass]
    public class ClientesControllerTest
    {
        private Mock<IClienteService> clienteService;
        private Cliente jose;

        [TestInitialize]
        public void Inicialize()
        {
            clienteService = new Mock<IClienteService>();

            jose = new Cliente()
            {
                Nome = "José da Silva",
                NomeMae = "Maria da Silva",
                CPF = "00000000000",
                EstadoCivil = "Solteiro",
                DataNascimento = DateTime.Now.AddYears(-25),
                CEP = "02154000",
                Complemento = null,
                Renda = 2000.00,
                Numero = "5533",
                Bairro = "Mooca",
                Cidade = "Sao Paulo",
                Estado = "SP",
                Pais = "Brasil",
                Telefone="37622479",
                Tipo="PF",
                Id= "5de82676f08dde1e0c9ca233"
            };

            clienteService.Setup(x => x.Create(It.IsAny<Cliente>())).Returns(jose);
        }


        [TestMethod]
        public void CreateTest_201()
        {
            ClientesController clientesController = new ClientesController(clienteService.Object);

            Cliente pedro = new Cliente();

            var response = clientesController.Create(pedro);

            Assert.IsInstanceOfType(response.Result, typeof(CreatedAtRouteResult));
        }

    }
}
