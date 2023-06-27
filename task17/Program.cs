void PrintQuater(int x, int y)
{
    if (x > 0 && y > 0)
    {
        System.Console.WriteLine("Точка располагается в первой четверти");

    }
    else if (x < 0 && y > 0)
    {
        System.Console.WriteLine("Точка располагается во второй четверти");    
    }
    else if (x < 0 && y < 0)
    {
        System.Console.WriteLine("Точка располагается в третьей четверти");    
    }
    else
    {
        System.Console.WriteLine("Точка располагается в четвертой четверти");
    }
}



System.Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

PrintQuater(x, y);
