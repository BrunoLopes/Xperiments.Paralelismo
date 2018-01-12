
using System;

namespace Xperiments.Paralelismo.Models
{
    public class Movimento
    {
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public TipoMovimento Tipo { get; set; }

    }

    public enum TipoMovimento
    {
        Saque,
        Deposito,
        Transferencia,
        RecarregarCelular,
        PagamentoDebito

    }

}