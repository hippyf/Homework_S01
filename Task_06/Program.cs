/* Напишите программу, которая принимает на вход число и выдаёт,
является ли число чётным */

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2 == 0)
Console.WriteLine($"{number} - чётное число");
else Console.WriteLine($"{number} - нечётное число");