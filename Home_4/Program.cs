// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// 1. Создаем массив с уник элементами
// 2. Закидываем его в трехмерный массив

int[,,] FillArray = new int [2,2,2];

int [] num = new int[8];  //FillArray.GetLength(0)*FillArray.GetLength(1)*FillArray.GetLength(2)
for(int i = 0; i < num.GetLength(0); i++)
{
    num[i] = new Random().Next(1,9); 
    for(int j = 0; j < i; j++)
    {
        while(num[j] == num[i]) 
        {
            num[i] = new Random().Next(1,9);
            j = 0;
        }
    }
    // Console.Write($"{num[i]} ");
}
// Console.WriteLine();
// Console.WriteLine();

int qwerty = 0;
for (int x = 0; x < FillArray.GetLength(0); x++)
{
    for (int y = 0; y < FillArray.GetLength(1); y++)
    {
        for (int z = 0; z < FillArray.GetLength(2); z++)
        {
            FillArray[x, y, z] = num[qwerty];
            qwerty = qwerty + 1;
            Console.Write($"{FillArray[x, y, z]}({x},{y},{z}) ");
        }
        Console.WriteLine();
    }
}    


    
    








