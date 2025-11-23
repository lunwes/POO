using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public abstract class Funcionario
    {
        protected int codigo;
        protected string? nome;
        protected Endereco endereco;
        protected double salario;
        public List<Dependente> Dependentes { get; set; }

        public Funcionario(int codigo, string nome, Endereco endereco, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            _Endereco = endereco;
            Salario = salario;
            Dependentes = new List<Dependente>();
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string? Nome { get => nome; set => nome = value; }

        public Endereco _Endereco
        {
            get => endereco;
            set => endereco = value;
        }

        public double Salario { get => salario; set => salario = value; }

        public virtual void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo} Nome: {Nome} Salário {Salario:c}");
        }

        public abstract double CalcularSalario(int diasUteis);
        public int CalcularTotalDependente()
        {
            return Dependentes.Count;
        }

        public void AdicionarDependente(Dependente novoDep)
        {
            Dependentes.Add(novoDep);
        }

        public void RemoverDependente(int codigo)
        {
            Dependentes.RemoveAll(d => d.Codigo == codigo);
        }

        public void ListarDependentes()
        {
            foreach (var d in Dependentes)
                Console.WriteLine($"Dependente: {d.Nome} - Idade: {d.Idade}");
        }

        public void MostrarQtdeDependentesFuncionario()
        {
            Console.WriteLine($"{Nome} possui {Dependentes.Count} dependentes.");
        }
    }
}
