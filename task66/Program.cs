// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRangeNaturalNumbers(int m, int n)
{
    if (m < n) return m + SumRangeNaturalNumbers(m + 1, n);
    else if (m > n) return n + SumRangeNaturalNumbers(m, n + 1);
    else return n;
}

Console.Write("Введите натуральное число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

if (numM < 1 || numN < 1)
{
    Console.WriteLine("Неправильный ввод!");
    return;
}

int result = SumRangeNaturalNumbers(numM, numN);
Console.WriteLine($"M = {numM}; N = {numN} -> {result}");
