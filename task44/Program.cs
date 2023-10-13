// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 --> 0 1 1 2 3
// Если N = 3 --> 0 1 1
// Если N = 7 --> 0 1 1 2 3 5 8

int[] FiboArray(int num)
{
    int[] fibonacci = new int[num];
    fibonacci[1] = 1;
    for (int i = 2; i < num; i++)
    {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
    }
    return fibonacci;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

Console.Write("Введите число цифр Фибоначчи: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 2)
{
    Console.WriteLine("Число должно быть больше 1");
    return;
}

int[] result = FiboArray(number);
Console.Write($"Если N = {number} --> ");
PrintArray(result);
