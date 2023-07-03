int Pow(int A, int B)   
{
    int power = 1;
    for (int i = 0; i < B; i++)
    {
        power *= A;
    }
    return power;
} 


Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {numberA} в степени {numberB} = {Pow(numberA, numberB)}");
