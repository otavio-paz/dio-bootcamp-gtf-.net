using System.Collections.Generic;

Stack<string> pilhaLivros = new Stack<string>();

pilhaLivros.Push(".NET"); //Push adiciona 
pilhaLivros.Push("O Homem de Giz");
pilhaLivros.Push("Jantar Secreto");

System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count()}");
while (pilhaLivros.Count > 0)
{
    System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
    System.Console.WriteLine($"{pilhaLivros.Pop()} foi lido");
}

System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count()}");





static void Fila()
{
    Queue<string> fila = new Queue<string>();
    //fila. mostrará todos os metodos que se pode fazer da classe Queue
    fila.Enqueue("Leonardo");
    fila.Enqueue("Eduardo");
    fila.Enqueue("André");

    System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
    while (fila.Count > 0)
    {
        System.Console.WriteLine($"Vez de: {fila.Peek()}");
        System.Console.WriteLine($"{fila.Dequeue()} atendido");
    }

    System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
}
