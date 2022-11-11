/*Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/



int number = 8;
 void CountNumbers (int number)
 {
    if (number <= 1)
        number.ToString();
    if(number == 0) return;
        Console.Write("{0} ", number);
        CountNumbers(number - 1);
 }
 CountNumbers(number);