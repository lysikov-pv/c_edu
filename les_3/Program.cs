int InpVar(string str) // Возращает значение введенное с клавиатуры
{
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}
int Max2(int a, int b) // Возращает максимальное из двух
{
    if (a > b) return a; else return b;
}
int Min2(int a, int b) // Возращает минимальное из двух
{
    if (a < b) return a; else return b;
}
int Max3(int a, int b, int c) // Возращает максимальное из трех
{
    if (a > b)
    {
        if (a > c) return a; else return c;
    }
    else
    {
        if (b > c) return b; else return c;
    }
}
int RandomVar(string str, int min, int max) // Возращает значение из диапазона [min;max) попутно выводя его на экран 
{
    int x = new Random().Next(min, max);
    Console.WriteLine(str + x);
    return x;
}
int Sqrt(int a) // Возращает квадрат числа
{
    return a * a;
}

Console.Clear();
Console.WriteLine("0. Вывести квадрат числа");
Console.WriteLine("1. По двум введённым числам проверять является ли первое квадратом второго");
Console.WriteLine("2. Даны два числа. Показать большее и меньшее число");
Console.WriteLine("3. По введенному номеру дня недели вывести его название");
Console.WriteLine("4. Найти максимальное из трех чисел");
Console.WriteLine("5. Написать программу вычисления значения функции y=f(a)");
Console.WriteLine("6. Выяснить является ли число чётным");
Console.WriteLine("7. Показать числа от -N до N");
Console.WriteLine("8. Показать четные числа от 1 до N");
Console.WriteLine("9. Показать последнюю цифру трёхзначного числа");
Console.WriteLine("10. Показать вторую цифру трёхзначного числа");
int exampleNum = InpVar("Введите номер задачи для проверки: ");
int a, b, c, n;
switch (exampleNum)
{
case 0: // Вывести квадрат числа
    a = InpVar("A = ");
    Console.WriteLine($"{a} в квадрате это {Sqrt(a)}");
    break;

case 1: // По двум введённым числам проверять является ли первое квадратом второго
    a = InpVar("A = ");
    b = InpVar("B = ");
    if (Sqrt(b) == a)
    {
        Console.WriteLine($"{a} является квадратом {b}");
    }
    else
    {
        Console.WriteLine($"{a} не является квадратом {b}");
    }
    break;

case 2: // Даны два числа. Показать большее и меньшее число
    a = InpVar("A = ");
    b = InpVar("B = ");
    Console.WriteLine($"Большее {Max2(a, b)}, меньшее {Min2(a, b)}");
    break;

case 3: // По введенному номеру дня недели вывести его название
    int dayNum = InpVar("Введите номер дня: ");
    if      (dayNum == 1) { Console.WriteLine("Это понедельник"); }
    else if (dayNum == 2) { Console.WriteLine("Это вторник"); }
    else if (dayNum == 3) { Console.WriteLine("Это среда"); }
    else if (dayNum == 4) { Console.WriteLine("Это четверг"); }
    else if (dayNum == 5) { Console.WriteLine("Это пятница"); }
    else if (dayNum == 6) { Console.WriteLine("Это суббота"); }
    else if (dayNum == 7) { Console.WriteLine("Это воскресенье"); }
    else                  { Console.WriteLine("Нет такого дня недели"); }
    break;

case 4: // 4. Найти максимальное из трех чисел
    a = InpVar("A = ");
    b = InpVar("B = ");
    c = InpVar("C = ");
    Console.WriteLine("Максимальное из трех: " + Max3(a, b, c));
    break;

case 5: // Написать программу вычисления значения функции y=f(a)
    a = InpVar("A = ");
    Console.WriteLine($"y=sqrt({a})={Sqrt(a)}");
    break;


case 6: // Выяснить является ли число чётным
    a = InpVar("A = ");
    if (a % 2 == 0) { Console.WriteLine("Четное"); }
    else            { Console.WriteLine("Нечетное"); }
    break;

case 7: // Показать числа от -N до N
    n = InpVar("N = ");
    Console.Write("Числа от -N до N: ");
    for (int i=n*-1; i<=n; i++)
    {
        Console.Write($"{i} ");
    }
    break;

case 8: // Показать четные числа от 1 до N
    n = InpVar("N = ");
    Console.Write("Четные числа от 1 до N: ");
    for (int i=1; i<=n; i++)
    {
        if (i%2==0) Console.Write($"{i} ");
    }
    break;

case 9: // Показать последнюю цифру трёхзначного числа
    a = RandomVar("A = ", 100, 1000);
    Console.WriteLine("Последняя цифра: " + a % 10);
    break;

case 10: // Показать вторую цифру трёхзначного числа
    a = RandomVar("A = ", 100, 1000);
    Console.WriteLine("Вторая цифра: " + a / 10 % 10);
    break;

}