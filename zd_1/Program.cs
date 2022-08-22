/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8*/


int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random random = new Random();

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

int[,] SortRow(int[,] array, int rowNum)
{
    int temp;
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int i = 1; i < array.GetLength(1); i++)
        {
            if (array[rowNum, i] < array[rowNum, i - 1])
            {
                temp = array[rowNum, i];
                array[rowNum, i] = array[rowNum, i - 1];
                array[rowNum, i - 1] = temp;
            }
        }
    }
    return array;
}

Console.WriteLine("Введите максимальное количество столбцов и строк в массиве:");
int maxSize = int.Parse(Console.ReadLine());
int maxRow = maxSize;
int maxCol = maxSize;

int[,] array = GetArray(maxRow, maxCol);

PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    array = SortRow(array, i);
}
Console.WriteLine("Отсортированные строки ");
PrintArray(array);