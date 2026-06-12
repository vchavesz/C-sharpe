double saldo = 0;
int opcao;
const string caminhoExtrato = "extrato.txt";

do
{
    ExibirMenu();

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Opcao invalida. Digite um numero de 1 a 5.");
        Pausar();
        continue;
    }

    switch (opcao)
    {
        case 1:
            ExibirSaldo();
            break;
        case 2:
            Depositar();
            break;
        case 3:
            Sacar();
            break;
        case 4:
            ExibirExtrato();
            break;
        case 5:
            Console.WriteLine("Programa encerrado.");
            break;
        default:
            Console.WriteLine("Escolha uma opcao valida.");
            break;
    }

    if (opcao != 5)
        Pausar();

} while (opcao != 5);

void ExibirMenu()
{
    Console.Clear();
    Console.WriteLine("=== Caixa Eletronico ===");
    Console.WriteLine("1 - Saldo");
    Console.WriteLine("2 - Depositar");
    Console.WriteLine("3 - Sacar");
    Console.WriteLine("4 - Extrato");
    Console.WriteLine("5 - Sair");
    Console.Write("Escolha uma opcao: ");
}

void ExibirSaldo()
{
    Console.WriteLine($"Saldo atual: R$ {saldo:F2}");
}

void Depositar()
{
    Console.Write("Valor do deposito: R$ ");

    if (!double.TryParse(Console.ReadLine(), out double deposito) || deposito <= 0)
    {
        Console.WriteLine("Valor para deposito invalido.");
        return;
    }

    saldo += deposito;
    SalvarOperacao("Deposito", deposito);
    Console.WriteLine("Deposito realizado com sucesso.");
}

void Sacar()
{
    Console.Write("Valor do saque: R$ ");

    if (!double.TryParse(Console.ReadLine(), out double saque) || saque <= 0)
    {
        Console.WriteLine("Valor para saque invalido.");
        return;
    }

    if (saque > saldo)
    {
        Console.WriteLine("Saldo insuficiente.");
        return;
    }

    saldo -= saque;
    SalvarOperacao("Saque", saque);
    Console.WriteLine("Saque realizado com sucesso.");
}

void ExibirExtrato()
{
    if (!File.Exists(caminhoExtrato))
    {
        Console.WriteLine("Nenhuma transacao registrada.");
        return;
    }

    string[] transacoes = File.ReadAllLines(caminhoExtrato);
    if (transacoes.Length == 0)
    {
        Console.WriteLine("Nenhuma transacao registrada.");
        return;
    }

    Console.WriteLine("=== Extrato ===");
    foreach (string transacao in transacoes)
        Console.WriteLine(transacao);
}

void SalvarOperacao(string operacao, double valor)
{
    File.AppendAllLines(caminhoExtrato, [$"{DateTime.Now:dd/MM/yyyy HH:mm} - {operacao}: R$ {valor:F2}"]);
}

void Pausar()
{
    Console.WriteLine();
    Console.Write("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}
