namespace ExemploClasseAbs.models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            base.saldo = valor; //base diz que pertence a classe pai, o salto vem de Conta
        }
    }
}