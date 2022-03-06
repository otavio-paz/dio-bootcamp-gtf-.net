int a = 100;
int b = 0;

try
{
    var resultado = Dividir(a, b);
    System.Console.WriteLine($"O valor da divisão de {a} por {b} é igual a {resultado}");
}
catch (DivideByZeroException ex) when (a < 0) //mais especifica
{
    System.Console.WriteLine(ex.Message);
}
catch (Exception ex) //mais generalizada
{
    System.Console.WriteLine(ex.Message);
}
finally
{
    System.Console.WriteLine("Finalmente a divisão foi finalizada");
}

static double Dividir(int x, int y)
{
    if (y == 0)
        throw new ArithmeticException();
    return x / y;
}