string[] times = new string[4]; // Declara um array de string com 4 "espaços"
string campeao = @"
 
░█████╗░░█████╗░███╗░░░███╗██████╗░███████╗░█████╗░░█████╗░  
██╔══██╗██╔══██╗████╗░████║██╔══██╗██╔════╝██╔══██╗██╔══██╗  
██║░░╚═╝███████║██╔████╔██║██████╔╝█████╗░░███████║██║░░██║  
██║░░██╗██╔══██║██║╚██╔╝██║██╔═══╝░██╔══╝░░██╔══██║██║░░██║  
╚█████╔╝██║░░██║██║░╚═╝░██║██║░░░░░███████╗██║░░██║╚█████╔╝  
░╚════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░░░░╚══════╝╚═╝░░╚═╝░╚════╝░  
 
 ";
times[0] = "Fluminense"; // Atribuindo o valor "Fluminense" à posição 0 do array times
times[1] = "Paris-Saint German";
times[2] = "Real Madrid";
times[3] = "Chelsea";

Console.WriteLine("Copa do Mundo de Clubes da FIFA 🏆");
Console.WriteLine("===================================");
Console.WriteLine("Semifinais");
Console.WriteLine("===================================");
Console.WriteLine(times[0] + " 0 x 2 " + times[3] + " | " + times[1] + " 4 x 0 " + times[2]);
Console.WriteLine(times[1] + " e " + times[3] + " Classificados ");
Console.WriteLine("===================================");
Console.WriteLine("Final");
Console.WriteLine("===================================");
Console.WriteLine(times[1] + " 0 x 3 " + times[3]);
Console.WriteLine(times[3] + campeao);