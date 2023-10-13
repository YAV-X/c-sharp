// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины. 
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Введите первую сторону: ");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую сторону: ");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью сторону: ");
int side3 = Convert.ToInt32(Console.ReadLine());

bool IsExistTriangle(int a, int b, int c)
{
    return a < b + c && b < a + b && c < a + b;
}

bool result = IsExistTriangle(side1, side2, side3);
Console.WriteLine(result ? "Треугольник существуею" : "Треугольник не существует");

