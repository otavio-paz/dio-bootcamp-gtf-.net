using System.Collections.Generic;

//Dictionary <chave, valor>
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

//percorrendo o dictionary
// foreach (KeyValuePair<string, string> item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

string valorProcurado = "SC";

if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))
{
    System.Console.WriteLine(estadoEncontrado);
}
else
{
    System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
}

// System.Console.WriteLine($"Removendo o valor: {valorProcurado}");

// estados.Remove(valorProcurado);


// foreach (KeyValuePair<string, string> item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// System.Console.WriteLine("Valor original: ");
// System.Console.WriteLine(estados[valorProcurado]); //com base na chave BA, mostrará Bahia

// estados[valorProcurado] = "BA - teste atualização"; //irá atualizar o valor da chave

// System.Console.WriteLine("Valor atualizado: ");
// System.Console.WriteLine(estados[valorProcurado]);
