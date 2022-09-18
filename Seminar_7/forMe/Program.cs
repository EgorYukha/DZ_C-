//1. Задайте двумерный массив [МхН] заполненный случайными целыми числами

// int stringCount = Convert.ToInt32(Console.ReadLine());
// int columsCount = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[stringCount,columsCount];
// Random rnd = new Random();
// for(int i = 0; i < stringCount; i++)
// {
//     for(int j = 0; j < columsCount; j++ )
//     {
//         array[i,j] = rnd.Next(1,100);
//         Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
// }

//Задача 2. Задайте двумерный массив. Найдите элементы у которых оба индекса 
//четные и замените их элемены на их квадраты.


// int stringCount = Convert.ToInt32(Console.ReadLine());
// int columsCount = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[stringCount,columsCount];
// Random rnd = new Random();

// for(int i = 0; i < stringCount; i++)
// {
//     for(int j = 0; j < columsCount; j++ )
//     {
//         array[i,j] = rnd.Next(1,10);
//         Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// for(int i = 0; i < stringCount; i++)
// {
//     for(int j = 0; j < columsCount; j++ )
//     {
//         if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
//         {
//             array[i,j] = array[i,j] * array[i,j];
//         Console.WriteLine(array[i,j] + " ");
//         }
//     }
//     Console.WriteLine();
// }


//Version 2.1



// for(int i = 0; i < 4; i++)
// {
//     for(int j = 0; i < 4; j++)
//     {
//         if(i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
//             arr[i,j] = arr[i,j] * arr[i,j];
//         Console.WriteLine(arr[i,j] + " ");
//     }
//     Console.WriteLine();
// }

//Правильный вариант:

int[,] arr = new int[4,4];
Random rnd = new Random();

for(int i = 0; i < 4; i++)
{
    for(int j = 0; j < 4; j++ )
    {
        arr[i,j] = rnd.Next(1,9);
        Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for(int i = 0; i < 4; i++)
{
    for(int j = 0; j < 4; j++)
    {
        if(i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
        {
            arr[i,j] = arr[i,j] * arr[i,j];
        }
        Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
}
