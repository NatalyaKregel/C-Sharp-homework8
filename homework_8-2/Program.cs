/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка */

Console.Write("ВВедите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FindMinSumRow(matrix);

// Метод заполнения массива случайными числами
void FillArray(int[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(10, 21);
        }
    }
}

// Метод вывода массива на печать 
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"| " + matrix[i, j] + "|");
            Console.Write("  ");
        }
        Console.WriteLine();
    }
}

//Метод нахождения минимальной суммы

/*  void MinSumRow(int[,] matrix, int i)
{
    int MinSumRow= 0;
    int Sum = SumElemRow(matrix,0);
    for (int k = 1; k < n; k++)
    {
        int tempMinSumRow = SumElemRow(matrix,k);
        if (Sum>tempMinSumRow)
        {
            Sum = tempMinSumRow;
            MinSumRow = k;
        }
    } 
    Console.WriteLine ($"Минимальная сумма в строке " + " = " + MinSumRow);


}*/ 

void FindMinSumRow(int[,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    int[] sumRow = new int[m];
    for(int index = 0; index < m; index++)
    {   
        for (int i = 0; i < n; i++) 
        {
            sumRow[index] += matrix[index,i];
        }
    }
    
    int k = 0;
    for (int i = 0; i < m; i++) 
    {   
        int min = sumRow[0];
        
        if(sumRow[i]<min) 
        {
            min = sumRow[i];
            k = i;
        }

    }
    Console.WriteLine($"Наименьшая сумма элементов находится в {k+1} строке, (индекс строки = {k})");
}
