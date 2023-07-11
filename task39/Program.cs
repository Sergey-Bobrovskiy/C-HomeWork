
int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,10);
    }
    return arr;
}

int[] ReverseArray( int[] arr )
{
    int temp = 0;
    for (int i=0; i < arr.Length / 2;i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - i -1];
        arr[arr.Length - i -1] = temp;
    }
    return arr;
}

System.Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length);
System.Console.WriteLine(string.Join("; ", array));

System.Console.WriteLine(string.Join("; ", ReverseArray(array)));