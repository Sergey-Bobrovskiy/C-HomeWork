int SumDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result+=number % 10;
        number = number / 10;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number} равна {SumDigit(number)}");