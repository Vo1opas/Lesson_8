/* Задача 62: Заполните спирально массив 4 на 4.
 1 2 3 4
 12 13 14 5
 11 16 15 6
 10 9 8 7
*/

int maxSize = 4;
int maxRow = maxSize;
int maxCol = maxSize;


int[,] GetSpiralArray(int maxRow, int maxCol)
{
    int[,] array = new int[maxRow, maxCol];

    int colStep = 0;
    int rowStep = 0;
    int row = 0;
    int col = 0;
    int minCol = 0;
    int minRow = 0;
    maxRow--;
    maxCol--;

    for (int i = 1; i <= array.GetLength(0) * array.GetLength(0); i++)
    {

        if (col != maxCol && row == minRow)
        {
            colStep = 1;
            rowStep = 0;
        }


        if (col == maxCol && row != maxRow)
        {
            colStep = 0;
            rowStep = 1;
        }


        if (col != minCol && row == maxRow)
        {
            colStep = -1;
            rowStep = 0;
        }


        if (col == minCol && row != minRow)
        {
            colStep = 0;
            rowStep = -1;
        }


        if (col == maxCol && row == minRow)
        {
            if (col != (array.GetLength(0) - 1) || row != 0)
            {
                minCol++;
            }
        }
        if (col == maxCol && row == maxRow)
        {
            minRow++;
        }
        if (col == minCol && row == maxRow)
        {
            maxCol--;
        }
        if (col == minCol && row == minRow)
        {
            if (!(col == 0 && minRow == 0))
            {
                maxRow--;
            }
        }

        array[row, col] = i;

        row += rowStep;
        col += colStep;
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
int[,] array = GetSpiralArray(maxRow, maxCol);
PrintArray(array);