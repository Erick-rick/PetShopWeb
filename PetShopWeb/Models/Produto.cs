using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopWeb.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string NomeEmpresa { get; set; }
        public int Quantidade { get; set; }
        public float ValorCompra { get; set; }
        public float Venda{ get; set; }
    }
}
