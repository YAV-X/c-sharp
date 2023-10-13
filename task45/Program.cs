// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] ArrayCopy(int[] arr)
{
    int[] resultArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        resultArray[i] = arr[i];
    }
    return resultArray;
}

int[] array = CreateArrayRndInt(5, 1, 10);
PrintArray(array);
int[] arrayCopy = ArrayCopy(array);
array[0] = 100;
PrintArray(array);

int[] linkArray = array;
PrintArray(linkArray);
array[0] = -100;
PrintArray(linkArray);
