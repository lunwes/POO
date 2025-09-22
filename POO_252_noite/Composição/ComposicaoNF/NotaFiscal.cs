using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNF
{
    public class NotaFiscal
    {
        public int NumeroNf { get; set; }
        public string? Data { get; set; }
        public List<ItemNotaFiscal> VetItens { get; set; }

        public NotaFiscal(int nf, string data)
        { // inicializa os atributos da classe
            /* no momento da instância do objeto-todo que é a NotaFiscal, a instância da 
            relação/associação DEVE ser realizada/estabelecida */
            VetItens = new List<ItemNotaFiscal>();
            NumeroNf = nf;
            Data = data;
        }
        ~NotaFiscal() // o destrutor retira a referência de memória do objeto instanciado
        {
            // implemente o fechamento dos recursos em aberto aqui
            VetItens = null; // null retira a referência da memória
            Console.WriteLine("Destruindo a nota fiscal");
        }
    }
}