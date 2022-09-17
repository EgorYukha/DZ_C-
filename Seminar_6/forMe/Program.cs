﻿//Задача 1
//Напишите программу, которая перевернет одномерный целочисленный массив
// ( первый элемент на последнем месте, послений - на первом)

int[] arr = new int[] { 1, 2, 3, 4, 5 };

// 1 2 3 4 5
// arr[0] <=> arr[N - 1]
// arr[1] <=> arr[N - 2]
// arr[2] <=> arr[N - 3]

for(int i = 0; i < arr.Length / 2; i++)
{
    int tmp = arr[i];
    arr[i] = arr[arr.Length - (i+1)];
    arr[arr.Length - (i+1)] = tmp;
}
Console.WriteLine();


// Задача 2. 
// Напишите программу, которая будет преобразовывать десятичное число в двоечное.
// Пример:
// 45 -> 101101
// 3 -> 11

// x = Math.Round(x, 3);
// y = Math.Round(y, 3);      // округление