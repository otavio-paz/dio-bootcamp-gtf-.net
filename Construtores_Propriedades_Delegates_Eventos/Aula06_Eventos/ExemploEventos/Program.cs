using static System.Console;
using ExemploEventos.models;

namespace ExemploDelegates
{
    class Program
    {
        public delegate void Operacao(int x, int y); 
        
        static void Main(string[] args)
        {
                
                Matematica m = new Matematica(10, 20);
                m.Somar();
                
        }
    }
}