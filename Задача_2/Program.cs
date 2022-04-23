// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите необходимое число");
int Func(int x)
{
    int a = x / 10;
    int b = a % 10;
    return b;
}
int number = Convert.ToInt32(Console.ReadLine());
if (number>99)
{   
    if (number>999)
    {
        Console.WriteLine("Число не является трехзначным");
    }
    else
    {
        int contr = Func(number);
        Console.WriteLine($"Вторая цифра числа = {contr}");
    }
}
else
{
     Console.WriteLine("Число не является трехзначным");
}


