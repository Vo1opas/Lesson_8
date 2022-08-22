/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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

int RowSum(int[,] array, int rowNum)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {

        sum += array[rowNum, i];
    }

    return sum;
}

Console.WriteLine("Введите максимальное количество столбцов и строк в массиве:");
int maxSize = int.Parse(Console.ReadLine());
int maxRow = maxSize;
int maxCol = maxSize;

int[,] array = GetArray(maxRow, maxCol);

PrintArray(array);
int minSum = RowSum(array, 0);
int curSum;
int minSumRow = 0;
for (int i = 1; i < array.GetLength(0); i++)
{
    curSum = RowSum(array, i);
    if (curSum < minSum)
    {
        minSum = curSum;
        minSumRow = i;
    }
}
Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (minSumRow + 1));
