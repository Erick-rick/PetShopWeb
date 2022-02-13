using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopWeb.Models
{
    public class Servico
    {
        public int Codigo { get; set; }
        public int Vagas { get; set; }
        public String Descricao { get; set; }
        public float Valor { get; set; }

        public Servico()
        {
        }

        public Servico(int codigo, int vagas, string descricao, float valor)
        {
            Codigo = codigo;
            Vagas = vagas;
            Descricao = descricao;
            Valor = valor;
        }
    }


}
