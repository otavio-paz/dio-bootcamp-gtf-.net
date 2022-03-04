namespace ExemploClasseSel.models
{
    public class Diretora : Professor
    {
        public override void Apresentar()
        {
            System.Console.WriteLine($"Diretor.");
        }
    }
}