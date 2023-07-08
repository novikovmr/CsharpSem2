/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();

Console.Write ("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 5 && n < 8) Console.WriteLine("Да");
else if (n < 6) Console.WriteLine("Нет");
else Console.WriteLine("Такого дня нет");

