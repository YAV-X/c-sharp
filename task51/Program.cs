// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int SumDiag(int[,] matrix)
{
    int sum = 0;
    int minSize = matrix.GetLength(0);

    if (minSize > matrix.GetLength(1)) minSize = matrix.GetLength(1);

    for (int i = 0; i < minSize; i++)
    {
        //* for (int j = 0; j < matrix.GetLength(1); j++)
        //* {
        //*     if (i == j) sum += matrix[i, j];
        //* }

        sum += matrix[i, i];
    }
    return sum;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateMatrixRndInt(5, 5, 1, 9);
PrintMatrix(array);
Console.WriteLine();

int sumDiag = SumDiag(array);
Console.WriteLine(sumDiag);