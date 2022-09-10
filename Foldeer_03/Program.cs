//  Найти сумму элементов от M до N, N и M заданы

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
 
 int Sum(int m, int n)
{
    if (n == m) return n;
    return m + Sum(m + 1, n);
}
Console.Write(Sum (m,n));
