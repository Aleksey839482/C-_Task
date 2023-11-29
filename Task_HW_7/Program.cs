// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Пример:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("--------------Задача 1------------------");


Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int Function(int numberM, int numberN)
{
    if(numberM == numberN)
    {
        return numberN;
    }
    Console.Write(numberM + " ");
    return Function(numberM + 1, numberN);

}

Console.WriteLine (Function(numberM, numberN));



Console.WriteLine("--------------Задача 2------------------");


// // Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

// // Пример:
// // m = 2, n = 3 -> A(m,n) = 9

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    if(m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine(Akkerman(m, n));



Console.WriteLine("--------------Задача 3------------------");




// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] array = {1, 4, 5, 2, 6, 21, 45};
int i = array.Length - 1;

int Reverce(int i, int[] array)
{
    if(i == 0)
    {
        return array[0];
    }
    Console.Write(array[i] + ", ");
    return Reverce(i - 1, array);
}

Console.WriteLine($"{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}");
Console.Write(Reverce(i, array));