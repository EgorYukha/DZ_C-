//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.

Console.Write("Введите x1: ");
int dig1 = Convert.ToInt32(Console.ReadLine());
double x1 = Convert.ToDouble(dig1);

Console.Write("Введите y1: ");
int dig2 = Convert.ToInt32(Console.ReadLine());
double y1 = Convert.ToDouble(dig2);

Console.Write("Введите z1: ");
int dig3 = Convert.ToInt32(Console.ReadLine());
double z1 = Convert.ToDouble(dig3);

Console.Write("Введите x2: ");
int num1 = Convert.ToInt32(Console.ReadLine());
double x2 = Convert.ToDouble(num1);

Console.Write("Введите y2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
double y2 = Convert.ToDouble(num2);

Console.Write("Введите z2: ");
int num3 = Convert.ToInt32(Console.ReadLine());
double z2 = Convert.ToDouble(num3);

double Coordinate = Math.Sqrt(Math.Pow((x2-x1), 2) + 
Math.Pow((y2-y1), 2) + 
Math.Pow((z2-z1), 2));

Console.WriteLine ($"Длина отрезка: {Coordinate}");




