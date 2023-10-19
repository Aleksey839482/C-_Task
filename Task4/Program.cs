// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8


// 1. Получение случайного числа
// 2. Определить наибольшую цифру в числе
// 3. Вывести данную цифру

// Random generateNumber = new Random();

int number = new Random().Next(10, 100); //[10, 99] правая граница не включается
Console.WriteLine(number);
int a = number / 10; //(75 / 10 = 7(5))
int b = number % 10; //(75 % 10 = 5(7))

if (a > b)
{
    Console.WriteLine("a > b, " + a);
}
else if (b > a)
{
    Console.WriteLine("b > a, " + b);
}
else 
{
    Console.WriteLine("Числа равны между собой");
}