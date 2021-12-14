// 72. Написать программу возведения числа А в целую стень B

int PowerAtoB (int a, int b)
{
    if (b < 1) return 1;
    else return a * PowerAtoB(a, b - 1);
}

Console.Clear();

{   // Тест 1
    Console.WriteLine("Тест 1");
    int a = 2;
    int b = 3;
    int actualResult = PowerAtoB(a, b);
    int expectedResult = 8;
    Console.WriteLine($"{a} в степени {b} равно {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int a = 4;
    int b = 5;
    int actualResult = PowerAtoB(a, b);
    int expectedResult = 1024;
    Console.WriteLine($"{a} в степени {b} равно {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}