//TESTE 2/2 OKAY - 100%
using static System.Console;

namespace DIO
{
    class Program
    {
        static int Paridade(int numeroDaParidade)
        {
            int resto;
            resto = numeroDaParidade % 2; //se restar 0, é par. caso contrário, é impar.

            if (resto == 0)
                return 0; //retorna 0 se for par
            else
                return 1; //retorna 1 se for impar
        }

        static int Soma5Consecutivos(int valorParidade, int numeroInicial)   
        {
            int soma;
            if(valorParidade == 0) //a sequencia forma uma pa
            {
                soma = (((numeroInicial + (numeroInicial + 4*2))*5)/2); //soma de uma sequencia em pa
                return soma; 
            }
            else
            {
                soma = (((numeroInicial + 1 + (numeroInicial + 1 + 4*2))*5)/2); //soma de uma sequencia em pa, sendo o proximo numero
                return soma;
            }
            
        }
        
        static void Main(string[] args)
        {
            int x = 1;
            while (x != 0)
            {
                x = int.Parse(ReadLine());
                if (x == 0)
                    break;
                int valorParidade;
                valorParidade = Paridade(x);
                int SomaDos5Consecutivos = Soma5Consecutivos(valorParidade, x);
                WriteLine(SomaDos5Consecutivos);               
            }
        }
    }
}
