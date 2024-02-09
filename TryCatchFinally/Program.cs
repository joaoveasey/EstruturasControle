try

{

    Console.WriteLine("Informe o dividendo: \n");

    int dividendo = Convert.ToInt32(Console.ReadLine());



    Console.WriteLine("Informe o divisor: \n");

    int divisor = Convert.ToInt32(Console.ReadLine());



    int resultado = (dividendo / divisor);

    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}");



    Console.ReadKey();

}

catch (FormatException)

{

    Console.WriteLine($"\ninforme um valor inteiro");

}

catch (OverflowException)

{

    Console.WriteLine("\ninforme um valor inteiro entre 1 e 999999");

}

catch (DivideByZeroException)

{

    Console.WriteLine("\nnão existe divisão por zero");

}

catch (Exception ex)

{

    Console.WriteLine(ex.Message);

}

finally

{

    Console.WriteLine("\nPrograma chegou ao fim!");

}