// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Сумма произведений Строка на столбец 


int[,] matrix1 = new int[2,2];
int[,] matrix2 = new int[2,2];
int[,] matrix3 = new int[2,2];

for(int i = 0; i < matrix1.GetLength(0); i++)
{
    for(int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i,j] = new Random().Next(1,5);
        Console.Write($"{matrix1[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for(int m = 0; m < matrix2.GetLength(0); m++)
{
    for(int n = 0; n < matrix2.GetLength(1); n++)
    {
        matrix2[m,n] = new Random().Next(1,5);
        Console.Write($"{matrix2[m,n]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for(int k = 0; k < matrix3.GetLength(0); k++)
{
    for(int l = 0; l < matrix3.GetLength(1); l++)
    {
        int sum = 0;
        for(int x = 0; x < matrix1.GetLength(1); x++)
        {
            sum = sum + matrix1[k, x] * matrix2[x, l];
        }
        matrix3[k,l] = sum;
        Console.Write($"{matrix3[k,l]} ");
    }
    Console.WriteLine();
}