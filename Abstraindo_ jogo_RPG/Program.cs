using Abstraindo__jogo_RPG.Entities;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Hero principal_hero = new Hero("Terra", 99, "Rune Knight", 9172, 954); //instanciar

        Mage white = new Mage("Heaven", 99, "White Mage", 6666, 999);

        Mage blue = new Mage("Strago", 67, "Blue Mage", 5809, 742);

        WriteLine(principal_hero.ToString());

        WriteLine(principal_hero.Attack); //mesma saida da anterior, pq o metodo puxa o string
        
        WriteLine(white.Attack()); //a resposta que dará é de espada, só que a Heaven nao usa espada
    }
}