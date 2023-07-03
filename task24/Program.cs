int Sum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum+=i;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());   
System.Console.WriteLine($"Сумма чисел от 1 до {number} = {Sum(number)}");
