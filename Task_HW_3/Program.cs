// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
// массив [10 21 14 93 23] => 2

Console.Write("Введите число для размера массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
int quantity = 0;

for(int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(1, 101);
        Console.Write(array[i] + " ");
    }


