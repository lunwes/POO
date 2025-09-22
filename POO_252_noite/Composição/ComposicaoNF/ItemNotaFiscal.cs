using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNF
{
    public class ItemNotaFiscal
    {
        public int QtdProduto { get; set; }
        public ItemNotaFiscal(int qtdProduto)
        {
            QtdProduto = qtdProduto;
        }

        ~ItemNotaFiscal() // destrutor da classe
        {
            Console.WriteLine("Destruindo o Item nota fiscal");
        }
        public void Mostrar()
        {
            Console.WriteLine("Quantidade de produto: " + QtdProduto);
        }
    }
}