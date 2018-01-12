using System;
using System.Collections.Generic;
using Xperiments.Paralelismo.Models;

namespace Xperiments.Paralelismo.Repository
{
    
    public class ContaClienteRepository
    {
        public string ConsolidarMovimentacao(ContaCliente conta)
        {
            var soma =0m;

            foreach (var movimento in conta.Movimentacoes)
                soma += movimento.Valor * FatorDeMultiplicacao(movimento.Data);

            AtualizarInvestimentos(conta);

            return $"Cliente { conta.NomeCliente } tem saldo atualizado de R$ {soma.ToString("00.000,00")} ";
                
            
        }

        private static decimal FatorDeMultiplicacao(DateTime dataMovimento)
        {
            
        }

    }
}