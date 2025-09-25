using System;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Salario { get; set; }
        public static int Contador { get; set; }
    
        public Funcionario()
        {
            Contador += 1;
        }

        public Funcionario(int codigo)
        {
            Codigo = codigo;
            Contador += 1;
        }

        public Funcionario(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Contador += 1;
        }

        // declaração de construtor - atalho ctr

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            Contador += 1;
        }
        
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + Codigo +
            "\tNome: " + Nome + "\tSalário: " + Salario + "\nQuantidade de Funcionários: " + Contador);
        }
    }
}