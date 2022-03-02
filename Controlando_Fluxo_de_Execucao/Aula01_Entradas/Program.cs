using System;

namespace Aula01_Entradas
{
    class Program
    {
        static void Main (string[] args)
        {
            int valor1;
            int valor2;
            
            Console.WriteLine("Digite o primeiro valor: ");
            //O ReadLine retorna um string, então precisa do int.Parse para converter para inteiro
            valor1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine($"O primeiro valor é: {valor1} ");


            Console.WriteLine("Digite o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"O segundo número é: {valor2}");

            var soma = valor1 + valor2;

            Console.WriteLine($"A soma dos dois valores é: {soma}");
        }
    }
}