// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine()); 
// string num1 = Convert.ToString(number);
// Console.WriteLine(num1.Length);

int CountingDigit(int num)
{
    int count = 0;
    while ( num > 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (CountingDigit(number) == 0)
{
    System.Console.WriteLine("1");
}
else
{
    System.Console.WriteLine(CountingDigit(number));
}