// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

int[,] array = GeneateArray2D();
PrintArray(array);
double[] array2 = new double[array.GetLength(1)];


int[,] GeneateArray2D()
{
    int[,] array = new int[3, 4];
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
Console.Write("Новый массив: ");

for (int i = 0; i < array.GetLength(0); i++)
{
    double result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result += array[i, j];
    }
    result /= array.GetLength(1);
    array2[i] = result;
    Console.Write(array2[i] + " ");
}
