Console.WriteLine("break e continue");

//-----break-------

for (; ; )
{
    Console.WriteLine("Tecle algo (x sai)");
    var opcao = Console.ReadLine();

    Console.WriteLine(opcao?.ToUpper());

    if (opcao == "x" ||  opcao == "X")
    {
        Console.WriteLine("tchau");
        break;
    }
}

//-----continue------

for(int i = 1; i <= 10; i++)
{
    if (i == 4)
        continue;

    Console.WriteLine(i);

}

//----outro exemplo de break e continue juntos--------

for (int i = 1; i<= 10; i++)
{
    if (i == 5)
        continue;

    if (i == 8)
        break;

    Console.WriteLine(i);
}
