// Задайте одномерный массив, заполненый случайными числами.
// Определите количество простых чисел в этом массиве.

// Примеры

// [1 3 4 19 3] => 2
// [4 3 1 9 5 21 13] => 3

// 1. Задать одномерный массив
// 2. Определяем колчество простых чисел
// 3. Вывод

// Math.Pow();  // Степень
// Math.Sqrt(); // Корень

int[] GenerateArray () {
    int[] array = new int[8];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,11);
    }

    return array;
}
void PrintArray (int[] array) {  // просто выводит массив
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

bool IsSimple (int number) {
    for(int i = 2; i < number; i++)
    {
        if (number % i == 0 || number == 1)
        {
            return false;
        }
    }
    return true;
}

int CountSimpleNumber (int[] array){
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (IsSimple(array[i]))
        {
            count++;
        }
    }
    return count;
}

int[] newArray = GenerateArray();
PrintArray(newArray);
int count = CountSimpleNumber(newArray);
Console.WriteLine("Количство простых чисел: " + count);