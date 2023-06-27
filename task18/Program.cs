void PrintRange(int x)
{
    if (x == 1)
    {
        System.Console.WriteLine("Диапазон возможных координат: x > 0, y > 0");

    }
    else if (x == 2)
    {
        System.Console.WriteLine("Диапазон возможных координат: x < 0, y > 0");    
    }
    else if (x == 3)
    {
        System.Console.WriteLine("Диапазон возможных координат: x < 0, y < 0");    
    }
    else
    {
        System.Console.WriteLine("Диапазон возможных координат: x > 0, y < 0");
    }
}



System.Console.Write("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());


PrintRange(x);