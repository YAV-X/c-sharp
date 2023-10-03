// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.Write("Введите число a: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2) Console.WriteLine($"a = {number1}; b = {number2} -> max = {number1}");
else if (number2 > number1) Console.WriteLine($"a = {number1}; b = {number2} -> max = {number2}");
else Console.WriteLine("Числа равны.");
