using static System.Console;
using ExemploGettersSetters.models;

namespace ExemploGettersSetters
{
    class Program
    {
        static void Main(string [] args)
        {
            Data data1 = new Data();
            // data1.SetMonth(20); //usando o método set

            data1.Month = 12; //usando a propriedade

            data1.TellMonth(); //usando o método tell month

        }
    }
}