int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-100000,100000);
    }
    return arr;
}

System.Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length);
System.Console.WriteLine(string.Join("; ", array));

int sum = 0;
for (int i = 1; i < array.Length; i++)
{
    sum += array[i];
    i++;
}
System.Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");