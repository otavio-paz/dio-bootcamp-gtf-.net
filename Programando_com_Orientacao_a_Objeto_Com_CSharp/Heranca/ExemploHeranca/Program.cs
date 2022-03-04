using ExemploHeranca.models;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno();
            p1.Nome = "Finch";
            p1.Idade = 25;
            
            p1.Apresentar();

            Professor p2 = new Professor();
            p2.Nome = "Carlos";
            p2.Idade = 43;

            p2.Apresentar();
        }
   }
}