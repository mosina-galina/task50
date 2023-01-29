//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите номер строки ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите номер столбца ");
int n = int.Parse(Console.ReadLine() ?? "");
int row = new Random().Next(1,5);;
int col = new Random().Next(1,5);;
int[,] array = new int[row,col];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
    array[i,j] = new Random().Next(1,100);
    Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
if ((m<=row)&(n<=col))
{
    Console.WriteLine($"{array[m-1,n-1]}");
}
else
{
    Console.WriteLine("Такого числа нет");
}