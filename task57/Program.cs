// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// --------------------
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}\t");
        }
        Console.WriteLine("  |");
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];           // общее кол-во элементов массива
    int k = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void PrintFrequencyDictionary(int[] array)
{
    int count = 1;
    int currentNum = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == currentNum) count++;
        else
        {
            Console.WriteLine($"{currentNum,3} встречается {count,3} раза");
            currentNum = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{currentNum,3} встречается {count,3} раза");
}

int[,] newMatrix = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(newMatrix);
int[] newArray = MatrixToArray(newMatrix);
PrintArray(newArray);
Array.Sort(newArray);
PrintArray(newArray);
Console.WriteLine();
PrintFrequencyDictionary(newArray);
