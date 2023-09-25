// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели: ");
string weekDay = Console.ReadLine();

if (weekDay == "6" || weekDay == "7")
    Console.WriteLine($"{weekDay} -> да");
else
    Console.WriteLine($"{weekDay} -> нет");
