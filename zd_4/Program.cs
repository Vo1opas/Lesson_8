/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1) */



int maxSize = 2;
int maxRow = maxSize;
int maxCol = maxSize;
int maxDeep = maxSize;
int[] numbers = new int[maxSize * maxSize * maxSize];

int[] fillUniqueNum(int[] numbers)
{
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        numbers[i] = 10 + i;
    }
    return numbers;
}

int[,,] GetArray(int row, int col, int deep, int[] numbers)
{
    int[,,] array = new int[row, col, deep];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1);j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                // что бы получить неповторяемое число по порядку из массива numbers = row * 2 + col * 1 + deep * 4
                array[i, j, k] = numbers[i * 2 + j + k * 4];
            }
        }
    }
    return array;
}

void PrintArrayWithKeys(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0}({1},{2},{3}) ", array[i, j, k], i, j, k);
            }
            Console.WriteLine("");
        }
        Console.WriteLine("---");
    }
}

numbers = fillUniqueNum(numbers);
int[,,] array = GetArray(maxRow, maxCol,maxDeep, numbers);
PrintArrayWithKeys(array);