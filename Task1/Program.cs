/* Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i,j] = rnd.Next(1,10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] GetnewMatrix(int[,] matrix)
{
    int max = 0;
    int count = 0;
    int sortCount = 0;
    int tmp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sortCount = 0;
        while (sortCount < matrix.GetLength(1))
        {
            max = 0;
            for (int j = sortCount; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    count = j;
                }
            }
            tmp = matrix[i, count];
            matrix[i, count] = matrix[i, sortCount];
            matrix[i, sortCount] = tmp;
            sortCount++;
        }
    }
    return matrix;
}

int numberRows = GetNumber("Введите количество строк");
int numberColumns = GetNumber("Введите количество столбцов");
int [,] matrix = InitMatrix(numberRows, numberColumns);
PrintArray(matrix);
int[,] newMatrix = GetnewMatrix(matrix);
PrintArray(newMatrix);