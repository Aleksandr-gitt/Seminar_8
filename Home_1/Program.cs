// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] FillArray = new int [4,5];

for(int i = 0; i < FillArray.GetLength(0); i++)
{
    for(int j = 0; j < FillArray.GetLength(1); j++)
    {
        FillArray[i, j] = new Random().Next(1,10);
        Console.Write($"{FillArray[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for(int x = 0; x < FillArray.GetLength(0); x++)
{
    for(int i = 0; i < FillArray.GetLength(0); i++)
    {
        for(int j = 0; j < FillArray.GetLength(1)-1 ; j++)
        {           
            if(FillArray[i, j] < FillArray[i, j + 1])
            {
            int temp = FillArray[i, j + 1];
            FillArray[i, j + 1] = FillArray[i, j];
            FillArray[i, j] = temp;
            }
        } 
    }
}
for(int i = 0; i < FillArray.GetLength(0); i++)
{
    for(int j = 0; j < FillArray.GetLength(1); j++)
    {
        
        Console.Write($"{FillArray[i, j]} ");
    }
    Console.WriteLine();
}   