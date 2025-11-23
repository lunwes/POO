using HerancaFuncionario;

Funcionario f = new Funcionario(1000);
Secretario s = new Secretario(1000);
Gerente g = new Gerente(1000);
Diretor d = new Diretor(1000);

GerenciadorBonificacao gb = new GerenciadorBonificacao();

gb.TotalizadorBonificacao(f);
gb.TotalizadorBonificacao(s);
gb.TotalizadorBonificacao(g);
gb.TotalizadorBonificacao(d);

Console.WriteLine($"Funcionário: {f.CalcularBonificacao():c}");
Console.WriteLine($"Secretário: {s.CalcularBonificacao():c}");
Console.WriteLine($"Gerente: {g.CalcularBonificacao():c}");
Console.WriteLine($"Diretor: {d.CalcularBonificacao():c}");

Console.WriteLine($"\nTotal de Bonificações: {gb.TotalBonificacao:c}");
