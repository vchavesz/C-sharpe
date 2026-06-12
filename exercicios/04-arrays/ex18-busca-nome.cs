// Exercício 18 - Busca de Nome em Array
// Busca um nome digitado dentro de uma lista fixa.
// MELHORIA: comparação sem sensibilidade a maiúsculas/minúsculas.

string[] nomes = { "Vinicius", "Pedro", "Julia", "Ana Julia", "Arthur" };
bool encontrado = false;

while (!encontrado)
{
    Console.Write("Digite um nome para buscar: ");
    string nomeDigitado = Console.ReadLine() ?? "";

    foreach (string nome in nomes)
    {
        if (nome.Equals(nomeDigitado, StringComparison.OrdinalIgnoreCase))
        {
            encontrado = true;
            break;
        }
    }

    if (encontrado)
        Console.WriteLine($"✔ Nome \"{nomeDigitado}\" encontrado com sucesso!");
    else
        Console.WriteLine($"✘ Nome \"{nomeDigitado}\" não encontrado. Tente novamente.");
}
