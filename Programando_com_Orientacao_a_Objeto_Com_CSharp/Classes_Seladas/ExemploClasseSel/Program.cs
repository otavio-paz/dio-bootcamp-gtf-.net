using static System.Console;
using ExemploClasseSel.models;

namespace ExemploClasseSel 
{
    class Program
    {
        static void Main(string[] args)
        {
            Computador comp = new Computador();
            System.Console.WriteLine(comp.ToString());
        }
    }
}