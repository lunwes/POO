using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicaoConta
{
    public class ContaCorrente
    {
        public double Saldo { get; private set; }
        public double ChequeEspecial { get; private set; }
        public int Numero { get; set; }
        public static int Contador { get; set; }

        public ContaCorrente()
        {
            Contador++;
            Numero = Contador;
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                System.Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                ChequeEspecial = valor - Saldo;
                Saldo = 0;
                Console.WriteLine($"Saldo Insuficiente! Cheque especial de {ChequeEspecial:c} criado!");
            }
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            System.Console.WriteLine("Depósito realizado com sucesso!");
        }

        public void GerarExtrato()
        {
            Console.WriteLine($"Número: {Numero} \tSaldo: {Saldo:c}");
        }

        ~ContaCorrente() 
        {
            Console.WriteLine("Destruindo Conta Corrente...");
        }
    }
}