using ConstrutorFuncionario;

Funcionario f1 = new Funcionario();
f1.MostrarAtributos();

Funcionario f2 = new Funcionario(2);
f2.MostrarAtributos();

Funcionario f3 = new Funcionario(3, "Paula");
f3.MostrarAtributos();

Funcionario f4 = new Funcionario(4, "Jorgina", 3000.50);
f4.MostrarAtributos();