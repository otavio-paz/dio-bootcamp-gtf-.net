using static System.Console;

CriarCsv();

WriteLine("\n\n Pressione [enter] para finalizar");
ReadLine();


static void CriarCsv()
{
    var path = Path.Combine(
        Environment.CurrentDirectory,
        "Saida");

        var pessoas = new List<Pessoa>(){
            new Pessoa()
            {
                Nome = "José da Silva",
                Email = "js@gmail.com",
                Telefone = 123456,
                Nascimento = new DateOnly(year: 1970, month: 2, day: 14)
            },

            new Pessoa()
            {
                Nome = "Pedro Lucas",
                Email = "pl@gmail.com",
                Telefone = 456789,
                Nascimento = new DateOnly(year: 2002, month: 04, day: 20)
            },

            new Pessoa()
            {
                Nome = "Maria Antonia",
                Email = "ma@gmail.com",
                Telefone = 123456,
                Nascimento = new DateOnly(year: 1982, month: 12, day: 04)
            },

            new Pessoa()
            {
                Nome = "Carla Daniela",
                Email = "ca@gmail.com",
                Telefone = 789456,
                Nascimento = new DateOnly(year: 2000, month: 08, day: 20)
            },
        };

        var di = new DirectoryInfo(path);
        if(!di.Exists)
        {
            di.Create();
            path = Path.Combine(path, "usuarios.csv");
        }
        using var sw = new StreamWriter(path);
        sw.WriteLine("nome, email, telefone, nascimento");

        foreach (var pessoa in pessoas)
        {
            var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}";
            sw.WriteLine(linha);
        }




}

static void LerCsv()
{
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
}

class Pessoa
{
    public string Nome {get; set; }
    public string Email {get; set; }
    public int Telefone {get; set; }
    public DateOnly Nascimento {get; set; }
}