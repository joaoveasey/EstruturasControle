Console.WriteLine("Estrutura Switch Case: Parte 2");

//-----------executar o mesmo codigo para diferentes valores--------------
Console.WriteLine("Informe o nome do mês: ");
var mes = Console.ReadLine().ToLower(); // ToLower converte para minusculo

switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("este mês tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("este mês tem 28 ou 29 dias");
        break;
    case "abril":
    case "junho":
    case "setembro":
    case "novembro":
        Console.WriteLine("este mês tem 30 dias");
        break;
    default:
        Console.WriteLine("valor desconhecido");
        break;
}

//------------ instruções switch aninhadas --------------

int cargo = 0;
int funcao = 0;
Console.WriteLine("Gerente (1) ou Programador (2)? ");
cargo = Convert.ToInt32(Console.ReadLine());

if (cargo == 2)
{
    Console.WriteLine("Você é Júnior (1) ou Sênior (2)?");
    funcao = Convert.ToInt32(Console.ReadLine());
}

switch (cargo)
{
    case 1:
        Console.WriteLine("\nBem-vindo gerente!");
        break;
    case 2:
        Console.WriteLine("\nBem-vindo programador!");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("\nVocê é Júnior");
                break;
            case 2:
                Console.WriteLine("\nVocê é Sênior");
                break;
            default:
                Console.WriteLine("\nNão consigo te identificar");
                break;
        }
        break;
    default:
        Console.WriteLine("\nNão consigo te identificar");
        break;
}


Console.ReadKey();