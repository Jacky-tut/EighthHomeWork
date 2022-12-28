/* .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
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

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] InitArray(int firstDimension, int secondDimension, int thirdDimension)
{
    Random rnd = new Random();
    char[] numbers = new char[90];
    int[,,] array = new int[firstDimension, secondDimension, thirdDimension];
    int number = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (true)
                {
                    number = rnd.Next(10, 100);
                    if (numbers[number - 10] != '*')
                    {
                        numbers[number - 10] = '*';
                        break;
                    }

                }
                array[i, j, k] = number;
            }
        }
    }
    return array;
}

int firstNumbers = GetNumber("Введите первую размерность массива");
int secondNumbers = GetNumber("Введите вторую размерность массива");
int thirdNumbers = GetNumber("Введите третью размерность массива");
int [,,] array = InitArray(firstNumbers, secondNumbers, thirdNumbers);
PrintArray(array);
