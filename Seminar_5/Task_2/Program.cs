// Задача 2: 
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).
// [3, 7, 23, 12] -> 12
// [4, 6, 8, 1, 4] -> 6


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

FillArrayRandomNumbers(array);
Console.WriteLine("Наш массив: ");
PrintArray(array);
int sum = 0;

for (int i = 1; i < array.Length; i+=2)
{
    if(array[i] % 2 == 0)
    sum = sum + array[i];
}
Console.WriteLine($"Всего {array.Length} чисел, сумма четных элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}