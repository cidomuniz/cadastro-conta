using cadastro_conta.webapi.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace cadastro_conta.test.Models
{
    [TestClass]
    public class ClienteTest
    {
        private string nome;
        private string nomeMae;
        private string razaoSocial;
        private string cpf;
        private string cnpj;
        private string estadoCivil;
        private DateTime dataNascimento;
        private string cep;
        private string complemento;
        private double renda;
        private string numero;
        private string bairro;
        private string cidade;
        private string estado;
        private string pais;
        private string telefone;
        private string tipo;

        [TestInitialize]
        public void Initialize()
        {
            nome = "Pedro da Silva";
            nomeMae = "Maria da Silva";
            razaoSocial = "Monstros S.A";
            cpf = "00000000000";
            cnpj = "000000000000000";
            estadoCivil = "Solteiro";
            dataNascimento = DateTime.Now.AddYears(-25);
            cep = "02154000";
            complemento = null;
            renda = 2000.00;
            numero = "5533";
            bairro = "Mooca";
            cidade = "Sao Paulo";
            estado = "SP";
            pais = "Brasil";
            telefone = "37622479";
            tipo = "PF";
        }

        [TestMethod]
        public void Cliente_PF()
        {
            Cliente pedro = new Cliente()
            {
                Nome = nome,
                NomeMae = nomeMae,
                CPF = cpf,
                EstadoCivil = estadoCivil,
                DataNascimento = dataNascimento,
                CEP = cep,
                Complemento = complemento,
                Renda = renda,
                Numero = numero,
                Bairro = bairro,
                Cidade = cidade,
                Estado = estado,
                Pais = pais,
                Telefone = telefone,
                Tipo = tipo
            };

            Assert.AreEqual(nome, pedro.Nome);
            Assert.AreEqual(nomeMae, pedro.NomeMae);
            Assert.AreEqual(cpf, pedro.CPF);
            Assert.AreEqual(estadoCivil, pedro.EstadoCivil);
            Assert.AreEqual(dataNascimento, pedro.DataNascimento);
            Assert.AreEqual(cep, pedro.CEP);
            Assert.AreEqual(complemento, pedro.Complemento);
            Assert.AreEqual(renda, pedro.Renda);
            Assert.AreEqual(numero, pedro.Numero);
            Assert.AreEqual(bairro, pedro.Bairro);
            Assert.AreEqual(cidade, pedro.Cidade);
            Assert.AreEqual(estado, pedro.Estado);
            Assert.AreEqual(pais, pedro.Pais);
            Assert.AreEqual(telefone, pedro.Telefone);
            Assert.AreEqual(tipo, pedro.Tipo);
        }

        [TestMethod]
        public void Cliente_PJ()
        {
            Cliente empresaFachada = new Cliente()
            {
                RazaoSocial = razaoSocial,
                CNPJ = cnpj,
                CEP = cep,
                Complemento = complemento,
                Renda = renda,
                Numero = numero,
                Bairro = bairro,
                Cidade = cidade,
                Estado = estado,
                Pais = pais,
                Telefone = telefone,
                Tipo = tipo
            };

            Assert.AreEqual(razaoSocial, empresaFachada.RazaoSocial);
            Assert.AreEqual(cnpj, empresaFachada.CNPJ);
            Assert.AreEqual(cep, empresaFachada.CEP);
            Assert.AreEqual(complemento, empresaFachada.Complemento);
            Assert.AreEqual(renda, empresaFachada.Renda);
            Assert.AreEqual(numero, empresaFachada.Numero);
            Assert.AreEqual(bairro, empresaFachada.Bairro);
            Assert.AreEqual(cidade, empresaFachada.Cidade);
            Assert.AreEqual(estado, empresaFachada.Estado);
            Assert.AreEqual(pais, empresaFachada.Pais);
            Assert.AreEqual(telefone, empresaFachada.Telefone);
            Assert.AreEqual(tipo, empresaFachada.Tipo);
        }

        [TestMethod]
        public void ValidaCPF_string_invalido()
        {
            Cliente cpfInvalido = new Cliente()
            {
                CPF = "hndsauigdai"
            };

            Assert.IsFalse(cpfInvalido.ValidaCPF());
        }

        [TestMethod]
        public void ValidaCPF_numero_invalido()
        {
            Cliente cpfInvalido = new Cliente()
            {
                CPF = "16546545644"
            };

            Assert.IsFalse(cpfInvalido.ValidaCPF());
        }

        [TestMethod]
        public void ValidaCPF_tamanho_invalido_menor()
        {
            Cliente cpfInvalido = new Cliente()
            {
                CPF = "123"
            };

            Assert.IsFalse(cpfInvalido.ValidaCPF());
        }

        [TestMethod]
        public void ValidaCPF_tamanho_invalido_maior()
        {
            Cliente cpfInvalido = new Cliente()
            {
                CPF = "12347687486787878465165465"
            };

            Assert.IsFalse(cpfInvalido.ValidaCPF());
        }

        [TestMethod]
        public void ValidaCPF_valido()
        {
            Cliente cpfValido = new Cliente()
            {
                CPF = "36636796839"
            };

            Assert.IsTrue(cpfValido.ValidaCPF());
        }

        [TestMethod]
        public void ValidaCNPJ_string_invalido()
        {
            Cliente cnpjInvalido = new Cliente()
            {
                CNPJ = "hndsauigdai"
            };

            Assert.IsFalse(cnpjInvalido.ValidaCNPJ());
        }

        [TestMethod]
        public void ValidaCNPJ_numero_invalido()
        {
            Cliente cnpjInvalido = new Cliente()
            {
                CNPJ = "12546421545404"
            };

            Assert.IsFalse(cnpjInvalido.ValidaCNPJ());
        }

        [TestMethod]
        public void ValidaCNPJ_tamanho_invalido_menor()
        {
            Cliente cnpjInvalido = new Cliente()
            {
                CNPJ = "123"
            };

            Assert.IsFalse(cnpjInvalido.ValidaCNPJ());
        }

        [TestMethod]
        public void ValidaCNPJ_tamanho_invalido_maior()
        {
            Cliente cnpjInvalido = new Cliente()
            {
                CNPJ = "12347687486787878465165465"
            };

            Assert.IsFalse(cnpjInvalido.ValidaCNPJ());
        }

        [TestMethod]
        public void ValidaCNPJ_valido()
        {
            Cliente cnpjValido = new Cliente()
            {
                CNPJ = "60701190000104"
            };

            Assert.IsTrue(cnpjValido.ValidaCNPJ());
        }
    }
}
