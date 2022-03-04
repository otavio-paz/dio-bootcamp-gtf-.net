namespace ExemploEventos.models
{
    public class Calculadora
    {
        public delegate void DelegateCalculadora();  //Delegate

        public static event DelegateCalculadora EventoCalculadora; //Evento

        public static void Somar(int x, int y)
        {
            if(EventoCalculadora != null) 
            {
                System.Console.WriteLine($"Adição: { x + y}");
                EventoCalculadora(); //se tiver inscrito, vai ser executado
            }
            else
            {
                System.Console.WriteLine("Nenhum inscrito");
            }
        }

        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtração: { x - y}");
        }
    }
}