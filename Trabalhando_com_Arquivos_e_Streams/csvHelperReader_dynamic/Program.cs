using static System.Console;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;

var path = Path.Combine(Environment.CurrentDirectory,
"Entrada",
"Produtos.csv");

var fi = new FileInfo(path);
if(!fi.Exists)
    throw new FileNotFoundException($"O arquivo {path} não existe.");

using var sr = new StreamReader(fi.FullName);
var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
using var csvReader = new CsvReader(sr, csvConfig); //implementa IDisposable, logo, using

var registros = csvReader.GetRecords<dynamic>(); //GetRecords vai ler as linhas do arquivo

foreach (var registro in registros)
{
    WriteLine($"Nome: {registro.Produto}");
    WriteLine($"Marca: {registro.Marca}");
    WriteLine($"Preço: {registro.Preco}");
    WriteLine("=-=-=-=-=-=-=-=-=");
}

