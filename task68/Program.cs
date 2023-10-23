// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// m = 4, n = 0 -> A(m,n) = 13
// m = 3, n = 11 -> A(m,n) = 16381

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Ack(m - 1, 1);
    return Ack(m - 1, Ack(m, n - 1));
}

Console.Write("Введите натуральное число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

if (numM < 0 || numN < 0)
{
    Console.WriteLine("Неправильный ввод!");
    return;
}

int result = Ack(numM, numN);
Console.WriteLine($"m = {numM}, n = {numN} -> A(m,n) = {result}");
