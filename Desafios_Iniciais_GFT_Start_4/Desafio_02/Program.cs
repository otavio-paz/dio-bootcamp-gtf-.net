// 0K 4/4 - 100%
using static System.Console;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());

            int inicio = 1;

            for (int i = 1; i <= n; i++)
            {
                WriteLine($"{i} {i*i} {i*i*i}");               
            }
        }
    }
}