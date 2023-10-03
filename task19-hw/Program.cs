// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.
// Для остальных чисел вернуть True или False.
// 14212 -> False
// 12821 -> True
// 234322 -> False Число не пятизначное 

using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
        // Введите свое решение ниже
        // Преобразовываем число в строку
        string numberStr = number.ToString();

        // Проверяем, является ли число пятизначным
        if (numberStr.Length != 5)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }

        // Сравниваем цифры с начала и конца строки
        for (int i = 0; i < numberStr.Length / 2; i++)
        {
            if (numberStr[i] != numberStr[numberStr.Length - 1 - i])
            {
                return false; // Не является палиндромом
            }
        }

        return true; // Является палиндромом

    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 234322;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}