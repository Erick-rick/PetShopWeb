using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopWeb.Models
{
    public class Vendas
    {
     
        public int Codigo { get; set; }
        public string FormaPagamento { get; set; }
        public DateTime Data { get; set; }
        public float ValorVendido { get; set; }
        public float Total { get; set; }
        public string Status { get; set; }
        public int CodigoServico { get; set; }
        public float TotalServico { get; set; }
        public float ValorServico { get; set; }
        public int QuantidadeServico { get; set; }
        public int CodigoProduto { get; set; }
        public float TotalProduto { get; set; }
        public float ValorProduto { get; set; }
        public int QuantidadeProduto { get; set; }

        public Vendas()
        {
        }

        public Vendas(int codigo, string formaPagamento, DateTime data, float valorVendido, float total, string status, int codigoServico, float totalServico, float valorServico, int quantidadeServico, int codigoProduto, float totalProduto, float valorProduto, int quantidadeProduto)
        {
            Codigo = codigo;
            FormaPagamento = formaPagamento;
            Data = data;
            ValorVendido = valorVendido;
            Total = total;
            Status = status;
            CodigoServico = codigoServico;
            TotalServico = totalServico;
            ValorServico = valorServico;
            QuantidadeServico = quantidadeServico;
            CodigoProduto = codigoProduto;
            TotalProduto = totalProduto;
            ValorProduto = valorProduto;
            QuantidadeProduto = quantidadeProduto;
        }
    }
}
