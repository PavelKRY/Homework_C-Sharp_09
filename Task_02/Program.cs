//  Напишите программу, которая спирально заполнит числами от 1 до 16 двумерный массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] array = new int[4, 4];
int diggit = 0;
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == array.GetLength(0) - array.GetLength(1))
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = diggit++;

                if (j == array.GetLength(1) - 1)
                {
                    for (int k = i + 1; k < array.GetLength(0); k++)
                    {
                        array[k, j] = diggit++;
                    }
                }
            }

        }
    }
    for (int i = array.GetLength(0) - 1; i >= 0; i--)
    {
        if (i == array.GetLength(0) - 1)
        {
            for (int j = array.GetLength(1) - 2; j >= 0; j--)
            {
                array[i, j] = diggit++;
                if (j == array.GetLength(0) - array.GetLength(1))
                {
                    for (int k = i - 1; k > 0; k--)
                    {
                        array[k, j] = diggit++;
                    }
                }
            }
        }
    }
    for (int i = 1; i < array.GetLength(0) - 1; i++)
    {
        if (i == array.GetLength(1) - 3)
        {
            for (int j = 1; j < array.GetLength(1) - 1; j++)
            {
                {
                    array[i, j] = diggit++;
                    if (j == array.GetLength(0) - 2)
                    {
                        int k = array.GetLength(0) - 2;
                        for (int l = j; l > 0; l--)
                        {
                            array[k, l] = diggit++;
                        }
                    }
                }

            }
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("\t" + "0" + array[i, j]);
            }
            else
            {
                Console.Write("\t" + array[i, j]);
            }
        }
        Console.WriteLine(string.Empty);
    }
}

FillArray(array);
PrintArray(array);
