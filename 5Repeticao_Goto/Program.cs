Console.WriteLine("Estrutura de repetição com goto/label\n");

int i = 1;

repetir: //nome/criação da label

Console.WriteLine($"i = {i}"); //código
i++;

if (i <= 10) //condição
    goto repetir; //retorna caso a condição nao seja satisfeita