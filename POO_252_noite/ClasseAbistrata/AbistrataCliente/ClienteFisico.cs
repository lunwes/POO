using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbistrataCliente
{
    public class ClienteFisico : Cliente
    {
        public int Rg { get; set; }
        public ClienteFisico(int codigo, string nome, int idade, int rg) : base(codigo, nome, idade)
        {
            Rg = rg;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Rg: " + Rg);
        }
        public override void VerificarIdade()
        {
            if (Idade >= 18 && idade <= 45)
            System.Console.WriteLine("Cliente físico!");
        }
    }
}