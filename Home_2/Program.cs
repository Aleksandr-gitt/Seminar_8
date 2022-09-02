// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] FillArray = new int [4,3];

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

int[] SumRow = new int[FillArray.GetLength(0)];
for(int i = 0; i < FillArray.GetLength(0); i++)
{   
    int sum = 0;
    for (int j = 0; j <3; j++)
    {
        sum = sum + FillArray[i, j];
    }
    SumRow[i] = sum;
    // Console.WriteLine(sum);
}    
Console.WriteLine();

int MinRow = SumRow[0];
for(int i = 0; i < FillArray.GetLength(0); i++)
{
    if(MinRow > SumRow[i]) MinRow = SumRow[i];
}
// Console.WriteLine(MinRow);
int indRow = 0;
for(int i = 0; i < SumRow.GetLength(0); i++)
{
    if(MinRow == SumRow[i])  
    {
        indRow = i+1;
        break;
    }
}
Console.WriteLine($"1-я строка с минимальной суммой элементов - № {indRow}");
