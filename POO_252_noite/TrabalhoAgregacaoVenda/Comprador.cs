using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Comprador
    {
        public double Verba { get; set; }
        public Comprador (double verba)
        {
            Verba = verba;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Verba: " + Verba);
        }

        public void SubtrairVerba(double valor)
        {
            Verba = Verba - valor;
        }
    }
}