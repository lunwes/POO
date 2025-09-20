using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVetor
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        // estabelece a relação de associação pelo atributo Titular da classe Conta
        public List<Cliente> VetTitulares { get; set; }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {Numero} \tSaldo:  {Saldo:c}");
        }
    }
}