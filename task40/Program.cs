void Teorem( int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        System.Console.WriteLine("Да это стороны треугольника");
    }
    else
    {
        System.Console.WriteLine("Нет это не треугольник");
    }
}



System.Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());
Teorem(A, B, C);