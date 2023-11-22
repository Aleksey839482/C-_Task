// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

//1. Создание одномерного массива
//2. Вывод одномерного массива
//3. Переворот одномерного массива (reverse)

// int[] GenerateArray(int length)
// {
// int[] array = new int[length];
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = Convert.ToInt32(Console.ReadLine());
// }
// }

int[] GenerateArray()
{
Console.WriteLine("Введите числа через ,");
string input = Console.ReadLine(); //"12,24,35,46,13" => ["12", "24" , "35" , "46" , "13"] => [12, 24, 35, 46, 13]
string[] arrayNumbers = input.Split(",");
int[] numbers = new int[arrayNumbers.Length];
for (int i = 0; i < arrayNumbers.Length; i++)
{
numbers[i] = Convert.ToInt32(arrayNumbers[i]);
}
return numbers;
}

void PrintArray(int[] array)
{ //[12, 24, 35, 46, 13] => "12 24 35 46 13"
string str = String.Join(" ", array); //String.Join => Трансформирует массив в строку
Console.WriteLine(str);

foreach (int number in array)
{ //foreach - перебирает каждый элемент итерируемого объекта, в данном случае массив чисел - array
Console.Write(number + " ");
}
}

void ReverseArray(int[] array)
{
int temp;
int lastIndex = array.Length - 1;
for (int i = 0; i < array.Length / 2; i++)
{
temp = array[i];
array[i] = array[lastIndex - i];
array[lastIndex - i] = temp;
}
}

int[] array = GenerateArray();
PrintArray(array);
ReverseArray(array);
Console.WriteLine();
PrintArray(array);