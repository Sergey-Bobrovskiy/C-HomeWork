void GetBinaryView(int num)
{
    if(num ==0)
    {
        return;
    }
    GetBinaryView(num/2);
    System.Console.Write(num % 2);
}



System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
GetBinaryView(number);