/* Напишите программу, которая принимает на вход число (N),
а на выходе показывает все чётные числа от 1 до N
Вариант1 */

Console.WriteLine ("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= number)
{
    Console.Write(count + "  ");
    count = count + 2;
}
Console.WriteLine();