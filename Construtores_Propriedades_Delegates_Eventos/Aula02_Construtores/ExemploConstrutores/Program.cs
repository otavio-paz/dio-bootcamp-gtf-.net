using static System.Console;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string [] args)
        {
           Student p1 = new Student("Otávio", "Paz", "Matemática");
           p1.Introduction();
           
           // Person p1 = new Person(); //usando o construtor vazio
           // Person p2 = new Person("Otávio", "Paz"); //usando o contrutor q pede name e last_name

           // p2.Introduction();

           // Log log = Log.GetInstance();

           // log.LogProperty = "Teste instância";

           // Log log2 = Log.GetInstance();
           // WriteLine(log2.LogProperty);
        }
    }
}