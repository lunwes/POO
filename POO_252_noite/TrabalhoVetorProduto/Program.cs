using TrabalhoVetorProduto;

// declaração de um vetor com apenas 4 elementos para facilitar nos testes!
Produto[] vetProduto = new Produto[4];

for (int i = 0; i < vetProduto.Length; i++)
{
    vetProduto[i] = new Produto();
    Console.Write("Digite o código: ");
    vetProduto[i].codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o nome: ");
    vetProduto[i].nome = Console.ReadLine();
    Console.Write("Digite o preço: ");
    vetProduto[i].preco = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o estoque: ");
    vetProduto[i].estoque = Convert.ToInt32(Console.ReadLine());
}

foreach (Produto p in vetProduto)
    p.MostrarAtributos();

foreach (Produto p in vetProduto)
    p.CalcularSubtotal();

foreach (Produto p in vetProduto)
    p.MostrarAtributos();

for (int i = 0; i < vetProduto.Length; i++)
{
    int r = i % 2;
    if (r == 0)
    {
        vetProduto[i].CalcularAumento(10);
    }
}

for (int i = 0; i < vetProduto.Length; i++)
{
    int r = i % 2;
    if (r != 0)
    {
        vetProduto[i].RetirarEstoque(3);
    }
}

foreach (Produto p in vetProduto)
    p.CalcularSubtotal();

foreach (Produto p in vetProduto)
    p.MostrarAtributos();