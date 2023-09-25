// Задача 11: Напишите программу, которая принимает на вход случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 --> 46
// 782 --> 72
// 918 --> 98

int number = new Random().Next(100, 1000);

int result = DeleteSecondDigit(number);

Console.WriteLine($"{number} --> {result}");

int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return firstDigit * 10 + thirdDigit;
}

