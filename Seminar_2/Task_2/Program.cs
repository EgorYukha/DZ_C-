//Задача 2: Напишите программу, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) или сообщает, что третьей цифры нет.

int rand = new Random().Next(1, 65536);
Console.WriteLine("Случайное число: " + rand);
string str = rand.ToString();
if(rand > 99)
{
Console.WriteLine("Третья цифра слева: " + str[2]);
}
else
{
    Console.WriteLine("такой цифры нет");
}
