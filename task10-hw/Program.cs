// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 --> 5
// 782 --> 8
// 918 --> 1

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите трехзначное число: ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Неправильный ввод");
    return;
}

Console.WriteLine($"Введите число {number}");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра равна {secondRank}");



// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int SecondDigit(int num)
// {
//     return num / 10 % 10;
// }

// if (number > 99 && number < 1000)
// {
//     int secondDigit = SecondDigit(number);
//     Console.WriteLine($"{number} --> {secondDigit}");
// }
// else
//     Console.WriteLine($"Неправильный ввод!");
