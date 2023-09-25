// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 --> нет
// 46 --> нет
// 161 --> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool IsMultipleOfDigit(int num, int divisor1, int divisor2)
{
    return (num % divisor1 == 0) && (num % divisor2 == 0);
}

if (IsMultipleOfDigit(number, 7, 23))
{
    Console.WriteLine($"{number} --> да");
}
else Console.WriteLine($"{number} --> нет");
