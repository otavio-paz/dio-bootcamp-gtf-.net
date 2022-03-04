using ExemploPOO.models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Bob";
            p1.Idade = 45;

            p1.Apresentar();
        }
   }
}