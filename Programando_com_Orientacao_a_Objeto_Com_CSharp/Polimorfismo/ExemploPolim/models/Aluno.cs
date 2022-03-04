namespace ExemploPolim.models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos. Sou aluno e tenho nota {Nota}!");
        }
    }
}