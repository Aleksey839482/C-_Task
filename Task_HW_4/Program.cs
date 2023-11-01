﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// 1. Cоздать цикл приема чисел А и Б 
// 2. Использовать метод Math.Pow(A,Б) для возведения числа А в натуральную степень B 


// void numberAB(double a , double b)
// {
//     double result = Math.Pow(a,b);
//     Console.WriteLine($" {a} ^ {b} = {result}");
// }

// Console.Write("Введите число A : ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число B : ");
// double b = Convert.ToDouble(Console.ReadLine());
// numberAB(a,b);





﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int sum (int number)
// {
//     int result = 0;
//     while(number > 0)
//     {
//         result += number % 10;
//         number = number / 10;
//     }
//     return result;
// }

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Сумма всех чисел в цифре {number} = {sum(number)}");





// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GenerateArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"Массив из {array.Length} элементов : ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] result = GenerateArray();
PrintArray(result);