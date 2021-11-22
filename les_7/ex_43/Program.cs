int DecToBinary (int x) // Переводит положительное число из десятичной в двоичную систему счисления
{
    int result = 0;
    int rate = 0;
    while (x >= 1)
    {
        result = result + x % 2 * (int)Math.Pow(10, rate);
        rate++;
        x = x / 2;
    }
    return result;
}

Console.Clear();

{   // Тест 1 (прямой)
    int a = 10;
    int expectedResult = 1010;
    int actualResult = DecToBinary(a);

    Console.WriteLine("Тест 1 (прямой)");
    Console.WriteLine($"{a} (dec) = {actualResult} (bin). Результат верен: {actualResult == expectedResult}\n");
}

{   // Тест 2 (прямой)
    int a = 99;
    int expectedResult = 1100011;
    int actualResult = DecToBinary(a);

    Console.WriteLine("Тест 2 (прямой)");
    Console.WriteLine($"{a} (dec) = {actualResult} (bin). Результат верен: {actualResult == expectedResult}\n");
}

{   // Тест 3 (пограничный)
    int a = 0;
    int expectedResult = 0;
    int actualResult = DecToBinary(a);

    Console.WriteLine("Тест 3 (пограничный)");
    Console.WriteLine($"{a} (dec) = {actualResult} (bin). Результат верен: {actualResult == expectedResult}\n");
}

{   // Тест 4 (пограничный)
    int a = 1;
    int expectedResult = 1;
    int actualResult = DecToBinary(a);

    Console.WriteLine("Тест 4 (пограничный)");
    Console.WriteLine($"{a} (dec) = {actualResult} (bin). Результат верен: {actualResult == expectedResult}\n");
}