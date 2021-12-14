// 69. Найти сумму элементов от M до N, N и M заданы

int GetSumFromMToN (int m, int n)
{
    if (n < m) return 0;
    else return n + GetSumFromMToN(m, n - 1);
}

Console.Clear();

{   // Тест 1
    Console.WriteLine("Тест 1");
    int m = 5;
    int n = 10;
    int actualResult = GetSumFromMToN(m, n);
    int expectedResult = 45;
    Console.WriteLine($"Сумма от {m} до {n} равна {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int m = 0;
    int n = 5;
    int actualResult = GetSumFromMToN(m, n);
    int expectedResult = 15;
    Console.WriteLine($"Сумма от {m} до {n} равна {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}