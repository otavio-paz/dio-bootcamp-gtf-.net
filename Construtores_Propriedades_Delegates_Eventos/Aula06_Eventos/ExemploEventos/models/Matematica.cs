namespace ExemploEventos.models
{
    public class Matematica
    {
        public int X {get; set; }
        public int Y {get; set; }

        public Matematica(int x, int y)
        {
            X = x;
            Y = y;

            Calculadora.EventoCalculadora += EventHandler; //está inscrevendo Matematica no evento calculadora
            //quando acontecer algo com o evento, vai executar o metodo
        }

        public void Somar()
        {
            Calculadora.Somar(X, Y);
        }

        public void EventHandler() //metodo que seja executado apos o termino do evento
        {
            System.Console.WriteLine("Método executado!");
        }
    }
}