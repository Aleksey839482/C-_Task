// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// Указание
// Использовать рекурсию.

// Пример:
// 123 => 6
// 63 => 9

int Function(int number)
{
    if(number == 0)
    {
        return 0;
    }
    return number % 10 + Function(number / 10);
}

int number = 145;
Console.Write(Function(number));
