/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int m = 4;
int n = 8;

int Element (int m, int n)
{
    if (n == 1)
        return m;
    else return n + Element(m,n - 1);
}
Console.WriteLine(Element(m,n));