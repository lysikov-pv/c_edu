// 70. Найти сумму цифр числа

int GetSumDigits (int n)
{
    if (n == 0) return 0;
    else return n % 10 + GetSumDigits(n / 10);
}

Console.Clear();

{   // Тест 1
    Console.WriteLine("Тест 1");
    int n = 108;
    int actualResult = GetSumDigits(n);
    int expectedResult = 9;
    Console.WriteLine($"Сумма цифр числа {n} равна {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int n = 108108;
    int actualResult = GetSumDigits(n);
    int expectedResult = 18;
    Console.WriteLine($"Сумма цифр числа {n} равна {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}