System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <  100)
{
     System.Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number>999)
    {
        number /= 10;
    }
    System.Console.WriteLine($"Третья цифра числа {number%10}");
}