using System;
using ExemploEncap.Models;

namespace ExemploEncap
{
    class Program
    {
        static void Main(string[] args)
        {
            //Valores validos
            Retangulo r = new Retangulo();
            // r.comprimento = 30; vai dar erro, pois é privado
            r.DefinirMedidas(30, 30);
            System.Console.WriteLine($"Área: {r.ObterArea()}");

            //Valores invalidos
            Retangulo r2 = new Retangulo();
            r.DefinirMedidas(-30, 20);
            System.Console.WriteLine($"Área: {r2.ObterArea()}");
        }
    }
}