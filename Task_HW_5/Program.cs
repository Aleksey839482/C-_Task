﻿//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//4 3 1 (1,2) => 9
//2 6 9 

// 1.Создать двумерный массив 
// 2.Заполнить его случайными числами 
// 3.Написать метод который принимает позиции элемента (0,0) (0,1) (0,2) и возвращает значение элемента из позиции или выдаёт ошибку при отстутствии позиции
                                                    // (1,0) (1,1) (1,2)

// int [,] GenerateArray()
// {
//     int[,] array = new int[2,3];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }                    

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// void ElementPosition(int [,] array, int [] array2) //метод проверки существует ли позиция в нашем массиве который принимает двумерный и одномерный массивы
// {
//     if ( array2[0] < array.GetLength(0) && array2[1] < array.GetLength(1))  
//     {
//         Console.Write($"ЭЛЕМЕНТ МАССИВА {array[array2[0],array2[1]]}");    
//     }
//         else 
//         {
//                 Console.Write("Такого элемента не сущестует");
//         }   
// }

// int[] EnterNumbers() //метод ввода чисел через , позиции элемента массива
// {
//     Console.Write("Введите номер позиции массива через ',': ");
//     string input = Console.ReadLine();
//     string[] arrayNumbers = input.Split(","); // .Split метод разделения текста (символ которым разделяют | , # и тд .)
//     int[] numbers = new int[arrayNumbers.Length];
//     for(int i  = 0; i < arrayNumbers.Length; i++)
//     {
//         numbers[i] = Convert.ToInt32(arrayNumbers[i]);
//     }
//     return numbers;
// }

// int[,] mass = GenerateArray();
// PrintArray(mass);
// int [] mass1 = EnterNumbers();
// ElementPosition(mass,mass1);




﻿//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
//4 3 1 => 4 6 2
//2 6 9 => 2 6 9
//4 6 2 => 4 3 1

// 1.Задать двумерный массив 
// 2.Вывести двумерный массив 
// 3.Элементы первой строки записать в новую переменную 
// 4.Элементы последней строки перезаписать в первую строку 
// 5.Элементы записанные в новую переменную записать в последнюю строку
// 6.Вывести получившийся массив 


// int [,] GenerateArray()
// {

//     int[,] array = new int[3,3];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }        

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ReverseFirstAndLaststring(int [,] array)
// {
//     int number = 0;
//     for(int j = 0;j < array.GetLength(1);j++) 
//     {
//         number = array[0,j]; //переменна для хранения значений чтобы не потерять вовремя замены элементов
//         array[0,j] = array[array.GetLength(0) - 1,j]; //элементу первой строки присваиваем значение элемента последней строки 
//         array[array.GetLength(0) - 1,j] = number; //элементу последней строки присваиваем значение переменной в которую записывали значения элемента первой строки
//     }
//     return array;

// }

// int [,] mass = GenerateArray();
// PrintArray(mass);
// ReverseFirstAndLaststring(mass);
// Console.WriteLine("-----------");
// PrintArray(mass);



﻿// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// 4 3 1 => Строка с индексом 0
// 2 6 9

// 1.Задать прямоугольный двумерный массив 
// 2.Создать метод который будет суммировать элементы строк и сравнивать сумма каких меньше

int [,] GenerateArray()
{

    int[,] array = new int[2, 3];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}        

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SummStringArrayCheck(int [,] array)
{
    int [] summ = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ[i] = summ[i] + array[i,j];
            

        }
        Console.WriteLine($"Cумма cтроки с индексом {i} = {summ[i]} ");
    }
    int min = summ[0];
    int IndexMin = 0;
    for(int i = 0; i < summ.Length ; i++)
    {
        if(summ[i] < min )
        {
            min = summ[i];
            IndexMin = i;
        }
    }
    Console.WriteLine($"Индекс строки с минимальной суммой - {IndexMin}");
}

int[,] arr = GenerateArray();
PrintArray(arr);
SummStringArrayCheck(arr);