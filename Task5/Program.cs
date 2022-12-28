/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int getNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && (result > 0))
        {
            break;
        }
        else
        {
            Console.WriteLine($"Введено неверное число, повторить ввод");
        }
    }
    return result;
}

int[,] InitArray(int m, int n)
{
    int count = 1;
    int a = 0;
    int b = 0;
    int c = 0;
    int d = 0;
    int e = 0;
    int[,] array = new int[m, n];


    while (count < array.GetLength(0) * array.GetLength(0) + 1)
    {
        for (c = d; c < array.GetLength(0) - a; c++)//вправо
        {
            array[b, c] = count++;
        }
        --c;
        for (b = 1 + a; b < array.GetLength(0) - a; b++)//вниз
        {
            array[b, c] = count++;
        }
        --b;
        d = --c;
        for (c = d; c > -1 + a; c--)//влево
        {
            array[b, c] = count++;
        }
        e = --b;
        d = ++c;
        a++;
        for (b = e; b > -1 + a; b--)//вверх
        {
            array[b, c] = count++;
        }
        d = ++c;
        e = ++b;
    }
    return array;
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

int m = getNumber("Введите количество строк: ");
int n = getNumber("Введите количество столбцов: ");
int[,] array = InitArray(m, n);
PrintArray(array);