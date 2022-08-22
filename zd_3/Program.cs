/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

и

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10

20 81 8 6

56 8 4 24

10 6 24 49 */

int[,] GetArray(int row, int col, Random random)
{
    int[,] array = new int[row, col];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyArray(int[,] arr1, int[,] arr2)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            arr1[i, j] = arr1[i, j] * arr2[i, j];
        }

    }

    return arr1;
}


Console.WriteLine("Введите максимальное количество столбцов и строк в массиве: ");
int maxSize = int.Parse(Console.ReadLine());
int maxRow = maxSize;
int maxCol = maxSize;

Random random = new Random();

int[,] array1 = GetArray(maxRow, maxCol, random);
int[,] array2 = GetArray(maxRow, maxCol, random);
Console.WriteLine("Массив №1: ");
PrintArray(array1);
Console.WriteLine("Массив №2: ");
PrintArray(array2);
Console.WriteLine("Их произведение будет равно следующему массиву: ");
PrintArray(MultiplyArray(array1, array2));