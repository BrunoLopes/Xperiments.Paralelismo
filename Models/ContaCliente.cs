using System;
using System.Collections.Generic;

namespace Xperiments.Paralelismo.Models
{
    
    public class ContaCliente
    {
        public string NomeCliente {get; set;}
        public List<Movimento> Movimentacoes {get; set;}
        public decimal Investimento { get; set;} 

    }
}