void Palindrom(int num)
{
    if (num < 10000 || num > 99999)
    {
        System.Console.WriteLine("Это не пятизначное число");
    }
    else
    {
        string num1 = Convert.ToString(num);
        if (num1[0] == num1[4] && num1[1] == num1[3])
        {
            System.Console.WriteLine("да");
        }
        else 
        {
            System.Console.WriteLine("нет");
        }
    }
}



System.Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Palindrom(number);
