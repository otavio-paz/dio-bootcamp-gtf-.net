namespace ExemploPolim.models
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }
    

        public override void Apresentar()
        {
            System.Console.WriteLine($"Saudações, meu nome é {Nome} e tenho {Idade} anos. Sou professor e meu salário é de R$ {Salario}.");
        }
    }
}