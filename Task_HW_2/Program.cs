//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите число трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int numberA = number / 10;
// if (number > 99 && number < 1000)
// {
//     Console.WriteLine(numberA % 10);
// }
// else
// {
//     Console.WriteLine("Введенное число не трёхзначное");
// }




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//     }
// else
// {
//     int result(int number)
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;
// }
// Console.WriteLine(result(number));
// }





// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 8)
{
    if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
    {
        Console.WriteLine("Нет, это будний день");
    }
    else
    {
        Console.WriteLine("Да, это выходной");
    }
}
else
{
    Console.WriteLine("Такого дня не существует");
}