using AgregacaoVetor;

Conta c1 = new Conta();

c1.Numero = 1;
c1.Saldo = 10000;
c1.VetTitulares = new List<Cliente>();
for (int i = 0; i < 3; i++)
{
    Cliente objetoCliente = new Cliente();

    Console.Write("Digite o nome: ");
    objetoCliente.Nome = Console.ReadLine();

    Console.Write("Digite o RG: ");
    objetoCliente.Rg = Convert.ToInt32(Console.ReadLine());

    c1.VetTitulares.Add(objetoCliente);
}

Console.WriteLine("\nApresentação dos Sócios\n");
foreach (var cliente in c1.VetTitulares) // var = tipo implicito; representa o tipo/class Cliente
{
    cliente.Mostrar();
}
