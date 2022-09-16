/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки 
двумерного массива.
//Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */ 

Console.Write("ВВедите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
OrderingElements(matrix);
PrintArray(matrix);

// Метод заполнения массива случайными числами
void FillArray(int[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(11, 100);
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

//Метод упорядочения элементов строки по убыванию
void OrderingElements(int[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n-1; k++)
            {
                if (matrix[i,k]<matrix[i,k+1])
                {
                    int temp = matrix[i,k+1];
                    matrix[i,k+1]=matrix[i,k];
                    matrix[i,k]=temp;     
                }
            }
        }
    }
    return;
}


