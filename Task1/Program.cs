// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
// на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
// 1. На вход принимать число
// 2. Посчитать квадрат числа
// 3. Вывод числа
Console.WriteLine("Введите число: ");
string strNumber = Console.ReadLine();    // "123" + "123" = "123123"     // 123 + 123 = 246 // Переводит строки в число
int number = Convert.ToInt32(strNumber);          //Console.ReadLine();
number = number * number; // number = 5 * 5
Console.WriteLine(number);
Console.WriteLine("Квадрат от введенного Вами числа " + strNumber + " будет " + number);
Console.WriteLine($"Квадрат от введенного Вами числа {strNumber} будет {number}");
Console.WriteLine("Квадрат от введенного Вами числа {0} будет {1}", strNumber, number);