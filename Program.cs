using System;
using Xperiments.Paralelismo.Models;

namespace Xperiments.Paralelismo
{
    class Program
    {
    static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.00);

            CalculadoraDeImpostos calculadora = new CalculadoraDeImpostos();
            
            calculadora.RealizaCalculo(orcamento, iss);
            
            calculadora.RealizaCalculo(orcamento, icms);
            
        }
    }
}
