/* Задача 15 (С использованием "Random"): Напишите программу, которая проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int DayNumber = new Random().Next(1,8);
Console.WriteLine($"Сгенерированное число: {DayNumber}");

if (DayNumber > 5)
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("Нет");
}
