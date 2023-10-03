// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

// Находим расстояние по теореме Пифагора.

int catet1 = x1 - y1;
int catet2 = x2 - y2;
double distance = Math.Sqrt((catet1 * catet1) + (catet2 * catet2));

// Округление и вывод

double resultRound = Math.Round(distance, 2, MidpointRounding.ToZero);

Console.WriteLine(resultRound);
