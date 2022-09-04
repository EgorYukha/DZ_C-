// Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу
// кубов чисел от 1 до N. Полученный массив вывести на экран.

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
int index = 0;
int num = 1;
while( index < n)
{
    array[index] = num * num * num;
    Console.WriteLine(array[index] + " ");
    index++;
    num++;
}
