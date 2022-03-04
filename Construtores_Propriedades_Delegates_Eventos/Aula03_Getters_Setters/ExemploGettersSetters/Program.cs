using static System.Console;
using ExemploGettersSetters.models;

namespace ExemploGettersSetters
{
    class Program
    {
        static void Main(string [] args)
        {
            Data data1 = new Data();
            data1.SetMonth(20);

            
            data1.TellMonth();

        }
    }
}