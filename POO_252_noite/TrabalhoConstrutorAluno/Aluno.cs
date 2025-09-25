using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoConstrutorAluno
{
    public class Aluno
    {
        public long Ra { get; set; }
        public string? Nome { get; set; }
        public static long Contador { get; set; } = 15704824130000;

        public Aluno()
        {
            Contador++;
            Ra = Contador;
        }

        public Aluno(string nome)
        {
            Contador++;
            Nome = nome;
            Ra = Contador;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Aluno: {Nome} \tMatrícula: {Ra}");
        }
    }
}