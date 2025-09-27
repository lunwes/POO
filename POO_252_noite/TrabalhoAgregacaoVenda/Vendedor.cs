using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Vendedor
    {
        public double Comissao { get; set; }

        public void CalcularComissao(double valor)
        {
            Comissao = valor * 2 / 100;
        }
        public void MostrarAtributo()
        {
            Console.WriteLine($"Comissão da venda: {Comissao:c}");
        }
    }
}