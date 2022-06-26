/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число
большее, а какое меньшее */

Console.WriteLine("Введите первое целое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB) Console.WriteLine($"{numberA} - большее число, {numberB} - меньшее число");
else if(numberA < numberB) Console.WriteLine($"{numberA} - меньшее число, {numberB} - большее число");
else if(numberA == numberB) Console.WriteLine("Числа равны");