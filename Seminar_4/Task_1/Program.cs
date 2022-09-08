//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B. Не использовать функцию Math.Pow()

Console.WriteLine("Введите первое число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

//ver.1. 
//int degree = Convert.ToInt32(Math.Pow(num1, num2));
//Console.WriteLine(degree);

//ver.2.
//Console.WriteLine($"{num1} в степени {num2} = " + Math.Pow(num1, num2));

int degree = num1;

for (int i = 1; i < num2; i++)
{
degree = degree * num1;
}
Console.WriteLine($"{num1} в степени {num2} = "  + degree);
