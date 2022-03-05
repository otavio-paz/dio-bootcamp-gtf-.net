using System.Text;

var sb = new StringBuilder(); //para o uso do string Reader, precisa do StringBuilder
sb.AppendLine("Caracteres na primeira linha para ler");
sb.AppendLine("e a segunda linha");
sb.AppendLine("e o fim");

using var sr = new StringReader(sb.ToString()); //StringReader implementa IDisposable, logo, using

//var texto = sr.ReadToEnd(); //leitura de todo um texto, cuidado se for um texto grande

var buffer = new char[10];
var tamanho = 0;

do
{
    buffer = new char[10]; //limpando o buffer
    tamanho = sr.Read(buffer);
    Console.WriteLine(string.Join("",buffer));
}
while (tamanho >= buffer.Length);

//Outra forma, mais sucinta
/*
do
{
    Console.WriteLine(sr.ReadLine());
} while(sr.Peek() >= 0);
*/

Console.WriteLine("Digite [enter] para finalizar");
Console.ReadLine();
