// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int[,] array = new int[3, 5];
Random rnd = new Random();
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int min = array[i, j];



            Console.Write(" " + array[i, j]);
        }
        Console.WriteLine(string.Empty);
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine(string.Empty);

void SortOfRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                int nextValue = array[i, k];
                if (array[i, k] > array[i, j])
                {
                    array[i, k] = array[i, j];
                    array[i, j] = nextValue;
                }
            }
        }
    }
    Console.WriteLine(string.Empty);

}
SortOfRows(array);
PrintArray(array);
Console.WriteLine(string.Empty);