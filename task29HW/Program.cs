int[] GenerateArray(int len, int min, int max)
{
    int[] array = new int[len];
    Random random = new Random();
    for (int i =0; i < len; i++)
    {
        array[i] = random.Next(min, max);  
        Console.Write($"{array[i]}  "); 
    }
    return array;
}




Console.WriteLine("Введите длинну массива");
int length= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное значение диапазона ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = GenerateArray(length, min, max);    