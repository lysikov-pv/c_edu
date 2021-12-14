// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

void PrintCodeWord (string str)
{
    str = str.Replace("0", "а").Replace("1", "и").Replace("2", "с").Replace("3", "в");
    Console.WriteLine(str);
}

void PrintWords(string str, int n)
{
    int alphabetLength = 4;
    if (n < 1)
    {
        PrintCodeWord(str);
        return;
    }
    for (int i = 0; i < alphabetLength; i++)
    {
        str = String.Concat(str, i.ToString());
        PrintWords(str, n - 1);
        str = str.Substring(0, str.Length - 1);
    }
}

Console.Clear();

{   // Тест 1
    Console.WriteLine("Тест 1");
    int n = 2;
    PrintWords(string.Empty, n);
}

{   // Тест 2
    Console.WriteLine("\nТест 2");
    int n = 3;
    PrintWords(string.Empty, n);
}

{   // Тест 3
    Console.WriteLine("\nТест 3");
    int n = 4;
    PrintWords(string.Empty, n);
}