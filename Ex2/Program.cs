/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
int f (int x)
{
    int result = 0;
    if (x >= 100)
    {
        while (x > 999 )
        {
            x = x / 10;
        }
        result = x % 10;
    }
    return result;
}
if (f(n) > 0) Console.WriteLine(f(n));
else Console.WriteLine("Третьей цифры нет");
