// Задача 1. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк массива: ");
int stringCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columsCount = Convert.ToInt32(Console.ReadLine());

//Создание и заполение массива
double[,] array = new double[stringCount,columsCount];
Random rnd = new Random();
for(int i = 0; i < stringCount; i++)
{
    for(int j = 0; j < columsCount; j++)
    {
        array[i,j] = rnd.NextDouble() * 20 -10;
        //Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
// округление числа
for(int i = 0; i < stringCount; i++)
{
    for(int j = 0; j < columsCount; j++)
    {
        double roundingNumder = Math.Round(array[i,j],1);
        Console.Write(roundingNumder + " ");
    }
    Console.WriteLine();
}