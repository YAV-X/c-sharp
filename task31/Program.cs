// Задача 31: 
// 1. Задайте массив из 12 элементов.
// 2. Заполненный случайными числами из промежутка [-9, 9].
// 3. Найдите сумму отрицательных и положительных элементов массива.
// 4. Вывод результата.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    // Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    // Console.Write("]");
}

int GetSumPositiveElem(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int GetSumNegativeElem(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] GetSumPositiveNegativElem(int[] arr)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPositive += arr[i];
        else sumNegative += arr[i];
    }
    return new int[] { sumPositive, sumNegative };
}

int[] array = CreateArrayRndInt(36, -9, 9);

PrintArray(array);
Console.Write(" --> [");
PrintArray(array);
Console.WriteLine("]");

int[] sumPositiveNegativElem = GetSumPositiveNegativElem(array);
Console.WriteLine($"Сумма положительных элементов --> {sumPositiveNegativElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов --> {sumPositiveNegativElem[1]}");

int getSumNegativeElem = GetSumNegativeElem(array);
int getSumPositiveElem = GetSumPositiveElem(array);
Console.WriteLine($"Сумма положительных элементов --> {getSumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов --> {getSumNegativeElem}");

