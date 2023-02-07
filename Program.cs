// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int[,] num = new int[4, 4];
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {

        num[i, j] = new Random().Next(1, 10);
        Console.Write($"   {num[i, j]}");
    }
    Console.WriteLine();
}
int count=0;
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        if (N == num[i, j])
        {
           count++;
        }
    }
}
if (count!=0)
{
    Console.WriteLine($"{N} -> такое чило есть в массиве");
}
else
{
    Console.WriteLine($"{N} -> такого чила нет в массиве");
}