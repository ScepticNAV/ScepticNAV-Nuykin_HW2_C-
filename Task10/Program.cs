﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8 
918 -> 1 */

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (((num <= 99) | (num >= 1000)) & ((num >= -99) | (num <= -1000)))  // К сожалению, пока не знаком с синтаксисом C#, не знаю как сократить эту запись 
    {
        Console.WriteLine("Вы ввели не трехзначное число.");
    }

else
    {
        int result = (num / 10) % 10;
        
            if (result < 0)                                           // Без этого условия при вводе отрицательного числа, например -123, выводится -2. Скорее всего нужно указать тип данных result, как мн-во натуральных чисел, но я не знаю как
                {   
                result = result * (-1);    
                }

    Console.WriteLine($"Вторая цифра в числе равна: {result}");
    }




