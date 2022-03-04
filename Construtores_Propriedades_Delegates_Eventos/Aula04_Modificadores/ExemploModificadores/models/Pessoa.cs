namespace ExemploModificadores.models
{
    public class Pessoa
    {
        private readonly string nome = "Hunter";
        private readonly string sobrenome;

        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }
        
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public void Apresentar()
        {
           // this.nome = "Teste"; //erro
            System.Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
        }
    }
}