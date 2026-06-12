// Revisão - Calculadora de IMC
// Lê nome, peso e altura do usuário, calcula o IMC e exibe a classificação.
// CORREÇÃO: adicionado .Replace('.', ',') também no campo peso para consistência regional.
// CORREÇÃO: adicionado null-coalescing operator nos ReadLine() para evitar warning de nullable.

Console.Write("Digite seu nome: ");
string nome = Console.ReadLine() ?? "Usuário";

double peso;
while (true)
{
    Console.Write("Digite seu peso em kg (ex: 70,5): ");
    string entrada = Console.ReadLine()?.Replace('.', ',') ?? "";

    if (double.TryParse(entrada, out peso) && peso > 0)
        break;

    Console.WriteLine("Peso inválido. Tente novamente.");
}

double altura;
while (true)
{
    Console.Write("Digite sua altura em metros (ex: 1,75): ");
    string entrada = Console.ReadLine()?.Replace('.', ',') ?? "";

    if (double.TryParse(entrada, out altura) && altura > 0)
        break;

    Console.WriteLine("Altura inválida. Tente novamente.");
}

double imc = peso / (altura * altura);

string classificacao = imc switch
{
    < 18.5 => "Abaixo do peso",
    < 25.0 => "Peso normal",
    < 30.0 => "Sobrepeso",
    _      => "Obesidade"
};

Console.WriteLine($"\nOlá, {nome}!");
Console.WriteLine($"Peso:       {peso:F1} kg");
Console.WriteLine($"Altura:     {altura:F2} m");
Console.WriteLine($"IMC:        {imc:F2}");
Console.WriteLine($"Resultado:  {classificacao}");
