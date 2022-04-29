// Напишите программу, которая принимает на вход отрицательное четырехзначное число 
// и на выходе показывает вторую цифру этого числа.
int Method(int x)
{
    if (x<0)
    {
        if (x<-999)
        {
            if (x>-9999)
            {
                x = x/100;
                x = x % 10;
                x = -x;
                return x;
            }
            else
            {
                Console.WriteLine($"Число {x} не подходит условию");
                return x;
            }
        }
        else
        {
            Console.WriteLine($"Число {x} не подходит условию");
            return x;
        }
    }
    else
    {
        Console.WriteLine($"Число {x} не подходит условию");
        return x;
    }
    
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int contr = Method(number);
Console.WriteLine($"Вторая цифра числа {number} =  {contr}");