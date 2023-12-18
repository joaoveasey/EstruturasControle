Console.WriteLine("Estrutura If-Else");

Console.WriteLine("Escreva a nota do aluno: \t");
int nota = Convert.ToInt32(Console.ReadLine());

if(nota > 5)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado\n");
}

Console.WriteLine("\nEscreva o valor de x \t");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escreva o valor de y \t");
int y = Convert.ToInt32(Console.ReadLine());

//if-else aninhado --> não recomendado
if (x > y)
{
    Console.WriteLine("x maior que y");
} 
else
{
    if (x < y)
    {
        Console.WriteLine("x menor que y");
    }
    else
    {
        Console.WriteLine("x = y");
    }
}


Console.ReadKey();