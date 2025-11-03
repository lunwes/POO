using HerancaProduto;

Console.Clear();

Produto p = new Produto(1, "Garfo", 20.50);
p.Mostrar();

Perecivel pe = new Perecivel(2, "Bolo", 12.75, "31/10/2025", "01/09/2025", 678);
pe.Mostrar();