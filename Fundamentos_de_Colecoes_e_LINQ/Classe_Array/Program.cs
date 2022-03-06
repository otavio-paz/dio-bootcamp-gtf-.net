using System;
using Classe_Array.helper;

OperacoesArray op = new OperacoesArray();

int[] array = new int[5] { 6, 3, 8, 1, 9 };

System.Console.WriteLine("Array original: ");
op.ImprimirArray(array);

op.Ordenar(ref array); //usando a classe array

System.Console.WriteLine("Array ordenado:");
op.ImprimirArray(array);