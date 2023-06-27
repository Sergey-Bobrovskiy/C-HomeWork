void TableOfCubes(int num)
{
    for (int i = 1; i < num+1; i++)
    {
        System.Console.WriteLine(Math.Pow(i,3));
    }
}


System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

TableOfCubes(number);
