//Пользователь вводит число N (N > 1). Программа должна вывести N единиц на экран.
Console.WriteLine("Введите целое число больше 0");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
if(number > 0)
{
    while(count <= number)
    {
        Console.Write("1, ");
        count++;
    }
}
else 
{
    Console.Write("Введено неверное число!");
}
Console.WriteLine();