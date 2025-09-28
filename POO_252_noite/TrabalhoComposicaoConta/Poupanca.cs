using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicaoConta
{
    public class Poupanca
    {
        public double Saldo { get; private set; }
        public int Numero { get; set; }
        public static int Contador { get; set; }

        public Poupanca()
        {
            Contador++;
            Numero = Contador;
        }

        public bool Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            System.Console.WriteLine("Depósito realizado com sucesso!");
        }

        public void GerarRendimento()
        {
            double rendimento = Saldo * 0.005;
            Saldo += rendimento;

            Console.WriteLine($"Rendimento: {rendimento:c}");
            Console.WriteLine($"Novo saldo: {Saldo:c}");
        }

        public void Mostrar()
        {
            System.Console.WriteLine($"Número: {Numero} \tSaldo: {Saldo:c}");
        }

        ~Poupanca() // destrutor da classe
        {
            Console.WriteLine("Destruindo Poupança...");
        }
    }
}