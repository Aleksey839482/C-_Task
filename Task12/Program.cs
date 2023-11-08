// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3      4 3 4 3
// 4 3 4 1 =>   4 3 4 1
// 2 9 5 4      2 9 25 4
// Обсудить этапы решения задачи
// Оформить этапы в виде функций


// int [] array = new int[8];           - одномерный массив
// int [,] array = new int[8, 8];       - двумерный массив
// int [,,] array = new int[8, 8, 8];   - трёхмерный массив

int[,] array = GeneateArray2D();
PrintArray(array);
Console.WriteLine("____________");
Square(array);
PrintArray(array);
Console.WriteLine("____________");


int[,] GeneateArray2D()
{
    int[,] array = new int[6, 6];
    for (int i = 0; i < array.GetLength(0); i++)        //8
    {
        for (int j = 0; j < array.GetLength(1); j++)    //6  
        {
          array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)        //8
    {
        for (int j = 0; j < array.GetLength(1); j++)    //6  
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Square(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)        //8
    {
        for (int j = 0; j < array.GetLength(1); j++)    //6  
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
}