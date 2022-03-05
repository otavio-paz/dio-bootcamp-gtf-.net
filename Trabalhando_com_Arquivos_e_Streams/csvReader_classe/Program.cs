using static System.Console;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;
using csvReader_classe.Model;

LerCsvComClasse();

WriteLine("Digite [enter] para fianlizar...");
ReadLine();

static void LerCsvComClasse()
{
    var path = Path.Combine(Environment.CurrentDirectory,
    "Entrada",
    "novos-usuarios.csv");

    var fi = new FileInfo(path);
    if (!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe.");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig); //implementa IDisposable, logo, using

    var registros = csvReader.GetRecords<Usuario>(); //GetRecords vai ler as linhas do arquivo

    foreach (var registro in registros)
    {
        WriteLine($"Nome: {registro.Nome}");
        WriteLine($"Email: {registro.Email}");
        WriteLine($"Telefone: {registro.Telefone}");
        WriteLine("=-=-=-=-=-=-=-=-=");
    }


}