using static System.Console;

CriarMatrizes();
static void CriarMatrizes()
{
    //int[,] matriz1 = new int[4, 2];
    //declaraçao unica
    //matriz1[0, 0] = 5;


    int[,] matriz2 = new int[4, 2]
    {// 0   1  colunas
                {8, 8},
                {10, 20},
                {50, 100},
                {90, 200}
    };

    for (int i = 0; i < matriz2.GetLength(0); i++) //pegara as linhas
    {
        for (int j = 0; j < matriz2.GetLength(1); j++) //pegara as colunas
        {
            System.Console.WriteLine(matriz2[i, j]);
        }
    }

    ReadLine();

}

static void CriarArray()
{
    int[] arrayInteiros = new int[3];

    arrayInteiros[0] = 10;
    arrayInteiros[1] = 20;
    arrayInteiros[2] = 30;

    //percorrer array linearmente
    for (int i = 0; i < arrayInteiros.Length; i++)
    {
        System.Console.WriteLine(arrayInteiros[i]);
    }

    //percorrer array linearmente de outra forma
    foreach (var item in arrayInteiros) //trabalha com o proprio valor da lista que ele analisa
    {
        System.Console.WriteLine(item);
    }

}

