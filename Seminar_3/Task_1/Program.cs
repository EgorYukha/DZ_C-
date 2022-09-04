//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число:  ");
int num = Convert.ToInt32(Console.ReadLine());
int dig1 = num / 10000;
int dig2 = (num / 1000) % 10;
int dig4 = (num / 10) % 10;
int dig5 = num % 10;

if(dig1 == dig5 && dig2 == dig4)
{
    Console.WriteLine($"Число {num} является палиндромом.");
}
if(num < 10000 || num > 99999)
{
    Console.WriteLine("Введено некорректное число.");
}
else
{
    Console.WriteLine($"Число {num} НЕ является палиндромом.");
}
