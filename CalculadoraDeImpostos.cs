using System;
using Xperiments.Paralelismo.Models;

namespace Xperiments.Paralelismo
{

    public class CalculadoraDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            var x = imposto.Calcula(orcamento);
            Console.WriteLine(x);
            
        }

    }

}