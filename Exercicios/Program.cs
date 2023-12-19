// 1) Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior
//using System.Threading.Channels;

//Console.WriteLine("Encontre o maior dentre 3 números:\n");

//Console.Write("Primeiro número: ");
//int a1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Segundo número: ");
//int b1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Terceiro número: ");
//int c1 = Convert.ToInt32(Console.ReadLine());

//if (a1 > b1)
//{
//    if (a1 > c1)
//    {
//        Console.WriteLine($"Primeiro Número : {a1} é o maior");
//    }
//}
//else if (b1 > c1)
//{
//    if (b1 > a1)
//    {
//        Console.WriteLine($"Segundo Número : {b1} é o maior");
//    }
//}
//else
//{
//    Console.WriteLine($"Terceiro Número : {c1} é o maior");
//}

// 2) - Escreva um programa para calcular a raiz da equação quadrática : ax² + bx + c = 0

//Console.WriteLine("Cálculo da equação do segundo grau (ax^2+bx+c) :");

//Console.WriteLine("Informe o valor de a :");
//int a2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Informe o valor de b :");
//int b2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Informe o valor de c :");
//int c2 = Convert.ToInt32(Console.ReadLine());

//int delta = (b2 * b2) - (4 * a2 * c2);
//double x1 = (-b2 + Math.Sqrt(delta)) / (2 * a2);
//double x2 = (-b2 - Math.Sqrt(delta)) / (2 * a2);


//if (delta < 0)
//{
//    Console.WriteLine("As raízes são imaginárias;\n Sem solução para os números reais.");
//}
//else if (delta > 0)
//{
//    Console.WriteLine($"Ambas as raízes são reais e diferentes\nPrimeira raíz x1 = {x1}\nSegunda raíz x2 = {x2}");
//}

// 3) Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop while, do -while e for.
//com while
//int i3 = 0;
//while (i3 < 10)
//{
//    Console.WriteLine(i3);
//    i3++;
//}

//com do while
//int a3 = 0;
//do
//{
//    Console.WriteLine(a3);
//    a3++;
//}
//while (a3 < 10);

//com for
//for(int x3 = 0; x3 < 10; x3++)
//{
//    Console.WriteLine(x3);
//}
