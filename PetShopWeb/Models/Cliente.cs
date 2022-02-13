using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopWeb.Models
{
    public class Cliente
    {
    
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Rg { get; set; }
        public int Cpf { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public int Cep { get; set; }
        public int Telefone { get; set; }

        public Cliente()
        {
        }

        public Cliente(int codigo, string nome, int rg, int cpf, string endereco, int numero, string bairro, int cep, int telefone)
        {
            Codigo = codigo;
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            Telefone = telefone;
        }
    }
}
