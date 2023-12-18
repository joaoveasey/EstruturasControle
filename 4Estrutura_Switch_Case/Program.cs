Console.WriteLine("Estrutura Switch Case");

//switch (variavel)
//{
//    case valor1:
//        codigo1
//        break;
//    case valor2
//        codigo2
//        break;
//    default:
//        codigo3
//        break;
//}

Console.WriteLine("Valor da compra R$600,00");
Console.Write("Informe o número de parcelas (1 a 3)");
var nDeParcelas = Convert.ToInt32(Console.ReadLine());

switch (nDeParcelas)
{
    case 1:
        Console.WriteLine($"\n Prestação = 1 x de R${600 / nDeParcelas}.");
        break;
    case 2:
        Console.WriteLine($"\n Prestação = 2 x de R${600 / nDeParcelas}.");
        break;
    case 3:
        Console.WriteLine($"\n Prestação = 3 x de R${600 / nDeParcelas}.");
        break;
    default:
        Console.WriteLine("Não foi possível concluir esta ação.");
        break;
}

Console.WriteLine("Fim do processamento");

//-----avaliando o valor de uma expressão : Par ou ímpar -------

Console.WriteLine("Insira um número: ");
int a = Convert.ToInt32(Console.ReadLine());

switch (a % 2)
{
    case 0:
        Console.WriteLine($"O número {a} é par");
        break;
    case 1:
        Console.WriteLine($"O número {a} é ímpar");
        break;
}

Console.ReadKey();

