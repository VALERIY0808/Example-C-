// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
int size = Convert.ToInt32(Console.ReadLine());

int Methodnewarr(int x)
{
    int [] arr = new int [x];
    int res = 0;
    
    for (int i = 0;i<x;i++)
    {
        arr[i] = new Random().Next(100,999);
        if (arr[i] % 2 ==0)
        {
             res++;
        }
        Console.WriteLine(arr[i]);
    }
    return res;
}
int contr = Methodnewarr(size);
Console.WriteLine($"Количество четных чисел в массиве = {contr}");
