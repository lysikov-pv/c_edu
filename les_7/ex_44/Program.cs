// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, b1 k1 и b2 и k2 заданы

double[] GetInersectionLines(double k1, double b1, double k2, double b2) // Возвращает координаты пересечения двух прямых в формате массива {x, y}
{
    double[] result = new double[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = k1 * result[0] + b1;
    return result;
}

Console.Clear();

{   // Тест 1 (прямой)
    double k1 = 1;
    double b1 = 1;
    double k2 = 2;
    double b2 = 2;
    double expectedX = -1;
    double expectedY = 0;
    double[] actualResult = GetInersectionLines(k1, b1, k2, b2);
    double actualX = actualResult[0];
    double actualY = actualResult[1];

    Console.WriteLine("Тест 1 (прямой)");
    Console.WriteLine($"Прямые y={k1}x+{b1} и y={k2}x+{b2} пересекаются в точне: ({actualX}, {actualY}). Результат верен: {actualX == expectedX && actualY == expectedY}\n");
}

{   // Тест 2 (прямой)
    double k1 = -1;
    double b1 = 2;
    double k2 = 3;
    double b2 = 4;
    double expectedX = -0.5;
    double expectedY = 2.5;
    double[] actualResult = GetInersectionLines(k1, b1, k2, b2);
    double actualX = actualResult[0];
    double actualY = actualResult[1];
        

    Console.WriteLine("Тест 2 (прямой)");
    Console.WriteLine($"Прямые y={k1}x+{b1} и y={k2}x+{b2} пересекаются в точне: ({actualX}, {actualY}). Результат верен: {actualX == expectedX && actualY == expectedY}\n");
}

{   // Тест 3 (прямой)
    double k1 = 1;
    double b1 = 2;
    double k2 = 3;
    double b2 = -4;
    double expectedX = 3;
    double expectedY = 5;
    double[] actualResult = GetInersectionLines(k1, b1, k2, b2);
    double actualX = actualResult[0];
    double actualY = actualResult[1];
        

    Console.WriteLine("Тест 3 (прямой)");
    Console.WriteLine($"Прямые y={k1}x+{b1} и y={k2}x{b2} пересекаются в точне: ({actualX}, {actualY}). Результат верен: {actualX == expectedX && actualY == expectedY}\n");
}