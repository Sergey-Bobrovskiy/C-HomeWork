int SecondFigure(int num)
{
    int digit1=num / 100;
    int result =(num - digit1*100)/10;
    return result;
}

int number = new Random().Next(100, 1000);
System.Console.WriteLine($"Ваше случайное число: {number}");
System.Console.WriteLine($"Вторая цифра числа {number} - {SecondFigure(number)}");
