Console.WriteLine("Estrutura If-Else-If");

Console.WriteLine("Informe a nota do aluno: ");
var nota = Convert.ToInt32(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("Reprovado");
}
else if (nota >= 5 && nota < 6) 
{
    Console.WriteLine("Recuperação");
}
else if (nota >= 6 && nota < 9)
{
    Console.WriteLine("Aluno aprovado");
}
else if (nota >= 9 && nota < 10)
{
    Console.WriteLine("Aprovado com distinção!");
}
else
{
    Console.WriteLine("Valor desconhecido");
}


//--------- outro exemplo ----------
int cargo = 0;
int funcao = 0;
Console.WriteLine("Gerente (1) ou Programador (2)? ");
cargo = Convert.ToInt32(Console.ReadLine());

if (cargo == 1)
{
    Console.WriteLine("Você é o Gerente");
}
if (cargo == 2)
{
    Console.WriteLine("Você é Júnior (1) ou Sênior (2)?");
    funcao = Convert.ToInt32(Console.ReadLine());
    if (funcao == 1)
    {
        Console.WriteLine("Você é um Programador Júnior.");
    }
    else if (funcao == 2)
    {
        Console.WriteLine("Você é um Programador Sênior.");
    }
    else
    {
        Console.WriteLine("Valor desconhecido");
    }
}
else if (cargo != 1 && cargo != 2)
{
    Console.WriteLine("Valor desconhecido");
}

Console.ReadKey();