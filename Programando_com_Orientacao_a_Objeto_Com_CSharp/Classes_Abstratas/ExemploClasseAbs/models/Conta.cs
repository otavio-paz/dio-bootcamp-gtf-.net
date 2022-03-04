namespace ExemploClasseAbs.models
{
    public abstract class Conta
    {
        protected double saldo; //somente a propria classe e filhas

        //todo metodo abstrato precisa ser sobrescrito se for herdar
        public abstract void Creditar(double valor); //é abstrato, e nao tem implementaçao, nem da para adicionar algo

        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Seu saldo é: {saldo}");
        }       
    
    }
}