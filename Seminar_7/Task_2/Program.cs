// Задача 2. Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите номер строки массива: ");
int stringCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца массива: ");
int columsCount = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[5,5];

if(stringCount > array.GetLength(0) || columsCount > array.GetLength(1))
{
    Console.WriteLine($"{stringCount}{columsCount} -> такого значения нет");
}
else
{
    Console.WriteLine($"Значение элемента {stringCount} строки и {columsCount} столбца =  {array[stringCount-1,columsCount-1]}");
}

Random rnd = new Random();
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = rnd.Next(1,10);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
