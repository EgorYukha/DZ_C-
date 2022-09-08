//1.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
//2.
int countOfDigits = 0;
int tmp = num;
while(tmp != 0)
{
    tmp = tmp / 10;
    countOfDigits++;
}
// countOfDigits = num.Tostring().Lenght;
//3.
int[] array;
array = new int [countOfDigits];

//4.
int i = 0;
tmp = num;
while(tmp != 0)
{
    array[i] = tmp % 10;
    tmp /= 10;
    i++;
}
//5.
Console.WriteLine();