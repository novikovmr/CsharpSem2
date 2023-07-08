/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();

int f(int n)
{
    int n2 = (n / 10) % 10;
    return n2;
}

int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(x));