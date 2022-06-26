/*Напишите программу, которая принимает на вход три числа и выдаёт 
максимальное из этих чисел*/

Console.WriteLine("Введите первое целое число ");
int nubmerA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = nubmerA;
if (max < numberB) max = numberB;
if (max < numberC) max = numberC;
Console.Write ("max = ");
Console.WriteLine (max);