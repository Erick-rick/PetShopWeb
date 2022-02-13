using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopWeb.Models
{
    public class Animal
    {
       

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Sexo { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Proprietario { get; set; }


        public Animal()
        {
        }

        public Animal(int codigo, string nome, DateTime data, string sexo, string tipo, string descricao, string proprietario)
        {
            Codigo = codigo;
            Nome = nome;
            Data = data;
            Sexo = sexo;
            Tipo = tipo;
            Descricao = descricao;
            Proprietario = proprietario;
        }
    }
}
