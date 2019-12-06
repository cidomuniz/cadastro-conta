using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace cadastro_conta.webapi.Models
{
    public class Cliente
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Name")]
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NomeMae { get; set; }
        public string Telefone { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string CEP { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public double Renda { get; set; }
        public string Tipo { get; set; }



        //public Cliente(string id, string nome, string cPF, string estadoCivil, DateTime dataNascimento, string nomeMae, string telefone, 
        //    string razaoSocial, string cNPJ, string cEP, string pais, string estado, string cidade, string bairro, 
        //    string numero, string complemento, double renda, string tipo)
        //{
        //    Id = id;
        //    Nome = nome;
        //    CPF = cPF;
        //    EstadoCivil = estadoCivil;
        //    DataNascimento = dataNascimento;
        //    NomeMae = nomeMae;
        //    Telefone = telefone;
        //    RazaoSocial = razaoSocial;
        //    CNPJ = cNPJ;
        //    CEP = cEP;
        //    Pais = pais;
        //    Estado = estado;
        //    Cidade = cidade;
        //    Bairro = bairro;
        //    Numero = numero;
        //    Complemento = complemento;
        //    Renda = renda;
        //    Tipo = tipo;
        //}

        public bool ValidaCPF()
        {
            return true;
        }

        public bool ValidaCNPJ()
        {
            return true;
        }

    }
}
