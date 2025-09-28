using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicaoConta
{
    public class Banco
    {
        public List<Poupanca>? Poups { get; set; }
        public List<ContaCorrente>? Contas { get; set; }

        public Banco()
        {
            Contas = new List<ContaCorrente>();
            Poups = new List<Poupanca>();
        }

        public void IniciarBanco()
        {
            Console.WriteLine("\nSistema bancário inicializado!");
            Console.WriteLine("Estrutura pronta para cadastrar contas.");
        }


        public void AbrirConta()
        {
            ContaCorrente c = new ContaCorrente();
            Contas?.Add(c);
            Console.WriteLine("\nConta corrente criada com sucesso!");
            c.GerarExtrato();
        }

        public void AbrirPoupanca()
        {
            Poupanca p = new Poupanca();
            Poups?.Add(p);
            Console.WriteLine("\nPoupança criada com sucesso!");
            p.Mostrar();
        }

         public void DecretarFalencia()
        {
            Console.WriteLine("\nDECRETANDO FALÊNCIA DO BANCO...");
            
            Poups = null;
            Contas = null;
            
            Console.WriteLine("Contas e Poupanças apagadas...");
        }

        ~Banco()
        {
            Console.WriteLine("Destruindo Banco...");
        }

    }
}