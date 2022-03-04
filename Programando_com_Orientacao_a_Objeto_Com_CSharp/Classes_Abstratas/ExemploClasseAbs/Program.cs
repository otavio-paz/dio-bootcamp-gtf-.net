using static System.Console;
using ExemploClasseAbs.models;

namespace ExemploClasseAbs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conta conta = new Conta(); //erro pois a classe é abstrata
            Corrente c = new Corrente();
            c.Creditar(100);

            c.ExibirSaldo();
            

        }
    }
}