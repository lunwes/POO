using HerancaFuncionario;

Funcionario f = new Funcionario(1000);
System.Console.WriteLine($"Funcionario: {f.CalcularBonificacao():c}");

Secretarios s = new Secretarios(1000);
System.Console.WriteLine($"Secretário: {s.CalcularBonificacao():c}");

Gerentes g = new Gerentes(1000);
System.Console.WriteLine($"Gerente: {g.CalcularBonificacao():c}");

Diretores d = new Diretores(1000);
System.Console.WriteLine($"Gerente: {d.CalcularBonificacao():c}");