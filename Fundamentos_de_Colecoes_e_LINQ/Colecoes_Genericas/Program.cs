using System.Collections.Generic;
using Colecoes_Genericas.helper;

OperacoesLista opLista = new OperacoesLista(); //instanciando classe
List<string> estados = new List<string>{"SP", "MG", "BA"}; //declaraçao da lista -> nao precisa explicitar a capacidade
string[] estadosArray = new string[2]{"SC", "RS"};

System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

opLista.ImprimirListaString(estados);

estados.Insert(1, "RJ"); //RJ passa para o indice 1 e o restante vai pra frente do indice

opLista.ImprimirListaString(estados);



//estados.AddRange(estadosArray);