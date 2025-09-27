using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Produto
    {
        public int Codigo { get; set; }
        public static int Contador { get; set; } = 499;
        private string? nome;
        public string? Nome
        {
            get { return char.ToUpper(nome[0]) + nome.Substring(1).ToLower();; }
            set { nome = value; }
        }
        
        private double preco;
        public double Preco
        {
            get { return preco; }
            set
            {
                if (value >= 0.01)
                {
                    preco = value;
                }
                else
                    Console.WriteLine("Preço Inválido!");                
            } 
        }

        public Produto()
        {
            Contador++;
            Codigo += Contador;
        }
        
        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo} \tNome: {Nome} \tPreço: {Preco:c}");
        }
    }
}