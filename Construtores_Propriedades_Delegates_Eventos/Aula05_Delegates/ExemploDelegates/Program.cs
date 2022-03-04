using static System.Console;
using ExemploDelegates.models;

namespace ExemploDelegates
{
    class Program
    {
        public delegate void Operacao(int x, int y); //declaracao do delegate com os parametros
        //int x e int y são a assinatura, precisam condizem com o delegate na classe
        static void Main(string[] args)
        {
                Operacao op = new Operacao(Calculadora.Somar); //passar o metodo somar pra delegate
                op += Calculadora.Subtrair; //+= significa que estamos adicionando mais um metodo, sem perder a referencia do metodo anterior

                //Operacao op2 = Calculadora.Somar; //outra forma de passar o metodo para o delegate

                op.Invoke(10, 2); //invocar o delegate - primeira maneira
                //op(10, 2); //chamar o delegate - segunda forma
        }
    }
}
