﻿//  Найти сумму цифр числа

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());


int SumDigits(int number)
{
    if (number < 1) return 0;
    int result = 0;
    return SumDigits(number / 10) + number % 10;
}
Console.WriteLine($"Сумма числа: {SumDigits(number)}");