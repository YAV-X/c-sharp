// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент 1, на выходе получим следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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

int[] GetIndexesMinElem(int[,] matrix)
{
    int rowMinIndex = 0;
    int columnMinIndex = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[rowMinIndex, columnMinIndex])         // первое вхождение, <= последнее вхождение
            {
                rowMinIndex = i;
                columnMinIndex = j;
            }
        }
    }
    return new int[] { rowMinIndex, columnMinIndex };
}

int[,] DeleteRowColumnMinElem(int[,] matrix, int row, int column)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    for (int i = 0, m = 0; i < newMatrix.GetLength(0); i++, m++)
    {
        if (i == row) m++;
        for (int j = 0, n = 0; j < newMatrix.GetLength(1); j++, n++)
        {
            if (j == column) n++;
            newMatrix[i, j] = matrix[m, n];
        }
    }
    return newMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}\t");
        }
        Console.WriteLine(" |");
    }
}

int[,] array = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array);
int[] indexesMinElem = GetIndexesMinElem(array);
Console.WriteLine($"row {indexesMinElem[0]}, column {indexesMinElem[1]}, value {array[indexesMinElem[0], indexesMinElem[1]]}");
int[,] newArray = DeleteRowColumnMinElem(array, indexesMinElem[0], indexesMinElem[1]);
PrintMatrix(newArray);
