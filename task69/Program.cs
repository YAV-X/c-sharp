// Задача 69: Напишите программу, которая на вход принимает два числа А и В, и возводит число А в целую степень В с помощью рекурсии.
// A = 3; B = 5 -> 243 (3*3*3*3*3)
// A = 2; B = 3 -> 8

int Pow(int a, int b)   // 3,5 3,4 3,3 3,2 3,1 3,0
{
    if (b == 0) return 1;
    return a * Pow(a, b - 1);   //3,5 3,4 3,3 3,2 3,1
}   // return (1) * 3 * 3 * 3 * 3 * 3

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целую степень числа А: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB < 0)
{
    Console.WriteLine(1 / (double)Pow(numA, -numB));
}
else Console.WriteLine(Pow(numA, numB));