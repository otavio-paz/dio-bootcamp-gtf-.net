//RESULTADO - 3/3
using System; 
using System.Collections.Generic; 
using System.Linq;

class MinhaClasse {
       static void Main()
        {
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalDeCasosDeTeste; i++)
            {
               Console.WriteLine(string.Join(" ",
               Console.ReadLine().Split(" ").ToList().Distinct().OrderBy(item => item)));
            }
      }
}