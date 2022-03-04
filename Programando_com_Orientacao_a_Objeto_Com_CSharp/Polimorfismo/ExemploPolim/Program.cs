using ExemploPolim.models;

namespace ExemploPolim
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno();
            p1.Nome = "Finch";
            p1.Idade = 25;
            p1.Documento = "123456";
            p1.Nota = 10;
            p1.Apresentar();

            Professor p2 = new Professor();
            p2.Nome = "Carlos";
            p2.Idade = 43;
            p2.Documento = "54321";
            p2.Salario = 10405;
            p2.Apresentar();

            System.Console.WriteLine("==========");

            Calculadora calc = new Calculadora();
            System.Console.WriteLine($"Resultado da primeira soma: {calc.Somar(10, 20, 30)}");
        }
   }
}