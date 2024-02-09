using ExcessoesPersonalizadas;

Conta conta1 = new Conta(1 ,"Maria", 100m);

try
{
    Console.WriteLine(conta1.ToString());
    conta1.Depositar(100);
    conta1.Sacar(300);
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

Console.ReadKey();

public class Conta
{
    public Conta( int numero , string? titular, decimal saldo) 
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }
    public int Numero { get; set; }
    public string? Titular { get; set; }
    public decimal Saldo { get; set; }

    public decimal Depositar(decimal valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depositou: {valor}");
        return Saldo;
    }
    public decimal Sacar(decimal valor)
    {
        if(Saldo< valor)
        {
            throw new SaldoInsuficienteException("Saldo insuficiente!");
        }

        Saldo -= valor;
        Console.WriteLine($"Sacou: {valor}");
        return Saldo;
    }
    public override string ToString()
    {
        return $"Conta: {Numero} : {Titular} - Saldo: {Saldo}";
    }
}