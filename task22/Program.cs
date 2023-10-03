// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 --> 1, 4, 9, 16,
// 2 --> 1,4

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void NumberSquaredTable(int number)
{
    int i = 1;
    while(i <= number)
    {
        Console.WriteLine($"| {i} | {i * i} |");
        i++;
    }
}

int N = Prompt("Введите число: ");
NumberSquaredTable(N);
