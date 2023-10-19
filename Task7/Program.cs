// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// Console.Write("Введите Number1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Number2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int result = number1 % number2;
// if (result == 0)
// {
//     Console.WriteLine("Первое число кратно второму");
// }
// else
// {
//     Console.WriteLine("Первое число не кратно второму, остаток: " + result);
// }

//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}