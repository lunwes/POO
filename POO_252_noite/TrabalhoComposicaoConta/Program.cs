using TrabalhoComposicaoConta;

Banco b = new Banco();
b.IniciarBanco();

int Menu()
{
    System.Console.WriteLine("\n == MENU DE AÇÕES == \n");
    System.Console.WriteLine("1 - Abrir Conta Corrente" +
    "\n2 - Depósito Conta Corrente" +
    "\n3 - Saque Conta Corrente" +
    "\n4 - Gerar Extrato" +
    "\n5 - Abrir Poupança" +
    "\n6 - Depósito Poupança" +
    "\n7 - Saque Poupança" +
    "\n8 - Gerar Rendimento" +
    "\n9 - Decretar Falência" +
    "\n10 - Sair");
    System.Console.Write("Digite o número da ação desejada: ");
    int op = Convert.ToInt32(Console.ReadLine());
    return op;
}

int op = Menu();

if (op > 10 || op < 1)
{
    System.Console.WriteLine("\nOpção inválida!");
    op = Menu();
}

while (op >= 1 && op <= 10)
{

    if (op == 1)
    {
        Console.Clear();
        System.Console.WriteLine("Opção selecionada: 1");
        b.AbrirConta();
        op = Menu();
    }

    else if (op == 2)
    {
        Console.Clear();
        System.Console.WriteLine("Opção selecionada: 2");
        System.Console.Write("Digite o número da conta que deseja depositar: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        bool encontrado = false;
        foreach (var c in b.Contas)
        {
            if (c.Numero == n1)
            {
                System.Console.Write("Quantia a depositar: ");
                double deposito = Convert.ToDouble(Console.ReadLine());
                c.Depositar(deposito);
                encontrado = true;
                break;
            }
        }
        if (!encontrado)
        {
            System.Console.WriteLine("Conta não encontrada!");
        }
        op = Menu();
    }

    else if (op == 3)
    {
        Console.Clear();
        System.Console.WriteLine("Opção selecionada: 3");
        System.Console.Write("Digite o número da conta que deseja sacar: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        bool encontrado = false;
        foreach (var c in b.Contas)
        {
            if (c.Numero == n1)
            {
                System.Console.Write("Valor a ser retirado: ");
                double saque = Convert.ToDouble(Console.ReadLine());
                c.Sacar(saque);
                encontrado = true;
                break;
            }
        }
        if (!encontrado)
        {
            System.Console.WriteLine("Conta não encontrada!");
        }
        op = Menu();
    }

    else if (op == 4)
    {
        Console.Clear();
        System.Console.WriteLine("Opção selecionada: 4");
        System.Console.Write("Digite o número da conta que deseja gerar extrato: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        bool encontrado = false;
        foreach (var c in b.Contas)
        {
            if (c.Numero == n1)
            {
                c.GerarExtrato();
                encontrado = true;
                break;
            }
        }
        if (!encontrado)
        {
            System.Console.WriteLine("Conta não encontrada!");
        }
        op = Menu();
    }

    else if (op == 5)
    {
        Console.Clear();
        System.Console.WriteLine("Opção selecionada: 5");
        b.AbrirPoupanca();
        op = Menu();
    }

    else if (op == 6)
    {
        Console.Clear();
        System.Console.WriteLine("Opção selecionada: 6");
        System.Console.Write("Digite o número da poupança que deseja depositar: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        bool encontrado = false;
        foreach (var p in b.Poups)
        {
            if (p.Numero == n1)
            {
                System.Console.Write("Quantia a depositar: ");
                double deposito = Convert.ToDouble(Console.ReadLine());
                p.Depositar(deposito);
                encontrado = true;
                break;
            }
        }
        if (!encontrado)
        {
            System.Console.WriteLine("Poupança não encontrada!");
        }
        op = Menu();
    }

    else if (op == 7)
    {
        Console.Clear();
        System.Console.WriteLine("Opção selecionada: 7");
        System.Console.Write("Digite o número da poupança que deseja sacar: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        bool encontrado = false;
        foreach (var p in b.Poups)
        {
            if (p.Numero == n1)
            {
                System.Console.Write("Valor a ser retirado: ");
                double saque = Convert.ToDouble(Console.ReadLine());
                bool saqueRealizado = p.Sacar(saque);
                if (saqueRealizado)
                {
                    Console.WriteLine("Saque realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi possível realizar o saque. Saldo insuficiente.");
                }
                encontrado = true;
                break;
            }
        }
        if (!encontrado)
        {
            System.Console.WriteLine("Poupança não encontrada!");
        }
        op = Menu();
    }

    else if (op == 8)
    {
        Console.Clear();
        System.Console.WriteLine("Opção selecionada: 8");
        System.Console.Write("Digite o número da poupança que deseja gerar rendimento: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        bool encontrado = false;
        foreach (var p in b.Poups)
        {
            if (p.Numero == n1)
            {
                p.GerarRendimento();
                encontrado = true;
                break;
            }
        }
        if (!encontrado)
        {
            System.Console.WriteLine("Poupança não encontrada!");
        }
        op = Menu();
    }

    else if (op == 9)
    {
        b.DecretarFalencia();
        Console.WriteLine("\n=== FORÇANDO DESTRUIÇÃO ===");
        b = null;
        GC.Collect();
        Console.WriteLine("Programa encerrado.");
        break;
    }

    else if (op == 10)
    {
        Console.WriteLine("Saindo . . .");
        break;
    }
}

