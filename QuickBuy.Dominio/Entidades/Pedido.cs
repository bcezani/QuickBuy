using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public DateTime DataPedido { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public int UsuarioId { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int EnderecoNumero { get; set; }

        public FormaPagamento FormaPagamento { get; set; }
        public int FormaPagamentoId { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; }
    }
}