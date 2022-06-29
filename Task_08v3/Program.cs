/* Напишите программу, которая принимает на вход число (N),
а на выходе показывает все чётные числа от 1 до N
Вариант1 */
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
for (int i = 1; i <= number; i++)
{
    if (i%2 ==0)
    {
        Console.Write(i+ " ");
    }
}
Console.WriteLine();