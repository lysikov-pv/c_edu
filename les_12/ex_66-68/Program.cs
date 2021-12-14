// 66. Показать натуральные числа от 1 до N, N задано
// 67. Показать натуральные числа от N до 1, N задано
// 68. Показать натуральные числа от M до N, N и M заданы

void PrintFrom1ToN (int n)
{
    if (n < 1) return;
    PrintFrom1ToN(n - 1);
    Console.Write($"{n} ");
}

void PrintFromNTo1 (int n)
{
    if (n < 1) return;
    Console.Write($"{n} ");
    PrintFromNTo1(n - 1);
}

void PrintFromMToN (int m, int n)
{
    if (n < m) return;
    PrintFromMToN(m, n - 1);
    Console.Write($"{n} ");
}

Console.Clear();

{   // Тест 1
    Console.WriteLine("Тест 1");
    PrintFrom1ToN(n:10);
}

{   // Тест 2
    Console.WriteLine("\n\nТест 2");
    PrintFromNTo1(n:15);
}

{   // Тест 3
    Console.WriteLine("\n\nТест 3");
    PrintFromMToN(m:17, n:31);
}