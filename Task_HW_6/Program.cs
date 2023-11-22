﻿// Задача 41 : Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь

// Пример 0,7,8,-2,-2 -> 2
// -1,-7,567,89,223 -> 3

// int[] GenerateArray()
// {
//     string[] str;
//     Console.WriteLine("Введите числа через , ");
//     str = Console.ReadLine().Split(",");
//     int[] array = new int[str.Length];

//     for(int i = 0; i < str.Length; i++)
//     {
//         array[i] = Convert.ToInt32(str[i]);
//     }
//     return array;
// }

// void CountNumbers(int[] array)
// {
//     int result = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         {
//             result++;
//         }
//     }
//     Console.WriteLine("Количество положительных чисел = " + result);
// }

// int[] array = GenerateArray();
// CountNumbers(array);


// Задача 43. Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1,k1,b2 и k2
// задаются пользователем. 

// Пример 
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 (-0,5;-0,5) 

double[] Numbers()
{
    string[] str;
    Console.WriteLine("Введите числа b1, b2, k1, k2 через , ");
    str = Console.ReadLine().Split(",");
    double[] array = new double[str.Length];

    for(int i = 0; i < str.Length; i++)
    {
        array[i] = Convert.ToInt32(str[i]);
    }
    return array;
}

void Point(double[] array)
{
    double b1 = array[0];
    double b2 = array[1];
    double k1 = array[2];
    double k2 = array[3];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    Console.WriteLine($"Прямые пересекаются в точке x = {x} y = {y}");
}

double[] array = Numbers();
Point(array);