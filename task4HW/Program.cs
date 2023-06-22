Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB > max) 
{
max = numberB;
}
if (numberC > max)
{
Console.WriteLine($"Максимальное число {numberC}");   
}
else 
{
Console.WriteLine($"Максимальное число {max}");
}
