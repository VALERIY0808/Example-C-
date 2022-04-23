// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите необходимое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number>99)
{   
    if (number>999)
    {
        Console.WriteLine("Число не является трехзначным");
    }
    else
    {
        int a = number / 10;
        int b = a % 10;
        Console.WriteLine($"Вторая цифра числа = {b}");
    }
}
else
{
     Console.WriteLine("Число не является трехзначным");
}


