//Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

//Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

// Console.WriteLine("Введите целое число N: ");
// string strN = Console.ReadLine();
// int number = Convert.ToInt32(strN);
// for(int N = -number; N <= number; N++)
// {
//     Console.Write(N + " ");
// }

Console.WriteLine("Введите трёхзначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int lastnumber = number % 10;
    Console.Write(lastnumber);
}
else 
{
    Console.WriteLine("Введённое число не трёхзначное, введите корректное число");
}