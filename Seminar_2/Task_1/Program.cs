// Задача 1: Напишите программу, которая принимает на вход случайно сгенерированное трёхзначное число и на выходе показывает вторую цифру этого числа.

int rand = new Random().Next(100, 999);
Console.WriteLine(rand);
int digit_second = (rand % 100) / 10;
Console.WriteLine(digit_second);
