/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
Cij​ = Ai1 *​ B1j​ + Ai2 * ​B2j​+...+ Ain​ * Bnj​
 */

int[,] MultiMatrix (int[,] Matrix1, int[,] Matrix2)
{
    int Row1 = Matrix1.GetLength(0);
    int Colomn1 = Matrix1.GetLength(1);
    int Row2 = Matrix2.GetLength(0);
    int Colomn2 = Matrix2.GetLength(1);
    int[,] resultMatrix = new int[Row1,Colomn2];
    if (Colomn1 == Row2)
    {
        for (int i = 0; i < Row1; i++)
        {
            for (int j = 0; j < Colomn2; j++)
            {
                resultMatrix[i,j] = 0;
                for (int k=0; k < Colomn1; k++)
                {
                    resultMatrix[i, j] += Matrix1[i, k] * Matrix2[k, j];
                }
            }
        }
        return resultMatrix;
    }
    else
    {
        Console.WriteLine("Такие матрицы не пригодны для умножения");
        return resultMatrix;
    }
}

void PrintArray(int[,] array)
{   
    int row = array.GetLength(0);
    int colomns = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomns; j++)
        {   
            Console.Write("| "+array[i,j]+" |");  
        }
        Console.WriteLine(  );
    }
}

int[,] matrix1 = new int[,] 
{
    {8,5},      
    {4,6},
};
int[,] matrix2 = new int[,] 
{
    {6,2},
    {5,2},
};
Console.WriteLine("Перемножим матрицы");
Console.WriteLine();
Console.WriteLine("Матрица 1: ");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица 2: ");
PrintArray(matrix2);
Console.WriteLine();
int[,] result = MultiMatrix(matrix1,matrix2);
Console.WriteLine("Результирующая матрица:");
PrintArray(result);
