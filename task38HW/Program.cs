// double[] FillArray(int size)
// {
//     double[] arr = new double[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.NextDouble() + rnd.Next;
//     }
//     return arr;
// }
int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,100000);
    }
    return arr;
}

System.Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length);
System.Console.WriteLine(string.Join("; ", array));

int min = array[1];
int max = array[1];
for (int i = 2; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    if (array[i] > max)
    {
        max  = array[i];
    }
}

System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max-min}");

