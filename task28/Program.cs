int Composition(int num)
{
    int comp = 1;
    for (int i = 1; i <= num; i++)
    {
        comp*=i;
    }
    return comp;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());   
System.Console.WriteLine($"Произведение чисел от 1 до {number} = {Composition(number)}");
