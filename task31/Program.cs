
int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9,10);
    }
    return arr;
}

System.Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length);
System.Console.WriteLine(string.Join("; ", array));

int sumP = 0;
int sumN = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i]>0)
    {
        sumP+=array[i];
    }
    else
    {
        sumN+=array[i];
    }
}
System.Console.WriteLine($"Сумма положительных = {sumP}, отрицательных = {sumN}");