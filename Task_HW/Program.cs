// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3



// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2)
//     {Console.WriteLine($"Число {number1} больше {number2}");}
// else
//     {Console.WriteLine($"Число {number2} больше {number2}");}



// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22



// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number3 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2 && number1 > number3)
//     {Console.WriteLine($"Число {number1} большее");}
// else if (number2 > number1 && number2 > number3)
//     {Console.WriteLine($"Число {number2} большее");}
// else
//     {Console.WriteLine($"Число {number3} большее");}


// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


// Console.WriteLine("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// if ((x % 2) == 0)
// {
//     Console.WriteLine("Чётное");
// }
// else
// {
//     Console.WriteLine("Нечётное");
// }



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int N = number; N <= number; N++)
{   if ((N % 2) == 0)
    {
        Console.Write(N + " ");
    }
    else
    {
        Console.Write("Четных чисел нет");
    }
}