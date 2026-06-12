double valor;

do
{
    Console.WriteLine("Digite um valor qualquer ou escreva 0 para sair do programa. ");
    valor = double.Parse(Console.ReadLine());


    if (valor != 0) 
    {
        double resultado = valor * 0.25;
        Console.WriteLine(" 25% de " + valor + " é: " + resultado);
    }

} while (valor != 0);
Console.WriteLine("Programa encerrado.");