/*Даны два числа a и b, a меньше b. 
Вывести на экран сколько раз число a поместится в числе b. */

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число, оно должно быть больше первого");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (numberA < numberB) 
{
    result = result + numberB / numberA;
    Console.WriteLine($"{result} - столько раз число {numberA} поместится в числе {numberB}");
}
else
{
    Console.WriteLine("Вы ввели неверные числа!");
}