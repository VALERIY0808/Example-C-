// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
int Method(int x,int y)
{
    if (y == x*x)
    {
        Console.WriteLine($"Число {y} является квадратом числа {x}");
    }
    else
    {
        Console.WriteLine($"Число {y}  не является квадратом числа {x}");
    }
    return y;
}
Console.WriteLine("Введите первое число");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondnumber = Convert.ToInt32(Console.ReadLine());
int contr = Method(firstnumber,secondnumber);
