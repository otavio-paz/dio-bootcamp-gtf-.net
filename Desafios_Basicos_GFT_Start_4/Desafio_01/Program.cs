//RESULTADO - 10/10

using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nota, resto;

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            resto = n;

            //nota 100
            nota = 100;
            resto = CalcularNotas(nota, resto);

            //nota 50
            nota = 50;
            resto = CalcularNotas(nota, resto);

            //nota 20
            nota = 20;
            resto = CalcularNotas(nota, resto);

            //nota 10
            nota = 10;
            resto = CalcularNotas(nota, resto);

            //nota 5
            nota = 5;
            resto = CalcularNotas(nota, resto);

            //nota 2
            nota = 2;
            resto = CalcularNotas(nota, resto);

            //nota 1
            nota = 1;
            resto = CalcularNotas(nota, resto);

        }

        static public int CalcularNotas(int nota, int resto)
        {
            int quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            return resto = resto - quociente * nota;
        }

    }
}

// opção mais repetitiva 

//             int n, nota, quociente, resto;

//             n = int.Parse(Console.ReadLine());
//             Console.WriteLine(n);

//             resto = n;

//             //nota 100
//             nota = 100;
//             quociente = resto / nota;
//             Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
//             resto = resto - quociente*nota;

//             //nota 50
//             nota = 50;
//             quociente = resto / nota;
//             Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
//             resto = resto - quociente*nota;

//             //nota 20
//             nota = 20;
//             quociente = resto / nota;
//             Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
//             resto = resto - quociente*nota;

//             //nota 10
//             nota = 10;
//             quociente = resto / nota;
//             Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
//             resto = resto - quociente*nota;

//             //nota 5
//             nota = 5;
//             quociente = resto / nota;
//             Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
//             resto = resto - quociente*nota;

//             //nota 2
//             nota = 2;
//             quociente = resto / nota;
//             Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
//             resto = resto - quociente*nota;

//             //nota 1
//             nota = 1;
//             quociente = resto / nota;
//             Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
//             resto = resto - quociente*nota;