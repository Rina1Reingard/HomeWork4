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

int a = Number ("Введите первое число");
int b = Number ("Введите второе число");
int result = a;

for (int i = 1; i < b; i++)
{
    result = result*a;   
}
Console.Write($"{result}");