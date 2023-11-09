// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Пример
// 2 3 4 3
// 4 3 4 1 => 2 + 3 + 5 = 10
// 2 9 5 4

int[,] GeneateArray2D()
{
    int[,] array = new int[6, 6];
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

void Sum(int[,] array)
{
    int result = 0;
    for (int i = 0, j = 0; i < array.GetLength(0) && j < array.GetLength(1); j++, i++)
    {
        result = result + array[i, j];
    }
    // for (int i = 0; i < array.GetLength(0); i++)        //8
    // {
    //     for (int j = 0; j < array.GetLength(1); j++)    //6  
    //     {
    //         if (i == j)
    //         {
    //             result = result + array[i, j];
    //         }
    //     }
    // }
    Console.Write("Сумма элементов главной диагонали: " + result);
}

int[,] array = GeneateArray2D();
PrintArray(array);
Console.WriteLine("____________");
Sum(array);
