/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
 */

int[] CreateArrayRandomizer(int min, int max)
{
    Random randomizer = new Random();
    int size  = max - min;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        var num = randomizer.Next(min, max);
        if (array.Contains(num)) i--;
        else array[i] = num;
    }
    return array;
}

int[, ,] FillArray(int[, ,] emptyArray, int[] random)
{
    int x = emptyArray.GetLength(0);
    int y = emptyArray.GetLength(1);
    int z = emptyArray.GetLength(2);
    int n = 0;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {   
            for (int k = 0; k < z; k++)
            {
               emptyArray[i,j,k] = random[n];
               n++; 
            }
        }
    }
    return emptyArray;
}

void PrintArray(int[, ,] array)
{   
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int z = array.GetLength(2);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {   
            for (int k = 0; k < z; k++)
            {
               Console.Write(" | "+array[i,j,k]+$" |({j},{k},{i}) ");  
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите размерность массива через запятую:");
int[] sizeMatrix = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
int x = sizeMatrix[0];
int y = sizeMatrix[1];
int z = sizeMatrix[2];
int[, ,] emptyArray = new int[x,y,z];

Console.WriteLine("Введите диапазон генерируемых чисел через дефис (10-100):");
int[] rangeRand = Array.ConvertAll(Console.ReadLine().Split("-"), int.Parse);
int min = rangeRand[0];
int max = rangeRand[1]-1;

if ((max - min) < x*y*z)
{
    Console.WriteLine("Диапазон чисел меньше чем, размерность массива");
}
else
{
    int[] arrayRandomizer = CreateArrayRandomizer(min, max);
    int[, ,] fullArray = FillArray(emptyArray,arrayRandomizer);
    PrintArray(fullArray);
} 
