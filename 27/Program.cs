int Number(string message)
{
    int number = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out number))
        {break;
        }
        else
        {
            Console.WriteLine("Ввели не число или некорректное число. Повторите ввод");
        }
    }
    return number;
}
int number = Number("Введите число больше 0");
int sum = 0;

while (number != 0)
{          
    sum = sum+number%10;
    number = number/10;
}
Console.WriteLine($"сумма цифр в числе равно {sum}");
