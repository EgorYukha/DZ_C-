// Задача 1: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
// суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Номер строки с наименьшей суммой элементов: 1 строка

int[,] array = new int[4, 4];
FillArrayRandom(array);
PrintArray(array);
Console.WriteLine();
stringMinElement(array);


void stringMinElement(int[,] array)
{
    int minString = 0;
    int minStringSum = 0;
    int sumString = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minString
         += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumString += array[i, j];
        if (sumString < minString
        )
        {
            minString
             = sumString;
            minStringSum = i;
        }
        sumString = 0;
    }
    Console.Write($"{minStringSum + 1} строка");
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
