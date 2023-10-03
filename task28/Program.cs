// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. 
// 4 --> 24
// 5 --> 120

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Factorial(int num)
{
    int factoial = 1;
    for (int i = 1; i <= num; i++)
    {
        checked         // проверяет переполнение типа
        {
            factoial *= i;
        }
    }
    return factoial;
}

int N = Prompt("Введите число: ");

Console.Write($"{N} --> {Factorial(N)}");
