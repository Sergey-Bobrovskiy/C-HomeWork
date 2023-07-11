﻿void FillMatrixWithRandom(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0, 10);
        }
    }
}

void PrintMatrix( int[,] matrix)
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


int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);

for (int j = 0; j < matrix.GetLength(1); j++)
{   
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum+= matrix[i,j];
    }
    System.Console.Write($"{sum} ");
}
