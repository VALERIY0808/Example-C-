// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
int Method(int x)
{
    if (x % 7 ==0)
    {
        if (x % 23 == 0)
        {
            Console.WriteLine($"Число {x} кратно 23 и 7 одновременно");
        }
        else
        {
            Console.WriteLine($"Число {x}  не кратно 23 и 7 одновременно");
        }
    }   
    else
    {
    Console.WriteLine($"Число {x}  не кратно 23 и 7 одновременно");
    }
    return x;
}
Console.WriteLine("Введите число для проверки");
int number = Convert.ToInt32(Console.ReadLine());
int contr = Method(number);
