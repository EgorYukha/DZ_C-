// Задача 1: Программа запрашивает натуральное число M, пользователь вводит с клавиатуры 
// M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введи количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

void InputNumbers(int m)
{
for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int counting(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено больше 0 чисел: {counting(array)} ");