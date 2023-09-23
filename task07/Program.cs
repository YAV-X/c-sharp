// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// using Internal;

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number <= 999)
{
    Console.Write($"{number} -> ");
    number = number % 10;
    Console.WriteLine($"{number}");
}
else Console.WriteLine($"Неправильный ввод!");
