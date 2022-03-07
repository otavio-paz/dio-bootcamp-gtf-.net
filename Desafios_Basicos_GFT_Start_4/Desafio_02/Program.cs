//RESULTADO 3/3

using System;
using System.Globalization;

class minhaClasse
{

    public static bool VerificarTriangulo(double a, double b, double c)
    {
        double b_menos_c = Math.Abs(b - c); // | b - c | < a < b + c
        double a_menos_c = Math.Abs(a - c); // | a - c | < b < a + c
        double a_menos_b = Math.Abs(a - b); // | a - b | < c < a + b


        if (b_menos_c < a && a < b + c && a_menos_c < a && a < b + c && a_menos_b < a && a < b + c)
            return true; //é um triangulo
        else
            return false; //não é um triangulo
    }

    public static void CalcularPerimetroTriangulo(double a, double b, double c)
    {
        double perimetro = a + b + c;

        System.Console.WriteLine($"Perimetro = {perimetro.ToString("N1")}");
    }

    public static void CalcularAreaTrapezio(double a, double b, double c)
    {
        double area = ((a + b) * c) / 2;
        System.Console.WriteLine($"Area = {area.ToString("N1")}");
    }
    static void Main(string[] args)
    {

        double a, b, c;
        string[] valor = Console.ReadLine().Split();
        a = Convert.ToDouble(valor[0], CultureInfo.InvariantCulture);
        b = Convert.ToDouble(valor[1], CultureInfo.InvariantCulture);
        c = Convert.ToDouble(valor[2], CultureInfo.InvariantCulture);

        //condição de existencia de triangulo
        bool condTriangulo = VerificarTriangulo(a, b, c);
        if (condTriangulo)
            CalcularPerimetroTriangulo(a, b, c);
        else
            CalcularAreaTrapezio(a, b, c);

    }

}