﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int thirdDigit
// int threeDigitNumber

Console.Clear();
Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("третьей цыфры нет");
}
else
{
    while (num > 999)
    {
        num /= 10;
    }
    int thirdDigit = num % 10;
    Console.WriteLine(thirdDigit);
}
