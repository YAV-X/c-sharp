// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 46 --> 101110
// 13 --> 1101
// 2 --> 10

int DecToBaseNum(int number, int baseNum)
{
    int result = 0;
    int mult = 1;
    while (number > 0)
    {
        result += number % baseNum * mult;           //1 + 0 + 1 + 1 + 0
        number /= baseNum;
        mult *= 10;
    }
    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите основание системы счисления: ");
int baseNumber = Convert.ToInt32(Console.ReadLine());

int decToBaseNum = DecToBaseNum(number, baseNumber);
Console.WriteLine($"{number} --> {decToBaseNum}");
