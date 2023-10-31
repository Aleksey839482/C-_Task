// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2


int[] GenerateArray (int arrayLength) 
{
    int[] array = new int[arrayLength];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,101);
    }

    return array;
}
void PrintArray (int[] array) 
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int CountNumbers (int[] array) 
{
    int number = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == 1 && array[i] % 7 == 0)
        number++;
    }
    return number;
}

Console.Write("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = GenerateArray(n);
PrintArray(array);
int number = CountNumbers(array);

Console.WriteLine("Количество чисел: " + number);
