using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            VetF = new List<Funcionario>();
        }

        public void Mostrar()
        {
            Console.WriteLine($"Código do departamento: {Codigo} Nome: {Nome}");
        }

        public void AdmitirFuncionario(Funcionario f)
        {
            VetF.Add(f);
        }

        public void ListarFuncionarios()
        {
            foreach (var f in VetF)
                f.Mostrar();
        }

        public void DemitirFuncionario(int codigo)
        {
            VetF.RemoveAll(f => f.Codigo == codigo);
        }

        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            foreach (var f in VetF)
                folha += f.CalcularSalario(diasUteis);

            return folha;
        }

        public void MostrarQtdeDependentesFuncionario()
        {
            foreach (var f in VetF)
            {
                f.MostrarQtdeDependentesFuncionario();
            }
        }
    }
}