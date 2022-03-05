using static System.Console;

var path = Path.Combine(
    Environment.CurrentDirectory, "Entrada", "usuarios-exportacao.csv");

if (File.Exists(path)) //verificar se o arquivo existe
{
    using var sr = new StreamReader(path);
    //leitura da primeira linha
    var cabecalho = sr.ReadLine()?.Split(','); //em caso de aviso de null, colocar o ?, pra ele ignorar

    while (true)
    {
        var registro = sr.ReadLine()?.Split(','); //cada linha

        if (registro == null)
            break;

        if (cabecalho.Length != registro.Length) //se o arquivo tiver uma virgula indesejada
        {
            WriteLine("Arquivo fora do padrão");
            break;
        }

        for (int i = 0; i < registro.Length; i++)
        {
            WriteLine($"{cabecalho?[i]}:{registro[i]}");
        }

        WriteLine("------------");
    }

}

else
{
    WriteLine($"O arquivo {path} não existe");
}

WriteLine("\n\n Pressione [enter] para finalizar");
ReadLine();