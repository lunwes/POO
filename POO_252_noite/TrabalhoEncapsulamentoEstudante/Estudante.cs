using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoEncapsulamentoEstudante
{
    public class Estudante
    {
        private string? nome;
        private double nota;
        public string? Nome
        {
            get { return char.ToUpper(nome[0]) + nome.Substring(1).ToLower(); }
            set { nome = value; }
        }

        public double Nota
        {
            get { return nota; }
            set
            {
                if (value < 0 && value > 10)
                {
                    Console.WriteLine("Valor da nota inválido!");
                }
                else
                    nota = value;
            }
        }

        public bool EstaAprovado()
        {
            if (Nota >= 6)
            {
                return true;
            }
            else
                return false;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("Status: " + EstaAprovado());
        }
    }
}