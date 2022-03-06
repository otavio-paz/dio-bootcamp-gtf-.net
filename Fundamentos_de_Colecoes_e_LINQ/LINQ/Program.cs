
int[] arrayNumeros = new int[11] {1,4,8,15,5,20,22,0,5,1,12312};

var minimo = arrayNumeros.Min();
var maximo = arrayNumeros.Max();
var medio = arrayNumeros.Average();
var soma = arrayNumeros.Sum();
var arrayUnico = arrayNumeros.Distinct().ToArray();

System.Console.WriteLine($"Mínimo: {minimo}");
System.Console.WriteLine($"Máximo: {maximo}");
System.Console.WriteLine($"Médio: {medio}");
System.Console.WriteLine($"Soma: {soma}");

System.Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
System.Console.WriteLine($"Array original: {string.Join(", ", arrayUnico)}");


// //proximo ao SQL
// var numerosParesQuery = 
//     from num in arrayNumeros
//     where num % 2 == 0 //verifica a paridade
//     orderby num //ordena em ordem crescente
//     select num; //seleciona esse numero

// //mesma coisa do anterior
// var numerosParesMetodo = arrayNumeros.Where(x=> x % 2 == 0).OrderBy(x => x).ToList();

// System.Console.WriteLine("Números pares query: " + string.Join(", ", numerosParesQuery));

// System.Console.WriteLine("Números pares metodo: " + string.Join(", ", numerosParesMetodo));