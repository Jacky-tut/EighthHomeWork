/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int GetMinSumString(int[,] matrix)
{
    int min = 0;
    int minSum = 100;
    int minString = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        min = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            min += matrix[i, j];
        }
        if (min < minSum)
        {
            minSum = min;
            minString = i;
        }
    }
    return minString + 1;
}

int numberRows = GetNumber("Введите количество строк");
int numberColumns = GetNumber("Введите количество столбцов");
int [,] matrix = InitMatrix(numberRows, numberColumns);
PrintArray(matrix);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {GetMinSumString(matrix)}");

