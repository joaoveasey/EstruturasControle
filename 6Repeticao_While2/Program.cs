Console.WriteLine("Repetição While 2 - Loop");

//usando break com while
while (true)
{
    Console.WriteLine("Insira um número inteiro: (pressione 0 para sair)");
    int numero = Convert.ToInt32(Console.ReadLine());
    if (numero == 0)
    {
        break;
    }

    if (numero % 2 == 0)
        Console.WriteLine($"{numero} é PAR!");
    else
        Console.WriteLine($"{numero} é IMPAR!");
}

//while aninhado
//coordenadas de um plano cartesiano
Console.WriteLine("\n--------Coordenadas de um plano cartesiano");
int x = 0;
while (x < 5)
{
    int y = 0;
    while (y < 5)
    {
        Console.WriteLine($"{x} , {y}");
        y++;
    }
    x++;
    Console.WriteLine();
}