// Задача 3: * Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Если кол-во 
// элементов нечетное, то элемент посередине не учитывать.
// Результат сложения вывести на экран.
// 1, 3, 8, 3, 2 -> 11
// 8, 3, 4, 2 -> 28

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + ", ");
}
Console.WriteLine("");
int result = 1;
//int sum = 0;
//int last = array.Last();
//int first = array.First();
for (int i = 0; i < array.Length; i++)
{
    result = array[i] * array[^1];
}
Console.WriteLine("произвед " + result);

// int[] numbers = { 1, 2, 3, 4, 5 };
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = numbers[i] * 2;
//     Console.WriteLine(numbers[i]);
// }