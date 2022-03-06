using Ordenando_Bubble_Sort.helper;

OperacoesArray op = new OperacoesArray();
int[] array = new int[5]{6, 3, 8, 1, 9};

System.Console.WriteLine("Array original: ");
op.ImprimirArray(array);

op.OrdenarBubblesort(array);

System.Console.WriteLine("Array ordenado:");
op.ImprimirArray(array);