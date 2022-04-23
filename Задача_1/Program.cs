// Напишите метод, который выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int GetNumber (int value);{
Console.WriteLine("Вводим случайного числа");
int value = new Random().Next(10,100);
int a = value / 10;
int b = value % 10;
// System.Console.WriteLine($"value = {value} a:{a} b:{b}");
int max = a;
 if (b>max) max=b;
 return max;
 }
