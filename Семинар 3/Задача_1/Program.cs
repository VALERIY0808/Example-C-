// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int Method(int x,int y)
{
    if (x==0 | y==0)
    {
        Console.WriteLine("Координата точки = 0 ");
        return x;
    } 
    else
    {
        if (x>0)
        {
            if (y>0)
            {
                Console.WriteLine("Точка находится в 1 четверти");
                return x;
            }
            else
            {
                Console.WriteLine("Точка находится в 4 четверти");
                return x;
            }

        }
        else
        {
            if (y>0)
            {
                Console.WriteLine("Точка находится в 2 четверти");
                return x;
            }
            else
            {
                Console.WriteLine("Точка находится в 3 четверти");
                return x;
            }
        }
    }
}

Console.WriteLine("Введите первую координату заданнной точки");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую координату заданнной точки");
int b = Convert.ToInt32(Console.ReadLine());
int contr = Method(a,b);
