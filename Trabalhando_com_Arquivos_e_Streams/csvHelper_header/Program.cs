using static System.Console;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;
using csvHelper_header.Model;

LerCsvComOutroDelimitador();

WriteLine("Digite [enter] para fianlizar...");
ReadLine();

static void LerCsvComOutroDelimitador()
{
    var path = Path.Combine(Environment.CurrentDirectory,
    "Entrada",
    "Livros-preco-com-virgula.csv");

    var fi = new FileInfo(path);
    if (!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe.");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";"
    };

    using var csvReader = new CsvReader(sr, csvConfig); //implementa IDisposable, logo, using

    var registros = csvReader.GetRecords<Livro>().ToList(); //GetRecords vai ler as linhas do arquivo

    foreach (var registro in registros)
    {
        WriteLine($"Título: {registro.Titulo}");
        WriteLine($"Preço: {registro.Preco}");
        WriteLine($"Autor(a): {registro.Autor}");
        WriteLine($"Data de Lançamento: {registro.Lancamento}");
        WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    }
}
