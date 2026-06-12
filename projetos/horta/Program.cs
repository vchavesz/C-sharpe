class ProgramaHorta
{
    static void Main()
    {
        ExibirMenu();

        Console.Write("Digite a opcao desejada: ");
        string entrada = Console.ReadLine() ?? "";

        if (!int.TryParse(entrada, out int opcao))
        {
            Console.WriteLine("Entrada invalida. Digite um numero.");
            return;
        }

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Digite o nome da fruta a ser salva:");
                SalvarItem("fruta");
                break;
            case 2:
                Console.WriteLine("Digite o nome do legume a ser salvo:");
                SalvarItem("legume");
                break;
            case 3:
                Console.WriteLine("Digite o nome da verdura a ser salva:");
                SalvarItem("verdura");
                break;
            default:
                Console.WriteLine("Opcao invalida.");
                break;
        }
    }

    static void ExibirMenu()
    {
        Console.WriteLine("=== Cadastro de Produtos da Horta ===");
        Console.WriteLine("1 - Fruta");
        Console.WriteLine("2 - Legume");
        Console.WriteLine("3 - Verdura");
    }

    static void SalvarItem(string tipo)
    {
        string item = (Console.ReadLine() ?? "").Trim().ToLower();
        if (string.IsNullOrWhiteSpace(item))
        {
            Console.WriteLine("Nome invalido.");
            return;
        }

        string nomeArquivo = tipo + "s.csv";
        if (!File.Exists(nomeArquivo))
            File.WriteAllText(nomeArquivo, "");

        string conteudo = File.ReadAllText(nomeArquivo);
        string[] itensExistentes = conteudo.Split(",", StringSplitOptions.RemoveEmptyEntries);

        foreach (string existente in itensExistentes)
        {
            if (item == existente.Trim().ToLower())
            {
                Console.WriteLine($"{tipo} \"{item}\" ja esta cadastrado.");
                return;
            }
        }

        File.WriteAllText(nomeArquivo, conteudo + item + ",");
        Console.WriteLine($"{tipo} \"{item}\" salvo com sucesso!");
    }
}
