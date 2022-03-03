//RESULTADO 8/8 - 100%
using static System.Console;

public class Problem {
    public static void Main() {

        int mes = int.Parse(ReadLine());

        switch (mes) {
            case 1:
                WriteLine("January");
                break;
            case 2:
                WriteLine("February");
                break;
            case 3:
                WriteLine("March");
                break;
            case 4:
                WriteLine("April");
                break;
            case 5:
                WriteLine("May");
                break;
            case 6:
                WriteLine("June");
                break;
            case 7:
                WriteLine("July");
                break;
            case 8:
                WriteLine("August");
                break;
            case 9:
                WriteLine("September");
                break;
            case 10:
                WriteLine("October");
                break;
            case 11:
                WriteLine("November");
                break;
            case 12:
                WriteLine("December");
                break;

            default:
                WriteLine("Digite um número válido de 1 a 12");
                break;
        }
    }
}

