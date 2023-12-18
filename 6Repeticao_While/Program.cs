Console.WriteLine("Repetição While - Loop");

//while (condicao) --> boolean
//{
//    codigo;
//}

int i = 0;
while (i < 10)
{
    Console.WriteLine(i);
    i++;
}

//------ outro exemplo ----------

Console.WriteLine("Insira um número: ");
var a = Convert.ToInt32(Console.ReadLine());
int m = 1;
if (a > 0)
{
    while (m < 11)
    {
        Console.WriteLine($"{a} x {m} = {a * m}");
        m++;
    }
}
else
{
    Console.WriteLine("Número deve ser maior que zero");
}