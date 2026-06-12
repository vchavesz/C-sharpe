string[] nomes = { "Vinicius", "Pedro", "Julia", "Ana julia", "Arthur" };
string nomeDigitado;
bool encontrado = false;

while (!encontrado)
{
    Console.WriteLine("Digite um nome: ");
    nomeDigitado = Console.ReadLine();

    for (int i = 0; i < nomes.Length; i++)
    {

        if (nomeDigitado == nomes[i])

        {
            encontrado = true;
            break;
        }

    }
    if (encontrado)
        Console.WriteLine("Nome encontrado com sucesso.");

    else
    {
        Console.WriteLine("Nome não encontrado, tente novamente.");
    }
}   


/* Cria uma lista com nomes fixos.

Pede ao usuário um nome (Console.ReadLine()).

Usa um for para comparar o nome digitado com os nomes da lista.

Se encontrar, mostra "Nome encontrado com sucesso." e para.

Se não encontrar, mostra "Nome não encontrado, tente novamente." e repete tudo com while.

