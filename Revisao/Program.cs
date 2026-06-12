// See https://aka.ms/new-console-template for more information

Console.WriteLine(" Digite seu nome: ");
string nome = Console.ReadLine();

 double peso;
    while (true)
{
                Console.WriteLine("Digite seu peso em kg : ");
                if (double.TryParse(Console.ReadLine(), out peso ))
                break;
                Console.WriteLine("Peso invalido, tente novamente! ");

}

double altura;
    while(true)
{

                Console.WriteLine("Digite sua altura ex (1,90): ");
                if (double.TryParse(Console.ReadLine().Replace('.', ','), out altura) && altura > 0)
                break;
                Console.WriteLine("Peso invalidado, tente novamente! ");
                
}

double imc = peso / (altura * altura);

string classificacao = imc switch
{
    < 18.5 => "Abaixo do peso",
    < 25   => "Peso normal",
    < 30   => "Sobrepeso",
    _      => "Obesidade"
};


Console.WriteLine($"Olá {nome}, seu imc é:  {imc:F2} ({classificacao})" );