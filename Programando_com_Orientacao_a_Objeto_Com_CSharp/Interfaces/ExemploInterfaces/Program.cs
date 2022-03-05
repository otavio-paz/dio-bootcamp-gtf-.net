using System;
using ExemploInterfaces.models;
using ExemploInterfaces.interfaces;

namespace ExemploInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadora calc = new Calculadora(); //é possivel
            //ICalculadora calc = new ICalculadora(); // nao da para instanciar interface
            System.Console.WriteLine(calc.Somar(10, 20));
        }
    }
}