// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, 
// которые являются делителями этого числа. (для получения цифр числа операцию 
// приведения числа к строке не использовать)

Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (num > 0)
{
    int digit = num % 10;
    if(num % 2 == 0)
    sum = sum + digit;
    num = num / 10;
    
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);

