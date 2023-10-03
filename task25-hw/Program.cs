// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 --> 243
// 2, 4 --> 16

int Power(int x, int y)
{
    int power = 1;
    for(int i = 1; i <= y; i++)
    {
        checked
        {
            power *= x;
        }
        
    }
    return power;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int pow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number}, {pow} --> {Power(number, pow)}");
