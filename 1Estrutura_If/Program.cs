Console.WriteLine("Instrução If");

Console.WriteLine("----Cliente especial? (true/false)");
var resposta = Convert.ToBoolean(Console.ReadLine());

if(resposta)
{
    Console.WriteLine("Desconto de 10%");
}
Console.WriteLine("\nFim do processamento\n");

Console.WriteLine("\n----Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("x maior que y");
}
if (x < y)
{
    Console.WriteLine("x menor que y");
}
if (x == y)
{
    Console.WriteLine("iguais");
}

Console.ReadKey();