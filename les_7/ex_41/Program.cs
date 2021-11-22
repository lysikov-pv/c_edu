// 41. Выяснить являются ли три числа сторонами треугольника

bool CheckTriangle(int a, int b, int c) // Возращает максимальный элемент массива
{
    return (a < b + c) && (b < a + c) && (c < a + b);
}

Console.Clear();

{   // Тест 1 (прямой)
    int a = 1;
    int b = 1;
    int c = 1;
    bool expectedResult = true;
    bool actualResult = CheckTriangle(a, b, c);

    Console.WriteLine("Тест 1 (прямой)");
    Console.WriteLine($"a={a}, b={b}, c={c}. Являются сторонами треугольника: {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}

{   // Тест 2 (прямой)
    int a = 1;
    int b = 5; // Не возможно построить треугольни
    int c = 1;
    bool expectedResult = false;
    bool actualResult = CheckTriangle(a, b, c);

    Console.WriteLine("Тест 2 (прямой)");
    Console.WriteLine($"a={a}, b={b}, c={c}. Являются сторонами треугольника: {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}

{   // Тест 3 (пограничный)
    int a = 1;
    int b = 0; // Одна из сторон 0
    int c = 2;
    bool expectedResult = false;
    bool actualResult = CheckTriangle(a, b, c);

    Console.WriteLine("Тест 3 (пограничный)");
    Console.WriteLine($"a={a}, b={b}, c={c}. Являются сторонами треугольника: {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}

{   // Тест 4 (пограничный)
    int a = 1;
    int b = 2;
    int c = 3; // Одна из сторон равна сумме других
    bool expectedResult = false;
    bool actualResult = CheckTriangle(a, b, c);

    Console.WriteLine("Тест 4 (пограничный)");
    Console.WriteLine($"a={a}, b={b}, c={c}. Являются сторонами треугольника: {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}


{   // Тест 5 (обратный)
    int a = 1;
    int b = -1; // Одна из сторон отрицательная длина
    int c = 1;
    bool notExpectedResult = true;
    bool actualResult = CheckTriangle(a, b, c);

    Console.WriteLine("Тест 5 (обратный)");
    Console.WriteLine($"a={a}, b={b}, c={c}. Являются сторонами треугольника: {actualResult}. Результат верен: {actualResult != notExpectedResult}\n");
}

{   // Тест 6 (обратный)
    int a = -1;
    int b = -1; 
    int c = -1;
    bool notExpectedResult = true;  // Где-то в параллельной вселенной отрицательный треугольник, но не у нас
    bool actualResult = CheckTriangle(a, b, c);

    Console.WriteLine("Тест 5 (обратный)");
    Console.WriteLine($"a={a}, b={b}, c={c}. Являются сторонами треугольника: {actualResult}. Результат верен: {actualResult != notExpectedResult}\n");
}