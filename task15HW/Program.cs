System.Console.Write("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7)
{
    System.Console.WriteLine("Это не день недели!");
}
else if (number >5)
{
    System.Console.WriteLine("да");
}
else System.Console.WriteLine("нет");
