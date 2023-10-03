// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// 452 --> 11
// 82 --> 10
// 9012 --> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumOfDigits(int num)
{
    int digit = 0;
    int result = 0;
    while (num > 10)
    {
        digit = num % 10;
        result += digit;
        num /= 10;
    }
    result += num;
    return result;
}

Console.WriteLine($"{number} --> {SumOfDigits(number)}");

// int sumOfDigits = SumOfDigits(number);
// Console.WriteLine($"{number} --> {sumOfDigits}");