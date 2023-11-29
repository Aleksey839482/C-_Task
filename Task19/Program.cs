// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// Указание
// Использовать рекурсию. Не использовать цикл.

// Пример
// N=5 => 1 2 3 4 5

// Console.Write("Введите число N: ");

// Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

void NatNumbers(int number)
{
    if(number == 0)
    {
        return;
    }
    // number = number - 1;
    NatNumbers(number);
    Console.Write(number - 1);
}
NatNumbers(number);
// NatNumbers(number + 1);