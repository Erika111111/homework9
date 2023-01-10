/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Введите число N: ");
int num = int.Parse(Console.ReadLine());

string SumNum(int a)
{
    if (a == 1)
    return a.ToString();
    else
    {
        return SumNum(a - 1) + " , " + a;
    }
}
Console.WriteLine(SumNum(num));