using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class GerenciadorBonificacao
    {
        public double TotalBonificacao { get; private set; }

        public void TotalizadorBonificacao(Funcionario f)
        {
            this.TotalBonificacao += f.CalcularBonificacao();
        }
        
        public void TotalizadorBonificacao(Secretario s)
        {
            this.TotalBonificacao += s.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Gerente g)
        {
            this.TotalBonificacao += g.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Diretor d)
        {
            this.TotalBonificacao += d.CalcularBonificacao();
        }
    }
}
