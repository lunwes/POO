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
                if (value > 0 && value < 10)
                {
                    nota = value;
                }
                else
                
                    Console.WriteLine("\nValor da nota inválido!");
            }
        }

        public bool EstaAprovado()
        {
           return nota >= 6;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"\nNome: {Nome} \tNota: {Nota} \tStatus: {(EstaAprovado() ? "Aprovado!" : "Reprovado.")}");
        }
    }
}