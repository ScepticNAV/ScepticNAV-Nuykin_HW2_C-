/* Задача 15 (с использованием "Switch"): Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите число дня недели, который хотите проверить на выходной");
int DayNumber = Convert.ToInt32(Console.ReadLine());
switch (DayNumber)
{
    case 1:
        {
            System.Console.WriteLine("Нет");
            break;
        }
    case 2:
        {
            System.Console.WriteLine("Нет");
            break;
        }
    case 3:
        {
            System.Console.WriteLine("Нет");
            break;
        }
    case 4:
        {
            System.Console.WriteLine("Нет");
            break;
        }
    case 5:
        {
            System.Console.WriteLine("Нет");
            break;
        }
    case 6:
        {
            System.Console.WriteLine("Да");
            break;
        }
    case 7:
        {
            System.Console.WriteLine("Да");
            break;
        }
    default:
        {
            System.Console.WriteLine("В неделе 7 дней, введите число от 1 до 7");
            break;
        }
}
