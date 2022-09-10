//  Написать программу показывающие первые N чисел,
// для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());



int N = 10;
int Metod(int x, int y, int num)
{
    if (num == 1) return x;
    if (num == 2) return y;
    return Metod(x, y, num - 1) + Metod(x, y, num - 2);
}
for (int i = 1; i < N; i++)
{
    Console.Write(Metod(a, b, i) + " ");
}