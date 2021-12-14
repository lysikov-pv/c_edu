// 65. Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 

int[,] GetSpiralFill(int rows, int columns) // Заполняет массив спирально
{
    int[,] array = new int[rows, columns];
    int i = 0;
    int j = 0;
    int count = 1;
    string direction = "right";
    int changeDirection = 0;
    while (changeDirection < 2)
    {

        if (changeDirection == 0)
        {
            array[i, j] = count;
            count++;
        }
        switch (direction)
        {
            case "right":
            {
                if (j + 1 < columns ) // Справа не край массива
                    if (array[i, j + 1] == 0) // Справа пустая ячейка
                    {
                        j++;
                        changeDirection = 0;
                    }
                    else // Справа ячейка заполнена
                    {
                        direction = "down";
                        changeDirection++;
                    }
                else // Справа край массива
                {
                    direction = "down";
                    changeDirection++;
                }
                break;
            }
            case "down":
            {
                if (i + 1 < rows ) // Снизу не край массива
                    if (array[i + 1, j] == 0) // Снизу пустая ячейка
                    {
                        i++;
                        changeDirection = 0;
                    }
                    else // Сниху ячейка заполнена
                    {
                        direction = "left";
                        changeDirection++;
                    }
                else // Снизу край массива
                {
                    direction = "left";
                    changeDirection++;
                }
                break;
            }
            case "left":
            {
                if (j - 1 >= 0 ) // Слева не край массива
                    if (array[i, j - 1] == 0) // Слева пустая ячейка
                    {
                        j--;
                        changeDirection = 0;
                    }
                    else // Слева ячейка заполнена
                    {
                        direction = "top";
                        changeDirection++;
                    }
                else // Слева край массива
                {
                    direction = "top";
                    changeDirection++;
                }
                break;
            }
            case "top":
            {
                if (i - 1 >= 0 ) // Сверху не край массива
                    if (array[i - 1, j] == 0) // Сверху пустая ячейка
                    {
                        i--;
                        changeDirection = 0;
                    }
                    else // Сверху ячейка заполнена
                    {
                        direction = "right";
                        changeDirection++;
                    }
                else // Сверху край массива
                {
                    direction = "right";
                    changeDirection++;
                }
                break;
            }
        }
    }
    return array;
}

void PrintArray(int[,] arr, string preStr = "", string postStr = "\n") // Выводит на экран элементы двумерного массива
{
    Console.Write(preStr);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(String.Format("{0,5:0}", arr[i, j]));
        Console.WriteLine();
    }
    Console.Write(postStr);
}

{   // Тест 1
    Console.WriteLine("Тест 1");
    int[,] array = GetSpiralFill(rows: 1, columns: 6);
    PrintArray(array, preStr: "", postStr: "");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[,] array = GetSpiralFill(rows: 7, columns: 1);
    PrintArray(array, preStr: "", postStr: "");
}

{   // Тест 3
    Console.WriteLine("Тест 3");
    int[,] array = GetSpiralFill(rows: 2, columns: 5);
    PrintArray(array, preStr: "", postStr: "");
}

{   // Тест 4
    Console.WriteLine("Тест 4");
    int[,] array = GetSpiralFill(rows: 3, columns: 8);
    PrintArray(array, preStr: "", postStr: "");
}

{   // Тест 5
    Console.WriteLine("Тест 5");
    int[,] array = GetSpiralFill(rows: 9, columns: 6);
    PrintArray(array, preStr: "", postStr: "");
}