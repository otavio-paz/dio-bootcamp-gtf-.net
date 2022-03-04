namespace ExemploConstrutores.Models
{
    public class Student : Person
    {
        public Student(string name, string last_name, string subject) : base(name, last_name)
        {
            System.Console.WriteLine("Construtor classe aluno!");
        }
    }
}