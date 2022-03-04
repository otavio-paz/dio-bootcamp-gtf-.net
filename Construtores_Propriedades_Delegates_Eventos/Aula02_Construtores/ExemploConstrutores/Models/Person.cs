namespace ExemploConstrutores.Models
{
    public class Person
    {
        private string name;
        private string last_name;

        public Person()
        {
            name = string.Empty;
            last_name = string.Empty;
        }

        public Person(string name, string last_name)
        {
            this.name = name;
            this.last_name = last_name;
            System.Console.WriteLine("Construtor classe pessoa!");
        }

        public void Introduction()
        {
            System.Console.WriteLine($"Hello, my name is: {name} {last_name} !");
        }
    }
}