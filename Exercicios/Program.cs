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

// 4) - Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero recebido via teclado 
//while(true)
//{
//    Console.WriteLine("\nInsira um número natural maior que 0 (digite 0 para sair do loop): \n");
//    int n4 = Convert.ToInt32(Console.ReadLine());
//    if (n4 < 0)
//    {
//        Console.WriteLine("Seu número é menor que 0");
//        break;
//    }
//    else
//    {
//        if (n4 == 0)
//        {
//            break;
//        }
//        for (int i4 = 1; i4 < 11; i4++)
//        {
//            Console.WriteLine($"{n4} x {i4} = {n4 * i4}");
//        }
//    }
//}

// 5) Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de resposta de uma pergunta.
// O usuário pode optar por continuar respondendo a pergunta ou parar de responder. Não utilize a instrução break.
//char a5 = 's';

//while (a5 != 'x')
//{
//    Console.WriteLine("\nQual a instrução para sair de um loop?\na. quit \nb.continue \nc. break \nd.exit \n\nQual a opção correta? (pressione x para sair)");
//    a5 = Convert.ToChar(Console.ReadLine());

//    if (a5 == 'a')
//    {
//        continue;
//    }
//    else if (a5 == 'b')
//    {
//        continue;
//    }
//    else if (a5 == 'c')
//    {
//        Console.WriteLine("------------Resposta correta!----------\n");
//        continue;
//    }
//    else if (a5 == 'd')
//    {
//        continue;
//    }
//    else
//    {
//        if (a5 != 'x')
//        {
//            Console.WriteLine("Por favor insira um termo válido.\n");
//            continue;
//        }
//    }
//}

// 6) Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 maneiras diferentes:
//incrementando 2 em cada passo:
//for (int i6 = 10; i6 < 21; i6+=2)
//{
//    if (i6 != 16)
//    {
//        Console.WriteLine(i6);
//    }
//}
//incrementando 1 em cada passo:
//for (int x6 = 10; x6 < 21;  x6++)
//{
//    if(x6 % 2 == 0 && x6 != 16)
//    {
//        Console.WriteLine(x6);
//    }
//}
//com loop infinito (usando "break" e "continue")
//int a6 = 10;
//while (true)
//{
//    if (a6 != 16)
//    {
//        Console.WriteLine(a6);
//    }
//    a6 += 2;
//    if (a6 > 21)
//    {
//        break;
//    }
//    continue;
//}

// 7) Escreva um programa para exibir o padrão como triângulo de ângulo reto usando asterisco (*). (usando loop aninhado) --> precisei consultar a sugestão de solução
//int i, j, linhas;
//Console.Write("Informe o número de linhas: ");
//linhas = Convert.ToInt32(Console.ReadLine());

//for (i = 1; i <= linhas; i++)
//{
//    for (j = 1; j <= i; j++)
//        Console.Write("*");
//        Console.Write("\n");  
//}

