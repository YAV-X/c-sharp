// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25; b = 5 -> да
// a = 10; b = 2 -> нет
// a = -3; b = 9 -> нет
// a = 9; b = -3 -> да

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine($"a = {number1}; b = {number2} -> yes");
}
else Console.WriteLine($"a = {number1}; b = {number2} -> no");
