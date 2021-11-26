int CalcMaxAttempts(int nums) // По длине диапозона вычисляем необходимое количество попыток
{
    int result = 0;
    while (nums > 1)
    {
        result++;
        nums /= 2;
    }
    return result + 1;
}

int RequestNumber() // Запрашиваем число у игрока (без проверок)
{
    Console.Write("\nВведите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintComparsionResult(int secretNumber, int playersNumber) // Выводим текст о том что число больше/меньше/угадано
{
    if      (secretNumber > playersNumber)  Console.Write("Загаданное число больше. ");
    else if (secretNumber < playersNumber)  Console.Write("Загаданное число меньше. ");
    else if (secretNumber == playersNumber) Console.Write("Поздравляем! Вы угадали! ");
}
string ToStrUsedAttempts(int attempts) // Возращаем строку с правильным окончанием: Вы спавились за...
{
    if (attempts > 9 && attempts < 21)                 return $"{attempts} попыток";
    else if (attempts % 10 == 1)                       return $"{attempts} попытку";
    else if (attempts % 10 >= 5 || attempts % 10 == 0) return $"{attempts} попыток";
    else                                               return $"{attempts} попытки";
}

string ToStrAttemptsLeft(int attempts) // Возращаем строку с правильным окончанием: Осталось...
{
    if (attempts > 9 && attempts < 21)                 return $"{attempts} попыток";
    else if (attempts % 10 == 1)                       return $"{attempts} попытка";
    else if (attempts % 10 >= 5 || attempts % 10 == 0) return $"{attempts} попыток";
    else                                               return $"{attempts} попытки";
}

void PrintResult(int countAttempts, int maxAttempts, bool isGuessed) // Выводим приглашение к следующей попытке, либо поздравление. Печатаем количество оставшихся попыток.
{
    if (isGuessed)               Console.WriteLine($"Вы справились за {ToStrUsedAttempts(maxAttempts - countAttempts)}.");
    else if (countAttempts == 0) Console.WriteLine("В этот раз вам не повезло. Ваши попытки закончились.");
    else                         Console.WriteLine($"Осталось {ToStrAttemptsLeft(countAttempts)}.");
}

int minVal = 1; // Задаем границы диапозона в котоом программа загадывает число
int maxVal = 100;
int maxAttempts = CalcMaxAttempts(maxVal - minVal); // По диапозону вычисляем необходимое количество попыток
int countAttempts = maxAttempts;
int secretNumber = new Random().Next(minVal, maxVal + 1); // Загадываем число
bool isGuessed = false; // Переменная признак того что число угадано

// Печатаем правила
Console.Clear();
Console.WriteLine($"Компьютер загадал число от {minVal} до {maxVal}. Попробуйте угадать какое. У вас {ToStrAttemptsLeft(countAttempts)}.");

do
{
    int playersNumber = RequestNumber(); // Запрашиваем число у игрока
    countAttempts--; // Уменьшаем количество попыток
    isGuessed = (secretNumber == playersNumber); // Булевая переменная признак что число угадано
    PrintComparsionResult(secretNumber, playersNumber); // Выводим текст о том что число больше/меньше/угадано
    PrintResult(countAttempts, maxAttempts, isGuessed); // Выводим приглашение к следующей попытке, либо поздравление. Печатаем количество оставшихся попыток.
} while (isGuessed == false && countAttempts > 0); // Повторяем цикл пока число не угадано и количество попыток не 0
