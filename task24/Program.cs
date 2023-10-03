// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 --> 28
// 4 --> 10
// 8 --> 36

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void SumOfNumbers(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        checked     // проверяет переполнение типа
        {
            sum += i;
        }
    }
    Console.WriteLine($"{num} --> {sum}");
}

int N = Prompt("Введите число N: ");
SumOfNumbers(N);