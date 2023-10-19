Console.WriteLine("Введите Number1: ");
string strNumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(strNumber1);
Console.WriteLine("Введите Number2: ");
string strNumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(strNumber2);
if (number1 == number2 * number2 || number2 == number1 * number1)
    {Console.WriteLine("Да");}
else
    {Console.WriteLine("Нет");}
