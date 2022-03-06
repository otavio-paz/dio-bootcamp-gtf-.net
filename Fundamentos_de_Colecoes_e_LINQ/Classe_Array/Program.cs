using System;
using Classe_Array.helper;

OperacoesArray op = new OperacoesArray();

int[] array = new int[5] { 6, 3, 8, 1, 9 };
string[] arrayString = op.ConverterParaArrayString(array);






//int[] arrayCopia = new int[10];

//int valorProcurado = 9;

// System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

// op.RedimensionarArray(ref array, array.Length * 2);

// System.Console.WriteLine($"Capacidade atual do array após redimensionamento: {array.Length}");

// int indice = op.ObterIndice(array, valorProcurado);

// if (indice > -1)
//     System.Console.WriteLine($"O indice do elemento {valorProcurado} é {indice}");
// else
//     System.Console.WriteLine($"Valor não existente no array");

// int valorAchado = op.ObterValor(array, valorProcurado);

// if (valorAchado > 0) //quando ele nao acha, retorna 0
//     System.Console.WriteLine("Encontrei o valor");
// else
//     System.Console.WriteLine("Não encontrei o valor");


// bool TodosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

// if (TodosMaiorQue)
//     System.Console.WriteLine($"Todos os valores são maior que {valorProcurado}");
// else
//     System.Console.WriteLine($"Existe valores que não são maiores do que {valorProcurado}");


// bool existe = op.Existe(array, valorProcurado);

// if (existe)
//     System.Console.WriteLine($"Encontrei o valor {valorProcurado}");
// else
//     System.Console.WriteLine($"Não enconrei o valor {valorProcurado}");


// System.Console.WriteLine("Array antes da copia:");
// op.ImprimirArray(arrayCopia);

// op.Copiar(ref array, ref arrayCopia);
// System.Console.WriteLine("Array após a copia:");
// op.ImprimirArray(arrayCopia);