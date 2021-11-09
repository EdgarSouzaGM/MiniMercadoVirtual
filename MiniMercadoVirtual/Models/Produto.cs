using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniMercadoVirtual.Models.Enums;

namespace MiniMercadoVirtual.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtAlteracao { get; set; }
        public StatusProduto Status { get; set; }
    }
}
