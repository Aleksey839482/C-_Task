// Напишите программу, которая на вход принимает два числа А и В, и выводит число А в целую степень В с помощью рекурсии.

// Указание:
// Использовать рекусию.
// Не использовать цикл.

// Пример:

// А = 3; В = 5 -> 243(3^5)
// A = 2; B = 3 -> 8(2^3)


Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Function(int numberA, int numberB)
{
    if(numberB == 0)
    {
        return 1;
    }
    return numberA * Function(numberA, numberB - 1);

}

Console.WriteLine (Function(numberA, numberB));