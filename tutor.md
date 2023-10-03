// Объявления массива
//
// int[] array = new int[8];       // массив заполненный нулями
// int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
// int[] array = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };
// int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
// var array = new int[];          // неявная типизация
//
int[] array = new int[8];

array[0] = 5;

for (int i = 0; i < array.Length; i++)
{
    array[i] = i;
    Console.Write(array[i] + " ");
}