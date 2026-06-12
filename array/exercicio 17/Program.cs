int[] numeros = new int[6];

for (int i = 0; i < 6; i++)
{
    while (true)
    {
        Console.Write($"Digite o {i + 1}º número inteiro: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int numero) )
        {
            numeros[i] = numero;
            break;
        }
        else
        {
            Console.WriteLine("Número inválido ou não inteiro. Tente novamente.");
        }
    }
}

Console.WriteLine("Números digitados:");
foreach (int n in numeros)
{
    Console.WriteLine(n);
}

int soma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    int dobro = numeros[i] * 2;
    Console.WriteLine($"Número: {numeros[i]} → Dobro: {dobro}");
}

/*  O programa começa criando um **array de inteiros com 6 posições**, chamado `numeros`. Esse array vai servir para armazenar os 6 números que o usuário irá digitar.

Em seguida, o programa usa um **laço `for`** que repete 6 vezes, uma para cada número. Dentro desse laço, existe um **`while (true)`**, que faz o programa **ficar pedindo o número até o usuário digitar um valor válido**.

A entrada do usuário é lida como texto usando `Console.ReadLine()`. Em seguida, o `int.TryParse` tenta converter esse texto para um número inteiro.
Se a conversão der certo (ou seja, o usuário digitou um número inteiro válido), esse número é armazenado na posição correspondente do array, e o programa segue para o próximo número.
Se o valor digitado for inválido (como letras ou número com vírgula), o programa avisa o erro e pede para digitar novamente.

Depois de todos os números serem digitados corretamente e armazenados, o programa imprime a lista de números usando um `foreach`, mostrando cada um na tela.

Por fim, o programa percorre o array mais uma vez com outro `for`, e para cada número armazenado, calcula o **dobro** (multiplicando por 2) e imprime no seguinte formato:

```
Número: X → Dobro: Y
```
Este código é útil para praticar manipulação de arrays, validação de entrada de dados,
e uso de estruturas de repetição (for, while) em C#.
*/