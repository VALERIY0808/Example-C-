// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

int Method(int x,int y)
{
    int a = x % y ;
    return a
}

int firstnumber = Convert.ToInt32(Console.ReadLine());
int secondnumber = Convert.ToInt32(Console.ReadLine());
int contr = Method(firstnumber,secondnumber);
if contr == 0
{
    Console.WriteLine("Кратно");
} 
else 
{
    Console.WriteLine($"Не кратно остаток = {contr}")
}

Console.WriteLine($"Первое число {firstnumber} Второе число {secondnumber}");