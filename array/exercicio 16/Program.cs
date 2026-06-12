double[] numeros = new double[4];

for (int i = 0; i < 4; i++)
{
    while (true)
    {
        Console.Write($"Digite o {i + 1}º número decimal: ");
        string entrada = Console.ReadLine();

        if (double.TryParse(entrada, out double numero) && numero % 1 != 0)
        {
            numeros[i] = numero;
            break;
        }
        else
        {
            Console.WriteLine("Número inválido ou não decimal. Tente novamente.");
        }
    }
}

Console.WriteLine("Números digitados:");
foreach (double n in numeros)
{
    Console.WriteLine(n);
}

double soma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    soma += numeros[i];
}

double media = soma / numeros.Length;

Console.WriteLine(" A media dos 4 numeros decimais é: " + media);

/*
Este programa cria um array para armazenar 4 números decimais digitados pelo usuário.
Para cada número, ele pede a entrada e verifica se o valor é um número decimal válido
(utilizando double.TryParse) e se possui parte decimal (não é inteiro).

Se o número for válido e decimal, ele é armazenado no array; caso contrário, o programa
avisa o usuário e pede para digitar novamente.

Após receber os 4 números válidos, o programa imprime todos eles na tela,
calcula a soma dos números e, em seguida, calcula a média dividindo a soma pela quantidade de números.

Por fim, exibe a média dos números decimais digitados.
*/
