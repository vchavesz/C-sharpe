using System;
using System.IO;

class ProgramaHorta
{
    static void Main()
    {
        ExibirMenu();

        Console.Write("Digite a opção desejada: ");
        string entrada = Console.ReadLine();

        // Tenta converter a entrada para número inteiro
        if (int.TryParse(entrada, out int opcao))
        {
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
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Digite um número.");
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
        string item = Console.ReadLine().Trim().ToLower(); // Remover espaços e padronizar

        string nomeArquivo = tipo + "s.csv"; // fruta → frutas.csv
        if (!File.Exists(nomeArquivo))
        {
            File.WriteAllText(nomeArquivo, ""); // Cria arquivo vazio se não existir
        }

        string conteudo = File.ReadAllText(nomeArquivo);
        string[] itensExistentes = conteudo.Split(",", StringSplitOptions.RemoveEmptyEntries);

        bool jaExiste = false;
        foreach (string existente in itensExistentes)
        {
            if (item == existente.Trim().ToLower())
            {
                jaExiste = true;
                Console.WriteLine($"{tipo} \"{item}\" já está cadastrado.");
                break;
            }
        }

        if (!jaExiste)
        {
            File.WriteAllText(nomeArquivo, conteudo + item + ",");
            Console.WriteLine($"{tipo} \"{item}\" salvo com sucesso!");
        }
    }
}
