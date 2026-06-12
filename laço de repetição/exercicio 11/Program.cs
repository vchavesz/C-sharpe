Console.WriteLine("Numero inteiro positivo");
int N = int.Parse(Console.ReadLine());

int soma = 0;

for (int i = 1; i <= N; i++)
{
    soma += i;
}

Console.WriteLine("A soma dos números de 1 até " + N + " é: " + soma);