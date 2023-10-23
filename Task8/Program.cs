// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. 
// Замените отрицательные элементы на положительные, а положительные на отрицательные.

// int[] arrey = new int[10];
// int len_arr = arrey.Length;
// for(int i = 0; i < len_arr; i++)
// {
//     arrey[i] = new Random().Next(-10, 11);
//     Console.Write(arrey[i] + " ");
// }
// Console.WriteLine();

// for(int i = 0; i < len_arr; i++)
// {
//     arrey[i] = -arrey[i];
//     Console.Write(arrey[i] + " ");
// }


// Найдите произведения пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новый массив.

// Пример

// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

// Console.Write("Введите число для размера массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num];

// int check_num = num / 2;
// int[] array_new = new int[check_num];

// for(int i = 0; i < num; i++)
// {
//     array[i] = new Random().Next(1, 11);
//     Console.Write(array[i] + " ");
// }

// Console.WriteLine (" || ");

// int last_index = num - 1;
// for(int i = 0, j = last_index; i < num / 2; i++, j--)
// {
//     array_new[i] = array[i] * array[j];//array[^(i+1)], array[array.Length - 1 - i]
//     Console.Write(array_new[i] + " ");
// }



// Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. 
// Младший разряд числа должен располагаться на 0-м индексе массива, старший – на 2-м. 

// Пример

// 456  =>  [6 5 4]
// 781  =>  [1 8 7]

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[3];

if (num > 99 && num < 1000)
{
    for(int i = 0; i < 3; i++)
    {
        array[i] = num % 10;
        num /=10;
        Console.Write(array[i] + " ");
    }  
}
else 
{
    Console.Write("Вы ввели не трёхзначное число");
}