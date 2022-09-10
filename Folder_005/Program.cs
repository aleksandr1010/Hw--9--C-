//  Написать программу возведения числа А в целую степень B

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

int DegreeOfNumber(int numberA, int numberB)
{
    if (numberB < 1) return 1;
    return numberA * (DegreeOfNumber(numberA, numberB - 1));
}

Console.WriteLine($" Число {numberA} в {numberB} степени = {DegreeOfNumber(numberA, numberB)}");
