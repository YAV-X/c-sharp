// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Объявления массива
//
//* int[] array = new int[8];       // массив заполненный нулями
//* int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
//* int[] array = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };
//* int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
//* var array = new int[];          // неявная типизация
//

// int[] array = new int[8];

// array[0] = 5;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i;
//     Console.Write(array[i] + " ");
// }

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] arr = CreateArray(8);
PrintArray(arr);