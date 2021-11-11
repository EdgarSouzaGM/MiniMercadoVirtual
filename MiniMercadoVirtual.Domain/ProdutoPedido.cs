using System;
using MiniMercadoVirtual.Domain.Enums;

namespace MiniMercadoVirtual.Domain
{
    public class ProdutoPedido
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
        public int PedidoId { get; set; }
    }
}
