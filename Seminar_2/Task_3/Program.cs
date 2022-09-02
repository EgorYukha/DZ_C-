// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if(dayNumber == 6 | dayNumber == 7)
{
    Console.WriteLine("Этот день выходной.");
}
if(dayNumber < 1 | dayNumber > 7)
{
    Console.WriteLine("Это не день недели.");
}
else
{
    Console.WriteLine("Этот день не выходной.");
}
