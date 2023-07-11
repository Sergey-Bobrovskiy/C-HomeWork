void Fibbonachi(int n)
{
    System.Console.Write("0 1 ");
    int fib = 0; int fib1 =1;
    int res = 0;
    for (int i = 0; i < n-2; i++)
    {
        res = fib + fib1;
        System.Console.Write($"{res} ");
        fib = fib1;
        fib1 = res;

    }
}

System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Fibbonachi(N);
