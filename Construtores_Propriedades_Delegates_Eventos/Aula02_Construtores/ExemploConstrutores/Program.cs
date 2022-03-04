using static System.Console;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string [] args)
        {
            Person p1 = new Person(); //usando o construtor vazio
            Person p2 = new Person("Otávio", "Paz"); //usando o contrutor q pede name e last_name

            p2.Introduction();
        }
    }
}