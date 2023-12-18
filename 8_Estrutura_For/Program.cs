Console.WriteLine("Estrutura do loop For");

//for (inicializador; condição; iterador)
//{
//    instruções;
//}

int resultado, numero;

Console.WriteLine("Informe o número inteiro: ");
numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}