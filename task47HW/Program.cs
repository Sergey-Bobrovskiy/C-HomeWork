void FillMatrixWithRandom(double[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 10) + Math.Round(rnd.NextDouble(),2);
        }
    }
}

void PrintMatrix( double[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());  
System.Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine()); 

double[,] matrix = new double[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
