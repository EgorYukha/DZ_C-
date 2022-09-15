// int [,] matrix = new int [3, 4];
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.Write($"{matrix[i, j]}");
//     }
// Console.WriteLine();
// }


// int Ar(int N)
// {
//     int x = -N;
//     while (x < N)
//     {
//         Console.WriteLine(x);
//         x++;

//     }
//     return x;
// }


// Задайте массив из 5 элементов, заполненный случайными числами из промежутка [-9, 9]
// Найдите сумму положительных и отрицательный элементов массива. 

// int N = 5;
// int[] array = new int[N];
// for (int i = 0; i < N; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     Console.WriteLine( array[i]);
// }

// int negSum = 0;
// int posSum = 0;
// for (int i = 0; i < N; i++)
// {
//     if(array[i] < 0)
//     {
//         negSum = negSum + array[i];
//     }
//     else
//     {
//         posSum = posSum + array[i];
        
//     }
// }
// Console.WriteLine(negSum + " " + posSum);


//Задайте произвольный целочисленный массив. Напишите программу, которая определяет 
//присутствует ли заданное число пользователем в массиве.

// int N = 12;
// int[] numbers = new int[N];
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Random rnd = new Random();
// for (int i = 0; i < N; i++)
// {
//     numbers[i] = rnd.Next(-9, 9+1);
//     Console.Write(numbers[i]);
// }
// void task(int num)
// {
//     for (int i = 0; i < N; i++)
//     {
//         if(num == numbers[i])
//         {
//             Console.WriteLine($"Введеное число {num} совпадает с числом из массива");
//             break;
//         }
//     }
// }

// F. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[size];
// int min = 100;
// int max = 1000;
// int count = 0;

// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(min, max);
//     Console.WriteLine( array[i]);
//     break;
// }

// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] % 2 == 0)
//     count = array[i] + count;
//     count++;
//     Console.WriteLine(count);
//     break;
// }

