// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 --> 3
// 78 --> 2
// 89126 --> 5

int NumberOfDigit(int number)
{
    int count = 1;
    while(number > 10)
    {
        number /= 10;
        count++;
    }
    return count;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int numOfDigit = NumberOfDigit(num);
Console.WriteLine($"{num} --> {numOfDigit}");