/* Напишите программу, которая принимает на вход число (N),
а на выходе показывает все чётные числа от 1 до N 
Вариант 2 */

Console.WriteLine ("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    int count = 0;
    while(count >= number)
    {
        Console.Write(count + "  ");
        count = count - 2;
    }
}
else
{
    int count = 2;
    while(count <= number)
    {
        Console.Write(count + "  ");
        count = count +2;
    }
}
Console.WriteLine();