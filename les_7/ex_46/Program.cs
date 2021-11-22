// 46. Написать программу масштабирования фигуры

//  (x1,y1)-----------(x2,y2)
//     |                 |
//     |                 |
//  (x0,y0)-----------(x3,y3)

double[] ScaleRectangle(double[] coord, double n) // Масштабирует прямоугольник координаты которого заданы в формате {x0, y0, x1, y1, x2, y2, x3, y3}. Точка x0, y0 остается на месте.
{
    double[] result = new double[8];

    result[0] = coord[0];         // x0'
    result[1] = coord[1];         // y0'

    result[4] = coord[0] + (coord[4] - coord[0]) * n; // x2' = x0 + (x2 - x0) * n
    result[5] = coord[1] + (coord[5] - coord[1]) * n; // y2' = x0 + (y2 - y0) * n
 
    result[2] = coord[0];         // x1' = x0'
    result[3] = result[5];        // y1' = y2'

    result[6] = result[4];        // x3' = x2'
    result[7] = coord[1];         // y3' = y0'

    return result;
}

bool IsEqualArray(double[] arrA, double[] arrB) // Сравнивает поэлементно два массива: True - идентичны, False - отличаются.
{
    if (arrA.Length != arrB.Length) return false;
    else
    {
        for (int i = 0; i < arrA.Length; i++)
        {
            if (arrA[i] != arrB[i]) return false;
        }
    }
    return true;
}

void PrintRectCoord(double[] coord)
{
    Console.WriteLine($"({coord[2]}, {coord[3]})-----------({coord[4]}, {coord[5]})");
    Console.WriteLine($"   |                |");
    Console.WriteLine($"   |                |");
    Console.WriteLine($"({coord[0]}, {coord[1]})-----------({coord[6]}, {coord[7]})");
}

Console.Clear();

{   // Тест 1 (прямой)
    double[] initCoord = { 1, 1, 1, 2, 2, 2, 2, 1 };
    int n = 2;
    double[] expectedCoord =  { 1, 1, 1, 3, 3, 3, 3, 1 };
    double[] actualCoord = ScaleRectangle(initCoord, n);

    Console.WriteLine("Тест 1 (прямой)");
    Console.WriteLine($"Начальные координаты: ");
    PrintRectCoord(initCoord);
    Console.WriteLine($"Координаты после масштабирования на {n}: ");
    PrintRectCoord(actualCoord);
    Console.WriteLine($"Результат верен: {IsEqualArray(actualCoord, expectedCoord)}\n");
}

{   // Тест 2 (прямой)
    double[] initCoord = { -1, -1, -1, 2, 2, 2, 2, -1 };
    int n = 3;
    double[] expectedCoord =  { -1, -1, -1, 8, 8, 8, 8, -1 };
    double[] actualCoord = ScaleRectangle(initCoord, n);

    Console.WriteLine("Тест 2 (прямой)");
    Console.WriteLine($"Начальные координаты: ");
    PrintRectCoord(initCoord);
    Console.WriteLine($"Координаты после масштабирования на {n}: ");
    PrintRectCoord(actualCoord);
    Console.WriteLine($"Результат верен: {IsEqualArray(actualCoord, expectedCoord)}\n");
}