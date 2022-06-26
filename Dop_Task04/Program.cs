//Дано N секунд. Вывести время в формате часы:минуты:секунды
Console.WriteLine("Введите количество секунд");
int number = Convert.ToInt32(Console.ReadLine());
int hour = number/60/60;
int min = (number-(hour*60*60))/60;
Console.Write($"{hour}:");
Console.Write($"{min}:");
Console.Write($"{number-(hour*60*60+min*60)}");
Console.WriteLine();