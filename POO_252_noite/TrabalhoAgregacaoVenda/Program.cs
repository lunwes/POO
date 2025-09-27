using TrabalhoAgregacaoVenda;

Venda v1 = new Venda();
v1.Vend = new Vendedor();
v1.Comp = new Comprador(500);
v1.VetProd = new List<Produto>();
for (int i = 0; i < 2; i++)
{
    Produto objetoProduto = new Produto();

    Console.Write("Digite o nome do produto: ");
    objetoProduto.Nome = Console.ReadLine();

    Console.Write("Digite o preço do produto: ");
    objetoProduto.Preco = Convert.ToDouble(Console.ReadLine());

    v1.VetProd.Add(objetoProduto);
}

Console.WriteLine("\nVenda concluída!\n");

double totalVenda = v1.VetProd.Sum(prod => prod.Preco);

/* 
prod => prod.Preco é a forma compacta de escrever

    foreach (var prod in v1.VetProd)
    {
        totalVenda += prod.Preco;
    }

o operador => é uma forma compacta de escrever o foreach
*/

if (v1.Comp.Verba >= totalVenda)
{
    v1.Comp.SubtrairVerba(totalVenda);
    v1.Comp.MostrarAtributo();

    v1.Vend.CalcularComissao(totalVenda);
    v1.Vend.MostrarAtributo();

    Console.Write("Deseja imprimir os detalhes da venda? (s/n): ");
    string sn = Console.ReadLine();
    while (sn != null)
    {
        if (sn == "s")
        {
            v1.MostrarAtributos();
            break;
        }

        else if (sn == "n")
        {
            System.Console.WriteLine("Finalizando Venda . . .");
            break;
        }

        else
        {
            System.Console.WriteLine("\nResposta inválida!");
            Console.Write("\nDeseja imprimir os detalhes da venda? (s/n): ");
            sn = Console.ReadLine();
        }
    }   
}
else
    Console.WriteLine("Saldo insuficiente!");

