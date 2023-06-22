Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB) 
{
Console.WriteLine($"Максимальное число {numberA}");
}
else if (numberA < numberB)
{
Console.WriteLine($"Максимальное число {numberB}");   
}
else 
{
Console.WriteLine("Числа равны");
}

