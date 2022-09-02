// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] quadro = new int[4,4];
int num = 1;
int i =0;
int j =0;

while(num <= 16)  // 4*4    GetLength(0)-1 = 3   GetLength(1)-1 = 3
{
    quadro[i, j] = num;
    num++;
    if(i <= j + 1 && j + i < 3) j++;                // j == 3
    
    else if(i < j && i + j >= 3) i++;                // i == 3
    
    else if(i >= j && j + i > 3) j--;               
    
    else i--;
}

void PrintQuadro(int[,] quadro)
{
    for(int x = 0; x < 4; x++)
    {
        for(int y = 0; y < 4; y++)
        {
            Console.Write($"{quadro[x, y]} ");
        }
        Console.WriteLine();
    }
}


// FillQuadro(i, j);
PrintQuadro(quadro);