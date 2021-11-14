// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет
// 15. Дано число. Проверить кратно ли оно 7 и 23
// 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём
// 17. По двум введённым числам проверять является ли одно квадратом другого
// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Ввести номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.
// 22. Найти расстояние между точками в пространстве 2D/3D

int InpVar(string str) // Возращает значение введенное с клавиатуры
{
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int RandomVar(string str, int min, int max) // Возращает значение из диапазона [min;max) попутно выводя его на экран 
{
    int x = new Random().Next(min, max);
    Console.WriteLine(str + x);
    return x;
}

int ParsIntToArray(int x, int[] arr) // Заполняет массив цифрами из числа (1234 => {4,3,2,1}) и возращает длину полученного массива 
{
    int i = 0;
    while (x > 0)
    {
        arr[i] = x % 10;
        i++;
        x = x / 10;
    }
    return i;
}

int MaxInArray(int[] arr, int arrLength) // Возращает максимальный элемент массива
{
    int max = arr[0];
    for (int i = 1; i < arrLength; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

int exampleNum;
do
{
    Console.Clear();
    Console.WriteLine("11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа");
    Console.WriteLine("12. Удалить вторую цифру трёхзначного числа");
    Console.WriteLine("13. Выяснить, кратно ли число заданному, если нет, вывести остаток");
    Console.WriteLine("14. Найти третью цифру числа или сообщить, что её нет");
    Console.WriteLine("15. Дано число. Проверить кратно ли оно 7 и 23");
    Console.WriteLine("16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём");
    Console.WriteLine("17. По двум введённым числам проверять является ли одно квадратом другого");
    Console.WriteLine("18. Проверить истинность утверждения ¬(X ИЛИ Y) = ¬X И ¬Y");
    Console.WriteLine("19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X != 0 и Y != 0");
    Console.WriteLine("20. Ввести номер четверти, показать диапазоны для возможных координат");
    Console.WriteLine("21. Программа проверяет пятизначное число на палиндромом");
    Console.WriteLine("22. Найти расстояние между точками в пространстве 2D/3D");
    Console.WriteLine("0.  Выход");
    exampleNum = InpVar("Введите номер задачи для проверки: ");
    switch (exampleNum)
    {
        case 11: // Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
            {
                int a = RandomVar("A = ", 10, 100);
                int[] arr = new int[10];
                int arrLength = ParsIntToArray(a, arr);
                Console.WriteLine($"{MaxInArray(arr, arrLength)} является максимальной цифрой числа");
                break;
            }
        case 12: // Удалить вторую цифру трёхзначного числа
            {
                int a = RandomVar("A = ", 100, 1000);
                int[] arr = new int[10];
                int arrLength = ParsIntToArray(a, arr);
                int b = arr[0] + arr[2] * 10; // В массиве в индексе 0 храниться последняя цифра числа
                Console.WriteLine($"Число A без второй цифры: {b}");
                break;
            }
        case 13: // Выяснить, кратно ли число заданному, если нет, вывести остаток
            {
                int a = RandomVar("A = ", 0, 1000);
                int b = InpVar("B = ");
                if (a % b == 0)
                {
                    Console.WriteLine($"{a} кратно {b}");
                }
                else
                {
                    Console.WriteLine($"{a} не кратно {b}; остаток от делления {a % b}");
                }
                break;
            }
        case 14: // Найти третью цифру числа или сообщить, что её нет
            {
                int a = InpVar("A = ");
                int[] arr = new int[10];
                int arrLength = ParsIntToArray(a, arr);
                if (arrLength > 2)
                {
                    Console.WriteLine($"Третья цифра числа {arr[2]}");
                }
                else
                {
                    Console.WriteLine($"У числа нет третьей цифры");
                }
                break;
            }
        case 15: // Дано число. Проверить кратно ли оно 7 и 23
            {
                int a = InpVar("A = ");
                if (a % 7 == 0) // Можно было (a % 7 == 0 && a % 23 == 0), но захотелось показать чему именно кратно
                {
                    Console.Write($"Число кратно 7");
                }
                else
                {
                    Console.Write($"Число не кратно 7");
                }
                if (a % 23 == 0)
                {
                    Console.WriteLine($" и кратно 23");
                }
                else
                {
                    Console.WriteLine($" и не кратно 23");
                }
                break;
            }
        case 16: // Дано число обозначающее день недели. Выяснить является номер недели выходным днём
            {
                int a = InpVar("A = ");
                if (a == 6 || a == 7)    Console.Write($"Это выходной");
                else if (a > 0 && a < 6) Console.Write($"Это будний день");        
                else                     Console.Write($"Такого дня недели нет");
                break;
            }
        case 17: // По двум введённым числам проверять является ли одно квадратом другого
            {
                int a = InpVar("A = ");
                int b = InpVar("B = ");
                if (a == b * b)      Console.WriteLine($"{a} является квадратом {b}");
                else if (b == a * a) Console.WriteLine($"{b} является квадратом {a}");
                else                 Console.WriteLine($"Не одно из чисел не является квадратом другого");
                break;
            }
        case 18: // Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
            {
                int count = 0;
                for (int ix = 0; ix <= 1; ix++)
                    for (int iy = 0; iy <= 1; iy++)
                    {
                        bool x = Convert.ToBoolean(ix);
                        bool y = Convert.ToBoolean(iy);
                        bool result = (!(x || y) == !x && !y);
                        if (result) count++;
                        Console.WriteLine($"X  = {x}, Y = {y}, выражение: {result}");
                    }
                if (count == 0) Console.WriteLine("Итог: Для всех сочетаний X и Y выражение истинно");
                else Console.WriteLine("Итог: Выражение ложно");
                break;
            }
        case 19: // Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
            {
                int x = InpVar("X = ");
                int y = InpVar("Y = ");
                if (x > 0 && y > 0)        Console.WriteLine("I четверть");
                else if (x < 0 && y > 0)   Console.WriteLine("II четверть");
                else if (x < 0 && y < 0)   Console.WriteLine("III четверть");
                else if (x > 0 && y < 0)   Console.WriteLine("IV четверть");
                else if (x == 0 && y == 0) Console.WriteLine("Начало координат");
                else                       Console.WriteLine("Как ты это сделал?");
                break;
            }
        case 20: // Ввести номер четверти, показать диапазоны для возможных координат
            {
                int n = InpVar("Введите номер четверти: ");
                if (n == 1)      Console.WriteLine("x > 0, y > 0");
                else if (n == 2) Console.WriteLine("x < 0, y > 0");
                else if (n == 3) Console.WriteLine("x < 0, y < 0");
                else if (n == 4) Console.WriteLine("x > 0, y < 0");
                else             Console.WriteLine("Такой четверти нет");
                break;
            }
        case 21: // Программа проверяет число на палиндромом (размер ввода ограничен типом int)
            {
                int a = InpVar("A = ");
                int[] arr = new int[10];
                int arrLength = ParsIntToArray(a, arr);
                bool result = true;
                for (int i = 0; i < arrLength / 2; i++)
<<<<<<< HEAD
                    if (arr[i] != arr[arrLength - i - 1]) result = false;
=======
                    if(arr[i]!=arr[arrLength-i-1]) result = false;
>>>>>>> 09d091f9a318565b0d1f52160415e7e6def7131b
                if (result) Console.WriteLine("Число палиндром");
                else        Console.WriteLine("Число не палиндром");
                break;
            }
        case 22: // Найти расстояние между точками в пространстве 2D/3D
            {
                int n = InpVar("Введите кол-во измерений (2=2D, 3=3D): ");
                if (n == 2)
                {
                    int x1 = RandomVar("X1 = ", -100, 101);
                    int y1 = RandomVar("Y1 = ", -100, 101);
                    int x2 = RandomVar("X2 = ", -100, 101);
                    int y2 = RandomVar("Y2 = ", -100, 101);
                    Console.WriteLine($"Расстояние между точками ({x1},{y1}) и ({x2},{y2}) равно {Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))}");
                }
                else if (n == 3)
                {
                    int x1 = RandomVar("X1 = ", -100, 101);
                    int y1 = RandomVar("Y1 = ", -100, 101);
                    int z1 = RandomVar("Z1 = ", -100, 101);
                    int x2 = RandomVar("X2 = ", -100, 101);
                    int y2 = RandomVar("Y2 = ", -100, 101);
                    int z2 = RandomVar("Z2 = ", -100, 101);
                    Console.WriteLine($"Расстояние между точками ({x1},{y1},{z1}) и ({x2},{y2},{z2}) равно {Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2))}");
                }
                else Console.WriteLine("Программа не может посчитать для стольки измерений");
                break;
            }
    }
    if (exampleNum != 0) // Оставить решение задачи на экране пока не нажат Enter
    {
        Console.WriteLine("Нажмите Enter");
        Console.ReadLine();
    }
}
while (exampleNum != 0);