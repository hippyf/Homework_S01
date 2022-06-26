//На ввод рост трех спортсменов. Расположить их от большего к меньшему.
Console.WriteLine("Введите рост первого спортсмена");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рост второго спортсмена");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рост третьего спортсмена");
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA < numberB && numberA < numberC)
{
    Console.Write($"{numberA}, ");
    Console.Write($"{Math.Min(numberB,numberC)}, ");
    Console.Write(Math.Max(numberB,numberC));
}
else if(numberB < numberA && numberB < numberC)
{
    Console.Write($"{numberB}, ");
    Console.Write($"{Math.Min(numberA,numberC)}, ");
    Console.Write(Math.Max(numberA,numberC));
}
else 
{
    Console.Write($"{numberC}, ");
    Console.Write($"{Math.Min(numberA,numberB)}, ");
    Console.Write(Math.Max(numberA,numberB));
}
Console.WriteLine();