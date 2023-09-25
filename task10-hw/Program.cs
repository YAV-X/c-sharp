// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 --> 5
// 782 --> 8
// 918 --> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


int SecondDigit(int num)
{
    return num / 10 % 10;
}

if (number > 99 && number < 1000)
{
    int secondDigit = SecondDigit(number);
    Console.WriteLine($"{number} --> {secondDigit}");
}
else
        Console.WriteLine($"Неправильный ввод!");
