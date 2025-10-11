using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class ClienteFisico : Cliente
    { //         classe derivada : class base
        private int rg;
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public void Mostrar()
        { /* codigo minusculo tem o modificador de acesso/visibilidade aberto para acessar
        a superclasse, pela palavra reservada protected */
            Console.WriteLine($"Código: {codigo} \tNome: {nome} \tRG: {Rg}");
        }
        
    }
}