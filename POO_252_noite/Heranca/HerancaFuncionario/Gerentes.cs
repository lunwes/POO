using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Gerentes : Funcionario
    {
        public Gerentes(double salario) : base (salario)
        {
        }
        public override double CalcularBonificacao()
        {
            return Salario * 15 / 100;
        }
    }
}