// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите Number1: ");
string strNumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(strNumber1);
Console.WriteLine("Введите Number2: ");
string strNumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(strNumber2);
if (number1 == number2 * number2)
    {Console.WriteLine("Да");}
else
    {Console.WriteLine("Нет");}


// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число от 1 до 7: ");
string strNumber = Console.ReadLine();
int number = Convert.ToInt32(strNumber);
if (number < 8)
    {if (number == 1)
        {Console.WriteLine("Понедельник");}
    else
        { if (number == 2)
            {Console.WriteLine("Вторник");}
        else
            {if (number == 3)
                {Console.WriteLine("Среда");}
            else
                {if (number == 4)
                    {Console.WriteLine("Четверг");}
                    else
                        {if (number == 5)
                            {Console.WriteLine("Пятница");}
                        else
                            {if (number == 6)
                                {Console.WriteLine("Суббота");}
                            else
                                {if (number == 7)
                                    {Console.WriteLine("Воскресенье");}}}}}}}}
else 
    {Console.WriteLine("Не правильное число");}