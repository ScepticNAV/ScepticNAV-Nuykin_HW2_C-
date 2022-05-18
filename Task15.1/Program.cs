/* Задача 15 (с вводом числа пользователем): Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите число дня недели, который хотите проверить");
int DayNumber = Convert.ToInt32(Console.ReadLine());

if ((DayNumber == 6) | (DayNumber == 7))
{
    Console.WriteLine("Да");
}

else
{
    if ((DayNumber > 0) && (DayNumber < 6))
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("В неделе всего 7 дней. Введите число от 1 до 7");
    }
}
