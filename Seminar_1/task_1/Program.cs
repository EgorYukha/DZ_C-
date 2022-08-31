Console.WriteLine("Введите первое число: " );
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: " );
int num_2 = Convert.ToInt32(Console.ReadLine());
if(num_1 > num_2)
{
    Console.WriteLine("Большее число: " + num_1);
}
else
{
    Console.WriteLine("Большее число: " + num_2);
}
