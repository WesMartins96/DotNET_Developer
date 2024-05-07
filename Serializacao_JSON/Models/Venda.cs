using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacao_JSON.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }

        public override string ToString()
        {
            return $"ID: {Id} / PRODUTO: {Produto} / PREÇO: {Preco.ToString("F2")} / DATA DA VENDA: {DataVenda.ToString("dd/MM/yyyy")}";
        }
    }
}
