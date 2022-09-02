//Напишите программу, которая принимает на вход случайно сгенерированное число (от 1 до 1 000 000) и проверяет, кратно ли оно одновременно 7 и 23.
int start = 1;
int stop = 1000000;
int rand = new Random().Next(start, stop);
//int rand = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rand);
if(rand % 7 == 0)
{
    Console.WriteLine("Число кратное 7.");
}
else
{
    Console.WriteLine("Условие не выполняется. Не кратное 7.");
}
if(rand % 23 == 0)
{
    Console.WriteLine("Число кратное 23.");
}
else
{
    Console.WriteLine("Условие не выполняется. Не кратное 23.");
}
