Console.WriteLine("Estrutura DO WHILE");

//do
//{
//    codigo;
//} while (condição); --> roda a expressão até a condição ser false

//obs: a diferença de WHILE e DO-WHILE é que no do-while o código vai ser executado sempre pelo menos uma vez,
//enquanto o while, se for falso, não executa nada.

var i = 1;

do
{
    Console.WriteLine($"i = {i}");
    i++;
    if( i > 7)
    {
        break; //usado para nao cair em um loop infinito
    }
}
while (true);


//----------do-while aninhado----------

int x = 0;
do
{
    int j = 0;
    do
    {
        Console.Write($"({x},{j})");
        j++;
    } while (j < 5);
    x++;
    Console.WriteLine();
}while(x < 5);


Console.ReadLine();